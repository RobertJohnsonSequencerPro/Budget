Option Strict On
Option Explicit On

Public Class ctlAccount

#Region "Variables"

#End Region

#Region "Properties"
    Public strGUID As String
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
        Label8.ForeColor = Color.WhiteSmoke


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
    ''' <param name="ParentAccountName"></param>
    Public Sub New(dtAccountTypes As DataTable, dtAccounts As DataTable, GloballyUniqueID As String, IsDeleted As Boolean, AccountName As String, AccountType As String, StartingBalance As Decimal, StartingBalanceDate As Date, Optional ParentAccountName As String = "None")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        For Each drAccountType As DataRow In dtAccountTypes.Rows
            cmbAccountType.Items.Add(drAccountType.Item("Type").ToString)
        Next drAccountType

        For Each drParentAccount As DataRow In dtAccounts.Rows
            cmbParentAccount.Items.Add(drParentAccount.Item(modGLobal.Accounts.txtSubAccountToAccountName.ToString))
        Next drParentAccount

        strGUID = GloballyUniqueID
        booIsDeleted = IsDeleted
        txtAccountName.Text = AccountName
        cmbAccountType.Text = AccountType
        txtStartingBalance.Text = StartingBalance.ToString
        dtpStartingBalanceDate.Value = StartingBalanceDate
        cmbParentAccount.Text = ParentAccountName
    End Sub


#End Region

#Region "Methods"

#End Region


#Region "Events"

#End Region

#Region "Event Handlers"

#End Region




End Class
