Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports Budget.modGLobal

Public Class Form1

#Region "Variables"
    'See also the module StructsEnumsVariables

#End Region
#Region "DataTables"
    Dim dtAccounts As New DataTable
    Dim dtTransactions As New DataTable

    Dim dtAccountTypes As New DataTable
    Dim dtTransactionTypes As New DataTable
    Dim dtFromAccounts As New DataTable
    Dim dtToAccounts As New DataTable
    Dim dtDailyBalances As New DataTable
#End Region


#Region "Enumerations"
    'See also the module StructsEnumsVariables

#End Region

#Region "Structures"
    'See also the module StructsEnumsVariables

#End Region

#Region "Properties"

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
            Dim drType10 As DataRow = .NewRow
            drType10.Item("Type") = TransactionTypes.Reallocate
            .Rows.Add(drType10)
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
        'SQLiteServer.AddDefaultsToDatabase()

        'GetAccounts()
        ''MessageBox.Show(dtFromAccounts.Rows.Count.ToString)
        'GetPlannedTransactions()
        'GetActualTransactions()
        'CalculateCurrentAccountBalances()
        'ConfigureAccountsDataGridView()
        'ConfigureActualTransactionsDataGridView()
        'ConfigurePlannedTransactionsDataGridView()
        'ConfigureAccountsPlannedDataGridView()

        'PopulateAccountNameComboBoxes()
        'PopulateFilteredTransactions()
        'PopulateTransactionTypeComboBoxes()
        'PopulateAccountTypeComboBox()

        'Dim dtAccounts As New DataTable
        'SQLiteServer.PopulateADataTable(dtAccounts, "Account")
        'Dim Accounts As New List(Of String)
        'For Each dr As DataRow In dtAccounts.Rows
        '    Accounts.Add(dr.Item(modGLobal.Account.txtAccountName.ToString).ToString)
        'Next

        'Dim TransactionControl As New ctlTransaction(SQLiteServer.CreateGUID(), Accounts)
        'TabPage4.Controls.Add(TransactionControl)

        dtAccounts = LoadAccountsFromDBIntoDataTable()
        dtTransactions = LoadTransactionsFromDBIntoDataTable()
        PopulateAccountsFrameFromDataTable(dtAccounts)
        PopulateTransactionsFrameFromDataTable(dtTransactions, Now.AddMonths(-22), Now)


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
    Private Sub AddAnAccountToDataTable(ByRef dtAccountsData As DataTable, AccountName As String, AccountType As String, StartingBalance As Decimal, StartingBalanceDate As Date, Optional ParentAccountName As String = "None")
        Dim NewRecord As DataRow = dtAccountsData.NewRow
        With NewRecord
            .Item(modGLobal.Accounts.txtAccountName.ToString) = AccountName
            .Item(modGLobal.Accounts.txtAccountType.ToString) = AccountType
            .Item(modGLobal.Accounts.decStartingBalance.ToString) = StartingBalance
            .Item(modGLobal.Accounts.datDateOfStartingBalance.ToString) = StartingBalanceDate
            .Item(modGLobal.Accounts.txtSubAccountToAccountName.ToString) = ParentAccountName
        End With
    End Sub
    ''' <summary>
    ''' Uses the parameters given to add a new transaction to dtTransactionsData
    ''' </summary>
    ''' <param name="dtTransactionsData"></param>
    Private Sub AddATransactionToDataTable(ByRef dtTransactionsData As DataTable, FromAccountName As String, ToAccountName As String, Amount As Decimal, TransactionDate As Date, TransactionType As modGLobal.TransactionTypes, TransactionIsCompleted As Boolean)
        Dim NewRecord As DataRow = dtTransactionsData.NewRow
        With NewRecord
            .Item(modGLobal.Transactions.txtFromAccount.ToString) = FromAccountName
            .Item(modGLobal.Transactions.txtFromAccount.ToString) = ToAccountName
            .Item(modGLobal.Transactions.txtFromAccount.ToString) = Amount
            .Item(modGLobal.Transactions.txtFromAccount.ToString) = TransactionDate
            .Item(modGLobal.Transactions.txtFromAccount.ToString) = TransactionType
            .Item(modGLobal.Transactions.txtFromAccount.ToString) = TransactionIsCompleted
        End With
    End Sub
    ''' <summary>
    ''' Updates existing records in the datatable. Does not add new records.
    ''' </summary>
    ''' <param name="dtAccountsData"></param>
    Private Sub UpdateAccountsDataTableFromForm(ByRef dtAccountsData As DataTable)
        For Each AccountControl As ctlAccount In flpAccounts.Controls
            For Each AccountRecord As DataRow In dtAccountsData.Rows
                If AccountControl.strGUID = (AccountRecord.Item(modGLobal.Accounts.txtGUID.ToString)).ToString Then
                    With AccountRecord
                        .Item(modGLobal.Accounts.txtAccountName.ToString) = AccountControl.txtAccountName.Text
                        .Item(modGLobal.Accounts.txtAccountType.ToString) = AccountControl.cmbAccountType.Text
                        .Item(modGLobal.Accounts.txtSubAccountToAccountName.ToString) = AccountControl.cmbParentAccount.Text
                        .Item(modGLobal.Accounts.datDateOfStartingBalance.ToString) = AccountControl.dtpStartingBalanceDate.Value
                        .Item(modGLobal.Accounts.decStartingBalance.ToString) = CDec(AccountControl.txtStartingBalance.Text)
                    End With
                    Exit For
                End If
            Next
        Next
    End Sub
    ''' <summary>
    ''' Updates existing records in the datatable. Does not add new records.
    ''' </summary>
    ''' ''' <param name="dtTransactionsData"></param>
    Private Sub UpdateTransactionsDataTableFromForm(ByRef dtTransactionsData As DataTable)
        For Each TransactionControl As ctlTransaction In flpTransactions.Controls
            For Each TransactionRecord As DataRow In dtTransactionsData.Rows
                If TransactionControl.txtGUID = (TransactionRecord.Item(modGLobal.Transactions.txtGUID.ToString)).ToString Then
                    With TransactionRecord
                        .Item(modGLobal.Transactions.txtTransactionType) = TransactionControl.cmbTransactionType.Text
                        .Item(modGLobal.Transactions.datTransactionDate) = TransactionControl.dtpDate.Value
                        .Item(modGLobal.Transactions.txtToAccount) = TransactionControl.cmbToAccount.Text
                        .Item(modGLobal.Transactions.txtFromAccount) = TransactionControl.cmbFromAccount.Text
                        .Item(modGLobal.Transactions.booIsCompleted) = TransactionControl.rdbCompleted.Checked
                        .Item(modGLobal.Transactions.decAmount) = CDec(TransactionControl.txtAmount.Text)
                    End With
                    Exit For
                End If
            Next
        Next
    End Sub
    ''' <summary>
    ''' Updates the database with the data in the dtAccountsData datatable.
    ''' </summary>
    ''' <param name="dtAccountsData"></param>
    Private Sub SaveAccountsDataTableToDB(dtAccountsData As DataTable)
        Dim SQLiteConnection As New clsSQLiteConnection
        SQLiteConnection.SaveADataTable(dtAccountsData, "Accounts")
    End Sub
    ''' <summary>
    ''' Updates the database with the data in the dtTransactionssData datatable.
    ''' </summary>
    ''' <param name="dtTransactionsData"></param>
    Private Sub SaveTransactionsDataTableToDB(dtTransactionsData As DataTable)
        Dim SQLiteConnection As New clsSQLiteConnection
        SQLiteConnection.SaveADataTable(dtTransactionsData, "Transactions")
    End Sub
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
            Dim AccountControl As New ctlAccount()
            flpAccounts.Controls.Add(AccountControl)
        Next AccountRecord
    End Sub
    ''' <summary>
    ''' Creates transaction controls and adds them to flpTransactions flow layout panel. Filters by start and end dates.
    ''' </summary>
    ''' <param name="dtTransactionssData"></param>
    ''' <param name="datStartDate"></param>
    ''' <param name="datEndDate"></param>
    Private Sub PopulateTransactionsFrameFromDataTable(dtTransactionsData As DataTable, StartDate As Date, EndDate As Date)
        For Each TransactionRecord As DataRow In dtTransactionsData.Rows
            With TransactionRecord
                If CDate(TransactionRecord.Item(modGLobal.Transactions.datTransactionDate.ToString)) >= StartDate Then
                    If CDate(TransactionRecord.Item(modGLobal.Transactions.datTransactionDate.ToString)) <= EndDate Then
                        Dim TransactionControl As New ctlTransaction((.Item(modGLobal.Transactions.txtGUID)).ToString, (.Item(modGLobal.Transactions.txtFromAccount)).ToString, (.Item(modGLobal.Transactions.txtToAccount).ToString))
                        flpTransactions.Controls.Add(TransactionControl)
                    End If
                End If
            End With
        Next TransactionRecord
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Private Sub PopulateTransactionTypeComboBoxes()
        'cmbCreateTransactionType.Items.Clear()
        'cmbFilterTransactionType.Items.Clear()
        'cmbCreateTransactionType.Items.Add(TransactionTypes.Borrow_Cash)
        'cmbFilterTransactionType.Items.Add(TransactionTypes.Borrow_Cash)
        'cmbCreateTransactionType.Items.Add(TransactionTypes.Earn)
        'cmbFilterTransactionType.Items.Add(TransactionTypes.Earn)
        'cmbCreateTransactionType.Items.Add(TransactionTypes.Liquidate)
        'cmbFilterTransactionType.Items.Add(TransactionTypes.Liquidate)
        'cmbCreateTransactionType.Items.Add(TransactionTypes.Payoff)
        'cmbFilterTransactionType.Items.Add(TransactionTypes.Payoff)
        'cmbCreateTransactionType.Items.Add(TransactionTypes.Reallocate)
        'cmbFilterTransactionType.Items.Add(TransactionTypes.Reallocate)
        'cmbCreateTransactionType.Items.Add(TransactionTypes.Save)
        'cmbFilterTransactionType.Items.Add(TransactionTypes.Save)
        'cmbCreateTransactionType.Items.Add(TransactionTypes.Spend_Cash)
        'cmbFilterTransactionType.Items.Add(TransactionTypes.Spend_Cash)
        'cmbCreateTransactionType.Items.Add(TransactionTypes.Spend_on_Credit)
        'cmbFilterTransactionType.Items.Add(TransactionTypes.Spend_on_Credit)
        'cmbCreateTransactionType.SelectedIndex = 5

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    Private Sub PopulateAccountTypeComboBox()
        'cmbNewAccountType.Items.Clear()
        'cmbNewAccountType.Items.Add(AccountTypes.Cash)
        'cmbNewAccountType.Items.Add(AccountTypes.Debt)
        'cmbNewAccountType.Items.Add(AccountTypes.Expense)
        'cmbNewAccountType.Items.Add(AccountTypes.Income)
        'cmbNewAccountType.Items.Add(AccountTypes.Savings)
        'cmbNewAccountType.SelectedIndex = 4
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    'Private Sub PopulateFilteredTransactions()

    '    cmbFilteredTransactions.Items.Clear()
    '    Dim dtAllTransactions As New DataTable
    '    Dim dtRemainingTransactions As New DataTable
    '    Dim dtFilteredTransactions As New DataTable
    '    dtAllTransactions = dtActualTransactions.Clone
    '    dtFilteredTransactions = dtActualTransactions.Clone
    '    dtRemainingTransactions = dtActualTransactions.Clone
    '    For Each dr As DataRow In dtActualTransactions.Rows
    '        dtAllTransactions.ImportRow(dr)
    '    Next dr
    '    For Each dr As DataRow In dtPlannedTransactions.Rows
    '        dtAllTransactions.ImportRow(dr)
    '    Next dr
    '    For Each dr As DataRow In dtAllTransactions.Rows
    '        If Not cmbFilterTransactionType.Text = "" Then
    '            If Not dr.Item("TransactionType").ToString = cmbFilterTransactionType.Text Then
    '                dtRemainingTransactions.ImportRow(dr)
    '            Else
    '                dtFilteredTransactions.ImportRow(dr)
    '            End If
    '        Else
    '            dtFilteredTransactions.ImportRow(dr)
    '        End If
    '    Next dr
    '    dtAllTransactions.Clear()
    '    For Each dr As DataRow In dtRemainingTransactions.Rows
    '        dtAllTransactions.ImportRow(dr)
    '    Next
    '    dtRemainingTransactions.Clear()

    '    For Each dr As DataRow In dtAllTransactions.Rows
    '        If Not cmbFilterTransactionFromAccount.Text = "" Then
    '            If Not dr.Item("FromAccountname").ToString = cmbFilterTransactionFromAccount.Text Then
    '                dtRemainingTransactions.ImportRow(dr)
    '            Else
    '                dtFilteredTransactions.ImportRow(dr)
    '            End If
    '        Else
    '            dtFilteredTransactions.ImportRow(dr)
    '        End If
    '    Next dr
    '    dtAllTransactions.Clear()
    '    For Each dr As DataRow In dtRemainingTransactions.Rows
    '        dtAllTransactions.ImportRow(dr)
    '    Next
    '    dtRemainingTransactions.Clear()

    '    For Each dr As DataRow In dtAllTransactions.Rows
    '        If Not cmbFilterTransactionToAccount.Text = "" Then
    '            If Not dr.Item("ToAccountName").ToString = cmbFilterTransactionToAccount.Text Then
    '                dtRemainingTransactions.ImportRow(dr)
    '            Else
    '                dtFilteredTransactions.ImportRow(dr)
    '            End If
    '        Else
    '            dtFilteredTransactions.ImportRow(dr)
    '        End If
    '    Next dr
    '    dtAllTransactions.Clear()
    '    For Each dr As DataRow In dtRemainingTransactions.Rows
    '        dtAllTransactions.ImportRow(dr)
    '    Next
    '    dtRemainingTransactions.Clear()

    '    For Each dr As DataRow In dtAllTransactions.Rows
    '        If IsNumeric(cmbFilterTransactionType.Text) Then
    '            If Not CDec(dr.Item("Amount")) = CDec(txtFilterTransactionAmount.Text) Then
    '                dtRemainingTransactions.ImportRow(dr)
    '            Else
    '                dtFilteredTransactions.ImportRow(dr)
    '            End If
    '        Else
    '            dtFilteredTransactions.ImportRow(dr)
    '        End If
    '    Next dr
    '    dtAllTransactions.Clear()
    '    For Each dr As DataRow In dtRemainingTransactions.Rows
    '        dtAllTransactions.ImportRow(dr)
    '    Next
    '    dtRemainingTransactions.Clear()

    '    For Each dr As DataRow In dtAllTransactions.Rows
    '        If Not CDate(dr.Item("Date")) >= dtpFilterTransactionStartDate.Value Or Not CDate(dr.Item("Date")) <= dtpFilterTransactionEndDate.Value Then
    '            dtRemainingTransactions.ImportRow(dr)
    '        Else
    '            dtFilteredTransactions.ImportRow(dr)
    '        End If
    '    Next dr
    '    dtAllTransactions.Clear()
    '    For Each dr As DataRow In dtRemainingTransactions.Rows
    '        dtAllTransactions.ImportRow(dr)
    '    Next
    '    dtRemainingTransactions.Clear()

    '    For Each dr As DataRow In dtFilteredTransactions.Rows
    '        cmbFilteredTransactions.Items.Add("$" & dr.Item("Amount").ToString & " From " & dr.Item("FromAccountname").ToString & " To " & dr.Item("ToAccountName").ToString & " On " & dr.Item("Date").ToString & " Transaction Type " & dr.Item("TransactionType").ToString)
    '    Next dr

    'End Sub

    'Private Sub PopulateAccountNameComboBoxes()
    '    cmbSelectAccount.Items.Clear()

    '    For Each dr As DataRow In dtAccounts.Rows
    '        If Not CBool(dr.Item("IsDeleted")) Then
    '            cmbSelectAccount.Items.Add(dr.Item("AccountName").ToString)
    '            cmbCreateTransactionFromAccount.Items.Add(dr.Item("AccountName").ToString)
    '            cmbCreateTransactionToAccount.Items.Add(dr.Item("AccountName").ToString)
    '            cmbFilterTransactionFromAccount.Items.Add(dr.Item("AccountName").ToString)
    '            cmbFilterTransactionToAccount.Items.Add(dr.Item("AccountName").ToString)
    '            cmbRemoveAccountName.Items.Add(dr.Item("AccountName").ToString)
    '        Else
    '            cmbRestoreAccountName.Items.Add(dr.Item("AccountName").ToString)
    '        End If
    '    Next dr
    '    cmbSelectAccount.SelectedIndex = 0
    'End Sub

    'Private Sub ConfigureAccountsDataGridView()
    '    Dim AccountName As New DataGridViewTextBoxColumn
    '    With AccountName
    '        .HeaderText = "Account Name"
    '        .Name = "AccountName"
    '        .Width = 300
    '        dgvAccounts.Columns.Add(AccountName)
    '        .DataPropertyName = "AccountName"
    '    End With

    '    Dim CalculatedBalance As New DataGridViewTextBoxColumn
    '    With CalculatedBalance
    '        .HeaderText = "Balance"
    '        .Name = "CalculatedBalance"
    '        .ReadOnly = True
    '        .Width = 150
    '        dgvAccounts.Columns.Add(CalculatedBalance)
    '        .DataPropertyName = "CalculatedBalance"
    '    End With

    '    Dim cmbAccountType As New DataGridViewComboBoxColumn
    '    With cmbAccountType
    '        .HeaderText = "Account Type"
    '        .Name = "cmbAccountType"
    '        .Width = 150
    '        dgvAccounts.Columns.Add(cmbAccountType)
    '        .DataPropertyName = "Type"
    '        For Each dr As DataRow In dtAccountTypes.Rows
    '            .Items.Add(dr.Item("Type").ToString)
    '        Next
    '        .DataPropertyName = "AccountType"
    '    End With

    '    Dim StartingBalance As New DataGridViewTextBoxColumn
    '    With StartingBalance
    '        .HeaderText = "Starting Balance"
    '        .Name = "StartingBalance"
    '        .Width = 150
    '        dgvAccounts.Columns.Add(StartingBalance)
    '        .DataPropertyName = "StartingBalance"
    '    End With

    '    Dim DateOfStartingBalance As New DataGridViewTextBoxColumn
    '    With DateOfStartingBalance
    '        .HeaderText = "Starting Balance Date"
    '        .Name = "DateOfStartingBalance"
    '        .DefaultCellStyle.Format = "MM/dd/yyyy"
    '        .Width = 150
    '        dgvAccounts.Columns.Add(DateOfStartingBalance)
    '        .DataPropertyName = "DateOfStartingBalance"
    '    End With

    '    'Dim DeleteButton As New DataGridViewButtonColumn
    '    'With DeleteButton
    '    '    .HeaderText = "Delete Account"
    '    '    .Name = "DeleteButton"
    '    '    .Text = "Delete"
    '    '    .Width = 150
    '    '    dgvAccounts.Columns.Add(DeleteButton)
    '    '    .Text = "Delete"
    '    '    .Visible = False
    '    'End With

    '    dgvAccounts.DataSource = dtAccounts
    '    dgvAccounts.EditMode = DataGridViewEditMode.EditOnEnter

    'End Sub

    'Private Sub ConfigureAccountsPlannedDataGridView()
    '    Dim AccountName As New DataGridViewTextBoxColumn
    '    With AccountName
    '        .HeaderText = "Account Name"
    '        .Name = "AccountName"
    '        .Width = 300
    '        dgvAccountsPlanned.Columns.Add(AccountName)
    '        .DataPropertyName = "AccountName"
    '    End With

    '    Dim CalculatedBalance As New DataGridViewTextBoxColumn
    '    With CalculatedBalance
    '        .HeaderText = "Balance"
    '        .Name = "CalculatedBalance"
    '        .ReadOnly = True
    '        .Width = 150
    '        dgvAccountsPlanned.Columns.Add(CalculatedBalance)
    '        .DataPropertyName = "CalculatedBalance"
    '    End With

    '    Dim cmbAccountType As New DataGridViewComboBoxColumn
    '    With cmbAccountType
    '        .HeaderText = "Account Type"
    '        .Name = "cmbAccountType"
    '        .Width = 150
    '        dgvAccountsPlanned.Columns.Add(cmbAccountType)
    '        .DataPropertyName = "Type"
    '        For Each dr As DataRow In dtAccountTypes.Rows
    '            .Items.Add(dr.Item("Type").ToString)
    '        Next
    '        .DataPropertyName = "AccountType"
    '    End With

    '    Dim StartingBalance As New DataGridViewTextBoxColumn
    '    With StartingBalance
    '        .HeaderText = "Starting Balance"
    '        .Name = "StartingBalance"
    '        .Width = 150
    '        dgvAccountsPlanned.Columns.Add(StartingBalance)
    '        .DataPropertyName = "StartingBalance"
    '    End With

    '    Dim DateOfStartingBalance As New DataGridViewTextBoxColumn
    '    With DateOfStartingBalance
    '        .HeaderText = "Starting Balance Date"
    '        .Name = "DateOfStartingBalance"
    '        .DefaultCellStyle.Format = "MM/dd/yyyy"
    '        .Width = 150
    '        dgvAccountsPlanned.Columns.Add(DateOfStartingBalance)
    '        .DataPropertyName = "DateOfStartingBalance"
    '    End With

    '    'Dim DeleteButton As New DataGridViewButtonColumn
    '    'With DeleteButton
    '    '    .HeaderText = "Delete Account"
    '    '    .Name = "DeleteButton"
    '    '    .Text = "Delete"
    '    '    .Width = 150
    '    '    dgvAccountsPlanned.Columns.Add(DeleteButton)
    '    '    .Text = "Delete"
    '    '    .Visible = False
    '    'End With

    '    dgvAccountsPlanned.DataSource = dtAccounts
    'End Sub

    'Private Sub ConfigurePlannedTransactionsDataGridView()

    '    Dim TransactionDate As New DataGridViewTextBoxColumn
    '    With TransactionDate
    '        .HeaderText = "Date"
    '        .Name = "Date"
    '        .Width = 150
    '        .DefaultCellStyle.Format = "MM/dd/yyyy"
    '        dgvPlannedTransactions.Columns.Add(TransactionDate)
    '        .DataPropertyName = "Date"
    '    End With

    '    Dim TransactionType As New DataGridViewComboBoxColumn
    '    With TransactionType
    '        .HeaderText = "Transaction Type"
    '        .Name = "TransactionType"
    '        .Width = 150
    '        dgvPlannedTransactions.Columns.Add(TransactionType)
    '        .DataPropertyName = "TransactionType"
    '        For Each dr As DataRow In dtTransactionTypes.Rows
    '            .Items.Add(dr.Item("Type").ToString)
    '        Next
    '    End With

    '    Dim TransactionAmount As New DataGridViewTextBoxColumn
    '    With TransactionAmount
    '        .HeaderText = "Amount"
    '        .Name = "Amount"
    '        .Width = 150
    '        dgvPlannedTransactions.Columns.Add(TransactionAmount)
    '        .DataPropertyName = "Amount"
    '    End With

    '    Dim FromAccountName As New DataGridViewComboBoxColumn
    '    With FromAccountName
    '        .HeaderText = "From Account"
    '        .Name = "FromAccountName"
    '        .Width = 300
    '        dgvPlannedTransactions.Columns.Add(FromAccountName)
    '        .DataPropertyName = "FromAccountName"
    '        For Each dr As DataRow In dtFromAccounts.Rows
    '            .Items.Add(dr.Item("AccountName").ToString)
    '        Next
    '    End With

    '    Dim ToAccountName As New DataGridViewComboBoxColumn
    '    With ToAccountName
    '        .HeaderText = "To Account"
    '        .Name = "ToAccountName"
    '        .Width = 300
    '        dgvPlannedTransactions.Columns.Add(ToAccountName)
    '        .DataPropertyName = "ToAccountName"
    '        For Each dr As DataRow In dtToAccounts.Rows
    '            .Items.Add(dr.Item("AccountName").ToString)
    '        Next
    '    End With

    '    dgvPlannedTransactions.DataSource = dtPlannedTransactions
    'End Sub

    'Private Sub ConfigureActualTransactionsDataGridView()
    '    Dim TransactionDate As New DataGridViewTextBoxColumn
    '    With TransactionDate
    '        .HeaderText = "Date"
    '        .Name = "Date"
    '        .Width = 150
    '        .DefaultCellStyle.Format = "MM/dd/yyyy"
    '        dgvActualTransactions.Columns.Add(TransactionDate)
    '        .DataPropertyName = "Date"
    '    End With

    '    Dim TransactionType As New DataGridViewComboBoxColumn
    '    With TransactionType
    '        .HeaderText = "Transaction Type"
    '        .Name = "TransactionType"
    '        .Width = 150
    '        dgvActualTransactions.Columns.Add(TransactionType)
    '        .DataPropertyName = "TransactionType"
    '        For Each dr As DataRow In dtTransactionTypes.Rows
    '            .Items.Add(dr.Item("Type").ToString)
    '        Next
    '    End With

    '    Dim TransactionAmount As New DataGridViewTextBoxColumn
    '    With TransactionAmount
    '        .HeaderText = "Amount"
    '        .Name = "Amount"
    '        .Width = 150
    '        dgvActualTransactions.Columns.Add(TransactionAmount)
    '        .DataPropertyName = "Amount"
    '    End With

    '    Dim FromAccountName As New DataGridViewComboBoxColumn
    '    With FromAccountName
    '        .HeaderText = "From Account"
    '        .Name = "FromAccountName"
    '        .Width = 300
    '        dgvActualTransactions.Columns.Add(FromAccountName)
    '        .DataPropertyName = "FromAccountName"
    '        For Each dr As DataRow In dtFromAccounts.Rows
    '            .Items.Add(dr.Item("AccountName").ToString)
    '        Next
    '    End With

    '    Dim ToAccountName As New DataGridViewComboBoxColumn
    '    With ToAccountName
    '        .HeaderText = "To Account"
    '        .Name = "ToAccountName"
    '        .Width = 300
    '        dgvActualTransactions.Columns.Add(ToAccountName)
    '        .DataPropertyName = "ToAccountName"
    '        For Each dr As DataRow In dtToAccounts.Rows
    '            .Items.Add(dr.Item("AccountName").ToString)
    '        Next
    '    End With

    '    dgvActualTransactions.DataSource = dtActualTransactions

    'End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Private Sub GetAccounts()
        dtAccounts.Reset()
        dtFromAccounts.Reset()
        dtToAccounts.Reset()
        Dim SQLiteServer As New clsSQLiteConnection
        SQLiteServer.PopulateADataTable(dtAccounts, "Accounts")
        dtFromAccounts = dtAccounts.Clone
        dtToAccounts = dtAccounts.Clone
        For Each dr As DataRow In dtAccounts.Rows
            dtFromAccounts.ImportRow(dr)
            dtToAccounts.ImportRow(dr)
        Next
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    Private Sub GetPlannedTransactions()
        dtTransactions.Reset()
        Dim SQLiteServer As New clsSQLiteConnection
        SQLiteServer.PopulateADataTable(dtTransactions, "Transactions")
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    Private Sub CalculateCurrentAccountBalances()
        For Each drAccount As DataRow In dtAccounts.Rows
            drAccount.Item("CalculatedBalance") = drAccount.Item("StartingBalance")
            For Each drActualTransaction As DataRow In dtTransactions.Rows
                If drAccount.Item("AccountName").ToString = drActualTransaction.Item("FromAccountName").ToString Then
                    drAccount.Item("CalculatedBalance") = CDec(drAccount.Item("CalculatedBalance")) - CDec(drActualTransaction.Item("Amount"))
                ElseIf drAccount.Item("AccountName").ToString = drActualTransaction.Item("ToAccountName").ToString Then
                    drAccount.Item("CalculatedBalance") = CDec(drAccount.Item("CalculatedBalance")) + CDec(drActualTransaction.Item("Amount"))
                End If
            Next drActualTransaction
        Next drAccount
    End Sub
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
    Private Sub SaveAccounts()
        'MessageBox.Show(dtAccounts.Rows(0).Item("guid").ToString)
        'Dim dtChanges As DataTable = dtAccounts.GetChanges
        'For Each dr As DataRow In dtChanges.Rows
        '    MessageBox.Show(dr.Item("AccountName").ToString)
        'Next
        Dim SQLiteServer As New clsSQLiteConnection
        SQLiteServer.SaveADataTable(dtAccounts, "Accounts")
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    Private Sub SaveTransactions()
        Dim SQLiteServer As New clsSQLiteConnection
        SQLiteServer.SaveADataTable(dtTransactions, "Transactions")
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        'MessageBox.Show(dtAccounts.GetChanges.Rows.Count.ToString)
        SaveAccounts()
        SaveTransactions()
        CalculateCurrentAccountBalances()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvPlannedTransactions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvAccounts_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvActualTransactions_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvPlannedTransactions_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvAccountsPlanned_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)

    End Sub

    'Private Sub SetAvailableAccountsBasedOnTransactionType(ActualTransaction As Boolean, TransactionType As String)
    '    dtFromAccounts.Reset()
    '    dtToAccounts.Reset()

    '    dtFromAccounts = dtAccounts.Clone
    '    dtToAccounts = dtAccounts.Clone

    '    If ActualTransaction = True Then
    '        Select Case TransactionType
    '            Case TransactionTypes.Borrow_Cash
    '                For Each dr As DataRow In dtAccounts.Rows
    '                    If dr.Item("AccountType").ToString = AccountTypes.Debt Then
    '                        dtFromAccounts.ImportRow(dr)
    '                    ElseIf dr.Item("AccountType").ToString = AccountTypes.Cash Then
    '                        dtToAccounts.ImportRow(dr)
    '                    End If
    '                Next
    '            Case TransactionTypes.Earn
    '                For Each dr As DataRow In dtAccounts.Rows
    '                    If dr.Item("AccountType").ToString = AccountTypes.Income Then
    '                        dtFromAccounts.ImportRow(dr)
    '                    ElseIf dr.Item("AccountType").ToString = AccountTypes.Cash Then
    '                        dtToAccounts.ImportRow(dr)
    '                    End If
    '                Next
    '            Case TransactionTypes.Liquidate
    '                For Each dr As DataRow In dtAccounts.Rows
    '                    If dr.Item("AccountType").ToString = AccountTypes.Savings Then
    '                        dtFromAccounts.ImportRow(dr)
    '                    ElseIf dr.Item("AccountType").ToString = AccountTypes.Cash Then
    '                        dtToAccounts.ImportRow(dr)
    '                    End If
    '                Next
    '            Case TransactionTypes.Payoff
    '                For Each dr As DataRow In dtAccounts.Rows
    '                    If dr.Item("AccountType").ToString = AccountTypes.Cash Then
    '                        dtFromAccounts.ImportRow(dr)
    '                    ElseIf dr.Item("AccountType").ToString = AccountTypes.Debt Then
    '                        dtToAccounts.ImportRow(dr)
    '                    End If
    '                Next
    '            Case TransactionTypes.Reallocate
    '                For Each dr As DataRow In dtAccounts.Rows
    '                    If dr.Item("AccountType").ToString = AccountTypes.Savings Then
    '                        dtFromAccounts.ImportRow(dr)
    '                    ElseIf dr.Item("AccountType").ToString = AccountTypes.Savings Then
    '                        dtToAccounts.ImportRow(dr)
    '                    End If
    '                Next
    '            Case TransactionTypes.Save
    '                For Each dr As DataRow In dtAccounts.Rows
    '                    If dr.Item("AccountType").ToString = AccountTypes.Cash Then
    '                        dtFromAccounts.ImportRow(dr)
    '                    ElseIf dr.Item("AccountType").ToString = AccountTypes.Savings Then
    '                        dtToAccounts.ImportRow(dr)
    '                    End If
    '                Next
    '            Case TransactionTypes.Spend_Cash
    '                For Each dr As DataRow In dtAccounts.Rows
    '                    If dr.Item("AccountType").ToString = AccountTypes.Cash Then
    '                        dtFromAccounts.ImportRow(dr)
    '                    ElseIf dr.Item("AccountType").ToString = AccountTypes.Expense Then
    '                        dtToAccounts.ImportRow(dr)
    '                    End If
    '                Next
    '            Case TransactionTypes.Spend_on_Credit
    '                For Each dr As DataRow In dtAccounts.Rows
    '                    If dr.Item("AccountType").ToString = AccountTypes.Debt Then
    '                        dtFromAccounts.ImportRow(dr)
    '                    ElseIf dr.Item("AccountType").ToString = AccountTypes.Expense Then
    '                        dtToAccounts.ImportRow(dr)
    '                    End If
    '                Next
    '        End Select
    '        For Each dgvRow As DataGridViewRow In dgvActualTransactions.Rows
    '            'CType(dgvActualTransactions.Columns(1), DataGridViewComboBoxColumn).Items.Add(dgvRow.DataBoundItem("Tr"))
    '        Next
    '    Else

    '    End If
    'End Sub

    'Private Sub dgvActualTransactions_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActualTransactions.CellEndEdit
    '    Select Case dgvActualTransactions.CurrentCell.Value.ToString
    '        Case TransactionTypes.Borrow_Cash
    '            SetAvailableAccountsBasedOnTransactionType(True, TransactionTypes.Borrow_Cash)
    '        Case TransactionTypes.Earn
    '            SetAvailableAccountsBasedOnTransactionType(True, TransactionTypes.Earn)
    '        Case TransactionTypes.Liquidate
    '            SetAvailableAccountsBasedOnTransactionType(True, TransactionTypes.Liquidate)
    '        Case TransactionTypes.Payoff
    '            SetAvailableAccountsBasedOnTransactionType(True, TransactionTypes.Payoff)
    '        Case TransactionTypes.Reallocate
    '            SetAvailableAccountsBasedOnTransactionType(True, TransactionTypes.Reallocate)
    '        Case TransactionTypes.Save
    '            SetAvailableAccountsBasedOnTransactionType(True, TransactionTypes.Save)
    '        Case TransactionTypes.Spend_Cash
    '            SetAvailableAccountsBasedOnTransactionType(True, TransactionTypes.Spend_Cash)
    '        Case TransactionTypes.Spend_on_Credit
    '            SetAvailableAccountsBasedOnTransactionType(True, TransactionTypes.Spend_on_Credit)
    '    End Select
    'End Sub

    'Public Function CalculateBalance(ByVal AccountName As String, ByVal StartDate As Date, ByVal EndDate As Date, ByVal StartingBalance As Decimal, ByRef Transactions As DataTable) As Decimal
    '    'The "Transactions" datatable expects a table with columns guid(int), Date(date), Amount(decimal) FromAccountName(string), ToAccountName(string), TransactionType(string)
    '    'dtActualTransactions and dtPlannedTransactions should match this structure when populated from the database

    '    Dim RunningBalance As Decimal
    '    RunningBalance = StartingBalance
    '    For Each dr As DataRow In Transactions.Rows
    '        If CDate(dr.Item("Date")) >= StartDate Then
    '            If CDate(dr.Item("Date")) <= EndDate Then
    '                If dr.Item("FromAccountName").ToString = AccountName Then
    '                    RunningBalance = RunningBalance - CDec(dr.Item("Amount"))
    '                ElseIf dr.Item("ToAccountName").ToString = AccountName Then
    '                    RunningBalance = RunningBalance + CDec(dr.Item("Amount"))
    '                End If
    '            End If
    '        End If
    '    Next dr
    '    Return RunningBalance
    'End Function

    'Public Function CreateRecurringTransaction(ByRef Transactions As DataTable, ByVal CountOfRecurrences As Integer, ByVal FromAccountName As String, ByVal ToAccountName As String, ByVal Amount As Decimal, ByVal StartDate As Date, ByVal IntervalInDays As Integer, ByVal TransactionType As String) As DataTable
    '    'Expects a datatable with columns identical to those in dtActualtransactions and dtPlannedTransactions
    '    'New transactions are added to the datatable
    '    Dim TransactionDate As Date = StartDate
    '    Dim Count As Integer
    '    For Count = 1 To CountOfRecurrences
    '        Dim dr As DataRow = Transactions.NewRow
    '        dr.Item("Date") = TransactionDate
    '        dr.Item("Amount") = Amount
    '        dr.Item("FromAccountName") = FromAccountName
    '        dr.Item("ToAccountName") = ToAccountName
    '        dr.Item("TransactionType") = TransactionType
    '        TransactionDate = TransactionDate.AddDays(CDec(IntervalInDays))
    '        Transactions.Rows.Add(dr)
    '    Next Count
    '    Return Transactions
    'End Function

    'Public Function DeleteATransaction(ByRef Transactions As DataTable, ByVal FromAccountName As String, ByVal ToAccountName As String, ByVal Amount As Decimal, ByVal TransactionDate As Date) As DataTable
    '    'Expects Transactions to be a datatable with columns identical to those in dtActualtransactions and dtPlannedTransactions
    '    For Each dr As DataRow In Transactions.Rows
    '        If CDate(dr.Item("Date")) = TransactionDate Then
    '            If CDec(dr.Item("Amount")) = Amount Then
    '                If dr.Item("FromAccountName").ToString = FromAccountName Then
    '                    If dr.Item("ToAccountName").ToString = ToAccountName Then
    '                        Transactions.Rows.Remove(dr)
    '                        Return Transactions
    '                    End If
    '                End If
    '            End If
    '        End If
    '    Next dr
    '    Return Transactions
    'End Function

    'Public Function CalculateDailyBalances(ByRef Transactions As DataTable, ByVal AccountName As String, ByVal StartingBalance As Decimal, ByVal StartDate As Date, ByVal EndDate As Date) As DataTable
    '    'Expects Transactions to be a datatable with columns identical to those in dtActualtransactions and dtPlannedTransactions
    '    'Returns a new table with columns Date(date), AccountName(string), Balance(decimal)
    '    'The balances are END OF DAY balances, ie balance includes the results of all transactions that occurred on that date
    '    Dim DateOfBalance As Date = StartDate
    '    Dim Balances As New DataTable
    '    Dim RunningBalance As Decimal = StartingBalance
    '    Balances.Columns.Add("Date", GetType(Date))
    '    Balances.Columns.Add("AccountName", GetType(Date))
    '    Balances.Columns.Add("Balance", GetType(Date))
    '    Dim Count As Integer
    '    For Count = 1 To 1 + (EndDate - StartDate).Days
    '        For Each drT As DataRow In Transactions.Rows
    '            If CDate(drT.Item("Date")) = DateOfBalance Then
    '                If drT.Item("FromAccountName").ToString = AccountName Then
    '                    RunningBalance = RunningBalance - CDec(drT.Item("Amount"))
    '                    Dim dr As DataRow = Balances.NewRow
    '                    dr.Item("Date") = DateOfBalance
    '                    dr.Item("AccountName") = AccountName
    '                    dr.Item("Balance") = RunningBalance
    '                    Balances.Rows.Add(dr)
    '                ElseIf drT.Item("ToAccountName").ToString = AccountName Then
    '                    RunningBalance = RunningBalance + CDec(drT.Item("Amount"))
    '                    Dim dr As DataRow = Balances.NewRow
    '                    dr.Item("Date") = DateOfBalance
    '                    dr.Item("AccountName") = AccountName
    '                    dr.Item("Balance") = RunningBalance
    '                    Balances.Rows.Add(dr)
    '                End If
    '            End If
    '        Next drT
    '    Next Count
    '    Return Balances
    'End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CtlAccount1_Load(sender As Object, e As EventArgs) Handles CtlAccount1.Load
        CtlAccount1.Label8.ForeColor = Color.WhiteSmoke
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click
        Dim AccountControl As New ctlAccount
        flpAccounts.Controls.Add(AccountControl)

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    'Public Sub AddANewTransaction()
    '    Dim SQLiteConnection As New clsSQLiteConnection
    '    Dim TransactionControl As New ctlTransaction(SQLiteConnection.CreateGUID, GetAccountList)
    '    flpTransactions.Controls.Add(TransactionControl)
    'End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    Public Sub AddANewAccount()

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Function GetAccountList() As List(Of String)
        Dim lstAccounts As New List(Of String)
        Dim dtAccounts As New DataTable
        Dim SQLiteConnection As New clsSQLiteConnection
        Try
            SQLiteConnection.PopulateADataTable(dtAccounts, GetType(modGLobal.Accounts).Name)
            If dtAccounts.Rows.Count > 0 Then
                For Each dr As DataRow In dtAccounts.Rows
                    lstAccounts.Add(dr.Item(modGLobal.Accounts.txtAccountName).ToString)
                Next dr
            End If
        Catch ex As Exception

        End Try
        Return lstAccounts
    End Function

#End Region
End Class
