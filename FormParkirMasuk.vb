Public Class FormParkirMasuk
    Dim Jenis_Kendaraan

    Private Sub FormParkirMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN_Tambah_Click(sender As Object, e As EventArgs) Handles BTN_Tambah.Click

        bukakoneksi()
        sql = "INSERT INTO PARKIR_KENDARAAN (NO_TIKET,JENIS_KENDARAAN,JAM_MASUK) VALUES " +
        TxtBoxMasuk.Text + "," + TxtBoxNomor.Text + "," + Jenis_Kendaraan

        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub RBMotor_CheckedChanged(sender As Object, e As EventArgs) Handles RBMotor.CheckedChanged

        TxtBoxNomor.Text = DateTime.Now.Date.ToString("ddMMyy")
        TxtBoxMasuk.Text = DateTime.Now.ToString("HH:mm:ss")
        If RBMotor.Checked Then
            Jenis_Kendaraan = "Motor"
        End If
    End Sub

    Private Sub radioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radioButton1.CheckedChanged


        TxtBoxNomor.Text = DateTime.Now.Date.ToString("ddMMyy")
        TxtBoxMasuk.Text = DateTime.Now.ToString("HH:mm:ss")

    End Sub


End Class