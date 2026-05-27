Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim numero As Double

        'double. Tryparse para conversion de string a la variable que elijamos, en este caso la variable numero es un double 
        'por eso se usa textnumero ("textNumero  viene a ser el valor del textbox que al ingresarlo es un valor de string y el tryparse
        ' es el que lo vuelve un numero decimal o entero dependiendo de que queramos

        If Double.TryParse(txtNumero.Text, numero) Then
            'aca comparamos que el numero sea mayor a cero para ser positivo
            If numero > 0 Then
                'el lblResultado.Text accede al laberl para imprimir  " positivo " las comillas son para imprimir el string
                lblResultado.Text = "Positivo"

            ElseIf numero < 0 Then
                lblResultado.Text = "Negativo"

            Else
                lblResultado.Text = "Cero"

            End If

        Else
            MessageBox.Show("Ingrese un valor valorido")
        End If


    End Sub
End Class
