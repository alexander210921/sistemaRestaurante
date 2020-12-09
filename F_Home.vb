Public Class F_Home
    Public status As Boolean = False
    Public contador As Integer
    Public numventa As Integer
    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            End
        Else
        End If
    End Sub
    Private Sub pictureBox4_Click(sender As Object, e As EventArgs) Handles pictureBox4.Click
        Me.WindowState = FormWindowState.Normal
        pictureBox2.Visible = True
        pictureBox4.Visible = False
    End Sub
    Private Sub pictureBox3_Click(sender As Object, e As EventArgs) Handles pictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        Me.WindowState = FormWindowState.Maximized
        pictureBox2.Visible = False
        pictureBox4.Visible = True
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    End Sub
    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        F_menú.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        F_Bebida.Show()
        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        F_postre.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        F_ensalada.Show()
        Me.Hide()
    End Sub
    Private Sub PedidoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PedidoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbSistemaDataSet1)
    End Sub

    Private Sub F_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.pedido1' Puede moverla o quitarla según sea necesario.
        Me.Pedido1TableAdapter.Fill(Me.DbSistemaDataSet1.pedido1)
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.NumVenta' Puede moverla o quitarla según sea necesario.
        Me.NumVentaTableAdapter.Fill(Me.DbSistemaDataSet1.NumVenta)
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.pedido' Puede moverla o quitarla según sea necesario.
        Me.PedidoTableAdapter.Fill(Me.DbSistemaDataSet1.pedido)
        If status Then
            PictureBox6.Visible = True
            TextBox5.Text = "Tienes nuevos productos agregados"
            Button4.Visible = True
            Button6.Visible = True
        End If
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Try
            Me.PedidoTableAdapter.insertarpedido(Me.NumVentaTableAdapter.ventaactual(), F_infoCliente.id_cliente, 21, DateTimePicker1.Value, 0, 20, 0, 0, 0)
            MessageBox.Show("Se agregó tu orden")
        Catch ex As Exception
            MessageBox.Show("No se pudo agregar tu pedido")
        End Try
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If contador Mod 2.0! = 0 Then
            Panel6.Visible = True
        Else
            Panel6.Visible = False
        End If
        contador = contador + 1
        If status Then
            PictureBox6.Visible = True
            TextBox5.Text = "Tienes nuevos productos agregados"
            Button4.Visible = True
            Button6.Visible = True
            Inicio.notificacion = True
        Else
            Inicio.notificacion = False
        End If
    End Sub
    Private Sub Panel19_Paint(sender As Object, e As PaintEventArgs) Handles Panel19.Paint
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        F_datosPedido.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If (MsgBox("¿Esta seguro de cancelar su pedido?", vbCritical + vbYesNo) = vbYes) Then
                Me.Pedido1TableAdapter.eliminarpedido(numventa)
                Me.NumVentaTableAdapter.insertarventa("Nueva venta agregada")
                MessageBox.Show("Se eliminó su pedido")
                Button6.Visible = False
            Else
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error")
        End Try

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If (MsgBox("¿Estas seguro de cerrar seion", vbCritical + vbYesNo) = vbYes) Then
            F_login.Show()
            Me.Close()
        Else
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text += 1
        If Label3.Text = "35" Then
            PictureBox7.Image = My.Resources.imagen1
        End If

        If Label3.Text = "70" Then
            PictureBox7.Image = My.Resources.imagen2
        End If

        If Label3.Text = "105" Then
            PictureBox7.Image = My.Resources.imagen3
        End If

        If Label3.Text = "140" Then
            PictureBox7.Image = My.Resources.imagen4
        End If

        If Label3.Text = "175" Then
            PictureBox7.Image = My.Resources.imagen5
        End If

        If Label3.Text = "250" Then
            Timer1.Stop()
            PictureBox7.Image = My.Resources.imagen6
            Label3.Text = "0"
            Timer1.Start()
        End If
    End Sub
End Class