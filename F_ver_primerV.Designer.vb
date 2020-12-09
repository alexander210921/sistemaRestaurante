<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ver_primerV
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dbSistemaDataSet1 = New Sistema2.dbSistemaDataSet1()
        Me.PrimerasNventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrimerasNventasTableAdapter = New Sistema2.dbSistemaDataSet1TableAdapters.PrimerasNventasTableAdapter()
        CType(Me.dbSistemaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimerasNventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PrimerasNventasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema2.R_venta_primerasV.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'dbSistemaDataSet1
        '
        Me.dbSistemaDataSet1.DataSetName = "dbSistemaDataSet1"
        Me.dbSistemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrimerasNventasBindingSource
        '
        Me.PrimerasNventasBindingSource.DataMember = "PrimerasNventas"
        Me.PrimerasNventasBindingSource.DataSource = Me.dbSistemaDataSet1
        '
        'PrimerasNventasTableAdapter
        '
        Me.PrimerasNventasTableAdapter.ClearBeforeFill = True
        '
        'F_ver_primerV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "F_ver_primerV"
        Me.Text = "F_ver_primerV"
        CType(Me.dbSistemaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimerasNventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PrimerasNventasBindingSource As BindingSource
    Friend WithEvents dbSistemaDataSet1 As dbSistemaDataSet1
    Friend WithEvents PrimerasNventasTableAdapter As dbSistemaDataSet1TableAdapters.PrimerasNventasTableAdapter
End Class
