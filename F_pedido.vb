Public Class F_pedido
    Private Sub F_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.nombredelcliente' Puede moverla o quitarla según sea necesario.
        Me.nombredelclienteTableAdapter.Fill(Me.dbSistemaDataSet1.nombredelcliente, F_infoCliente.id_cliente)
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.totaldelpedido' Puede moverla o quitarla según sea necesario.
        Me.totaldelpedidoTableAdapter.Fill(Me.dbSistemaDataSet1.totaldelpedido, Me.NumVentaTableAdapter.ventaactual())
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.direcciondelpedido' Puede moverla o quitarla según sea necesario.
        Me.direcciondelpedidoTableAdapter.Fill(Me.dbSistemaDataSet1.direcciondelpedido, F_infoCliente.id_cliente)
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.NumVenta' Puede moverla o quitarla según sea necesario.
        Me.NumVentaTableAdapter.Fill(Me.dbSistemaDataSet1.NumVenta)
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.detall_pedido' Puede moverla o quitarla según sea necesario.
        Me.detall_pedidoTableAdapter.Fill(Me.dbSistemaDataSet1.detall_pedido, Me.NumVentaTableAdapter.ventaactual())
        'TODO: esta línea de código carga datos en la tabla 'dbSistemaDataSet1.detalle_ubicacion' Puede moverla o quitarla según sea necesario.
        Me.detalle_ubicacionTableAdapter.Fill(Me.dbSistemaDataSet1.detalle_ubicacion, F_infoCliente.id_cliente)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Inicio.Show()
        Me.Hide()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            End
        Else

        End If
    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        Me.WindowState = FormWindowState.Maximized
        pictureBox2.Visible = False
        pictureBox4.Visible = True
    End Sub

    Private Sub pictureBox3_Click(sender As Object, e As EventArgs) Handles pictureBox3.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub pictureBox4_Click(sender As Object, e As EventArgs) Handles pictureBox4.Click
        Me.WindowState = FormWindowState.Normal
        pictureBox2.Visible = True
        pictureBox4.Visible = False
    End Sub
End Class