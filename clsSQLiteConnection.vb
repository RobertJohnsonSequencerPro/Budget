Option Strict On
Option Explicit On

Imports System.Data.SQLite


Public Class clsSQLiteConnection
    Dim Path As String = "C:\Users\Public\Documents\SequencerPro"
    Dim Filename As String = "SpendingPlannerDB.db"
    Dim FullPath As String = System.IO.Path.Combine(Path, Filename)
    Public ConnectionString As String = String.Format("Data Source = {0}", FullPath)
    Dim SQLiteDatabaseAdapter As New SQLiteDataAdapter


    Public Sub New()

    End Sub

    Public Function CreateSQLiteDatabase() As Boolean
        'Check if the database already exists. If not, then create it and add the users table and add one admin user
        If Not DatabaseExists(FullPath) Then
            If DirectoryExists(Path) = False Then
                CreateDirectory(Path)
            End If
        End If

        CreateTableFromEnum(GetType(modGLobal.Account))
        CreateTableFromEnum(GetType(modGLobal.Transaction))
        CreateTableFromEnum(GetType(modGLobal.CalculatedAccountBalance))

        Return True
    End Function

    Public Function CreateTableFromEnum(ByRef Enumeration As Type) As Boolean
        'This function assumes that the Enum name is the desired table name and that each item in the enum is a desired column name.
        'It further assumes that the first 3 letters of the column name indicate the data type.
        'All tables are created with a few utility columns - txtGUID, booIsDeleted, and datRecordCreated

        Try
            CreateATableInDatabase(Enumeration.Name)
            Dim Columns As Array = System.Enum.GetNames(Enumeration)
            For Each ColumnName As String In Columns
                Dim Prefix As String = ColumnName.Substring(0, 3)
                Select Case Prefix
                    Case modGLobal.SQLiteDataTypePrefixes.txt.ToString
                        AddAColumnToATable(Enumeration.Name, ColumnName, "TEXT")
                    Case modGLobal.SQLiteDataTypePrefixes.dec.ToString
                        AddAColumnToATable(Enumeration.Name, ColumnName, "REAL")
                    Case modGLobal.SQLiteDataTypePrefixes.blb.ToString
                        AddAColumnToATable(Enumeration.Name, ColumnName, "BLOB")
                    Case modGLobal.SQLiteDataTypePrefixes.int.ToString
                        AddAColumnToATable(Enumeration.Name, ColumnName, "INTEGER")
                    Case modGLobal.SQLiteDataTypePrefixes.boo.ToString
                        AddAColumnToATable(Enumeration.Name, ColumnName, "INTEGER")
                    Case modGLobal.SQLiteDataTypePrefixes.dat.ToString
                        AddAColumnToATable(Enumeration.Name, ColumnName, "TEXT")
                    Case modGLobal.SQLiteDataTypePrefixes.dbl.ToString
                        AddAColumnToATable(Enumeration.Name, ColumnName, "REAL")
                    Case Else
                        MessageBox.Show("The data type " & Prefix & " is not recognized.")
                End Select
            Next
        Catch ex As Exception
            MessageBox.Show("Error in clsSQLiteConnection.CreateTableFromEnum. Error is " & ex.Message)
            Return False
        End Try
        Return True
    End Function

    Private Function DatabaseExists(Fullpath As String) As Boolean
        Return System.IO.File.Exists(Fullpath)
    End Function

    Public Function AddAColumnToATable(TableName As String, ColumnName As String, DataType As String) As Boolean
        'Allowed DataTypes are INTEGER, TEXT, BLOB, REAL, NUMERIC
        Try
            Using SQLiteConn As New SQLiteConnection(ConnectionString)
                Dim dt As New DataTable
                'MessageBox.Show("SELECT * FROM '" & TableName & "'")
                SQLiteDatabaseAdapter = New SQLiteDataAdapter("SELECT * FROM '" & TableName & "'", SQLiteConn)
                SQLiteConn.Open()
                Dim DatabaseAdapterCommandBuilder As SQLiteCommandBuilder = New SQLiteCommandBuilder(SQLiteDatabaseAdapter)
                SQLiteDatabaseAdapter.Fill(dt)
                If dt.Columns.Contains(ColumnName) Then
                    'The column already exists so do not add it.
                    Return True
                End If
                'MessageBox.Show("ALTER TABLE " & TableName & " ADD COLUMN '" & ColumnName & "' " & DataType)
                Dim AddColumnQuery As String = "ALTER TABLE '" & TableName & "' ADD COLUMN '" & ColumnName & "' " & DataType
                Dim cmd2 As New SQLiteCommand(AddColumnQuery, SQLiteConn)
                cmd2.ExecuteNonQuery()
                SQLiteConn.Close()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error in clsSQLiteConnection.AddAColumnToATable. The error is " & ex.Message)
            Return False
        End Try
    End Function

    Public Sub AddDefaultsToDatabase()
        Dim SQLiteServer As New clsSQLiteConnection
        Dim dtAccounts As New DataTable
        SQLiteServer.PopulateADataTable(dtAccounts, "accounts")
        If dtAccounts.Rows.Count < 1 Then
            Dim dr1 As DataRow = dtAccounts.NewRow
            dr1.Item("AccountName") = "Save for Vacation"
            dr1.Item("StartingBalance") = 100
            dr1.Item("AccountType") = AccountTypes.Savings
            dr1.Item("DateOfStartingBalance") = Now.ToString
            dr1.Item("isDeleted") = 0
            dtAccounts.Rows.Add(dr1)
            Dim dr2 As DataRow = dtAccounts.NewRow
            dr2.Item("AccountName") = "Checking"
            dr2.Item("StartingBalance") = 100
            dr2.Item("AccountType") = AccountTypes.Cash
            dr2.Item("DateOfStartingBalance") = Now.ToString
            dr2.Item("isDeleted") = 0
            dtAccounts.Rows.Add(dr2)
            Dim dr3 As DataRow = dtAccounts.NewRow
            dr3.Item("AccountName") = "Income from Allowance"
            dr3.Item("StartingBalance") = 0
            dr3.Item("AccountType") = AccountTypes.Income
            dr3.Item("DateOfStartingBalance") = Now.ToString
            dr3.Item("isDeleted") = 0
            dtAccounts.Rows.Add(dr3)
            Dim dr4 As DataRow = dtAccounts.NewRow
            dr4.Item("AccountName") = "School Expense"
            dr4.Item("StartingBalance") = 0
            dr4.Item("AccountType") = AccountTypes.Expense
            dr4.Item("DateOfStartingBalance") = Now.ToString
            dr4.Item("isDeleted") = 0
            dtAccounts.Rows.Add(dr4)
            Dim dr5 As DataRow = dtAccounts.NewRow
            dr5.Item("AccountName") = "Credit Card 1"
            dr5.Item("StartingBalance") = -750
            dr5.Item("AccountType") = AccountTypes.Debt
            dr5.Item("DateOfStartingBalance") = Now.ToString
            dr5.Item("isDeleted") = 0
            dtAccounts.Rows.Add(dr5)
            Dim dr6 As DataRow = dtAccounts.NewRow
            dr6.Item("AccountName") = "Transportation Expense"
            dr6.Item("StartingBalance") = 0
            dr6.Item("AccountType") = AccountTypes.Expense
            dr6.Item("DateOfStartingBalance") = Now.ToString
            dr6.Item("isDeleted") = 0
            dtAccounts.Rows.Add(dr6)
        End If
        SaveADataTable(dtAccounts, "accounts")

        Dim dtPlannedTransactions As New DataTable
        SQLiteServer.PopulateADataTable(dtPlannedTransactions, "PlannedTransactions")
        If dtPlannedTransactions.Rows.Count < 1 Then
            Dim dr2 As DataRow = dtPlannedTransactions.NewRow
            dr2.Item("Date") = "1/1/2022"
            dr2.Item("Amount") = 150
            dr2.Item("FromAccountName") = "Cash"
            dr2.Item("ToAccountName") = "Save for Vacation"
            dr2.Item("TransactionType") = TransactionTypes.Save
            dtPlannedTransactions.Rows.Add(dr2)

            Dim dr1 As DataRow = dtPlannedTransactions.NewRow
            dr1.Item("Date") = "9/1/2022"
            dr1.Item("Amount") = 4000
            dr1.Item("FromAccountName") = "Save for Vacation"
            dr1.Item("ToAccountName") = "Cash"
            dr1.Item("TransactionType") = TransactionTypes.Liquidate
            dtPlannedTransactions.Rows.Add(dr1)
        End If
        SaveADataTable(dtPlannedTransactions, "PlannedTransactions")

        Dim dtActualTransactions As New DataTable
        SQLiteServer.PopulateADataTable(dtActualTransactions, "ActualTransactions")
        If dtActualTransactions.Rows.Count < 1 Then
            Dim dr2 As DataRow = dtActualTransactions.NewRow
            dr2.Item("Date") = "1/1/2022"
            dr2.Item("Amount") = 150
            dr2.Item("FromAccountName") = "Checking"
            dr2.Item("ToAccountName") = "Credit Card 1"
            dr2.Item("TransactionType") = TransactionTypes.Payoff
            dtActualTransactions.Rows.Add(dr2)
            SQLiteServer.PopulateADataTable(dtActualTransactions, "ActualTransactions")

            Dim dr1 As DataRow = dtActualTransactions.NewRow
            dr1.Item("Date") = "1/2/2022"
            dr1.Item("Amount") = 300
            dr1.Item("FromAccountName") = "Cash"
            dr1.Item("ToAccountName") = "Save For Vacation"
            dr1.Item("TransactionType") = TransactionTypes.Save
            dtActualTransactions.Rows.Add(dr1)
        End If
        SaveADataTable(dtActualTransactions, "ActualTransactions")
    End Sub

    'Public Function CreateCustomGUID(Seed As String) As String
    '    Seed = Seed & Guid.NewGuid.ToString & DateTime.Now.Ticks.ToString
    '    Seed = Seed & DateTime.Now.Ticks.ToString
    '    Return Seed
    'End Function

    Public Function CreateGraphPoints(AccountName As String, EndDate As Date) As Boolean
        Dim dtGraphPoints As New DataTable
        PopulateDataTableMatchString(dtGraphPoints, "AccountGraphs", "AccountName", AccountName)
        For Each dr As DataRow In dtGraphPoints.Rows
            dr.Delete()
        Next dr
        Dim dtTransactionList As New DataTable
        PopulateDataTableMatchString(dtTransactionList, "Transactions", "FromAccount", AccountName)
        MessageBox.Show(dtTransactionList.Rows.Count.ToString)
        PopulateDataTableMatchString(dtTransactionList, "Transactions", "ToAccount", AccountName)
        MessageBox.Show(dtTransactionList.Rows.Count.ToString)
        Dim dtAccountInfo As New DataTable
        PopulateDataTableMatchString(dtAccountInfo, "Accounts", "AccountName", AccountName)
        Dim StartDate As Date = CDate(dtAccountInfo.Rows(0).Item("DateOfStartingBalance"))
        MessageBox.Show(StartDate.ToString)
        Dim StartingBalance As Decimal = CDec(dtAccountInfo.Rows(0).Item("StartingBalance"))
        MessageBox.Show(StartingBalance.ToString)
        Dim NumberOfDays As Integer = (EndDate - StartDate).Days
        MessageBox.Show(NumberOfDays.ToString)
        Dim RunningBalance As Decimal = StartingBalance
        Dim RunningDate As Date = StartDate
        Do While RunningDate < EndDate
            RunningDate = RunningDate.AddDays(1)
            For Each dr As DataRow In dtTransactionList.Rows
                If CDate(dr.Item("Date")).Date = RunningDate.Date Then
                    If dr.Item("ToAccount").ToString = AccountName Then
                        RunningBalance = RunningBalance + CDec(dr.Item("Amount"))
                    ElseIf dr.Item("FromAccount").ToString = AccountName Then
                        RunningBalance = RunningBalance - CDec(dr.Item("Amount"))
                    End If
                End If
            Next
            Dim drNewGraphPoint As DataRow = dtGraphPoints.NewRow
            drNewGraphPoint.Item("AccountName") = AccountName
            drNewGraphPoint.Item("Amount") = RunningBalance
            drNewGraphPoint.Item("Date") = RunningDate
        Loop
        SaveADataTable(dtGraphPoints, "AccountGraphs")
        Return True
    End Function

    Public Function CreateATableInDatabase(TableName As String) As Boolean
        'Create a table in the SQLite database created by this class

        Try
            Using SQLConn As New SQLiteConnection(ConnectionString)
                Dim CreateTableQuery As String = "CREATE table If Not EXISTS '" & TableName & "' ('txtGUID' STRING PRIMARY KEY UNIQUE, 'booIsDeleted' INTEGER, 'datRecordCreated' STRING);"
                Dim cmd As New SQLiteCommand(CreateTableQuery, SQLConn)
                SQLConn.Open()
                cmd.ExecuteNonQuery()
                SQLConn.Close()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error in CreateATable. " & ex.Message)
            Return False
        End Try
    End Function

    Public Function PopulateADataTable(ByRef TargetDataTable As DataTable, TableName As String) As Boolean

        Try
            If TableName = "" Then
                Return False
            End If
            Using SQLIteConn As New SQLiteConnection(ConnectionString)
                SQLIteConn.Open()
                SQLiteDatabaseAdapter = New SQLiteDataAdapter("SELECT * FROM '" & TableName & "'", SQLIteConn)
                Dim DatabaseAdapterCommandBuilder As SQLiteCommandBuilder = New SQLiteCommandBuilder(SQLiteDatabaseAdapter)
                SQLiteDatabaseAdapter.Fill(TargetDataTable)
                SQLIteConn.Close()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error in clsSQLiteServer.PopulateADataTable. TableName = " & TableName & " " & ex.Message)
            Return False
        End Try
    End Function

    Public Function PopulateADataTableFiltered(ByRef dtTargetDataTable As DataTable, TableName As String, SearchColumnName As String, StringToSearchFor As String) As Boolean

        Try
            If TableName = "" Then
                Return False
            End If
            dtTargetDataTable.Clear()
            Using SQLIteConn As New SQLiteConnection(ConnectionString)
                SQLIteConn.Open()
                SQLiteDatabaseAdapter = New SQLiteDataAdapter("SELECT * FROM '" & TableName & "' WHERE " & SearchColumnName & " = '" & StringToSearchFor & "'", SQLIteConn)
                Dim DatabaseAdapterCommandBuilder As SQLiteCommandBuilder = New SQLiteCommandBuilder(SQLiteDatabaseAdapter)
                SQLiteDatabaseAdapter.Fill(dtTargetDataTable)
                SQLIteConn.Close()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error in clsSQLiteServer.PopulateADataTableFiltered. TableName = '" & TableName & "' " & ex.Message)
            Return False
        End Try
    End Function

    Public Function PopulateADataTableFilteredByTwoFields(ByRef dtTargetDataTable As DataTable, TableName As String, FirstSearchColumnName As String, FirstStringToSearchFor As String, SecondSearchColumnName As String, SecondStringToSearchFor As String) As Boolean


        Try
            If TableName = "" Then
                Return False
            End If
            dtTargetDataTable.Clear()
            Using SQLIteConn As New SQLiteConnection(ConnectionString)
                SQLIteConn.Open()
                SQLiteDatabaseAdapter = New SQLiteDataAdapter("SELECT * FROM '" & TableName & "' WHERE " & FirstSearchColumnName & " = '" & FirstStringToSearchFor & "' AND " & SecondSearchColumnName & "='" & SecondStringToSearchFor & "'", SQLIteConn)
                Dim DatabaseAdapterCommandBuilder As SQLiteCommandBuilder = New SQLiteCommandBuilder(SQLiteDatabaseAdapter)
                SQLiteDatabaseAdapter.Fill(dtTargetDataTable)
                SQLIteConn.Close()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error in clsSQLiteServer.PopulateADataTableFilteredByTwoFields. TableName = " & TableName & " " & ex.Message)
            Return False
        End Try
    End Function

    Public Function PopulateADataTableFilteredByBoolean(ByRef dtTargetDataTable As DataTable, TableName As String, BooleanColumnName As String, BooleanValue As Boolean) As Boolean


        Try
            If TableName = "" Then
                Return False
            End If
            dtTargetDataTable.Clear()
            Using SQLIteConn As New SQLiteConnection(ConnectionString)
                SQLIteConn.Open()
                SQLiteDatabaseAdapter = New SQLiteDataAdapter("SELECT * FROM '" & TableName & "' WHERE " & BooleanColumnName & " = " & BooleanValue, SQLIteConn)
                Dim DatabaseAdapterCommandBuilder As SQLiteCommandBuilder = New SQLiteCommandBuilder(SQLiteDatabaseAdapter)
                SQLiteDatabaseAdapter.Fill(dtTargetDataTable)
                SQLIteConn.Close()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error in clsSQLiteServer.PopulateADataTableFiltered. TableName = " & TableName & " " & ex.Message)
            Return False
        End Try
    End Function

    Public Function PopulateADataTableFilteredByBooleanAndLimitRows(ByRef dtTargetDataTable As DataTable, TableName As String, BooleanColumnName As String, BooleanValue As Boolean, OrderByColumn As String, Optional OrderDescending As Boolean = False, Optional NumberOfRows As Integer = 1000, Optional StartFromRow As Integer = 0) As Boolean


        Try
            If TableName = "" Then
                Return False
            End If
            Dim OrderDirection As String = "ASC"
            If OrderDescending = True Then
                OrderDirection = "DESC"
            End If
            dtTargetDataTable.Clear()
            Using SQLIteConn As New SQLiteConnection(ConnectionString)
                SQLIteConn.Open()
                'MessageBox.Show("SELECT * FROM " & TableName & " WHERE " & BooleanColumnName & " = " & BooleanValue & " ORDER BY " & OrderByColumn & " " & OrderDirection & " LIMIT " & NumberOfRows & " OFFSET " & StartFromRow & ";")
                SQLiteDatabaseAdapter = New SQLiteDataAdapter("SELECT * FROM '" & TableName & "' WHERE " & BooleanColumnName & " = " & BooleanValue & " ORDER BY " & OrderByColumn & " " & OrderDirection & " LIMIT " & NumberOfRows & " OFFSET " & StartFromRow & ";", SQLIteConn)
                Dim DatabaseAdapterCommandBuilder As SQLiteCommandBuilder = New SQLiteCommandBuilder(SQLiteDatabaseAdapter)
                SQLiteDatabaseAdapter.Fill(dtTargetDataTable)
                SQLIteConn.Close()
                'MessageBox.Show(dtTargetDataTable.Rows.Count.ToString)
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error in clsSQLiteServer.PopulateADataTableFilteredByBooleanAndLimitRows. TableName = " & TableName & " " & ex.Message)
            Return False
        End Try
    End Function

    Public Function PopulateDataTableMatchString(ByRef dt As DataTable, TableName As String, MatchField As String, MatchValue As String) As Boolean

        Try
            Using SQLIteConn As New SQLiteConnection(ConnectionString)
                SQLIteConn.Open()
                SQLiteDatabaseAdapter = New SQLiteDataAdapter("SELECT * FROM '" & TableName & "' WHERE " & MatchField & "='" & MatchValue & "';", SQLIteConn)
                Dim DatabaseAdapterCommandBuilder As SQLiteCommandBuilder = New SQLiteCommandBuilder(SQLiteDatabaseAdapter)
                SQLiteDatabaseAdapter.Fill(dt)
                SQLIteConn.Close()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error in populate a DataTable matching string. " & ex.Message)
            Return False
        End Try
    End Function

    Public Function PopulateAdataTableLimitNumberOfRows(ByRef dtTargetDataTable As DataTable, TableName As String, OrderByColumn As String, Optional OrderDescending As Boolean = False, Optional NumberOfRows As Integer = 1000, Optional StartFromRow As Integer = 0) As Boolean

        Try
            If TableName = "" Then
                Return False
            End If
            Dim OrderDirection As String = "ASC"
            If OrderDescending = True Then
                OrderDirection = "DESC"
            End If
            Using SQLIteConn As New SQLiteConnection(ConnectionString)
                SQLIteConn.Open()
                'MessageBox.Show("SELECT * FROM '" & TableName & "' ORDER BY " & OrderByColumn & " " & OrderDirection & " LIMIT " & NumberOfRows & " OFFSET " & StartFromRow & ";")
                SQLiteDatabaseAdapter = New SQLiteDataAdapter("SELECT * FROM '" & TableName & "' ORDER BY " & OrderByColumn & " " & OrderDirection & " LIMIT " & NumberOfRows & " OFFSET " & StartFromRow & ";", SQLIteConn)
                Dim DatabaseAdapterCommandBuilder As SQLiteCommandBuilder = New SQLiteCommandBuilder(SQLiteDatabaseAdapter)
                SQLiteDatabaseAdapter.Fill(dtTargetDataTable)
                SQLIteConn.Close()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error in clsSQLiteServer.PopulateADataTableLimitNumberOfRows. TableName = " & TableName & " " & ex.Message)
            Return False
        End Try
    End Function

    Public Function PopulateAdataTableFilteredAndLimitNumberOfRows(ByRef dtTargetDataTable As DataTable, TableName As String, SearchColumnName As String, StringToSearchFor As String, OrderByColumn As String, Optional OrderDescending As Boolean = False, Optional NumberOfRows As Integer = 1000, Optional StartFromRow As Integer = 0) As Boolean


        Try
            If TableName = "" Then
                Return False
            End If
            Dim OrderDirection As String = "ASC"
            If OrderDescending = True Then
                OrderDirection = "DESC"
            End If
            Using SQLIteConn As New SQLiteConnection(ConnectionString)
                SQLIteConn.Open()
                SQLiteDatabaseAdapter = New SQLiteDataAdapter("SELECT * FROM '" & TableName & "' WHERE " & SearchColumnName & " = '" & StringToSearchFor & "' ORDER BY " & OrderByColumn & " " & OrderDirection & " LIMIT " & NumberOfRows & " OFFSET " & StartFromRow & ";", SQLIteConn)
                Dim DatabaseAdapterCommandBuilder As SQLiteCommandBuilder = New SQLiteCommandBuilder(SQLiteDatabaseAdapter)
                SQLiteDatabaseAdapter.Fill(dtTargetDataTable)
                SQLIteConn.Close()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error in clsSQLiteServer.PopulateADataTableLimitNumberOfRows. TableName = " & TableName & " " & ex.Message)
            Return False
        End Try
    End Function

    Public Function PopulateADataTableByDateRange(ByRef dtTargetDataTable As DataTable, TableName As String, DateField As String, StartDate As Date, EndDate As Date) As Boolean


        Try
            If TableName = "" Then
                Return False
            End If
            Using SQLIteConn As New SQLiteConnection(ConnectionString)
                SQLIteConn.Open()
                SQLiteDatabaseAdapter = New SQLiteDataAdapter("SELECT * FROM '" & TableName & "' WHERE NOT (" & DateField & " > '" & EndDate & "' OR " & DateField & " < '" & StartDate & "')", SQLIteConn)
                Dim DatabaseAdapterCommandBuilder As SQLiteCommandBuilder = New SQLiteCommandBuilder(SQLiteDatabaseAdapter)
                SQLiteDatabaseAdapter.Fill(dtTargetDataTable)
                SQLIteConn.Close()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error in clsSQLiteServer.PopulateADataTableByDateRange. TableName = " & TableName & " " & ex.Message)
            Return False
        End Try
    End Function

    Public Function SaveADataTable(ByRef dt As DataTable, TableNameInDataBase As String) As Boolean


        Try
            Using SQLiteConn As New SQLiteConnection(ConnectionString)
                SQLiteConn.Open()
                SQLiteDatabaseAdapter = New SQLiteDataAdapter("SELECT * FROM '" & TableNameInDataBase & "'", SQLiteConn)
                Dim DatabaseAdapterCommandBuilder As SQLiteCommandBuilder = New SQLiteCommandBuilder(SQLiteDatabaseAdapter)
                SQLiteDatabaseAdapter.DeleteCommand = DatabaseAdapterCommandBuilder.GetDeleteCommand
                SQLiteDatabaseAdapter.UpdateCommand = DatabaseAdapterCommandBuilder.GetUpdateCommand
                SQLiteDatabaseAdapter.InsertCommand = DatabaseAdapterCommandBuilder.GetInsertCommand
                SQLiteDatabaseAdapter.Update(dt)
                SQLiteConn.Close()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error in SaveADataTable" & vbCrLf & ex.Message)
        End Try
        Return False
    End Function

    'Public Function AddARowToADataset(TableName As String, TargetDataset As DataSet, SourceDataRow As DataRow) As Boolean
    '    'This function assumes that the source datarow has the same structure as the targeted datatable.
    '    TargetDataset.Tables(TableName).Rows.Add(SourceDataRow)
    '    Return True
    'End Function

    Public Function AddARowToADataTable(ByRef TargetDataTable As DataTable, ByRef SourceDataRow As DataRow) As Boolean
        'This function assumes that the source datarow has the same structure as the targeted datatable.
        TargetDataTable.Rows.Add(SourceDataRow)
        Return True
    End Function

    Public Function UpdateARowInADataset(ByRef TargetDataSet As DataSet, TableName As String, ByRef UpdatedDataRow As DataRow, MatchingItem As String) As Boolean
        'This function updates a datrow in an existing datatable with name TableName. The function searches the rows in the table for 
        'a matching value between the UpdatedRow and the Row that will be updated. Normally this would be the the Primary Key and would
        'be a GUID, but potentially you can match on any field/item/column.
        For Each dr As DataRow In TargetDataSet.Tables(TableName).Rows
            If dr.Item(MatchingItem) Is UpdatedDataRow.Item(MatchingItem) Then
                dr.ItemArray = UpdatedDataRow.ItemArray
            End If
        Next dr
        Return False
    End Function

    Private Function DirectoryExists(Path As String) As Boolean
        Return System.IO.Directory.Exists(Path)
    End Function

    Public Function CreateDirectory(Path As String) As Boolean
        Try
            My.Computer.FileSystem.CreateDirectory(Path)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function CreateGUID() As String
        Dim NewGUID As String = Guid.NewGuid.ToString
        Return NewGUID
    End Function

    Public Function PopulateDataRowMatchString(ByRef dr As DataRow, TableName As String, MatchField As String, MatchValue As String) As Boolean

        Dim dtTemporary As New DataTable
        Try
            Using SQLIteConn As New SQLiteConnection(ConnectionString)
                SQLIteConn.Open()
                SQLiteDatabaseAdapter = New SQLiteDataAdapter("SELECT * FROM '" & TableName & "' WHERE " & MatchField & "='" & MatchValue & "';", SQLIteConn)
                Dim DatabaseAdapterCommandBuilder As SQLiteCommandBuilder = New SQLiteCommandBuilder(SQLiteDatabaseAdapter)
                SQLiteDatabaseAdapter.Fill(dtTemporary)
                SQLIteConn.Close()
                For Each drDataRow As DataRow In dtTemporary.Rows
                    If drDataRow.Item(MatchField).ToString = MatchValue Then
                        dr = drDataRow
                        Return True
                    End If
                Next drDataRow
                Return False
            End Using
        Catch ex As Exception
            MessageBox.Show("Error in populate a DataTable matching string. " & ex.Message)
            Return False
        End Try
    End Function

    Public Function PopulateDataTableByContainedString(ByRef dt As DataTable, TableName As String, Field As String, ContainedString As String, Optional MaxRows As Integer = 1000) As Boolean
        'Note: as of 27MAR2022 this function has not been tested for correct behavior.

        Try
            Using SQLIteConn As New SQLiteConnection(ConnectionString)
                SQLIteConn.Open()
                SQLiteDatabaseAdapter = New SQLiteDataAdapter("SELECT * FROM '" & TableName & "' WHERE " & Field & " LIKE '%" & ContainedString & "%' LIMIT " & MaxRows & ";", SQLIteConn)
                Dim DatabaseAdapterCommandBuilder As SQLiteCommandBuilder = New SQLiteCommandBuilder(SQLiteDatabaseAdapter)
                SQLiteDatabaseAdapter.Fill(dt)
                SQLIteConn.Close()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error in populate a DataTable matching contained string. " & ex.Message)
            Return False
        End Try
    End Function

    Public Function PopulateDataTableByContainedStringLimitTo16Rows(ByRef dt As DataTable, TableName As String, Field As String, ContainedString As String, OrderByColumn As String) As Boolean

        Try
            Using SQLIteConn As New SQLiteConnection(ConnectionString)
                SQLIteConn.Open()
                SQLiteDatabaseAdapter = New SQLiteDataAdapter("SELECT * FROM '" & TableName & "' WHERE " & Field & " LIKE '%" & ContainedString & "%' ORDER BY " & OrderByColumn & " ASC LIMIT " & 16 & ";", SQLIteConn)
                Dim DatabaseAdapterCommandBuilder As SQLiteCommandBuilder = New SQLiteCommandBuilder(SQLiteDatabaseAdapter)
                SQLiteDatabaseAdapter.Fill(dt)
                SQLIteConn.Close()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error in populate a DataTable matching contained string limit to 20 rows. " & ex.Message)
            Return False
        End Try
    End Function

    Public Function CreateEmptyDataTableFromSchema(ByRef dt As DataTable, TableName As String) As Boolean

        Try
            Using SQLIteConn As New SQLiteConnection(ConnectionString)
                SQLIteConn.Open()
                SQLiteDatabaseAdapter = New SQLiteDataAdapter("SELECT * FROM '" & TableName & "' LIMIT 0;", SQLIteConn)
                Dim DatabaseAdapterCommandBuilder As SQLiteCommandBuilder = New SQLiteCommandBuilder(SQLiteDatabaseAdapter)
                SQLiteDatabaseAdapter.Fill(dt)
                SQLIteConn.Close()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Could not create empty table from schema for table " & TableName & ". " & ex.Message)
            Return False
        End Try
    End Function

    Public Function CreateSingleColumnIndex(TableName As String, ColumnName As String) As Boolean

        Try
            Using SQLiteConn As New SQLiteConnection(ConnectionString)
                Dim CreateIndex As String = "CREATE INDEX idx_" & TableName & "_" & ColumnName & " ON '" & TableName & "' (" & ColumnName & ");"
                Dim cmd As New SQLiteCommand(CreateIndex, SQLiteConn)
                SQLiteConn.Open()
                cmd.ExecuteNonQuery()
                SQLiteConn.Close()
                Return True
            End Using

        Catch ex As Exception

        End Try
        Return False
    End Function

    Public Function CreateSingleColumnIndexUnique(TableName As String, ColumnName As String) As Boolean

        Try
            Using SQLiteConn As New SQLiteConnection(ConnectionString)
                Dim CreateIndex As String = "CREATE UNIQUE INDEX idx_" & TableName & "_" & ColumnName & " ON " & TableName & "(" & ColumnName & ");"
                Dim cmd As New SQLiteCommand(CreateIndex, SQLiteConn)
                SQLiteConn.Open()
                cmd.ExecuteNonQuery()
                SQLiteConn.Close()
                Return True
            End Using

        Catch ex As Exception

        End Try
        Return False
    End Function

    Public Function CreateTwoColumnIndex(TableName As String, FirstColumnName As String, SecondColumnName As String) As Boolean

        Try
            Using SQLiteConn As New SQLiteConnection(ConnectionString)
                Dim CreateIndex As String = "CREATE INDEX idx_" & TableName & "_" & FirstColumnName & "_" & SecondColumnName & " ON " & TableName & "(" & FirstColumnName & ", " & SecondColumnName & ");"
                Dim cmd As New SQLiteCommand(CreateIndex, SQLiteConn)
                SQLiteConn.Open()
                cmd.ExecuteNonQuery()
                SQLiteConn.Close()
                Return True
            End Using

        Catch ex As Exception

        End Try
        Return False
    End Function

    Public Function CreateThreeColumnIndex(TableName As String, FirstColumnName As String, SecondColumnName As String, ThirdColumnName As String) As Boolean

        Try
            Using SQLiteConn As New SQLiteConnection(ConnectionString)
                Dim CreateIndex As String = "CREATE INDEX idx_" & TableName & "_" & FirstColumnName & "_" & SecondColumnName & "_" & ThirdColumnName & " ON " & TableName & "(" & FirstColumnName & ", " & SecondColumnName & ", " & ThirdColumnName & ");"
                Dim cmd As New SQLiteCommand(CreateIndex, SQLiteConn)
                SQLiteConn.Open()
                cmd.ExecuteNonQuery()
                SQLiteConn.Close()
                Return True
            End Using

        Catch ex As Exception

        End Try
        Return False
    End Function



    Public Function CreateAJoinedTable(Table1Name As String, Table2Name As String, JoinOnTable1ColumnName As String, JoinOnTable2ColumnName As String, Optional InnerJoin As Boolean = True) As DataTable
        Dim dtTemp As New DataTable
        Try
            If InnerJoin Then
                Using SQLiteConn As New SQLiteConnection()
                    SQLiteConn.ParseViaFramework = True
                    'Set ParseViaFramework to true to avoid a parsing error for network files. See https://system.data.sqlite.org/index.html/info/bbdds6eae2
                    SQLiteConn.Open()
                    Dim NewDatabaseAdapter = New SQLiteDataAdapter("SELECT * FROM " & Table1Name & " INNER JOIN " & Table2Name & " ON " & Table1Name & "." & JoinOnTable1ColumnName & " = " & Table2Name & "." & JoinOnTable2ColumnName & " ORDER BY " & Table1Name & "." & JoinOnTable1ColumnName & ";", SQLiteConn)
                    Dim DatabaseAdaterCommandBuilder As SQLiteCommandBuilder = New SQLiteCommandBuilder(NewDatabaseAdapter)
                    NewDatabaseAdapter.Fill(dtTemp)
                    SQLiteConn.Close()
                End Using
                Return dtTemp
            Else
                dtTemp = CreateAJoinedTable(Table1Name, Table2Name, JoinOnTable1ColumnName, JoinOnTable2ColumnName, True, False)
                Return dtTemp
            End If

        Catch ex As Exception

        End Try
        Return dtTemp
    End Function

    Public Function CreateAJoinedTable(Table1Name As String, Table2Name As String, JoinOnTable1ColumnName As String, JoinOnTable2ColumnName As String, Optional FullJoin As Boolean = True, Optional LeftJoin As Boolean = True) As DataTable
        Dim dtTemp As New DataTable
        Try
            If FullJoin Then
                Using SQLiteConn As New SQLiteConnection()
                    SQLiteConn.ParseViaFramework = True
                    'Set ParseViaFramework to true to avoid a parsing error for network files. See https://system.data.sqlite.org/index.html/info/bbdds6eae2
                    SQLiteConn.Open()
                    Dim NewDatabaseAdapter = New SQLiteDataAdapter("SELECT * FROM " & Table1Name & " LEFT JOIN " & Table2Name & " ON " & Table1Name & "." & JoinOnTable1ColumnName & " = " & Table2Name & "." & JoinOnTable2ColumnName & " UNION ALL SELECT * FROM " & Table2Name & " LEFT JOIN " & Table1Name & " ON " & Table2Name & "." & JoinOnTable2ColumnName & " = " & Table1Name & "." & JoinOnTable1ColumnName & " ORDER BY " & Table1Name & "." & JoinOnTable1ColumnName & ";", SQLiteConn)
                    Dim DatabaseAdaterCommandBuilder As SQLiteCommandBuilder = New SQLiteCommandBuilder(NewDatabaseAdapter)
                    NewDatabaseAdapter.Fill(dtTemp)
                    SQLiteConn.Close()
                End Using
                Return dtTemp
            ElseIf LeftJoin Then
                Using SQLiteConn As New SQLiteConnection()
                    SQLiteConn.ParseViaFramework = True
                    'Set ParseViaFramework to true to avoid a parsing error for network files. See https://system.data.sqlite.org/index.html/info/bbdds6eae2
                    SQLiteConn.Open()
                    Dim NewDatabaseAdapter = New SQLiteDataAdapter("SELECT * FROM " & Table1Name & " LEFT JOIN " & Table2Name & " ON " & Table1Name & "." & JoinOnTable1ColumnName & " = " & Table2Name & "." & JoinOnTable2ColumnName & " ORDER BY " & Table1Name & "." & JoinOnTable1ColumnName & ";", SQLiteConn)
                    Dim DatabaseAdaterCommandBuilder As SQLiteCommandBuilder = New SQLiteCommandBuilder(NewDatabaseAdapter)
                    NewDatabaseAdapter.Fill(dtTemp)
                    SQLiteConn.Close()
                End Using
                Return dtTemp
            Else
                dtTemp = CreateAJoinedTable(Table1Name, Table2Name, JoinOnTable1ColumnName, JoinOnTable2ColumnName, True)
                Return dtTemp
            End If

        Catch ex As Exception

        End Try
        Return dtTemp
    End Function
End Class
