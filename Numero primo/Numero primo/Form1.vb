Public Class Form1
    Private Sub btnVerificarPrimo_Click(sender As Object, e As EventArgs) Handles btnVerificarPrimo.Click
        Dim numero As Integer
        Dim esPrimo As Boolean = True
        Dim i As Integer
        If Integer.TryParse(txtNumero.Text, numero) Then
            'porque el numero primo son solo los numeros naturales
            'y los numeros naturales son numeros positivos
            ' es decir un numero primo es un numero natural mayor que uno
            If numero <= 1 Then 'empieza if principal
                esPrimo = False
                'verificamos si tiene algun divisor entre 2 y numero -1
                'numero-1: es un numero anterior ingresado por el usuario
                'ej: ingresa 8:
                'va a buscar del 2 al 8 divisores que den resto 0
            Else
                For i = 2 To numero - 1 'empieza for
                    If numero Mod i = 0 Then
                        esPrimo = False
                    End If
                Next 'termina for
            End If
            If esPrimo = True Then
                lblResultado.Text = "Es primo"
            Else
                lblResultado.Text = "No es primo"
            End If
        Else
            lblResultado.Text = "Ingrese un numero valido"
        End If 'termina if principal
    End Sub
End Class
