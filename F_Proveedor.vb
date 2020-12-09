Public Class F_Proveedor
    Private Sub ProveedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbSistemaDataSet1)
    End Sub

    Private Sub F_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.DbSistemaDataSet1.proveedor)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.ProveedorTableAdapter.agregarproveedor(NombreTextBox.Text, TelefonoTextBox.Text, EmailTextBox.Text, PaisTextBox.Text, DepartamentoTextBox.Text, UbicacionTextBox.Text)
            Me.ProveedorTableAdapter.Fill(Me.DbSistemaDataSet1.proveedor)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Me.ProveedorTableAdapter.actualizarproveedor(NombreTextBox.Text, TelefonoTextBox.Text, EmailTextBox.Text, PaisTextBox.Text, DepartamentoTextBox.Text, UbicacionTextBox.Text, Id_proveedorTextBox.Text, Id_proveedorTextBox.Text)
            Me.ProveedorTableAdapter.Fill(Me.DbSistemaDataSet1.proveedor)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            Me.ProveedorTableAdapter.eliminarproveedor(Id_proveedorTextBox.Text)
            Me.ProveedorTableAdapter.Fill(Me.DbSistemaDataSet1.proveedor)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Me.ProveedorDataGridView.DataSource = Me.ProveedorTableAdapter.buscarproveedor(TextBox1.Text)
        Catch ex As Exception
            MessageBox.Show("Ingrese el ID del proveedor")
        End Try

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Me.ProveedorDataGridView.DataSource = Me.ProveedorTableAdapter.verproveedor()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Inicio.Show()
        Me.Hide()
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
End Class