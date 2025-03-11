<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        MenuStrip1 = New MenuStrip()
        SistemToolStripMenuItem = New ToolStripMenuItem()
        AturProfileToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        LanggananToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem1 = New ToolStripMenuItem()
        TentangToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        Panel3 = New Panel()
        DataGridView1 = New DataGridView()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        MenuStrip1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {SistemToolStripMenuItem, AdminToolStripMenuItem, BantuanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(585, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SistemToolStripMenuItem
        ' 
        SistemToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AturProfileToolStripMenuItem, LogoutToolStripMenuItem})
        SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        SistemToolStripMenuItem.Size = New Size(54, 20)
        SistemToolStripMenuItem.Text = "Sistem"
        ' 
        ' AturProfileToolStripMenuItem
        ' 
        AturProfileToolStripMenuItem.Name = "AturProfileToolStripMenuItem"
        AturProfileToolStripMenuItem.Size = New Size(134, 22)
        AturProfileToolStripMenuItem.Text = "Atur Profile"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(134, 22)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LanggananToolStripMenuItem, LaporanToolStripMenuItem})
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        AdminToolStripMenuItem.Size = New Size(55, 20)
        AdminToolStripMenuItem.Text = "Admin"
        ' 
        ' LanggananToolStripMenuItem
        ' 
        LanggananToolStripMenuItem.Name = "LanggananToolStripMenuItem"
        LanggananToolStripMenuItem.Size = New Size(180, 22)
        LanggananToolStripMenuItem.Text = "Langganan"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(180, 22)
        LaporanToolStripMenuItem.Text = "Laporan"
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
        BantuanToolStripMenuItem1.Size = New Size(118, 22)
        BantuanToolStripMenuItem1.Text = "Bantuan"
        ' 
        ' TentangToolStripMenuItem
        ' 
        TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        TentangToolStripMenuItem.Size = New Size(118, 22)
        TentangToolStripMenuItem.Text = "Tentang"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Location = New Point(10, 27)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(563, 75)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 2
        Label1.Text = "Nomor Plat"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 15)
        Label2.TabIndex = 3
        Label2.Text = "Jenis"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 15)
        Label3.TabIndex = 4
        Label3.Text = "Biaya Parkir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(303, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 15)
        Label4.TabIndex = 5
        Label4.Text = "Kendaraan Sedang Parkir"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveBorder
        Panel2.Location = New Point(84, 215)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 50)
        Panel2.TabIndex = 6
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(84, 115)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(206, 23)
        TextBox1.TabIndex = 7
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(84, 150)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(84, 181)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 9
        Button1.Text = "Masuk"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(175, 180)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 10
        Button2.Text = "Keluar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(10, 286)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 12
        Label5.Text = "Informasi"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(11, 310)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 15)
        Label6.TabIndex = 13
        Label6.Text = "Tanggal"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(150, 310)
        Label7.Name = "Label7"
        Label7.Size = New Size(28, 15)
        Label7.TabIndex = 14
        Label7.Text = "Jam"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(15, 335)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(58, 19)
        RadioButton1.TabIndex = 15
        RadioButton1.TabStop = True
        RadioButton1.Text = "motor"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(79, 335)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(56, 19)
        RadioButton2.TabIndex = 16
        RadioButton2.TabStop = True
        RadioButton2.Text = "mobil"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(141, 335)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(49, 19)
        RadioButton3.TabIndex = 17
        RadioButton3.TabStop = True
        RadioButton3.Text = "taksi"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(DataGridView1)
        Panel3.Location = New Point(303, 139)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(270, 186)
        Panel3.TabIndex = 27
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(270, 186)
        DataGridView1.TabIndex = 0
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(196, 336)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(44, 19)
        RadioButton5.TabIndex = 37
        RadioButton5.TabStop = True
        RadioButton5.Text = "spd"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(246, 336)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(66, 19)
        RadioButton4.TabIndex = 36
        RadioButton4.TabStop = True
        RadioButton4.Text = "bis/truk"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(585, 366)
        Controls.Add(RadioButton5)
        Controls.Add(RadioButton4)
        Controls.Add(Panel3)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox1)
        Controls.Add(Panel2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIParkir - Form Utama"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AturProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LanggananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
End Class
