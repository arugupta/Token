Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class slots
    Public Function insert() As SqlDataReader
        Dim query As New System.Text.StringBuilder

        'insert into customer


        Return SqlHelper.ExecuteReader(DALCommon.ConnectionString, CommandType.Text, query.ToString())
    End Function
End Class
