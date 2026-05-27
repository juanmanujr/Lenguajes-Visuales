Public Class Form1
    Dim sumador, restador As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sumador = sumador + 1
        Label1.Text = " " & sumador
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sumador = sumador - 1
        Label1.Text = " " & sumador
    End Sub
End Class
