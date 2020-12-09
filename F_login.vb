

Public Class F_login
    Public a As Integer
    Public rpt As Boolean
    Private Sub EmpleadoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbSistemaDataSet1)
    End Sub

    Private Sub F_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.DbSistemaDataSet1.empleado)
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Try
                If (Me.EmpleadoTableAdapter.roll(TextBox1.Text, TextBox2.Text).Equals("Vendedor")) Then
                    MessageBox.Show("Vendedor")
                    rpt = False
                ElseIf Me.EmpleadoTableAdapter.roll(TextBox1.Text, TextBox2.Text).Equals("Administrador") Then
                    MessageBox.Show("admin")
                    rpt = True
                End If
            Catch ex As Exception
            End Try
            If Me.EmpleadoTableAdapter.verify(TextBox1.Text, TextBox2.Text).Value > 0 Then
                a = Me.EmpleadoTableAdapter.id_empleado(TextBox1.Text, TextBox2.Text).Value
                MessageBox.Show("Bienvenido")
                Inicio.Show()
                Me.Hide()
            Else
                MessageBox.Show("Usuario o contraseña incorrecta")
            End If
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        F_infoCliente.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class