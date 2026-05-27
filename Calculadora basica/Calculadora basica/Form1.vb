Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Agregar operaciones al ComboBox
        ComboBox1.Items.Add("+")
        ComboBox1.Items.Add("-")
        ComboBox1.Items.Add("*")
        ComboBox1.Items.Add("/")
        ' Seleccionar la primera opción por defecto
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim resultado As Double

        ' Verificar que los valores ingresados sean numéricos
        If Not Double.TryParse(TextBox1.Text, num1) Then
            MessageBox.Show("Ingrese un número válido en el primer campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not Double.TryParse(TextBox2.Text, num2) Then
            MessageBox.Show("Ingrese un número válido en el segundo campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Obtener la operación seleccionada
        Dim operacion As String = ComboBox1.SelectedItem.ToString()

        ' Realizar la operación seleccionada
        Select Case operacion
            Case "+"
                resultado = num1 + num2
            Case "-"
                resultado = num1 - num2
            Case "*"
                resultado = num1 * num2
            Case "/"
                ' Manejar división por cero
                If num2 = 0 Then
                    MessageBox.Show("No se puede dividir por 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                resultado = num1 / num2
        End Select

        ' Mostrar el resultado en el Label
        Label1.Text = "Resultado: " & resultado.ToString()
    End Sub
End Class
