<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class persegi_panjang
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TPanjang = New System.Windows.Forms.TextBox()
        Me.TLebar = New System.Windows.Forms.TextBox()
        Me.TLuas = New System.Windows.Forms.TextBox()
        Me.TKeliling = New System.Windows.Forms.TextBox()
        Me.Luas = New System.Windows.Forms.Button()
        Me.Keliling = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(626, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.TKeliling)
        Me.GroupBox2.Controls.Add(Me.TLuas)
        Me.GroupBox2.Controls.Add(Me.TLebar)
        Me.GroupBox2.Controls.Add(Me.TPanjang)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 160)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox3.Controls.Add(Me.Keliling)
        Me.GroupBox3.Controls.Add(Me.Luas)
        Me.GroupBox3.Location = New System.Drawing.Point(39, 309)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(626, 63)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menghitung Persegi Panjang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Panjang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Luas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(148, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lebar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(148, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Keliling"
        '
        'TPanjang
        '
        Me.TPanjang.Location = New System.Drawing.Point(261, 29)
        Me.TPanjang.Name = "TPanjang"
        Me.TPanjang.Size = New System.Drawing.Size(100, 20)
        Me.TPanjang.TabIndex = 5
        '
        'TLebar
        '
        Me.TLebar.Location = New System.Drawing.Point(261, 56)
        Me.TLebar.Name = "TLebar"
        Me.TLebar.Size = New System.Drawing.Size(100, 20)
        Me.TLebar.TabIndex = 6
        '
        'TLuas
        '
        Me.TLuas.Location = New System.Drawing.Point(261, 80)
        Me.TLuas.Name = "TLuas"
        Me.TLuas.Size = New System.Drawing.Size(100, 20)
        Me.TLuas.TabIndex = 7
        '
        'TKeliling
        '
        Me.TKeliling.Location = New System.Drawing.Point(261, 106)
        Me.TKeliling.Name = "TKeliling"
        Me.TKeliling.Size = New System.Drawing.Size(100, 20)
        Me.TKeliling.TabIndex = 8
        '
        'Luas
        '
        Me.Luas.Location = New System.Drawing.Point(210, 19)
        Me.Luas.Name = "Luas"
        Me.Luas.Size = New System.Drawing.Size(75, 23)
        Me.Luas.TabIndex = 0
        Me.Luas.Text = "Luas"
        Me.Luas.UseVisualStyleBackColor = True
        '
        'Keliling
        '
        Me.Keliling.Location = New System.Drawing.Point(324, 19)
        Me.Keliling.Name = "Keliling"
        Me.Keliling.Size = New System.Drawing.Size(75, 23)
        Me.Keliling.TabIndex = 1
        Me.Keliling.Text = "Keliling"
        Me.Keliling.UseVisualStyleBackColor = True
        '
        'persegi_panjang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 409)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "persegi_panjang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "persegi_panjang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TKeliling As System.Windows.Forms.TextBox
    Friend WithEvents TLuas As System.Windows.Forms.TextBox
    Friend WithEvents TLebar As System.Windows.Forms.TextBox
    Friend WithEvents TPanjang As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Keliling As System.Windows.Forms.Button
    Friend WithEvents Luas As System.Windows.Forms.Button
End Class
