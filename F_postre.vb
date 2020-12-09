Public Class F_postre
    Public contador As Integer
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        F_Home.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            Me.PedidoTableAdapter.insertarpedido(Me.NumVentaTableAdapter.ventaactual(), F_infoCliente.id_cliente, 13, DateTimePicker1.Value, TextBox1.Text, 19, 0, 0, 0)
            MessageBox.Show("Se agregó tu orden")
            F_Home.status = True

        Catch ex As Exception
            MessageBox.Show("No se pudo agregar tu pedido")
        End Try
    End Sub

    Private Sub NumVentaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.NumVentaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbSistemaDataSet1)

    End Sub

    Private Sub F_postre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.pedido' Puede moverla o quitarla según sea necesario.
        Me.PedidoTableAdapter.Fill(Me.DbSistemaDataSet1.pedido)
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.NumVenta' Puede moverla o quitarla según sea necesario.
        Me.NumVentaTableAdapter.Fill(Me.DbSistemaDataSet1.NumVenta)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.PedidoTableAdapter.insertarpedido(Me.NumVentaTableAdapter.ventaactual(), F_infoCliente.id_cliente, 14, DateTimePicker1.Value, TextBox2.Text, 15, 0, 0, 0)
            MessageBox.Show("Se agregó tu orden")
            F_Home.status = True

        Catch ex As Exception
            MessageBox.Show("No se pudo agregar tu pedido")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.PedidoTableAdapter.insertarpedido(Me.NumVentaTableAdapter.ventaactual(), F_infoCliente.id_cliente, 15, DateTimePicker1.Value, TextBox3.Text, 25, 0, 0, 0)
            MessageBox.Show("Se agregó tu orden")
            F_Home.status = True

        Catch ex As Exception
            MessageBox.Show("No se pudo agregar tu pedido")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.PedidoTableAdapter.insertarpedido(Me.NumVentaTableAdapter.ventaactual(), F_infoCliente.id_cliente, 16, DateTimePicker1.Value, TextBox4.Text, 12, 0, 0, 0)
            MessageBox.Show("Se agregó tu orden")
            F_Home.status = True
        Catch ex As Exception
            MessageBox.Show("No se pudo agregar tu pedido")
        End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If contador Mod 2.0! = 0 Then
            Panel8.Visible = True
        Else
            Panel8.Visible = False

        End If

        contador = contador + 1


    End Sub
End Class