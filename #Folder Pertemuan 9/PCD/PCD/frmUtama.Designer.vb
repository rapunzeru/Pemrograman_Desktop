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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistogramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrayscaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerahkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GelapkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKontrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KurangiKontrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TampilkanHistogramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EffectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TajamkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaburkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RotateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlipHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlipVerticallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HighPassFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HistogramToolStripMenuItem, Me.EffectsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BukaToolStripMenuItem, Me.SimpanToolStripMenuItem, Me.InformationToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BukaToolStripMenuItem
        '
        Me.BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        Me.BukaToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.BukaToolStripMenuItem.Text = "Buka"
        '
        'SimpanToolStripMenuItem
        '
        Me.SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        Me.SimpanToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SimpanToolStripMenuItem.Text = "Simpan"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.InformationToolStripMenuItem.Text = "Properti"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'HistogramToolStripMenuItem
        '
        Me.HistogramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GrayscaleToolStripMenuItem, Me.CerahkanToolStripMenuItem, Me.GelapkanToolStripMenuItem, Me.TambahKontrasToolStripMenuItem, Me.KurangiKontrasToolStripMenuItem, Me.ResetToolStripMenuItem, Me.TampilkanHistogramToolStripMenuItem})
        Me.HistogramToolStripMenuItem.Name = "HistogramToolStripMenuItem"
        Me.HistogramToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.HistogramToolStripMenuItem.Text = "Histogram"
        '
        'GrayscaleToolStripMenuItem
        '
        Me.GrayscaleToolStripMenuItem.Name = "GrayscaleToolStripMenuItem"
        Me.GrayscaleToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.GrayscaleToolStripMenuItem.Text = "Greyscale"
        '
        'CerahkanToolStripMenuItem
        '
        Me.CerahkanToolStripMenuItem.Name = "CerahkanToolStripMenuItem"
        Me.CerahkanToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CerahkanToolStripMenuItem.Text = "Cerahkan"
        '
        'GelapkanToolStripMenuItem
        '
        Me.GelapkanToolStripMenuItem.Name = "GelapkanToolStripMenuItem"
        Me.GelapkanToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.GelapkanToolStripMenuItem.Text = "Gelapkan"
        '
        'TambahKontrasToolStripMenuItem
        '
        Me.TambahKontrasToolStripMenuItem.Name = "TambahKontrasToolStripMenuItem"
        Me.TambahKontrasToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.TambahKontrasToolStripMenuItem.Text = "Tambah Kontras"
        '
        'KurangiKontrasToolStripMenuItem
        '
        Me.KurangiKontrasToolStripMenuItem.Name = "KurangiKontrasToolStripMenuItem"
        Me.KurangiKontrasToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.KurangiKontrasToolStripMenuItem.Text = "Kurangi Kontras"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'TampilkanHistogramToolStripMenuItem
        '
        Me.TampilkanHistogramToolStripMenuItem.Name = "TampilkanHistogramToolStripMenuItem"
        Me.TampilkanHistogramToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.TampilkanHistogramToolStripMenuItem.Text = "Tampilkan Histogram"
        '
        'EffectsToolStripMenuItem
        '
        Me.EffectsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TajamkanToolStripMenuItem, Me.KaburkanToolStripMenuItem, Me.RotateToolStripMenuItem, Me.FlipHorizontalToolStripMenuItem, Me.FlipVerticallyToolStripMenuItem, Me.HighPassFilterToolStripMenuItem})
        Me.EffectsToolStripMenuItem.Name = "EffectsToolStripMenuItem"
        Me.EffectsToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.EffectsToolStripMenuItem.Text = "Effects"
        '
        'TajamkanToolStripMenuItem
        '
        Me.TajamkanToolStripMenuItem.Name = "TajamkanToolStripMenuItem"
        Me.TajamkanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TajamkanToolStripMenuItem.Text = "Tajamkan"
        '
        'KaburkanToolStripMenuItem
        '
        Me.KaburkanToolStripMenuItem.Name = "KaburkanToolStripMenuItem"
        Me.KaburkanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.KaburkanToolStripMenuItem.Text = "Kaburkan"
        '
        'RotateToolStripMenuItem
        '
        Me.RotateToolStripMenuItem.Name = "RotateToolStripMenuItem"
        Me.RotateToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RotateToolStripMenuItem.Text = "Putar 90 derajat"
        '
        'FlipHorizontalToolStripMenuItem
        '
        Me.FlipHorizontalToolStripMenuItem.Name = "FlipHorizontalToolStripMenuItem"
        Me.FlipHorizontalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FlipHorizontalToolStripMenuItem.Text = "Flip Horizontal"
        '
        'FlipVerticallyToolStripMenuItem
        '
        Me.FlipVerticallyToolStripMenuItem.Name = "FlipVerticallyToolStripMenuItem"
        Me.FlipVerticallyToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FlipVerticallyToolStripMenuItem.Text = "Flip Vertikal"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 426)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'HighPassFilterToolStripMenuItem
        '
        Me.HighPassFilterToolStripMenuItem.Name = "HighPassFilterToolStripMenuItem"
        Me.HighPassFilterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HighPassFilterToolStripMenuItem.Text = "High Pass Filter"
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmUtama"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistogramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrayscaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerahkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GelapkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKontrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KurangiKontrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EffectsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TampilkanHistogramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TajamkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KaburkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RotateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipVerticallyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HighPassFilterToolStripMenuItem As ToolStripMenuItem
End Class
