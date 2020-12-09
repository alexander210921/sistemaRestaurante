Public Class F_compra
    Private Sub CompraBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CompraBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbSistemaDataSet1)

    End Sub

    Private Sub F_compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.compra' Puede moverla o quitarla según sea necesario.
        Me.CompraTableAdapter.Fill(Me.DbSistemaDataSet1.compra)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.CompraTableAdapter.insertarcompra(Id_productoTextBox.Text, Valor_compraTextBox.Text, ObservacionTextBox.Text)
            Me.CompraTableAdapter.Fill(Me.DbSistemaDataSet1.compra)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.CompraTableAdapter.actualizarcompra(Id_productoTextBox.Text, Valor_compraTextBox.Text, ObservacionTextBox.Text, Id_compraTextBox.Text, Id_compraTextBox.Text)
            Me.CompraTableAdapter.Fill(Me.DbSistemaDataSet1.compra)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Me.CompraTableAdapter.eliminarrcompra(Id_compraTextBox.Text)
            Me.CompraTableAdapter.Fill(Me.DbSistemaDataSet1.compra)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Me.CompraDataGridView.DataSource = Me.CompraTableAdapter.buscarcompra(TextBox1.Text)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.CompraDataGridView.DataSource = Me.CompraTableAdapter.vercompras()
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
End Class