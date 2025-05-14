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
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShapeIsian = New System.Windows.Forms.Panel()
        Me.ShapeTepi = New System.Windows.Forms.Panel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioElipsIsi = New System.Windows.Forms.RadioButton()
        Me.RadioKotakIsi = New System.Windows.Forms.RadioButton()
        Me.RadioElips = New System.Windows.Forms.RadioButton()
        Me.RadioKotak = New System.Windows.Forms.RadioButton()
        Me.RadioGaris = New System.Windows.Forms.RadioButton()
        Me.RadioBebas = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGbrUlang = New System.Windows.Forms.Button()
        Me.btnBersihkan = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.warna6 = New System.Windows.Forms.Panel()
        Me.warna5 = New System.Windows.Forms.Panel()
        Me.warna4 = New System.Windows.Forms.Panel()
        Me.warna3 = New System.Windows.Forms.Panel()
        Me.warna2 = New System.Windows.Forms.Panel()
        Me.warna1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BukaToolStripMenuItem, Me.SimpanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BukaToolStripMenuItem
        '
        Me.BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        Me.BukaToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.BukaToolStripMenuItem.Text = "Buka"
        '
        'SimpanToolStripMenuItem
        '
        Me.SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        Me.SimpanToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SimpanToolStripMenuItem.Text = "Simpan"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ShapeIsian)
        Me.GroupBox1.Controls.Add(Me.ShapeTepi)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RadioElipsIsi)
        Me.GroupBox1.Controls.Add(Me.RadioKotakIsi)
        Me.GroupBox1.Controls.Add(Me.RadioElips)
        Me.GroupBox1.Controls.Add(Me.RadioKotak)
        Me.GroupBox1.Controls.Add(Me.RadioGaris)
        Me.GroupBox1.Controls.Add(Me.RadioBebas)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 426)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tools"
        '
        'ShapeIsian
        '
        Me.ShapeIsian.BackColor = System.Drawing.Color.White
        Me.ShapeIsian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ShapeIsian.Location = New System.Drawing.Point(74, 355)
        Me.ShapeIsian.Name = "ShapeIsian"
        Me.ShapeIsian.Size = New System.Drawing.Size(40, 39)
        Me.ShapeIsian.TabIndex = 10
        '
        'ShapeTepi
        '
        Me.ShapeTepi.BackColor = System.Drawing.Color.Black
        Me.ShapeTepi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ShapeTepi.Location = New System.Drawing.Point(28, 355)
        Me.ShapeTepi.Name = "ShapeTepi"
        Me.ShapeTepi.Size = New System.Drawing.Size(40, 39)
        Me.ShapeTepi.TabIndex = 9
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(7, 268)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'RadioElipsIsi
        '
        Me.RadioElipsIsi.AutoSize = True
        Me.RadioElipsIsi.Location = New System.Drawing.Point(7, 148)
        Me.RadioElipsIsi.Name = "RadioElipsIsi"
        Me.RadioElipsIsi.Size = New System.Drawing.Size(60, 17)
        Me.RadioElipsIsi.TabIndex = 5
        Me.RadioElipsIsi.Text = "Elips Isi"
        Me.RadioElipsIsi.UseVisualStyleBackColor = True
        '
        'RadioKotakIsi
        '
        Me.RadioKotakIsi.AutoSize = True
        Me.RadioKotakIsi.Location = New System.Drawing.Point(7, 125)
        Me.RadioKotakIsi.Name = "RadioKotakIsi"
        Me.RadioKotakIsi.Size = New System.Drawing.Size(66, 17)
        Me.RadioKotakIsi.TabIndex = 4
        Me.RadioKotakIsi.Text = "Kotak Isi"
        Me.RadioKotakIsi.UseVisualStyleBackColor = True
        '
        'RadioElips
        '
        Me.RadioElips.AutoSize = True
        Me.RadioElips.Location = New System.Drawing.Point(7, 102)
        Me.RadioElips.Name = "RadioElips"
        Me.RadioElips.Size = New System.Drawing.Size(47, 17)
        Me.RadioElips.TabIndex = 3
        Me.RadioElips.Text = "Elips"
        Me.RadioElips.UseVisualStyleBackColor = True
        '
        'RadioKotak
        '
        Me.RadioKotak.AutoSize = True
        Me.RadioKotak.Location = New System.Drawing.Point(7, 79)
        Me.RadioKotak.Name = "RadioKotak"
        Me.RadioKotak.Size = New System.Drawing.Size(53, 17)
        Me.RadioKotak.TabIndex = 2
        Me.RadioKotak.Text = "Kotak"
        Me.RadioKotak.UseVisualStyleBackColor = True
        '
        'RadioGaris
        '
        Me.RadioGaris.AutoSize = True
        Me.RadioGaris.Location = New System.Drawing.Point(7, 56)
        Me.RadioGaris.Name = "RadioGaris"
        Me.RadioGaris.Size = New System.Drawing.Size(49, 17)
        Me.RadioGaris.TabIndex = 1
        Me.RadioGaris.Text = "Garis"
        Me.RadioGaris.UseVisualStyleBackColor = True
        '
        'RadioBebas
        '
        Me.RadioBebas.AutoSize = True
        Me.RadioBebas.Location = New System.Drawing.Point(7, 33)
        Me.RadioBebas.Name = "RadioBebas"
        Me.RadioBebas.Size = New System.Drawing.Size(55, 17)
        Me.RadioBebas.TabIndex = 0
        Me.RadioBebas.Text = "Bebas"
        Me.RadioBebas.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnGbrUlang)
        Me.GroupBox2.Controls.Add(Me.btnBersihkan)
        Me.GroupBox2.Controls.Add(Me.btnUndo)
        Me.GroupBox2.Controls.Add(Me.warna6)
        Me.GroupBox2.Controls.Add(Me.warna5)
        Me.GroupBox2.Controls.Add(Me.warna4)
        Me.GroupBox2.Controls.Add(Me.warna3)
        Me.GroupBox2.Controls.Add(Me.warna2)
        Me.GroupBox2.Controls.Add(Me.warna1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(146, 395)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(654, 55)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Warna"
        '
        'btnGbrUlang
        '
        Me.btnGbrUlang.Location = New System.Drawing.Point(513, 19)
        Me.btnGbrUlang.Name = "btnGbrUlang"
        Me.btnGbrUlang.Size = New System.Drawing.Size(104, 23)
        Me.btnGbrUlang.TabIndex = 4
        Me.btnGbrUlang.Text = "Gambar Ulang"
        Me.btnGbrUlang.UseVisualStyleBackColor = True
        '
        'btnBersihkan
        '
        Me.btnBersihkan.Location = New System.Drawing.Point(354, 20)
        Me.btnBersihkan.Name = "btnBersihkan"
        Me.btnBersihkan.Size = New System.Drawing.Size(122, 23)
        Me.btnBersihkan.TabIndex = 3
        Me.btnBersihkan.Text = "Bersihkan Kanvas"
        Me.btnBersihkan.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(273, 20)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(75, 23)
        Me.btnUndo.TabIndex = 2
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'warna6
        '
        Me.warna6.BackColor = System.Drawing.Color.Black
        Me.warna6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.warna6.Location = New System.Drawing.Point(158, 20)
        Me.warna6.Name = "warna6"
        Me.warna6.Size = New System.Drawing.Size(22, 23)
        Me.warna6.TabIndex = 1
        '
        'warna5
        '
        Me.warna5.BackColor = System.Drawing.Color.White
        Me.warna5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.warna5.Location = New System.Drawing.Point(130, 20)
        Me.warna5.Name = "warna5"
        Me.warna5.Size = New System.Drawing.Size(22, 23)
        Me.warna5.TabIndex = 1
        '
        'warna4
        '
        Me.warna4.BackColor = System.Drawing.Color.Blue
        Me.warna4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.warna4.Location = New System.Drawing.Point(102, 20)
        Me.warna4.Name = "warna4"
        Me.warna4.Size = New System.Drawing.Size(22, 23)
        Me.warna4.TabIndex = 1
        '
        'warna3
        '
        Me.warna3.BackColor = System.Drawing.Color.Green
        Me.warna3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.warna3.Location = New System.Drawing.Point(74, 20)
        Me.warna3.Name = "warna3"
        Me.warna3.Size = New System.Drawing.Size(22, 23)
        Me.warna3.TabIndex = 1
        '
        'warna2
        '
        Me.warna2.BackColor = System.Drawing.Color.Yellow
        Me.warna2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.warna2.Location = New System.Drawing.Point(46, 20)
        Me.warna2.Name = "warna2"
        Me.warna2.Size = New System.Drawing.Size(22, 23)
        Me.warna2.TabIndex = 1
        '
        'warna1
        '
        Me.warna1.BackColor = System.Drawing.Color.Red
        Me.warna1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.warna1.Location = New System.Drawing.Point(18, 20)
        Me.warna1.Name = "warna1"
        Me.warna1.Size = New System.Drawing.Size(22, 23)
        Me.warna1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox3.Location = New System.Drawing.Point(600, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 371)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Objek"
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(3, 16)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(194, 352)
        Me.TextBox1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(146, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(454, 371)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmUtama"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioElipsIsi As RadioButton
    Friend WithEvents RadioKotakIsi As RadioButton
    Friend WithEvents RadioElips As RadioButton
    Friend WithEvents RadioKotak As RadioButton
    Friend WithEvents RadioGaris As RadioButton
    Friend WithEvents RadioBebas As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ShapeIsian As Panel
    Friend WithEvents ShapeTepi As Panel
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents btnUndo As Button
    Friend WithEvents warna6 As Panel
    Friend WithEvents warna5 As Panel
    Friend WithEvents warna4 As Panel
    Friend WithEvents warna3 As Panel
    Friend WithEvents warna2 As Panel
    Friend WithEvents warna1 As Panel
    Friend WithEvents btnGbrUlang As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents TextBox1 As TextBox
End Class
