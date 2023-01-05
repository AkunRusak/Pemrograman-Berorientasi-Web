Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        hasill.Text = Val(nilai11.Text) + Val(nilai22.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        hasill.Text = Val(nilai11.Text) - Val(nilai22.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        hasill.Text = Val(nilai11.Text) * Val(nilai22.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        hasill.Text = Val(nilai11.Text) / Val(nilai22.Text)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        hasill.Text = Val(nilai11.Text) ^ Val(nilai22.Text)
    End Sub
End Class
