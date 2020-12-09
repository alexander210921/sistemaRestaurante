Public Class F_ver_reporte_fecha
    Private Sub F_ver_reporte_fecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.ReporteventaporFecha' Puede moverla o quitarla según sea necesario.
        Me.ReporteventaporFechaTableAdapter.Fill(Me.dbSistemaDataSet1.ReporteventaporFecha, F_datos_reporte.fecha1, F_datos_reporte.fecha2)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class