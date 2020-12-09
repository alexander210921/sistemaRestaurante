<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_mostrardetallefactura
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource10 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource11 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.detalle_facturacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbSistemaDataSet1 = New Sistema2.dbSistemaDataSet1()
        Me.nombre_empleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.venta_actualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.fecha_emitida_factuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.nombre_clienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.nombre_empleadossssBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.num_NITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.obtener_totalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.monto_pagarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vueltoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.detalle_facturacionTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.detalle_facturacionTableAdapter()
        Me.NumVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NumVentaTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.NumVentaTableAdapter()
        Me.TableAdapterManager = New Sistema2.dbSistemaDataSet1TableAdapters.TableAdapterManager()
        Me.nombre_empleadoTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.nombre_empleadoTableAdapter()
        Me.venta_actualTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.venta_actualTableAdapter()
        Me.fecha_emitida_factuTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.fecha_emitida_factuTableAdapter()
        Me.nombre_clienteTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.nombre_clienteTableAdapter()
        Me.nombre_empleadossssTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.nombre_empleadossssTableAdapter()
        Me.num_NITTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.num_NITTableAdapter()
        Me.obtener_totalTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.obtener_totalTableAdapter()
        Me.monto_pagarTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.monto_pagarTableAdapter()
        Me.vueltoTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.vueltoTableAdapter()
        Me.obtener_total2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.obtener_total2TableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.obtener_total2TableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.detalle_facturacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbSistemaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nombre_empleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.venta_actualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha_emitida_factuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nombre_clienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nombre_empleadossssBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_NITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obtener_totalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.monto_pagarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vueltoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obtener_total2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ReportViewer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(887, 543)
        Me.Panel1.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.detalle_facturacionBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.nombre_empleadoBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.venta_actualBindingSource
        ReportDataSource4.Name = "DataSet4"
        ReportDataSource4.Value = Me.fecha_emitida_factuBindingSource
        ReportDataSource5.Name = "DataSet5"
        ReportDataSource5.Value = Me.nombre_clienteBindingSource
        ReportDataSource6.Name = "DataSet6"
        ReportDataSource6.Value = Me.nombre_empleadossssBindingSource
        ReportDataSource7.Name = "DataSet7"
        ReportDataSource7.Value = Me.num_NITBindingSource
        ReportDataSource8.Name = "DataSet8"
        ReportDataSource8.Value = Me.obtener_totalBindingSource
        ReportDataSource9.Name = "DataSet9"
        ReportDataSource9.Value = Me.monto_pagarBindingSource
        ReportDataSource10.Name = "DataSet10"
        ReportDataSource10.Value = Me.vueltoBindingSource
        ReportDataSource11.Name = "DataSet11"
        ReportDataSource11.Value = Me.obtener_total2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource9)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource10)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource11)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema2.R_detallefactura.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(887, 543)
        Me.ReportViewer1.TabIndex = 0
        '
        'detalle_facturacionBindingSource
        '
        Me.detalle_facturacionBindingSource.DataMember = "detalle_facturacion"
        Me.detalle_facturacionBindingSource.DataSource = Me.dbSistemaDataSet1
        '
        'dbSistemaDataSet1
        '
        Me.dbSistemaDataSet1.DataSetName = "dbSistemaDataSet1"
        Me.dbSistemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'nombre_empleadoBindingSource
        '
        Me.nombre_empleadoBindingSource.DataMember = "nombre_empleado"
        Me.nombre_empleadoBindingSource.DataSource = Me.dbSistemaDataSet1
        '
        'venta_actualBindingSource
        '
        Me.venta_actualBindingSource.DataMember = "venta_actual"
        Me.venta_actualBindingSource.DataSource = Me.dbSistemaDataSet1
        '
        'fecha_emitida_factuBindingSource
        '
        Me.fecha_emitida_factuBindingSource.DataMember = "fecha_emitida_factu"
        Me.fecha_emitida_factuBindingSource.DataSource = Me.dbSistemaDataSet1
        '
        'nombre_clienteBindingSource
        '
        Me.nombre_clienteBindingSource.DataMember = "nombre_cliente"
        Me.nombre_clienteBindingSource.DataSource = Me.dbSistemaDataSet1
        '
        'nombre_empleadossssBindingSource
        '
        Me.nombre_empleadossssBindingSource.DataMember = "nombre_empleadossss"
        Me.nombre_empleadossssBindingSource.DataSource = Me.dbSistemaDataSet1
        '
        'num_NITBindingSource
        '
        Me.num_NITBindingSource.DataMember = "num_NIT"
        Me.num_NITBindingSource.DataSource = Me.dbSistemaDataSet1
        '
        'obtener_totalBindingSource
        '
        Me.obtener_totalBindingSource.DataMember = "obtener_total"
        Me.obtener_totalBindingSource.DataSource = Me.dbSistemaDataSet1
        '
        'monto_pagarBindingSource
        '
        Me.monto_pagarBindingSource.DataMember = "monto_pagar"
        Me.monto_pagarBindingSource.DataSource = Me.dbSistemaDataSet1
        '
        'vueltoBindingSource
        '
        Me.vueltoBindingSource.DataMember = "vuelto"
        Me.vueltoBindingSource.DataSource = Me.dbSistemaDataSet1
        '
        'detalle_facturacionTableAdapter
        '
        Me.detalle_facturacionTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema2.dbSistemaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'nombre_empleadoTableAdapter
        '
        Me.nombre_empleadoTableAdapter.ClearBeforeFill = True
        '
        'venta_actualTableAdapter
        '
        Me.venta_actualTableAdapter.ClearBeforeFill = True
        '
        'fecha_emitida_factuTableAdapter
        '
        Me.fecha_emitida_factuTableAdapter.ClearBeforeFill = True
        '
        'nombre_clienteTableAdapter
        '
        Me.nombre_clienteTableAdapter.ClearBeforeFill = True
        '
        'nombre_empleadossssTableAdapter
        '
        Me.nombre_empleadossssTableAdapter.ClearBeforeFill = True
        '
        'num_NITTableAdapter
        '
        Me.num_NITTableAdapter.ClearBeforeFill = True
        '
        'obtener_totalTableAdapter
        '
        Me.obtener_totalTableAdapter.ClearBeforeFill = True
        '
        'monto_pagarTableAdapter
        '
        Me.monto_pagarTableAdapter.ClearBeforeFill = True
        '
        'vueltoTableAdapter
        '
        Me.vueltoTableAdapter.ClearBeforeFill = True
        '
        'obtener_total2BindingSource
        '
        Me.obtener_total2BindingSource.DataMember = "obtener_total2"
        Me.obtener_total2BindingSource.DataSource = Me.dbSistemaDataSet1
        '
        'obtener_total2TableAdapter
        '
        Me.obtener_total2TableAdapter.ClearBeforeFill = True
        '
        'F_mostrardetallefactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 543)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "F_mostrardetallefactura"
        Me.Text = "F_mostrardetallefactura"
        Me.Panel1.ResumeLayout(False)
        CType(Me.detalle_facturacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbSistemaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nombre_empleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.venta_actualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha_emitida_factuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nombre_clienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nombre_empleadossssBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_NITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obtener_totalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.monto_pagarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vueltoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obtener_total2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents detalle_facturacionBindingSource As BindingSource
    Friend WithEvents dbSistemaDataSet1 As dbSistemaDataSet1
    Friend WithEvents detalle_facturacionTableAdapter As dbSistemaDataSet1TableAdapters.detalle_facturacionTableAdapter
    Friend WithEvents NumVentaBindingSource As BindingSource
    Friend WithEvents NumVentaTableAdapter As dbSistemaDataSet1TableAdapters.NumVentaTableAdapter
    Friend WithEvents TableAdapterManager As dbSistemaDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents nombre_empleadoBindingSource As BindingSource
    Friend WithEvents nombre_empleadoTableAdapter As dbSistemaDataSet1TableAdapters.nombre_empleadoTableAdapter
    Friend WithEvents venta_actualBindingSource As BindingSource
    Friend WithEvents fecha_emitida_factuBindingSource As BindingSource
    Friend WithEvents nombre_clienteBindingSource As BindingSource
    Friend WithEvents nombre_empleadossssBindingSource As BindingSource
    Friend WithEvents venta_actualTableAdapter As dbSistemaDataSet1TableAdapters.venta_actualTableAdapter
    Friend WithEvents fecha_emitida_factuTableAdapter As dbSistemaDataSet1TableAdapters.fecha_emitida_factuTableAdapter
    Friend WithEvents nombre_clienteTableAdapter As dbSistemaDataSet1TableAdapters.nombre_clienteTableAdapter
    Friend WithEvents nombre_empleadossssTableAdapter As dbSistemaDataSet1TableAdapters.nombre_empleadossssTableAdapter
    Friend WithEvents num_NITBindingSource As BindingSource
    Friend WithEvents num_NITTableAdapter As dbSistemaDataSet1TableAdapters.num_NITTableAdapter
    Friend WithEvents obtener_totalBindingSource As BindingSource
    Friend WithEvents obtener_totalTableAdapter As dbSistemaDataSet1TableAdapters.obtener_totalTableAdapter
    Friend WithEvents monto_pagarBindingSource As BindingSource
    Friend WithEvents vueltoBindingSource As BindingSource
    Friend WithEvents monto_pagarTableAdapter As dbSistemaDataSet1TableAdapters.monto_pagarTableAdapter
    Friend WithEvents vueltoTableAdapter As dbSistemaDataSet1TableAdapters.vueltoTableAdapter
    Friend WithEvents obtener_total2BindingSource As BindingSource
    Friend WithEvents obtener_total2TableAdapter As dbSistemaDataSet1TableAdapters.obtener_total2TableAdapter
End Class
