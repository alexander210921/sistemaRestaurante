Public Class F_ver_informe_venta_cliente
    Private Sub F_ver_informe_venta_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.Reporteporclienteventa' Puede moverla o quitarla según sea necesario.
        Me.ReporteporclienteventaTableAdapter.Fill(Me.dbSistemaDataSet1.Reporteporclienteventa, F_datos_reporte.ID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class