Public Class F_ver_reporte_ultimasN
    Private Sub F_ver_reporte_ultimasN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.UltimassNventas' Puede moverla o quitarla según sea necesario.
        Me.UltimassNventasTableAdapter.Fill(Me.dbSistemaDataSet1.UltimassNventas, F_datos_reporte.ID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class