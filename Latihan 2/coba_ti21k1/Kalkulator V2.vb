Public Class Kalkulator_V2

    Dim num1, num2 As Double
    Dim opr As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Tinput.Text <> "0" Then
            Tinput.Text += "1"
        Else
            Tinput.Text = "1"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Tinput.Text <> "0" Then
            Tinput.Text += "2"
        Else
            Tinput.Text = "2"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Tinput.Text <> "0" Then
            Tinput.Text += "3"
        Else
            Tinput.Text = "3"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Tinput.Text <> "0" Then
            Tinput.Text += "4"
        Else
            Tinput.Text = "4"
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Tinput.Text <> "0" Then
            Tinput.Text += "5"
        Else
            Tinput.Text = "5"
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Tinput.Text <> "0" Then
            Tinput.Text += "6"
        Else
            Tinput.Text = "6"
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Tinput.Text <> "0" Then
            Tinput.Text += "7"
        Else
            Tinput.Text = "7"
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Tinput.Text <> "0" Then
            Tinput.Text += "8"
        Else
            Tinput.Text = "8"
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Tinput.Text <> "0" Then
            Tinput.Text += "9"
        Else
            Tinput.Text = "9"
        End If
    End Sub

    Private Sub Button00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button00.Click
        If Tinput.Text <> "0" Then
            Tinput.Text += "00"
        Else
            Tinput.Text = "00"
        End If
    End Sub

    Private Sub Button0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button0.Click
        If Tinput.Text <> "0" Then
            Tinput.Text += "0"
        Else
            Tinput.Text = "0"
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If Tinput.Text <> "0" Then
            Tinput.Text += ","
        Else
            Tinput.Text = ","
        End If
    End Sub

    Private Sub Buttonkali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonkali.Click
        num1 = Tinput.Text
        Tinput.Text = ""
        opr = "*"
    End Sub

   
    Private Sub Buttonbagi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonbagi.Click
        num1 = Tinput.Text
        Tinput.Text = ""
        opr = "/"
    End Sub

    Private Sub Buttontambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttontambah.Click
        num1 = Tinput.Text
        Tinput.Text = ""
        opr = "+"
    End Sub

    Private Sub Buttonkurang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonkurang.Click
        num1 = Tinput.Text
        Tinput.Text = ""
        opr = "-"
    End Sub

    Private Sub Buttonhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonhapus.Click
        Tinput.Clear()
    End Sub

    Private Sub Buttonexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonexit.Click
        End
    End Sub

    Private Sub Buttonsamadengan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonsamadengan.Click
        num2 = Tinput.Text
        If opr = "*" Then
            Tinput.Text = num1 * num2
        ElseIf opr = "/" Then
            Tinput.Text = num1 / num2
        ElseIf opr = "+" Then
            Tinput.Text = num1 + num2
        ElseIf opr = "-" Then
            Tinput.Text = num1 - num2
        Else
            MsgBox("Ada Yang Salah")
        End If
    End Sub
End Class