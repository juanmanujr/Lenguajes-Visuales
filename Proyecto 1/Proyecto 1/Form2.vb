Public Class frmMostrar
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        MessageBox.Show("El texto ingresado es: " & txtHola.Text)
    End Sub
End Class