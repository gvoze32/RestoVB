<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKategori
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIDKategori = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.DGKategori = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Kategori"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Kategori"
        '
        'txtIDKategori
        '
        Me.txtIDKategori.Location = New System.Drawing.Point(152, 46)
        Me.txtIDKategori.Name = "txtIDKategori"
        Me.txtIDKategori.Size = New System.Drawing.Size(125, 27)
        Me.txtIDKategori.TabIndex = 2
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(152, 91)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(229, 27)
        Me.txtNama.TabIndex = 3
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.AplikasiResto1494.My.Resources.Resources.Add
        Me.btnTambah.Location = New System.Drawing.Point(521, 34)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(50, 50)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Image = Global.AplikasiResto1494.My.Resources.Resources.Pencil
        Me.btnUbah.Location = New System.Drawing.Point(521, 90)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(50, 50)
        Me.btnUbah.TabIndex = 5
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.AplikasiResto1494.My.Resources.Resources.Save
        Me.btnSimpan.Location = New System.Drawing.Point(521, 146)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(50, 50)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = Global.AplikasiResto1494.My.Resources.Resources.Cancel
        Me.btnBatal.Location = New System.Drawing.Point(521, 204)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(50, 50)
        Me.btnBatal.TabIndex = 7
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Image = Global.AplikasiResto1494.My.Resources.Resources.Trash
        Me.btnHapus.Location = New System.Drawing.Point(521, 260)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(50, 50)
        Me.btnHapus.TabIndex = 8
        Me.btnHapus.UseVisualStyleBackColor = True
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 231)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 96)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukkan nama kategori yang dicari:"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(6, 38)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(259, 27)
        Me.txtCari.TabIndex = 0
        '
        'DGKategori
        '
        Me.DGKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGKategori.Location = New System.Drawing.Point(12, 343)
        Me.DGKategori.Name = "DGKategori"
        Me.DGKategori.RowHeadersWidth = 51
        Me.DGKategori.RowTemplate.Height = 29
        Me.DGKategori.Size = New System.Drawing.Size(559, 188)
        Me.DGKategori.TabIndex = 11
        '
        'FormKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 543)
        Me.Controls.Add(Me.DGKategori)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtIDKategori)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormKategori"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Kategori"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGKategori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIDKategori As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGKategori As DataGridView
    Friend WithEvents txtCari As TextBox
End Class
