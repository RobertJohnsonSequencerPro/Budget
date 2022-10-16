Option Strict On
Option Explicit On


Module StructsEnumsVariables


#Region "Enumerations"


#End Region

#Region "Structures"
    Public Structure AccountTypes
        Const Income = "Income"
        Const Cash = "Cash"
        Const Savings = "Savings"
        Const Debt = "Debt"
        Const Expense = "Expense"
    End Structure

    Public Structure TransactionTypes
        Const Earn = "Earn"
        Const Save = "Save"
        Const Reallocate = "Reallocate"
        Const Liquidate = "Liquidate"
        Const Payoff = "Payoff"
        Const Spend_Cash = "Spend Cash"
        Const Spend_on_Credit = "Spend on Credit"
        Const Borrow_Cash = "Borrow Cash"
    End Structure
#End Region

End Module
