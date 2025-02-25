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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        FormatToolStripMenuItem = New ToolStripMenuItem()
        FormatToolStripMenuItem1 = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusReady = New ToolStripStatusLabel()
        ToolStripStatusLine = New ToolStripStatusLabel()
        InsertStatusStrip = New ToolStripStatusLabel()
        CapsStripStatus = New ToolStripStatusLabel()
        NumStripStatus = New ToolStripStatusLabel()
        OpenFileDialog1 = New OpenFileDialog()
        FontDialog1 = New FontDialog()
        PrintDialog1 = New PrintDialog()
        PageSetupDialog1 = New PageSetupDialog()
        SaveFileDialog1 = New SaveFileDialog()
        PrintDocument1 = New Printing.PrintDocument()
        TextBox1 = New TextBox()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, FormatToolStripMenuItem, FormatToolStripMenuItem1, ViewToolStripMenuItem, AboutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' FormatToolStripMenuItem
        ' 
        FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        FormatToolStripMenuItem.Size = New Size(39, 20)
        FormatToolStripMenuItem.Text = "Edit"
        ' 
        ' FormatToolStripMenuItem1
        ' 
        FormatToolStripMenuItem1.Name = "FormatToolStripMenuItem1"
        FormatToolStripMenuItem1.Size = New Size(57, 20)
        FormatToolStripMenuItem1.Text = "Format"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(44, 20)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(52, 20)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusReady, ToolStripStatusLine, InsertStatusStrip, CapsStripStatus, NumStripStatus})
        StatusStrip1.Location = New Point(0, 426)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 24)
        StatusStrip1.TabIndex = 0
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusReady
        ' 
        ToolStripStatusReady.Name = "ToolStripStatusReady"
        ToolStripStatusReady.Size = New Size(42, 19)
        ToolStripStatusReady.Text = "Ready."
        ' 
        ' ToolStripStatusLine
        ' 
        ToolStripStatusLine.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Right
        ToolStripStatusLine.BorderStyle = Border3DStyle.Etched
        ToolStripStatusLine.Name = "ToolStripStatusLine"
        ToolStripStatusLine.Size = New Size(39, 19)
        ToolStripStatusLine.Text = "Line1"
        ' 
        ' InsertStatusStrip
        ' 
        InsertStatusStrip.BorderSides = ToolStripStatusLabelBorderSides.Right
        InsertStatusStrip.BorderStyle = Border3DStyle.Etched
        InsertStatusStrip.Enabled = False
        InsertStatusStrip.Name = "InsertStatusStrip"
        InsertStatusStrip.Size = New Size(29, 19)
        InsertStatusStrip.Text = "INS"
        ' 
        ' CapsStripStatus
        ' 
        CapsStripStatus.BorderSides = ToolStripStatusLabelBorderSides.Right
        CapsStripStatus.BorderStyle = Border3DStyle.Etched
        CapsStripStatus.Enabled = False
        CapsStripStatus.Name = "CapsStripStatus"
        CapsStripStatus.Size = New Size(40, 19)
        CapsStripStatus.Text = "CAPS"
        ' 
        ' NumStripStatus
        ' 
        NumStripStatus.BorderSides = ToolStripStatusLabelBorderSides.Right
        NumStripStatus.BorderStyle = Border3DStyle.Etched
        NumStripStatus.Enabled = False
        NumStripStatus.Name = "NumStripStatus"
        NumStripStatus.Size = New Size(39, 19)
        NumStripStatus.Text = "NUM"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.DefaultExt = "*.txt"
        OpenFileDialog1.FileName = "Untitled"
        OpenFileDialog1.Filter = "Text File|*.txt|All Files|*.*"
        OpenFileDialog1.Title = "Open File Text"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PageSetupDialog1
        ' 
        PageSetupDialog1.EnableMetric = True
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.DefaultExt = "*.txt"
        SaveFileDialog1.FileName = "Untitled.txt"
        SaveFileDialog1.Filter = "Text File|*.txt|All Files|*.*"
        SaveFileDialog1.Title = "Save File Text as"
        ' 
        ' TextBox1
        ' 
        TextBox1.AcceptsReturn = True
        TextBox1.AcceptsTab = True
        TextBox1.AllowDrop = True
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Location = New Point(0, 24)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ScrollBars = ScrollBars.Both
        TextBox1.Size = New Size(800, 402)
        TextBox1.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox1)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        KeyPreview = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "NotepadKu"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLine As ToolStripStatusLabel
    Friend WithEvents InsertStatusStrip As ToolStripStatusLabel
    Friend WithEvents CapsStripStatus As ToolStripStatusLabel
    Friend WithEvents NumStripStatus As ToolStripStatusLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents TextBox1 As TextBox

End Class
