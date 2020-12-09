<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Registro
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
        Me.components = New System.ComponentModel.Container()
        Dim Id_clienteLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim DepartamentoLabel As System.Windows.Forms.Label
        Dim UbicacionLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DbSistemaDataSet1 = New Sistema2.dbSistemaDataSet1()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New Sistema2.dbSistemaDataSet1TableAdapters.TableAdapterManager()
        Me.Id_clienteTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PaisTextBox = New System.Windows.Forms.TextBox()
        Me.DepartamentoTextBox = New System.Windows.Forms.TextBox()
        Me.UbicacionTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Id_clienteLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        DepartamentoLabel = New System.Windows.Forms.Label()
        UbicacionLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DbSistemaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.label18)
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.PictureBox18)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Id_clienteLabel)
        Me.Panel1.Controls.Add(Me.Id_clienteTextBox)
        Me.Panel1.Controls.Add(NombreLabel)
        Me.Panel1.Controls.Add(Me.NombreTextBox)
        Me.Panel1.Controls.Add(ApellidoLabel)
        Me.Panel1.Controls.Add(Me.ApellidoTextBox)
        Me.Panel1.Controls.Add(TelefonoLabel)
        Me.Panel1.Controls.Add(Me.TelefonoTextBox)
        Me.Panel1.Controls.Add(EmailLabel)
        Me.Panel1.Controls.Add(Me.EmailTextBox)
        Me.Panel1.Controls.Add(PaisLabel)
        Me.Panel1.Controls.Add(Me.PaisTextBox)
        Me.Panel1.Controls.Add(DepartamentoLabel)
        Me.Panel1.Controls.Add(Me.DepartamentoTextBox)
        Me.Panel1.Controls.Add(UbicacionLabel)
        Me.Panel1.Controls.Add(Me.UbicacionTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(717, 420)
        Me.Panel1.TabIndex = 0
        '
        'DbSistemaDataSet1
        '
        Me.DbSistemaDataSet1.DataSetName = "dbSistemaDataSet1"
        Me.DbSistemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.DbSistemaDataSet1
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cajaTableAdapter = Nothing
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.compraTableAdapter = Nothing
        Me.TableAdapterManager.detalle_facturaTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.forma_pagoTableAdapter = Nothing
        Me.TableAdapterManager.NumVentaTableAdapter = Nothing
        Me.TableAdapterManager.PagosTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema2.dbSistemaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Id_clienteLabel
        '
        Id_clienteLabel.AutoSize = True
        Id_clienteLabel.ForeColor = System.Drawing.Color.White
        Id_clienteLabel.Location = New System.Drawing.Point(524, 45)
        Id_clienteLabel.Name = "Id_clienteLabel"
        Id_clienteLabel.Size = New System.Drawing.Size(52, 13)
        Id_clienteLabel.TabIndex = 0
        Id_clienteLabel.Text = "id cliente:"
        Id_clienteLabel.Visible = False
        '
        'Id_clienteTextBox
        '
        Me.Id_clienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "id_cliente", True))
        Me.Id_clienteTextBox.Location = New System.Drawing.Point(605, 42)
        Me.Id_clienteTextBox.Name = "Id_clienteTextBox"
        Me.Id_clienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_clienteTextBox.TabIndex = 1
        Me.Id_clienteTextBox.Visible = False
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.ForeColor = System.Drawing.Color.White
        NombreLabel.Location = New System.Drawing.Point(262, 173)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(46, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "nombre*"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(343, 170)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 3
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.ForeColor = System.Drawing.Color.White
        ApellidoLabel.Location = New System.Drawing.Point(262, 199)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 4
        ApellidoLabel.Text = "apellido*"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(343, 196)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox.TabIndex = 5
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.ForeColor = System.Drawing.Color.White
        TelefonoLabel.Location = New System.Drawing.Point(262, 225)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(49, 13)
        TelefonoLabel.TabIndex = 6
        TelefonoLabel.Text = "telefono*"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(343, 222)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 7
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.ForeColor = System.Drawing.Color.White
        EmailLabel.Location = New System.Drawing.Point(262, 251)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 8
        EmailLabel.Text = "email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(343, 248)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 9
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.ForeColor = System.Drawing.Color.White
        PaisLabel.Location = New System.Drawing.Point(262, 277)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(30, 13)
        PaisLabel.TabIndex = 10
        PaisLabel.Text = "pais*"
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "pais", True))
        Me.PaisTextBox.Location = New System.Drawing.Point(343, 274)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PaisTextBox.TabIndex = 11
        '
        'DepartamentoLabel
        '
        DepartamentoLabel.AutoSize = True
        DepartamentoLabel.ForeColor = System.Drawing.Color.White
        DepartamentoLabel.Location = New System.Drawing.Point(262, 303)
        DepartamentoLabel.Name = "DepartamentoLabel"
        DepartamentoLabel.Size = New System.Drawing.Size(76, 13)
        DepartamentoLabel.TabIndex = 12
        DepartamentoLabel.Text = "departamento*"
        '
        'DepartamentoTextBox
        '
        Me.DepartamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "departamento", True))
        Me.DepartamentoTextBox.Location = New System.Drawing.Point(343, 300)
        Me.DepartamentoTextBox.Name = "DepartamentoTextBox"
        Me.DepartamentoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DepartamentoTextBox.TabIndex = 13
        '
        'UbicacionLabel
        '
        UbicacionLabel.AutoSize = True
        UbicacionLabel.ForeColor = System.Drawing.Color.White
        UbicacionLabel.Location = New System.Drawing.Point(262, 329)
        UbicacionLabel.Name = "UbicacionLabel"
        UbicacionLabel.Size = New System.Drawing.Size(57, 13)
        UbicacionLabel.TabIndex = 14
        UbicacionLabel.Text = "ubicacion*"
        '
        'UbicacionTextBox
        '
        Me.UbicacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "ubicacion", True))
        Me.UbicacionTextBox.Location = New System.Drawing.Point(343, 326)
        Me.UbicacionTextBox.Name = "UbicacionTextBox"
        Me.UbicacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UbicacionTextBox.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel2.Controls.Add(Me.pictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(717, 36)
        Me.Panel2.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(91, 85)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(151, 25)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "BURGER HOT"
        '
        'PictureBox18
        '
        Me.PictureBox18.Image = Global.Sistema2.My.Resources.Resources._32382hamburger_98925
        Me.PictureBox18.Location = New System.Drawing.Point(5, 42)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(88, 68)
        Me.PictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox18.TabIndex = 77
        Me.PictureBox18.TabStop = False
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.ForeColor = System.Drawing.Color.White
        Me.label18.Location = New System.Drawing.Point(100, 123)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(111, 13)
        Me.label18.TabIndex = 80
        Me.label18.Text = "Campos obligatorios(*)"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(100, 110)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(196, 13)
        Me.label1.TabIndex = 79
        Me.label1.Text = "RELLENE LOS SIGUIENTES CAMPOS"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(368, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 81
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(265, 366)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 82
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox1.Image = Global.Sistema2.My.Resources.Resources.Cerrar
        Me.pictureBox1.Location = New System.Drawing.Point(690, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(24, 29)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 20
        Me.pictureBox1.TabStop = False
        '
        'F_Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 420)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_Registro"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DbSistemaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DbSistemaDataSet1 As dbSistemaDataSet1
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As dbSistemaDataSet1TableAdapters.clienteTableAdapter
    Friend WithEvents TableAdapterManager As dbSistemaDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Id_clienteTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PaisTextBox As TextBox
    Friend WithEvents DepartamentoTextBox As TextBox
    Friend WithEvents UbicacionTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Private WithEvents Label16 As Label
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Private WithEvents label18 As Label
    Private WithEvents label1 As Label
    Private WithEvents pictureBox1 As PictureBox
End Class
