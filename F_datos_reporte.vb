Public Class F_datos_reporte
    Public ID As Integer
    Public num As Integer
    Public fecha1 As Date
    Public fecha2 As Date
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub F_datos_reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textBox1.Text = ""
        If F_Reporte_Venta.texto.Equals("ID Cliente") Then
            label2.Text = "ID Cliente"
            label2.Visible = True
            textBox1.Visible = True
            num = 1
        End If
        If F_Reporte_Venta.texto.Equals("ID Empleado") Then
            label2.Text = "ID Empleado"
            label2.Visible = True
            textBox1.Visible = True
            num = 2
        End If
        If F_Reporte_Venta.texto.Equals("Reporte por fecha") Then
            label2.Text = "Reporte por fecha"
            label3.Visible = True
            label4.Visible = True
            dateTimePicker1.Visible = True
            dateTimePicker2.Visible = True
            label2.Visible = False
            textBox1.Visible = False
            num = 3
        End If

        If F_Reporte_Venta.texto.Equals("Num.Venta") Then
            label2.Text = "Num.Venta"
            label2.Visible = True
            textBox1.Visible = True
            num = 4
        End If
        If F_Reporte_Venta.texto.Equals("Primeras N venta") Then
            label2.Text = "Primeras N venta"
            label2.Visible = True
            textBox1.Visible = True
            num = 5
        End If
        If F_Reporte_Venta.texto.Equals("Ultimas N venta") Then
            label2.Text = "Ultimas N venta"
            label2.Visible = True
            textBox1.Visible = True
            num = 6
        End If



    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Try
            If num = 1 Then
                ID = Convert.ToInt32(textBox1.Text)
                textBox1.Text = ""
                F_ver_informe_venta_cliente.Show()
                Me.Close()
            ElseIf num = 2 Then
                ID = Convert.ToInt32(textBox1.Text)
                textBox1.Text = ""
                F_ver_reporte_empleado.Show()
                Me.Close()
            ElseIf num = 3 Then
                fecha1 = dateTimePicker1.Value
                fecha2 = dateTimePicker2.Value
                textBox1.Text = ""
                F_ver_reporte_fecha.Show()
                Me.Close()
            ElseIf num = 4 Then
                ID = Convert.ToInt32(textBox1.Text)
                textBox1.Text = ""
                F_ver_informe_num.Show()
                Me.Close()
            ElseIf num = 5 Then
                ID = Convert.ToInt32(textBox1.Text)
                textBox1.Text = ""
                F_ver_primerV.Show()
                Me.Close()
            ElseIf num = 6 Then
                ID = Convert.ToInt32(textBox1.Text)
                textBox1.Text = ""
                F_ver_reporte_ultimasN.Show()
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Llene el campo")
        End Try




    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            Me.Close()
        Else

        End If
    End Sub
End Class