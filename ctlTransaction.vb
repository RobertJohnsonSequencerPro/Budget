Option Strict On
Option Explicit On
Imports Budget.modGLobal

Public Class ctlTransaction

#Region "Variables"

#End Region

#Region "Properties"
    Public txtGUID As String
    Public booIsDeleted As Boolean
#End Region

#Region "Objects"
    Dim IOTable As clsSingleRecordIO
#End Region

#Region "Constructors"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim SQLiteConnection As New clsSQLiteConnection
        txtGUID = SQLiteConnection.CreateGUID
        Dim Accounts As New List(Of String)
        Accounts = GetAccountList()
        For Each AccountName As String In Accounts
            cmbFromAccount.Items.Add(AccountName)
            cmbToAccount.Items.Add(AccountName)
        Next
        cmbTransactionType.DataSource = GetType(modGLobal.TransactionTypes).GetEnumNames
        IOTable = New clsSingleRecordIO(GetType(modGLobal.Transactions), modGLobal.DBConnectionString, txtGUID)
        IOTable.GetDataFromDatabase()
        If Not IOTable.RecordIsInDB Then
            IOTable.UpdateTextField(modGLobal.Transactions.txtFromAccount.ToString, "None")
            IOTable.UpdateTextField(modGLobal.Transactions.txtToAccount.ToString, "None")
            IOTable.UpdateTextField(modGLobal.Transactions.decAmount.ToString, "None")
            IOTable.UpdateTextField(modGLobal.Transactions.datTransactionDate.ToString, "None")
            IOTable.UpdateTextField(modGLobal.Transactions.booIsCompleted.ToString, "None")
        End If
        txtAmount.Text = IOTable.GetNumericFieldValue(modGLobal.Transactions.decAmount.ToString).ToString
        cmbFromAccount.Text = IOTable.GetTextFieldValue(modGLobal.Transactions.txtFromAccount.ToString)
        cmbToAccount.Text = IOTable.GetTextFieldValue(modGLobal.Transactions.txtToAccount.ToString)
        dtpDate.Value = CDate(IOTable.GetDateFieldValue(modGLobal.Transactions.datTransactionDate.ToString))
        cmbTransactionType.Text = IOTable.GetTextFieldValue(modGLobal.Transactions.txtTransactionType.ToString)
        Dim Completed As Boolean = CBool(IOTable.GetIntegerFieldValue(modGLobal.Transactions.booIsCompleted.ToString))
    End Sub

    Public Sub New(GloballyUniqueUD As String, FromAccountName As String, ToAccountName As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtGUID = GloballyUniqueUD

        cmbFromAccount.Items.Add(FromAccountName)
        cmbToAccount.Items.Add(ToAccountName)

        cmbTransactionType.DataSource = GetType(modGLobal.TransactionTypes).GetEnumNames

        IOTable = New clsSingleRecordIO(GetType(modGLobal.Transactions), modGLobal.DBConnectionString, txtGUID)
        IOTable.GetDataFromDatabase()
        If Not IOTable.RecordIsInDB Then
            IOTable.UpdateTextField(modGLobal.Transactions.txtFromAccount.ToString, "None")
            IOTable.UpdateTextField(modGLobal.Transactions.txtToAccount.ToString, "None")
            IOTable.UpdateTextField(modGLobal.Transactions.decAmount.ToString, "None")
            IOTable.UpdateTextField(modGLobal.Transactions.datTransactionDate.ToString, "None")
            IOTable.UpdateTextField(modGLobal.Transactions.booIsCompleted.ToString, "None")
        End If

    End Sub

    Public Sub New(GloballyUniqueID As String, IsDeleted As Boolean, TransactionDate As Date, Amount As Decimal, FromAccountName As String, ToAccountName As String, TransactionType As String, IsCompleted As Boolean)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        txtGUID = GloballyUniqueID
        booIsDeleted = IsDeleted

    End Sub
#End Region

#Region "Methods"
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

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub


#End Region

#Region "Events"

#End Region

#Region "Event Handlers"

#End Region


End Class
