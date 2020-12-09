<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_pago
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
        Dim Id_formaPagoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim IdnumPagoLabel As System.Windows.Forms.Label
        Dim Id_tipopagoLabel As System.Windows.Forms.Label
        Dim Id_empleadoLabel As System.Windows.Forms.Label
        Dim MontoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel1 As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.IdnumPagoTextBox = New System.Windows.Forms.TextBox()
        Me.Id_tipopagoTextBox = New System.Windows.Forms.TextBox()
        Me.Id_empleadoTextBox = New System.Windows.Forms.TextBox()
        Me.MontoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox1 = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PagosDataGridView = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Id_formaPagoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.Forma_pagoDataGridView = New System.Windows.Forms.DataGridView()
        Me.Forma_pagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbSistemaDataSet1 = New Sistema2.dbSistemaDataSet1()
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Forma_pagoTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.forma_pagoTableAdapter()
        Me.TableAdapterManager = New Sistema2.dbSistemaDataSet1TableAdapters.TableAdapterManager()
        Me.PagosTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.PagosTableAdapter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Id_formaPagoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        IdnumPagoLabel = New System.Windows.Forms.Label()
        Id_tipopagoLabel = New System.Windows.Forms.Label()
        Id_empleadoLabel = New System.Windows.Forms.Label()
        MontoLabel = New System.Windows.Forms.Label()
        DescripcionLabel1 = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Forma_pagoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Forma_pagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbSistemaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_formaPagoLabel
        '
        Id_formaPagoLabel.AutoSize = True
        Id_formaPagoLabel.Location = New System.Drawing.Point(128, 86)
        Id_formaPagoLabel.Name = "Id_formaPagoLabel"
        Id_formaPagoLabel.Size = New System.Drawing.Size(75, 13)
        Id_formaPagoLabel.TabIndex = 1
        Id_formaPagoLabel.Text = "id forma Pago:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(128, 112)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(64, 13)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "descripcion:"
        '
        'IdnumPagoLabel
        '
        IdnumPagoLabel.AutoSize = True
        IdnumPagoLabel.ForeColor = System.Drawing.Color.White
        IdnumPagoLabel.Location = New System.Drawing.Point(53, 308)
        IdnumPagoLabel.Name = "IdnumPagoLabel"
        IdnumPagoLabel.Size = New System.Drawing.Size(66, 13)
        IdnumPagoLabel.TabIndex = 1
        IdnumPagoLabel.Text = "idnum Pago:"
        '
        'Id_tipopagoLabel
        '
        Id_tipopagoLabel.AutoSize = True
        Id_tipopagoLabel.ForeColor = System.Drawing.Color.White
        Id_tipopagoLabel.Location = New System.Drawing.Point(53, 334)
        Id_tipopagoLabel.Name = "Id_tipopagoLabel"
        Id_tipopagoLabel.Size = New System.Drawing.Size(62, 13)
        Id_tipopagoLabel.TabIndex = 3
        Id_tipopagoLabel.Text = "id tipopago:"
        '
        'Id_empleadoLabel
        '
        Id_empleadoLabel.AutoSize = True
        Id_empleadoLabel.ForeColor = System.Drawing.Color.White
        Id_empleadoLabel.Location = New System.Drawing.Point(53, 360)
        Id_empleadoLabel.Name = "Id_empleadoLabel"
        Id_empleadoLabel.Size = New System.Drawing.Size(67, 13)
        Id_empleadoLabel.TabIndex = 5
        Id_empleadoLabel.Text = "id empleado:"
        '
        'MontoLabel
        '
        MontoLabel.AutoSize = True
        MontoLabel.ForeColor = System.Drawing.Color.White
        MontoLabel.Location = New System.Drawing.Point(53, 386)
        MontoLabel.Name = "MontoLabel"
        MontoLabel.Size = New System.Drawing.Size(39, 13)
        MontoLabel.TabIndex = 7
        MontoLabel.Text = "monto:"
        '
        'DescripcionLabel1
        '
        DescripcionLabel1.AutoSize = True
        DescripcionLabel1.ForeColor = System.Drawing.Color.White
        DescripcionLabel1.Location = New System.Drawing.Point(53, 412)
        DescripcionLabel1.Name = "DescripcionLabel1"
        DescripcionLabel1.Size = New System.Drawing.Size(64, 13)
        DescripcionLabel1.TabIndex = 9
        DescripcionLabel1.Text = "descripcion:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(566, 258)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(37, 13)
        FechaLabel.TabIndex = 11
        FechaLabel.Text = "fecha:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Forma_pagoDataGridView)
        Me.Panel1.Controls.Add(Me.FechaDateTimePicker)
        Me.Panel1.Controls.Add(FechaLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 611)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Button12)
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.Button9)
        Me.Panel2.Controls.Add(Me.Button10)
        Me.Panel2.Controls.Add(Me.PagosDataGridView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 252)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1284, 359)
        Me.Panel2.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(615, 58)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(143, 20)
        Me.TextBox2.TabIndex = 46
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.ForeColor = System.Drawing.Color.White
        Me.Button12.Location = New System.Drawing.Point(764, 57)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 23)
        Me.Button12.TabIndex = 45
        Me.Button12.Text = "Buscar"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(34, 463)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(330, 23)
        Me.Button11.TabIndex = 44
        Me.Button11.Text = "Guardar"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(710, 236)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(129, 23)
        Me.Button8.TabIndex = 42
        Me.Button8.Text = "Mostrar todo"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(357, 236)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(157, 23)
        Me.Button9.TabIndex = 41
        Me.Button9.Text = "Actualizar"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(520, 236)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(157, 23)
        Me.Button10.TabIndex = 40
        Me.Button10.Text = "Eliminar"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'IdnumPagoTextBox
        '
        Me.IdnumPagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "idnumPago", True))
        Me.IdnumPagoTextBox.Location = New System.Drawing.Point(126, 305)
        Me.IdnumPagoTextBox.Name = "IdnumPagoTextBox"
        Me.IdnumPagoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdnumPagoTextBox.TabIndex = 2
        '
        'Id_tipopagoTextBox
        '
        Me.Id_tipopagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "id_tipopago", True))
        Me.Id_tipopagoTextBox.Location = New System.Drawing.Point(126, 331)
        Me.Id_tipopagoTextBox.Name = "Id_tipopagoTextBox"
        Me.Id_tipopagoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_tipopagoTextBox.TabIndex = 4
        '
        'Id_empleadoTextBox
        '
        Me.Id_empleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "id_empleado", True))
        Me.Id_empleadoTextBox.Location = New System.Drawing.Point(126, 357)
        Me.Id_empleadoTextBox.Name = "Id_empleadoTextBox"
        Me.Id_empleadoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_empleadoTextBox.TabIndex = 6
        '
        'MontoTextBox
        '
        Me.MontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "monto", True))
        Me.MontoTextBox.Location = New System.Drawing.Point(126, 383)
        Me.MontoTextBox.Name = "MontoTextBox"
        Me.MontoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MontoTextBox.TabIndex = 8
        '
        'DescripcionTextBox1
        '
        Me.DescripcionTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "descripcion", True))
        Me.DescripcionTextBox1.Location = New System.Drawing.Point(126, 409)
        Me.DescripcionTextBox1.Name = "DescripcionTextBox1"
        Me.DescripcionTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.DescripcionTextBox1.TabIndex = 10
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PagosBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(639, 254)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 12
        '
        'PagosDataGridView
        '
        Me.PagosDataGridView.AutoGenerateColumns = False
        Me.PagosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.PagosDataGridView.DataSource = Me.PagosBindingSource
        Me.PagosDataGridView.Location = New System.Drawing.Point(197, 86)
        Me.PagosDataGridView.Name = "PagosDataGridView"
        Me.PagosDataGridView.Size = New System.Drawing.Size(642, 144)
        Me.PagosDataGridView.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(660, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 11
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(766, 55)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(73, 23)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Buscar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(643, 211)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(73, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Eliminar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(564, 211)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(73, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Actualizar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(12, 56)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(151, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Menu principal"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(738, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Mostrar todo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(131, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Id_formaPagoTextBox
        '
        Me.Id_formaPagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Forma_pagoBindingSource, "id_formaPago", True))
        Me.Id_formaPagoTextBox.Location = New System.Drawing.Point(209, 83)
        Me.Id_formaPagoTextBox.Name = "Id_formaPagoTextBox"
        Me.Id_formaPagoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_formaPagoTextBox.TabIndex = 2
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Forma_pagoBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(209, 109)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextBox.TabIndex = 4
        '
        'Forma_pagoDataGridView
        '
        Me.Forma_pagoDataGridView.AutoGenerateColumns = False
        Me.Forma_pagoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Forma_pagoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Forma_pagoDataGridView.DataSource = Me.Forma_pagoBindingSource
        Me.Forma_pagoDataGridView.Location = New System.Drawing.Point(446, 84)
        Me.Forma_pagoDataGridView.Name = "Forma_pagoDataGridView"
        Me.Forma_pagoDataGridView.Size = New System.Drawing.Size(393, 121)
        Me.Forma_pagoDataGridView.TabIndex = 0
        '
        'Forma_pagoBindingSource
        '
        Me.Forma_pagoBindingSource.DataMember = "forma_pago"
        Me.Forma_pagoBindingSource.DataSource = Me.DbSistemaDataSet1
        '
        'DbSistemaDataSet1
        '
        Me.DbSistemaDataSet1.DataSetName = "dbSistemaDataSet1"
        Me.DbSistemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PagosBindingSource
        '
        Me.PagosBindingSource.DataMember = "Pagos"
        Me.PagosBindingSource.DataSource = Me.DbSistemaDataSet1
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idnumPago"
        Me.DataGridViewTextBoxColumn3.HeaderText = "idnumPago"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "id_tipopago"
        Me.DataGridViewTextBoxColumn4.HeaderText = "id_tipopago"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id_empleado"
        Me.DataGridViewTextBoxColumn5.HeaderText = "id_empleado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "monto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "monto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn8.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_formaPago"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_formaPago"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Forma_pagoTableAdapter
        '
        Me.Forma_pagoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.forma_pagoTableAdapter = Me.Forma_pagoTableAdapter
        Me.TableAdapterManager.NumVentaTableAdapter = Nothing
        Me.TableAdapterManager.PagosTableAdapter = Me.PagosTableAdapter
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema2.dbSistemaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PagosTableAdapter
        '
        Me.PagosTableAdapter.ClearBeforeFill = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel3.Controls.Add(Me.pictureBox4)
        Me.Panel3.Controls.Add(Me.pictureBox2)
        Me.Panel3.Controls.Add(Me.pictureBox1)
        Me.Panel3.Controls.Add(Me.pictureBox3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1284, 32)
        Me.Panel3.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.DescripcionTextBox)
        Me.Panel4.Controls.Add(Me.Button11)
        Me.Panel4.Controls.Add(DescripcionLabel)
        Me.Panel4.Controls.Add(Me.Id_formaPagoTextBox)
        Me.Panel4.Controls.Add(Id_formaPagoLabel)
        Me.Panel4.Controls.Add(Me.DescripcionTextBox1)
        Me.Panel4.Controls.Add(DescripcionLabel1)
        Me.Panel4.Controls.Add(Me.MontoTextBox)
        Me.Panel4.Controls.Add(IdnumPagoLabel)
        Me.Panel4.Controls.Add(MontoLabel)
        Me.Panel4.Controls.Add(Me.Id_empleadoTextBox)
        Me.Panel4.Controls.Add(Me.IdnumPagoTextBox)
        Me.Panel4.Controls.Add(Id_empleadoLabel)
        Me.Panel4.Controls.Add(Me.Id_tipopagoTextBox)
        Me.Panel4.Controls.Add(Id_tipopagoLabel)
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(893, 35)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(391, 576)
        Me.Panel4.TabIndex = 14
        '
        'pictureBox4
        '
        Me.pictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox4.Image = Global.Sistema2.My.Resources.Resources.window_restore_icon_144027
        Me.pictureBox4.Location = New System.Drawing.Point(1226, 0)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(25, 29)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox4.TabIndex = 18
        Me.pictureBox4.TabStop = False
        Me.pictureBox4.Visible = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox1.Image = Global.Sistema2.My.Resources.Resources.Cerrar
        Me.pictureBox1.Location = New System.Drawing.Point(1257, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(24, 29)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 15
        Me.pictureBox1.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox3.Image = Global.Sistema2.My.Resources.Resources.minimizar
        Me.pictureBox3.Location = New System.Drawing.Point(1196, 0)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(24, 29)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox3.TabIndex = 16
        Me.pictureBox3.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox2.Image = Global.Sistema2.My.Resources.Resources.maximizar
        Me.pictureBox2.Location = New System.Drawing.Point(1227, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(24, 29)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 17
        Me.pictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(442, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 24)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "METODOS DE PAGO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(193, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 24)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "LISTADO DE PAGOS"
        '
        'F_pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1284, 611)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_pago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_pago"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Forma_pagoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Forma_pagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbSistemaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DbSistemaDataSet1 As dbSistemaDataSet1
    Friend WithEvents Forma_pagoBindingSource As BindingSource
    Friend WithEvents Forma_pagoTableAdapter As dbSistemaDataSet1TableAdapters.forma_pagoTableAdapter
    Friend WithEvents TableAdapterManager As dbSistemaDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Forma_pagoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Id_formaPagoTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PagosTableAdapter As dbSistemaDataSet1TableAdapters.PagosTableAdapter
    Friend WithEvents PagosBindingSource As BindingSource
    Friend WithEvents IdnumPagoTextBox As TextBox
    Friend WithEvents Id_tipopagoTextBox As TextBox
    Friend WithEvents Id_empleadoTextBox As TextBox
    Friend WithEvents MontoTextBox As TextBox
    Friend WithEvents DescripcionTextBox1 As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents PagosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button12 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents pictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
