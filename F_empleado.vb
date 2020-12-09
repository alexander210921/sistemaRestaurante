Public Class F_empleado
    Private Sub EmpleadoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbSistemaDataSet1)

    End Sub

    Private Sub EmpleadoBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbSistemaDataSet1)

    End Sub

    Private Sub F_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.DbSistemaDataSet1.empleado)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.EmpleadoTableAdapter.Insertarempleado(NombreTextBox.Text, ApellidoTextBox.Text, SexoTextBox.Text, Fecha_nacDateTimePicker.Value, Convert.ToInt32(TelefonoTextBox.Text), Convert.ToInt64(DPITextBox.Text), Convert.ToDecimal(SalarioTextBox.Text), EmailTextBox.Text, PaisTextBox.Text, DepartamentoTextBox.Text, UbicacionTextBox.Text, UsuarioTextBox.Text, PassworduserTextBox.Text, AccesoTextBox.Text)
            Me.EmpleadoTableAdapter.Fill(Me.DbSistemaDataSet1.empleado)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Me.EmpleadoDataGridView.DataSource = Me.EmpleadoTableAdapter.buscarempleado(Id_empleadoTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.EmpleadoDataGridView.DataSource = Me.EmpleadoTableAdapter.verempleado()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.EmpleadoTableAdapter.eliminarempleado(Id_empleadoTextBox.Text)
            Me.EmpleadoTableAdapter.Fill(Me.DbSistemaDataSet1.empleado)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.EmpleadoTableAdapter.actualizarempleado(NombreTextBox.Text, ApellidoTextBox.Text, SexoTextBox.Text, Fecha_nacDateTimePicker.Value, Convert.ToInt32(TelefonoTextBox.Text), Convert.ToInt64(DPITextBox.Text), Convert.ToDecimal(SalarioTextBox.Text), EmailTextBox.Text, PaisTextBox.Text, DepartamentoTextBox.Text, UbicacionTextBox.Text, UsuarioTextBox.Text, PassworduserTextBox.Text, AccesoTextBox.Text, Id_empleadoTextBox.Text, Id_empleadoTextBox.Text)
            Me.EmpleadoTableAdapter.Fill(Me.DbSistemaDataSet1.empleado)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
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

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub
End Class