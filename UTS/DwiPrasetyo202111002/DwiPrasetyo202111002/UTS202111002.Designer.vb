<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UTS202111002
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
        Me.Ckodematkul = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Tnilaibobot = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tnilaihuruf = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tnilai = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cprodi = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tnama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tsks = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tnamamatkul = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.Bclear = New System.Windows.Forms.Button()
        Me.Bproses = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Ttotalsks = New System.Windows.Forms.TextBox()
        Me.Tipk = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ckodematkul
        '
        Me.Ckodematkul.FormattingEnabled = True
        Me.Ckodematkul.Items.AddRange(New Object() {"MT01", "MT02", "MT03", "MT04", "MT05", "MT06", "MT07"})
        Me.Ckodematkul.Location = New System.Drawing.Point(21, 31)
        Me.Ckodematkul.Name = "Ckodematkul"
        Me.Ckodematkul.Size = New System.Drawing.Size(72, 21)
        Me.Ckodematkul.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mistral", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Entri Data Nilai"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(685, 62)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Yellow
        Me.GroupBox2.Controls.Add(Me.Tnilaibobot)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Tnilaihuruf)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Tnilai)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Cprodi)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Tnama)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Tsks)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Tnamamatkul)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Ckodematkul)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 256)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'Tnilaibobot
        '
        Me.Tnilaibobot.Location = New System.Drawing.Point(266, 225)
        Me.Tnilaibobot.Name = "Tnilaibobot"
        Me.Tnilaibobot.Size = New System.Drawing.Size(60, 20)
        Me.Tnilaibobot.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(176, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Nilai BOBOT"
        '
        'Tnilaihuruf
        '
        Me.Tnilaihuruf.Location = New System.Drawing.Point(266, 199)
        Me.Tnilaihuruf.Name = "Tnilaihuruf"
        Me.Tnilaihuruf.Size = New System.Drawing.Size(60, 20)
        Me.Tnilaihuruf.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(187, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Nilai Huruf"
        '
        'Tnilai
        '
        Me.Tnilai.Location = New System.Drawing.Point(51, 209)
        Me.Tnilai.Name = "Tnilai"
        Me.Tnilai.Size = New System.Drawing.Size(100, 20)
        Me.Tnilai.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Nilai"
        '
        'Cprodi
        '
        Me.Cprodi.FormattingEnabled = True
        Me.Cprodi.Items.AddRange(New Object() {"Teknik Informatika", "Akuntasi", "Sistem Informasi", "Robotika", "Multimedia"})
        Me.Cprodi.Location = New System.Drawing.Point(190, 143)
        Me.Cprodi.Name = "Cprodi"
        Me.Cprodi.Size = New System.Drawing.Size(136, 21)
        Me.Cprodi.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(187, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Prodi"
        '
        'Tnama
        '
        Me.Tnama.Location = New System.Drawing.Point(21, 143)
        Me.Tnama.Name = "Tnama"
        Me.Tnama.Size = New System.Drawing.Size(134, 20)
        Me.Tnama.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nama"
        '
        'Tsks
        '
        Me.Tsks.Location = New System.Drawing.Point(241, 12)
        Me.Tsks.Name = "Tsks"
        Me.Tsks.Size = New System.Drawing.Size(85, 20)
        Me.Tsks.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(204, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "SKS"
        '
        'Tnamamatkul
        '
        Me.Tnamamatkul.Location = New System.Drawing.Point(21, 71)
        Me.Tnamamatkul.Name = "Tnamamatkul"
        Me.Tnamamatkul.Size = New System.Drawing.Size(136, 20)
        Me.Tnamamatkul.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Mata Kuliah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Mata Kuliah"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Bexit)
        Me.GroupBox3.Controls.Add(Me.Bclear)
        Me.GroupBox3.Controls.Add(Me.Bproses)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 345)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(329, 75)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'Bexit
        '
        Me.Bexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bexit.Location = New System.Drawing.Point(247, 25)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(76, 37)
        Me.Bexit.TabIndex = 2
        Me.Bexit.Text = "Exit"
        Me.Bexit.UseVisualStyleBackColor = True
        '
        'Bclear
        '
        Me.Bclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bclear.Location = New System.Drawing.Point(133, 25)
        Me.Bclear.Name = "Bclear"
        Me.Bclear.Size = New System.Drawing.Size(76, 37)
        Me.Bclear.TabIndex = 1
        Me.Bclear.Text = "Clear"
        Me.Bclear.UseVisualStyleBackColor = True
        '
        'Bproses
        '
        Me.Bproses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bproses.Location = New System.Drawing.Point(15, 25)
        Me.Bproses.Name = "Bproses"
        Me.Bproses.Size = New System.Drawing.Size(76, 37)
        Me.Bproses.TabIndex = 0
        Me.Bproses.Text = "Proses"
        Me.Bproses.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Yellow
        Me.GroupBox4.Controls.Add(Me.ListBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(381, 80)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(320, 217)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(11, 16)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(299, 186)
        Me.ListBox1.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(516, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Total SKS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(553, 352)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "IPK"
        '
        'Ttotalsks
        '
        Me.Ttotalsks.Location = New System.Drawing.Point(595, 315)
        Me.Ttotalsks.Name = "Ttotalsks"
        Me.Ttotalsks.Size = New System.Drawing.Size(100, 20)
        Me.Ttotalsks.TabIndex = 8
        '
        'Tipk
        '
        Me.Tipk.Location = New System.Drawing.Point(595, 345)
        Me.Tipk.Name = "Tipk"
        Me.Tipk.Size = New System.Drawing.Size(100, 20)
        Me.Tipk.TabIndex = 9
        '
        'UTS202111002
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(718, 448)
        Me.Controls.Add(Me.Tipk)
        Me.Controls.Add(Me.Ttotalsks)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UTS202111002"
        Me.Text = "UTS202111002"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ckodematkul As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Tnilaibobot As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Tnilaihuruf As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Tnilai As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Cprodi As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Tnama As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Tsks As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Tnamamatkul As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Bexit As System.Windows.Forms.Button
    Friend WithEvents Bclear As System.Windows.Forms.Button
    Friend WithEvents Bproses As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Ttotalsks As System.Windows.Forms.TextBox
    Friend WithEvents Tipk As System.Windows.Forms.TextBox
End Class
