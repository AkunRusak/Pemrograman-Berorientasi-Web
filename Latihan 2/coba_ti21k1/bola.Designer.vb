<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bola
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Thasil = New System.Windows.Forms.TextBox()
        Me.Tr = New System.Windows.Forms.TextBox()
        Me.Luas = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Tjari_jari = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.volume = New System.Windows.Forms.Button()
        Me.Keliling = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Red
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(626, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mengitung Luas Bola"
        '
        'Thasil
        '
        Me.Thasil.Location = New System.Drawing.Point(261, 56)
        Me.Thasil.Name = "Thasil"
        Me.Thasil.Size = New System.Drawing.Size(100, 20)
        Me.Thasil.TabIndex = 6
        '
        'Tr
        '
        Me.Tr.Location = New System.Drawing.Point(261, 29)
        Me.Tr.Name = "Tr"
        Me.Tr.Size = New System.Drawing.Size(100, 20)
        Me.Tr.TabIndex = 5
        '
        'Luas
        '
        Me.Luas.Location = New System.Drawing.Point(151, 19)
        Me.Luas.Name = "Luas"
        Me.Luas.Size = New System.Drawing.Size(75, 23)
        Me.Luas.TabIndex = 0
        Me.Luas.Text = "Luas"
        Me.Luas.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasil"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Yellow
        Me.GroupBox2.Controls.Add(Me.Thasil)
        Me.GroupBox2.Controls.Add(Me.Tr)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Tjari_jari)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 160)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Tjari_jari
        '
        Me.Tjari_jari.AutoSize = True
        Me.Tjari_jari.Location = New System.Drawing.Point(148, 32)
        Me.Tjari_jari.Name = "Tjari_jari"
        Me.Tjari_jari.Size = New System.Drawing.Size(52, 13)
        Me.Tjari_jari.TabIndex = 1
        Me.Tjari_jari.Text = "R/jari_jari"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.volume)
        Me.GroupBox3.Controls.Add(Me.Keliling)
        Me.GroupBox3.Controls.Add(Me.Luas)
        Me.GroupBox3.Location = New System.Drawing.Point(34, 304)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(626, 63)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'volume
        '
        Me.volume.Location = New System.Drawing.Point(261, 19)
        Me.volume.Name = "volume"
        Me.volume.Size = New System.Drawing.Size(75, 23)
        Me.volume.TabIndex = 2
        Me.volume.Text = "volume"
        Me.volume.UseVisualStyleBackColor = True
        '
        'Keliling
        '
        Me.Keliling.Location = New System.Drawing.Point(368, 19)
        Me.Keliling.Name = "Keliling"
        Me.Keliling.Size = New System.Drawing.Size(75, 23)
        Me.Keliling.TabIndex = 1
        Me.Keliling.Text = "Keliling"
        Me.Keliling.UseVisualStyleBackColor = True
        '
        'bola
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 375)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "bola"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bola"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Thasil As System.Windows.Forms.TextBox
    Friend WithEvents Tr As System.Windows.Forms.TextBox
    Friend WithEvents Luas As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Tjari_jari As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Keliling As System.Windows.Forms.Button
    Friend WithEvents volume As System.Windows.Forms.Button
End Class
