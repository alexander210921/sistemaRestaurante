Public Class F_ver_reporte_empleado
    Private Sub F_ver_reporte_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.ReporteventaporEmpleado' Puede moverla o quitarla según sea necesario.
        Me.ReporteventaporEmpleadoTableAdapter.Fill(Me.dbSistemaDataSet1.ReporteventaporEmpleado, F_datos_reporte.ID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class