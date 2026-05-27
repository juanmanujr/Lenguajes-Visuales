Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim suma, resta, multi, divi As Double
        suma = CInt(txtNum1.Text) + CInt(txtNum2.Text)
        txtSuma.Text = suma

        resta = CInt(txtNum1.Text) - CInt(txtNum2.Text)
        txtResta.Text = resta

        If CInt(txtNum2.Text) <> 0 Then
            divi = CInt(txtNum1.Text) / CInt(txtNum2.Text)
            txtDivi.Text = divi
        Else
            txtDivi.Text = "No se admite la division por 0"
        End If

        multi = CInt(txtNum1.Text) * CInt(txtNum2.Text)
        txtMulti.Text = multi

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtNum1.Text = ""
        txtNum2.Text = ""
        txtSuma.Text = ""
        txtResta.Text = ""
        txtMulti.Text = ""
        txtDivi.Text = ""

    End Sub
End Class
