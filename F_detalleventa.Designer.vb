<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_detalleventa
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Id_numVentaLabel As System.Windows.Forms.Label
        Dim Id_empleadoLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim MontoApagarLabel As System.Windows.Forms.Label
        Dim VueltoLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.button4 = New System.Windows.Forms.Button()
        Me.NumeroNITTextBox = New System.Windows.Forms.TextBox()
        Me.Detalle_facturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbSistemaDataSet1 = New Sistema2.dbSistemaDataSet1()
        Me.Id_clienteTextBox = New System.Windows.Forms.TextBox()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.button5 = New System.Windows.Forms.Button()
        Me.Id_productoTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadDeProductoTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_unitarioTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.label10 = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Button()
        Me.Id_tipoPagoTextBox = New System.Windows.Forms.TextBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Id_numVentaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_empleadoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.MontoApagarTextBox = New System.Windows.Forms.TextBox()
        Me.VueltoTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Detalle_facturaTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.detalle_facturaTableAdapter()
        Me.TableAdapterManager = New Sistema2.dbSistemaDataSet1TableAdapters.TableAdapterManager()
        Me.ClienteTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.clienteTableAdapter()
        Me.Forma_pagoTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.forma_pagoTableAdapter()
        Me.ProductoTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.productoTableAdapter()
        Me.Forma_pagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NumVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NumVentaTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.NumVentaTableAdapter()
        Me.button7 = New System.Windows.Forms.Button()
        Id_numVentaLabel = New System.Windows.Forms.Label()
        Id_empleadoLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        MontoApagarLabel = New System.Windows.Forms.Label()
        VueltoLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.Detalle_facturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbSistemaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Forma_pagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_numVentaLabel
        '
        Id_numVentaLabel.AutoSize = True
        Id_numVentaLabel.ForeColor = System.Drawing.Color.White
        Id_numVentaLabel.Location = New System.Drawing.Point(926, 339)
        Id_numVentaLabel.Name = "Id_numVentaLabel"
        Id_numVentaLabel.Size = New System.Drawing.Size(72, 13)
        Id_numVentaLabel.TabIndex = 1
        Id_numVentaLabel.Text = "id num Venta:"
        Id_numVentaLabel.Visible = False
        '
        'Id_empleadoLabel
        '
        Id_empleadoLabel.AutoSize = True
        Id_empleadoLabel.ForeColor = System.Drawing.Color.White
        Id_empleadoLabel.Location = New System.Drawing.Point(926, 369)
        Id_empleadoLabel.Name = "Id_empleadoLabel"
        Id_empleadoLabel.Size = New System.Drawing.Size(67, 13)
        Id_empleadoLabel.TabIndex = 7
        Id_empleadoLabel.Text = "id empleado:"
        Id_empleadoLabel.Visible = False
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.ForeColor = System.Drawing.Color.White
        FechaLabel.Location = New System.Drawing.Point(926, 396)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(37, 13)
        FechaLabel.TabIndex = 11
        FechaLabel.Text = "fecha:"
        FechaLabel.Visible = False
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.ForeColor = System.Drawing.Color.White
        TotalLabel.Location = New System.Drawing.Point(521, 399)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(42, 13)
        TotalLabel.TabIndex = 19
        TotalLabel.Text = "TOTAL"
        '
        'MontoApagarLabel
        '
        MontoApagarLabel.AutoSize = True
        MontoApagarLabel.ForeColor = System.Drawing.Color.White
        MontoApagarLabel.Location = New System.Drawing.Point(522, 421)
        MontoApagarLabel.Name = "MontoApagarLabel"
        MontoApagarLabel.Size = New System.Drawing.Size(80, 13)
        MontoApagarLabel.TabIndex = 21
        MontoApagarLabel.Text = "Monto a pagar*"
        '
        'VueltoLabel
        '
        VueltoLabel.AutoSize = True
        VueltoLabel.ForeColor = System.Drawing.Color.White
        VueltoLabel.Location = New System.Drawing.Point(926, 421)
        VueltoLabel.Name = "VueltoLabel"
        VueltoLabel.Size = New System.Drawing.Size(39, 13)
        VueltoLabel.TabIndex = 23
        VueltoLabel.Text = "vuelto:"
        VueltoLabel.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.button7)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.PictureBox18)
        Me.Panel1.Controls.Add(Me.dataGridView1)
        Me.Panel1.Controls.Add(Me.button2)
        Me.Panel1.Controls.Add(Me.button1)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.label18)
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Controls.Add(Id_numVentaLabel)
        Me.Panel1.Controls.Add(Me.Id_numVentaTextBox)
        Me.Panel1.Controls.Add(Id_empleadoLabel)
        Me.Panel1.Controls.Add(Me.Id_empleadoTextBox)
        Me.Panel1.Controls.Add(FechaLabel)
        Me.Panel1.Controls.Add(Me.FechaDateTimePicker)
        Me.Panel1.Controls.Add(TotalLabel)
        Me.Panel1.Controls.Add(Me.TotalTextBox)
        Me.Panel1.Controls.Add(MontoApagarLabel)
        Me.Panel1.Controls.Add(Me.MontoApagarTextBox)
        Me.Panel1.Controls.Add(VueltoLabel)
        Me.Panel1.Controls.Add(Me.VueltoTextBox)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1268, 687)
        Me.Panel1.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(111, 58)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(151, 25)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "BURGER HOT"
        '
        'PictureBox18
        '
        Me.PictureBox18.Image = Global.Sistema2.My.Resources.Resources._32382hamburger_98925
        Me.PictureBox18.Location = New System.Drawing.Point(17, 58)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(88, 68)
        Me.PictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox18.TabIndex = 73
        Me.PictureBox18.TabStop = False
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.AllowUserToOrderColumns = True
        Me.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(94, 450)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.Size = New System.Drawing.Size(1110, 81)
        Me.dataGridView1.TabIndex = 50
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button2.Enabled = False
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.ForeColor = System.Drawing.Color.Black
        Me.button2.Location = New System.Drawing.Point(762, 537)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(442, 23)
        Me.button2.TabIndex = 49
        Me.button2.Text = "Facturar"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.ForeColor = System.Drawing.Color.Black
        Me.button1.Location = New System.Drawing.Point(94, 537)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(464, 23)
        Me.button1.TabIndex = 48
        Me.button1.Text = "Agregar"
        Me.button1.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel5.Controls.Add(Me.label2)
        Me.Panel5.Controls.Add(Me.label14)
        Me.Panel5.Controls.Add(Me.button4)
        Me.Panel5.Controls.Add(Me.NumeroNITTextBox)
        Me.Panel5.Controls.Add(Me.Id_clienteTextBox)
        Me.Panel5.Location = New System.Drawing.Point(929, 154)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(264, 232)
        Me.Panel5.TabIndex = 47
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(21, 53)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(62, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "id cliente (*)"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.ForeColor = System.Drawing.Color.White
        Me.label14.Location = New System.Drawing.Point(21, 79)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(28, 13)
        Me.label14.TabIndex = 28
        Me.label14.Text = "NIT "
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(24, 157)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(216, 37)
        Me.button4.TabIndex = 38
        Me.button4.Text = "Verificar "
        Me.button4.UseVisualStyleBackColor = True
        '
        'NumeroNITTextBox
        '
        Me.NumeroNITTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_facturaBindingSource, "numeroNIT", True))
        Me.NumeroNITTextBox.Location = New System.Drawing.Point(116, 76)
        Me.NumeroNITTextBox.Name = "NumeroNITTextBox"
        Me.NumeroNITTextBox.Size = New System.Drawing.Size(97, 20)
        Me.NumeroNITTextBox.TabIndex = 18
        '
        'Detalle_facturaBindingSource
        '
        Me.Detalle_facturaBindingSource.DataMember = "detalle_factura"
        Me.Detalle_facturaBindingSource.DataSource = Me.DbSistemaDataSet1
        '
        'DbSistemaDataSet1
        '
        Me.DbSistemaDataSet1.DataSetName = "dbSistemaDataSet1"
        Me.DbSistemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Id_clienteTextBox
        '
        Me.Id_clienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_facturaBindingSource, "id_cliente", True))
        Me.Id_clienteTextBox.Location = New System.Drawing.Point(116, 46)
        Me.Id_clienteTextBox.Name = "Id_clienteTextBox"
        Me.Id_clienteTextBox.Size = New System.Drawing.Size(97, 20)
        Me.Id_clienteTextBox.TabIndex = 4
        '
        'panel4
        '
        Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.panel4.Controls.Add(Me.label12)
        Me.panel4.Controls.Add(Me.label3)
        Me.panel4.Controls.Add(Me.label6)
        Me.panel4.Controls.Add(Me.label13)
        Me.panel4.Controls.Add(Me.button5)
        Me.panel4.Controls.Add(Me.Id_productoTextBox)
        Me.panel4.Controls.Add(Me.CantidadDeProductoTextBox)
        Me.panel4.Controls.Add(Me.Precio_unitarioTextBox)
        Me.panel4.Location = New System.Drawing.Point(510, 154)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(264, 232)
        Me.panel4.TabIndex = 46
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.ForeColor = System.Drawing.Color.Red
        Me.label12.Location = New System.Drawing.Point(25, 209)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(216, 13)
        Me.label12.TabIndex = 47
        Me.label12.Text = "Verifica antes de agregar nuevos productos "
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(25, 59)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(73, 13)
        Me.label3.TabIndex = 3
        Me.label3.Text = "id producto (*)"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(25, 90)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(65, 13)
        Me.label6.TabIndex = 24
        Me.label6.Text = "Cantidad  (*)"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.ForeColor = System.Drawing.Color.White
        Me.label13.Location = New System.Drawing.Point(25, 123)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(80, 13)
        Me.label13.TabIndex = 26
        Me.label13.Text = "Precio unitario  "
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(28, 157)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(201, 40)
        Me.button5.TabIndex = 39
        Me.button5.Text = "Verificar "
        Me.button5.UseVisualStyleBackColor = True
        '
        'Id_productoTextBox
        '
        Me.Id_productoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_facturaBindingSource, "id_producto", True))
        Me.Id_productoTextBox.Location = New System.Drawing.Point(127, 52)
        Me.Id_productoTextBox.Name = "Id_productoTextBox"
        Me.Id_productoTextBox.Size = New System.Drawing.Size(97, 20)
        Me.Id_productoTextBox.TabIndex = 6
        '
        'CantidadDeProductoTextBox
        '
        Me.CantidadDeProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_facturaBindingSource, "cantidadDeProducto", True))
        Me.CantidadDeProductoTextBox.Location = New System.Drawing.Point(127, 87)
        Me.CantidadDeProductoTextBox.Name = "CantidadDeProductoTextBox"
        Me.CantidadDeProductoTextBox.Size = New System.Drawing.Size(97, 20)
        Me.CantidadDeProductoTextBox.TabIndex = 14
        '
        'Precio_unitarioTextBox
        '
        Me.Precio_unitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_facturaBindingSource, "precio_unitario", True))
        Me.Precio_unitarioTextBox.Location = New System.Drawing.Point(127, 116)
        Me.Precio_unitarioTextBox.Name = "Precio_unitarioTextBox"
        Me.Precio_unitarioTextBox.Size = New System.Drawing.Size(97, 20)
        Me.Precio_unitarioTextBox.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel3.Controls.Add(Me.label10)
        Me.Panel3.Controls.Add(Me.button3)
        Me.Panel3.Controls.Add(Me.Id_tipoPagoTextBox)
        Me.Panel3.Location = New System.Drawing.Point(83, 154)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(264, 232)
        Me.Panel3.TabIndex = 45
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.ForeColor = System.Drawing.Color.White
        Me.label10.Location = New System.Drawing.Point(15, 69)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(70, 13)
        Me.label10.TabIndex = 19
        Me.label10.Text = "id tipoPago(*)"
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(18, 157)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(227, 37)
        Me.button3.TabIndex = 13
        Me.button3.Text = "Verificar "
        Me.button3.UseVisualStyleBackColor = True
        '
        'Id_tipoPagoTextBox
        '
        Me.Id_tipoPagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_facturaBindingSource, "id_tipoPago", True))
        Me.Id_tipoPagoTextBox.Location = New System.Drawing.Point(91, 62)
        Me.Id_tipoPagoTextBox.Name = "Id_tipoPagoTextBox"
        Me.Id_tipoPagoTextBox.Size = New System.Drawing.Size(154, 20)
        Me.Id_tipoPagoTextBox.TabIndex = 10
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.ForeColor = System.Drawing.Color.White
        Me.label18.Location = New System.Drawing.Point(111, 105)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(111, 13)
        Me.label18.TabIndex = 44
        Me.label18.Text = "Campos obligatorios(*)"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(111, 92)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(196, 13)
        Me.label1.TabIndex = 43
        Me.label1.Text = "RELLENE LOS SIGUIENTES CAMPOS"
        '
        'Id_numVentaTextBox
        '
        Me.Id_numVentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_facturaBindingSource, "id_numVenta", True))
        Me.Id_numVentaTextBox.Location = New System.Drawing.Point(1046, 336)
        Me.Id_numVentaTextBox.Name = "Id_numVentaTextBox"
        Me.Id_numVentaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_numVentaTextBox.TabIndex = 2
        Me.Id_numVentaTextBox.Visible = False
        '
        'Id_empleadoTextBox
        '
        Me.Id_empleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_facturaBindingSource, "id_empleado", True))
        Me.Id_empleadoTextBox.Location = New System.Drawing.Point(1046, 366)
        Me.Id_empleadoTextBox.Name = "Id_empleadoTextBox"
        Me.Id_empleadoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_empleadoTextBox.TabIndex = 8
        Me.Id_empleadoTextBox.Visible = False
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Detalle_facturaBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(1046, 392)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 12
        Me.FechaDateTimePicker.Visible = False
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_facturaBindingSource, "total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(604, 395)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(147, 20)
        Me.TotalTextBox.TabIndex = 20
        '
        'MontoApagarTextBox
        '
        Me.MontoApagarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_facturaBindingSource, "montoApagar", True))
        Me.MontoApagarTextBox.Location = New System.Drawing.Point(604, 418)
        Me.MontoApagarTextBox.Name = "MontoApagarTextBox"
        Me.MontoApagarTextBox.Size = New System.Drawing.Size(147, 20)
        Me.MontoApagarTextBox.TabIndex = 22
        '
        'VueltoTextBox
        '
        Me.VueltoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_facturaBindingSource, "vuelto", True))
        Me.VueltoTextBox.Location = New System.Drawing.Point(1046, 418)
        Me.VueltoTextBox.Name = "VueltoTextBox"
        Me.VueltoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.VueltoTextBox.TabIndex = 24
        Me.VueltoTextBox.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1268, 45)
        Me.Panel2.TabIndex = 0
        '
        'Detalle_facturaTableAdapter
        '
        Me.Detalle_facturaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cajaTableAdapter = Nothing
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.compraTableAdapter = Nothing
        Me.TableAdapterManager.detalle_facturaTableAdapter = Me.Detalle_facturaTableAdapter
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.forma_pagoTableAdapter = Me.Forma_pagoTableAdapter
        Me.TableAdapterManager.NumVentaTableAdapter = Nothing
        Me.TableAdapterManager.PagosTableAdapter = Nothing
        Me.TableAdapterManager.pedido1TableAdapter = Nothing
        Me.TableAdapterManager.pedido2TableAdapter = Nothing
        Me.TableAdapterManager.pedidoTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema2.dbSistemaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'Forma_pagoTableAdapter
        '
        Me.Forma_pagoTableAdapter.ClearBeforeFill = True
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'Forma_pagoBindingSource
        '
        Me.Forma_pagoBindingSource.DataMember = "forma_pago"
        Me.Forma_pagoBindingSource.DataSource = Me.DbSistemaDataSet1
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.DbSistemaDataSet1
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.DbSistemaDataSet1
        '
        'NumVentaBindingSource
        '
        Me.NumVentaBindingSource.DataMember = "NumVenta"
        Me.NumVentaBindingSource.DataSource = Me.DbSistemaDataSet1
        '
        'NumVentaTableAdapter
        '
        Me.NumVentaTableAdapter.ClearBeforeFill = True
        '
        'button7
        '
        Me.button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button7.ForeColor = System.Drawing.Color.White
        Me.button7.Location = New System.Drawing.Point(111, 125)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(215, 23)
        Me.button7.TabIndex = 75
        Me.button7.Text = "Menú principal"
        Me.button7.UseVisualStyleBackColor = False
        '
        'F_detalleventa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 687)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_detalleventa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_detalleventa"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Detalle_facturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbSistemaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel4.ResumeLayout(False)
        Me.panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Forma_pagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DbSistemaDataSet1 As dbSistemaDataSet1
    Friend WithEvents Detalle_facturaBindingSource As BindingSource
    Friend WithEvents Detalle_facturaTableAdapter As dbSistemaDataSet1TableAdapters.detalle_facturaTableAdapter
    Friend WithEvents TableAdapterManager As dbSistemaDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Id_numVentaTextBox As TextBox
    Friend WithEvents Id_clienteTextBox As TextBox
    Friend WithEvents Id_productoTextBox As TextBox
    Friend WithEvents Id_empleadoTextBox As TextBox
    Friend WithEvents Id_tipoPagoTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents CantidadDeProductoTextBox As TextBox
    Friend WithEvents Precio_unitarioTextBox As TextBox
    Friend WithEvents NumeroNITTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents MontoApagarTextBox As TextBox
    Friend WithEvents VueltoTextBox As TextBox
    Private WithEvents Panel5 As Panel
    Private WithEvents label2 As Label
    Private WithEvents label14 As Label
    Private WithEvents button4 As Button
    Private WithEvents panel4 As Panel
    Private WithEvents label12 As Label
    Private WithEvents label3 As Label
    Private WithEvents label6 As Label
    Private WithEvents label13 As Label
    Private WithEvents button5 As Button
    Private WithEvents Panel3 As Panel
    Private WithEvents label10 As Label
    Private WithEvents button3 As Button
    Private WithEvents label18 As Label
    Private WithEvents label1 As Label
    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Friend WithEvents Forma_pagoTableAdapter As dbSistemaDataSet1TableAdapters.forma_pagoTableAdapter
    Friend WithEvents Forma_pagoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As dbSistemaDataSet1TableAdapters.productoTableAdapter
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As dbSistemaDataSet1TableAdapters.clienteTableAdapter
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents NumVentaBindingSource As BindingSource
    Friend WithEvents NumVentaTableAdapter As dbSistemaDataSet1TableAdapters.NumVentaTableAdapter
    Private WithEvents Label16 As Label
    Friend WithEvents PictureBox18 As PictureBox
    Private WithEvents button7 As Button
End Class
