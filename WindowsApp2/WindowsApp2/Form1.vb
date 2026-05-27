Public Class Form1
    Private txt_valor2 As Object
    Private txt_valor1 As Object

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Ingrese_valor_1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        Dim valor1, valor2, resultado As Decimal
        valor1 = txt_valor1.Text
        valor2 = txt_valor2.Text
        resultado = valor1 + valor2




    End Sub
End Class
