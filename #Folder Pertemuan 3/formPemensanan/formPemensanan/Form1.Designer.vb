﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(306, 192)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(318, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(669, 300)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(387, 11)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(274, 265)
        Panel3.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(196, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 1
        Label1.Text = "Pemesanan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(9, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 15)
        Label2.TabIndex = 2
        Label2.Text = "tanggal pemesanan"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(126, 38)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(199, 23)
        DateTimePicker1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 15)
        Label3.TabIndex = 4
        Label3.Text = "jumlah kursi"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"2 kursi", "4 kursi", "6 kursi", "8 kursi", "10 kursi"})
        ComboBox1.Location = New Point(127, 80)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(9, 136)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 15)
        Label4.TabIndex = 6
        Label4.Text = "jumlah tamu"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(130, 133)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 7
        TextBox1.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(105, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 15)
        Label5.TabIndex = 8
        Label5.Text = "data diri"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(3, 38)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 15)
        Label6.TabIndex = 9
        Label6.Text = "nama"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(3, 83)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 15)
        Label7.TabIndex = 10
        Label7.Text = "email"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(3, 136)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 15)
        Label8.TabIndex = 11
        Label8.Text = "nomor telpon"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(124, 41)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(124, 85)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(124, 128)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(912, 315)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "pesan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(999, 347)
        Controls.Add(Button1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button

End Class
