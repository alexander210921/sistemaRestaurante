Public Class F_ver_primerV
    Private Sub F_ver_primerV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.PrimerasNventas' Puede moverla o quitarla según sea necesario.
        Me.PrimerasNventasTableAdapter.Fill(Me.dbSistemaDataSet1.PrimerasNventas, F_datos_reporte.ID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class