Public Class GajiKaryawan

    Private Sub Cnik_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cnik.SelectedIndexChanged
        If Cnik.Text = "202111001" Then
            Tnama.Text = "Dwi Prasetyo"
        ElseIf Cnik.Text = "202111002" Then
            Tnama.Text = "Cindy Nur Halizah"
        ElseIf Cnik.Text = "202111003" Then
            Tnama.Text = "Monica Diandra"
        ElseIf Cnik.Text = "202111004" Then
            Tnama.Text = "Gelang Arum Kemangi Sukma"
        ElseIf Cnik.Text = "202111005" Then
            Tnama.Text = "Prita Karina Diandra"
        ElseIf Cnik.Text = "202111006" Then
            Tnama.Text = "Nadia Diandra"
        ElseIf Cnik.Text = "202111007" Then
            Tnama.Text = "Meo"
        ElseIf Cnik.Text = "202111008" Then
            Tnama.Text = "Mochi"
        ElseIf Cnik.Text = "202111009" Then
            Tnama.Text = "Moka"
        ElseIf Cnik.Text = "202111010" Then
            Tnama.Text = "Mimi"
        End If
    End Sub

    Private Sub Cdepart_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cdepart.SelectedIndexChanged
        If Cdepart.Text = "HRD" Then
            Tgajipokok.Text = 8000000
            Tjabatan.Text = 4000000
            Tanak.Text = 2000000
            Tkesehatan.Text = 4000000
        ElseIf Cdepart.Text = "MKT" Then
            Tgajipokok.Text = 5000000
            Tjabatan.Text = 2500000
            Tanak.Text = 2000000
            Tkesehatan.Text = 4000000
        ElseIf Cdepart.Text = "TQC" Then
            Tgajipokok.Text = 4000000
            Tjabatan.Text = 2000000
            Tanak.Text = 2000000
            Tkesehatan.Text = 4000000
        ElseIf Cdepart.Text = "PRD" Then
            Tgajipokok.Text = 6000000
            Tjabatan.Text = 3000000
            Tanak.Text = 2000000
            Tkesehatan.Text = 4000000
        End If
    End Sub

    Private Sub Bproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bproses.Click
        ListBox1.Items.Add("NIK : " + Cnik.Text)
        ListBox1.Items.Add("Nama : " + Tnama.Text)
        ListBox1.Items.Add("Departement : " + Cdepart.Text)
        ListBox1.Items.Add("Gaji Pokok : " + Tgajipokok.Text)
        ListBox1.Items.Add("Kehadiran : " + Thadir.Text + "X                     Gaji Pokok : " + Tgaji.Text)
        ListBox1.Items.Add("Jumlah Jam Lembur : " + Tlembur.Text + "X     Gaji Pokok/30 : " + Tgaji30.Text)
        ListBox1.Items.Add("Tunjangan Jabatan : " + Tjabatan.Text)
        ListBox1.Items.Add("Tunjangan Anak : " + Tanak.Text)
        ListBox1.Items.Add("Tunjangan Kesehatan : " + Tkesehatan.Text)
        ListBox1.Items.Add("Potongan Koperasi : " + Tkoperasi.Text)
        ListBox1.Items.Add("PPN : " + Tppn.Text)
        ListBox1.Items.Add("Total Gaji : " + Ttotalgaji.Text)

        Dim hadir, lembur, gaji, gaji30 As Integer
        Dim ppn As Integer
        Dim totalgaji As Integer

        hadir = Thadir.Text
        lembur = Tlembur.Text

        If Cdepart.Text = "HRD" Then
            Tgajipokok.Text = 8000000
        ElseIf Cdepart.Text = "MKT" Then
            Tgajipokok.Text = 5000000
        ElseIf Cdepart.Text = "TQC" Then
            Tgajipokok.Text = 4000000
        ElseIf Cdepart.Text = "PRD" Then
            Tgajipokok.Text = 6000000
        End If

        If Thadir.Text = "" Or Thadir.Text = "0" Then
            hadir = gaji * 50000
        Else
            hadir = 0
        End If
        If Tlembur.Text = "" Or Tlembur.Text = "0" Then
            lembur = gaji30 * 50000
        Else
            lembur = 0
        End If

        ppn = Val((Tgajipokok.Text) - Val(Tgajipokok.Text * 100%))
        totalgaji = (Val(Thadir.Text) * (Tgajipokok.Text)) + (Val(Tlembur.Text) * (Tgajipokok.Text)) + Val(Tjabatan.Text) + Val(Tanak.Text) + Val(Tkesehatan.Text) - Val(Tkoperasi.Text) - Val(Tppn.Text)

    End Sub

    Private Sub Bclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bclear.Click
        Cnik.Text = ""
        Tnama.Text = ""
        Cdepart.Text = ""
        Tgajipokok.Text = ""
        Thadir.Text = ""
        Tlembur.Text = ""
        Tjabatan.Text = ""
        Tanak.Text = ""
        Tkesehatan.Text = ""
        Tgaji.Text = ""
        Tgaji30.Text = ""

        ListBox1.Items.Clear()
    End Sub
End Class