Public Class UTS202111002

    Private Sub Ckodematkul_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ckodematkul.SelectedIndexChanged
        If Ckodematkul.Text = "MT01" Then
            Tsks.Text = 4
            Tnamamatkul.Text = "PBO I"
        ElseIf Ckodematkul.Text = "MT02" Then
            Tsks.Text = 2
            Tnamamatkul.Text = "SIM"
        ElseIf Ckodematkul.Text = "MT03" Then
            Tsks.Text = 2
            Tnamamatkul.Text = "WEB"
        ElseIf Ckodematkul.Text = "MT04" Then
            Tsks.Text = 4
            Tnamamatkul.Text = "Matematika"
        ElseIf Ckodematkul.Text = "MT05" Then
            Tsks.Text = 2
            Tnamamatkul.Text = "Algoritma"
        ElseIf Ckodematkul.Text = "MT06" Then
            Tsks.Text = 4
            Tnamamatkul.Text = "Sistem Operasi"
        ElseIf Ckodematkul.Text = "MT07" Then
            Tsks.Text = 2
            Tnamamatkul.Text = "Struktur Data"
        End If
    End Sub

    Private Sub Bclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bclear.Click
        Ckodematkul.Text = ""
        Tnamamatkul.Text = ""
        Tnama.Text = ""
        Tnilai.Text = ""
        Tnilaibobot.Text = ""
        Tnilaihuruf.Text = ""
        Tsks.Text = ""
        Cprodi.Text = ""
        ListBox1.Items.Clear()

    End Sub

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Me.Close()
    End Sub

    Private Sub Bproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bproses.Click
        ListBox1.Items.Add("Kode Mata Kuliah : " + Ckodematkul.Text)
        ListBox1.Items.Add("Nama Mata Kuliah : " + Tnamamatkul.Text)
        ListBox1.Items.Add("SKS : " + Tsks.Text)
        ListBox1.Items.Add("Nama : " + Tnama.Text)
        ListBox1.Items.Add("Prodi : " + Cprodi.Text)
        ListBox1.Items.Add("Nilai : " + Tnilai.Text)
        ListBox1.Items.Add("Nilai Huruf : " + Tnilaihuruf.Text)
        ListBox1.Items.Add("Nilai Bobot : " + Tnilaibobot.Text)

        Dim sks, nilai As Double
        Dim ipk As String
        sks = Tsks.Text
        nilai = Tnilai.Text

        ipk = nilai : Val(Tsks.Text)
        Ttotalsks.Text = Format(sks, "")
        Tipk.Text = Format(nilai * sks)

        If nilai >= "85" And nilai <= "100" Then
            Tnilaihuruf.Text = "A"
            Tnilaibobot.Text = "4"
        End If
        If nilai <= "70" And nilai < "85" Then
            Tnilaihuruf.Text = "B"
            Tnilaibobot.Text = "3"
        End If
        If nilai <= "60" And nilai < "70" Then
            Tnilaihuruf.Text = "C"
            Tnilaibobot.Text = "2"
        End If
        If nilai <= "50" And nilai < "60" Then
            Tnilaihuruf.Text = "D"
            Tnilaibobot.Text = "1"
        End If
        If nilai < "50" Then
            Tnilaihuruf.Text = "E"
            Tnilaibobot.Text = "0"
        End If
    End Sub
End Class