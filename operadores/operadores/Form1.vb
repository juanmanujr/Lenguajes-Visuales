Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resultado As Double
        If RadioButton1.Checked Then
            resultado = CInt(TextBox1.Text) + CInt(TextBox2.Text)
        ElseIf RadioButton2.Checked Then
            resultado = CInt(TextBox1.Text) - CInt(TextBox2.Text)
        ElseIf RadioButton3.Checked Then
            resultado = CInt(TextBox1.Text) * CInt(TextBox2.Text)
        ElseIf RadioButton4.Checked Then
            If CInt(TextBox2.Text) <> 0 Then
                resultado = CInt(TextBox1.Text) / CInt(TextBox2.Text)
            Else
                Label3.Text = "No se puede dividir por cero"
                Exit Sub
            End If
        End If
        Label3.Text = "Resultado " & resultado


    End Sub
End Class
