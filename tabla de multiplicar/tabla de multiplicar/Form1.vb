Public Class Form1
    Private Sub btnMostrarTabla_Click(sender As Object, e As EventArgs) Handles btnMostrarTabla.Click
        Dim numero As Integer
        Dim i As Integer

        If Integer.TryParse(txtNumero.Text, numero) Then
            For i = 1 To 10
                lstTabla.Items.Add(numero & " x " & i & " = " & numero * i)
            Next
        Else
            MessageBox.Show("Ingrese un numero valido")
        End If
    End Sub
End Class
