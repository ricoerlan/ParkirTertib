Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Module Modulkoneksi
    Public comSQL As New SqlClient.SqlCommand
    Public sql As String
    Public conn As New SqlConnection


    Public str = "Data Source=RICO;Initial Catalog=ParkirTertib;Integrated Security=True"
    Public koneksi As New OleDbConnection(str)
    Public Function bukakoneksi() As OleDbConnection
        Try
            If koneksi.State = ConnectionState.Closed Then koneksi.Open()
        Catch ex As Exception
        End Try

        Return koneksi

    End Function

    Public Function tutupkoneksi() As OleDbConnection

        Try
            If koneksi.State = ConnectionState.Open Then
                koneksi.Close()
            End If
        Catch ex As Exception

        End Try

        Return koneksi

    End Function
End Module