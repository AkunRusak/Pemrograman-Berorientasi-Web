<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lingkaran
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tjari_jari = New System.Windows.Forms.TextBox()
        Me.Tluas = New System.Windows.Forms.TextBox()
        Me.Tkeliling = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnluas = New System.Windows.Forms.Button()
        Me.btnkeliling = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mengitung Lingkaran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jari Jari"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "LUAS"
        '
        'Tjari_jari
        '
        Me.Tjari_jari.Location = New System.Drawing.Point(145, 90)
        Me.Tjari_jari.Name = "Tjari_jari"
        Me.Tjari_jari.Size = New System.Drawing.Size(100, 20)
        Me.Tjari_jari.TabIndex = 3
        '
        'Tluas
        '
        Me.Tluas.Location = New System.Drawing.Point(145, 133)
        Me.Tluas.Name = "Tluas"
        Me.Tluas.Size = New System.Drawing.Size(100, 20)
        Me.Tluas.TabIndex = 4
        '
        'Tkeliling
        '
        Me.Tkeliling.Location = New System.Drawing.Point(362, 136)
        Me.Tkeliling.Name = "Tkeliling"
        Me.Tkeliling.Size = New System.Drawing.Size(100, 20)
        Me.Tkeliling.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(301, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Keliling"
        '
        'btnluas
        '
        Me.btnluas.Location = New System.Drawing.Point(145, 232)
        Me.btnluas.Name = "btnluas"
        Me.btnluas.Size = New System.Drawing.Size(100, 55)
        Me.btnluas.TabIndex = 7
        Me.btnluas.Text = "Luas"
        Me.btnluas.UseVisualStyleBackColor = True
        '
        'btnkeliling
        '
        Me.btnkeliling.Location = New System.Drawing.Point(275, 232)
        Me.btnkeliling.Name = "btnkeliling"
        Me.btnkeliling.Size = New System.Drawing.Size(100, 55)
        Me.btnkeliling.TabIndex = 8
        Me.btnkeliling.Text = "Keliling"
        Me.btnkeliling.UseVisualStyleBackColor = True
        '
        'lingkaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 358)
        Me.Controls.Add(Me.btnkeliling)
        Me.Controls.Add(Me.btnluas)
        Me.Controls.Add(Me.Tkeliling)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Tluas)
        Me.Controls.Add(Me.Tjari_jari)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "lingkaran"
        Me.Text = "lingkaran"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tjari_jari As System.Windows.Forms.TextBox
    Friend WithEvents Tluas As System.Windows.Forms.TextBox
    Friend WithEvents Tkeliling As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnluas As System.Windows.Forms.Button
    Friend WithEvents btnkeliling As System.Windows.Forms.Button
End Class
