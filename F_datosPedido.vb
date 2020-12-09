Public Class F_datosPedido
    Public ubicacion As String
    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ubicacion = ComboBox1.SelectedItem.ToString() & " " & TextBox3.Text
        Try
            Me.ClienteTableAdapter.ubicaciondelcliente(F_infoCliente.id_cliente, TextBox1.Text, TextBox2.Text, ubicacion)
            F_verDetallePedido.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try
    End Sub
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbSistemaDataSet1)
    End Sub
    Private Sub F_datosPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.DbSistemaDataSet1.cliente)
    End Sub
End Class