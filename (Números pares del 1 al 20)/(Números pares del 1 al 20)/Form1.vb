Public Class Form1
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim contador As Integer = 0

        For contador = 0 To 20 Step 2

            'añade itemns al listbox
            lstPares.Items.Add(contador)

        Next


    End Sub
End Class
