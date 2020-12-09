Public Class F_verPagos
    Private Sub F_verPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.ReportePagos' Puede moverla o quitarla según sea necesario.
        Me.ReportePagosTableAdapter.Fill(Me.dbSistemaDataSet1.ReportePagos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class