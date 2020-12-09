Public Class F_ver_compras
    Private Sub F_ver_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.reporeCompra' Puede moverla o quitarla según sea necesario.
        Me.reporeCompraTableAdapter.Fill(Me.dbSistemaDataSet1.reporeCompra)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class