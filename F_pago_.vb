Public Class F_pago_
    Private Sub F_pago__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.ReportePagoEmpleado' Puede moverla o quitarla según sea necesario.
        Me.ReportePagoEmpleadoTableAdapter.Fill(Me.dbSistemaDataSet1.ReportePagoEmpleado, F_datospago.id)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class