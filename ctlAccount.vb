Option Strict On
Option Explicit On

Public Class ctlAccount

#Region "Variables"
    Private _booIsSelected As Boolean

#End Region

#Region "Properties"
    Public Property txtGUID As String
    Public Property booIsDeleted As Boolean
    Public Property booIsSelected As Boolean
        Get
            Return _booIsSelected
        End Get
        Set(value As Boolean)
            _booIsSelected = value
            If _booIsSelected = True Then
                Me.BackColor = Color.FromArgb(20, 30, 50)
                tlpMain.BackColor = Color.FromArgb(20, 30, 50)
            Else
                Me.BackColor = Color.FromArgb(50, 50, 50)
                tlpMain.BackColor = Color.FromArgb(50, 50, 50)
            End If
        End Set
    End Property
    Public Property txtParentAccountID As String


#End Region

#Region "Objects"
    Dim IOTable As clsSingleRecordIO
#End Region

#Region "Constructors"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub
    ''' <summary>
    ''' Creates a new account control based on inputs. dtAccountTypes must include a column named "Type"
    ''' </summary>
    ''' <param name="dtAccountTypes"></param>
    ''' <param name="dtAccounts"></param>
    ''' <param name="GloballyUniqueID"></param>
    ''' <param name="IsDeleted"></param>
    ''' <param name="AccountName"></param>
    ''' <param name="AccountType"></param>
    ''' <param name="StartingBalance"></param>
    ''' <param name="StartingBalanceDate"></param>
    ''' <param name="ParentAccountID"></param>
    Public Sub New(dtAccountTypes As DataTable, dtAccounts As DataTable, GloballyUniqueID As String, IsDeleted As Boolean, AccountName As String, AccountType As String, StartingBalance As Decimal, StartingBalanceDate As Date, Optional ParentAccountID As String = "None")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        For Each drAccountType As DataRow In dtAccountTypes.Rows
            cmbAccountType.Items.Add(drAccountType.Item("Type").ToString)
        Next drAccountType

        For Each drParentAccount As DataRow In dtAccounts.Rows
            cmbParentAccount.Items.Add(drParentAccount.Item(modGLobal.Accounts.txtAccountName.ToString))
        Next drParentAccount

        txtGUID = GloballyUniqueID
        booIsDeleted = IsDeleted
        txtAccountName.Text = AccountName
        cmbAccountType.Text = AccountType
        txtStartingBalance.Text = StartingBalance.ToString
        dtpStartingBalanceDate.Value = StartingBalanceDate
        cmbParentAccount.Text = GetAccountNameFromID(ParentAccountID)
        If GetAccountNameFromID(ParentAccountID) = "None" Then
            chkVirtualAccount.Checked = False
        Else
            chkVirtualAccount.Checked = True
        End If
        If Not IsNumeric(txtStartingBalance.Text) Then
            txtStartingBalance.Text = "0"
        End If
        dtpProjectedBalanceDate.Value = Now
        lblProjectedBalance.Text = (CalculateProjectedAccountBalance(txtGUID, dtpProjectedBalanceDate.Value, CDec(txtStartingBalance.Text), dtpStartingBalanceDate.Value)).ToString
    End Sub

#End Region

#Region "Methods"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="AccountUniqueID"></param>
    ''' <param name="BalanceDate"></param>
    ''' <param name="StartingBalance"></param>
    ''' <param name="StartingBalanceDate"></param>
    ''' <returns></returns>
    Public Function CalculateActualAccountBalance(AccountUniqueID As String, BalanceDate As Date, StartingBalance As Decimal, StartingBalanceDate As Date) As Decimal
        Dim CalculatedBalance As Decimal = StartingBalance
        Dim SQLiteConnection As New clsSQLiteConnection
        Dim TransactionsFromThisAccount As New DataTable
        Dim TransactionsToThisAccount As New DataTable
        SQLiteConnection.PopulateADataTableFiltered(TransactionsFromThisAccount, "Transactions", modGlobal.Transactions.txtFromAccountID.ToString, AccountUniqueID)
        SQLiteConnection.PopulateADataTableFiltered(TransactionsToThisAccount, "Transactions", modGlobal.Transactions.txtToAccountID.ToString, AccountUniqueID)
        For Each TransactionFrom As DataRow In TransactionsFromThisAccount.Rows
            With TransactionFrom
                If CDate(.Item(modGlobal.Transactions.datTransactionDate.ToString)) >= StartingBalanceDate Then
                    If CDate(.Item(modGlobal.Transactions.datTransactionDate.ToString)) <= BalanceDate Then
                        If CBool(.Item(modGlobal.Transactions.booIsCompleted.ToString)) Then
                            CalculatedBalance = CalculatedBalance - CDec(.Item(modGlobal.Transactions.decAmount.ToString))
                        End If
                    End If
                End If
            End With
        Next
        For Each TransactionTo As DataRow In TransactionsToThisAccount.Rows
            With TransactionTo
                If CDate(.Item(modGlobal.Transactions.datTransactionDate.ToString)) >= StartingBalanceDate Then
                    If CDate(.Item(modGlobal.Transactions.datTransactionDate.ToString)) <= BalanceDate Then
                        If CBool(.Item(modGlobal.Transactions.booIsCompleted.ToString)) Then
                            CalculatedBalance = CalculatedBalance + CDec(.Item(modGlobal.Transactions.decAmount.ToString))
                        End If
                    End If
                End If
            End With
        Next
        Return CalculatedBalance
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="AccountUniqueID"></param>
    ''' <param name="BalanceDate"></param>
    ''' <param name="StartingBalance"></param>
    ''' <param name="StartingBalanceDate"></param>
    ''' <returns></returns>
    Public Function CalculateProjectedAccountBalance(AccountUniqueID As String, BalanceDate As Date, StartingBalance As Decimal, StartingBalanceDate As Date) As Decimal
        Dim CalculatedBalance As Decimal = StartingBalance
        Dim SQLiteConnection As New clsSQLiteConnection
        Dim TransactionsFromThisAccount As New DataTable
        Dim TransactionsToThisAccount As New DataTable
        SQLiteConnection.PopulateADataTableFiltered(TransactionsFromThisAccount, "Transactions", modGlobal.Transactions.txtFromAccountID.ToString, AccountUniqueID)
        SQLiteConnection.PopulateADataTableFiltered(TransactionsToThisAccount, "Transactions", modGlobal.Transactions.txtToAccountID.ToString, AccountUniqueID)
        For Each TransactionFrom As DataRow In TransactionsFromThisAccount.Rows
            With TransactionFrom
                If CDate(.Item(modGlobal.Transactions.datTransactionDate.ToString)) >= StartingBalanceDate Then
                    If CDate(.Item(modGlobal.Transactions.datTransactionDate.ToString)) <= BalanceDate Then
                        CalculatedBalance = CalculatedBalance - CDec(.Item(modGlobal.Transactions.decAmount.ToString))
                    End If
                End If
            End With
        Next
        For Each TransactionTo As DataRow In TransactionsToThisAccount.Rows
            With TransactionTo
                If CDate(.Item(modGlobal.Transactions.datTransactionDate.ToString)) >= StartingBalanceDate Then
                    If CDate(.Item(modGlobal.Transactions.datTransactionDate.ToString)) <= BalanceDate Then
                        CalculatedBalance = CalculatedBalance + CDec(.Item(modGlobal.Transactions.decAmount.ToString))
                    End If
                End If
            End With
        Next
        Return CalculatedBalance
    End Function
    ''' <summary>
    ''' Returns the name of the account with the provided ID.
    ''' </summary>
    ''' <param name="Accountname"></param>
    ''' <returns></returns>
    Public Function GetAccountNameFromID(AccountID As String) As String
        Dim AccountName As String = "None"
        Dim SQLiteConnection As New clsSQLiteConnection
        Dim dtAccounts As New DataTable
        SQLiteConnection.PopulateADataTable(dtAccounts, "Accounts")
        If dtAccounts.Rows.Count > 0 Then
            For Each dr As DataRow In dtAccounts.Rows
                If (dr.Item(modGLobal.Accounts.txtGUID.ToString)).ToString = AccountID Then
                    AccountName = (dr.Item(modGLobal.Accounts.txtAccountName.ToString)).ToString
                    Return AccountName
                End If
            Next
        End If
        Return AccountName
    End Function
    ''' <summary>
    ''' Returns the ID of the account with the provided name.
    ''' </summary>
    ''' <param name="AccountName"></param>
    ''' <returns></returns>
    Public Function GetAccountIDFromName(AccountName As String) As String
        Dim AccountID As String = ""
        Dim SQLiteConnection As New clsSQLiteConnection
        Dim dtAccounts As New DataTable
        SQLiteConnection.PopulateADataTable(dtAccounts, "Accounts")
        If dtAccounts.Rows.Count > 0 Then
            For Each dr As DataRow In dtAccounts.Rows
                If (dr.Item(modGLobal.Accounts.txtAccountName.ToString)).ToString = AccountName Then
                    AccountID = (dr.Item(modGLobal.Accounts.txtGUID.ToString)).ToString
                    Return AccountID
                End If
            Next
        End If
        Return AccountID
    End Function

#End Region


#Region "Events"
    Public Event AnyMouseClick(AccountGUID As String)
#End Region

#Region "Event Handlers"
    Private Sub lblAccountNameHeader_Click(sender As Object, e As EventArgs) Handles lblAccountNameHeader.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub lblAccountTypeHeader_Click(sender As Object, e As EventArgs) Handles lblAccountTypeHeader.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub lblParentAccountHeader_Click(sender As Object, e As EventArgs) Handles lblParentAccountHeader.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub lblCurrentBalanceHeader_Click(sender As Object, e As EventArgs) Handles lblCurrentBalanceHeader.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub lblProjectedBalanceHeader_Click(sender As Object, e As EventArgs) Handles lblProjectedBalanceHeader.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub lblProjectedBalanceDateHeader_Click(sender As Object, e As EventArgs) Handles lblProjectedBalanceDateHeader.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub lblStartingBalanceHeader_Click(sender As Object, e As EventArgs) Handles lblStartingBalanceHeader.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub lblStartingBalanceDateHeader_Click(sender As Object, e As EventArgs) Handles lblStartingBalanceDateHeader.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub lblCurrentBalance_Click(sender As Object, e As EventArgs) Handles lblCurrentBalance.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub lblProjectedBalance_Click(sender As Object, e As EventArgs) Handles lblProjectedBalance.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub


    Private Sub chkVirtualAccount_MouseClick(sender As Object, e As MouseEventArgs) Handles chkVirtualAccount.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub txtAccountName_MouseClick(sender As Object, e As MouseEventArgs) Handles txtAccountName.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub cmbAccountType_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbAccountType.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub cmbParentAccount_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbParentAccount.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub


    Private Sub dtpProjectedBalanceDate_MouseClick(sender As Object, e As MouseEventArgs) Handles dtpProjectedBalanceDate.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub dtpStartingBalanceDate_MouseClick(sender As Object, e As MouseEventArgs) Handles dtpStartingBalanceDate.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub txtStartingBalance_MouseClick(sender As Object, e As MouseEventArgs) Handles txtStartingBalance.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

#End Region




End Class
