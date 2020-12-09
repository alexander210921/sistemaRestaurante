Public Class F_verDetallePedido
    Private Sub F_verDetallePedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.NumVenta' Puede moverla o quitarla según sea necesario.
        Me.NumVentaTableAdapter.Fill(Me.dbSistemaDataSet1.NumVenta)
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.detall_pedido' Puede moverla o quitarla según sea necesario.
        Me.detall_pedidoTableAdapter.Fill(Me.dbSistemaDataSet1.detall_pedido, Me.NumVentaTableAdapter.ventaactual())
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class