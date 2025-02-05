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
        lblCelcius = New Label()
        txtCelcius = New TextBox()
        btnConvert = New Button()
        btnKeluar = New Button()
        lblFahrenheit = New Label()
        lblReamur = New Label()
        lblKelvin = New Label()
        SuspendLayout()
        ' 
        ' lblCelcius
        ' 
        lblCelcius.AutoSize = True
        lblCelcius.Location = New Point(60, 74)
        lblCelcius.Name = "lblCelcius"
        lblCelcius.Size = New Size(45, 15)
        lblCelcius.TabIndex = 0
        lblCelcius.Text = "Celcius"
        ' 
        ' txtCelcius
        ' 
        txtCelcius.Location = New Point(133, 74)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(100, 23)
        txtCelcius.TabIndex = 1
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(265, 79)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(75, 23)
        btnConvert.TabIndex = 2
        btnConvert.Text = "convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(378, 83)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(75, 23)
        btnKeluar.TabIndex = 3
        btnKeluar.Text = "keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' lblFahrenheit
        ' 
        lblFahrenheit.AutoSize = True
        lblFahrenheit.Location = New Point(77, 137)
        lblFahrenheit.Name = "lblFahrenheit"
        lblFahrenheit.Size = New Size(63, 15)
        lblFahrenheit.TabIndex = 4
        lblFahrenheit.Text = "Fahrenheit"
        ' 
        ' lblReamur
        ' 
        lblReamur.AutoSize = True
        lblReamur.Location = New Point(292, 142)
        lblReamur.Name = "lblReamur"
        lblReamur.Size = New Size(48, 15)
        lblReamur.TabIndex = 5
        lblReamur.Text = "Reamur"
        ' 
        ' lblKelvin
        ' 
        lblKelvin.AutoSize = True
        lblKelvin.Location = New Point(526, 147)
        lblKelvin.Name = "lblKelvin"
        lblKelvin.Size = New Size(39, 15)
        lblKelvin.TabIndex = 6
        lblKelvin.Text = "Kelvin"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(601, 176)
        Controls.Add(lblKelvin)
        Controls.Add(lblReamur)
        Controls.Add(lblFahrenheit)
        Controls.Add(btnKeluar)
        Controls.Add(btnConvert)
        Controls.Add(txtCelcius)
        Controls.Add(lblCelcius)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCelcius As Label
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents lblFahrenheit As Label
    Friend WithEvents lblReamur As Label
    Friend WithEvents lblKelvin As Label

End Class
