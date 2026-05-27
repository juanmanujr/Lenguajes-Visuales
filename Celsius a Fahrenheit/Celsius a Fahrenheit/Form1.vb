Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim celsius As Double
        Dim fahrenheit As Double

        If Double.TryParse(TextBox1.Text, celsius) Then

            fahrenheit = (celsius * 9 / 5) + 32
            Label1.Text = "Fahrenheit: " & fahrenheit.ToString("0.00") & " ºF"
        Else
            MessageBox.Show("Ingrese una temperatura valida en celsius", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
