<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_producto
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
        Dim Id_productoLabel As System.Windows.Forms.Label
        Dim Id_categoriaLabel As System.Windows.Forms.Label
        Dim Id_proveedorLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim Precio_compraLabel As System.Windows.Forms.Label
        Dim Precio_ventaLabel As System.Windows.Forms.Label
        Dim DescuestoLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim Id_empleadoqueloingresoLabel As System.Windows.Forms.Label
        Dim Fecha_ingresoLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbSistemaDataSet1 = New Sistema2.dbSistemaDataSet1()
        Me.Fecha_ingresoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.DescuestoTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_ventaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_productoTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_compraTextBox = New System.Windows.Forms.TextBox()
        Me.Id_categoriaTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Id_proveedorTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.productoTableAdapter()
        Me.TableAdapterManager = New Sistema2.dbSistemaDataSet1TableAdapters.TableAdapterManager()
        Id_productoLabel = New System.Windows.Forms.Label()
        Id_categoriaLabel = New System.Windows.Forms.Label()
        Id_proveedorLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Precio_compraLabel = New System.Windows.Forms.Label()
        Precio_ventaLabel = New System.Windows.Forms.Label()
        DescuestoLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        Id_empleadoqueloingresoLabel = New System.Windows.Forms.Label()
        Fecha_ingresoLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbSistemaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_productoLabel
        '
        Id_productoLabel.AutoSize = True
        Id_productoLabel.ForeColor = System.Drawing.Color.White
        Id_productoLabel.Location = New System.Drawing.Point(20, 160)
        Id_productoLabel.Name = "Id_productoLabel"
        Id_productoLabel.Size = New System.Drawing.Size(63, 13)
        Id_productoLabel.TabIndex = 1
        Id_productoLabel.Text = "id producto:"
        '
        'Id_categoriaLabel
        '
        Id_categoriaLabel.AutoSize = True
        Id_categoriaLabel.ForeColor = System.Drawing.Color.White
        Id_categoriaLabel.Location = New System.Drawing.Point(20, 186)
        Id_categoriaLabel.Name = "Id_categoriaLabel"
        Id_categoriaLabel.Size = New System.Drawing.Size(65, 13)
        Id_categoriaLabel.TabIndex = 3
        Id_categoriaLabel.Text = "id categoria:"
        '
        'Id_proveedorLabel
        '
        Id_proveedorLabel.AutoSize = True
        Id_proveedorLabel.ForeColor = System.Drawing.Color.White
        Id_proveedorLabel.Location = New System.Drawing.Point(20, 212)
        Id_proveedorLabel.Name = "Id_proveedorLabel"
        Id_proveedorLabel.Size = New System.Drawing.Size(69, 13)
        Id_proveedorLabel.TabIndex = 5
        Id_proveedorLabel.Text = "id proveedor:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.ForeColor = System.Drawing.Color.White
        NombreLabel.Location = New System.Drawing.Point(20, 238)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 7
        NombreLabel.Text = "nombre:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.ForeColor = System.Drawing.Color.White
        DescripcionLabel.Location = New System.Drawing.Point(20, 264)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(64, 13)
        DescripcionLabel.TabIndex = 9
        DescripcionLabel.Text = "descripcion:"
        '
        'Precio_compraLabel
        '
        Precio_compraLabel.AutoSize = True
        Precio_compraLabel.ForeColor = System.Drawing.Color.White
        Precio_compraLabel.Location = New System.Drawing.Point(20, 290)
        Precio_compraLabel.Name = "Precio_compraLabel"
        Precio_compraLabel.Size = New System.Drawing.Size(77, 13)
        Precio_compraLabel.TabIndex = 11
        Precio_compraLabel.Text = "precio compra:"
        '
        'Precio_ventaLabel
        '
        Precio_ventaLabel.AutoSize = True
        Precio_ventaLabel.ForeColor = System.Drawing.Color.White
        Precio_ventaLabel.Location = New System.Drawing.Point(20, 316)
        Precio_ventaLabel.Name = "Precio_ventaLabel"
        Precio_ventaLabel.Size = New System.Drawing.Size(69, 13)
        Precio_ventaLabel.TabIndex = 13
        Precio_ventaLabel.Text = "precio venta:"
        '
        'DescuestoLabel
        '
        DescuestoLabel.AutoSize = True
        DescuestoLabel.ForeColor = System.Drawing.Color.White
        DescuestoLabel.Location = New System.Drawing.Point(20, 342)
        DescuestoLabel.Name = "DescuestoLabel"
        DescuestoLabel.Size = New System.Drawing.Size(59, 13)
        DescuestoLabel.TabIndex = 15
        DescuestoLabel.Text = "descuesto:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.ForeColor = System.Drawing.Color.White
        CantidadLabel.Location = New System.Drawing.Point(20, 368)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(51, 13)
        CantidadLabel.TabIndex = 17
        CantidadLabel.Text = "cantidad:"
        '
        'Id_empleadoqueloingresoLabel
        '
        Id_empleadoqueloingresoLabel.AutoSize = True
        Id_empleadoqueloingresoLabel.ForeColor = System.Drawing.Color.White
        Id_empleadoqueloingresoLabel.Location = New System.Drawing.Point(20, 394)
        Id_empleadoqueloingresoLabel.Name = "Id_empleadoqueloingresoLabel"
        Id_empleadoqueloingresoLabel.Size = New System.Drawing.Size(127, 13)
        Id_empleadoqueloingresoLabel.TabIndex = 19
        Id_empleadoqueloingresoLabel.Text = "id empleadoqueloingreso:"
        '
        'Fecha_ingresoLabel
        '
        Fecha_ingresoLabel.AutoSize = True
        Fecha_ingresoLabel.ForeColor = System.Drawing.Color.White
        Fecha_ingresoLabel.Location = New System.Drawing.Point(20, 421)
        Fecha_ingresoLabel.Name = "Fecha_ingresoLabel"
        Fecha_ingresoLabel.Size = New System.Drawing.Size(74, 13)
        Fecha_ingresoLabel.TabIndex = 21
        Fecha_ingresoLabel.Text = "fecha ingreso:"
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
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.ProductoDataGridView)
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
        Me.Label16.Location = New System.Drawing.Point(129, 77)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(151, 25)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "BURGER HOT"
        '
        'PictureBox18
        '
        Me.PictureBox18.Image = Global.Sistema2.My.Resources.Resources._32382hamburger_98925
        Me.PictureBox18.Location = New System.Drawing.Point(45, 34)
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
        Me.Label1.Location = New System.Drawing.Point(41, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 24)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "LISTADO DE PRODUCTOS"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel3.Controls.Add(Me.pictureBox4)
        Me.Panel3.Controls.Add(Me.pictureBox2)
        Me.Panel3.Controls.Add(Me.pictureBox1)
        Me.Panel3.Controls.Add(Me.pictureBox3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1284, 34)
        Me.Panel3.TabIndex = 45
        '
        'pictureBox4
        '
        Me.pictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox4.Image = Global.Sistema2.My.Resources.Resources.window_restore_icon_144027
        Me.pictureBox4.Location = New System.Drawing.Point(1218, 3)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(25, 29)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox4.TabIndex = 22
        Me.pictureBox4.TabStop = False
        Me.pictureBox4.Visible = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox2.Image = Global.Sistema2.My.Resources.Resources.maximizar
        Me.pictureBox2.Location = New System.Drawing.Point(1218, 3)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(24, 29)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 21
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox1.Image = Global.Sistema2.My.Resources.Resources.Cerrar
        Me.pictureBox1.Location = New System.Drawing.Point(1248, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(24, 29)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 19
        Me.pictureBox1.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox3.Image = Global.Sistema2.My.Resources.Resources.minimizar
        Me.pictureBox3.Location = New System.Drawing.Point(1187, 3)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(24, 29)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox3.TabIndex = 20
        Me.pictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Controls.Add(Me.label7)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.DescripcionTextBox)
        Me.Panel2.Controls.Add(Me.Fecha_ingresoDateTimePicker)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Fecha_ingresoLabel)
        Me.Panel2.Controls.Add(Id_empleadoqueloingresoLabel)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.CantidadTextBox)
        Me.Panel2.Controls.Add(CantidadLabel)
        Me.Panel2.Controls.Add(Me.DescuestoTextBox)
        Me.Panel2.Controls.Add(DescuestoLabel)
        Me.Panel2.Controls.Add(Me.Precio_ventaTextBox)
        Me.Panel2.Controls.Add(Id_productoLabel)
        Me.Panel2.Controls.Add(Precio_ventaLabel)
        Me.Panel2.Controls.Add(Me.Id_productoTextBox)
        Me.Panel2.Controls.Add(Me.Precio_compraTextBox)
        Me.Panel2.Controls.Add(Id_categoriaLabel)
        Me.Panel2.Controls.Add(Precio_compraLabel)
        Me.Panel2.Controls.Add(Me.Id_categoriaTextBox)
        Me.Panel2.Controls.Add(DescripcionLabel)
        Me.Panel2.Controls.Add(Id_proveedorLabel)
        Me.Panel2.Controls.Add(Me.NombreTextBox)
        Me.Panel2.Controls.Add(Me.Id_proveedorTextBox)
        Me.Panel2.Controls.Add(NombreLabel)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(909, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(375, 577)
        Me.Panel2.TabIndex = 44
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.ForeColor = System.Drawing.Color.White
        Me.label7.Location = New System.Drawing.Point(154, 136)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(98, 13)
        Me.label7.TabIndex = 60
        Me.label7.Text = "MANTENIMIENTO"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(153, 391)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 44
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(153, 261)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescripcionTextBox.TabIndex = 10
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.DbSistemaDataSet1
        '
        'DbSistemaDataSet1
        '
        Me.DbSistemaDataSet1.DataSetName = "dbSistemaDataSet1"
        Me.DbSistemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Fecha_ingresoDateTimePicker
        '
        Me.Fecha_ingresoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductoBindingSource, "fecha_ingreso", True))
        Me.Fecha_ingresoDateTimePicker.Location = New System.Drawing.Point(153, 417)
        Me.Fecha_ingresoDateTimePicker.Name = "Fecha_ingresoDateTimePicker"
        Me.Fecha_ingresoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_ingresoDateTimePicker.TabIndex = 22
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(134, 472)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(118, 23)
        Me.Button6.TabIndex = 43
        Me.Button6.Text = "Agregar categoria"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(23, 443)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(330, 23)
        Me.Button4.TabIndex = 40
        Me.Button4.Text = "Guardar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(153, 365)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CantidadTextBox.TabIndex = 18
        '
        'DescuestoTextBox
        '
        Me.DescuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "descuesto", True))
        Me.DescuestoTextBox.Location = New System.Drawing.Point(153, 339)
        Me.DescuestoTextBox.Name = "DescuestoTextBox"
        Me.DescuestoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescuestoTextBox.TabIndex = 16
        '
        'Precio_ventaTextBox
        '
        Me.Precio_ventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "precio_venta", True))
        Me.Precio_ventaTextBox.Location = New System.Drawing.Point(153, 313)
        Me.Precio_ventaTextBox.Name = "Precio_ventaTextBox"
        Me.Precio_ventaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Precio_ventaTextBox.TabIndex = 14
        '
        'Id_productoTextBox
        '
        Me.Id_productoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "id_producto", True))
        Me.Id_productoTextBox.Location = New System.Drawing.Point(153, 157)
        Me.Id_productoTextBox.Name = "Id_productoTextBox"
        Me.Id_productoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_productoTextBox.TabIndex = 2
        '
        'Precio_compraTextBox
        '
        Me.Precio_compraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "precio_compra", True))
        Me.Precio_compraTextBox.Location = New System.Drawing.Point(153, 287)
        Me.Precio_compraTextBox.Name = "Precio_compraTextBox"
        Me.Precio_compraTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Precio_compraTextBox.TabIndex = 12
        '
        'Id_categoriaTextBox
        '
        Me.Id_categoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "id_categoria", True))
        Me.Id_categoriaTextBox.Location = New System.Drawing.Point(153, 183)
        Me.Id_categoriaTextBox.Name = "Id_categoriaTextBox"
        Me.Id_categoriaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_categoriaTextBox.TabIndex = 4
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(153, 235)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreTextBox.TabIndex = 8
        '
        'Id_proveedorTextBox
        '
        Me.Id_proveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "id_proveedor", True))
        Me.Id_proveedorTextBox.Location = New System.Drawing.Point(153, 209)
        Me.Id_proveedorTextBox.Name = "Id_proveedorTextBox"
        Me.Id_proveedorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_proveedorTextBox.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(660, 167)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(143, 20)
        Me.TextBox1.TabIndex = 42
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(809, 166)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 41
        Me.Button5.Text = "Buscar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(35, 477)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(224, 23)
        Me.Button7.TabIndex = 39
        Me.Button7.Text = "Menú principal"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(660, 477)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 23)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Mostrar todo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(298, 477)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(157, 23)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(461, 477)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 23)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(35, 195)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.Size = New System.Drawing.Size(849, 276)
        Me.ProductoDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_producto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_producto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "id_categoria"
        Me.DataGridViewTextBoxColumn2.HeaderText = "id_categoria"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "id_proveedor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "id_proveedor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "precio_compra"
        Me.DataGridViewTextBoxColumn6.HeaderText = "precio_compra"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "precio_venta"
        Me.DataGridViewTextBoxColumn7.HeaderText = "precio_venta"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "descuesto"
        Me.DataGridViewTextBoxColumn8.HeaderText = "descuesto"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn9.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "id_empleadoqueloingreso"
        Me.DataGridViewTextBoxColumn10.HeaderText = "id_empleadoqueloingreso"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "fecha_ingreso"
        Me.DataGridViewTextBoxColumn11.HeaderText = "fecha_ingreso"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.productoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema2.dbSistemaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'F_producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1284, 611)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_producto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbSistemaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DbSistemaDataSet1 As dbSistemaDataSet1
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As dbSistemaDataSet1TableAdapters.productoTableAdapter
    Friend WithEvents TableAdapterManager As dbSistemaDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Id_productoTextBox As TextBox
    Friend WithEvents Id_categoriaTextBox As TextBox
    Friend WithEvents Id_proveedorTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents Precio_compraTextBox As TextBox
    Friend WithEvents Precio_ventaTextBox As TextBox
    Friend WithEvents DescuestoTextBox As TextBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents Fecha_ingresoDateTimePicker As DateTimePicker
    Friend WithEvents ProductoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Button7 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents pictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Private WithEvents label7 As Label
    Private WithEvents Label16 As Label
    Friend WithEvents PictureBox18 As PictureBox
End Class
