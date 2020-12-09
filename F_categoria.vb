Public Class F_categoria
    Private Sub CategoriaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CategoriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbSistemaDataSet1)

    End Sub

    Private Sub F_categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbSistemaDataSet1.categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.DbSistemaDataSet1.categoria)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.CategoriaTableAdapter.insertarcategoria(Tipo_categoriaTextBox.Text)
            Me.CategoriaTableAdapter.Fill(Me.DbSistemaDataSet1.categoria)
        Catch ex As Exception
            MessageBox.Show("No se pudo guardar")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.CategoriaTableAdapter.UpdateQuery(Tipo_categoriaTextBox.Text, Id_categoriaTextBox.Text, Id_categoriaTextBox.Text, Id_categoriaTextBox.Text)
            Me.CategoriaTableAdapter.Fill(Me.DbSistemaDataSet1.categoria)
        Catch ex As Exception
            MessageBox.Show("No se pudo actualizar")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.CategoriaTableAdapter.eliminarcategoria(Id_categoriaTextBox.Text)
            Me.CategoriaTableAdapter.Fill(Me.DbSistemaDataSet1.categoria)
        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar")
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Me.CategoriaDataGridView.DataSource = Me.CategoriaTableAdapter.buscarcategoria(TextBox1.Text)
        Catch ex As Exception
            MessageBox.Show("No se pudo mostrar")
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CategoriaDataGridView.DataSource = Me.CategoriaTableAdapter.vercategoria()
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
    End Sub
End Class