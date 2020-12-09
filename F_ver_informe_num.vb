Public Class F_ver_informe_num
    Private Sub F_ver_informe_num_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.Informepornumventa' Puede moverla o quitarla según sea necesario.
        Me.InformepornumventaTableAdapter.Fill(Me.dbSistemaDataSet1.Informepornumventa, F_datos_reporte.ID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class