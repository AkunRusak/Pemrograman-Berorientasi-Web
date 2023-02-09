<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Tstock = New System.Windows.Forms.TextBox()
        Me.Tharga = New System.Windows.Forms.TextBox()
        Me.Tnamabrg = New System.Windows.Forms.TextBox()
        Me.Tkodebrg = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.keluar = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.add = New System.Windows.Forms.Button()
        Me.akhir = New System.Windows.Forms.Button()
        Me.sesudah = New System.Windows.Forms.Button()
        Me.sebelum = New System.Windows.Forms.Button()
        Me.awal = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(684, 54)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input Data Barang"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.Tstock)
        Me.GroupBox2.Controls.Add(Me.Tharga)
        Me.GroupBox2.Controls.Add(Me.Tnamabrg)
        Me.GroupBox2.Controls.Add(Me.Tkodebrg)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(684, 109)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input"
        '
        'Tstock
        '
        Me.Tstock.Location = New System.Drawing.Point(503, 62)
        Me.Tstock.Name = "Tstock"
        Me.Tstock.Size = New System.Drawing.Size(74, 20)
        Me.Tstock.TabIndex = 8
        '
        'Tharga
        '
        Me.Tharga.Location = New System.Drawing.Point(503, 19)
        Me.Tharga.Name = "Tharga"
        Me.Tharga.Size = New System.Drawing.Size(126, 20)
        Me.Tharga.TabIndex = 7
        '
        'Tnamabrg
        '
        Me.Tnamabrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tnamabrg.Location = New System.Drawing.Point(125, 62)
        Me.Tnamabrg.Name = "Tnamabrg"
        Me.Tnamabrg.Size = New System.Drawing.Size(234, 22)
        Me.Tnamabrg.TabIndex = 6
        '
        'Tkodebrg
        '
        Me.Tkodebrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tkodebrg.Location = New System.Drawing.Point(125, 19)
        Me.Tkodebrg.Name = "Tkodebrg"
        Me.Tkodebrg.Size = New System.Drawing.Size(100, 22)
        Me.Tkodebrg.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(451, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(451, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Barang"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 187)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(684, 191)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(672, 172)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox4.Controls.Add(Me.keluar)
        Me.GroupBox4.Controls.Add(Me.delete)
        Me.GroupBox4.Controls.Add(Me.edit)
        Me.GroupBox4.Controls.Add(Me.cancel)
        Me.GroupBox4.Controls.Add(Me.add)
        Me.GroupBox4.Controls.Add(Me.akhir)
        Me.GroupBox4.Controls.Add(Me.sesudah)
        Me.GroupBox4.Controls.Add(Me.sebelum)
        Me.GroupBox4.Controls.Add(Me.awal)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 384)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(684, 57)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Proses"
        '
        'keluar
        '
        Me.keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keluar.Location = New System.Drawing.Point(599, 19)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(56, 31)
        Me.keluar.TabIndex = 8
        Me.keluar.Text = "Exit"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(537, 19)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(56, 31)
        Me.delete.TabIndex = 7
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit.Location = New System.Drawing.Point(475, 19)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(56, 31)
        Me.edit.TabIndex = 6
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.Location = New System.Drawing.Point(413, 19)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(56, 31)
        Me.cancel.TabIndex = 5
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'add
        '
        Me.add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add.Location = New System.Drawing.Point(351, 19)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(56, 31)
        Me.add.TabIndex = 4
        Me.add.Text = "Add"
        Me.add.UseVisualStyleBackColor = True
        '
        'akhir
        '
        Me.akhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.akhir.Location = New System.Drawing.Point(208, 20)
        Me.akhir.Name = "akhir"
        Me.akhir.Size = New System.Drawing.Size(56, 31)
        Me.akhir.TabIndex = 3
        Me.akhir.Text = ">>"
        Me.akhir.UseVisualStyleBackColor = True
        '
        'sesudah
        '
        Me.sesudah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sesudah.Location = New System.Drawing.Point(146, 20)
        Me.sesudah.Name = "sesudah"
        Me.sesudah.Size = New System.Drawing.Size(56, 31)
        Me.sesudah.TabIndex = 2
        Me.sesudah.Text = ">"
        Me.sesudah.UseVisualStyleBackColor = True
        '
        'sebelum
        '
        Me.sebelum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sebelum.Location = New System.Drawing.Point(84, 19)
        Me.sebelum.Name = "sebelum"
        Me.sebelum.Size = New System.Drawing.Size(56, 31)
        Me.sebelum.TabIndex = 1
        Me.sebelum.Text = "<"
        Me.sebelum.UseVisualStyleBackColor = True
        '
        'awal
        '
        Me.awal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.awal.Location = New System.Drawing.Point(22, 19)
        Me.awal.Name = "awal"
        Me.awal.Size = New System.Drawing.Size(56, 31)
        Me.awal.TabIndex = 0
        Me.awal.Text = "<<"
        Me.awal.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 450)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Tstock As System.Windows.Forms.TextBox
    Friend WithEvents Tharga As System.Windows.Forms.TextBox
    Friend WithEvents Tnamabrg As System.Windows.Forms.TextBox
    Friend WithEvents Tkodebrg As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents keluar As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents add As System.Windows.Forms.Button
    Friend WithEvents akhir As System.Windows.Forms.Button
    Friend WithEvents sesudah As System.Windows.Forms.Button
    Friend WithEvents sebelum As System.Windows.Forms.Button
    Friend WithEvents awal As System.Windows.Forms.Button

End Class
