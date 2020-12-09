Public Class F_Reporte_Pagos

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Try
            F_verPagos.Show()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Try
            F_datospago.Show()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            End
        Else

        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class