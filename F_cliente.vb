Public Class F_cliente
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbSistemaDataSet1)

    End Sub

    Private Sub F_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.DbSistemaDataSet1.cliente)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.ClienteTableAdapter.insertarcliente(NombreTextBox1.Text, ApellidoTextBox1.Text, TelefonoTextBox1.Text, EmailTextBox1.Text, PaisTextBox1.Text, DepartamentoTextBox1.Text, UbicacionTextBox1.Text)
            Me.ClienteTableAdapter.Fill(Me.DbSistemaDataSet1.cliente)
        Catch ex As Exception
            MessageBox.Show("No se pudo guardar")
        End Try
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Me.ClienteTableAdapter.actualizarcliente(NombreTextBox1.Text, ApellidoTextBox1.Text, TelefonoTextBox1.Text, EmailTextBox1.Text, PaisTextBox1.Text, DepartamentoTextBox1.Text, UbicacionTextBox1.Text, Id_clienteTextBox1.Text, Id_clienteTextBox1.Text)
            Me.ClienteTableAdapter.Fill(Me.DbSistemaDataSet1.cliente)
        Catch ex As Exception
            MessageBox.Show("No se pudo actualizar")
        End Try

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            Me.ClienteTableAdapter.eliminarcliente(Id_clienteTextBox1.Text)
            Me.ClienteTableAdapter.Fill(Me.DbSistemaDataSet1.cliente)
        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar")
        End Try

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Me.ClienteDataGridView.DataSource = Me.ClienteTableAdapter.verclientes()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Me.ClienteDataGridView.DataSource = Me.ClienteTableAdapter.buscarcliente(Convert.ToInt32(TextBox1.Text))
        Catch
            MessageBox.Show("Ocurrió un error")
        End Try
    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            End
        Else

        End If
    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        Me.WindowState = FormWindowState.Maximized
        pictureBox2.Visible = False
        pictureBox4.Visible = True
    End Sub

    Private Sub pictureBox3_Click(sender As Object, e As EventArgs) Handles pictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pictureBox4_Click(sender As Object, e As EventArgs) Handles pictureBox4.Click
        Me.WindowState = FormWindowState.Normal
        pictureBox2.Visible = True
        pictureBox4.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Inicio.Show()
        Me.Hide()
    End Sub
End Class