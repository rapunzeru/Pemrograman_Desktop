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
        FolderBrowserDialog1 = New FolderBrowserDialog()
        Label1 = New Label()
        txtPath = New TextBox()
        btnPath = New Button()
        lblExt = New Label()
        txtExt = New TextBox()
        lblOri = New Label()
        lblPreview = New Label()
        lvOri = New ListView()
        chFileName = New ColumnHeader()
        chExtension = New ColumnHeader()
        chAttribute = New ColumnHeader()
        chAccessed = New ColumnHeader()
        chModified = New ColumnHeader()
        lvPreview = New ListView()
        chFileName2 = New ColumnHeader()
        chExtension2 = New ColumnHeader()
        chAttribute2 = New ColumnHeader()
        chAccessed2 = New ColumnHeader()
        chModifed2 = New ColumnHeader()
        TabControl1 = New TabControl()
        tpFilename = New TabPage()
        cbCaseF = New ComboBox()
        txtWithThisF = New TextBox()
        txtInsertAfterF = New TextBox()
        txtRightCropNCharF = New TextBox()
        txtLeftCropNCharF = New TextBox()
        txtInsertBeforeF = New TextBox()
        txtReplaceThisF = New TextBox()
        txtReplaceWithF = New TextBox()
        lblWithThisF = New Label()
        lblCaseF = New Label()
        rbInsertAfterF = New RadioButton()
        rbRightCropNCharF = New RadioButton()
        rbLeftCropNCharF = New RadioButton()
        rbInsertBeforeF = New RadioButton()
        rbReplaceThisF = New RadioButton()
        rbReplaceWithF = New RadioButton()
        tpExtension = New TabPage()
        cbCaseE = New ComboBox()
        txtWithThisE = New TextBox()
        txtInsertAfterE = New TextBox()
        txtRightCropNCharE = New TextBox()
        txtLeftCropNCharE = New TextBox()
        txtInsertBeforeE = New TextBox()
        txtReplaceThisE = New TextBox()
        txtReplaceWithE = New TextBox()
        lblWithThisE = New Label()
        lblCaseE = New Label()
        rbInsertAfterE = New RadioButton()
        rbRightCropNCharE = New RadioButton()
        rbLeftCropNCharE = New RadioButton()
        rbInsertBeforeE = New RadioButton()
        rbReplaceThisE = New RadioButton()
        rbReplaceWithE = New RadioButton()
        tpAutonumber = New TabPage()
        gbWith = New GroupBox()
        nudIncrementBy = New NumericUpDown()
        nudStartWithNumber = New NumericUpDown()
        lblIncrementBy = New Label()
        lblStartWithNumber = New Label()
        gbPlace = New GroupBox()
        rbBeforeFileName = New RadioButton()
        rbAfterFileName = New RadioButton()
        btnPreview = New Button()
        btnRename = New Button()
        btnUndo = New Button()
        TabControl1.SuspendLayout()
        tpFilename.SuspendLayout()
        tpExtension.SuspendLayout()
        tpAutonumber.SuspendLayout()
        gbWith.SuspendLayout()
        CType(nudIncrementBy, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudStartWithNumber, ComponentModel.ISupportInitialize).BeginInit()
        gbPlace.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 15)
        Label1.TabIndex = 0
        Label1.Text = "path:"
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(52, 21)
        txtPath.Name = "txtPath"
        txtPath.ReadOnly = True
        txtPath.Size = New Size(571, 23)
        txtPath.TabIndex = 1
        ' 
        ' btnPath
        ' 
        btnPath.Location = New Point(633, 21)
        btnPath.Name = "btnPath"
        btnPath.Size = New Size(49, 23)
        btnPath.TabIndex = 2
        btnPath.Text = "..."
        btnPath.UseVisualStyleBackColor = True
        ' 
        ' lblExt
        ' 
        lblExt.AutoSize = True
        lblExt.Location = New Point(690, 25)
        lblExt.Name = "lblExt"
        lblExt.Size = New Size(46, 15)
        lblExt.TabIndex = 3
        lblExt.Text = "File Ext:"
        ' 
        ' txtExt
        ' 
        txtExt.Location = New Point(739, 22)
        txtExt.Name = "txtExt"
        txtExt.Size = New Size(58, 23)
        txtExt.TabIndex = 4
        txtExt.Text = "*.*"
        ' 
        ' lblOri
        ' 
        lblOri.AutoSize = True
        lblOri.Location = New Point(16, 51)
        lblOri.Name = "lblOri"
        lblOri.Size = New Size(70, 15)
        lblOri.TabIndex = 5
        lblOri.Text = "Original File"
        ' 
        ' lblPreview
        ' 
        lblPreview.AutoSize = True
        lblPreview.Location = New Point(399, 51)
        lblPreview.Name = "lblPreview"
        lblPreview.Size = New Size(69, 15)
        lblPreview.TabIndex = 6
        lblPreview.Text = "Preview File"
        ' 
        ' lvOri
        ' 
        lvOri.Columns.AddRange(New ColumnHeader() {chFileName, chExtension, chAttribute, chAccessed, chModified})
        lvOri.GridLines = True
        lvOri.Location = New Point(18, 69)
        lvOri.Name = "lvOri"
        lvOri.Size = New Size(373, 217)
        lvOri.TabIndex = 7
        lvOri.UseCompatibleStateImageBehavior = False
        lvOri.View = View.Details
        ' 
        ' chFileName
        ' 
        chFileName.Text = "File Name"
        chFileName.Width = 100
        ' 
        ' chExtension
        ' 
        chExtension.Text = "Extension"
        chExtension.Width = 50
        ' 
        ' chAttribute
        ' 
        chAttribute.Text = "Attributes"
        chAttribute.Width = 80
        ' 
        ' chAccessed
        ' 
        chAccessed.Text = "Date Accessed"
        chAccessed.Width = 90
        ' 
        ' chModified
        ' 
        chModified.Text = "Date Modified"
        chModified.Width = 90
        ' 
        ' lvPreview
        ' 
        lvPreview.Columns.AddRange(New ColumnHeader() {chFileName2, chExtension2, chAttribute2, chAccessed2, chModifed2})
        lvPreview.GridLines = True
        lvPreview.Location = New Point(399, 69)
        lvPreview.Name = "lvPreview"
        lvPreview.Size = New Size(389, 217)
        lvPreview.TabIndex = 8
        lvPreview.UseCompatibleStateImageBehavior = False
        lvPreview.View = View.Details
        ' 
        ' chFileName2
        ' 
        chFileName2.Text = "File Name"
        chFileName2.Width = 100
        ' 
        ' chExtension2
        ' 
        chExtension2.Text = "Extension"
        chExtension2.Width = 50
        ' 
        ' chAttribute2
        ' 
        chAttribute2.Text = "Attributes"
        chAttribute2.Width = 80
        ' 
        ' chAccessed2
        ' 
        chAccessed2.Text = "Date Accessed"
        chAccessed2.Width = 90
        ' 
        ' chModifed2
        ' 
        chModifed2.Text = "Date Modified"
        chModifed2.Width = 90
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tpFilename)
        TabControl1.Controls.Add(tpExtension)
        TabControl1.Controls.Add(tpAutonumber)
        TabControl1.Location = New Point(20, 292)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(667, 156)
        TabControl1.TabIndex = 9
        ' 
        ' tpFilename
        ' 
        tpFilename.Controls.Add(cbCaseF)
        tpFilename.Controls.Add(txtWithThisF)
        tpFilename.Controls.Add(txtInsertAfterF)
        tpFilename.Controls.Add(txtRightCropNCharF)
        tpFilename.Controls.Add(txtLeftCropNCharF)
        tpFilename.Controls.Add(txtInsertBeforeF)
        tpFilename.Controls.Add(txtReplaceThisF)
        tpFilename.Controls.Add(txtReplaceWithF)
        tpFilename.Controls.Add(lblWithThisF)
        tpFilename.Controls.Add(lblCaseF)
        tpFilename.Controls.Add(rbInsertAfterF)
        tpFilename.Controls.Add(rbRightCropNCharF)
        tpFilename.Controls.Add(rbLeftCropNCharF)
        tpFilename.Controls.Add(rbInsertBeforeF)
        tpFilename.Controls.Add(rbReplaceThisF)
        tpFilename.Controls.Add(rbReplaceWithF)
        tpFilename.Location = New Point(4, 24)
        tpFilename.Name = "tpFilename"
        tpFilename.Padding = New Padding(3)
        tpFilename.Size = New Size(659, 128)
        tpFilename.TabIndex = 0
        tpFilename.Text = "Filename"
        tpFilename.UseVisualStyleBackColor = True
        ' 
        ' cbCaseF
        ' 
        cbCaseF.FormattingEnabled = True
        cbCaseF.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "no change"})
        cbCaseF.Location = New Point(513, 5)
        cbCaseF.Name = "cbCaseF"
        cbCaseF.Size = New Size(140, 23)
        cbCaseF.TabIndex = 15
        ' 
        ' txtWithThisF
        ' 
        txtWithThisF.Location = New Point(514, 31)
        txtWithThisF.Name = "txtWithThisF"
        txtWithThisF.ReadOnly = True
        txtWithThisF.Size = New Size(139, 23)
        txtWithThisF.TabIndex = 14
        ' 
        ' txtInsertAfterF
        ' 
        txtInsertAfterF.Location = New Point(514, 64)
        txtInsertAfterF.Name = "txtInsertAfterF"
        txtInsertAfterF.ReadOnly = True
        txtInsertAfterF.Size = New Size(139, 23)
        txtInsertAfterF.TabIndex = 13
        ' 
        ' txtRightCropNCharF
        ' 
        txtRightCropNCharF.Location = New Point(514, 98)
        txtRightCropNCharF.Name = "txtRightCropNCharF"
        txtRightCropNCharF.ReadOnly = True
        txtRightCropNCharF.Size = New Size(90, 23)
        txtRightCropNCharF.TabIndex = 12
        ' 
        ' txtLeftCropNCharF
        ' 
        txtLeftCropNCharF.Location = New Point(127, 100)
        txtLeftCropNCharF.Name = "txtLeftCropNCharF"
        txtLeftCropNCharF.ReadOnly = True
        txtLeftCropNCharF.Size = New Size(90, 23)
        txtLeftCropNCharF.TabIndex = 11
        ' 
        ' txtInsertBeforeF
        ' 
        txtInsertBeforeF.Location = New Point(127, 65)
        txtInsertBeforeF.Name = "txtInsertBeforeF"
        txtInsertBeforeF.ReadOnly = True
        txtInsertBeforeF.Size = New Size(260, 23)
        txtInsertBeforeF.TabIndex = 10
        ' 
        ' txtReplaceThisF
        ' 
        txtReplaceThisF.Location = New Point(127, 36)
        txtReplaceThisF.Name = "txtReplaceThisF"
        txtReplaceThisF.ReadOnly = True
        txtReplaceThisF.Size = New Size(281, 23)
        txtReplaceThisF.TabIndex = 9
        ' 
        ' txtReplaceWithF
        ' 
        txtReplaceWithF.Location = New Point(127, 7)
        txtReplaceWithF.Name = "txtReplaceWithF"
        txtReplaceWithF.ReadOnly = True
        txtReplaceWithF.Size = New Size(342, 23)
        txtReplaceWithF.TabIndex = 8
        ' 
        ' lblWithThisF
        ' 
        lblWithThisF.AutoSize = True
        lblWithThisF.Location = New Point(414, 38)
        lblWithThisF.Name = "lblWithThisF"
        lblWithThisF.Size = New Size(52, 15)
        lblWithThisF.TabIndex = 7
        lblWithThisF.Text = "with this"
        ' 
        ' lblCaseF
        ' 
        lblCaseF.AutoSize = True
        lblCaseF.Location = New Point(475, 10)
        lblCaseF.Name = "lblCaseF"
        lblCaseF.Size = New Size(35, 15)
        lblCaseF.TabIndex = 6
        lblCaseF.Text = "Case:"
        ' 
        ' rbInsertAfterF
        ' 
        rbInsertAfterF.AutoSize = True
        rbInsertAfterF.Location = New Point(393, 66)
        rbInsertAfterF.Name = "rbInsertAfterF"
        rbInsertAfterF.Size = New Size(86, 19)
        rbInsertAfterF.TabIndex = 5
        rbInsertAfterF.TabStop = True
        rbInsertAfterF.Text = "Insert After:"
        rbInsertAfterF.UseVisualStyleBackColor = True
        ' 
        ' rbRightCropNCharF
        ' 
        rbRightCropNCharF.AutoSize = True
        rbRightCropNCharF.Location = New Point(392, 101)
        rbRightCropNCharF.Name = "rbRightCropNCharF"
        rbRightCropNCharF.Size = New Size(118, 19)
        rbRightCropNCharF.TabIndex = 4
        rbRightCropNCharF.TabStop = True
        rbRightCropNCharF.Text = "Right Crop n char"
        rbRightCropNCharF.UseVisualStyleBackColor = True
        ' 
        ' rbLeftCropNCharF
        ' 
        rbLeftCropNCharF.AutoSize = True
        rbLeftCropNCharF.Location = New Point(11, 101)
        rbLeftCropNCharF.Name = "rbLeftCropNCharF"
        rbLeftCropNCharF.Size = New Size(110, 19)
        rbLeftCropNCharF.TabIndex = 3
        rbLeftCropNCharF.TabStop = True
        rbLeftCropNCharF.Text = "Left Crop n char"
        rbLeftCropNCharF.UseVisualStyleBackColor = True
        ' 
        ' rbInsertBeforeF
        ' 
        rbInsertBeforeF.AutoSize = True
        rbInsertBeforeF.Location = New Point(11, 63)
        rbInsertBeforeF.Name = "rbInsertBeforeF"
        rbInsertBeforeF.Size = New Size(94, 19)
        rbInsertBeforeF.TabIndex = 2
        rbInsertBeforeF.TabStop = True
        rbInsertBeforeF.Text = "Insert Before:"
        rbInsertBeforeF.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceThisF
        ' 
        rbReplaceThisF.AutoSize = True
        rbReplaceThisF.Location = New Point(11, 37)
        rbReplaceThisF.Name = "rbReplaceThisF"
        rbReplaceThisF.Size = New Size(94, 19)
        rbReplaceThisF.TabIndex = 1
        rbReplaceThisF.TabStop = True
        rbReplaceThisF.Text = "Replace This:"
        rbReplaceThisF.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceWithF
        ' 
        rbReplaceWithF.AutoSize = True
        rbReplaceWithF.Location = New Point(11, 8)
        rbReplaceWithF.Name = "rbReplaceWithF"
        rbReplaceWithF.Size = New Size(97, 19)
        rbReplaceWithF.TabIndex = 0
        rbReplaceWithF.TabStop = True
        rbReplaceWithF.Text = "Replace With:"
        rbReplaceWithF.UseVisualStyleBackColor = True
        ' 
        ' tpExtension
        ' 
        tpExtension.Controls.Add(cbCaseE)
        tpExtension.Controls.Add(txtWithThisE)
        tpExtension.Controls.Add(txtInsertAfterE)
        tpExtension.Controls.Add(txtRightCropNCharE)
        tpExtension.Controls.Add(txtLeftCropNCharE)
        tpExtension.Controls.Add(txtInsertBeforeE)
        tpExtension.Controls.Add(txtReplaceThisE)
        tpExtension.Controls.Add(txtReplaceWithE)
        tpExtension.Controls.Add(lblWithThisE)
        tpExtension.Controls.Add(lblCaseE)
        tpExtension.Controls.Add(rbInsertAfterE)
        tpExtension.Controls.Add(rbRightCropNCharE)
        tpExtension.Controls.Add(rbLeftCropNCharE)
        tpExtension.Controls.Add(rbInsertBeforeE)
        tpExtension.Controls.Add(rbReplaceThisE)
        tpExtension.Controls.Add(rbReplaceWithE)
        tpExtension.Location = New Point(4, 24)
        tpExtension.Name = "tpExtension"
        tpExtension.Padding = New Padding(3)
        tpExtension.Size = New Size(659, 128)
        tpExtension.TabIndex = 1
        tpExtension.Text = "Extension"
        tpExtension.UseVisualStyleBackColor = True
        ' 
        ' cbCaseE
        ' 
        cbCaseE.FormattingEnabled = True
        cbCaseE.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "no change"})
        cbCaseE.Location = New Point(510, 5)
        cbCaseE.Name = "cbCaseE"
        cbCaseE.Size = New Size(140, 23)
        cbCaseE.TabIndex = 31
        ' 
        ' txtWithThisE
        ' 
        txtWithThisE.Location = New Point(511, 31)
        txtWithThisE.Name = "txtWithThisE"
        txtWithThisE.ReadOnly = True
        txtWithThisE.Size = New Size(139, 23)
        txtWithThisE.TabIndex = 30
        ' 
        ' txtInsertAfterE
        ' 
        txtInsertAfterE.Location = New Point(511, 64)
        txtInsertAfterE.Name = "txtInsertAfterE"
        txtInsertAfterE.ReadOnly = True
        txtInsertAfterE.Size = New Size(139, 23)
        txtInsertAfterE.TabIndex = 29
        ' 
        ' txtRightCropNCharE
        ' 
        txtRightCropNCharE.Location = New Point(511, 98)
        txtRightCropNCharE.Name = "txtRightCropNCharE"
        txtRightCropNCharE.ReadOnly = True
        txtRightCropNCharE.Size = New Size(90, 23)
        txtRightCropNCharE.TabIndex = 28
        ' 
        ' txtLeftCropNCharE
        ' 
        txtLeftCropNCharE.Location = New Point(124, 100)
        txtLeftCropNCharE.Name = "txtLeftCropNCharE"
        txtLeftCropNCharE.ReadOnly = True
        txtLeftCropNCharE.Size = New Size(90, 23)
        txtLeftCropNCharE.TabIndex = 27
        ' 
        ' txtInsertBeforeE
        ' 
        txtInsertBeforeE.Location = New Point(124, 65)
        txtInsertBeforeE.Name = "txtInsertBeforeE"
        txtInsertBeforeE.ReadOnly = True
        txtInsertBeforeE.Size = New Size(260, 23)
        txtInsertBeforeE.TabIndex = 26
        ' 
        ' txtReplaceThisE
        ' 
        txtReplaceThisE.Location = New Point(124, 36)
        txtReplaceThisE.Name = "txtReplaceThisE"
        txtReplaceThisE.ReadOnly = True
        txtReplaceThisE.Size = New Size(281, 23)
        txtReplaceThisE.TabIndex = 25
        ' 
        ' txtReplaceWithE
        ' 
        txtReplaceWithE.Location = New Point(124, 7)
        txtReplaceWithE.Name = "txtReplaceWithE"
        txtReplaceWithE.ReadOnly = True
        txtReplaceWithE.Size = New Size(342, 23)
        txtReplaceWithE.TabIndex = 24
        ' 
        ' lblWithThisE
        ' 
        lblWithThisE.AutoSize = True
        lblWithThisE.Location = New Point(411, 38)
        lblWithThisE.Name = "lblWithThisE"
        lblWithThisE.Size = New Size(52, 15)
        lblWithThisE.TabIndex = 23
        lblWithThisE.Text = "with this"
        ' 
        ' lblCaseE
        ' 
        lblCaseE.AutoSize = True
        lblCaseE.Location = New Point(472, 10)
        lblCaseE.Name = "lblCaseE"
        lblCaseE.Size = New Size(35, 15)
        lblCaseE.TabIndex = 22
        lblCaseE.Text = "Case:"
        ' 
        ' rbInsertAfterE
        ' 
        rbInsertAfterE.AutoSize = True
        rbInsertAfterE.Location = New Point(390, 66)
        rbInsertAfterE.Name = "rbInsertAfterE"
        rbInsertAfterE.Size = New Size(86, 19)
        rbInsertAfterE.TabIndex = 21
        rbInsertAfterE.Text = "Insert After:"
        rbInsertAfterE.UseVisualStyleBackColor = True
        ' 
        ' rbRightCropNCharE
        ' 
        rbRightCropNCharE.AutoSize = True
        rbRightCropNCharE.Location = New Point(389, 101)
        rbRightCropNCharE.Name = "rbRightCropNCharE"
        rbRightCropNCharE.Size = New Size(118, 19)
        rbRightCropNCharE.TabIndex = 20
        rbRightCropNCharE.Text = "Right Crop n char"
        rbRightCropNCharE.UseVisualStyleBackColor = True
        ' 
        ' rbLeftCropNCharE
        ' 
        rbLeftCropNCharE.AutoSize = True
        rbLeftCropNCharE.Location = New Point(8, 101)
        rbLeftCropNCharE.Name = "rbLeftCropNCharE"
        rbLeftCropNCharE.Size = New Size(110, 19)
        rbLeftCropNCharE.TabIndex = 19
        rbLeftCropNCharE.Text = "Left Crop n char"
        rbLeftCropNCharE.UseVisualStyleBackColor = True
        ' 
        ' rbInsertBeforeE
        ' 
        rbInsertBeforeE.AutoSize = True
        rbInsertBeforeE.Location = New Point(8, 63)
        rbInsertBeforeE.Name = "rbInsertBeforeE"
        rbInsertBeforeE.Size = New Size(94, 19)
        rbInsertBeforeE.TabIndex = 18
        rbInsertBeforeE.Text = "Insert Before:"
        rbInsertBeforeE.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceThisE
        ' 
        rbReplaceThisE.AutoSize = True
        rbReplaceThisE.Location = New Point(8, 37)
        rbReplaceThisE.Name = "rbReplaceThisE"
        rbReplaceThisE.Size = New Size(94, 19)
        rbReplaceThisE.TabIndex = 17
        rbReplaceThisE.Text = "Replace This:"
        rbReplaceThisE.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceWithE
        ' 
        rbReplaceWithE.AutoSize = True
        rbReplaceWithE.Location = New Point(8, 8)
        rbReplaceWithE.Name = "rbReplaceWithE"
        rbReplaceWithE.Size = New Size(97, 19)
        rbReplaceWithE.TabIndex = 16
        rbReplaceWithE.Text = "Replace With:"
        rbReplaceWithE.UseVisualStyleBackColor = True
        ' 
        ' tpAutonumber
        ' 
        tpAutonumber.Controls.Add(gbWith)
        tpAutonumber.Controls.Add(gbPlace)
        tpAutonumber.Location = New Point(4, 24)
        tpAutonumber.Name = "tpAutonumber"
        tpAutonumber.Padding = New Padding(3)
        tpAutonumber.Size = New Size(659, 128)
        tpAutonumber.TabIndex = 2
        tpAutonumber.Text = "Autonumber"
        tpAutonumber.UseVisualStyleBackColor = True
        ' 
        ' gbWith
        ' 
        gbWith.Controls.Add(nudIncrementBy)
        gbWith.Controls.Add(nudStartWithNumber)
        gbWith.Controls.Add(lblIncrementBy)
        gbWith.Controls.Add(lblStartWithNumber)
        gbWith.Location = New Point(244, 0)
        gbWith.Name = "gbWith"
        gbWith.Size = New Size(302, 114)
        gbWith.TabIndex = 1
        gbWith.TabStop = False
        gbWith.Text = "With"
        ' 
        ' nudIncrementBy
        ' 
        nudIncrementBy.Location = New Point(24, 80)
        nudIncrementBy.Name = "nudIncrementBy"
        nudIncrementBy.Size = New Size(176, 23)
        nudIncrementBy.TabIndex = 3
        nudIncrementBy.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' nudStartWithNumber
        ' 
        nudStartWithNumber.Location = New Point(24, 36)
        nudStartWithNumber.Name = "nudStartWithNumber"
        nudStartWithNumber.Size = New Size(176, 23)
        nudStartWithNumber.TabIndex = 2
        nudStartWithNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblIncrementBy
        ' 
        lblIncrementBy.AutoSize = True
        lblIncrementBy.Location = New Point(24, 62)
        lblIncrementBy.Name = "lblIncrementBy"
        lblIncrementBy.Size = New Size(80, 15)
        lblIncrementBy.TabIndex = 1
        lblIncrementBy.Text = "Increment by:"
        ' 
        ' lblStartWithNumber
        ' 
        lblStartWithNumber.AutoSize = True
        lblStartWithNumber.Location = New Point(24, 18)
        lblStartWithNumber.Name = "lblStartWithNumber"
        lblStartWithNumber.Size = New Size(109, 15)
        lblStartWithNumber.TabIndex = 0
        lblStartWithNumber.Text = "Start With Number:"
        ' 
        ' gbPlace
        ' 
        gbPlace.Controls.Add(rbBeforeFileName)
        gbPlace.Controls.Add(rbAfterFileName)
        gbPlace.Location = New Point(28, 0)
        gbPlace.Name = "gbPlace"
        gbPlace.Size = New Size(200, 114)
        gbPlace.TabIndex = 0
        gbPlace.TabStop = False
        gbPlace.Text = "Place"
        ' 
        ' rbBeforeFileName
        ' 
        rbBeforeFileName.AutoSize = True
        rbBeforeFileName.Location = New Point(24, 52)
        rbBeforeFileName.Name = "rbBeforeFileName"
        rbBeforeFileName.Size = New Size(110, 19)
        rbBeforeFileName.TabIndex = 1
        rbBeforeFileName.TabStop = True
        rbBeforeFileName.Text = "Before Filename"
        rbBeforeFileName.UseVisualStyleBackColor = True
        ' 
        ' rbAfterFileName
        ' 
        rbAfterFileName.AutoSize = True
        rbAfterFileName.Location = New Point(24, 25)
        rbAfterFileName.Name = "rbAfterFileName"
        rbAfterFileName.Size = New Size(102, 19)
        rbAfterFileName.TabIndex = 0
        rbAfterFileName.TabStop = True
        rbAfterFileName.Text = "After Filename"
        rbAfterFileName.UseVisualStyleBackColor = True
        ' 
        ' btnPreview
        ' 
        btnPreview.Location = New Point(693, 330)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(75, 23)
        btnPreview.TabIndex = 10
        btnPreview.Text = "Preview"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' btnRename
        ' 
        btnRename.Location = New Point(693, 359)
        btnRename.Name = "btnRename"
        btnRename.Size = New Size(75, 23)
        btnRename.TabIndex = 11
        btnRename.Text = "Rename"
        btnRename.UseVisualStyleBackColor = True
        ' 
        ' btnUndo
        ' 
        btnUndo.Location = New Point(693, 388)
        btnUndo.Name = "btnUndo"
        btnUndo.Size = New Size(75, 23)
        btnUndo.TabIndex = 12
        btnUndo.Text = "Undo"
        btnUndo.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnUndo)
        Controls.Add(btnRename)
        Controls.Add(btnPreview)
        Controls.Add(TabControl1)
        Controls.Add(lvPreview)
        Controls.Add(lvOri)
        Controls.Add(lblPreview)
        Controls.Add(lblOri)
        Controls.Add(txtExt)
        Controls.Add(lblExt)
        Controls.Add(btnPath)
        Controls.Add(txtPath)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mass Renamer"
        TabControl1.ResumeLayout(False)
        tpFilename.ResumeLayout(False)
        tpFilename.PerformLayout()
        tpExtension.ResumeLayout(False)
        tpExtension.PerformLayout()
        tpAutonumber.ResumeLayout(False)
        gbWith.ResumeLayout(False)
        gbWith.PerformLayout()
        CType(nudIncrementBy, ComponentModel.ISupportInitialize).EndInit()
        CType(nudStartWithNumber, ComponentModel.ISupportInitialize).EndInit()
        gbPlace.ResumeLayout(False)
        gbPlace.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnPath As Button
    Friend WithEvents lblExt As Label
    Friend WithEvents txtExt As TextBox
    Friend WithEvents lblOri As Label
    Friend WithEvents lblPreview As Label
    Friend WithEvents lvOri As ListView
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chAttribute As ColumnHeader
    Friend WithEvents chAccessed As ColumnHeader
    Friend WithEvents chModified As ColumnHeader
    Friend WithEvents lvPreview As ListView
    Friend WithEvents chFileName2 As ColumnHeader
    Friend WithEvents chExtension2 As ColumnHeader
    Friend WithEvents chAttribute2 As ColumnHeader
    Friend WithEvents chAccessed2 As ColumnHeader
    Friend WithEvents chModifed2 As ColumnHeader
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpFilename As TabPage
    Friend WithEvents tpExtension As TabPage
    Friend WithEvents tpAutonumber As TabPage
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnRename As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents rbLeftCropNCharF As RadioButton
    Friend WithEvents rbInsertBeforeF As RadioButton
    Friend WithEvents rbReplaceThisF As RadioButton
    Friend WithEvents rbReplaceWithF As RadioButton
    Friend WithEvents rbInsertAfterF As RadioButton
    Friend WithEvents rbRightCropNCharF As RadioButton
    Friend WithEvents lblCaseF As Label
    Friend WithEvents txtReplaceWithF As TextBox
    Friend WithEvents lblWithThisF As Label
    Friend WithEvents txtInsertBeforeF As TextBox
    Friend WithEvents txtReplaceThisF As TextBox
    Friend WithEvents cbCaseF As ComboBox
    Friend WithEvents txtWithThisF As TextBox
    Friend WithEvents txtInsertAfterF As TextBox
    Friend WithEvents txtRightCropNCharF As TextBox
    Friend WithEvents txtLeftCropNCharF As TextBox
    Friend WithEvents cbCaseE As ComboBox
    Friend WithEvents txtWithThisE As TextBox
    Friend WithEvents txtInsertAfterE As TextBox
    Friend WithEvents txtRightCropNCharE As TextBox
    Friend WithEvents txtLeftCropNCharE As TextBox
    Friend WithEvents txtInsertBeforeE As TextBox
    Friend WithEvents txtReplaceThisE As TextBox
    Friend WithEvents txtReplaceWithE As TextBox
    Friend WithEvents lblWithThisE As Label
    Friend WithEvents lblCaseE As Label
    Friend WithEvents rbInsertAfterE As RadioButton
    Friend WithEvents rbRightCropNCharE As RadioButton
    Friend WithEvents rbLeftCropNCharE As RadioButton
    Friend WithEvents rbInsertBeforeE As RadioButton
    Friend WithEvents rbReplaceThisE As RadioButton
    Friend WithEvents rbReplaceWithE As RadioButton
    Friend WithEvents gbWith As GroupBox
    Friend WithEvents gbPlace As GroupBox
    Friend WithEvents rbBeforeFileName As RadioButton
    Friend WithEvents rbAfterFileName As RadioButton
    Friend WithEvents nudIncrementBy As NumericUpDown
    Friend WithEvents nudStartWithNumber As NumericUpDown
    Friend WithEvents lblIncrementBy As Label
    Friend WithEvents lblStartWithNumber As Label

End Class
