<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kondisi_IF
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CNamabarang = New System.Windows.Forms.ComboBox()
        Me.Tharga = New System.Windows.Forms.TextBox()
        Me.Tdisc_harga = New System.Windows.Forms.TextBox()
        Me.disc5 = New System.Windows.Forms.Button()
        Me.disc25 = New System.Windows.Forms.Button()
        Me.disc10 = New System.Windows.Forms.RadioButton()
        Me.disc15 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kondisi IF"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(133, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 107)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Tdisc_harga)
        Me.GroupBox2.Controls.Add(Me.Tharga)
        Me.GroupBox2.Controls.Add(Me.CNamabarang)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(134, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(411, 159)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Harga Setelah Diskon"
        '
        'CNamabarang
        '
        Me.CNamabarang.FormattingEnabled = True
        Me.CNamabarang.Items.AddRange(New Object() {"TV LG 20 inch", "Kulkas Panasonic", "AC Samsung ", "HP Samsung"})
        Me.CNamabarang.Location = New System.Drawing.Point(195, 28)
        Me.CNamabarang.Name = "CNamabarang"
        Me.CNamabarang.Size = New System.Drawing.Size(173, 21)
        Me.CNamabarang.TabIndex = 3
        '
        'Tharga
        '
        Me.Tharga.Location = New System.Drawing.Point(194, 62)
        Me.Tharga.Name = "Tharga"
        Me.Tharga.Size = New System.Drawing.Size(173, 20)
        Me.Tharga.TabIndex = 4
        '
        'Tdisc_harga
        '
        Me.Tdisc_harga.Location = New System.Drawing.Point(193, 96)
        Me.Tdisc_harga.Name = "Tdisc_harga"
        Me.Tdisc_harga.Size = New System.Drawing.Size(174, 20)
        Me.Tdisc_harga.TabIndex = 5
        '
        'disc5
        '
        Me.disc5.Location = New System.Drawing.Point(141, 322)
        Me.disc5.Name = "disc5"
        Me.disc5.Size = New System.Drawing.Size(89, 38)
        Me.disc5.TabIndex = 3
        Me.disc5.Text = "Disc 5 %"
        Me.disc5.UseVisualStyleBackColor = True
        '
        'disc25
        '
        Me.disc25.Location = New System.Drawing.Point(451, 324)
        Me.disc25.Name = "disc25"
        Me.disc25.Size = New System.Drawing.Size(93, 35)
        Me.disc25.TabIndex = 4
        Me.disc25.Text = "Disc 25 %"
        Me.disc25.UseVisualStyleBackColor = True
        '
        'disc10
        '
        Me.disc10.AutoSize = True
        Me.disc10.Location = New System.Drawing.Point(246, 342)
        Me.disc10.Name = "disc10"
        Me.disc10.Size = New System.Drawing.Size(72, 17)
        Me.disc10.TabIndex = 5
        Me.disc10.TabStop = True
        Me.disc10.Text = "Disc 10 %"
        Me.disc10.UseVisualStyleBackColor = True
        '
        'disc15
        '
        Me.disc15.AutoSize = True
        Me.disc15.Location = New System.Drawing.Point(352, 342)
        Me.disc15.Name = "disc15"
        Me.disc15.Size = New System.Drawing.Size(72, 17)
        Me.disc15.TabIndex = 6
        Me.disc15.TabStop = True
        Me.disc15.Text = "Disc 15 %"
        Me.disc15.UseVisualStyleBackColor = True
        '
        'Kondisi_IF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(699, 459)
        Me.Controls.Add(Me.disc15)
        Me.Controls.Add(Me.disc10)
        Me.Controls.Add(Me.disc25)
        Me.Controls.Add(Me.disc5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Kondisi_IF"
        Me.Text = "Kondisi_IF"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tdisc_harga As System.Windows.Forms.TextBox
    Friend WithEvents Tharga As System.Windows.Forms.TextBox
    Friend WithEvents CNamabarang As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents disc5 As System.Windows.Forms.Button
    Friend WithEvents disc25 As System.Windows.Forms.Button
    Friend WithEvents disc10 As System.Windows.Forms.RadioButton
    Friend WithEvents disc15 As System.Windows.Forms.RadioButton
End Class
