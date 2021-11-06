<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTProveedores))
        Me.view_proveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bd_proy4DataSet = New sys_proy4.bd_proy4DataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.view_proveedoresTableAdapter = New sys_proy4.bd_proy4DataSetTableAdapters.view_proveedoresTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.view_proveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bd_proy4DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'view_proveedoresBindingSource
        '
        Me.view_proveedoresBindingSource.DataMember = "view_proveedores"
        Me.view_proveedoresBindingSource.DataSource = Me.bd_proy4DataSet
        '
        'bd_proy4DataSet
        '
        Me.bd_proy4DataSet.DataSetName = "bd_proy4DataSet"
        Me.bd_proy4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.view_proveedoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sys_proy4.rptProveedores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(745, 333)
        Me.ReportViewer1.TabIndex = 0
        '
        'view_proveedoresTableAdapter
        '
        Me.view_proveedoresTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(658, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmRPTProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(745, 374)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTProveedores"
        Me.Text = "Reporte de proveedores"
        CType(Me.view_proveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bd_proy4DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents view_proveedoresBindingSource As BindingSource
    Friend WithEvents bd_proy4DataSet As bd_proy4DataSet
    Friend WithEvents view_proveedoresTableAdapter As bd_proy4DataSetTableAdapters.view_proveedoresTableAdapter
    Friend WithEvents Button1 As Button
End Class
