Option Strict On
Option Explicit On
Imports Budget.modGLobal

Public Class ctlTransaction

#Region "Variables"
    Private _booIsSelected As Boolean
#End Region

#Region "Properties"
    Public Property txtGUID As String
    Public Property booIsDeleted As Boolean
    Public Property txtFromAccountID As String
    Public Property txtToAccountID As String
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
#End Region

#Region "Objects"

#End Region

#Region "Constructors"

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="dtAccounts"></param>
    ''' <param name="dtTransactionTypes"></param>
    ''' <param name="GloballyUniqueID"></param>
    ''' <param name="IsDeleted"></param>
    ''' <param name="TransactionDate"></param>
    ''' <param name="Amount"></param>
    ''' <param name="FromAccountID"></param>
    ''' <param name="ToAccountID"></param>
    ''' <param name="TransactionType"></param>
    ''' <param name="IsCompleted"></param>
    Public Sub New(dtAccounts As DataTable, dtTransactionTypes As DataTable, GloballyUniqueID As String, IsDeleted As Boolean, TransactionDate As Date, Amount As Decimal, FromAccountID As String, ToAccountID As String, TransactionType As String, IsCompleted As Boolean)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        For Each drAccount As DataRow In dtAccounts.Rows
            cmbFromAccount.Items.Add(drAccount.Item(modGLobal.Accounts.txtAccountName.ToString))
            cmbToAccount.Items.Add(drAccount.Item(modGLobal.Accounts.txtAccountName.ToString))
        Next drAccount

        For Each drTransactionType As DataRow In dtTransactionTypes.Rows
            cmbTransactionType.Items.Add(drTransactionType.Item("Type").ToString)
        Next drTransactionType

        txtGUID = GloballyUniqueID
        booIsDeleted = IsDeleted
        dtpDate.Value = TransactionDate
        txtAmount.Text = Amount.ToString
        cmbToAccount.Text = GetAccountNameFromID(ToAccountID)
        cmbFromAccount.Text = GetAccountNameFromID(FromAccountID)
        cmbTransactionType.Text = TransactionType
        rdbCompleted.Checked = IsCompleted

    End Sub

    Public Sub New(dtAccounts As DataTable, dtTransactionTypes As DataTable, GloballyUniqueID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each drAccount As DataRow In dtAccounts.Rows
            cmbFromAccount.Items.Add(drAccount.Item(modGLobal.Accounts.txtAccountName.ToString))
            cmbToAccount.Items.Add(drAccount.Item(modGLobal.Accounts.txtAccountName.ToString))
        Next drAccount

        For Each drTransactionType As DataRow In dtTransactionTypes.Rows
            cmbTransactionType.Items.Add(drTransactionType.Item("Type").ToString)
        Next drTransactionType

        txtGUID = GloballyUniqueID
        booIsDeleted = False
        dtpDate.Value = Now
        txtAmount.Text = "0"
        cmbToAccount.Text = ""
        cmbFromAccount.Text = ""
        cmbTransactionType.Text = ""
        rdbCompleted.Checked = False
        rdbPlanned.Checked = True

    End Sub
#End Region

#Region "Methods"

    ''' <summary>
    ''' Returns the name of the account with the provided ID.
    ''' </summary>
    ''' <param name="Accountname"></param>
    ''' <returns></returns>
    Public Function GetAccountNameFromID(AccountID As String) As String
        Dim AccountName As String = ""
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
    Public Event AnyMouseClick(TransactionID As String)
#End Region

#Region "Event Handlers"
    Private Sub cmbFromAccount_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbFromAccount.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub cmbToAccount_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbToAccount.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub cmbTransactionType_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbTransactionType.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub dtpDate_MouseClick(sender As Object, e As MouseEventArgs) Handles dtpDate.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub lblAmountHeader_MouseClick(sender As Object, e As MouseEventArgs) Handles lblAmountHeader.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub lblDateHeader_MouseClick(sender As Object, e As MouseEventArgs) Handles lblDateHeader.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub lblFromAccountHeader_MouseClick(sender As Object, e As MouseEventArgs) Handles lblFromAccountHeader.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub lblToAccountHeader_MouseClick(sender As Object, e As MouseEventArgs) Handles lblToAccountHeader.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub lblTransactionTypeHeader_MouseClick(sender As Object, e As MouseEventArgs) Handles lblTransactionTypeHeader.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub rdbCompleted_MouseClick(sender As Object, e As MouseEventArgs) Handles rdbCompleted.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub rdbPlanned_MouseClick(sender As Object, e As MouseEventArgs) Handles rdbPlanned.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub tlpMain_MouseClick(sender As Object, e As MouseEventArgs) Handles tlpMain.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub

    Private Sub txtAmount_MouseClick(sender As Object, e As MouseEventArgs) Handles txtAmount.MouseClick
        RaiseEvent AnyMouseClick(txtGUID)
    End Sub


#End Region


End Class
