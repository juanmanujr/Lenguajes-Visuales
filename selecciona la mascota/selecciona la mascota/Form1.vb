Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnmostrar.Click
        Dim perro, gato, raton As String
        'Dim mensaje As String = "Has seleccionado el animal: "
        If chkperro.Checked Then
            perro = " perro, "
        End If
        If chkgato.Checked Then
            gato = " gato "
        End If
        If chkraton.Checked Then
            raton = "  raton "
        End If
        lblmostrar.Text = "Has seleccionado el animal: " & perro & gato & raton
    End Sub
End Class
