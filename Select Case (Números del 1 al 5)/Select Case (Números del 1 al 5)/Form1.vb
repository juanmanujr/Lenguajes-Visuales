Public Class Form1
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click

        Dim numero As Double
        'el tryparse se usa siempre con el if porque devuelve solo un valor de falso o verdadero, es un booleano
        If Double.TryParse(txtNumero.Text, numero) Then

            If (numero >= 1 And numero <= 5) Then

                Select Case numero

                    Case 1
                        txtNumero.Text = "Uno"

                    Case 2
                        txtNumero.Text = "Dos"

                    Case 3
                        txtNumero.Text = "Tres"

                    Case 4

                        txtNumero.Text = "Cuatro"
                    Case 5

                        txtNumero.Text = "Cinco"

                End Select

            Else

                MessageBox.Show("Solo se permiten numeros del 1 al 5")

            End If

        End If







    End Sub
End Class
