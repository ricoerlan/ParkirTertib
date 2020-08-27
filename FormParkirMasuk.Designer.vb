<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormParkirMasuk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTN_Tambah = New System.Windows.Forms.Button()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.RBMotor = New System.Windows.Forms.RadioButton()
        Me.TxtBoxMasuk = New System.Windows.Forms.TextBox()
        Me.TxtBoxNomor = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_Tambah
        '
        Me.BTN_Tambah.Location = New System.Drawing.Point(334, 102)
        Me.BTN_Tambah.Name = "BTN_Tambah"
        Me.BTN_Tambah.Size = New System.Drawing.Size(60, 43)
        Me.BTN_Tambah.TabIndex = 32
        Me.BTN_Tambah.Text = "Tambah"
        Me.BTN_Tambah.UseVisualStyleBackColor = True
        '
        'radioButton1
        '
        Me.radioButton1.AutoSize = True
        Me.radioButton1.Location = New System.Drawing.Point(235, 115)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(50, 17)
        Me.radioButton1.TabIndex = 31
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "Mobil"
        Me.radioButton1.UseVisualStyleBackColor = True
        '
        'RBMotor
        '
        Me.RBMotor.AutoSize = True
        Me.RBMotor.Location = New System.Drawing.Point(172, 115)
        Me.RBMotor.Name = "RBMotor"
        Me.RBMotor.Size = New System.Drawing.Size(52, 17)
        Me.RBMotor.TabIndex = 30
        Me.RBMotor.TabStop = True
        Me.RBMotor.Text = "Motor"
        Me.RBMotor.UseVisualStyleBackColor = True
        '
        'TxtBoxMasuk
        '
        Me.TxtBoxMasuk.Enabled = False
        Me.TxtBoxMasuk.Location = New System.Drawing.Point(172, 143)
        Me.TxtBoxMasuk.Name = "TxtBoxMasuk"
        Me.TxtBoxMasuk.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxMasuk.TabIndex = 29
        '
        'TxtBoxNomor
        '
        Me.TxtBoxNomor.AllowDrop = True
        Me.TxtBoxNomor.Enabled = False
        Me.TxtBoxNomor.Location = New System.Drawing.Point(172, 88)
        Me.TxtBoxNomor.Name = "TxtBoxNomor"
        Me.TxtBoxNomor.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxNomor.TabIndex = 28
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(78, 143)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(61, 13)
        Me.label4.TabIndex = 27
        Me.label4.Text = "Jam Masuk"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(80, 117)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(31, 13)
        Me.label3.TabIndex = 26
        Me.label3.Text = "Jenis"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(78, 88)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(65, 13)
        Me.label2.TabIndex = 25
        Me.label2.Text = "Nomor Tiket"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.label1.Location = New System.Drawing.Point(142, 34)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(206, 18)
        Me.label1.TabIndex = 24
        Me.label1.Text = "PARKIR MASUK ""TERTIB"""
        '
        'FormParkirMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 197)
        Me.Controls.Add(Me.BTN_Tambah)
        Me.Controls.Add(Me.radioButton1)
        Me.Controls.Add(Me.RBMotor)
        Me.Controls.Add(Me.TxtBoxMasuk)
        Me.Controls.Add(Me.TxtBoxNomor)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "FormParkirMasuk"
        Me.Text = "FormParkirMasuk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents BTN_Tambah As Button
    Private WithEvents radioButton1 As RadioButton
    Private WithEvents RBMotor As RadioButton
    Private WithEvents TxtBoxMasuk As TextBox
    Private WithEvents TxtBoxNomor As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
