Public Class Form1
    ' Variable para contar los clics
    Private contador As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Incrementar el contador en cada clic
        contador += 1
        ' Mostrar el contador en el Label
        Label1.Text = "Clics: " & contador.ToString()
    End Sub
End Class
