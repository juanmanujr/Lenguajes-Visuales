Public Class Form2
    Dim Edad As String = ""
    Dim ciudad As String = ""
    Private Sub btnComprobar_Click(sender As Object, e As EventArgs) Handles btnComprobar.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Edad = 'Tengo menos de 18 años'
        ' MsgBox("Tengo menos de 18 años")
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'MsgBox("Tengo entre 18 y 45 años ")
        Edad = "tengo entre 18 y 45 años "
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        'MsgBox("Tengo mas de 45 años ")
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        ' MsgBox("Caacupe")
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        ' MsgBox("Piribebuy")
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        ' MsgBox("Asunción")
    End Sub
End Class