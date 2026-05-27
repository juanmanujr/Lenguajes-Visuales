Public Class Form1
    Private Sub btnCalificar_Click(sender As Object, e As EventArgs) Handles btnCalificar.Click
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
                    lblResultado.Text = "Ingrese solo valores del 1 al 5"
            End Select
        Else
            txtNota.Text = "Ingrese solo valores del 1 al 5"
        End If
    End Sub
End Class
