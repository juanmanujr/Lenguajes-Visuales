Public Class frmMostrar
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        PictureBox1.Visible = True
    End Sub

    Private Sub btnOcultar_Click(sender As Object, e As EventArgs) Handles btnOcultar.Click
        PictureBox1.Visible = False
    End Sub
End Class
