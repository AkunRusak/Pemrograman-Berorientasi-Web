Public Class bola

    Private Sub Luas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Luas.Click
        Thasil.Text = 4 * 3.14 * (Val(Tr.Text) ^ 2)


    End Sub

    Private Sub volume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volume.Click
        Thasil.Text = 4 / 3 * 3.14 * (Val(Tr.Text) ^ 3)
    End Sub

    Private Sub Keliling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Keliling.Click
        Thasil.Text = 4 / 3 * 3.14 * (Val(Tr.Text) ^ 2)
    End Sub
End Class