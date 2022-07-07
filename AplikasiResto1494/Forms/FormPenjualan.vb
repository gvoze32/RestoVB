Public Class FormPenjualan
    Private Sub TPTanggal_Tick(sender As Object, e As EventArgs) Handles TPTanggal.Tick
        Dim namaHari As String()
        namaHari = New String() {" \M\i\n\g\g\u", "\S\e\n\i\n", "\S\e\l\a\s\a", "\R\a\b\u", "\K\a\m\i\s", "\J\u\m\a\t", "\S\a\b\t\u"}
        lblTanggal.Text = Format(Now, namaHari(Now.DayOfWeek()) & ", dd MMMM yyyy ")
    End Sub

    Sub Buattabel()
        LVPenjualan.Columns.Add("ID Menu", 120, HorizontalAlignment.Center)
        LVPenjualan.Columns.Add("Nama Menu", 180, HorizontalAlignment.Center)
        LVPenjualan.Columns.Add("Harga Menu", 120, HorizontalAlignment.Center)
        LVPenjualan.Columns.Add("Qty", 90, HorizontalAlignment.Center)
        LVPenjualan.Columns.Add("Sub Total", 120, HorizontalAlignment.Center)

        LVPenjualan.View = View.Details
        LVPenjualan.GridLines = True
        LVPenjualan.FullRowSelect = True
    End Sub

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Buattabel()
        lblIDJual.Text = KontrolPenjualan.kodebaru()
        lblIDKasir.Text = KODELOG
        lblNamaKasir.Text = NAMALOG

        MdiParent = FormUtama
    End Sub

    Private Sub btnCariMenu_Click(sender As Object, e As EventArgs) Handles btnCariMenu.Click
        FormCariMenu.Show()
    End Sub

    Sub JumlahLVMenu()
        Dim jumMenu As Integer = 0
        Dim jumHarga As Integer = 0
        Dim total As Double = 0
        For baris As Integer = 0 To LVPenjualan.Items.Count - 1
            jumMenu = jumMenu + LVPenjualan.Items(baris).SubItems(3).Text
            jumHarga = jumHarga + LVPenjualan.Items(baris).SubItems(4).Text
        Next
        lblTotal.Text = jumHarga
        lblJumlahMenu.Text = jumMenu
    End Sub

    Sub TambahMenu()
        txtIDMenu.Text = ""
        txtNamaMenu.Text = ""
        txtHarga.Text = ""
        txtJumlah.Text = ""
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim strMenu(5) As String

        strMenu(0) = txtIDMenu.Text
        strMenu(1) = txtNamaMenu.Text
        strMenu(2) = txtHarga.Text
        strMenu(3) = txtJumlah.Text
        strMenu(4) = Val(txtHarga.Text * txtJumlah.Text)
        LVPenjualan.Items.Add(New ListViewItem(strMenu))
        Call JumlahLVMenu()
        Call TambahMenu()
    End Sub

    Sub Bersih()
        LVPenjualan.Items.Clear()
        lblTotal.Text = "0"
        txtBayar.Text = "0"
        txtKembali.Text = "0"
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        LVPenjualan.SelectedItems(0).Remove()
        Call JumlahLVMenu()
    End Sub

    Private Sub txtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBayar.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            If Val(txtBayar.Text) < Val(lblTotal.Text) Then
                MsgBox("Pembayaran Kurang")
                Exit Sub
            ElseIf Val(txtBayar.Text) = Val(lblTotal.Text) Then
                txtKembali.Text = 0
                btnSimpan.Focus()
            ElseIf Val(txtBayar.Text) > Val(lblTotal.Text) Then
                txtKembali.Text = Val(txtBayar.Text) - Val(lblTotal.Text)
                btnSimpan.Focus()
            End If
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim lsdetail As New List(Of ClsEntDetailJual)()
        If LVPenjualan.Items.Count = 0 Then
            MsgBox("Masukkan Menu yang akan dipesan terlebih dahulu")
            Exit Sub
        End If
        With EntitasPenjualan
            .Total = lblTotal.Text
            .TglJual = Format(Now, "dd/MM/yyyy")
            .IdKasir = lblIDKasir.Text
        End With
        For i = 0 To LVPenjualan.Items.Count - 1

            EntitasDetailJual = New ClsEntDetailJual
            With LVPenjualan.Items(i)
                EntitasDetailJual.IdMenu = .SubItems(0).Text
                EntitasDetailJual.HargaJual = .SubItems(2).Text
                EntitasDetailJual.Qty = .SubItems(3).Text

            End With

            lsdetail.Add(EntitasDetailJual)
        Next i
        For I = 0 To lsdetail.Count - 1

        Next
        KontrolPenjualan.SIMPAN_DATA(EntitasPenjualan, lsdetail)
        Bersih()
    End Sub
End Class