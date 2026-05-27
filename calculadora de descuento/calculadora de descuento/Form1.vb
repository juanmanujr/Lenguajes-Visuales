Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        ' Dim resultado As Double
        ' resultado = CInt(txtPrecio.Text) - (CInt(txtPrecio.Text) * (CInt(txtDescuento.Text) / 100))
        ' lblresultado.Text = "El precio con descuento  es: " & resultado
        Dim precio As Double
        Dim descuento As Double

        If Double.TryParse(txtPrecio.Text, precio) AndAlso Double.TryParse(txtDescuento.Text, descuento) Then
            'entra aca si el usuario ingresa numero
            Dim precioFinal As Double = precio - (precio * (descuento / 100))
            'el tostring es solo para que no aparezcan tantos decimales 
            lblresultado.Text = "Precio con descuento: " & precioFinal.ToString("0.00")
        Else 'entra aca si el usuario no ingresa un numero
            lblresultado.Text = "Ingrese los valores numericos validos"
        End If

    End Sub
End Class
