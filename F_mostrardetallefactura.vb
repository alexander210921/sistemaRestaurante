Public Class F_mostrardetallefactura
    Private Sub F_mostrardetallefactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.obtener_total2' Puede moverla o quitarla según sea necesario.
        Me.obtener_total2TableAdapter.Fill(Me.dbSistemaDataSet1.obtener_total2, F_detalleventa.id_numventa)
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.obtener_total' Puede moverla o quitarla según sea necesario.
        Me.obtener_totalTableAdapter.Fill(Me.dbSistemaDataSet1.obtener_total, F_detalleventa.id_numventa)
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.monto_pagar' Puede moverla o quitarla según sea necesario.
        Me.monto_pagarTableAdapter.Fill(Me.dbSistemaDataSet1.monto_pagar, F_detalleventa.id_numventa)
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.vuelto' Puede moverla o quitarla según sea necesario.
        Me.vueltoTableAdapter.Fill(Me.dbSistemaDataSet1.vuelto, F_detalleventa.id_numventa)
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.num_NIT' Puede moverla o quitarla según sea necesario.
        Me.num_NITTableAdapter.Fill(Me.dbSistemaDataSet1.num_NIT, F_detalleventa.id_numventa)
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.venta_actual' Puede moverla o quitarla según sea necesario.
        Me.venta_actualTableAdapter.Fill(Me.dbSistemaDataSet1.venta_actual)
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.fecha_emitida_factu' Puede moverla o quitarla según sea necesario.
        Me.fecha_emitida_factuTableAdapter.Fill(Me.dbSistemaDataSet1.fecha_emitida_factu)
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.nombre_cliente' Puede moverla o quitarla según sea necesario.
        Me.nombre_clienteTableAdapter.Fill(Me.dbSistemaDataSet1.nombre_cliente, F_detalleventa.id_cliente)
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.nombre_empleadossss' Puede moverla o quitarla según sea necesario.
        Me.nombre_empleadossssTableAdapter.Fill(Me.dbSistemaDataSet1.nombre_empleadossss, F_login.a)
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.nombre_empleado' Puede moverla o quitarla según sea necesario.
        Me.nombre_empleadoTableAdapter.Fill(Me.dbSistemaDataSet1.nombre_empleado, F_login.a)
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.NumVenta' Puede moverla o quitarla según sea necesario.
        Me.NumVentaTableAdapter.Fill(Me.dbSistemaDataSet1.NumVenta)
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.detalle_facturacion' Puede moverla o quitarla según sea necesario.
        Me.detalle_facturacionTableAdapter.Fill(Me.dbSistemaDataSet1.detalle_facturacion, Me.NumVentaTableAdapter.ventaactual().Value)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class