<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kalkulator_V2
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
        Me.Tinput = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button00 = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Buttonkali = New System.Windows.Forms.Button()
        Me.Buttonbagi = New System.Windows.Forms.Button()
        Me.Buttontambah = New System.Windows.Forms.Button()
        Me.Buttonkurang = New System.Windows.Forms.Button()
        Me.Buttonhapus = New System.Windows.Forms.Button()
        Me.Buttonexit = New System.Windows.Forms.Button()
        Me.Buttonsamadengan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kalkulator Sederhana"
        '
        'Tinput
        '
        Me.Tinput.Location = New System.Drawing.Point(46, 41)
        Me.Tinput.Name = "Tinput"
        Me.Tinput.Size = New System.Drawing.Size(287, 38)
        Me.Tinput.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(46, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 43)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(108, 111)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 43)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(170, 111)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 43)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(46, 160)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 43)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(108, 160)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(56, 43)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(170, 160)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(56, 43)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(46, 209)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 43)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(108, 209)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(56, 43)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(170, 209)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(56, 43)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button00
        '
        Me.Button00.Location = New System.Drawing.Point(46, 258)
        Me.Button00.Name = "Button00"
        Me.Button00.Size = New System.Drawing.Size(56, 43)
        Me.Button00.TabIndex = 11
        Me.Button00.Text = "00"
        Me.Button00.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.Location = New System.Drawing.Point(108, 258)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(56, 43)
        Me.Button0.TabIndex = 12
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(170, 258)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(56, 43)
        Me.Button12.TabIndex = 13
        Me.Button12.Text = "."
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Buttonkali
        '
        Me.Buttonkali.Location = New System.Drawing.Point(277, 111)
        Me.Buttonkali.Name = "Buttonkali"
        Me.Buttonkali.Size = New System.Drawing.Size(56, 43)
        Me.Buttonkali.TabIndex = 14
        Me.Buttonkali.Text = "X"
        Me.Buttonkali.UseVisualStyleBackColor = True
        '
        'Buttonbagi
        '
        Me.Buttonbagi.Location = New System.Drawing.Point(277, 160)
        Me.Buttonbagi.Name = "Buttonbagi"
        Me.Buttonbagi.Size = New System.Drawing.Size(56, 43)
        Me.Buttonbagi.TabIndex = 15
        Me.Buttonbagi.Text = ":"
        Me.Buttonbagi.UseVisualStyleBackColor = True
        '
        'Buttontambah
        '
        Me.Buttontambah.Location = New System.Drawing.Point(277, 209)
        Me.Buttontambah.Name = "Buttontambah"
        Me.Buttontambah.Size = New System.Drawing.Size(56, 43)
        Me.Buttontambah.TabIndex = 16
        Me.Buttontambah.Text = "+"
        Me.Buttontambah.UseVisualStyleBackColor = True
        '
        'Buttonkurang
        '
        Me.Buttonkurang.Location = New System.Drawing.Point(277, 258)
        Me.Buttonkurang.Name = "Buttonkurang"
        Me.Buttonkurang.Size = New System.Drawing.Size(56, 43)
        Me.Buttonkurang.TabIndex = 17
        Me.Buttonkurang.Text = "-"
        Me.Buttonkurang.UseVisualStyleBackColor = True
        '
        'Buttonhapus
        '
        Me.Buttonhapus.Location = New System.Drawing.Point(46, 320)
        Me.Buttonhapus.Name = "Buttonhapus"
        Me.Buttonhapus.Size = New System.Drawing.Size(118, 43)
        Me.Buttonhapus.TabIndex = 18
        Me.Buttonhapus.Text = "Delete"
        Me.Buttonhapus.UseVisualStyleBackColor = True
        '
        'Buttonexit
        '
        Me.Buttonexit.Location = New System.Drawing.Point(170, 320)
        Me.Buttonexit.Name = "Buttonexit"
        Me.Buttonexit.Size = New System.Drawing.Size(87, 43)
        Me.Buttonexit.TabIndex = 19
        Me.Buttonexit.Text = "Exit"
        Me.Buttonexit.UseVisualStyleBackColor = True
        '
        'Buttonsamadengan
        '
        Me.Buttonsamadengan.Location = New System.Drawing.Point(277, 320)
        Me.Buttonsamadengan.Name = "Buttonsamadengan"
        Me.Buttonsamadengan.Size = New System.Drawing.Size(56, 43)
        Me.Buttonsamadengan.TabIndex = 20
        Me.Buttonsamadengan.Text = "="
        Me.Buttonsamadengan.UseVisualStyleBackColor = True
        '
        'Kalkulator_V2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 365)
        Me.Controls.Add(Me.Buttonsamadengan)
        Me.Controls.Add(Me.Buttonexit)
        Me.Controls.Add(Me.Buttonhapus)
        Me.Controls.Add(Me.Buttonkurang)
        Me.Controls.Add(Me.Buttontambah)
        Me.Controls.Add(Me.Buttonbagi)
        Me.Controls.Add(Me.Buttonkali)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.Button00)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tinput)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "Kalkulator_V2"
        Me.Text = "Kalkulator_V2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tinput As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button00 As System.Windows.Forms.Button
    Friend WithEvents Button0 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Buttonkali As System.Windows.Forms.Button
    Friend WithEvents Buttonbagi As System.Windows.Forms.Button
    Friend WithEvents Buttontambah As System.Windows.Forms.Button
    Friend WithEvents Buttonkurang As System.Windows.Forms.Button
    Friend WithEvents Buttonhapus As System.Windows.Forms.Button
    Friend WithEvents Buttonexit As System.Windows.Forms.Button
    Friend WithEvents Buttonsamadengan As System.Windows.Forms.Button
End Class
