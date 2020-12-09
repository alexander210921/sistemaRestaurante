Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections
Public Class Inicio
    Public notificacion As Integer
    Public contador As Integer
    Public a As Integer = 1
    Public cmd As SqlCommand
    Public rd As SqlDataReader
    Dim connec As SqlConnection = New SqlConnection("Server=(local);DataBase= dbSistema;Integrated Security=true")
    Dim nombre As ArrayList = New ArrayList()
    Dim cantidad As ArrayList = New ArrayList()

    Dim cliente As ArrayList = New ArrayList()
    Dim cantidad2 As ArrayList = New ArrayList()

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

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        F_producto.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        F_cliente.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        F_empleado.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        F_Proveedor.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        F_pago.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        F_compra.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        F_venta.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If a Mod 2.0! = 0 Then
            Panel13.Visible = True
        Else
            Panel13.Visible = False
        End If
        a = a + 1

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        F_Reporte_Venta.Show()
        Me.Hide()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        F_Reporte_Pagos.Show()
        Me.Hide()
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.DbSistemaDataSet1.empleado)
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.DbSistemaDataSet1.proveedor)
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.DbSistemaDataSet1.cliente)
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.DbSistemaDataSet1.producto)
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.detalle_factura' Puede moverla o quitarla según sea necesario.
        Me.Detalle_facturaTableAdapter.Fill(Me.DbSistemaDataSet1.detalle_factura)
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.ProductosPreferidos' Puede moverla o quitarla según sea necesario.
        Me.ProductosPreferidosTableAdapter.Fill(Me.DbSistemaDataSet1.ProductosPreferidos)
        If F_login.rpt Then
            Button3.Visible = True
            Button4.Visible = True
            Button6.Visible = True
            Button8.Visible = True
            Button7.Visible = True
            Panel6.Visible = True
            Panel7.Visible = True
            Panel9.Visible = True
            Panel10.Visible = True
            Panel11.Visible = True
            Panel16.Visible = True
        End If
        productos()
        clientev()
        Label1.Text = Me.Detalle_facturaTableAdapter.totalventa()
        label9.Text = Me.ProductoTableAdapter.totalproducto()
        label10.Text = Me.ClienteTableAdapter.totalcliente()
        label12.Text = Me.ProveedorTableAdapter.totalproveedor()
        label14.Text = Me.EmpleadoTableAdapter.totalempleado()
        Label2.Text = Me.Detalle_facturaTableAdapter.totalganancia()
        If F_Home.status Then
            TextBox5.Text = "Hay nuevos pedidos"
        End If


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        F_ver_compras.Show()
    End Sub
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
    End Sub

    Public Function productos()
        cmd = New SqlCommand("ProductosPreferidos", connec)
        cmd.CommandType = CommandType.StoredProcedure
        connec.Open()
        rd = cmd.ExecuteReader
        While rd.Read()
            nombre.Add(rd.GetString(0))
            cantidad.Add(rd.GetInt32(1))
        End While
        Chart1.Series(0).Points.DataBindXY(nombre, cantidad)
        rd.Close()
        connec.Close()
    End Function

    Public Function clientev()
        cmd = New SqlCommand("top5clientesmasrecurrentes", connec)
        cmd.CommandType = CommandType.StoredProcedure
        connec.Open()
        rd = cmd.ExecuteReader
        While rd.Read()
            cliente.Add(rd.GetString(0))
            cantidad2.Add(rd.GetInt32(1))
        End While
        Chart2.Series(0).Points.DataBindXY(cliente, cantidad2)
        rd.Close()
        connec.Close()
    End Function

    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs) Handles Panel16.Paint

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        If (MsgBox("¿Esta seguro de cerrar su sesion?", vbCritical + vbYesNo) = vbYes) Then
            F_login.Show()
            Me.Close()
        Else
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If (MsgBox("¿Estas seguro de cerrar seion", vbCritical + vbYesNo) = vbYes) Then
            F_login.Show()
            Me.Close()
        Else
        End If
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        If contador Mod 2.0! = 0 Then
            Panel17.Visible = True
        Else
            Panel17.Visible = False
        End If
        If notificacion Then
            TextBox5.Text = "Hay nuevos pedidos"
            Button12.Visible = True
        End If
        contador = contador + 1
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        F_pedido.Show()
        Me.Hide()
    End Sub
End Class