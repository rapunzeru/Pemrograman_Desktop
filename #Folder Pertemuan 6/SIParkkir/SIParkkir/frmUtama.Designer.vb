<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtama
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
        components = New ComponentModel.Container()
        lblTgl = New Label()
        lblInfoUser = New Label()
        Panel3 = New Panel()
        DataGridView1 = New DataGridView()
        ColNoPlat = New DataGridViewTextBoxColumn()
        ColMasuk = New DataGridViewTextBoxColumn()
        ColKeluar = New DataGridViewTextBoxColumn()
        ColHarga = New DataGridViewTextBoxColumn()
        Coljenis = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        DeleteToolStripMenuItem = New ToolStripMenuItem()
        txtNoPlat = New TextBox()
        pnlHarga = New Panel()
        lblHarga = New Label()
        Label4 = New Label()
        Label3 = New Label()
        lblInputPlat = New Label()
        pnlPlat = New Panel()
        lblPlat = New Label()
        MenuStrip1 = New MenuStrip()
        SistemToolStripMenuItem = New ToolStripMenuItem()
        ProfilToolStripMenuItem1 = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        DaftarKendaraanToolStripMenuItem = New ToolStripMenuItem()
        LaporanPendapatanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem1 = New ToolStripMenuItem()
        TentangToolStripMenuItem = New ToolStripMenuItem()
        lblJenis = New Label()
        lblTekan = New Label()
        lblJmlKendaraan = New Label()
        lblInfoJenis = New Label()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        ContextMenuStrip1.SuspendLayout()
        pnlHarga.SuspendLayout()
        pnlPlat.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.Location = New Point(10, 312)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(52, 15)
        lblTgl.TabIndex = 28
        lblTgl.Text = "Tanggal:"
        ' 
        ' lblInfoUser
        ' 
        lblInfoUser.AutoSize = True
        lblInfoUser.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInfoUser.Location = New Point(9, 288)
        lblInfoUser.Name = "lblInfoUser"
        lblInfoUser.Size = New Size(60, 15)
        lblInfoUser.TabIndex = 27
        lblInfoUser.Text = "Informasi"
        ' 
        ' Panel3
        ' 
        Panel3.AutoScroll = True
        Panel3.Controls.Add(DataGridView1)
        Panel3.Location = New Point(302, 141)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(270, 186)
        Panel3.TabIndex = 26
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColNoPlat, ColMasuk, ColKeluar, ColHarga, Coljenis, Column1})
        DataGridView1.ContextMenuStrip = ContextMenuStrip1
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(270, 186)
        DataGridView1.TabIndex = 0
        ' 
        ' ColNoPlat
        ' 
        ColNoPlat.HeaderText = "No Plat"
        ColNoPlat.Name = "ColNoPlat"
        ' 
        ' ColMasuk
        ' 
        ColMasuk.HeaderText = "Masuk"
        ColMasuk.Name = "ColMasuk"
        ' 
        ' ColKeluar
        ' 
        ColKeluar.HeaderText = "Keluar"
        ColKeluar.Name = "ColKeluar"
        ' 
        ' ColHarga
        ' 
        ColHarga.HeaderText = "Harga"
        ColHarga.Name = "ColHarga"
        ' 
        ' Coljenis
        ' 
        Coljenis.HeaderText = "Jenis"
        Coljenis.Name = "Coljenis"
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "id"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Visible = False
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {DeleteToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(108, 26)
        ' 
        ' DeleteToolStripMenuItem
        ' 
        DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        DeleteToolStripMenuItem.Size = New Size(107, 22)
        DeleteToolStripMenuItem.Text = "Delete"
        ' 
        ' txtNoPlat
        ' 
        txtNoPlat.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtNoPlat.Location = New Point(83, 117)
        txtNoPlat.Name = "txtNoPlat"
        txtNoPlat.Size = New Size(111, 29)
        txtNoPlat.TabIndex = 25
        ' 
        ' pnlHarga
        ' 
        pnlHarga.BackColor = Color.Transparent
        pnlHarga.BorderStyle = BorderStyle.Fixed3D
        pnlHarga.Controls.Add(lblHarga)
        pnlHarga.Location = New Point(83, 217)
        pnlHarga.Name = "pnlHarga"
        pnlHarga.Size = New Size(200, 50)
        pnlHarga.TabIndex = 24
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHarga.Location = New Point(15, 3)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(70, 40)
        lblHarga.TabIndex = 0
        lblHarga.Text = "Rp. "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(302, 120)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 15)
        Label4.TabIndex = 23
        Label4.Text = "Kendaraan Sedang Parkir"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 217)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 15)
        Label3.TabIndex = 22
        Label3.Text = "Biaya Parkir"
        ' 
        ' lblInputPlat
        ' 
        lblInputPlat.AutoSize = True
        lblInputPlat.Location = New Point(9, 120)
        lblInputPlat.Name = "lblInputPlat"
        lblInputPlat.Size = New Size(68, 15)
        lblInputPlat.TabIndex = 21
        lblInputPlat.Text = "Nomor Plat"
        ' 
        ' pnlPlat
        ' 
        pnlPlat.BackColor = Color.Transparent
        pnlPlat.BorderStyle = BorderStyle.Fixed3D
        pnlPlat.Controls.Add(lblPlat)
        pnlPlat.Dock = DockStyle.Top
        pnlPlat.Location = New Point(0, 24)
        pnlPlat.Name = "pnlPlat"
        pnlPlat.Size = New Size(585, 75)
        pnlPlat.TabIndex = 20
        ' 
        ' lblPlat
        ' 
        lblPlat.AutoSize = True
        lblPlat.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlat.Location = New Point(108, -8)
        lblPlat.Name = "lblPlat"
        lblPlat.Size = New Size(351, 86)
        lblPlat.TabIndex = 0
        lblPlat.Text = "R 6872 ZH"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {SistemToolStripMenuItem, AdminToolStripMenuItem, BantuanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(585, 24)
        MenuStrip1.TabIndex = 19
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SistemToolStripMenuItem
        ' 
        SistemToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProfilToolStripMenuItem1, LogoutToolStripMenuItem})
        SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        SistemToolStripMenuItem.Size = New Size(54, 20)
        SistemToolStripMenuItem.Text = "Sistem"
        ' 
        ' ProfilToolStripMenuItem1
        ' 
        ProfilToolStripMenuItem1.Name = "ProfilToolStripMenuItem1"
        ProfilToolStripMenuItem1.Size = New Size(180, 22)
        ProfilToolStripMenuItem1.Text = "Atur Profile"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(180, 22)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DaftarKendaraanToolStripMenuItem, LaporanPendapatanToolStripMenuItem})
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        AdminToolStripMenuItem.Size = New Size(55, 20)
        AdminToolStripMenuItem.Text = "Admin"
        ' 
        ' DaftarKendaraanToolStripMenuItem
        ' 
        DaftarKendaraanToolStripMenuItem.Name = "DaftarKendaraanToolStripMenuItem"
        DaftarKendaraanToolStripMenuItem.Size = New Size(180, 22)
        DaftarKendaraanToolStripMenuItem.Text = "Langganan"
        ' 
        ' LaporanPendapatanToolStripMenuItem
        ' 
        LaporanPendapatanToolStripMenuItem.Name = "LaporanPendapatanToolStripMenuItem"
        LaporanPendapatanToolStripMenuItem.Size = New Size(180, 22)
        LaporanPendapatanToolStripMenuItem.Text = "Laporan"
        ' 
        ' BantuanToolStripMenuItem
        ' 
        BantuanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BantuanToolStripMenuItem1, TentangToolStripMenuItem})
        BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        BantuanToolStripMenuItem.Size = New Size(63, 20)
        BantuanToolStripMenuItem.Text = "Bantuan"
        ' 
        ' BantuanToolStripMenuItem1
        ' 
        BantuanToolStripMenuItem1.Name = "BantuanToolStripMenuItem1"
        BantuanToolStripMenuItem1.Size = New Size(180, 22)
        BantuanToolStripMenuItem1.Text = "Bantuan"
        ' 
        ' TentangToolStripMenuItem
        ' 
        TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        TentangToolStripMenuItem.Size = New Size(180, 22)
        TentangToolStripMenuItem.Text = "Tentang"
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(9, 151)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(216, 30)
        lblJenis.TabIndex = 34
        lblJenis.Text = "Tekan F1 - Motor, F2 - Mobil, F3 - taksi, " & vbCrLf & "F4 - Sepeda, F5 - Bis/Truk"
        ' 
        ' lblTekan
        ' 
        lblTekan.AutoSize = True
        lblTekan.Location = New Point(10, 190)
        lblTekan.Name = "lblTekan"
        lblTekan.Size = New Size(184, 15)
        lblTekan.TabIndex = 36
        lblTekan.Text = "Tekan Enter untuk Masuk / Keluar"
        ' 
        ' lblJmlKendaraan
        ' 
        lblJmlKendaraan.AutoSize = True
        lblJmlKendaraan.Location = New Point(12, 338)
        lblJmlKendaraan.Name = "lblJmlKendaraan"
        lblJmlKendaraan.Size = New Size(148, 15)
        lblJmlKendaraan.TabIndex = 38
        lblJmlKendaraan.Text = "0 Motor, 0 Mobil, 0 Taksi, 0"
        ' 
        ' lblInfoJenis
        ' 
        lblInfoJenis.AutoSize = True
        lblInfoJenis.Location = New Point(205, 124)
        lblInfoJenis.Name = "lblInfoJenis"
        lblInfoJenis.Size = New Size(0, 15)
        lblInfoJenis.TabIndex = 39
        ' 
        ' frmUtama
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(585, 366)
        Controls.Add(lblInfoJenis)
        Controls.Add(lblJmlKendaraan)
        Controls.Add(lblTekan)
        Controls.Add(lblJenis)
        Controls.Add(lblTgl)
        Controls.Add(lblInfoUser)
        Controls.Add(Panel3)
        Controls.Add(txtNoPlat)
        Controls.Add(pnlHarga)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(lblInputPlat)
        Controls.Add(pnlPlat)
        Controls.Add(MenuStrip1)
        KeyPreview = True
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "frmUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Parkir System v.1.0"
        Panel3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ContextMenuStrip1.ResumeLayout(False)
        pnlHarga.ResumeLayout(False)
        pnlHarga.PerformLayout()
        pnlPlat.ResumeLayout(False)
        pnlPlat.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblTgl As Label
    Friend WithEvents lblInfoUser As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents pnlHarga As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblInputPlat As Label
    Friend WithEvents pnlPlat As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfilToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarKendaraanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPendapatanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblTekan As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblPlat As Label
    Friend WithEvents lblJmlKendaraan As Label
    Friend WithEvents lblInfoJenis As Label
    Friend WithEvents ColNoPlat As DataGridViewTextBoxColumn
    Friend WithEvents ColMasuk As DataGridViewTextBoxColumn
    Friend WithEvents ColKeluar As DataGridViewTextBoxColumn
    Friend WithEvents ColHarga As DataGridViewTextBoxColumn
    Friend WithEvents Coljenis As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
