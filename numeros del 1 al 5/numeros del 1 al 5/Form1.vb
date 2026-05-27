Public Class Form1
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim numero As Integer
        If Integer.TryParse(txtNumero.Text, numero) Then
            Select Case numero

                Case 1
                    lblResultado.Text = "Uno"
                Case 2
                    lblResultado.Text = "Dos"
                Case 3
                    lblResultado.Text = "Tres"
                Case 4
                    lblResultado.Text = "Cuatro"
                Case 5
                    lblResultado.Text = "Cinco"
                Case Else
                    lblResultado.Text = "Ingrese solo numeros del 1 al  5"
            End Select
        Else
            MessageBox.Show("Ingrese solo numeros validos")
        End If
    End Sub
End Class
