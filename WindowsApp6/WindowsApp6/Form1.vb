Imports System.Security.Cryptography

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim random As New Random()
        Dim rojo As Integer = random.Next(0, 256)
        Dim verde As Integer = random.Next(0, 256)
        Dim azul As Integer = random.Next(0, 256)

        Me.BackColor = Color.FromArgb(rojo, verde, azul)


    End Sub
End Class
