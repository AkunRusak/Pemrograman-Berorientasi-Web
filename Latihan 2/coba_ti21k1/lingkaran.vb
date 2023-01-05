Public Class lingkaran
    Private Sub btnluas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnluas.Click
        Tluas.Text = 3.14 * (Val(Tjari_jari.Text) ^ 2)
    End Sub

    Private Sub btnkeliling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeliling.Click
        Tkeliling.Text = 2 * 3.14 * Val(Tjari_jari.Text)
    End Sub
End Class