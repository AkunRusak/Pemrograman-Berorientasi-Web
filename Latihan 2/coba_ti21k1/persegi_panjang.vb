Public Class persegi_panjang

    Private Sub Luas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Luas.Click
        TLuas.Text = Val(TPanjang.Text) * Val(TLebar.Text)
    End Sub

    Private Sub Keliling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Keliling.Click
        TKeliling.Text = 2 * Val(TPanjang.Text) + 2 * Val(TLebar.Text)
    End Sub
End Class