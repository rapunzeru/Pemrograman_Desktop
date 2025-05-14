﻿Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class frmUtama

    Dim modegambar As String
    Dim warnatepi As Color = Color.Black
    Dim warnaisian As Color = Color.White
    Dim tepi As New System.Drawing.Pen(warnatepi, 3)
    Dim isian As New System.Drawing.SolidBrush(warnaisian)
    Dim titik As Point = Nothing
    Dim dipencet As Boolean = False
    Dim bmp As Bitmap
    Dim riwayatBaris As New Stack(Of Integer)
    Dim jumlahBarisGoresan As Integer = 0

    Private Sub BukaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaToolStripMenuItem.Click

    End Sub

    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub frmUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnBersihkan.PerformClick()
        tepi.EndCap = LineCap.Round
    End Sub

    Private Sub RadioBebas_CheckedChanged(sender As Object, e As EventArgs) Handles RadioBebas.CheckedChanged
        modegambar = "bebas"
    End Sub

    Private Sub RadioGaris_CheckedChanged(sender As Object, e As EventArgs) Handles RadioGaris.CheckedChanged
        modegambar = "garis"
    End Sub

    Private Sub RadioKotak_CheckedChanged(sender As Object, e As EventArgs) Handles RadioKotak.CheckedChanged
        modegambar = "kotak"
    End Sub

    Private Sub RadioElips_CheckedChanged(sender As Object, e As EventArgs) Handles RadioElips.CheckedChanged
        modegambar = "elips"
    End Sub

    Private Sub RadioKotakIsi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioKotakIsi.CheckedChanged
        modegambar = "kotakisi"
    End Sub

    Private Sub RadioElipsIsi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioElipsIsi.CheckedChanged
        modegambar = "elipsisi"
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        tepi.Width = NumericUpDown1.Value
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        tepi.Color = warnatepi
        isian.Color = warnaisian
        titik = e.Location
        dipencet = True
        If modegambar = "bebas" Then
            jumlahBarisGoresan = 0
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Dim jumlahBaris As Integer = 0
        Select Case modegambar
            Case "bebas"
                If dipencet Then
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawLine(tepi, titik, e.Location)
                    End Using
                    PictureBox1.Invalidate()
                    TextBox1.AppendText("o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString & vbCrLf)
                    TextBox1.AppendText("o ukurantepi " & tepi.Width.ToString & vbCrLf) 'tambahan
                    TextBox1.AppendText("o garis " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString & vbCrLf)
                    jumlahBarisGoresan += 3
                    titik = e.Location
                End If
        End Select
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        If PictureBox1.Image Is Nothing Then
            PictureBox1.Image = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        End If

        If modegambar = "bebas" Then
            If jumlahBarisGoresan > 0 Then
                riwayatBaris.Push(jumlahBarisGoresan)
            End If
            jumlahBarisGoresan = 0
            dipencet = False
            Return
        End If

        Select Case modegambar
            Case "garis"
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawLine(tepi, titik, e.Location)
                End Using
            Case "kotak"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawRectangle(tepi, rect)
                End Using
            Case "elips"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawEllipse(tepi, rect)
                End Using
            Case "kotakisi"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillRectangle(isian, rect)
                End Using
            Case "elipsisi"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillEllipse(isian, rect)
                End Using
        End Select
        PictureBox1.Invalidate()
        dipencet = False
        If (titik.X <> e.X And titik.Y <> e.Y) Then
            Dim jumlahBaris As Integer = 0
            TextBox1.AppendText("o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString & vbCrLf)
            jumlahBaris += 1
            TextBox1.AppendText("o " + "warnaisian" + " " + warnaisian.R.ToString + " " + warnaisian.G.ToString + " " + warnaisian.B.ToString & vbCrLf)
            jumlahBaris += 1
            TextBox1.AppendText("o ukurantepi " & tepi.Width.ToString & vbCrLf) 'tambahan
            jumlahBaris += 1
            TextBox1.AppendText("o " + modegambar + " " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString & vbCrLf)
            jumlahBaris += 1
            riwayatBaris.Push(jumlahBaris)
        End If

    End Sub



    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using
        PictureBox1.Image = bmp
    End Sub

    Private Sub btnGbrUlang_Click(sender As Object, e As EventArgs) Handles btnGbrUlang.Click
        btnBersihkan.PerformClick()
        Dim a As Integer = TextBox1.Lines.Count
        For i As Integer = 0 To a
            Dim teksbaris As String = TextBox1.Lines(i)
            Dim pecah() As String
            pecah = teksbaris.Split(" "c)
            On Error Resume Next
            pecah(1) = pecah(1).Trim(" "c)
            Select Case pecah(1)
                Case "ukurantepi"
                    tepi.Width = CSng(pecah(2)) 'tambahan
                Case "warnatepi"
                    warnatepi = Color.FromArgb(CByte(pecah(2)), CByte(pecah(3)), CByte(pecah(4)))
                    tepi.Color = warnatepi
                Case "warnaisian"
                    warnaisian = Color.FromArgb(CByte(pecah(2)), CByte(pecah(3)), CByte(pecah(4)))
                    isian.Color = warnaisian
                Case "garis"
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawLine(tepi, CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)), CInt(pecah(5)))
                    End Using
                Case "kotak"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawRectangle(tepi, rect)
                    End Using
                Case "elips"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawEllipse(tepi, rect)
                    End Using
                Case "kotakisi"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.FillRectangle(isian, rect)
                        'g.DrawRectangle(tepi, rect)
                    End Using
                Case "elipsisi"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.FillEllipse(isian, rect)
                        g.DrawEllipse(tepi, rect)
                    End Using
            End Select
        Next
        PictureBox1.Invalidate()
    End Sub



    Private Sub Warna1_MouseDown(sender As Object, e As MouseEventArgs) Handles warna1.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = warna1.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = warna1.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna2_MouseDown(sender As Object, e As MouseEventArgs) Handles warna2.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = warna2.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = warna2.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna3_MouseDown(sender As Object, e As MouseEventArgs) Handles warna3.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = warna3.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = warna3.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna4_MouseDown(sender As Object, e As MouseEventArgs) Handles warna4.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = warna4.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = warna4.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna5_MouseDown(sender As Object, e As MouseEventArgs) Handles warna5.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = warna5.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = warna5.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna6_MouseDown(sender As Object, e As MouseEventArgs) Handles warna6.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = warna6.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = warna6.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        If riwayatBaris.Count > 0 Then
            Dim jumlahBarisHapus As Integer = riwayatBaris.Pop()
            Dim semuaBaris As List(Of String) = TextBox1.Lines.ToList()

            If semuaBaris.Count >= jumlahBarisHapus Then
                semuaBaris.RemoveRange(semuaBaris.Count - jumlahBarisHapus, jumlahBarisHapus)
            End If

            TextBox1.Lines = semuaBaris.ToArray()
            btnGbrUlang.PerformClick()
        Else
            MessageBox.Show("Tidak ada langkah yang bisa di-undo.", "Undo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class