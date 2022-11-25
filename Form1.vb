Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports Budget.modGLobal

Public Class Form1

#Region "Variables"
    Private _SelectedAccountGUID As String
    Private _SelectedTransactionID As String
#End Region

#Region "DataTables"
    Dim dtAccounts As New DataTable
    Dim dtTransactions As New DataTable

    Dim dtAccountTypes As New DataTable
    Dim dtTransactionTypes As New DataTable
    Dim dtDailyBalances As New DataTable
#End Region

#Region "Enumerations"
    'See also the module StructsEnumsVariables

#End Region

#Region "Structures"
    'See also the module StructsEnumsVariables

#End Region

#Region "Properties"
    ''' <summary>
    ''' Indicates which account on Form1 is currently selected, and can cause the transaction list to be filtered by selected account.
    ''' </summary>
    ''' <returns></returns>
    Public Property SelectedAccountGUID As String
        Get
            Return _SelectedAccountGUID
        End Get
        Set(value As String)
            _SelectedAccountGUID = value
            If chkFilterBySelectedAccount.Checked Then
                PopulateTransactionsFrameFromDataTable(dtTransactions, dtpFromDate.Value, dtpToDate.Value, _SelectedAccountGUID)
            End If
        End Set
    End Property

    Public Property SelectedTransactionID As String
        Get
            Return _SelectedTransactionID
        End Get
        Set(value As String)

        End Set
    End Property


#End Region

#Region "Constructors"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        flpAccounts.Controls.Clear()
        flpTransactions.Controls.Clear()
        With dtAccountTypes
            .Columns.Add("Type")
            Dim drType1 As DataRow = .NewRow
            drType1.Item("Type") = AccountTypes.Savings
            .Rows.Add(drType1)
            Dim drType2 As DataRow = .NewRow
            drType2.Item("Type") = AccountTypes.Cash
            .Rows.Add(drType2)
            Dim drType3 As DataRow = .NewRow
            drType3.Item("Type") = AccountTypes.Expense
            .Rows.Add(drType3)
            Dim drType4 As DataRow = .NewRow
            drType4.Item("Type") = AccountTypes.Income
            .Rows.Add(drType4)
            Dim drType5 As DataRow = .NewRow
            drType5.Item("Type") = AccountTypes.Debt
            .Rows.Add(drType5)
        End With
        With dtTransactionTypes
            .Columns.Add("Type")
            Dim drType6 As DataRow = .NewRow
            drType6.Item("Type") = TransactionTypes.Save
            .Rows.Add(drType6)
            Dim drType7 As DataRow = .NewRow
            drType7.Item("Type") = TransactionTypes.Payoff
            .Rows.Add(drType7)
            Dim drType8 As DataRow = .NewRow
            drType8.Item("Type") = TransactionTypes.Liquidate
            .Rows.Add(drType8)
            Dim drType9 As DataRow = .NewRow
            drType9.Item("Type") = TransactionTypes.Earn
            .Rows.Add(drType9)
            'Dim drType10 As DataRow = .NewRow
            'drType10.Item("Type") = TransactionTypes.Reallocate
            '.Rows.Add(drType10)
            Dim drType11 As DataRow = .NewRow
            drType11.Item("Type") = TransactionTypes.Spend_Cash
            .Rows.Add(drType11)
            Dim drType12 As DataRow = .NewRow
            drType12.Item("Type") = TransactionTypes.Spend_on_Credit
            .Rows.Add(drType12)
            Dim drType13 As DataRow = .NewRow
            drType13.Item("Type") = TransactionTypes.Borrow_Cash
            .Rows.Add(drType13)
        End With

        Dim SQLiteServer As New clsSQLiteConnection
        SQLiteServer.CreateSQLiteDatabase()

        dtAccounts = LoadAccountsFromDBIntoDataTable()
        dtTransactions = LoadTransactionsFromDBIntoDataTable()
        PopulateAccountsFrameFromDataTable(dtAccounts)
        dtpFromDate.Value = Now.AddMonths(-2)
        dtpToDate.Value = Now
        SelectedAccountGUID = "None"
        PopulateTransactionsFrameFromDataTable(dtTransactions, dtpFromDate.Value, dtpToDate.Value, SelectedAccountGUID)
        For Each AccountControl As ctlAccount In flpAccounts.Controls
            With AccountControl
                .lblProjectedBalance.Text = (.CalculateProjectedAccountBalance(.txtGUID, .dtpProjectedBalanceDate.Value, CDec(.txtStartingBalance.Text), .dtpStartingBalanceDate.Value)).ToString
                .lblCurrentBalance.Text = (.CalculateActualAccountBalance(.txtGUID, Now, CDec(.txtStartingBalance.Text), .dtpStartingBalanceDate.Value)).ToString
            End With
        Next

    End Sub
#End Region


#Region "Methods"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Private Function LoadAccountsFromDBIntoDataTable() As DataTable
        Dim dtAccountsFromDB As New DataTable
        Dim SQLiteConnection As New clsSQLiteConnection
        SQLiteConnection.PopulateADataTable(dtAccountsFromDB, "Accounts")
        Return dtAccountsFromDB
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Private Function LoadTransactionsFromDBIntoDataTable() As DataTable
        Dim dtTransactionsFromDB As New DataTable
        Dim SQLiteConnection As New clsSQLiteConnection
        SQLiteConnection.PopulateADataTable(dtTransactionsFromDB, "Transactions")
        Return dtTransactionsFromDB
    End Function
    ''' <summary>
    ''' Uses the parameters given to add a new transaction to dtAccountssData
    ''' </summary>
    ''' <param name="dtAccountsData"></param>
    Private Sub AddAnAccountToDataTable(ByRef dtAccountsData As DataTable, AccountName As String, AccountType As String, StartingBalance As Decimal, StartingBalanceDate As Date, Optional ParentAccountID As String = "None")
        Dim NewRecord As DataRow = dtAccountsData.NewRow
        Dim NewGUID As String
        Dim SQLiteConnection As New clsSQLiteConnection
        NewGUID = SQLiteConnection.CreateGUID

        With NewRecord
            .Item(modGLobal.Accounts.booIsDeleted.ToString) = False
            .Item(modGLobal.Accounts.txtGUID.ToString) = NewGUID
            .Item(modGLobal.Accounts.datRecordCreated.ToString) = Now
            .Item(modGLobal.Accounts.txtAccountName.ToString) = AccountName
            .Item(modGLobal.Accounts.txtAccountType.ToString) = AccountType
            .Item(modGLobal.Accounts.decStartingBalance.ToString) = StartingBalance
            .Item(modGLobal.Accounts.datDateOfStartingBalance.ToString) = StartingBalanceDate
            .Item(modGLobal.Accounts.txtSubAccountToAccountID.ToString) = ParentAccountID
        End With
        dtAccountsData.Rows.Add(NewRecord)
    End Sub
    ''' <summary>
    ''' Uses the parameters given to add a new transaction to dtTransactionsData
    ''' </summary>
    ''' <param name="dtTransactionsData"></param>
    Private Sub AddATransactionToDataTable(ByRef dtTransactionsData As DataTable, TransactionID As String, FromAccountID As String, ToAccountID As String, Amount As Decimal, TransactionDate As Date, TransactionType As String, TransactionIsCompleted As Boolean)
        Dim NewRecord As DataRow = dtTransactionsData.NewRow
        With NewRecord
            .Item(modGlobal.Transactions.txtGUID.ToString) = TransactionID
            .Item(modGlobal.Transactions.txtFromAccountID.ToString) = FromAccountID
            .Item(modGlobal.Transactions.txtToAccountID.ToString) = ToAccountID
            .Item(modGlobal.Transactions.decAmount.ToString) = Amount
            .Item(modGlobal.Transactions.datTransactionDate.ToString) = TransactionDate
            .Item(modGlobal.Transactions.txtTransactionType.ToString) = TransactionType
            .Item(modGlobal.Transactions.booIsCompleted.ToString) = TransactionIsCompleted
            .Item(modGlobal.Transactions.booIsDeleted.ToString) = False
            .Item(modGlobal.Transactions.datRecordCreated.ToString) = Now

        End With
        dtTransactionsData.Rows.Add(NewRecord)
    End Sub
    ''' <summary>
    ''' Updates dtAccountData with dta the user entered into the form.
    ''' </summary>
    ''' <param name="dtAccountsData"></param>
    Private Function UpdateAccountsDataTableFromForm(ByRef dtAccountsData As DataTable) As Boolean
        Try
            'First, add accounts that are listed on the form but are not in the datatable
            For Each AccountControl As ctlAccount In flpAccounts.Controls
                If Not ValidateAccountDataInControl(AccountControl) Then
                    Return False
                End If
                Dim AccountInDataTable As Boolean = False
                For Each AccountRecord As DataRow In dtAccountsData.Rows
                    If AccountControl.txtGUID = (AccountRecord.Item(modGLobal.Accounts.txtGUID.ToString)).ToString Then
                        AccountInDataTable = True
                    End If
                    If AccountControl.txtAccountName.Text = (AccountRecord.Item(modGLobal.Accounts.txtAccountName.ToString)).ToString Then
                        AccountInDataTable = True
                    End If
                Next
                If Not AccountInDataTable Then
                    AddAnAccountToDataTable(dtAccountsData, AccountControl.txtAccountName.Text, AccountControl.cmbAccountType.Text, CDec(AccountControl.txtStartingBalance.Text), AccountControl.dtpStartingBalanceDate.Value)
                End If
            Next

            For Each AccountControl As ctlAccount In flpAccounts.Controls
                For Each AccountRecord As DataRow In dtAccountsData.Rows
                    If AccountControl.txtGUID = (AccountRecord.Item(modGLobal.Accounts.txtGUID.ToString)).ToString Then
                        With AccountRecord
                            .Item(modGLobal.Accounts.txtAccountName.ToString) = AccountControl.txtAccountName.Text
                            .Item(modGLobal.Accounts.txtAccountType.ToString) = AccountControl.cmbAccountType.Text
                            .Item(modGLobal.Accounts.txtSubAccountToAccountID.ToString) = AccountControl.GetAccountIDFromName(AccountControl.cmbParentAccount.Text)
                            .Item(modGLobal.Accounts.datDateOfStartingBalance.ToString) = AccountControl.dtpStartingBalanceDate.Value
                            .Item(modGLobal.Accounts.decStartingBalance.ToString) = CDec(AccountControl.txtStartingBalance.Text)
                        End With
                        Exit For
                    End If
                Next
            Next
        Catch ex As Exception
            MessageBox.Show("Error in Form1.UpdateAccountsDataTableFromForm. Error is " & ex.Message)
            Return False
        End Try
        Return True
    End Function
    ''' <summary>
    ''' Updates existing records in the datatable. Does not add new records.
    ''' </summary>
    ''' ''' <param name="dtTransactionsData"></param>
    Private Function UpdateTransactionsDataTableFromForm(ByRef dtTransactionsData As DataTable) As Boolean
        Try

            'First, add Transactions that are listed on the form but are not in the datatable
            For Each TransactionControl As ctlTransaction In flpTransactions.Controls
                With TransactionControl
                    If Not ValidatetransactionDataInControl(TransactionControl) Then
                        Return False
                    End If
                    Dim TransactionInDataTable As Boolean = False
                    For Each TransactionRecord As DataRow In dtTransactionsData.Rows
                        If .txtGUID = (TransactionRecord.Item(modGLobal.Transactions.txtGUID.ToString)).ToString Then
                            TransactionInDataTable = True
                        End If
                    Next
                    If Not TransactionInDataTable Then
                        If .txtGUID = "" Then
                            Dim SQLiteConnection As New clsSQLiteConnection
                            .txtGUID = SQLiteConnection.CreateGUID
                        End If
                        AddATransactionToDataTable(dtTransactionsData, .txtGUID, .txtFromAccountID, .txtToAccountID, CDec(.txtAmount.Text), .dtpDate.Value, .cmbTransactionType.Text, .rdbCompleted.Checked)
                    End If
                End With
            Next

            For Each TransactionControl As ctlTransaction In flpTransactions.Controls
                For Each TransactionRecord As DataRow In dtTransactionsData.Rows
                    If TransactionControl.txtGUID = (TransactionRecord.Item(modGLobal.Transactions.txtGUID.ToString)).ToString Then
                        With TransactionRecord
                            .Item(modGLobal.Transactions.txtTransactionType) = TransactionControl.cmbTransactionType.Text
                            .Item(modGLobal.Transactions.datTransactionDate) = TransactionControl.dtpDate.Value
                            .Item(modGLobal.Transactions.txtToAccountID) = TransactionControl.GetAccountIDFromName(TransactionControl.cmbToAccount.Text)
                            .Item(modGLobal.Transactions.txtFromAccountID) = TransactionControl.GetAccountIDFromName(TransactionControl.cmbFromAccount.Text)
                            .Item(modGLobal.Transactions.booIsCompleted) = TransactionControl.rdbCompleted.Checked
                            .Item(modGLobal.Transactions.decAmount) = CDec(TransactionControl.txtAmount.Text)
                        End With
                        Exit For
                    End If
                Next
            Next
        Catch ex As Exception
            MessageBox.Show("Error in Form1.UpdateTransactionsDataTableFromForm. Error is " & ex.Message)
            Return False
        End Try
        Return True
    End Function
    ''' <summary>
    ''' Updates the database with the data in the dtAccountsData datatable.
    ''' </summary>
    ''' <param name="dtAccountsData"></param>
    Private Function SaveAccountsDataTableToDB(dtAccountsData As DataTable) As Boolean
        Dim SQLiteConnection As New clsSQLiteConnection
        If SQLiteConnection.SaveADataTable(dtAccountsData, "Accounts") Then
            Return True
        End If
        Return False
    End Function
    ''' <summary>
    ''' Updates the database with the data in the dtTransactionssData datatable.
    ''' </summary>
    ''' <param name="dtTransactionsData"></param>
    Private Function SaveTransactionsDataTableToDB(dtTransactionsData As DataTable) As Boolean
        Dim SQLiteConnection As New clsSQLiteConnection
        If SQLiteConnection.SaveADataTable(dtTransactionsData, "Transactions") Then
            Return True
        End If
        Return False
    End Function
    ''' <summary>
    ''' Creates account controls and adds them to flpAccounts flow layout panel.
    ''' </summary>
    ''' <param name="dtAccountsData"></param>
    ''' <param name="ShowIncomeAccounts"></param>
    ''' <param name="ShowCashAccounts"></param>
    ''' <param name="ShowSavingsAccounts"></param>
    ''' <param name="ShowDebtAccounts"></param>
    ''' <param name="ShowExpenseAccounts"></param>
    Private Sub PopulateAccountsFrameFromDataTable(dtAccountsData As DataTable, Optional ShowIncomeAccounts As Boolean = True, Optional ShowCashAccounts As Boolean = True, Optional ShowSavingsAccounts As Boolean = True, Optional ShowDebtAccounts As Boolean = True, Optional ShowExpenseAccounts As Boolean = True)
        For Each AccountRecord As DataRow In dtAccountsData.Rows
            With AccountRecord
                If Not ShowIncomeAccounts Then
                    If .Item(modGLobal.Accounts.txtAccountType.ToString).ToString = modGLobal.AccountTypes.Income.ToString Then
                        Continue For
                    End If
                End If
                If Not ShowCashAccounts Then
                    If .Item(modGLobal.Accounts.txtAccountType.ToString).ToString = modGLobal.AccountTypes.Cash.ToString Then
                        Continue For
                    End If
                End If
                If Not ShowSavingsAccounts Then
                    If .Item(modGLobal.Accounts.txtAccountType.ToString).ToString = modGLobal.AccountTypes.Savings.ToString Then
                        Continue For
                    End If
                End If
                If Not ShowDebtAccounts Then
                    If .Item(modGLobal.Accounts.txtAccountType.ToString).ToString = modGLobal.AccountTypes.Debt.ToString Then
                        Continue For
                    End If
                End If
                If Not ShowExpenseAccounts Then
                    If .Item(modGLobal.Accounts.txtAccountType.ToString).ToString = modGLobal.AccountTypes.Expense.ToString Then
                        Continue For
                    End If
                End If
            End With
            Dim AccountControl As New ctlAccount(dtAccountTypes, dtAccountsData, AccountRecord.Item(modGLobal.Accounts.txtGUID.ToString).ToString, CBool(AccountRecord.Item(modGLobal.Accounts.booIsDeleted.ToString)), AccountRecord.Item(modGLobal.Accounts.txtAccountName.ToString).ToString, AccountRecord.Item(modGLobal.Accounts.txtAccountType.ToString).ToString, CDec(AccountRecord.Item(modGLobal.Accounts.decStartingBalance.ToString)), CDate(AccountRecord.Item(modGLobal.Accounts.datDateOfStartingBalance.ToString).ToString), AccountRecord.Item(modGLobal.Accounts.txtSubAccountToAccountID.ToString).ToString)
            flpAccounts.Controls.Add(AccountControl)
            AddHandler AccountControl.AnyMouseClick, Sub(AccountGUID As String)
                                                         UpdateSelectedAccountUniqueID(AccountGUID)
                                                     End Sub
        Next AccountRecord
    End Sub
    ''' <summary>
    ''' Creates transaction controls and adds them to flpTransactions flow layout panel. Filters by start and end dates.
    ''' </summary>
    ''' <param name="dtTransactionssData"></param>
    ''' <param name="datStartDate"></param>
    ''' <param name="datEndDate"></param>
    Private Sub PopulateTransactionsFrameFromDataTable(dtTransactionsData As DataTable, StartDate As Date, EndDate As Date, SelectedAccountUniqueID As String)
        For Each TransactionRecord As DataRow In dtTransactionsData.Rows
            With TransactionRecord
                If CDate(TransactionRecord.Item(modGLobal.Transactions.datTransactionDate.ToString)) >= StartDate Then
                    If CDate(TransactionRecord.Item(modGLobal.Transactions.datTransactionDate.ToString)) <= EndDate Then
                        If chkFilterBySelectedAccount.Checked And SelectedAccountUniqueID <> "None" Then
                            If TransactionRecord.Item(modGLobal.Transactions.txtGUID.ToString).ToString = SelectedAccountGUID Then
                                Dim TransactionControl As New ctlTransaction(dtAccounts, dtTransactionTypes, (.Item(modGLobal.Transactions.txtGUID)).ToString, CBool(.Item(modGLobal.Transactions.booIsDeleted.ToString)), CDate(.Item(modGLobal.Transactions.datTransactionDate.ToString)), CDec(.Item(modGLobal.Transactions.decAmount.ToString)), (.Item(modGLobal.Transactions.txtFromAccountID)).ToString, (.Item(modGLobal.Transactions.txtToAccountID).ToString), (.Item(modGLobal.Transactions.txtTransactionType.ToString)).ToString, CBool(.Item(modGLobal.Transactions.booIsCompleted.ToString)))
                                flpTransactions.Controls.Add(TransactionControl)
                            End If
                        Else
                            Dim TransactionControl As New ctlTransaction(dtAccounts, dtTransactionTypes, (.Item(modGLobal.Transactions.txtGUID)).ToString, CBool(.Item(modGLobal.Transactions.booIsDeleted.ToString)), CDate(.Item(modGLobal.Transactions.datTransactionDate.ToString)), CDec(.Item(modGLobal.Transactions.decAmount.ToString)), (.Item(modGLobal.Transactions.txtFromAccountID)).ToString, (.Item(modGLobal.Transactions.txtToAccountID).ToString), (.Item(modGLobal.Transactions.txtTransactionType.ToString)).ToString, CBool(.Item(modGLobal.Transactions.booIsCompleted.ToString)))
                            flpTransactions.Controls.Add(TransactionControl)
                        End If
                    End If
                End If
            End With
        Next TransactionRecord
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="AccountControl"></param>
    ''' <returns></returns>
    Private Function ValidateAccountDataInControl(ByRef AccountControl As ctlAccount) As Boolean
        With AccountControl
            If .txtGUID = "" Then
                Dim SQLiteConnection As New clsSQLiteConnection
                .txtGUID = SQLiteConnection.CreateGUID
            End If
            If .booIsDeleted = Nothing Then
                .booIsDeleted = False
            End If
            If .txtAccountName.Text = "" Then
                MessageBox.Show("Please enter a unique account name.")
                .txtAccountName.SelectAll()
                Return False
            End If
            If .txtStartingBalance.Text = "" Then
                .txtStartingBalance.Text = 0.ToString
            End If
            If Not IsNumeric(.txtStartingBalance.Text) Then
                MessageBox.Show("Please enter a numeric starting balance.")
                .txtStartingBalance.SelectAll()
                Return False
            End If
            If .dtpStartingBalanceDate.Value = #01/01/2022# Then
                .dtpStartingBalanceDate.Value = Now
                MessageBox.Show("Please select a date for the starting balance.")
                AccountControl.dtpStartingBalanceDate.Focus()
                Return False
            End If
            If .cmbAccountType.Text = "" Then
                MessageBox.Show("Please select the type of account.")
                .cmbAccountType.Focus()
                Return False
            End If
            Return True
        End With

    End Function

    Private Function ValidatetransactionDataInControl(ByRef TransactionControl As ctlTransaction) As Boolean
        With TransactionControl
            If .txtGUID = "" Then
                Dim SQLiteConnection As New clsSQLiteConnection
                .txtGUID = SQLiteConnection.CreateGUID
            End If
            If .booIsDeleted = Nothing Then
                .booIsDeleted = False
            End If
            If .cmbFromAccount.Text = "" Then
                MessageBox.Show("Please select the account that money is flowing out of.")
                .cmbFromAccount.SelectAll()
                Return False
            End If
            If .cmbToAccount.Text = "" Then
                MessageBox.Show("Please select the account that money is flowing into.")
                .cmbToAccount.SelectAll()
                Return False
            End If
            If Not IsNumeric(.txtAmount.Text) Then
                MessageBox.Show("Please enter a numeric value for the transaction amount.")
                .txtAmount.SelectAll()
                Return False
            End If
            If .cmbTransactionType.Text = "" Then
                MessageBox.Show("Please select the type of Transaction.")
                .cmbTransactionType.SelectAll()
                Return False
            End If
            Return True
        End With
    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="AccountName"></param>
    ''' <param name="BalanceDate"></param>
    Private Sub CalculatePlannedAccountBalance(AccountName As String, BalanceDate As Date)
        For Each drAccount As DataRow In dtAccounts.Rows
            drAccount.Item("CalculatedBalance") = drAccount.Item("StartingBalance")
            For Each drPLannedTransaction As DataRow In dtTransactions.Rows
                If drAccount.Item("AccountName").ToString = drPLannedTransaction.Item("FromAccountName").ToString Then
                    drAccount.Item("CalculatedBalance") = CDec(drAccount.Item("CalculatedBalance")) - CDec(drPLannedTransaction.Item("Amount"))
                ElseIf drAccount.Item("AccountName").ToString = drPLannedTransaction.Item("ToAccountName").ToString Then
                    drAccount.Item("CalculatedBalance") = CDec(drAccount.Item("CalculatedBalance")) + CDec(drPLannedTransaction.Item("Amount"))
                End If
            Next drPLannedTransaction
        Next drAccount
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="AccountUniqueID"></param>
    ''' <param name="BalanceDate"></param>
    ''' <param name="StartingBalance"></param>
    ''' <param name="StartingBalanceDate"></param>
    ''' <returns></returns>
    Private Function CalculateActualAccountBalance(AccountUniqueID As String, BalanceDate As Date, StartingBalance As Decimal, StartingBalanceDate As Date) As Decimal
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
    Private Function CalculateProjectedAccountBalance(AccountUniqueID As String, BalanceDate As Date, StartingBalance As Decimal, StartingBalanceDate As Date) As Decimal
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
    ''' 
    ''' </summary>
    Private Function SaveAccounts() As Boolean
        If UpdateAccountsDataTableFromForm(dtAccounts) Then
            If SaveAccountsDataTableToDB(dtAccounts) Then
                Return True
            End If
        End If
        Return False
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    Private Function SaveTransactions() As Boolean
        If UpdateTransactionsDataTableFromForm(dtTransactions) Then
            If SaveTransactionsDataTableToDB(dtTransactions) Then
                Return True
            End If
        End If
        Return False
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click

        If SaveAccounts() Then
            If SaveTransactions() Then
                MessageBox.Show("Changes have been saved.")
            End If
        End If
        For Each AccountControl As ctlAccount In flpAccounts.Controls
            With AccountControl
                .lblProjectedBalance.Text = (.CalculateProjectedAccountBalance(.txtGUID, .dtpProjectedBalanceDate.Value, CDec(.txtStartingBalance.Text), .dtpStartingBalanceDate.Value)).ToString
                .lblCurrentBalance.Text = (.CalculateActualAccountBalance(.txtGUID, Now, CDec(.txtStartingBalance.Text), .dtpStartingBalanceDate.Value)).ToString
            End With
        Next
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click
        Dim SQLiteConnecton As New clsSQLiteConnection
        Dim NewGUID As String = SQLiteConnecton.CreateGUID
        Dim AccountControl As New ctlAccount(dtAccountTypes, dtAccounts, NewGUID, False, "", modGLobal.AccountTypes.Savings.ToString, 0, #01/01/2022#)
        flpAccounts.Controls.Add(AccountControl)
        AddHandler AccountControl.AnyMouseClick, Sub()
                                                     UpdateSelectedAccountUniqueID(NewGUID)
                                                 End Sub
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkFilterBySelectedAccount_CheckedChanged(sender As Object, e As EventArgs) Handles chkFilterBySelectedAccount.CheckedChanged
        If SelectedAccountGUID = "" Then
            SelectedAccountGUID = "None"
        ElseIf SelectedAccountGUID <> "None" Then
            PopulateTransactionsFrameFromDataTable(dtTransactions, dtpFromDate.Value, dtpToDate.Value, SelectedAccountGUID)
        End If

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="NewlySelectedUniqueID"></param>
    Private Sub UpdateSelectedAccountUniqueID(NewlySelectedUniqueID As String)
        SelectedAccountGUID = NewlySelectedUniqueID
        For Each Account As ctlAccount In flpAccounts.Controls
            Account.booIsSelected = False
            If Account.txtGUID = SelectedAccountGUID Then
                Account.booIsSelected = True
            End If
        Next Account
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddTransaction_Click(sender As Object, e As EventArgs) Handles btnAddTransaction.Click
        Dim SQLiteConnecton As New clsSQLiteConnection
        Dim NewGUID As String = SQLiteConnecton.CreateGUID
        Dim TransactionControl As New ctlTransaction(dtAccounts, dtTransactionTypes, NewGUID)
        flpTransactions.Controls.Add(TransactionControl)
        AddHandler TransactionControl.AnyMouseClick, Sub()
                                                         UpdateSelectedTransactionUniqueID(NewGUID)
                                                     End Sub
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="NewlySelectedID"></param>
    Private Sub UpdateSelectedTransactionUniqueID(NewlySelectedID As String)
        SelectedTransactionID = NewlySelectedID
        For Each Transaction As ctlTransaction In flpTransactions.Controls
            Transaction.booIsSelected = False
            If Transaction.txtGUID = SelectedAccountGUID Then
                Transaction.booIsSelected = True
            End If
        Next Transaction
    End Sub

#End Region
End Class
