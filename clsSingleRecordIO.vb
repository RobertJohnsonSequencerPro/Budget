﻿Option Strict On
Option Explicit On


Public Class clsSingleRecordIO


#Region "Variables"

    'Public MyEnum As Object

#End Region

#Region "Properties"
    Public Property ConnectionString As String
    Public Property TableName As String
    Public Property GUID As String
    Public Property IsDeleted As Boolean
    Public Property DateRecordCreated As Date
    Public Property RecordIsInDB As Boolean

#End Region

#Region "DataTables"
    Public dtIOTable As New DataTable
#End Region

#Region "Objects"

#End Region

#Region "Events"

#End Region

#Region "EventHandlers"

#End Region

#Region "Methods"
    Public Function GetDataFromDatabase() As Boolean
        Try
            Dim SQLiteConnection As New clsSQLiteConnection
            dtIOTable.Clear()
            SQLiteConnection.PopulateADataTableFiltered(dtIOTable, TableName, "txtGUID", GUID)
            If dtIOTable.Rows.Count < 1 Then
                RecordIsInDB = False
                SQLiteConnection.CreateEmptyDataTableFromSchema(dtIOTable, TableName)
            Else
                RecordIsInDB = True
            End If
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function SaveDataToDataBase() As Boolean
        Try
            Dim SQLiteConnection As New clsSQLiteConnection
            SQLiteConnection.SaveADataTable(dtIOTable, TableName)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
#End Region

    Public Function UpdateTextField(ColumnName As String, NewValue As String) As Boolean
        Try
            dtIOTable.Rows(0).Item(ColumnName) = NewValue
            SaveDataToDataBase()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function UpdateIntegerField(ColumnName As String, NewValue As Integer) As Boolean
        Try
            dtIOTable.Rows(0).Item(ColumnName) = NewValue
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function UpdateNumericField(ColumnName As String, NewValue As Double) As Boolean
        Try
            dtIOTable.Rows(0).Item(ColumnName) = NewValue
            SaveDataToDataBase()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function GetTextFieldValue(ColumnName As String) As String
        Return dtIOTable.Rows(0).Item(ColumnName).ToString
    End Function

    Public Function GetIntegerFieldValue(ColumnName As String) As Integer
        Return CInt(dtIOTable.Rows(0).Item(ColumnName))
    End Function

    Public Function GetNumericFieldValue(ColumnName As String) As Double
        Return CDbl(dtIOTable.Rows(0).Item(ColumnName))
    End Function

#Region "Constructors"
    Public Sub New(ByRef EnumTableType As Type, ByVal DBConnectionString As String, RecordGUID As String)
        TableName = EnumTableType.Name
        ConnectionString = DBConnectionString
        GUID = RecordGUID
    End Sub
#End Region

End Class
