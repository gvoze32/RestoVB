<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIDJual = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblIDKasir = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNamaKasir = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblJumlahMenu = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.txtKembali = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtNamaMenu = New System.Windows.Forms.TextBox()
        Me.txtIDMenu = New System.Windows.Forms.TextBox()
        Me.LVPenjualan = New System.Windows.Forms.ListView()
        Me.btnCariMenu = New System.Windows.Forms.Button()
        Me.TPTanggal = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Jual"
        '
        'lblIDJual
        '
        Me.lblIDJual.AutoSize = True
        Me.lblIDJual.Location = New System.Drawing.Point(133, 9)
        Me.lblIDJual.Name = "lblIDJual"
        Me.lblIDJual.Size = New System.Drawing.Size(16, 20)
        Me.lblIDJual.TabIndex = 1
        Me.lblIDJual.Text = "x"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID Kasir"
        '
        'lblIDKasir
        '
        Me.lblIDKasir.AutoSize = True
        Me.lblIDKasir.Location = New System.Drawing.Point(133, 39)
        Me.lblIDKasir.Name = "lblIDKasir"
        Me.lblIDKasir.Size = New System.Drawing.Size(16, 20)
        Me.lblIDKasir.TabIndex = 3
        Me.lblIDKasir.Text = "x"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Nama Kasir"
        '
        'lblNamaKasir
        '
        Me.lblNamaKasir.AutoSize = True
        Me.lblNamaKasir.Location = New System.Drawing.Point(133, 69)
        Me.lblNamaKasir.Name = "lblNamaKasir"
        Me.lblNamaKasir.Size = New System.Drawing.Size(16, 20)
        Me.lblNamaKasir.TabIndex = 5
        Me.lblNamaKasir.Text = "x"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(369, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Hari/Tanggal"
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Location = New System.Drawing.Point(488, 9)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(16, 20)
        Me.lblTanggal.TabIndex = 7
        Me.lblTanggal.Text = "x"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(421, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Harga"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(488, 69)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(16, 20)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "x"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 20)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Jumlah"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 364)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 20)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Jumlah Menu"
        '
        'lblJumlahMenu
        '
        Me.lblJumlahMenu.AutoSize = True
        Me.lblJumlahMenu.Location = New System.Drawing.Point(116, 363)
        Me.lblJumlahMenu.Name = "lblJumlahMenu"
        Me.lblJumlahMenu.Size = New System.Drawing.Size(16, 20)
        Me.lblJumlahMenu.TabIndex = 13
        Me.lblJumlahMenu.Text = "x"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(357, 367)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 20)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Bayar"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(357, 400)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 20)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Kembali"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.btnHitung)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.txtBayar)
        Me.GroupBox1.Controls.Add(Me.txtKembali)
        Me.GroupBox1.Controls.Add(Me.txtJumlah)
        Me.GroupBox1.Controls.Add(Me.txtHarga)
        Me.GroupBox1.Controls.Add(Me.txtNamaMenu)
        Me.GroupBox1.Controls.Add(Me.txtIDMenu)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.LVPenjualan)
        Me.GroupBox1.Controls.Add(Me.btnCariMenu)
        Me.GroupBox1.Controls.Add(Me.lblJumlahMenu)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 435)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputkan Pesanan"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(98, 363)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(12, 20)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = ":"
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(245, 363)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(94, 29)
        Me.btnHitung.TabIndex = 33
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Image = Global.AplikasiResto1494.My.Resources.Resources.Trash
        Me.btnHapus.Location = New System.Drawing.Point(561, 244)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(50, 50)
        Me.btnHapus.TabIndex = 32
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.AplikasiResto1494.My.Resources.Resources.Save
        Me.btnSimpan.Location = New System.Drawing.Point(561, 371)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(50, 50)
        Me.btnSimpan.TabIndex = 31
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.AplikasiResto1494.My.Resources.Resources.Add
        Me.btnTambah.Location = New System.Drawing.Point(561, 176)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(50, 50)
        Me.btnTambah.TabIndex = 30
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtBayar
        '
        Me.txtBayar.Location = New System.Drawing.Point(430, 364)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(125, 27)
        Me.txtBayar.TabIndex = 21
        '
        'txtKembali
        '
        Me.txtKembali.Location = New System.Drawing.Point(430, 397)
        Me.txtKembali.Name = "txtKembali"
        Me.txtKembali.Size = New System.Drawing.Size(125, 27)
        Me.txtKembali.TabIndex = 20
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(110, 123)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(125, 27)
        Me.txtJumlah.TabIndex = 19
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(110, 90)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(125, 27)
        Me.txtHarga.TabIndex = 18
        '
        'txtNamaMenu
        '
        Me.txtNamaMenu.Location = New System.Drawing.Point(245, 50)
        Me.txtNamaMenu.Name = "txtNamaMenu"
        Me.txtNamaMenu.Size = New System.Drawing.Size(206, 27)
        Me.txtNamaMenu.TabIndex = 17
        '
        'txtIDMenu
        '
        Me.txtIDMenu.Location = New System.Drawing.Point(110, 50)
        Me.txtIDMenu.Name = "txtIDMenu"
        Me.txtIDMenu.Size = New System.Drawing.Size(125, 27)
        Me.txtIDMenu.TabIndex = 16
        '
        'LVPenjualan
        '
        Me.LVPenjualan.Location = New System.Drawing.Point(6, 176)
        Me.LVPenjualan.Name = "LVPenjualan"
        Me.LVPenjualan.Size = New System.Drawing.Size(549, 173)
        Me.LVPenjualan.TabIndex = 14
        Me.LVPenjualan.UseCompatibleStateImageBehavior = False
        '
        'btnCariMenu
        '
        Me.btnCariMenu.Location = New System.Drawing.Point(10, 40)
        Me.btnCariMenu.Name = "btnCariMenu"
        Me.btnCariMenu.Size = New System.Drawing.Size(94, 47)
        Me.btnCariMenu.TabIndex = 13
        Me.btnCariMenu.Text = "Cari Menu"
        Me.btnCariMenu.UseVisualStyleBackColor = True
        '
        'TPTanggal
        '
        Me.TPTanggal.Enabled = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(110, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(470, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(470, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = ":"
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 592)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTanggal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblNamaKasir)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblIDKasir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblIDJual)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Penjualan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblIDJual As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblIDKasir As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblNamaKasir As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblJumlahMenu As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCariMenu As Button
    Friend WithEvents LVPenjualan As ListView
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents txtKembali As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtNamaMenu As TextBox
    Friend WithEvents txtIDMenu As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents TPTanggal As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnHitung As Button
End Class
