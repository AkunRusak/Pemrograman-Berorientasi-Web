<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GajiKaryawan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tgajipokok = New System.Windows.Forms.TextBox()
        Me.Cdepart = New System.Windows.Forms.ComboBox()
        Me.Tnama = New System.Windows.Forms.TextBox()
        Me.Cnik = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bclear = New System.Windows.Forms.Button()
        Me.Bproses = New System.Windows.Forms.Button()
        Me.Tgaji30 = New System.Windows.Forms.TextBox()
        Me.Tgaji = New System.Windows.Forms.TextBox()
        Me.Tkesehatan = New System.Windows.Forms.TextBox()
        Me.Tanak = New System.Windows.Forms.TextBox()
        Me.Tjabatan = New System.Windows.Forms.TextBox()
        Me.Tlembur = New System.Windows.Forms.TextBox()
        Me.Thadir = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Tkoperasi = New System.Windows.Forms.TextBox()
        Me.Tppn = New System.Windows.Forms.TextBox()
        Me.Ttotalgaji = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menghitung Gaji Karyawan"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Tgajipokok)
        Me.GroupBox1.Controls.Add(Me.Cdepart)
        Me.GroupBox1.Controls.Add(Me.Tnama)
        Me.GroupBox1.Controls.Add(Me.Cnik)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 174)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Tgajipokok
        '
        Me.Tgajipokok.Location = New System.Drawing.Point(90, 138)
        Me.Tgajipokok.Name = "Tgajipokok"
        Me.Tgajipokok.Size = New System.Drawing.Size(100, 20)
        Me.Tgajipokok.TabIndex = 8
        '
        'Cdepart
        '
        Me.Cdepart.FormattingEnabled = True
        Me.Cdepart.Items.AddRange(New Object() {"HRD", "MKT", "TQC", "PRD"})
        Me.Cdepart.Location = New System.Drawing.Point(90, 100)
        Me.Cdepart.Name = "Cdepart"
        Me.Cdepart.Size = New System.Drawing.Size(87, 21)
        Me.Cdepart.TabIndex = 7
        '
        'Tnama
        '
        Me.Tnama.Location = New System.Drawing.Point(90, 63)
        Me.Tnama.Name = "Tnama"
        Me.Tnama.Size = New System.Drawing.Size(180, 20)
        Me.Tnama.TabIndex = 6
        '
        'Cnik
        '
        Me.Cnik.FormattingEnabled = True
        Me.Cnik.Items.AddRange(New Object() {"202111001", "202111002", "202111003", "202111004", "202111005", "202111006", "202111007", "202111008", "202111009", "202111010"})
        Me.Cnik.Location = New System.Drawing.Point(90, 21)
        Me.Cnik.Name = "Cnik"
        Me.Cnik.Size = New System.Drawing.Size(121, 21)
        Me.Cnik.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(198, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "HRD MKT TQC PRD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Gaji Pokok"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Departement"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nik"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Bclear)
        Me.GroupBox2.Controls.Add(Me.Bproses)
        Me.GroupBox2.Controls.Add(Me.Tgaji30)
        Me.GroupBox2.Controls.Add(Me.Tgaji)
        Me.GroupBox2.Controls.Add(Me.Tkesehatan)
        Me.GroupBox2.Controls.Add(Me.Tanak)
        Me.GroupBox2.Controls.Add(Me.Tjabatan)
        Me.GroupBox2.Controls.Add(Me.Tlembur)
        Me.GroupBox2.Controls.Add(Me.Thadir)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 249)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 174)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hitung Gaji"
        '
        'Bclear
        '
        Me.Bclear.Location = New System.Drawing.Point(359, 128)
        Me.Bclear.Name = "Bclear"
        Me.Bclear.Size = New System.Drawing.Size(69, 38)
        Me.Bclear.TabIndex = 15
        Me.Bclear.Text = "Clear"
        Me.Bclear.UseVisualStyleBackColor = True
        '
        'Bproses
        '
        Me.Bproses.Location = New System.Drawing.Point(285, 128)
        Me.Bproses.Name = "Bproses"
        Me.Bproses.Size = New System.Drawing.Size(69, 38)
        Me.Bproses.TabIndex = 14
        Me.Bproses.Text = "Proses"
        Me.Bproses.UseVisualStyleBackColor = True
        '
        'Tgaji30
        '
        Me.Tgaji30.Location = New System.Drawing.Point(275, 51)
        Me.Tgaji30.Name = "Tgaji30"
        Me.Tgaji30.Size = New System.Drawing.Size(100, 20)
        Me.Tgaji30.TabIndex = 13
        '
        'Tgaji
        '
        Me.Tgaji.Location = New System.Drawing.Point(275, 25)
        Me.Tgaji.Name = "Tgaji"
        Me.Tgaji.Size = New System.Drawing.Size(100, 20)
        Me.Tgaji.TabIndex = 12
        '
        'Tkesehatan
        '
        Me.Tkesehatan.Location = New System.Drawing.Point(131, 138)
        Me.Tkesehatan.Name = "Tkesehatan"
        Me.Tkesehatan.Size = New System.Drawing.Size(100, 20)
        Me.Tkesehatan.TabIndex = 11
        '
        'Tanak
        '
        Me.Tanak.Location = New System.Drawing.Point(131, 109)
        Me.Tanak.Name = "Tanak"
        Me.Tanak.Size = New System.Drawing.Size(100, 20)
        Me.Tanak.TabIndex = 10
        '
        'Tjabatan
        '
        Me.Tjabatan.Location = New System.Drawing.Point(131, 79)
        Me.Tjabatan.Name = "Tjabatan"
        Me.Tjabatan.Size = New System.Drawing.Size(100, 20)
        Me.Tjabatan.TabIndex = 9
        '
        'Tlembur
        '
        Me.Tlembur.Location = New System.Drawing.Point(131, 51)
        Me.Tlembur.Name = "Tlembur"
        Me.Tlembur.Size = New System.Drawing.Size(46, 20)
        Me.Tlembur.TabIndex = 8
        '
        'Thadir
        '
        Me.Thadir.Location = New System.Drawing.Point(131, 25)
        Me.Thadir.Name = "Thadir"
        Me.Thadir.Size = New System.Drawing.Size(46, 20)
        Me.Thadir.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(188, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "X Gaji Pokok/30"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(188, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "X Gaji Pokok"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Tunj Kesehatan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Tunj Anak"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Tunj Jabatan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Jumlah Jam Lembur"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Kehadiran"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(459, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(319, 277)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 16)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(306, 251)
        Me.ListBox1.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(553, 348)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Potongan Koperasi"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(455, 381)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(197, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "PPN X Gaji Pokok - (Gaji Pokok * 100%)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(600, 411)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Total Gaji"
        '
        'Tkoperasi
        '
        Me.Tkoperasi.Location = New System.Drawing.Point(656, 341)
        Me.Tkoperasi.Name = "Tkoperasi"
        Me.Tkoperasi.Size = New System.Drawing.Size(115, 20)
        Me.Tkoperasi.TabIndex = 7
        '
        'Tppn
        '
        Me.Tppn.Location = New System.Drawing.Point(658, 374)
        Me.Tppn.Name = "Tppn"
        Me.Tppn.Size = New System.Drawing.Size(113, 20)
        Me.Tppn.TabIndex = 8
        '
        'Ttotalgaji
        '
        Me.Ttotalgaji.Location = New System.Drawing.Point(658, 404)
        Me.Ttotalgaji.Name = "Ttotalgaji"
        Me.Ttotalgaji.Size = New System.Drawing.Size(113, 20)
        Me.Ttotalgaji.TabIndex = 9
        '
        'GajiKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(785, 436)
        Me.Controls.Add(Me.Ttotalgaji)
        Me.Controls.Add(Me.Tppn)
        Me.Controls.Add(Me.Tkoperasi)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GajiKaryawan"
        Me.Text = "GajiKaryawan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Tgajipokok As System.Windows.Forms.TextBox
    Friend WithEvents Cdepart As System.Windows.Forms.ComboBox
    Friend WithEvents Tnama As System.Windows.Forms.TextBox
    Friend WithEvents Cnik As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Bclear As System.Windows.Forms.Button
    Friend WithEvents Bproses As System.Windows.Forms.Button
    Friend WithEvents Tgaji30 As System.Windows.Forms.TextBox
    Friend WithEvents Tgaji As System.Windows.Forms.TextBox
    Friend WithEvents Tkesehatan As System.Windows.Forms.TextBox
    Friend WithEvents Tanak As System.Windows.Forms.TextBox
    Friend WithEvents Tjabatan As System.Windows.Forms.TextBox
    Friend WithEvents Tlembur As System.Windows.Forms.TextBox
    Friend WithEvents Thadir As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Tkoperasi As System.Windows.Forms.TextBox
    Friend WithEvents Tppn As System.Windows.Forms.TextBox
    Friend WithEvents Ttotalgaji As System.Windows.Forms.TextBox
End Class
