<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKasir
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
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtIDKasir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.DGKasir = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbLevel = New System.Windows.Forms.ComboBox()
        CType(Me.DGKasir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(152, 118)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(229, 27)
        Me.txtUserID.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "UserID"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(152, 81)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(229, 27)
        Me.txtNama.TabIndex = 35
        '
        'txtIDKasir
        '
        Me.txtIDKasir.Location = New System.Drawing.Point(152, 44)
        Me.txtIDKasir.Name = "txtIDKasir"
        Me.txtIDKasir.Size = New System.Drawing.Size(125, 27)
        Me.txtIDKasir.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Nama Kasir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "ID Kasir"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(6, 38)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(259, 27)
        Me.txtCari.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(152, 158)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(125, 27)
        Me.txtPassword.TabIndex = 39
        '
        'DGKasir
        '
        Me.DGKasir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGKasir.Location = New System.Drawing.Point(12, 343)
        Me.DGKasir.Name = "DGKasir"
        Me.DGKasir.RowHeadersWidth = 51
        Me.DGKasir.RowTemplate.Height = 29
        Me.DGKasir.Size = New System.Drawing.Size(559, 188)
        Me.DGKasir.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 241)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 96)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukkan nama kasir yang dicari:"
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
        'btnHapus
        '
        Me.btnHapus.Image = Global.AplikasiResto1494.My.Resources.Resources.Trash
        Me.btnHapus.Location = New System.Drawing.Point(505, 258)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(50, 50)
        Me.btnHapus.TabIndex = 29
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = Global.AplikasiResto1494.My.Resources.Resources.Cancel
        Me.btnBatal.Location = New System.Drawing.Point(505, 202)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(50, 50)
        Me.btnBatal.TabIndex = 28
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.AplikasiResto1494.My.Resources.Resources.Save
        Me.btnSimpan.Location = New System.Drawing.Point(505, 144)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(50, 50)
        Me.btnSimpan.TabIndex = 27
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Image = Global.AplikasiResto1494.My.Resources.Resources.Pencil
        Me.btnUbah.Location = New System.Drawing.Point(505, 88)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(50, 50)
        Me.btnUbah.TabIndex = 26
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.AplikasiResto1494.My.Resources.Resources.Add
        Me.btnTambah.Location = New System.Drawing.Point(505, 32)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(50, 50)
        Me.btnTambah.TabIndex = 25
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Level Kasir"
        '
        'cmbLevel
        '
        Me.cmbLevel.FormattingEnabled = True
        Me.cmbLevel.Location = New System.Drawing.Point(152, 196)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Size = New System.Drawing.Size(125, 28)
        Me.cmbLevel.TabIndex = 42
        '
        'FormKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 543)
        Me.Controls.Add(Me.cmbLevel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtIDKasir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.DGKasir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Name = "FormKasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Kasir"
        CType(Me.DGKasir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtIDKasir As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents DGKasir As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCari As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbLevel As ComboBox
End Class
