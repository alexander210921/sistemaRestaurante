Public Class F_infoCliente
    Public id_cliente As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        F_login.Show()
        Me.Hide()

    End Sub
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbSistemaDataSet1)
    End Sub

    Private Sub F_infoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.NumVenta' Puede moverla o quitarla según sea necesario.
        Me.NumVentaTableAdapter.Fill(Me.DbSistemaDataSet1.NumVenta)
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.DbSistemaDataSet1.cliente)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Me.ClienteTableAdapter.VerificarCliente(Convert.ToInt32(TextBox2.Text)).Value > 0 Then
                Me.NumVentaTableAdapter.insertarventa("Nueva venta en el sistema")
                F_Home.numventa = NumVentaTableAdapter.ventaactual()
                id_cliente = Convert.ToInt32(TextBox2.Text)
                MessageBox.Show("Bienvenido")
                F_Home.Show()
                Me.Hide()
            Else
                MessageBox.Show("Codigo incorrecto")

            End If
        Catch ex As Exception
            MessageBox.Show("Ingrese el codigo")
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        F_Registro.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            End
        Else
        End If
    End Sub
End Class