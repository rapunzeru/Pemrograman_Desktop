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
        lblSatu = New Label()
        lblDua = New Label()
        lblTiga = New Label()
        lblStatus = New Label()
        Button1 = New Button()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Timer3 = New Timer(components)
        Timer4 = New Timer(components)
        SuspendLayout()
        ' 
        ' lblSatu
        ' 
        lblSatu.AutoSize = True
        lblSatu.BorderStyle = BorderStyle.Fixed3D
        lblSatu.Font = New Font("Segoe UI", 24F)
        lblSatu.Location = New Point(63, 34)
        lblSatu.Name = "lblSatu"
        lblSatu.Size = New Size(43, 47)
        lblSatu.TabIndex = 0
        lblSatu.Text = "A"
        lblSatu.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDua
        ' 
        lblDua.AutoSize = True
        lblDua.BorderStyle = BorderStyle.Fixed3D
        lblDua.Font = New Font("Segoe UI", 24F)
        lblDua.Location = New Point(219, 38)
        lblDua.Name = "lblDua"
        lblDua.Size = New Size(43, 47)
        lblDua.TabIndex = 1
        lblDua.Text = "A"
        lblDua.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTiga
        ' 
        lblTiga.AutoSize = True
        lblTiga.BorderStyle = BorderStyle.Fixed3D
        lblTiga.Font = New Font("Segoe UI", 24F)
        lblTiga.Location = New Point(379, 38)
        lblTiga.Name = "lblTiga"
        lblTiga.Size = New Size(43, 47)
        lblTiga.TabIndex = 2
        lblTiga.Text = "A"
        lblTiga.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(52, 165)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(38, 15)
        lblStatus.TabIndex = 3
        lblStatus.Text = "status"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(364, 160)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "spin!"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 9
        ' 
        ' Timer3
        ' 
        Timer3.Interval = 11
        ' 
        ' Timer4
        ' 
        Timer4.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(466, 206)
        Controls.Add(Button1)
        Controls.Add(lblStatus)
        Controls.Add(lblTiga)
        Controls.Add(lblDua)
        Controls.Add(lblSatu)
        Name = "Form1"
        Text = "jackpot"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSatu As Label
    Friend WithEvents lblDua As Label
    Friend WithEvents lblTiga As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer

End Class
