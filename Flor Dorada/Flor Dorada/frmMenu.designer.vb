<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FichaMéficaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TratamientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarTratamientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TratamientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosVendidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarUnTurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarTurnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosYServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarTipoDeTratamientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarProductosEnStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarContraseñasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.TratamientosToolStripMenuItem, Me.ProductosYServiciosToolStripMenuItem, Me.ConfiguracionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(676, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMClientesToolStripMenuItem, Me.FichaMéficaToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ABMClientesToolStripMenuItem
        '
        Me.ABMClientesToolStripMenuItem.Name = "ABMClientesToolStripMenuItem"
        Me.ABMClientesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ABMClientesToolStripMenuItem.Text = "Cargar clientes"
        '
        'FichaMéficaToolStripMenuItem
        '
        Me.FichaMéficaToolStripMenuItem.Name = "FichaMéficaToolStripMenuItem"
        Me.FichaMéficaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FichaMéficaToolStripMenuItem.Text = "Ficha médica"
        '
        'TratamientosToolStripMenuItem
        '
        Me.TratamientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarConsultaToolStripMenuItem, Me.CargarTratamientoToolStripMenuItem, Me.BuscarClientesToolStripMenuItem, Me.ProductosVendidosToolStripMenuItem, Me.TurnosToolStripMenuItem1})
        Me.TratamientosToolStripMenuItem.Name = "TratamientosToolStripMenuItem"
        Me.TratamientosToolStripMenuItem.Size = New System.Drawing.Size(200, 20)
        Me.TratamientosToolStripMenuItem.Text = "Venta de tratamientos y productos"
        '
        'CargarConsultaToolStripMenuItem
        '
        Me.CargarConsultaToolStripMenuItem.Name = "CargarConsultaToolStripMenuItem"
        Me.CargarConsultaToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.CargarConsultaToolStripMenuItem.Text = "Cargar consulta"
        '
        'CargarTratamientoToolStripMenuItem
        '
        Me.CargarTratamientoToolStripMenuItem.Name = "CargarTratamientoToolStripMenuItem"
        Me.CargarTratamientoToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.CargarTratamientoToolStripMenuItem.Text = "Cargar venta de tratamiento"
        '
        'BuscarClientesToolStripMenuItem
        '
        Me.BuscarClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TratamientoToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.BuscarClientesToolStripMenuItem.Name = "BuscarClientesToolStripMenuItem"
        Me.BuscarClientesToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.BuscarClientesToolStripMenuItem.Text = "Buscar datos"
        '
        'TratamientoToolStripMenuItem
        '
        Me.TratamientoToolStripMenuItem.Name = "TratamientoToolStripMenuItem"
        Me.TratamientoToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.TratamientoToolStripMenuItem.Text = "Tratamiento"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ProductosVendidosToolStripMenuItem
        '
        Me.ProductosVendidosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarToolStripMenuItem, Me.BuscarToolStripMenuItem})
        Me.ProductosVendidosToolStripMenuItem.Name = "ProductosVendidosToolStripMenuItem"
        Me.ProductosVendidosToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ProductosVendidosToolStripMenuItem.Text = "Venta de productos"
        '
        'CargarToolStripMenuItem
        '
        Me.CargarToolStripMenuItem.Name = "CargarToolStripMenuItem"
        Me.CargarToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CargarToolStripMenuItem.Text = "Cargar venta"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar ventas"
        '
        'TurnosToolStripMenuItem1
        '
        Me.TurnosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarUnTurnoToolStripMenuItem, Me.BuscarTurnosToolStripMenuItem})
        Me.TurnosToolStripMenuItem1.Name = "TurnosToolStripMenuItem1"
        Me.TurnosToolStripMenuItem1.Size = New System.Drawing.Size(222, 22)
        Me.TurnosToolStripMenuItem1.Text = "Registro de turnos"
        '
        'CargarUnTurnoToolStripMenuItem
        '
        Me.CargarUnTurnoToolStripMenuItem.Name = "CargarUnTurnoToolStripMenuItem"
        Me.CargarUnTurnoToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.CargarUnTurnoToolStripMenuItem.Text = "Cargar un turno"
        '
        'BuscarTurnosToolStripMenuItem
        '
        Me.BuscarTurnosToolStripMenuItem.Name = "BuscarTurnosToolStripMenuItem"
        Me.BuscarTurnosToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.BuscarTurnosToolStripMenuItem.Text = "Buscar turnos"
        '
        'ProductosYServiciosToolStripMenuItem
        '
        Me.ProductosYServiciosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarTipoDeTratamientosToolStripMenuItem, Me.CargarProductosToolStripMenuItem, Me.BuscarProductosEnStockToolStripMenuItem})
        Me.ProductosYServiciosToolStripMenuItem.Name = "ProductosYServiciosToolStripMenuItem"
        Me.ProductosYServiciosToolStripMenuItem.Size = New System.Drawing.Size(130, 20)
        Me.ProductosYServiciosToolStripMenuItem.Text = "Productos y servicios"
        '
        'CargarTipoDeTratamientosToolStripMenuItem
        '
        Me.CargarTipoDeTratamientosToolStripMenuItem.Name = "CargarTipoDeTratamientosToolStripMenuItem"
        Me.CargarTipoDeTratamientosToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.CargarTipoDeTratamientosToolStripMenuItem.Text = "Cargar y buscar tratamientos Flor dorada"
        '
        'CargarProductosToolStripMenuItem
        '
        Me.CargarProductosToolStripMenuItem.Name = "CargarProductosToolStripMenuItem"
        Me.CargarProductosToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.CargarProductosToolStripMenuItem.Text = "Cargar productos"
        '
        'BuscarProductosEnStockToolStripMenuItem
        '
        Me.BuscarProductosEnStockToolStripMenuItem.Name = "BuscarProductosEnStockToolStripMenuItem"
        Me.BuscarProductosEnStockToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.BuscarProductosEnStockToolStripMenuItem.Text = "Buscar productos en stock"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarContraseñasToolStripMenuItem})
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'CambiarContraseñasToolStripMenuItem
        '
        Me.CambiarContraseñasToolStripMenuItem.Name = "CambiarContraseñasToolStripMenuItem"
        Me.CambiarContraseñasToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.CambiarContraseñasToolStripMenuItem.Text = "Cambiar contraseñas"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(586, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(442, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Bienvenido!"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(550, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Label3"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(12, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 38)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cambiar de usuario"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.Flor_Dorada.My.Resources.Resources._16fb21c6_5ce0_419e_8391_4fc0c40be437
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(442, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 206)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 71)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Flor_Dorada.My.Resources.Resources.forest_flora_frame_solid_color_abstract_cream_background_free_vector1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(676, 377)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.Text = "Menú principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiarContraseñasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ABMClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FichaMéficaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TratamientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarTratamientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosYServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarTipoDeTratamientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TratamientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProductosVendidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarProductosEnStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TurnosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CargarUnTurnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarTurnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
End Class
