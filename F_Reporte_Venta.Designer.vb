<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Reporte_Venta
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
        Me.button7 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.PictureBox18)
        Me.Panel1.Controls.Add(Me.button7)
        Me.Panel1.Controls.Add(Me.button6)
        Me.Panel1.Controls.Add(Me.button5)
        Me.Panel1.Controls.Add(Me.button4)
        Me.Panel1.Controls.Add(Me.button3)
        Me.Panel1.Controls.Add(Me.button2)
        Me.Panel1.Controls.Add(Me.button1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 611)
        Me.Panel1.TabIndex = 0
        '
        'button7
        '
        Me.button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button7.ForeColor = System.Drawing.Color.White
        Me.button7.Location = New System.Drawing.Point(61, 117)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(215, 23)
        Me.button7.TabIndex = 43
        Me.button7.Text = "Menú principal"
        Me.button7.UseVisualStyleBackColor = False
        '
        'button6
        '
        Me.button6.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button6.ForeColor = System.Drawing.Color.White
        Me.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button6.Location = New System.Drawing.Point(724, 390)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(151, 150)
        Me.button6.TabIndex = 42
        Me.button6.Text = "Informe de ventas por ultimas N ventas"
        Me.button6.UseVisualStyleBackColor = False
        '
        'button5
        '
        Me.button5.BackColor = System.Drawing.Color.Chocolate
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.ForeColor = System.Drawing.Color.White
        Me.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button5.Location = New System.Drawing.Point(420, 390)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(151, 150)
        Me.button5.TabIndex = 41
        Me.button5.Text = "Informe de ventas por primeras N ventas"
        Me.button5.UseVisualStyleBackColor = False
        '
        'button4
        '
        Me.button4.BackColor = System.Drawing.Color.RosyBrown
        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.ForeColor = System.Drawing.Color.White
        Me.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button4.Location = New System.Drawing.Point(961, 533)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(75, 75)
        Me.button4.TabIndex = 40
        Me.button4.Text = "Informe de ventas por numero de factura"
        Me.button4.UseVisualStyleBackColor = False
        Me.button4.Visible = False
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.LightCoral
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.Color.White
        Me.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button3.Location = New System.Drawing.Point(873, 203)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(151, 150)
        Me.button3.TabIndex = 39
        Me.button3.Text = "Informe de ventas por fecha"
        Me.button3.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.White
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button2.Location = New System.Drawing.Point(580, 203)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(151, 150)
        Me.button2.TabIndex = 38
        Me.button2.Text = "Informe de ventas por empleado"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.White
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button1.Location = New System.Drawing.Point(272, 203)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(151, 150)
        Me.button1.TabIndex = 37
        Me.button1.Text = "Informe de ventas por cliente"
        Me.button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1284, 37)
        Me.Panel2.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(135, 86)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(151, 25)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "BURGER HOT"
        '
        'PictureBox18
        '
        Me.PictureBox18.Image = Global.Sistema2.My.Resources.Resources._32382hamburger_98925
        Me.PictureBox18.Location = New System.Drawing.Point(51, 43)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(88, 68)
        Me.PictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox18.TabIndex = 79
        Me.PictureBox18.TabStop = False
        '
        'F_Reporte_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 611)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Reporte_Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_Reporte_Venta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Private WithEvents button7 As Button
    Private WithEvents button6 As Button
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Friend WithEvents Panel2 As Panel
    Private WithEvents Label16 As Label
    Friend WithEvents PictureBox18 As PictureBox
End Class
