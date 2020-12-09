Public Class F_Registro
    Public a As Integer
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbSistemaDataSet1)
    End Sub
    Private Sub F_Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.DbSistemaDataSet1.cliente)
        NombreTextBox.Text = ""
        ApellidoTextBox.Text = ""
        TelefonoTextBox.Text = ""
        EmailTextBox.Text = ""
        PaisTextBox.Text = ""
        DepartamentoTextBox.Text = ""
        UbicacionTextBox.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        F_infoCliente.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.ClienteTableAdapter.insertarcliente(NombreTextBox.Text, ApellidoTextBox.Text, TelefonoTextBox.Text, EmailTextBox.Text, PaisTextBox.Text, DepartamentoTextBox.Text, UbicacionTextBox.Text)
            a = Me.ClienteTableAdapter.ClienteActual()
            MessageBox.Show("CODIGO: " & a)
            F_infoCliente.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("No dejar campos vacios")
        End Try
    End Sub
    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            End
        Else
        End If
    End Sub
End Class