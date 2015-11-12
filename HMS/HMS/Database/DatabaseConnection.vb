Imports System.Data.SqlClient

Public Class DatabaseConnection
    Private Connection As SqlConnection

    Public Function runQuery(query As String)
        Dim command As SqlCommand
        command = Connection.CreateCommand
        command.CommandText = query

        Try
            Connection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            Application.Exit()
        End Try

        Dim reader As SqlDataReader
        Try
            reader = command.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
            Application.Exit()
        End Try
        Return reader
    End Function

    Sub New()
        Try
            Connection = New SqlConnection(ConnectionInfo.CONNECTION_STRING)
        Catch ex As Exception
            MsgBox(ex.Message)
            Application.Exit()
        End Try
    End Sub
End Class
