Public Class Menu

    Private Sub EntriDataNilaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntriDataNilaiToolStripMenuItem.Click
        UTS202111002.Show()
    End Sub

    Private Sub MenghitungGajiKaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenghitungGajiKaryawanToolStripMenuItem.Click
        GajiKaryawan.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class