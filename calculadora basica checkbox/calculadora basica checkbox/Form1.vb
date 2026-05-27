Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resultado As Double
        Dim num1 As Double
        Dim num2 As Double

        If Double.TryParse(txtNum1.Text, num1) AndAlso Double.TryParse(txtNum2.Text, num2) Then
            If chkSuma.Checked Then
                resultado = num1 + num2
                txtResultado.Text = resultado
            ElseIf chkResta.Checked Then
                resultado = num1 - num2
                txtResultado.Text = resultado
            ElseIf chkMulti.Checked Then
                resultado = num1 * num2
                txtResultado.Text = resultado
            ElseIf chkDivi.Checked Then
                If num2 <> 0 Then
                    resultado = num1 / num2
                    txtResultado.Text = resultado
                Else
                    txtResultado.Text = "No esta definida la division por 0"
                End If
            Else
                MessageBox.Show("Seleccione una operacion")
            End If
        Else
                MessageBox.Show("Ingrese numeros validos")
        End If
    End Sub
End Class
