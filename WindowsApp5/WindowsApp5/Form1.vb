Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim numero1 As Double
        Dim numero2 As Double
        Dim resultado As Double

        If Double.TryParse(TextBox1.Text, numero1) AndAlso Double.TryParse(TextBox2.Text, numero2) Then

            resultado = numero1 + numero2

            Label1.Text = "Resultado: " & resultado.ToString()

        Else

            MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
End Class
