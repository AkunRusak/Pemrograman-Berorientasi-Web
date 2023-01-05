<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Warung
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Tharga = New System.Windows.Forms.TextBox()
        Me.Cmakan = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Bkeluar = New System.Windows.Forms.Button()
        Me.Bbeli = New System.Windows.Forms.Button()
        Me.Bclear = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Ttotal = New System.Windows.Forms.TextBox()
        Me.Tbayar = New System.Windows.Forms.TextBox()
        Me.Tkembali = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 60)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Warung dan Makanan"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Tharga)
        Me.GroupBox2.Controls.Add(Me.Cmakan)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 212)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Tharga
        '
        Me.Tharga.Location = New System.Drawing.Point(69, 155)
        Me.Tharga.Name = "Tharga"
        Me.Tharga.Size = New System.Drawing.Size(163, 20)
        Me.Tharga.TabIndex = 3
        '
        'Cmakan
        '
        Me.Cmakan.FormattingEnabled = True
        Me.Cmakan.Items.AddRange(New Object() {"Kopi Luwak", "Kopi Hitam", "Mie Goreng", "Mie Kuah", "Mie Kuah Telor", "Teh Manis", "Nasi Goreng", "Teh Tawar"})
        Me.Cmakan.Location = New System.Drawing.Point(53, 52)
        Me.Cmakan.Name = "Cmakan"
        Me.Cmakan.Size = New System.Drawing.Size(197, 21)
        Me.Cmakan.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Harga"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Makanan dan Minuman"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(369, 114)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(307, 212)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 20)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(295, 186)
        Me.ListBox1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Bkeluar)
        Me.GroupBox4.Controls.Add(Me.Bbeli)
        Me.GroupBox4.Controls.Add(Me.Bclear)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 343)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(306, 104)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'Bkeluar
        '
        Me.Bkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bkeluar.Location = New System.Drawing.Point(215, 32)
        Me.Bkeluar.Name = "Bkeluar"
        Me.Bkeluar.Size = New System.Drawing.Size(85, 54)
        Me.Bkeluar.TabIndex = 2
        Me.Bkeluar.Text = "Keluar"
        Me.Bkeluar.UseVisualStyleBackColor = True
        '
        'Bbeli
        '
        Me.Bbeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bbeli.Location = New System.Drawing.Point(6, 32)
        Me.Bbeli.Name = "Bbeli"
        Me.Bbeli.Size = New System.Drawing.Size(85, 54)
        Me.Bbeli.TabIndex = 0
        Me.Bbeli.Text = "Beli"
        Me.Bbeli.UseVisualStyleBackColor = True
        '
        'Bclear
        '
        Me.Bclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bclear.Location = New System.Drawing.Point(111, 32)
        Me.Bclear.Name = "Bclear"
        Me.Bclear.Size = New System.Drawing.Size(85, 54)
        Me.Bclear.TabIndex = 1
        Me.Bclear.Text = "Clear"
        Me.Bclear.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(464, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(459, 400)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Bayar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(444, 441)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Kembali"
        '
        'Ttotal
        '
        Me.Ttotal.Location = New System.Drawing.Point(520, 354)
        Me.Ttotal.Name = "Ttotal"
        Me.Ttotal.Size = New System.Drawing.Size(156, 20)
        Me.Ttotal.TabIndex = 7
        '
        'Tbayar
        '
        Me.Tbayar.Location = New System.Drawing.Point(520, 396)
        Me.Tbayar.Name = "Tbayar"
        Me.Tbayar.Size = New System.Drawing.Size(156, 20)
        Me.Tbayar.TabIndex = 8
        '
        'Tkembali
        '
        Me.Tkembali.Location = New System.Drawing.Point(520, 434)
        Me.Tkembali.Name = "Tkembali"
        Me.Tkembali.Size = New System.Drawing.Size(156, 20)
        Me.Tkembali.TabIndex = 9
        '
        'Warung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(688, 469)
        Me.Controls.Add(Me.Tkembali)
        Me.Controls.Add(Me.Tbayar)
        Me.Controls.Add(Me.Ttotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Warung"
        Me.Text = "Warung"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Tharga As System.Windows.Forms.TextBox
    Friend WithEvents Cmakan As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Bkeluar As System.Windows.Forms.Button
    Friend WithEvents Bclear As System.Windows.Forms.Button
    Friend WithEvents Bbeli As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Ttotal As System.Windows.Forms.TextBox
    Friend WithEvents Tbayar As System.Windows.Forms.TextBox
    Friend WithEvents Tkembali As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
