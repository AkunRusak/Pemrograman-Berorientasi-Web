Public Class Warung

    Dim xtotal As Integer

    Private Sub Cmakan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmakan.SelectedIndexChanged
        If Cmakan.Text = "Kopi Luwak" Then
            Tharga.Text = 4500
        ElseIf Cmakan.Text = "Kopi Hitam" Then
            Tharga.Text = 4000
        ElseIf Cmakan.Text = "Mie Goreng" Then
            Tharga.Text = 10000
        ElseIf Cmakan.Text = "Mie Kuah" Then
            Tharga.Text = 6000
        ElseIf Cmakan.Text = "Mie Kuah Telor" Then
            Tharga.Text = 12000
        ElseIf Cmakan.Text = "Teh Manis" Then
            Tharga.Text = 3000
        ElseIf Cmakan.Text = "Nasi Goreng" Then
            Tharga.Text = 12000
        ElseIf Cmakan.Text = "Teh Tawar" Then
            Tharga.Text = 1500
        End If
    End Sub

    Private Sub Bbeli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bbeli.Click
        ListBox1.Items.Add(" " + Cmakan.Text + " " + "Harga : " + Tharga.Text)
        xtotal = xtotal + Val(Tharga.Text)
        Ttotal.Text = Format(xtotal, "#,##")
    End Sub

    Private Sub Tkembali_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tkembali.TextChanged

    End Sub

    Private Sub Tbayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbayar.TextChanged
        Tkembali.Text = Val(Tbayar.Text) - xtotal
    End Sub

    Private Sub Bclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bclear.Click
        Cmakan.Text = ""
        Tharga.Text = ""
        Ttotal.Text = ""
        Tbayar.Text = ""
        Tkembali.Text = ""
        ListBox1.Items.Clear()
    End Sub

    Private Sub Bkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bkeluar.Click
        Me.Close()
    End Sub
End Class