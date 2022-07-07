Public Class FormUtama
    Private Sub OlahDataKategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OlahDataKategoriToolStripMenuItem.Click
        FormKategori.Show()
    End Sub

    Private Sub OlahDataMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OlahDataMenuToolStripMenuItem.Click
        FormMenu.Show()
    End Sub

    Private Sub TransaksiBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiBaruToolStripMenuItem.Click
        FormPenjualan.Show()
    End Sub

    Private Sub OlahDataKasirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OlahDataKasirToolStripMenuItem.Click
        FormKasir.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        FormLogin.Show()
    End Sub

    Private Sub StokMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokMenuToolStripMenuItem.Click
        FormCariMenu.Show()
    End Sub
End Class
