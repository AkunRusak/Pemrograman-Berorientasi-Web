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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nilai1 = New System.Windows.Forms.Label()
        Me.nilai2 = New System.Windows.Forms.Label()
        Me.hasil = New System.Windows.Forms.Label()
        Me.nilai11 = New System.Windows.Forms.TextBox()
        Me.nilai22 = New System.Windows.Forms.TextBox()
        Me.hasill = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(373, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KALKULATOR SEDERHANA"
        '
        'nilai1
        '
        Me.nilai1.AutoSize = True
        Me.nilai1.Location = New System.Drawing.Point(435, 100)
        Me.nilai1.Name = "nilai1"
        Me.nilai1.Size = New System.Drawing.Size(79, 25)
        Me.nilai1.TabIndex = 1
        Me.nilai1.Text = "Nilai 1"
        '
        'nilai2
        '
        Me.nilai2.AutoSize = True
        Me.nilai2.Location = New System.Drawing.Point(435, 164)
        Me.nilai2.Name = "nilai2"
        Me.nilai2.Size = New System.Drawing.Size(79, 25)
        Me.nilai2.TabIndex = 2
        Me.nilai2.Text = "Nilai 2"
        '
        'hasil
        '
        Me.hasil.AutoSize = True
        Me.hasil.Location = New System.Drawing.Point(435, 246)
        Me.hasil.Name = "hasil"
        Me.hasil.Size = New System.Drawing.Size(79, 25)
        Me.hasil.TabIndex = 3
        Me.hasil.Text = "Hasil :"
        '
        'nilai11
        '
        Me.nilai11.Location = New System.Drawing.Point(520, 94)
        Me.nilai11.Name = "nilai11"
        Me.nilai11.Size = New System.Drawing.Size(72, 31)
        Me.nilai11.TabIndex = 4
        '
        'nilai22
        '
        Me.nilai22.Location = New System.Drawing.Point(520, 164)
        Me.nilai22.Name = "nilai22"
        Me.nilai22.Size = New System.Drawing.Size(72, 31)
        Me.nilai22.TabIndex = 5
        '
        'hasill
        '
        Me.hasill.Location = New System.Drawing.Point(520, 243)
        Me.hasill.Name = "hasill"
        Me.hasill.Size = New System.Drawing.Size(72, 31)
        Me.hasill.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(137, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 72)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(292, 304)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 72)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(440, 304)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 72)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "*"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(590, 304)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 72)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "/"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(746, 304)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(123, 72)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "^"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.coba_ti21k1.My.Resources.Resources.download
        Me.ClientSize = New System.Drawing.Size(1030, 442)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.hasill)
        Me.Controls.Add(Me.nilai22)
        Me.Controls.Add(Me.nilai11)
        Me.Controls.Add(Me.hasil)
        Me.Controls.Add(Me.nilai2)
        Me.Controls.Add(Me.nilai1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nilai1 As System.Windows.Forms.Label
    Friend WithEvents nilai2 As System.Windows.Forms.Label
    Friend WithEvents hasil As System.Windows.Forms.Label
    Friend WithEvents nilai11 As System.Windows.Forms.TextBox
    Friend WithEvents nilai22 As System.Windows.Forms.TextBox
    Friend WithEvents hasill As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button

End Class
