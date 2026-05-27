Public Class frmProgramaSumar
    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        Dim resultado As Integer
        resultado = CInt(txtNum1.Text) + CInt(txtNum2.Text)
        txtResultado.Text = resultado
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNum1.Text = ""
        txtNum2.Text = ""
        txtResultado.Text = ""
    End Sub
End Class
