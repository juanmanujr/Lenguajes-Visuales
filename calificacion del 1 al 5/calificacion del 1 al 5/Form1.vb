Public Class Form1
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim calificacion As Integer
        If Integer.TryParse(txtNota.Text, calificacion) Then
            Select Case calificacion
                Case 1
                    lblResultado.Text = "Reprobado"
                Case 2
                    lblResultado.Text = "Aprobado"
                Case 3
                    lblResultado.Text = "Bueno"
                Case 4
                    lblResultado.Text = "Muy bueno"
                Case 5
                    lblResultado.Text = "Excelente"
                Case Else
                    lblResultado.Text = "Ingrese solo numeros numeros del 1 al 5"
            End Select
        Else
            MessageBox.Show("Ingrese un numero valido")
        End If
    End Sub
End Class
