<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Proveedor
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
        Dim Id_proveedorLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim DepartamentoLabel As System.Windows.Forms.Label
        Dim UbicacionLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.label7 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.UbicacionTextBox = New System.Windows.Forms.TextBox()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbSistemaDataSet1 = New Sistema2.dbSistemaDataSet1()
        Me.DepartamentoTextBox = New System.Windows.Forms.TextBox()
        Me.PaisTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.Id_proveedorTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.ProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedorTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.proveedorTableAdapter()
        Me.TableAdapterManager = New Sistema2.dbSistemaDataSet1TableAdapters.TableAdapterManager()
        Id_proveedorLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        DepartamentoLabel = New System.Windows.Forms.Label()
        UbicacionLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbSistemaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_proveedorLabel
        '
        Id_proveedorLabel.AutoSize = True
        Id_proveedorLabel.ForeColor = System.Drawing.Color.White
        Id_proveedorLabel.Location = New System.Drawing.Point(84, 186)
        Id_proveedorLabel.Name = "Id_proveedorLabel"
        Id_proveedorLabel.Size = New System.Drawing.Size(69, 13)
        Id_proveedorLabel.TabIndex = 1
        Id_proveedorLabel.Text = "id proveedor:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.ForeColor = System.Drawing.Color.White
        NombreLabel.Location = New System.Drawing.Point(84, 212)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "nombre:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.ForeColor = System.Drawing.Color.White
        TelefonoLabel.Location = New System.Drawing.Point(84, 238)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(48, 13)
        TelefonoLabel.TabIndex = 5
        TelefonoLabel.Text = "telefono:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.ForeColor = System.Drawing.Color.White
        EmailLabel.Location = New System.Drawing.Point(84, 264)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 7
        EmailLabel.Text = "email:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.ForeColor = System.Drawing.Color.White
        PaisLabel.Location = New System.Drawing.Point(84, 290)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(29, 13)
        PaisLabel.TabIndex = 9
        PaisLabel.Text = "pais:"
        '
        'DepartamentoLabel
        '
        DepartamentoLabel.AutoSize = True
        DepartamentoLabel.ForeColor = System.Drawing.Color.White
        DepartamentoLabel.Location = New System.Drawing.Point(84, 316)
        DepartamentoLabel.Name = "DepartamentoLabel"
        DepartamentoLabel.Size = New System.Drawing.Size(75, 13)
        DepartamentoLabel.TabIndex = 11
        DepartamentoLabel.Text = "departamento:"
        '
        'UbicacionLabel
        '
        UbicacionLabel.AutoSize = True
        UbicacionLabel.ForeColor = System.Drawing.Color.White
        UbicacionLabel.Location = New System.Drawing.Point(84, 342)
        UbicacionLabel.Name = "UbicacionLabel"
        UbicacionLabel.Size = New System.Drawing.Size(56, 13)
        UbicacionLabel.TabIndex = 13
        UbicacionLabel.Text = "ubicacion:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.PictureBox18)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.ProveedorDataGridView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 611)
        Me.Panel1.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(116, 137)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(151, 25)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "BURGER HOT"
        '
        'PictureBox18
        '
        Me.PictureBox18.Image = Global.Sistema2.My.Resources.Resources._32382hamburger_98925
        Me.PictureBox18.Location = New System.Drawing.Point(32, 94)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(88, 68)
        Me.PictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox18.TabIndex = 75
        Me.PictureBox18.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 24)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "LISTADO DE PROVEEDOR"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel3.Controls.Add(Me.label7)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.UbicacionTextBox)
        Me.Panel3.Controls.Add(UbicacionLabel)
        Me.Panel3.Controls.Add(Me.DepartamentoTextBox)
        Me.Panel3.Controls.Add(DepartamentoLabel)
        Me.Panel3.Controls.Add(Me.PaisTextBox)
        Me.Panel3.Controls.Add(PaisLabel)
        Me.Panel3.Controls.Add(Me.EmailTextBox)
        Me.Panel3.Controls.Add(EmailLabel)
        Me.Panel3.Controls.Add(Id_proveedorLabel)
        Me.Panel3.Controls.Add(Me.TelefonoTextBox)
        Me.Panel3.Controls.Add(Me.Id_proveedorTextBox)
        Me.Panel3.Controls.Add(TelefonoLabel)
        Me.Panel3.Controls.Add(NombreLabel)
        Me.Panel3.Controls.Add(Me.NombreTextBox)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(945, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(339, 569)
        Me.Panel3.TabIndex = 49
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.ForeColor = System.Drawing.Color.White
        Me.label7.Location = New System.Drawing.Point(121, 156)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(98, 13)
        Me.label7.TabIndex = 61
        Me.label7.Text = "MANTENIMIENTO"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(28, 405)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(278, 23)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "Guardar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'UbicacionTextBox
        '
        Me.UbicacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "ubicacion", True))
        Me.UbicacionTextBox.Location = New System.Drawing.Point(165, 339)
        Me.UbicacionTextBox.Name = "UbicacionTextBox"
        Me.UbicacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UbicacionTextBox.TabIndex = 14
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "proveedor"
        Me.ProveedorBindingSource.DataSource = Me.DbSistemaDataSet1
        '
        'DbSistemaDataSet1
        '
        Me.DbSistemaDataSet1.DataSetName = "dbSistemaDataSet1"
        Me.DbSistemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartamentoTextBox
        '
        Me.DepartamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "departamento", True))
        Me.DepartamentoTextBox.Location = New System.Drawing.Point(165, 313)
        Me.DepartamentoTextBox.Name = "DepartamentoTextBox"
        Me.DepartamentoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DepartamentoTextBox.TabIndex = 12
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "pais", True))
        Me.PaisTextBox.Location = New System.Drawing.Point(165, 287)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PaisTextBox.TabIndex = 10
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(165, 261)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 8
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(165, 235)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 6
        '
        'Id_proveedorTextBox
        '
        Me.Id_proveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "id_proveedor", True))
        Me.Id_proveedorTextBox.Location = New System.Drawing.Point(165, 183)
        Me.Id_proveedorTextBox.Name = "Id_proveedorTextBox"
        Me.Id_proveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_proveedorTextBox.TabIndex = 2
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(165, 209)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel2.Controls.Add(Me.pictureBox4)
        Me.Panel2.Controls.Add(Me.pictureBox2)
        Me.Panel2.Controls.Add(Me.pictureBox1)
        Me.Panel2.Controls.Add(Me.pictureBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1284, 42)
        Me.Panel2.TabIndex = 48
        '
        'pictureBox4
        '
        Me.pictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox4.Image = Global.Sistema2.My.Resources.Resources.window_restore_icon_144027
        Me.pictureBox4.Location = New System.Drawing.Point(1226, 7)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(25, 29)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox4.TabIndex = 26
        Me.pictureBox4.TabStop = False
        Me.pictureBox4.Visible = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox2.Image = Global.Sistema2.My.Resources.Resources.maximizar
        Me.pictureBox2.Location = New System.Drawing.Point(1227, 7)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(24, 29)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 25
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox1.Image = Global.Sistema2.My.Resources.Resources.Cerrar
        Me.pictureBox1.Location = New System.Drawing.Point(1257, 7)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(24, 29)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 23
        Me.pictureBox1.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox3.Image = Global.Sistema2.My.Resources.Resources.minimizar
        Me.pictureBox3.Location = New System.Drawing.Point(1196, 7)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(24, 29)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox3.TabIndex = 24
        Me.pictureBox3.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(689, 170)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(143, 20)
        Me.TextBox1.TabIndex = 47
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(838, 169)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 46
        Me.Button5.Text = "Buscar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(32, 447)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(224, 23)
        Me.Button6.TabIndex = 44
        Me.Button6.Text = "Menú principal"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(689, 447)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(224, 23)
        Me.Button8.TabIndex = 43
        Me.Button8.Text = "Mostrar todo"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(468, 447)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(137, 23)
        Me.Button9.TabIndex = 42
        Me.Button9.Text = "Actualizar"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(317, 447)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(137, 23)
        Me.Button10.TabIndex = 41
        Me.Button10.Text = "Eliminar"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'ProveedorDataGridView
        '
        Me.ProveedorDataGridView.AutoGenerateColumns = False
        Me.ProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ProveedorDataGridView.DataSource = Me.ProveedorBindingSource
        Me.ProveedorDataGridView.Location = New System.Drawing.Point(32, 198)
        Me.ProveedorDataGridView.Name = "ProveedorDataGridView"
        Me.ProveedorDataGridView.Size = New System.Drawing.Size(881, 243)
        Me.ProveedorDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_proveedor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_proveedor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn3.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn4.HeaderText = "email"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "pais"
        Me.DataGridViewTextBoxColumn5.HeaderText = "pais"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "departamento"
        Me.DataGridViewTextBoxColumn6.HeaderText = "departamento"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ubicacion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ubicacion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cajaTableAdapter = Nothing
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.compraTableAdapter = Nothing
        Me.TableAdapterManager.detalle_facturaTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.forma_pagoTableAdapter = Nothing
        Me.TableAdapterManager.NumVentaTableAdapter = Nothing
        Me.TableAdapterManager.PagosTableAdapter = Nothing
        Me.TableAdapterManager.pedido1TableAdapter = Nothing
        Me.TableAdapterManager.pedido2TableAdapter = Nothing
        Me.TableAdapterManager.pedidoTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Me.ProveedorTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sistema2.dbSistemaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'F_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 611)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_Proveedor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbSistemaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DbSistemaDataSet1 As dbSistemaDataSet1
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As dbSistemaDataSet1TableAdapters.proveedorTableAdapter
    Friend WithEvents TableAdapterManager As dbSistemaDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Id_proveedorTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PaisTextBox As TextBox
    Friend WithEvents DepartamentoTextBox As TextBox
    Friend WithEvents UbicacionTextBox As TextBox
    Friend WithEvents ProveedorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Private WithEvents Label16 As Label
    Friend WithEvents PictureBox18 As PictureBox
    Private WithEvents label7 As Label
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents pictureBox3 As PictureBox
End Class
