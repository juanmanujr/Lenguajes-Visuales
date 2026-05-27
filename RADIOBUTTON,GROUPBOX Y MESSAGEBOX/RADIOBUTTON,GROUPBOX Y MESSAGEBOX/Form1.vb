Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim edad, ciudad As String
        If RadioButton1.Checked Then
            edad = "Tienes menos de 18 años"
        ElseIf RadioButton2.Checked Then
            edad = "Tienes entre 18 y 45 años"
        ElseIf RadioButton3.checked Then
            edad = "Tienes entre 45 y 65 años"
        End If

        If RadioButton4.Checked Then
            ciudad = "sos de Piribebuy"
        ElseIf RadioButton5.Checked Then
            ciudad = "sos de Caacupe"
        ElseIf RadioButton6.Checked Then
            ciudad = "sos de Asuncion"
        End If
        MessageBox.Show(edad & " y " & ciudad)

    End Sub
End Class
