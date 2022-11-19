Option Strict On
Option Explicit On
Imports Budget.modGLobal

Public Class ctlTransaction

#Region "Variables"

#End Region

#Region "Properties"
    Public GUID As String
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
        GUID = SQLiteConnection.CreateGUID
        Dim Accounts As New List(Of String)
        Accounts = GetAccountList()
        For Each AccountName As String In Accounts
            cmbFromAccount.Items.Add(AccountName)
            cmbToAccount.Items.Add(AccountName)
        Next
        cmbTransactionType.DataSource = GetType(modGLobal.TransactionTypes).GetEnumNames
        IOTable = New clsSingleRecordIO(GetType(modGLobal.Transaction), modGLobal.DBConnectionString, GUID)
        IOTable.GetDataFromDatabase()
        If Not IOTable.RecordIsInDB Then
            IOTable.UpdateTextField(modGLobal.Transaction.txtFromAccount.ToString, "None")
            IOTable.UpdateTextField(modGLobal.Transaction.txtToAccount.ToString, "None")
            IOTable.UpdateTextField(modGLobal.Transaction.decAmount.ToString, "None")
            IOTable.UpdateTextField(modGLobal.Transaction.datTransactionDate.ToString, "None")
            IOTable.UpdateTextField(modGLobal.Transaction.booIsCompleted.ToString, "None")
        End If
        txtAmount.Text = IOTable.GetNumericFieldValue(modGLobal.Transaction.decAmount.ToString).ToString
        cmbFromAccount.Text = IOTable.GetTextFieldValue(modGLobal.Transaction.txtFromAccount.ToString)
        cmbToAccount.Text = IOTable.GetTextFieldValue(modGLobal.Transaction.txtToAccount.ToString)
        dtpDate.Value = CDate(IOTable.GetTextFieldValue(modGLobal.Transaction.datTransactionDate.ToString))
        cmbTransactionType.Text = IOTable.GetTextFieldValue(modGLobal.Transaction.txtTransactionType.ToString)
        Dim Completed As Boolean = CBool(IOTable.GetIntegerFieldValue(modGLobal.Transaction.booIsCompleted.ToString))
    End Sub

    Public Sub New(txtGUID As String, Accounts As List(Of String))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        GUID = txtGUID
        For Each AccountName As String In Accounts
            cmbFromAccount.Items.Add(AccountName)
            cmbToAccount.Items.Add(AccountName)
        Next

        cmbTransactionType.DataSource = GetType(modGLobal.TransactionTypes).GetEnumNames

        IOTable = New clsSingleRecordIO(GetType(modGLobal.Transaction), modGLobal.DBConnectionString, GUID)
        IOTable.GetDataFromDatabase()
        If Not IOTable.RecordIsInDB Then
            IOTable.UpdateTextField(modGLobal.Transaction.txtFromAccount.ToString, "None")
            IOTable.UpdateTextField(modGLobal.Transaction.txtToAccount.ToString, "None")
            IOTable.UpdateTextField(modGLobal.Transaction.decAmount.ToString, "None")
            IOTable.UpdateTextField(modGLobal.Transaction.datTransactionDate.ToString, "None")
            IOTable.UpdateTextField(modGLobal.Transaction.booIsCompleted.ToString, "None")
        End If

    End Sub
#End Region

#Region "Methods"
    Public Function GetAccountList() As List(Of String)
        Dim lstAccounts As New List(Of String)
        Dim dtAccounts As New DataTable
        Dim SQLiteConnection As New clsSQLiteConnection
        Try
            SQLiteConnection.PopulateADataTable(dtAccounts, GetType(modGLobal.Account).Name)
            If dtAccounts.Rows.Count > 0 Then
                For Each dr As DataRow In dtAccounts.Rows
                    lstAccounts.Add(dr.Item(modGLobal.Account.txtAccountName).ToString)
                Next dr
            End If
        Catch ex As Exception

        End Try
        Return lstAccounts
    End Function
#End Region

#Region "Events"

#End Region

#Region "Event Handlers"

#End Region


End Class
