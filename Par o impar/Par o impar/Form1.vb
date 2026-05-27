Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer


        If Integer.TryParse(TextBox1.Text, numero) Then

            If numero Mod 2 = 0 Then
                Label1.Text = "El número " & numero & " es PAR."
            Else
                Label1.Text = "El número " & numero & " es IMPAR."
            End If

        Else
            MessageBox.Show("Ingrese un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
