Public Class Form1
    Private Sub btnVerificarPrimo_Click(sender As Object, e As EventArgs) Handles btnVerificarPrimo.Click
        Dim numero As Integer
        Dim esPrimo As Boolean = True
        Dim i As Integer
        If Integer.TryParse(txtNumero.Text, numero) Then
            If numero <= 1 Then
                esPrimo = False
            Else
                For i = 2 To numero - 1
                    If numero Mod i = 0 Then
                        esPrimo = False
                    End If
                Next
            End If
            If esPrimo = True Then
                lblResultado.Text = "Es primo"
            Else
                lblResultado.Text = "No es primo"
            End If
        Else
            MessageBox.Show("Ingrese un numero valido")
        End If
    End Sub
End Class
