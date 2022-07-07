<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.DGMenu = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtKategori = New System.Windows.Forms.TextBox()
        Me.txtIDMenu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
        CType(Me.DGMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHapus
        '
        Me.btnHapus.Image = Global.AplikasiResto1494.My.Resources.Resources.Trash
        Me.btnHapus.Location = New System.Drawing.Point(505, 257)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(50, 50)
        Me.btnHapus.TabIndex = 13
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = Global.AplikasiResto1494.My.Resources.Resources.Cancel
        Me.btnBatal.Location = New System.Drawing.Point(505, 201)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(50, 50)
        Me.btnBatal.TabIndex = 12
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.AplikasiResto1494.My.Resources.Resources.Save
        Me.btnSimpan.Location = New System.Drawing.Point(505, 143)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(50, 50)
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Image = Global.AplikasiResto1494.My.Resources.Resources.Pencil
        Me.btnUbah.Location = New System.Drawing.Point(505, 87)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(50, 50)
        Me.btnUbah.TabIndex = 10
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.AplikasiResto1494.My.Resources.Resources.Add
        Me.btnTambah.Location = New System.Drawing.Point(505, 31)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(50, 50)
        Me.btnTambah.TabIndex = 9
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'DGMenu
        '
        Me.DGMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMenu.Location = New System.Drawing.Point(12, 343)
        Me.DGMenu.Name = "DGMenu"
        Me.DGMenu.RowHeadersWidth = 51
        Me.DGMenu.RowTemplate.Height = 29
        Me.DGMenu.Size = New System.Drawing.Size(559, 188)
        Me.DGMenu.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 241)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 96)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukkan nama menu yang dicari:"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(6, 38)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(259, 27)
        Me.txtCari.TabIndex = 0
        '
        'btnCari
        '
        Me.btnCari.Image = Global.AplikasiResto1494.My.Resources.Resources.Search
        Me.btnCari.Location = New System.Drawing.Point(271, 26)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(50, 50)
        Me.btnCari.TabIndex = 9
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'txtKategori
        '
        Me.txtKategori.Location = New System.Drawing.Point(283, 80)
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Size = New System.Drawing.Size(98, 27)
        Me.txtKategori.TabIndex = 19
        '
        'txtIDMenu
        '
        Me.txtIDMenu.Location = New System.Drawing.Point(152, 43)
        Me.txtIDMenu.Name = "txtIDMenu"
        Me.txtIDMenu.Size = New System.Drawing.Size(125, 27)
        Me.txtIDMenu.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "ID Kategori"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ID Menu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nama Menu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Harga Menu"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(152, 117)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(229, 27)
        Me.txtNama.TabIndex = 22
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(152, 157)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(125, 27)
        Me.txtHarga.TabIndex = 23
        '
        'cmbKategori
        '
        Me.cmbKategori.FormattingEnabled = True
        Me.cmbKategori.Location = New System.Drawing.Point(152, 80)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(125, 28)
        Me.cmbKategori.TabIndex = 24
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 543)
        Me.Controls.Add(Me.cmbKategori)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKategori)
        Me.Controls.Add(Me.txtIDMenu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGMenu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Menu"
        CType(Me.DGMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents DGMenu As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents txtKategori As TextBox
    Friend WithEvents txtIDMenu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents cmbKategori As ComboBox
End Class
