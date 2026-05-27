Public Class Form1
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtNombre.Text <> "" Then
            ListBox1.Items.Add(txtNombre.Text)
            txtNombre.Clear()
        Else
            MessageBox.Show("Ingrese un nombre antes de agregar")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If ListBox1.SelectedIndex <> -1 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        Else
            MessageBox.Show("Seleccione un nombre para eliminar")
        End If
    End Sub
End Class
