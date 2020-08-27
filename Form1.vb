Public Class Form1
    Private Sub BTN_Tambah_Click(sender As Object, e As EventArgs) Handles BTN_Tambah.Click
        Me.Hide()
        FormParkirMasuk.Show()
    End Sub

    Private Sub BTN_tes_Click(sender As Object, e As EventArgs) Handles BTN_tes.Click


        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                MsgBox("Data Terkoneksi")

            End If

        Catch ex As Exception
            MsgBox("Data Gagal Terkoneksi" & ex.Message)

        End Try

    End Sub
End Class
