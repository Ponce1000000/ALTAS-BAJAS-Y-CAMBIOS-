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
                Using cmd As New SqlCommand("SELECT * FROM TipoCarro", con)
                    Dim dt As New DataTable()
                    con.Open()
                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                    con.Close()
                    DataGridViewTipoCarro.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Try
            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("INSERT INTO TipoCarro (Tipo, Transimision, Cuerpo, color, interior, Kilometraje, IdUsuarioCrea, Estatus) VALUES (@Tipo, @Transimision, @Cuerpo, @Color, @Interior, @Kilometraje, @IdUsuarioCrea, @Estatus)", con)
                    cmd.Parameters.AddWithValue("@Tipo", txtTipo.Text)
                    cmd.Parameters.AddWithValue("@Transimision", txtTransmision.Text)
                    cmd.Parameters.AddWithValue("@Cuerpo", txtCuerpo.Text)
                    cmd.Parameters.AddWithValue("@Color", txtColor.Text)
                    cmd.Parameters.AddWithValue("@Interior", txtInterior.Text)
                    cmd.Parameters.AddWithValue("@Kilometraje", txtKilometraje.Text)
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
            If DataGridViewTipoCarro.CurrentRow IsNot Nothing Then
                Using con As New SqlConnection(connectionString)
                    Using cmd As New SqlCommand("DELETE FROM TipoCarro WHERE id = @id", con)
                        Dim selectedId As Integer = Convert.ToInt32(DataGridViewTipoCarro.CurrentRow.Cells("id").Value)
                        cmd.Parameters.AddWithValue("@id", selectedId)
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
            If DataGridViewTipoCarro.CurrentRow IsNot Nothing Then
                Using con As New SqlConnection(connectionString)
                    Using cmd As New SqlCommand("UPDATE TipoCarro SET Tipo = @Tipo, Transimision = @Transimision, Cuerpo = @Cuerpo, color = @Color, interior = @Interior, Kilometraje = @Kilometraje, IdUsuarioModfica = @IdUsuarioModfica, FechaModifica = GETDATE(), Estatus = @Estatus WHERE id = @id", con)
                        Dim selectedId As Integer = Convert.ToInt32(DataGridViewTipoCarro.CurrentRow.Cells("id").Value)
                        cmd.Parameters.AddWithValue("@Tipo", txtTipo.Text)
                        cmd.Parameters.AddWithValue("@Transimision", txtTransmision.Text)
                        cmd.Parameters.AddWithValue("@Cuerpo", txtCuerpo.Text)
                        cmd.Parameters.AddWithValue("@Color", txtColor.Text)
                        cmd.Parameters.AddWithValue("@Interior", txtInterior.Text)
                        cmd.Parameters.AddWithValue("@Kilometraje", txtKilometraje.Text)
                        cmd.Parameters.AddWithValue("@IdUsuarioModfica", Convert.ToInt32(txtIdUsuarioModifica.Text))
                        cmd.Parameters.AddWithValue("@Estatus", chkEstatus.Checked)
                        cmd.Parameters.AddWithValue("@id", selectedId)
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