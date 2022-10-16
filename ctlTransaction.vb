Option Strict On
Option Explicit On

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

#End Region

#Region "Events"

#End Region

#Region "Event Handlers"

#End Region


End Class
