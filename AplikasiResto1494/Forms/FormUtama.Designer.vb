<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KategoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OlahDataKategoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OlahDataMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiBaruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OlahDataKasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.KategoriToolStripMenuItem, Me.MenuToolStripMenuItem, Me.PenjualanToolStripMenuItem, Me.KasirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(982, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(139, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'KategoriToolStripMenuItem
        '
        Me.KategoriToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OlahDataKategoriToolStripMenuItem})
        Me.KategoriToolStripMenuItem.Name = "KategoriToolStripMenuItem"
        Me.KategoriToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.KategoriToolStripMenuItem.Text = "Kategori"
        '
        'OlahDataKategoriToolStripMenuItem
        '
        Me.OlahDataKategoriToolStripMenuItem.Name = "OlahDataKategoriToolStripMenuItem"
        Me.OlahDataKategoriToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.OlahDataKategoriToolStripMenuItem.Text = "Olah Data Kategori"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OlahDataMenuToolStripMenuItem, Me.StokMenuToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'OlahDataMenuToolStripMenuItem
        '
        Me.OlahDataMenuToolStripMenuItem.Name = "OlahDataMenuToolStripMenuItem"
        Me.OlahDataMenuToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OlahDataMenuToolStripMenuItem.Text = "Olah Data Menu"
        '
        'StokMenuToolStripMenuItem
        '
        Me.StokMenuToolStripMenuItem.Name = "StokMenuToolStripMenuItem"
        Me.StokMenuToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.StokMenuToolStripMenuItem.Text = "Stok Menu"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiBaruToolStripMenuItem})
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'TransaksiBaruToolStripMenuItem
        '
        Me.TransaksiBaruToolStripMenuItem.Name = "TransaksiBaruToolStripMenuItem"
        Me.TransaksiBaruToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.TransaksiBaruToolStripMenuItem.Text = "Transaksi Baru"
        '
        'KasirToolStripMenuItem
        '
        Me.KasirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OlahDataKasirToolStripMenuItem})
        Me.KasirToolStripMenuItem.Name = "KasirToolStripMenuItem"
        Me.KasirToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.KasirToolStripMenuItem.Text = "Kasir"
        '
        'OlahDataKasirToolStripMenuItem
        '
        Me.OlahDataKasirToolStripMenuItem.Name = "OlahDataKasirToolStripMenuItem"
        Me.OlahDataKasirToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.OlahDataKasirToolStripMenuItem.Text = "Olah Data Kasir"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 953)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUtama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KategoriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OlahDataKategoriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OlahDataMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiBaruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KasirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OlahDataKasirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StokMenuToolStripMenuItem As ToolStripMenuItem
End Class
