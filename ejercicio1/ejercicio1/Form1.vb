Public Class Form1
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim numero As Double

        If Double.TryParse(txtNumero.Text, numero) Then
            If numero > 0 Then
                lblResultado.Text = "Es positivo"
                txtNumero.Clear()
                txtNumero.Focus()
            ElseIf numero < 0 Then
                lblResultado.Text = "Es negativo"
                txtNumero.Clear()
                txtNumero.Focus()
            ElseIf numero = 0 Then
                lblResultado.Text = "Es cero"
                txtNumero.Clear()
                txtNumero.Focus()
            End If
        Else
            MessageBox.Show("Ingrese un numero valido")

        End If



    End Sub
End Class
