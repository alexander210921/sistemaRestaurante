<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_compra
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
        Dim Id_compraLabel As System.Windows.Forms.Label
        Dim Id_productoLabel As System.Windows.Forms.Label
        Dim Valor_compraLabel As System.Windows.Forms.Label
        Dim ObservacionLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Id_productoTextBox = New System.Windows.Forms.TextBox()
        Me.CompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbSistemaDataSet1 = New Sistema2.dbSistemaDataSet1()
        Me.ObservacionTextBox = New System.Windows.Forms.TextBox()
        Me.Valor_compraTextBox = New System.Windows.Forms.TextBox()
        Me.Id_compraTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CompraDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompraTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.compraTableAdapter()
        Me.TableAdapterManager = New Sistema2.dbSistemaDataSet1TableAdapters.TableAdapterManager()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.label7 = New System.Windows.Forms.Label()
        Id_compraLabel = New System.Windows.Forms.Label()
        Id_productoLabel = New System.Windows.Forms.Label()
        Valor_compraLabel = New System.Windows.Forms.Label()
        ObservacionLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.CompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbSistemaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_compraLabel
        '
        Id_compraLabel.AutoSize = True
        Id_compraLabel.ForeColor = System.Drawing.Color.White
        Id_compraLabel.Location = New System.Drawing.Point(106, 187)
        Id_compraLabel.Name = "Id_compraLabel"
        Id_compraLabel.Size = New System.Drawing.Size(56, 13)
        Id_compraLabel.TabIndex = 1
        Id_compraLabel.Text = "id compra:"
        '
        'Id_productoLabel
        '
        Id_productoLabel.AutoSize = True
        Id_productoLabel.ForeColor = System.Drawing.Color.White
        Id_productoLabel.Location = New System.Drawing.Point(106, 213)
        Id_productoLabel.Name = "Id_productoLabel"
        Id_productoLabel.Size = New System.Drawing.Size(63, 13)
        Id_productoLabel.TabIndex = 3
        Id_productoLabel.Text = "id producto:"
        '
        'Valor_compraLabel
        '
        Valor_compraLabel.AutoSize = True
        Valor_compraLabel.ForeColor = System.Drawing.Color.White
        Valor_compraLabel.Location = New System.Drawing.Point(106, 239)
        Valor_compraLabel.Name = "Valor_compraLabel"
        Valor_compraLabel.Size = New System.Drawing.Size(71, 13)
        Valor_compraLabel.TabIndex = 5
        Valor_compraLabel.Text = "valor compra:"
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.ForeColor = System.Drawing.Color.White
        ObservacionLabel.Location = New System.Drawing.Point(106, 265)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(68, 13)
        ObservacionLabel.TabIndex = 7
        ObservacionLabel.Text = "observacion:"
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
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.CompraDataGridView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 611)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(357, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 24)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "LISTADO DE COMPRAS"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel3.Controls.Add(Me.label7)
        Me.Panel3.Controls.Add(Me.Id_productoTextBox)
        Me.Panel3.Controls.Add(Me.ObservacionTextBox)
        Me.Panel3.Controls.Add(ObservacionLabel)
        Me.Panel3.Controls.Add(Me.Valor_compraTextBox)
        Me.Panel3.Controls.Add(Valor_compraLabel)
        Me.Panel3.Controls.Add(Id_productoLabel)
        Me.Panel3.Controls.Add(Me.Id_compraTextBox)
        Me.Panel3.Controls.Add(Id_compraLabel)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(928, 46)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(353, 565)
        Me.Panel3.TabIndex = 18
        '
        'Id_productoTextBox
        '
        Me.Id_productoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraBindingSource, "id_producto", True))
        Me.Id_productoTextBox.Location = New System.Drawing.Point(183, 210)
        Me.Id_productoTextBox.Name = "Id_productoTextBox"
        Me.Id_productoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_productoTextBox.TabIndex = 4
        '
        'CompraBindingSource
        '
        Me.CompraBindingSource.DataMember = "compra"
        Me.CompraBindingSource.DataSource = Me.DbSistemaDataSet1
        '
        'DbSistemaDataSet1
        '
        Me.DbSistemaDataSet1.DataSetName = "dbSistemaDataSet1"
        Me.DbSistemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraBindingSource, "observacion", True))
        Me.ObservacionTextBox.Location = New System.Drawing.Point(183, 262)
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ObservacionTextBox.TabIndex = 8
        '
        'Valor_compraTextBox
        '
        Me.Valor_compraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraBindingSource, "valor_compra", True))
        Me.Valor_compraTextBox.Location = New System.Drawing.Point(183, 236)
        Me.Valor_compraTextBox.Name = "Valor_compraTextBox"
        Me.Valor_compraTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Valor_compraTextBox.TabIndex = 6
        '
        'Id_compraTextBox
        '
        Me.Id_compraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraBindingSource, "id_compra", True))
        Me.Id_compraTextBox.Location = New System.Drawing.Point(183, 184)
        Me.Id_compraTextBox.Name = "Id_compraTextBox"
        Me.Id_compraTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_compraTextBox.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(22, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(307, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel2.Controls.Add(Me.pictureBox4)
        Me.Panel2.Controls.Add(Me.pictureBox2)
        Me.Panel2.Controls.Add(Me.pictureBox1)
        Me.Panel2.Controls.Add(Me.pictureBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1284, 40)
        Me.Panel2.TabIndex = 17
        '
        'pictureBox4
        '
        Me.pictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox4.Image = Global.Sistema2.My.Resources.Resources.window_restore_icon_144027
        Me.pictureBox4.Location = New System.Drawing.Point(1217, 3)
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(688, 158)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 16
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(794, 155)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(73, 23)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "Buscar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(610, 410)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(73, 23)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Eliminar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(531, 410)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(73, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Actualizar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(352, 410)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Menu principal"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(766, 410)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Mostrar todo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CompraDataGridView
        '
        Me.CompraDataGridView.AllowUserToAddRows = False
        Me.CompraDataGridView.AllowUserToDeleteRows = False
        Me.CompraDataGridView.AllowUserToOrderColumns = True
        Me.CompraDataGridView.AutoGenerateColumns = False
        Me.CompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CompraDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.CompraDataGridView.DataSource = Me.CompraBindingSource
        Me.CompraDataGridView.Location = New System.Drawing.Point(352, 184)
        Me.CompraDataGridView.Name = "CompraDataGridView"
        Me.CompraDataGridView.ReadOnly = True
        Me.CompraDataGridView.Size = New System.Drawing.Size(515, 220)
        Me.CompraDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_compra"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_compra"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "id_producto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "id_producto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "valor_compra"
        Me.DataGridViewTextBoxColumn3.HeaderText = "valor_compra"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "observacion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "observacion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'CompraTableAdapter
        '
        Me.CompraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cajaTableAdapter = Nothing
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.compraTableAdapter = Me.CompraTableAdapter
        Me.TableAdapterManager.detalle_facturaTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.forma_pagoTableAdapter = Nothing
        Me.TableAdapterManager.NumVentaTableAdapter = Nothing
        Me.TableAdapterManager.PagosTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema2.dbSistemaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(89, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(151, 25)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "BURGER HOT"
        '
        'PictureBox18
        '
        Me.PictureBox18.Image = Global.Sistema2.My.Resources.Resources._32382hamburger_98925
        Me.PictureBox18.Location = New System.Drawing.Point(5, 53)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(88, 68)
        Me.PictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox18.TabIndex = 73
        Me.PictureBox18.TabStop = False
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.ForeColor = System.Drawing.Color.White
        Me.label7.Location = New System.Drawing.Point(141, 138)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(98, 13)
        Me.label7.TabIndex = 59
        Me.label7.Text = "MANTENIMIENTO"
        '
        'F_compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 611)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "as                                  m"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.CompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbSistemaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DbSistemaDataSet1 As dbSistemaDataSet1
    Friend WithEvents CompraBindingSource As BindingSource
    Friend WithEvents CompraTableAdapter As dbSistemaDataSet1TableAdapters.compraTableAdapter
    Friend WithEvents TableAdapterManager As dbSistemaDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents CompraDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Id_compraTextBox As TextBox
    Friend WithEvents Id_productoTextBox As TextBox
    Friend WithEvents Valor_compraTextBox As TextBox
    Friend WithEvents ObservacionTextBox As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents pictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Private WithEvents Label16 As Label
    Friend WithEvents PictureBox18 As PictureBox
    Private WithEvents label7 As Label
End Class
