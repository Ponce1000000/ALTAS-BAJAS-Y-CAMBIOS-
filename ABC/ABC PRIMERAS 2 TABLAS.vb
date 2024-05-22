Imports System.Configuration
Imports System.Data.SqlClient

Public Class Form2
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("DBConnectionString").ConnectionString

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadData()
        Try
            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("SELECT * FROM Vendedor", con)
                    Dim dt As New DataTable()
                    con.Open()
                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                    con.Close()
                    DataGridViewVendedor.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Try
            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("INSERT INTO Vendedor (Distribuidor, Precio, fechaventa, IdUsuarioCrea, Estatus) VALUES (@Distribuidor, @Precio, @fechaventa, @IdUsuarioCrea, @Estatus)", con)
                    cmd.Parameters.AddWithValue("@Distribuidor", txtDistribuidor.Text)
                    cmd.Parameters.AddWithValue("@Precio", Convert.ToInt32(txtPrecio.Text))
                    cmd.Parameters.AddWithValue("@fechaventa", txtFechaVenta.Text)
                    cmd.Parameters.AddWithValue("@IdUsuarioCrea", Convert.ToInt32(txtIdUsuarioCrea.Text))
                    cmd.Parameters.AddWithValue("@Estatus", chkEstatus.Checked)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    LoadData()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar el registro: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If DataGridViewVendedor.CurrentRow IsNot Nothing Then
                Using con As New SqlConnection(connectionString)
                    Using cmd As New SqlCommand("DELETE FROM Vendedor WHERE Distribuidor = @Distribuidor", con)
                        Dim selectedDistribuidor As String = DataGridViewVendedor.CurrentRow.Cells("Distribuidor").Value.ToString()
                        cmd.Parameters.AddWithValue("@Distribuidor", selectedDistribuidor)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                        LoadData()
                    End Using
                End Using
            Else
                MessageBox.Show("Por favor, seleccione una fila para eliminar.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el registro: " & ex.Message)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If DataGridViewVendedor.CurrentRow IsNot Nothing Then
                Using con As New SqlConnection(connectionString)
                    Using cmd As New SqlCommand("UPDATE Vendedor SET Precio = @Precio, fechaventa = @fechaventa, IdUsuarioModfica = @IdUsuarioModfica, FechaModifica = GETDATE(), Estatus = @Estatus WHERE Distribuidor = @Distribuidor", con)
                        Dim selectedDistribuidor As String = DataGridViewVendedor.CurrentRow.Cells("Distribuidor").Value.ToString()
                        cmd.Parameters.AddWithValue("@Precio", Convert.ToInt32(txtPrecio.Text))
                        cmd.Parameters.AddWithValue("@fechaventa", txtFechaVenta.Text)
                        cmd.Parameters.AddWithValue("@IdUsuarioModfica", Convert.ToInt32(txtIdUsuarioModifica.Text))
                        cmd.Parameters.AddWithValue("@Estatus", chkEstatus.Checked)
                        cmd.Parameters.AddWithValue("@Distribuidor", selectedDistribuidor)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                        LoadData()
                    End Using
                End Using
            Else
                MessageBox.Show("Por favor, seleccione una fila para actualizar.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el registro: " & ex.Message)
        End Try
    End Sub
End Class
