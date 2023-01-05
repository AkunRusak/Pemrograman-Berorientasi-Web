Public Class KalkulatorSains
    Dim angka, hasil As Double
    Dim sharedoperator As String
    Const pi As Double = 3.14159265358979
    Dim a, b As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Tinput.Text = "0" Then
            Tinput.Text = "1"
        Else
            Tinput.Text = Tinput.Text & "1"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Tinput.Text = "0" Then
            Tinput.Text = "2"
        Else
            Tinput.Text = Tinput.Text & "2"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Tinput.Text = "0" Then
            Tinput.Text = "3"
        Else
            Tinput.Text = Tinput.Text & "3"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Tinput.Text = "0" Then
            Tinput.Text = "4"
        Else
            Tinput.Text = Tinput.Text & "4"
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Tinput.Text = "0" Then
            Tinput.Text = "5"
        Else
            Tinput.Text = Tinput.Text & "5"
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Tinput.Text = "0" Then
            Tinput.Text = "6"
        Else
            Tinput.Text = Tinput.Text & "6"
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Tinput.Text = "0" Then
            Tinput.Text = "7"
        Else
            Tinput.Text = Tinput.Text & "7"
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Tinput.Text = "0" Then
            Tinput.Text = "8"
        Else
            Tinput.Text = Tinput.Text & "8"
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Tinput.Text = "0" Then
            Tinput.Text = "9"
        Else
            Tinput.Text = Tinput.Text & "9"
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If Tinput.Text = "0" Then
            Tinput.Text = "0"
        Else
            Tinput.Text = Tinput.Text & "0"
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If Tinput.Text = "0" Then
            Tinput.Text = "."
        Else
            Tinput.Text = Tinput.Text & "."
        End If
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        If Tinput.Text = "0" Then
            Tinput.Text = "00"
        Else
            Tinput.Text = Tinput.Text & "00"
        End If
    End Sub

    Private Sub Bsamadengan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsamadengan.Click
        If sharedoperator = "+" Then
            hasil = angka + Val(Tinput.Text)
            Tinput.Text = hasil
        ElseIf sharedoperator = "-" Then
            hasil = angka - Val(Tinput.Text)
            Tinput.Text = hasil
        ElseIf sharedoperator = "*" Then
            hasil = angka * Val(Tinput.Text)
            Tinput.Text = hasil
        ElseIf sharedoperator = "/" Then
            hasil = angka / Val(Tinput.Text)
            Tinput.Text = hasil
        ElseIf sharedoperator = "^" Then
            hasil = angka ^ Val(Tinput.Text)
            Tinput.Text = hasil
        ElseIf sharedoperator = "%" Then
            hasil = angka / 100
            Tinput.Text = hasil
        ElseIf sharedoperator = "n!" Then
            hasil = a * (a - 1) * (a - 2) * (a - 3) * (a - b)
            b = a - 1
            Tinput.Text = hasil
        ElseIf sharedoperator = " ✓" Then
            hasil = angka ^ 0.5
            Tinput.Text = hasil
        End If
    End Sub

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        End
    End Sub

   
    Private Sub Btambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btambah.Click
        If sharedoperator <> "" Then
            Select Case sharedoperator
                Case "+"
                    Call tambah()
                Case "-"
                    Call kurang()
                Case "x"
                    Call kali()
                Case "/"
                    Call bagi()
                Case "^"
                    Call pangkat()
                Case "log"
                    Call Log()
                Case "^1/2"
                    Call akar()
                Case "n!"
                    Call faktorial()
                Case "%"
                    Call persen()
                Case "Sin"
                    Call sin()
                Case "Cos"
                    Call cos()
                Case "Tan"
                    Call tan()
            End Select
        Else
            Call tambah()
        End If
        sharedoperator = "+"
        Tinput.Text = 0
    End Sub
    Private Sub tambah()
        If angka = "0" Then
            angka = Val(Tinput.Text)
        Else
            angka = angka + Val(Tinput.Text)
        End If
        sharedoperator = "+"
        Tinput.Text = ""
    End Sub

    Private Sub Bkurang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bkurang.Click
        If sharedoperator <> "" Then
            Select Case sharedoperator
                Case "+"
                    Call tambah()
                Case "-"
                    Call kurang()
                Case "x"
                    Call kali()
                Case "/"
                    Call bagi()
                Case "^"
                    Call pangkat()
                Case "log"
                    Call Log()
                Case "^1/2"
                    Call akar()
                Case "n!"
                    Call faktorial()
                Case "%"
                    Call persen()
                Case "Sin"
                    Call sin()
                Case "Cos"
                    Call cos()
                Case "Tan"
                    Call tan()
            End Select
        Else
            Call kurang()
        End If
        sharedoperator = "-"
        Tinput.Text = 0
    End Sub
    Private Sub kurang()
        If angka = "0" Then
            angka = Val(Tinput.Text)
        Else
            angka = angka - Val(Tinput.Text)
        End If
        sharedoperator = "-"
        Tinput.Text = ""
    End Sub

    Private Sub Bkali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bkali.Click
        If sharedoperator <> "" Then
            Select Case sharedoperator
                Case "+"
                    Call tambah()
                Case "-"
                    Call kurang()
                Case "x"
                    Call kali()
                Case "/"
                    Call bagi()
                Case "^"
                    Call pangkat()
                Case "log"
                    Call Log()
                Case "^1/2"
                    Call akar()
                Case "n!"
                    Call faktorial()
                Case "%"
                    Call persen()
                Case "Sin"
                    Call sin()
                Case "Cos"
                    Call cos()
                Case "Tan"
                    Call tan()
            End Select
        Else
            Call kali()
        End If
        sharedoperator = "*"
        Tinput.Text = 0
    End Sub
    Private Sub kali()
        If angka = "0" Then
            angka = Val(Tinput.Text)
        Else
            angka = angka * Val(Tinput.Text)
        End If
        sharedoperator = "*"
        Tinput.Text = ""
    End Sub

    Private Sub Bbagi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bbagi.Click
        If sharedoperator <> "" Then
            Select Case sharedoperator
                Case "+"
                    Call tambah()
                Case "-"
                    Call kurang()
                Case "x"
                    Call kali()
                Case "/"
                    Call bagi()
                Case "^"
                    Call pangkat()
                Case "log"
                    Call Log()
                Case "^1/2"
                    Call akar()
                Case "n!"
                    Call faktorial()
                Case "%"
                    Call persen()
                Case "Sin"
                    Call sin()
                Case "Cos"
                    Call cos()
                Case "Tan"
                    Call tan()
            End Select
        Else
            Call bagi()
        End If
        sharedoperator = "/"
        Tinput.Text = 0
    End Sub
    Private Sub bagi()
        If angka = "0" Then
            angka = Val(Tinput.Text)
        Else
            angka = angka / Val(Tinput.Text)
        End If
        sharedoperator = "/"
        Tinput.Text = ""
    End Sub

    Private Sub Bpangkat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bpangkat.Click
        If sharedoperator <> "" Then
            Select Case sharedoperator
                Case "+"
                    Call tambah()
                Case "-"
                    Call kurang()
                Case "x"
                    Call kali()
                Case "/"
                    Call bagi()
                Case "^"
                    Call pangkat()
                Case "log"
                    Call Log()
                Case "^1/2"
                    Call akar()
                Case "n!"
                    Call faktorial()
                Case "%"
                    Call persen()
                Case "Sin"
                    Call sin()
                Case "Cos"
                    Call cos()
                Case "Tan"
                    Call tan()
            End Select
        Else
            Call pangkat()
        End If
        sharedoperator = "^"
        Tinput.Text = 0
    End Sub
    Private Sub pangkat()
        If angka = "0" Then
            angka = Val(Tinput.Text)
        Else
            angka = angka ^ Val(Tinput.Text)
        End If
        sharedoperator = "^"
        Tinput.Text = ""
    End Sub

    Private Sub Bc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bc.Click
        Tinput.Text = "0"
        angka = 0
        hasil = 0
        sharedoperator = ""
    End Sub

    Private Sub Bpersen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bpersen.Click
        If sharedoperator <> "" Then
            Select Case sharedoperator
                Case "+"
                    Call tambah()
                Case "-"
                    Call kurang()
                Case "x"
                    Call kali()
                Case "/"
                    Call bagi()
                Case "^"
                    Call pangkat()
                Case "log"
                    Call Log()
                Case "^1/2"
                    Call akar()
                Case "n!"
                    Call faktorial()
                Case "%"
                    Call persen()
                Case "Sin"
                    Call sin()
                Case "Cos"
                    Call cos()
                Case "Tan"
                    Call tan()
            End Select
        Else
            Call persen()
        End If
        sharedoperator = "%"
        Tinput.Text = 0
    End Sub
    Private Sub persen()
        If angka = "0" Then
            angka = Val(Tinput.Text)
        Else
            angka = angka / 100
        End If
        sharedoperator = "%"
        Tinput.Text = ""
    End Sub

    Private Sub Bsin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsin.Click
        If sharedoperator <> "" Then
            Select Case sharedoperator
                Case "+"
                    Call tambah()
                Case "-"
                    Call kurang()
                Case "x"
                    Call kali()
                Case "/"
                    Call bagi()
                Case "^"
                    Call pangkat()
                Case "log"
                    Call log()
                Case "^1/2"
                    Call akar()
                Case "n!"
                    Call faktorial()
                Case "%"
                    Call persen()
                Case "Sin"
                    Call sin()
                Case "Cos"
                    Call cos()
                Case "Tan"
                    Call tan()
            End Select
        Else
            Call sin()
        End If
        sharedoperator = "SIN"
        Tinput.Text = 0
    End Sub
    Private Sub sin()
        Tinput.Text = Math.Sin(Tinput.Text * (pi / 180))
    End Sub

    Private Sub Bcos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcos.Click
        If sharedoperator <> "" Then
            Select Case sharedoperator
                Case "+"
                    Call tambah()
                Case "-"
                    Call kurang()
                Case "x"
                    Call kali()
                Case "/"
                    Call bagi()
                Case "^"
                    Call pangkat()
                Case "log"
                    Call Log()
                Case "^1/2"
                    Call akar()
                Case "n!"
                    Call faktorial()
                Case "%"
                    Call persen()
                Case "Sin"
                    Call sin()
                Case "Cos"
                    Call cos()
                Case "Tan"
                    Call tan()
            End Select
        Else
            Call cos()
        End If
        sharedoperator = "COS"
        Tinput.Text = 0
    End Sub
    Private Sub cos()
        Tinput.Text = Math.Cos(Tinput.Text * (pi / 180))
    End Sub

    Private Sub Btan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btan.Click
        If sharedoperator <> "" Then
            Select Case sharedoperator
                Case "+"
                    Call tambah()
                Case "-"
                    Call kurang()
                Case "x"
                    Call kali()
                Case "/"
                    Call bagi()
                Case "^"
                    Call pangkat()
                Case "log"
                    Call Log()
                Case "^1/2"
                    Call akar()
                Case "n!"
                    Call faktorial()
                Case "%"
                    Call persen()
                Case "Sin"
                    Call sin()
                Case "Cos"
                    Call cos()
                Case "Tan"
                    Call tan()
            End Select
        Else
            Call tan()
        End If
        sharedoperator = "TAN"
        Tinput.Text = 0
    End Sub
    Private Sub tan()
        Tinput.Text = Math.Tan(Tinput.Text * (pi / 180))
    End Sub

    Private Sub Bn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bn.Click
        If sharedoperator <> "" Then
            Select Case sharedoperator
                Case "+"
                    Call tambah()
                Case "-"
                    Call kurang()
                Case "x"
                    Call kali()
                Case "/"
                    Call bagi()
                Case "^"
                    Call pangkat()
                Case "log"
                    Call Log()
                Case "^1/2"
                    Call akar()
                Case "n!"
                    Call faktorial()
                Case "%"
                    Call persen()
                Case "Sin"
                    Call sin()
                Case "Cos"
                    Call cos()
                Case "Tan"
                    Call tan()
            End Select
        Else
            Call faktorial()
        End If
        sharedoperator = "n!"
        Tinput.Text = 0
    End Sub
    Private Sub faktorial()
        Dim a As Long
        Dim fac As Integer

        b = a - 1
        If a = 0 Then
            a = Val(Tinput.Text)
        Else : a = a * (a - 1) * (a - 2) * (a - b)
        End If
        fac = 1
        a = Tinput.Text

        Dim i As Integer

        For i = a To 1 Step -1
            fac = fac * i
        Next i
        Tinput.Text = fac
    End Sub

    Private Sub Blogx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blogx.Click
        If sharedoperator <> "" Then
            Select Case sharedoperator
                Case "+"
                    Call tambah()
                Case "-"
                    Call kurang()
                Case "x"
                    Call kali()
                Case "/"
                    Call bagi()
                Case "^"
                    Call pangkat()
                Case "log"
                    Call Log()
                Case "^1/2"
                    Call akar()
                Case "n!"
                    Call faktorial()
                Case "%"
                    Call persen()
                Case "Sin"
                    Call sin()
                Case "Cos"
                    Call cos()
                Case "Tan"
                    Call tan()
            End Select
        Else
            Call Log()
        End If
        sharedoperator = "log10"
        Tinput.Text = 0
    End Sub
    Private Sub Log()
        Tinput.Text = Math.Log10(Tinput.Text)
    End Sub

    Private Sub Bakar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bakar.Click
        If sharedoperator <> "" Then
            Select Case sharedoperator
                Case "+"
                    Call tambah()
                Case "-"
                    Call kurang()
                Case "x"
                    Call kali()
                Case "/"
                    Call bagi()
                Case "^"
                    Call pangkat()
                Case "log"
                    Call Log()
                Case "^1/2"
                    Call akar()
                Case "n!"
                    Call faktorial()
                Case "%"
                    Call persen()
                Case "Sin"
                    Call sin()
                Case "Cos"
                    Call cos()
                Case "Tan"
                    Call tan()
            End Select
        Else
            Call akar()
        End If
        sharedoperator = " ✓"
        Tinput.Text = 0
    End Sub
    Private Sub akar()
        If Angka = 0 Then
            angka = Val(Tinput.Text)
        Else
            Angka = Angka ^ 0.5
        End If
        sharedoperator = "√"
        Tinput.Text = ""
    End Sub

    Private Sub Bdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bdelete.Click
        If Tinput.Text.Length <> 0 Then
            Tinput.Text = Tinput.Text.Remove(Tinput.Text.Length - 1, 1)
        End If
    End Sub
End Class