Imports Npgsql

Public Class Form1
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim connString As String = "Host=localhost;Port=5432;Username=postgres;Password=Queteimporta9;Database=mi_base"
        Dim conn As New NpgsqlConnection(connString)

        Try
            conn.Open()

            Dim query As String = "INSERT INTO clientes(id, nombre, apellido, telefono, ci) VALUES (@id, @nombre, @apellido, @telefono, @ci)"
            Dim cmd As New NpgsqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text))
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@apellido", txtApellido.Text)
            cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text)
            cmd.Parameters.AddWithValue("@ci", txtCi.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Cliente guardado con éxito")
            'para limpiar los campos de id,nombre, apellido,telefono,ci,id, despues de ingresar
            txtID.Clear()
            txtNombre.Clear()
            txtApellido.Clear()
            txtTelefono.Clear()
            txtCi.Clear()
            txtID.Focus()
            conn.Close()


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try

    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim connString As String = "Host=localhost;Port=5432;Username=postgres;Password=Queteimporta9;Database=mi_base"
        Dim conn As New NpgsqlConnection(connString)

        Try
            'abrir la conexion con la base de datos
            conn.Open()

            Dim query As String = "SELECT *FROM clientes"
            Dim cmd As New NpgsqlCommand(query, conn)
            Dim da As New NpgsqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)
            dgvClientes.DataSource = dt

            'cerrar la conexion con la base de datos
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error al mostrar clientes: " & ex.Message)
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'creacion de la llave para conectarse a la base de datos

        Dim connString As String = "Host=localhost;Port=5432;Username=postgres;Password=Queteimporta9;Database=mi_base"
        ' 'dimm connstring as string: crea una variable tipo texto llamada connstring
        'lo de adentro es la cadena de conexion, que le dice al programa donde esta la base, con que usuario y que base usar
        'host=localhost: la base de datos esta en nuestra propia computadora
        'port=5432 es el puerto donde se conecta postgresql
        'username=postgres: nuestro usuario de postgresql
        'pasword=queteimporta: la contraseña para entrar
        'database=mi_base el nombre de tu base de datos
        'es como el gps para que el programa encuentre la base y pueda trabajar con ella
        Dim conn As New NpgsqlConnection(connString)

        Try
            'abrir la conexion con la base de datos
            conn.Open()

            Dim query As String = "DELETE FROM clientes WHERE id = @id"
            Dim cmd As New NpgsqlCommand(query, conn)




            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text)) 'preparar un dato para mandarle a la base de datos
            'cmd: comando que ejecuta el insert
            '.parameter.add.whitvalue: decirle el valor que vas a usar en el campo @id
            '@id nombre del parametro en la consulta sql
            'convert.toint32(txtid.text) agarra el texto del id y lo convierte en numero


            Dim result As Integer = cmd.ExecuteNonQuery()
            'cmd.executenonquery() ejecuta el comando sql
            If result > 0 Then
                MessageBox.Show("Cliente eliminado correctamente")
            Else
                MessageBox.Show("No se encontró un cliente con ese ID")
            End If


            conn.Close()
            btnMostrar.PerformClick() 'actualiza la tabla automaticamente
            'btnMostrar tiene codigo que actualiza la tabla, entonces .perfomclick se ejecuta sin hacer click en btnMostrar 
            'asi la tabla se actualiza sola
        Catch ex As Exception
            MessageBox.Show("Error al eliminar cliente: " & ex.Message)

        End Try






    End Sub
End Class
