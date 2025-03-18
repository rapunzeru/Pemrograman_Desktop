<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLangganan
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
        lblNama = New Label()
        lblNoPlat = New Label()
        lblBiaya = New Label()
        Label4 = New Label()
        txtNama = New TextBox()
        txtNoPlat = New TextBox()
        txtBiaya = New TextBox()
        lblId = New Label()
        lblJenis = New Label()
        cmbJenis = New ComboBox()
        Label7 = New Label()
        Panel1 = New Panel()
        DataGridView1 = New DataGridView()
        btnTambah = New Button()
        btnEdit = New Button()
        btnHapus = New Button()
        btnCancel = New Button()
        DateTimePicker1 = New DateTimePicker()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(12, 28)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(98, 15)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama Pelanggan"
        ' 
        ' lblNoPlat
        ' 
        lblNoPlat.AutoSize = True
        lblNoPlat.Location = New Point(12, 58)
        lblNoPlat.Name = "lblNoPlat"
        lblNoPlat.Size = New Size(68, 15)
        lblNoPlat.TabIndex = 1
        lblNoPlat.Text = "Nomor Plat"
        ' 
        ' lblBiaya
        ' 
        lblBiaya.AutoSize = True
        lblBiaya.Location = New Point(12, 86)
        lblBiaya.Name = "lblBiaya"
        lblBiaya.Size = New Size(30, 15)
        lblBiaya.TabIndex = 2
        lblBiaya.Text = "Tarif"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 115)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 15)
        Label4.TabIndex = 3
        Label4.Text = "Berlaku Hingga"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(119, 25)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(213, 23)
        txtNama.TabIndex = 4
        ' 
        ' txtNoPlat
        ' 
        txtNoPlat.Location = New Point(119, 54)
        txtNoPlat.Name = "txtNoPlat"
        txtNoPlat.Size = New Size(149, 23)
        txtNoPlat.TabIndex = 5
        ' 
        ' txtBiaya
        ' 
        txtBiaya.Location = New Point(119, 83)
        txtBiaya.Name = "txtBiaya"
        txtBiaya.Size = New Size(149, 23)
        txtBiaya.TabIndex = 6
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Location = New Point(338, 30)
        lblId.Name = "lblId"
        lblId.Size = New Size(17, 15)
        lblId.TabIndex = 8
        lblId.Text = "Id"
        lblId.Visible = False
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(299, 58)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(32, 15)
        lblJenis.TabIndex = 9
        lblJenis.Text = "Jenis"
        ' 
        ' cmbJenis
        ' 
        cmbJenis.FormattingEnabled = True
        cmbJenis.Items.AddRange(New Object() {"Motor", "Mobil", "Taxi/Umum", "Truk", "Sepeda"})
        cmbJenis.Location = New Point(358, 54)
        cmbJenis.Name = "cmbJenis"
        cmbJenis.Size = New Size(121, 23)
        cmbJenis.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 159)
        Label7.Name = "Label7"
        Label7.Size = New Size(175, 15)
        Label7.TabIndex = 11
        Label7.Text = "Kendaraan Terdaftar Langganan"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(18, 184)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(541, 145)
        Panel1.TabIndex = 12
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(541, 145)
        DataGridView1.TabIndex = 0
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(322, 112)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 13
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(404, 112)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 14
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(485, 111)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 15
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(484, 337)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 16
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(116, 115)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(152, 23)
        DateTimePicker1.TabIndex = 17
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Id"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "No Plat"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Nama Pemilik"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Biaya"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Jenis"
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Expired"
        Column6.Name = "Column6"
        ' 
        ' frmLangganan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(585, 366)
        Controls.Add(DateTimePicker1)
        Controls.Add(btnCancel)
        Controls.Add(btnHapus)
        Controls.Add(btnEdit)
        Controls.Add(btnTambah)
        Controls.Add(Panel1)
        Controls.Add(Label7)
        Controls.Add(cmbJenis)
        Controls.Add(lblJenis)
        Controls.Add(lblId)
        Controls.Add(txtBiaya)
        Controls.Add(txtNoPlat)
        Controls.Add(txtNama)
        Controls.Add(Label4)
        Controls.Add(lblBiaya)
        Controls.Add(lblNoPlat)
        Controls.Add(lblNama)
        KeyPreview = True
        Name = "frmLangganan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Kendaraan Langganan"
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents lblNoPlat As Label
    Friend WithEvents lblBiaya As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents txtBiaya As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
