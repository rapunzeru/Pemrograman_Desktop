<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripProgressBar1 = New ToolStripProgressBar()
        ImageList1 = New ImageList(components)
        ContextMenuStrip1 = New ContextMenuStrip(components)
        OpenToolStripMenuItem = New ToolStripMenuItem()
        OpenFolderToolStripMenuItem = New ToolStripMenuItem()
        CopyPathToolStripMenuItem = New ToolStripMenuItem()
        CopyFolderPathToClipboardToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        btnSearch = New Button()
        txtExtension = New TextBox()
        cbFind = New ComboBox()
        lblFind = New Label()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ExportToolStripMenuItem = New ToolStripMenuItem()
        RefreshToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        SplitContainer1 = New SplitContainer()
        tvDrive = New TreeView()
        Panel2 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblInfo = New Label()
        lvFile = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        StatusStrip1.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripProgressBar1})
        StatusStrip1.Location = New Point(0, 428)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 0
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(683, 17)
        ToolStripStatusLabel1.Spring = True
        ToolStripStatusLabel1.Text = "Ready"
        ToolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ToolStripProgressBar1
        ' 
        ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        ToolStripProgressBar1.Size = New Size(100, 16)
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "drive.bmp")
        ImageList1.Images.SetKeyName(1, "folder.bmp")
        ImageList1.Images.SetKeyName(2, "290138_document_extension_file_format_paper_icon.bmp")
        ImageList1.Images.SetKeyName(3, "9040368_filetype_exe_icon.bmp")
        ImageList1.Images.SetKeyName(4, "8664927_image_photo_icon.ico")
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {OpenToolStripMenuItem, OpenFolderToolStripMenuItem, CopyPathToolStripMenuItem, CopyFolderPathToClipboardToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(235, 92)
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(234, 22)
        OpenToolStripMenuItem.Text = "Open/Execute File"
        ' 
        ' OpenFolderToolStripMenuItem
        ' 
        OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem"
        OpenFolderToolStripMenuItem.Size = New Size(234, 22)
        OpenFolderToolStripMenuItem.Text = "Open and Select File in Folder"
        ' 
        ' CopyPathToolStripMenuItem
        ' 
        CopyPathToolStripMenuItem.Name = "CopyPathToolStripMenuItem"
        CopyPathToolStripMenuItem.Size = New Size(234, 22)
        CopyPathToolStripMenuItem.Text = "Copy Full Path to Clipboard"
        ' 
        ' CopyFolderPathToClipboardToolStripMenuItem
        ' 
        CopyFolderPathToClipboardToolStripMenuItem.Name = "CopyFolderPathToClipboardToolStripMenuItem"
        CopyFolderPathToClipboardToolStripMenuItem.Size = New Size(234, 22)
        CopyFolderPathToClipboardToolStripMenuItem.Text = "Copy Folder Path to Clipboard"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(txtExtension)
        Panel1.Controls.Add(cbFind)
        Panel1.Controls.Add(lblFind)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 64)
        Panel1.TabIndex = 3
        ' 
        ' btnSearch
        ' 
        btnSearch.Dock = DockStyle.Right
        btnSearch.Location = New Point(725, 24)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 40)
        btnSearch.TabIndex = 11
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtExtension
        ' 
        txtExtension.Location = New Point(642, 26)
        txtExtension.Name = "txtExtension"
        txtExtension.Size = New Size(72, 23)
        txtExtension.TabIndex = 10
        txtExtension.Text = "*.*"
        ' 
        ' cbFind
        ' 
        cbFind.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbFind.AutoCompleteSource = AutoCompleteSource.FileSystem
        cbFind.FormattingEnabled = True
        cbFind.Location = New Point(54, 27)
        cbFind.Name = "cbFind"
        cbFind.Size = New Size(580, 23)
        cbFind.TabIndex = 9
        ' 
        ' lblFind
        ' 
        lblFind.AutoSize = True
        lblFind.Location = New Point(14, 31)
        lblFind.Name = "lblFind"
        lblFind.Size = New Size(33, 15)
        lblFind.TabIndex = 8
        lblFind.Text = "Find:"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 7
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExportToolStripMenuItem, RefreshToolStripMenuItem, ToolStripMenuItem1, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' ExportToolStripMenuItem
        ' 
        ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        ExportToolStripMenuItem.Size = New Size(208, 22)
        ExportToolStripMenuItem.Text = "Export File List to Text File"
        ' 
        ' RefreshToolStripMenuItem
        ' 
        RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        RefreshToolStripMenuItem.Size = New Size(208, 22)
        RefreshToolStripMenuItem.Text = "Refresh Folder"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(205, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(208, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem1, ToolStripMenuItem2, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' HelpToolStripMenuItem1
        ' 
        HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        HelpToolStripMenuItem1.Size = New Size(107, 22)
        HelpToolStripMenuItem1.Text = "Help"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(104, 6)
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(107, 22)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 64)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(tvDrive)
        SplitContainer1.Panel1.Controls.Add(Panel2)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(lvFile)
        SplitContainer1.Size = New Size(800, 364)
        SplitContainer1.SplitterDistance = 266
        SplitContainer1.TabIndex = 4
        ' 
        ' tvDrive
        ' 
        tvDrive.Dock = DockStyle.Fill
        tvDrive.ImageIndex = 0
        tvDrive.ImageList = ImageList1
        tvDrive.Location = New Point(0, 0)
        tvDrive.Name = "tvDrive"
        tvDrive.SelectedImageIndex = 0
        tvDrive.Size = New Size(266, 198)
        tvDrive.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlDark
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(lblInfo)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 198)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(266, 166)
        Panel2.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(14, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 1
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInfo.Location = New Point(14, 14)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(121, 15)
        lblInfo.TabIndex = 0
        lblInfo.Text = "Free Fixed Disk Info:"
        ' 
        ' lvFile
        ' 
        lvFile.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8})
        lvFile.ContextMenuStrip = ContextMenuStrip1
        lvFile.Dock = DockStyle.Fill
        lvFile.GridLines = True
        lvFile.Location = New Point(0, 0)
        lvFile.Name = "lvFile"
        lvFile.Size = New Size(530, 364)
        lvFile.SmallImageList = ImageList1
        lvFile.TabIndex = 0
        lvFile.UseCompatibleStateImageBehavior = False
        lvFile.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Name"
        ColumnHeader1.Width = 100
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Extension"
        ColumnHeader2.Width = 80
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "File Size"
        ColumnHeader3.Width = 80
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Last Modified"
        ColumnHeader5.Width = 80
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Last Accessed"
        ColumnHeader6.Width = 90
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Create Date"
        ColumnHeader7.Width = 90
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Full Path"
        ColumnHeader8.Width = 100
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SplitContainer1)
        Controls.Add(Panel1)
        Controls.Add(StatusStrip1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "File Finder"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyPathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyFolderPathToClipboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtExtension As TextBox
    Friend WithEvents cbFind As ComboBox
    Friend WithEvents lblFind As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tvDrive As TreeView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lvFile As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label

End Class
