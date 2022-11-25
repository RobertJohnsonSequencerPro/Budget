Option Strict On
Option Explicit On


Module modGlobal

#Region "Constants"
    ''' <summary>
    ''' 
    ''' </summary>
    Public Const LocalDBPath As String = "C:\ProgramData\Budget\"
    ''' <summary>
    ''' 
    ''' </summary>
    Public Const LocalDBFileName As String = "Budget.db"
#End Region

#Region "Variables"


#End Region


#Region "Properties"

#End Region


#Region "Enumerations"
    ''' <summary>
    ''' 
    ''' </summary>
    Public Enum AccountTypes
        Income
        Cash
        Savings
        Debt
        Expense
    End Enum
    ''' <summary>
    ''' 
    ''' </summary>
    Public Enum TransactionTypes
        Earn
        'From Income Account to Cash Account.
        Save
        'From Cash Account to Savings Account.
        'Reallocate
        'Purpose is unclear for the Reallocate transaction type and so is deprecated.
        Liquidate
        'From Savings to Cash
        Payoff
        'From Cash to Debt
        Spend_Cash
        'From Cash to Expense
        Spend_on_Credit
        'From Debt to Expense
        Borrow_Cash
        'From Debt to Cash
    End Enum
    ''' <summary>
    ''' 
    ''' </summary>
    Public Enum SQLiteDataTypePrefixes
        int
        'INTEGER
        txt
        'TEXT
        dec
        'REAL
        blb
        'BLOB
        boo
        'INTEGER for BOOLEAN
        dat
        'TEXT for DATE
        dbl
        'REAL
    End Enum
    ''' <summary>
    ''' 
    ''' </summary>
#Region "Datatable Enums"
    Public Enum Accounts
        txtGUID
        datRecordCreated
        booIsDeleted
        txtAccountName
        decStartingBalance
        datDateOfStartingBalance
        txtAccountType
        txtSubAccountToAccountID
    End Enum
    ''' <summary>
    ''' 
    ''' </summary>
    Public Enum Transactions
        txtGUID
        datRecordCreated
        booIsDeleted
        datTransactionDate
        decAmount
        txtFromAccountID
        txtToAccountID
        txtTransactionType
        booIsCompleted
    End Enum

#End Region

#End Region

#Region "Objects"

#End Region

#Region "Variables"

#End Region

#Region "Methods"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Function DBConnectionString() As String
        Dim LocalDBFullPath = LocalDBPath & LocalDBFileName
        Return (String.Format("Data Source = {0}", LocalDBFullPath))
    End Function

#End Region

#Region "Events"

#End Region

#Region "Event Handlers"

#End Region

#Region "Methods"

#End Region


End Module
