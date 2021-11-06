<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.tbxUs = New System.Windows.Forms.TextBox()
        Me.lblUs = New System.Windows.Forms.Label()
        Me.lblCon = New System.Windows.Forms.Label()
        Me.tbxCon = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Título = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbxUs
        '
        Me.tbxUs.Location = New System.Drawing.Point(23, 74)
        Me.tbxUs.Name = "tbxUs"
        Me.tbxUs.Size = New System.Drawing.Size(98, 20)
        Me.tbxUs.TabIndex = 0
        '
        'lblUs
        '
        Me.lblUs.AutoSize = True
        Me.lblUs.BackColor = System.Drawing.Color.White
        Me.lblUs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUs.Location = New System.Drawing.Point(23, 56)
        Me.lblUs.Name = "lblUs"
        Me.lblUs.Size = New System.Drawing.Size(45, 15)
        Me.lblUs.TabIndex = 3
        Me.lblUs.Text = "Usuario"
        '
        'lblCon
        '
        Me.lblCon.AutoSize = True
        Me.lblCon.BackColor = System.Drawing.Color.White
        Me.lblCon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCon.Location = New System.Drawing.Point(23, 142)
        Me.lblCon.Name = "lblCon"
        Me.lblCon.Size = New System.Drawing.Size(63, 15)
        Me.lblCon.TabIndex = 4
        Me.lblCon.Text = "Contraseña"
        '
        'tbxCon
        '
        Me.tbxCon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbxCon.Location = New System.Drawing.Point(23, 159)
        Me.tbxCon.Name = "tbxCon"
        Me.tbxCon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxCon.Size = New System.Drawing.Size(98, 20)
        Me.tbxCon.TabIndex = 5
        '
        'btnAceptar
        '
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Location = New System.Drawing.Point(12, 214)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(73, 31)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Salir"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Título
        '
        Me.Título.AutoSize = True
        Me.Título.BackColor = System.Drawing.Color.White
        Me.Título.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Título.Location = New System.Drawing.Point(23, 9)
        Me.Título.Name = "Título"
        Me.Título.Size = New System.Drawing.Size(259, 15)
        Me.Título.TabIndex = 9
        Me.Título.Text = "Sistema de registro de Flor Dorada Estética Integral©"
        Me.Título.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(280, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(286, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(239, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Usted va a ingresar como:"
        Me.Label4.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Flor_Dorada.My.Resources.Resources._64673
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(127, 56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 38)
        Me.PictureBox2.TabIndex = 56
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(280, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(137, 151)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 34)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "Ok!"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Flor_Dorada.My.Resources.Resources.pastel_crema_polvo_fondo_flores_dibujadas_mano_52683_41005
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(384, 253)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Título)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.tbxCon)
        Me.Controls.Add(Me.lblCon)
        Me.Controls.Add(Me.lblUs)
        Me.Controls.Add(Me.tbxUs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxUs As TextBox
    Friend WithEvents lblUs As Label
    Friend WithEvents lblCon As Label
    Friend WithEvents tbxCon As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Título As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
End Class
