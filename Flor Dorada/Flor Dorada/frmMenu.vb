Imports System.Data.SqlClient
Public Class frmMenu

    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmLogin.Close()
        Close()
    End Sub


    Private Sub ABMClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmABMClientes.ShowDialog()
    End Sub

    Private Sub CambiarContraseñasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarContraseñasToolStripMenuItem.Click
        frmUsuarios.ShowDialog()
    End Sub
    Private Sub frmMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Back Then
            Button1.PerformClick()
        End If
    End Sub




    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreVentFlicker()
        Label3.Text = frmLogin.Label2.Text
        If (frmLogin.Label5.Text = "User") Or (frmLogin.Label5.Text = "user") Then
            CambiarContraseñasToolStripMenuItem.Enabled = False
        End If
        TextBox1.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New frmLogin
        Close()
        frm.Show()
    End Sub

    Private Sub ABMClientesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ABMClientesToolStripMenuItem.Click
        frmABMClientes.ShowDialog()
    End Sub

    Private Sub FichaMéficaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichaMéficaToolStripMenuItem.Click
        frmFichaMedica.ShowDialog(Me)
    End Sub

    Private Sub CargarConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarConsultaToolStripMenuItem.Click
        Cargar_consulta.ShowDialog()
    End Sub

    Private Sub CargarTipoDeTratamientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarTipoDeTratamientosToolStripMenuItem.Click
        frmTratamientos.ShowDialog()
    End Sub

    Private Sub CargarTratamientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarTratamientoToolStripMenuItem.Click
        frmTrataClientesSeleccionar.Show()
    End Sub

    Private Sub TratamientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TratamientoToolStripMenuItem.Click
        Visor_IDTRATACLIENTE.ShowDialog()
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem.Click
        FrmConsultaVisor.Show()
    End Sub



    Private Sub CargarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarProductosToolStripMenuItem.Click
        frmAgregarProductos.Show()
    End Sub

    Private Sub BuscarProductosEnStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarProductosEnStockToolStripMenuItem.Click
        frmBuscarProductos.ShowDialog()
    End Sub

    Private Sub CargarUnTurnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarUnTurnoToolStripMenuItem.Click
        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = (" select max(cast(id_turno as int)) from turnos")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "clientes")
            Dim inx As Integer
            frmAgregarTurno.TextBox5.Text = ds.Tables("clientes").Rows(0).Item(0)
            inx = frmAgregarTurno.TextBox5.Text
            inx = inx + 1
            frmAgregarTurno.TextBox5.Text = inx
            frmAgregarTurno.Show()
        Catch ex As Exception
            frmAgregarTurno.TextBox5.Text = "1"
            frmAgregarTurno.Show()
        End Try
    End Sub

    Private Sub BuscarTurnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarTurnosToolStripMenuItem.Click
        frmBuscarTurno.Show()
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = (" select max(cast(id_venta as int)) from venta_productos")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "clientes")
            Dim inx As Integer
            frmCargarVentaProductos.TextBox1.Text = ds.Tables("clientes").Rows(0).Item(0)
            inx = frmCargarVentaProductos.TextBox1.Text
            inx = inx + 1
            frmCargarVentaProductos.TextBox1.Text = inx
            frmCargarVentaProductos.Show()
        Catch ex As Exception
            frmCargarVentaProductos.TextBox1.Text = "1"
            frmCargarVentaProductos.Show()
        End Try
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        frmBuscarVentasRealizadas.Show()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If (e.KeyCode = Keys.C) Then
            TextBox1.Text = ""
            frmABMClientes.Show()
        ElseIf (e.KeyCode = Keys.Escape) Then
            TextBox1.Text = ""
            Dim frm As New frmLogin
            Close()
            frm.Show()
        ElseIf (e.KeyCode = Keys.M) Then
            TextBox1.Text = ""
            frmFichaMedica.ShowDialog(Me)
        ElseIf (e.KeyCode = Keys.T) Then
            TextBox1.Text = ""
            Visor_IDTRATACLIENTE.ShowDialog()
        ElseIf (e.KeyCode = Keys.H) Then
            TextBox1.Text = ""
            MsgBox("Teclas rápidas " & vbCrLf & vbCrLf & "Esc: Salir" & vbCrLf & "C: Clientes" & vbCrLf & "M: Ficha médica" & vbCrLf & "T: Visualizar tratamientos")
        End If
        TextBox1.Text = ""
    End Sub

End Class