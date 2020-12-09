Public Class F_detalleventa
    Public num As Integer
    Public id_cliente As Integer
    Public id_numventa As Integer
    Private Sub Detalle_facturaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Detalle_facturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbSistemaDataSet1)
    End Sub
    Private Sub F_detalleventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.NumVenta' Puede moverla o quitarla según sea necesario.
        Me.NumVentaTableAdapter.Fill(Me.DbSistemaDataSet1.NumVenta)
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.DbSistemaDataSet1.cliente)
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.DbSistemaDataSet1.producto)
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.forma_pago' Puede moverla o quitarla según sea necesario.
        Me.Forma_pagoTableAdapter.Fill(Me.DbSistemaDataSet1.forma_pago)
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.detalle_factura' Puede moverla o quitarla según sea necesario.
        Me.Detalle_facturaTableAdapter.Fill(Me.DbSistemaDataSet1.detalle_factura)
        Id_empleadoTextBox.Text = F_login.a
        Id_numVentaTextBox.Text = Me.NumVentaTableAdapter.ventaactual().Value
        MontoApagarTextBox.Text = 0
        VueltoTextBox.Text = 0
        MontoApagarTextBox.Enabled = False
        TotalTextBox.Enabled = False
        Id_tipoPagoTextBox.Text = ""
        Id_productoTextBox.Text = ""
        CantidadDeProductoTextBox.Text = ""
        Precio_unitarioTextBox.Text = ""
        TotalTextBox.Text = ""
        Id_clienteTextBox.Text = ""
        NumeroNITTextBox.Text = 0
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Try
            Me.dataGridView1.DataSource = Me.Forma_pagoTableAdapter.buscarformadepago(Id_tipoPagoTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("El valor del campo es erroneo")
        End Try
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Try
            Precio_unitarioTextBox.Text = Me.ProductoTableAdapter.preciounitario(Id_productoTextBox.Text)
            Me.dataGridView1.DataSource = Me.ProductoTableAdapter.buscarempleado(Id_productoTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Este producto no existe ")
        End Try
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Try
            Me.dataGridView1.DataSource = Me.ClienteTableAdapter.buscarcliente(Id_clienteTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("El valor del campo es erroneo")
        End Try
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Try
            id_numventa = Convert.ToInt32(Id_numVentaTextBox.Text)
            id_cliente = Convert.ToInt32(Id_clienteTextBox.Text)
            MontoApagarTextBox.Enabled = True
            button2.Enabled = True
            num = num + Convert.ToInt32(CantidadDeProductoTextBox.Text) * Convert.ToInt32(Precio_unitarioTextBox.Text)
            TotalTextBox.Text = num
            MessageBox.Show("Se agregó correctamente")
            If Id_tipoPagoTextBox.Text.Length <= 0 Or Id_productoTextBox.Text.Length <= 0 Or CantidadDeProductoTextBox.Text.Length <= 0 Or Id_clienteTextBox.Text.Length <= 0 Then
                MessageBox.Show("Revisa no dejar campos vacios")
            Else
                Me.Detalle_facturaTableAdapter.insertardetallefactura(Id_numVentaTextBox.Text, Id_clienteTextBox.Text, Id_productoTextBox.Text, Id_empleadoTextBox.Text, Id_tipoPagoTextBox.Text, FechaDateTimePicker.Value, CantidadDeProductoTextBox.Text, Precio_unitarioTextBox.Text, NumeroNITTextBox.Text, TotalTextBox.Text, MontoApagarTextBox.Text, VueltoTextBox.Text)
                Panel3.Enabled = False
                Panel5.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Try
            If Convert.ToInt32(MontoApagarTextBox.Text) < Convert.ToInt32(TotalTextBox.Text) Then
                MessageBox.Show("El monto a pagar es menor al total")
            Else
                VueltoTextBox.Text = Convert.ToInt32(MontoApagarTextBox.Text) - (Convert.ToInt32(TotalTextBox.Text))
                Me.Detalle_facturaTableAdapter.insertardetallefactura(Id_numVentaTextBox.Text, Id_clienteTextBox.Text, 0, Id_empleadoTextBox.Text, Id_tipoPagoTextBox.Text, FechaDateTimePicker.Value, 0, Precio_unitarioTextBox.Text, NumeroNITTextBox.Text, TotalTextBox.Text, MontoApagarTextBox.Text, VueltoTextBox.Text)
                MessageBox.Show("compra realizada")
                F_mostrardetallefactura.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("ingrese el montode pago del cliente")
        End Try

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Inicio.Show()
        Me.Hide()
    End Sub
End Class