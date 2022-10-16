Option Strict On
Option Explicit On


Module modGLobal

#Region "Constants"
    Public Const LocalDBPath As String = "C:\ProgramData\Budget\"
    Public Const LocalDBFileName As String = "Budget.db"
#End Region

#Region "Variables"


#End Region


#Region "Properties"

#End Region


#Region "Enumerations"

    Public Enum AccountTypes
        Income
        Cash
        Savings
        Debt
        Expense
    End Enum

    Public Enum TransactionTypes
        Earn
        Save
        Reallocate
        Liquidate
        Payoff
        Spend_Cash
        Spend_on_Credit
        Borrow_Cash
    End Enum

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

#Region "Datatable Enums"
    Public Enum Account
        txtGUID
        datRecordCreated
        booIsDeleted
        txtAccountName
        decStartingBalance
        datDateOfStartingBalance
        txtAccountType
        txtSubAccountToAccountName
    End Enum

    Public Enum Transaction
        txtGUID
        datRecordCreated
        booIsDeleted
        datTransactionDate
        decAmount
        txtFromAccount
        txtToAccount
        txtTransactionType
        booIsCompleted
    End Enum

    Public Enum CalculatedAccountBalance
        txtGUID
        datRecordCreated
        booIsDeleted
        txtAccountGUID
        decBalance
    End Enum
#End Region

#End Region

#Region "Objects"
    'Default accounts
    Public Checking As Account
    Public Saving As Account
    Public Income As Account
    Public Rent As Account
    Public Mortgage As Account
    Public Utilties As Account
    Public Fuel As Account
    Public Food As Account
    Public Car_Insurance As Account
    Public Health_Care As Account
    Public Credit_Card_Debt As Account
    Public Save_For_Car_Maintenance As Account
    Public Clothing As Account
    Public Save_For_School_Expense As Account
    Public Save_For_Vacation As Account
    Public Save_For_Gifts As Account

#End Region

#Region "Variables"

#End Region

#Region "Methods"

    Public Function DBConnectionString() As String
        Dim LocalDBFullPath = LocalDBPath & LocalDBFileName
        Return (String.Format("Data Source = {0}", LocalDBFullPath))
    End Function

    Public Sub CreateDataBase()

    End Sub


    Public Sub InitializeDefaultAccounts()

    End Sub




#End Region

#Region "Events"

#End Region

#Region "Event Handlers"

#End Region

#Region "Methods"

#End Region


End Module
