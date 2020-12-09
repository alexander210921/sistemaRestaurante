Public Class F_producto
    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbSistemaDataSet1)

    End Sub

    Private Sub F_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.DbSistemaDataSet1.producto)
        TextBox2.Text = F_login.a


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.ProductoTableAdapter.insertarproducto(Id_categoriaTextBox.Text, Id_proveedorTextBox.Text, NombreTextBox.Text, DescripcionTextBox.Text, Convert.ToDecimal(Precio_compraTextBox.Text), Convert.ToDecimal(Precio_ventaTextBox.Text), Convert.ToDecimal(DescuestoTextBox.Text), Convert.ToInt32(CantidadTextBox.Text), Convert.ToInt32(TextBox2.Text), Fecha_ingresoDateTimePicker.Value)
            Me.ProductoTableAdapter.Fill(Me.DbSistemaDataSet1.producto)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.ProductoTableAdapter.actualizarproducto(Id_categoriaTextBox.Text, Id_proveedorTextBox.Text, NombreTextBox.Text, DescripcionTextBox.Text, Convert.ToDecimal(Precio_compraTextBox.Text), Convert.ToDecimal(Precio_ventaTextBox.Text), Convert.ToDecimal(DescuestoTextBox.Text), Convert.ToInt32(CantidadTextBox.Text), Convert.ToInt32(TextBox2.Text), Fecha_ingresoDateTimePicker.Value, Id_productoTextBox.Text, Id_productoTextBox.Text)
            Me.ProductoTableAdapter.Fill(Me.DbSistemaDataSet1.producto)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.ProductoTableAdapter.eliminarproducto(Id_productoTextBox.Text)
            Me.ProductoTableAdapter.Fill(Me.DbSistemaDataSet1.producto)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Me.ProductoTableAdapter.buscarempleado(Id_productoTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.ProductoTableAdapter.Fill(Me.DbSistemaDataSet1.producto)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        F_categoria.Show()

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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class