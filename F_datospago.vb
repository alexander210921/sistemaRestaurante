Public Class F_datospago
    Public id As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            id = Convert.ToInt32(TextBox1.Text)
            F_pago_.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            Me.Close()
        Else

        End If
    End Sub
End Class