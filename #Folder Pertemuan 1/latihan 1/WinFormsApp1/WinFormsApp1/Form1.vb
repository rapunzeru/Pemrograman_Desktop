Public Class Form1
    Private Sub txtCelcius_TextChanged(sender As Object, e As EventArgs) Handles txtCelcius.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim celcius, fahrenheit, reamur, kelvin As Double
        celcius = Val(txtCelcius.Text)
        fahrenheit = 9 / 5 * (celcius) + 32
        reamur = 4 / 5 * (celcius)
        kelvin = celcius + 273
        MsgBox("Fahrenheit = " & fahrenheit & vbCrLf & "Reamur = " & reamur & vbCrLf & "Kelvin = " & kelvin)
    End Sub
End Class
