Public Class Form1
    ' Contador para productos
    Private totalProductos As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicialización del contador
        ActualizarCantidadTotal()
    End Sub

    ' Método para agregar productos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Verificar que el TextBox no esté vacío
        If Not String.IsNullOrWhiteSpace(TextBox1.Text) Then
            ' Agregar el producto al ListBox
            ListBox1.Items.Add(TextBox1.Text)
            ' Limpiar el TextBox
            TextBox1.Clear()
            ' Incrementar el contador
            totalProductos += 1
            ' Actualizar la cantidad total
            ActualizarCantidadTotal()
        Else
            ' Mensaje de advertencia si no se ingresa producto
            MessageBox.Show("Por favor ingrese un nombre de producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Método para eliminar el producto seleccionado
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Verificar si hay un producto seleccionado
        If ListBox1.SelectedIndex >= 0 Then
            ' Eliminar el producto seleccionado
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            ' Decrementar el contador
            totalProductos -= 1
            ' Actualizar la cantidad total
            ActualizarCantidadTotal()
        Else
            ' Mensaje si no se selecciona un producto
            MessageBox.Show("Seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Método para actualizar la cantidad total de productos
    Private Sub ActualizarCantidadTotal()
        Label1.Text = "Total de productos: " & totalProductos.ToString()
    End Sub
End Class
