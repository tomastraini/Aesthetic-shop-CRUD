<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTClientes))
        Me.view_clienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bd_proy4DataSet = New sys_proy4.bd_proy4DataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.view_clienteTableAdapter = New sys_proy4.bd_proy4DataSetTableAdapters.view_clienteTableAdapter()
        CType(Me.view_clienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bd_proy4DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'view_clienteBindingSource
        '
        Me.view_clienteBindingSource.DataMember = "view_cliente"
        Me.view_clienteBindingSource.DataSource = Me.bd_proy4DataSet
        '
        'bd_proy4DataSet
        '
        Me.bd_proy4DataSet.DataSetName = "bd_proy4DataSet"
        Me.bd_proy4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(713, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.view_clienteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sys_proy4.rptClientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 418)
        Me.ReportViewer1.TabIndex = 1
        '
        'view_clienteTableAdapter
        '
        Me.view_clienteTableAdapter.ClearBeforeFill = True
        '
        'frmRPTClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(800, 466)
        Me.ControlBox = False
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRPTClientes"
        Me.Text = "frmRPTClientes"
        CType(Me.view_clienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bd_proy4DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents view_clienteBindingSource As BindingSource
    Friend WithEvents bd_proy4DataSet As bd_proy4DataSet
    Friend WithEvents view_clienteTableAdapter As bd_proy4DataSetTableAdapters.view_clienteTableAdapter
End Class
