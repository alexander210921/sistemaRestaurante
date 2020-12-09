Public Class F_Reporte_Venta
    Public texto As String
    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        texto = "ID Cliente"
        F_datos_reporte.Show()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        texto = "ID Empleado"
        F_datos_reporte.Show()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        texto = "Reporte por fecha"
        F_datos_reporte.Show()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        texto = "Num.Venta"
        F_datos_reporte.Show()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        texto = "Primeras N venta"
        F_datos_reporte.Show()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        texto = "Ultimas N venta"
        F_datos_reporte.Show()
    End Sub
End Class