<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_datos_reporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.dateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(710, 37)
        Me.Panel1.TabIndex = 0
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(413, 90)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(62, 13)
        Me.label4.TabIndex = 16
        Me.label4.Text = "Fecha Final"
        Me.label4.Visible = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(166, 87)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(66, 13)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Fecha inicial"
        Me.label3.Visible = False
        '
        'dateTimePicker2
        '
        Me.dateTimePicker2.Location = New System.Drawing.Point(416, 106)
        Me.dateTimePicker2.Name = "dateTimePicker2"
        Me.dateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.dateTimePicker2.TabIndex = 14
        Me.dateTimePicker2.Visible = False
        '
        'dateTimePicker1
        '
        Me.dateTimePicker1.Location = New System.Drawing.Point(166, 106)
        Me.dateTimePicker1.Name = "dateTimePicker1"
        Me.dateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.dateTimePicker1.TabIndex = 13
        Me.dateTimePicker1.Visible = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.Green
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.ForeColor = System.Drawing.Color.White
        Me.button1.Location = New System.Drawing.Point(339, 177)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(102, 23)
        Me.button1.TabIndex = 12
        Me.button1.Text = "Ver el informe"
        Me.button1.UseVisualStyleBackColor = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(110, 152)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(0, 20)
        Me.label2.TabIndex = 11
        Me.label2.Visible = False
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(310, 151)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(144, 20)
        Me.textBox1.TabIndex = 10
        Me.textBox1.Visible = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox1.Image = Global.Sistema2.My.Resources.Resources.Cerrar
        Me.pictureBox1.Location = New System.Drawing.Point(683, 5)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(24, 29)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 20
        Me.pictureBox1.TabStop = False
        '
        'F_datos_reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(710, 275)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.dateTimePicker2)
        Me.Controls.Add(Me.dateTimePicker1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_datos_reporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_datos_reporte"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents dateTimePicker2 As DateTimePicker
    Private WithEvents dateTimePicker1 As DateTimePicker
    Private WithEvents button1 As Button
    Private WithEvents label2 As Label
    Private WithEvents textBox1 As TextBox
    Private WithEvents pictureBox1 As PictureBox
End Class
