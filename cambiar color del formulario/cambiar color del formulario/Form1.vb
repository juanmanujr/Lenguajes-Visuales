Public Class Form1
    Private colorActual As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case colorActual
            Case 0
                Me.BackColor = Color.Red
            Case 1
                Me.BackColor = Color.White
            Case 2
                Me.BackColor = Color.Blue
            Case 3
                Me.BackColor = Color.Yellow
        End Select

        colorActual = colorActual + 1
        If colorActual > 3 Then
            colorActual = 0
        End If



    End Sub
End Class
