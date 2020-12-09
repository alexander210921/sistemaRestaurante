<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_pedido
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
        Dim ReportDataSource26 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource27 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource28 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource29 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource30 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.detall_pedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbSistemaDataSet1 = New Sistema2.dbSistemaDataSet1()
        Me.detalle_ubicacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.direcciondelpedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.totaldelpedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.nombredelclienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.button7 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.detall_pedidoTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.detall_pedidoTableAdapter()
        Me.detalle_ubicacionTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.detalle_ubicacionTableAdapter()
        Me.NumVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NumVentaTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.NumVentaTableAdapter()
        Me.TableAdapterManager = New Sistema2.dbSistemaDataSet1TableAdapters.TableAdapterManager()
        Me.direcciondelpedidoTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.direcciondelpedidoTableAdapter()
        Me.totaldelpedidoTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.totaldelpedidoTableAdapter()
        Me.nombredelclienteTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.nombredelclienteTableAdapter()
        CType(Me.detall_pedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbSistemaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detalle_ubicacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.direcciondelpedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.totaldelpedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nombredelclienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel18.SuspendLayout()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'detall_pedidoBindingSource
        '
        Me.detall_pedidoBindingSource.DataMember = "detall_pedido"
        Me.detall_pedidoBindingSource.DataSource = Me.dbSistemaDataSet1
        '
        'dbSistemaDataSet1
        '
        Me.dbSistemaDataSet1.DataSetName = "dbSistemaDataSet1"
        Me.dbSistemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'detalle_ubicacionBindingSource
        '
        Me.detalle_ubicacionBindingSource.DataMember = "detalle_ubicacion"
        Me.detalle_ubicacionBindingSource.DataSource = Me.dbSistemaDataSet1
        '
        'direcciondelpedidoBindingSource
        '
        Me.direcciondelpedidoBindingSource.DataMember = "direcciondelpedido"
        Me.direcciondelpedidoBindingSource.DataSource = Me.dbSistemaDataSet1
        '
        'totaldelpedidoBindingSource
        '
        Me.totaldelpedidoBindingSource.DataMember = "totaldelpedido"
        Me.totaldelpedidoBindingSource.DataSource = Me.dbSistemaDataSet1
        '
        'nombredelclienteBindingSource
        '
        Me.nombredelclienteBindingSource.DataMember = "nombredelcliente"
        Me.nombredelclienteBindingSource.DataSource = Me.dbSistemaDataSet1
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel18.Controls.Add(Me.button7)
        Me.Panel18.Controls.Add(Me.ReportViewer1)
        Me.Panel18.Controls.Add(Me.Label1)
        Me.Panel18.Controls.Add(Me.Label20)
        Me.Panel18.Controls.Add(Me.PictureBox19)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel18.Location = New System.Drawing.Point(0, 32)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(1268, 548)
        Me.Panel18.TabIndex = 3
        '
        'button7
        '
        Me.button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button7.ForeColor = System.Drawing.Color.White
        Me.button7.Location = New System.Drawing.Point(109, 9)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(215, 23)
        Me.button7.TabIndex = 81
        Me.button7.Text = "Menú principal"
        Me.button7.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        ReportDataSource26.Name = "DataSet1"
        ReportDataSource26.Value = Me.detall_pedidoBindingSource
        ReportDataSource27.Name = "DataSet2"
        ReportDataSource27.Value = Me.detalle_ubicacionBindingSource
        ReportDataSource28.Name = "DataSet3"
        ReportDataSource28.Value = Me.direcciondelpedidoBindingSource
        ReportDataSource29.Name = "DataSet4"
        ReportDataSource29.Value = Me.totaldelpedidoBindingSource
        ReportDataSource30.Name = "DataSet5"
        ReportDataSource30.Value = Me.nombredelclienteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource26)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource27)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource28)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource29)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource30)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema2.R_Pedido_Detallado.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(156, 140)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(923, 388)
        Me.ReportViewer1.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(99, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 25)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "PEDIDOS"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(99, 52)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(151, 25)
        Me.Label20.TabIndex = 78
        Me.Label20.Text = "BURGER HOT"
        '
        'PictureBox19
        '
        Me.PictureBox19.Image = Global.Sistema2.My.Resources.Resources._32382hamburger_98925
        Me.PictureBox19.Location = New System.Drawing.Point(15, 9)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(88, 68)
        Me.PictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox19.TabIndex = 77
        Me.PictureBox19.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel2.Controls.Add(Me.pictureBox4)
        Me.Panel2.Controls.Add(Me.pictureBox1)
        Me.Panel2.Controls.Add(Me.pictureBox2)
        Me.Panel2.Controls.Add(Me.pictureBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1268, 32)
        Me.Panel2.TabIndex = 2
        '
        'pictureBox4
        '
        Me.pictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox4.Image = Global.Sistema2.My.Resources.Resources.window_restore_icon_144027
        Me.pictureBox4.Location = New System.Drawing.Point(1211, 6)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(25, 29)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox4.TabIndex = 10
        Me.pictureBox4.TabStop = False
        Me.pictureBox4.Visible = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox1.Image = Global.Sistema2.My.Resources.Resources.Cerrar
        Me.pictureBox1.Location = New System.Drawing.Point(1241, 6)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(24, 29)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 7
        Me.pictureBox1.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox2.Image = Global.Sistema2.My.Resources.Resources.maximizar
        Me.pictureBox2.Location = New System.Drawing.Point(1211, 6)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(24, 29)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 9
        Me.pictureBox2.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox3.Image = Global.Sistema2.My.Resources.Resources.minimizar
        Me.pictureBox3.Location = New System.Drawing.Point(1180, 6)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(24, 29)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox3.TabIndex = 8
        Me.pictureBox3.TabStop = False
        '
        'detall_pedidoTableAdapter
        '
        Me.detall_pedidoTableAdapter.ClearBeforeFill = True
        '
        'detalle_ubicacionTableAdapter
        '
        Me.detalle_ubicacionTableAdapter.ClearBeforeFill = True
        '
        'NumVentaBindingSource
        '
        Me.NumVentaBindingSource.DataMember = "NumVenta"
        Me.NumVentaBindingSource.DataSource = Me.dbSistemaDataSet1
        '
        'NumVentaTableAdapter
        '
        Me.NumVentaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.NumVentaTableAdapter = Me.NumVentaTableAdapter
        Me.TableAdapterManager.PagosTableAdapter = Nothing
        Me.TableAdapterManager.pedido1TableAdapter = Nothing
        Me.TableAdapterManager.pedido2TableAdapter = Nothing
        Me.TableAdapterManager.pedidoTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema2.dbSistemaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'direcciondelpedidoTableAdapter
        '
        Me.direcciondelpedidoTableAdapter.ClearBeforeFill = True
        '
        'totaldelpedidoTableAdapter
        '
        Me.totaldelpedidoTableAdapter.ClearBeforeFill = True
        '
        'nombredelclienteTableAdapter
        '
        Me.nombredelclienteTableAdapter.ClearBeforeFill = True
        '
        'F_pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 580)
        Me.Controls.Add(Me.Panel18)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_pedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_pedido"
        CType(Me.detall_pedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbSistemaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detalle_ubicacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.direcciondelpedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.totaldelpedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nombredelclienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel18 As Panel
    Private WithEvents Label20 As Label
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents Panel2 As Panel
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents Label1 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents detall_pedidoBindingSource As BindingSource
    Friend WithEvents dbSistemaDataSet1 As dbSistemaDataSet1
    Friend WithEvents detalle_ubicacionBindingSource As BindingSource
    Friend WithEvents detall_pedidoTableAdapter As dbSistemaDataSet1TableAdapters.detall_pedidoTableAdapter
    Friend WithEvents detalle_ubicacionTableAdapter As dbSistemaDataSet1TableAdapters.detalle_ubicacionTableAdapter
    Friend WithEvents NumVentaBindingSource As BindingSource
    Friend WithEvents NumVentaTableAdapter As dbSistemaDataSet1TableAdapters.NumVentaTableAdapter
    Friend WithEvents TableAdapterManager As dbSistemaDataSet1TableAdapters.TableAdapterManager
    Private WithEvents button7 As Button
    Friend WithEvents direcciondelpedidoBindingSource As BindingSource
    Friend WithEvents direcciondelpedidoTableAdapter As dbSistemaDataSet1TableAdapters.direcciondelpedidoTableAdapter
    Friend WithEvents totaldelpedidoBindingSource As BindingSource
    Friend WithEvents totaldelpedidoTableAdapter As dbSistemaDataSet1TableAdapters.totaldelpedidoTableAdapter
    Friend WithEvents nombredelclienteBindingSource As BindingSource
    Friend WithEvents nombredelclienteTableAdapter As dbSistemaDataSet1TableAdapters.nombredelclienteTableAdapter
End Class
