Public Class F_pago
    Private Sub Forma_pagoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Forma_pagoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbSistemaDataSet1)

    End Sub

    Private Sub F_pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.Pagos' Puede moverla o quitarla según sea necesario.
        Me.PagosTableAdapter.Fill(Me.DbSistemaDataSet1.Pagos)
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.forma_pago' Puede moverla o quitarla según sea necesario.
        Me.Forma_pagoTableAdapter.Fill(Me.DbSistemaDataSet1.forma_pago)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Forma_pagoTableAdapter.insertarformadepago(DescripcionTextBox.Text)
            Me.Forma_pagoTableAdapter.Fill(Me.DbSistemaDataSet1.forma_pago)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.Forma_pagoTableAdapter.actualizarformadepago(DescripcionTextBox.Text, Id_formaPagoTextBox.Text, Id_formaPagoTextBox.Text)
            Me.Forma_pagoTableAdapter.Fill(Me.DbSistemaDataSet1.forma_pago)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Me.Forma_pagoTableAdapter.eliminarformadepago(Id_formaPagoTextBox.Text)
            Me.Forma_pagoTableAdapter.Fill(Me.DbSistemaDataSet1.forma_pago)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Me.Forma_pagoDataGridView.DataSource = Me.Forma_pagoTableAdapter.buscarformadepago(TextBox1.Text)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Forma_pagoDataGridView.DataSource = Me.Forma_pagoTableAdapter.verformasdepago()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            Me.PagosTableAdapter.insertarpago(Id_tipopagoTextBox.Text, Id_empleadoTextBox.Text, Convert.ToDecimal(MontoTextBox.Text), DescripcionTextBox1.Text, FechaDateTimePicker.Value)
            Me.PagosTableAdapter.Fill(Me.DbSistemaDataSet1.Pagos)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Me.PagosDataGridView.DataSource = Me.PagosTableAdapter.verpagos()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            Me.PagosDataGridView.DataSource = Me.PagosTableAdapter.buscarpago(TextBox2.Text)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            Me.PagosTableAdapter.eliminarpago(Convert.ToInt32(IdnumPagoTextBox.Text))
            Me.PagosTableAdapter.Fill(Me.DbSistemaDataSet1.Pagos)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Me.PagosTableAdapter.actualizarpago(IdnumPagoTextBox.Text, Id_tipopagoTextBox.Text, Id_empleadoTextBox.Text, MontoTextBox.Text, DescripcionTextBox1.Text, FechaDateTimePicker.Value)
            Me.PagosTableAdapter.Fill(Me.DbSistemaDataSet1.Pagos)
        Catch ex As Exception
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Inicio.Show()
        Me.Hide()

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class