Public Class Form1
    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        If txtProducto.Text <> "" Then
            lstProductos.Items.Add(txtProducto.Text)
            txtProducto.Clear()
            txtProducto.Focus()
            lblCantidad.Text = "Total de productos: " & lstProductos.Items.Count
        Else
            MessageBox.Show("Ingrese un producto para añadir")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If lstProductos.SelectedIndex <> -1 Then
            lstProductos.Items.RemoveAt(lstProductos.SelectedIndex)
            lblCantidad.Text = "Total de productos: " & lstProductos.Items.Count
        Else
            MessageBox.Show("Seleccione un producto para eliminar ")
        End If
    End Sub
End Class
