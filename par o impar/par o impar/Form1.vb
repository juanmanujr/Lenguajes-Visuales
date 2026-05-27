Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer
        If Integer.TryParse(TextBox1.Text, numero) Then
            If numero Mod 2 = 0 Then
                Label2.Text = "Es par"
            Else
                Label2.Text = "Es impar"
            End If
        Else
            Label2.Text = "Ingrese un numero valido"
        End If
    End Sub


End Class
