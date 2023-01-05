Public Class Kondisi_IF
    Dim xhrg As Integer
    Dim hrg_disc As Integer
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub CNamabarang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CNamabarang.SelectedIndexChanged
        If CNamabarang.Text = "TV LG 20 inch" Then
            xhrg = 3000000
            Tharga.Text = Format(xhrg, "#,##")
        ElseIf CNamabarang.Text = "AC Samsung" Then
            xhrg = 4000000
            Tharga.Text = Format(xhrg, "#,##")
        ElseIf CNamabarang.Text = "HP Samsung" Then
            xhrg = 5000000
            Tharga.Text = Format(xhrg, "#,##")
        ElseIf CNamabarang.Text = "Kulkas Panasonic" Then
            xhrg = 2000000
            Tharga.Text = Format(xhrg, "#,##")
        End If
    End Sub

    Private Sub disc5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disc5.Click
        hrg_disc = xhrg - (xhrg * 5 / 100)
        Tdisc_harga.Text = Format(hrg_disc, "#,##")
    End Sub

    Private Sub disc10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disc10.CheckedChanged
        hrg_disc = xhrg - (xhrg * 10 / 100)
        Tdisc_harga.Text = Format(hrg_disc, "#,##")
    End Sub

    Private Sub disc15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disc15.CheckedChanged
        hrg_disc = xhrg - (xhrg * 15 / 100)
        Tdisc_harga.Text = Format(hrg_disc, "#,##")
    End Sub

    Private Sub disc25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disc25.Click
        hrg_disc = xhrg - (xhrg * 25 / 100)
        Tdisc_harga.Text = Format(hrg_disc, "#,##")
    End Sub

    Private Sub Tharga_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tharga.TextChanged

    End Sub
End Class