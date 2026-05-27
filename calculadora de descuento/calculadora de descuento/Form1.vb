Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim precio As Double
        Dim descuento As Double
        Dim precioFinal As Double
        If Double.TryParse(txtPrecio.Text, precio) AndAlso Double.TryParse(txtDescuento.Text, descuento) Then
            precioFinal = precio - (precio * descuento / 100)
            lblResultado.Text = "El precio final es: " & precioFinal

        Else
            MessageBox.Show("Ingrese numeros validos")
        End If
    End Sub
End Class
