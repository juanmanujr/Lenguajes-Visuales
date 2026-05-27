Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim() <> "" Then
            ListBox1.Items.Add(TextBox1.Text.Trim())
            TextBox1.Clear()
        Else
            MessageBox.Show("Ingrese un nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex <> -1 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        Else
            MessageBox.Show("Seleccione un nombre para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub
End Class
