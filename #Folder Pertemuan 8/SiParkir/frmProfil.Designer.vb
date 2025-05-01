<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfil
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
        btnClose = New Button()
        btnSave = New Button()
        lblPassword = New Label()
        lblUsername = New Label()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        lblRetype = New Label()
        txtRetype = New TextBox()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(281, 192)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 11
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(187, 192)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 10
        btnSave.Text = "save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(89, 93)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(57, 15)
        lblPassword.TabIndex = 9
        lblPassword.Text = "Password"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(89, 47)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(60, 15)
        lblUsername.TabIndex = 8
        lblUsername.Text = "Username"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(181, 85)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(173, 23)
        txtPassword.TabIndex = 7
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(181, 41)
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(173, 23)
        txtUsername.TabIndex = 6
        ' 
        ' lblRetype
        ' 
        lblRetype.AutoSize = True
        lblRetype.Location = New Point(89, 139)
        lblRetype.Name = "lblRetype"
        lblRetype.Size = New Size(69, 15)
        lblRetype.TabIndex = 13
        lblRetype.Text = "Retype Pass"
        ' 
        ' txtRetype
        ' 
        txtRetype.Location = New Point(181, 131)
        txtRetype.Name = "txtRetype"
        txtRetype.PasswordChar = "*"c
        txtRetype.Size = New Size(173, 23)
        txtRetype.TabIndex = 12
        ' 
        ' frmProfil
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(447, 236)
        Controls.Add(lblRetype)
        Controls.Add(txtRetype)
        Controls.Add(btnClose)
        Controls.Add(btnSave)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        KeyPreview = True
        Name = "frmProfil"
        StartPosition = FormStartPosition.CenterParent
        Text = "Form Profil"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblRetype As Label
    Friend WithEvents txtRetype As TextBox
End Class
