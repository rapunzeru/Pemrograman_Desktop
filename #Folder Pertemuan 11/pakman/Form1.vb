Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Public Class Form1
    'map (peta papan permainan)
    Dim map = {
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
{0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
{0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0},
{0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 0},
{0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0},
{0, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0},
{0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0},
{0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
}

    'kumpulan variabel
    Dim tsz = 40 'tile size (ukuran grid/tilenya)
    Dim pacx = 1 'pakman itu di petak x mana sekarang
    Dim pacy = 1 ' petak y
    Dim enmx = 9 'musuh itu di petak x berapa
    Dim enmy = 7 ' petak y
    Dim goalx = 1 'goal (pintu keluar pakman di petak x brp
    Dim goaly = 7 'goal di petak y berapa
    Dim bmp As Bitmap
    Dim oldpacx = 0
    Dim oldpacy = 0
    Dim wall As Image = Image.FromFile("D:\asetpakman\bata.png")
    Dim way As Image = Image.FromFile("D:\asetpakman\rumput.png")
    Dim pac As Image = Image.FromFile("D:\asetpakman\pakman.png")
    Dim enm1 As Image = Image.FromFile("D:\asetpakman\hantu1.png")
    Dim enm2 As Image = Image.FromFile("D:\asetpakman\hantu2.png")
    Dim enm3 As Image = Image.FromFile("D:\asetpakman\hantu3.png")
    Dim goal As Image = Image.FromFile("D:\asetpakman\omah.jpg")
    Dim pacRight As Image = Image.FromFile("D:\asetpakman\pakman.png")
    Dim pacDown As Image = Image.FromFile("D:\asetpakman\pakman2.png")
    Dim pacLeft As Image = Image.FromFile("D:\asetpakman\pakman3.png")
    Dim pacUp As Image = Image.FromFile("D:\asetpakman\pakman4.png")
    Dim lives As Integer = 3
    Dim enm1x = 11, enm1y = 1
    Dim enm2x = 6, enm2y = 7
    Dim enm3x = 9, enm3y = 7
    Dim enemyMoveCounter As Integer = 0
    Dim enemyMoveDelay As Integer = 2



    Private Sub Redraw()
        Dim g As Graphics = Graphics.FromImage(PictureBox1.Image)
        g.Clear(Color.Black) ' Membersihkan gambar sebelumnya

        Dim rows As Integer = map.GetLength(0)
        Dim cols As Integer = map.GetLength(1)

        ' Gambarkan peta berdasarkan isi map
        For y = 0 To rows - 1
            For x = 0 To cols - 1
                If map(y, x) = 0 Then
                    g.DrawImage(wall, x * tsz, y * tsz, tsz, tsz)
                Else
                    g.DrawImage(way, x * tsz, y * tsz, tsz, tsz)
                End If
            Next
        Next

        g.DrawImage(pac, pacx * tsz, pacy * tsz, tsz, tsz)
        g.DrawImage(enm1, enm1x * tsz, enm1y * tsz, tsz, tsz)
        g.DrawImage(enm2, enm2x * tsz, enm2y * tsz, tsz, tsz)
        g.DrawImage(enm3, enm3x * tsz, enm3y * tsz, tsz, tsz)
        g.DrawImage(goal, goalx * tsz, goaly * tsz, tsz, tsz)

        Dim nyawaBrush As Brush = Brushes.Red
        For i = 0 To lives - 1
            g.FillEllipse(nyawaBrush, i * 30 + 5, PictureBox1.Height - 35, 20, 20)
        Next

        PictureBox1.Refresh()
    End Sub


    Private Sub MoveEnemy(ByRef ex As Integer, ByRef ey As Integer)
        Dim jarakx = Math.Abs(pacx - ex)
        Dim jaraky = Math.Abs(pacy - ey)
        Dim arah As Integer
        If jarakx > jaraky Then
            arah = If(pacx > ex, 1, 3)
        ElseIf jaraky > jarakx Then
            arah = If(pacy > ey, 2, 0)
        Else
            arah = Math.Floor(Rnd() * 4)
        End If

        Select Case arah
            Case 0 : If map(ey - 1, ex) = 1 Then ey -= 1
            Case 1 : If map(ey, ex + 1) = 1 Then ex += 1
            Case 2 : If map(ey + 1, ex) = 1 Then ey += 1
            Case 3 : If map(ey, ex - 1) = 1 Then ex -= 1
        End Select
    End Sub



    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                If map(pacy - 1, pacx) = 1 Then
                    pacy -= 1
                    pac = pacUp
                End If
            Case Keys.Down
                If map(pacy + 1, pacx) = 1 Then
                    pacy += 1
                    pac = pacDown
                End If
            Case Keys.Left
                If map(pacy, pacx - 1) = 1 Then
                    pacx -= 1
                    pac = pacLeft
                End If
            Case Keys.Right
                If map(pacy, pacx + 1) = 1 Then
                    pacx += 1
                    pac = pacRight
                End If
        End Select
        Redraw()
    End Sub



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Width = map.GetLength(1) * tsz
        PictureBox1.Height = map.GetLength(0) * tsz
        Me.Width = PictureBox1.Width + tsz
        Me.Height = PictureBox1.Height + tsz * 2

        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = bmp
        Redraw()
    End Sub

    Private Function CariLangkah(enmx As Integer, enmy As Integer, targetx As Integer, targety As Integer) As Point
        Dim visited(map.GetLength(0) - 1, map.GetLength(1) - 1) As Boolean
        Dim queue As New Queue(Of Point)
        Dim parent As New Dictionary(Of Point, Point)
        Dim start As New Point(enmx, enmy)
        queue.Enqueue(start)
        visited(enmy, enmx) = True

        Dim dirs() As Point = {New Point(0, -1), New Point(1, 0), New Point(0, 1), New Point(-1, 0)}

        While queue.Count > 0
            Dim curr As Point = queue.Dequeue()

            If curr.X = targetx And curr.Y = targety Then
                Dim path As New List(Of Point)
                Dim currentPoint As Point = curr
                While Not currentPoint.Equals(start)
                    path.Add(currentPoint)
                    currentPoint = parent(currentPoint)
                End While
                path.Reverse()
                If path.Count > 0 Then
                    Return path(0)
                End If
                Return start
            End If

            For Each dir As Point In dirs
                Dim nx As Integer = curr.X + dir.X
                Dim ny As Integer = curr.Y + dir.Y
                If nx >= 0 AndAlso ny >= 0 AndAlso ny < map.GetLength(0) AndAlso nx < map.GetLength(1) Then
                    If Not visited(ny, nx) AndAlso map(ny, nx) = 1 Then
                        Dim nextPoint As New Point(nx, ny)
                        queue.Enqueue(nextPoint)
                        visited(ny, nx) = True
                        parent(nextPoint) = curr
                    End If
                End If
            Next
        End While

        Return start
    End Function


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        enemyMoveCounter += 1

        If enemyMoveCounter >= enemyMoveDelay Then
            enemyMoveCounter = 0

            Dim nextStep1 As Point = CariLangkah(enm1x, enm1y, pacx, pacy)
            enm1x = nextStep1.X
            enm1y = nextStep1.Y

            MoveEnemy(enm2x, enm2y)
            MoveEnemy(enm3x, enm3y)
        End If

        Dim jarakx, jaraky As Integer
        Dim arah As Integer
        jarakx = Math.Abs(pacx - enmx)
        jaraky = Math.Abs(pacy - enmy)
        If jarakx > jaraky Then
            If (pacx - enmx > 0) Then
                arah = 1
            Else
                arah = 3
            End If
        End If
        If jarakx < jaraky Then
            If (pacy - enmy > 0) Then
                arah = 2
            Else
                arah = 0
            End If
        End If
        If (oldpacx = pacx) And (oldpacy = pacy) Then
            arah = Math.Floor(Rnd() * 4)
        End If
        Select Case arah
            Case 0
                If map(enmy - 1, enmx) = 1 Then
                    enmy = enmy - 1
                End If
            Case 2
                If map(enmy + 1, enmx) = 1 Then
                    enmy = enmy + 1
                End If
            Case 1
                If map(enmy, enmx + 1) = 1 Then
                    enmx = enmx + 1
                End If
            Case 3
                If map(enmy, enmx - 1) = 1 Then
                    enmx = enmx - 1
                End If
        End Select
        oldpacx = pacx
        oldpacy = pacy
        Redraw()

        If ((pacx = enm1x And pacy = enm1y) Or
    (pacx = enm2x And pacy = enm2y) Or
    (pacx = enm3x And pacy = enm3y)) Then

            lives -= 1
            If lives = 0 Then
                Timer1.Enabled = False
                Redraw()
                MsgBox("Pakman Dies! Game Over.")
            Else
                pacx = 1 : pacy = 1
                enm1x = 11 : enm1y = 1
                enm2x = 6 : enm2y = 7
                enm3x = 9 : enm3y = 7
                MsgBox("Tertangkap! Sisa nyawa: " & lives)
            End If
        End If


        'cek apakah posisi pakman sama dg rumah
        If (pacx = goalx) And (pacy = goaly) Then
            Timer1.Enabled = False
            MsgBox("Pakman safe at Home!")
        End If
    End Sub

    Private Sub DrawLives(g As Graphics)
        For i = 0 To lives - 1
            g.FillEllipse(Brushes.Red, i * 30 + 5, PictureBox1.Height - 35, 20, 20)
        Next
    End Sub
End Class
