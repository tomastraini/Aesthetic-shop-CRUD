Imports System.Data.SqlClient
Public Class Visor_IDTRATACLIENTE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With

    End Sub

    Private Sub Visor_IDTRATACLIENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreVentFlicker()
        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("select  id_trata_clientes as 'ID Sesiones', nombre_cliente as 'Cliente',  nombre_tratamiento as 'Tratamiento',
fecha_inicio as 'Fecha de inicio', cant_sesiones as 'Cantidad de sesiones', cant_horas as 'Cantidad de horas',
 detalles_sesiones as 'Detalles'
from trata_clientes
join clientes on clientes.id_cliente = trata_clientes.id_cliente
join tratamientos on tratamientos.id_tratamiento = trata_clientes.id_tratamiento")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "clientes")
            DataGridView1.DataSource = ds.Tables("clientes")
            For i = 0 To DataGridView1.Rows.Count - 1
                Dim r As DataGridViewRow = DataGridView1.Rows(i)
                r.Height = 50
            Next
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            tbxBus.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("select id_trata_clientes as 'ID Sesiones', nombre_tratamiento as 'Tratamiento', nombre_cliente as 'Cliente',
fecha_inicio as 'Fecha de inicio', cant_sesiones as 'Cantidad de sesiones', cant_horas as 'Cantidad de horas',
, detalles_sesiones as 'Detalles'
from trata_clientes
join clientes on clientes.id_cliente = trata_clientes.id_cliente
join tratamientos on tratamientos.id_tratamiento = trata_clientes.id_tratamiento")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "clientes")
            DataGridView1.DataSource = ds.Tables("clientes")
            For i = 0 To DataGridView1.Rows.Count - 1
                Dim r As DataGridViewRow = DataGridView1.Rows(i)
                r.Height = 50
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tbxBus_TextChanged(sender As Object, e As EventArgs) Handles tbxBus.TextChanged
        If tbxBus.Text = "" Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select id_trata_clientes as 'ID Sesiones', nombre_tratamiento as 'Tratamiento', nombre_cliente as 'Cliente',
fecha_inicio as 'Fecha de inicio', cant_sesiones as 'Cantidad de sesiones', cant_horas as 'Cantidad de horas'
, detalles_sesiones as 'Detalles'
from trata_clientes
join clientes on clientes.id_cliente = trata_clientes.id_cliente
join tratamientos on tratamientos.id_tratamiento = trata_clientes.id_tratamiento")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "clientes")
                DataGridView1.DataSource = ds.Tables("clientes")
                For i = 0 To DataGridView1.Rows.Count - 1
                    Dim r As DataGridViewRow = DataGridView1.Rows(i)
                    r.Height = 50
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select id_trata_clientes as 'ID Sesiones', nombre_tratamiento as 'Tratamiento', nombre_cliente as 'Cliente',
fecha_inicio as 'Fecha de inicio', cant_sesiones as 'Cantidad de sesiones', cant_horas as 'Cantidad de horas'
, detalles_sesiones as 'Detalles'
from trata_clientes
join clientes on clientes.id_cliente = trata_clientes.id_cliente
join tratamientos on tratamientos.id_tratamiento = trata_clientes.id_tratamiento
where concat(id_trata_clientes, 
nombre_tratamiento, 
nombre_cliente, 
fecha_inicio, 
fecha_nac,
detalles_sesiones) like '%" & tbxBus.Text & "%' ORDER BY cast(id_trata_clientes as int)")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "Proveedores")
                DataGridView1.DataSource = ds.Tables("Proveedores")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex = -1 Then
            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select id_trata_clientes as 'ID Sesiones', nombre_tratamiento as 'Tratamiento', nombre_cliente as 'Cliente',
fecha_inicio as 'Fecha de inicio', cant_sesiones as 'Cantidad de sesiones', cant_horas as 'Cantidad de horas',
from trata_clientes
join clientes on clientes.id_cliente = trata_clientes.id_cliente
join tratamientos on tratamientos.id_tratamiento = trata_clientes.id_tratamiento")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "clientes")
                DataGridView1.DataSource = ds.Tables("clientes")
                '  DataGridView1.Sort(DataGridView1.Columns(e.ColumnIndex), System.ComponentModel.ListSortDirection.Ascending)
                ' DataGridView1.Sort(DataGridView1.Columns(e.ColumnIndex), System.ComponentModel.ListSortDirection.Descending)
                '  For i = 0 To DataGridView1.Rows.Count - 1
                ' Dim r As DataGridViewRow = DataGridView1.Rows(i)
                'r.Height = 50
                'Next
            Catch ex As Exception
                Close()
                frmTratamientosClientes.Show()
            End Try
        Else

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select id_trata_clientes, trata_clientes.id_tratamiento,
trata_clientes.id_cliente, fecha_inicio, cant_sesiones, cant_horas,
detalles_sesiones, nombre_tratamiento, nombre_cliente, apellido_cliente
from trata_clientes
join clientes on clientes.id_cliente = trata_clientes.id_cliente
join tratamientos on tratamientos.id_tratamiento = trata_clientes.id_tratamiento
where concat(id_trata_clientes, trata_clientes.id_tratamiento,
trata_clientes.id_cliente, fecha_inicio, cant_sesiones, cant_horas,
detalles_sesiones, nombre_tratamiento, nombre_cliente, apellido_cliente)
like '%" & DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value & "%'")
            Dim com As New SqlCommand(sql, con)
            Try

                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "clientes")
                frmTratamientosClientes.TextBox1.Text = ds.Tables("clientes").Rows(0).Item(0)
                frmTratamientosClientes.TextBox2.Text = ds.Tables("clientes").Rows(0).Item(1)
                frmTratamientosClientes.TextBox3.Text = ds.Tables("clientes").Rows(0).Item(2)
                frmTratamientosClientes.TextBox4.Text = ds.Tables("clientes").Rows(0).Item(3)
                frmTratamientosClientes.DateTimePicker1.Text = ds.Tables("clientes").Rows(0).Item(3)
                frmTratamientosClientes.TextBox5.Text = ds.Tables("clientes").Rows(0).Item(4)
                frmTratamientosClientes.TextBox6.Text = ds.Tables("clientes").Rows(0).Item(5)
                frmTratamientosClientes.TextBox7.Text = ds.Tables("clientes").Rows(0).Item(6)
                frmTratamientosClientes.TextBox8.Text = ds.Tables("clientes").Rows(0).Item(7)
                frmTratamientosClientes.TextBox9.Text = ds.Tables("clientes").Rows(0).Item(8)
                frmTratamientosClientes.TextBox9.Text = frmTratamientosClientes.TextBox9.Text + " " + ds.Tables("clientes").Rows(0).Item(9)
                Hide()
                frmTratamientosClientes.ShowDialog()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub tbxBus_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxBus.KeyDown
        If (e.KeyCode = Keys.Up) Then
            DataGridView1.Select()
        ElseIf (e.KeyCode = keys.Enter)
            If tbxBus.Text = "" Then

                Dim con As New SqlConnection(My.Settings.myConnectionString3)
                Dim sql As String = ("select id_trata_clientes as 'ID Sesiones', nombre_tratamiento as 'Tratamiento', nombre_cliente as 'Cliente',
fecha_inicio as 'Fecha de inicio', cant_sesiones as 'Cantidad de sesiones', cant_horas as 'Cantidad de horas'
, detalles_sesiones as 'Detalles'
from trata_clientes
join clientes on clientes.id_cliente = trata_clientes.id_cliente
join tratamientos on tratamientos.id_tratamiento = trata_clientes.id_tratamiento")
                Dim com As New SqlCommand(sql, con)
                Try
                    Dim ds As New DataSet
                    Dim da As New SqlDataAdapter(com)
                    da.Fill(ds, "clientes")
                    DataGridView1.DataSource = ds.Tables("clientes")
                    For i = 0 To DataGridView1.Rows.Count - 1
                        Dim r As DataGridViewRow = DataGridView1.Rows(i)
                        r.Height = 50
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else

                Dim con As New SqlConnection(My.Settings.myConnectionString3)
                Dim sql As String = ("select id_trata_clientes as 'ID Sesiones', nombre_tratamiento as 'Tratamiento', nombre_cliente as 'Cliente',
fecha_inicio as 'Fecha de inicio', cant_sesiones as 'Cantidad de sesiones', cant_horas as 'Cantidad de horas'
, detalles_sesiones as 'Detalles'
from trata_clientes
join clientes on clientes.id_cliente = trata_clientes.id_cliente
join tratamientos on tratamientos.id_tratamiento = trata_clientes.id_tratamiento
where concat(id_trata_clientes, 
nombre_tratamiento, 
nombre_cliente, 
fecha_inicio, 
fecha_nac,
detalles_sesiones) like '%" & tbxBus.Text & "%' ORDER BY cast(id_trata_clientes as int)")
                Dim com As New SqlCommand(sql, con)
                Try
                    Dim ds As New DataSet
                    Dim da As New SqlDataAdapter(com)
                    da.Fill(ds, "Proveedores")
                    DataGridView1.DataSource = ds.Tables("Proveedores")
                    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf (e.KeyCode = Keys.Escape)
            Close()
        End If
    End Sub

    Private Sub DataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DataGridView1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If (DataGridView1.Rows.Count < 2) Then
                Dim con As New SqlConnection(My.Settings.myConnectionString3)
                Dim sql As String = ("select id_trata_clientes, trata_clientes.id_tratamiento,
trata_clientes.id_cliente, fecha_inicio, cant_sesiones, cant_horas,
detalles_sesiones, nombre_tratamiento, nombre_cliente, apellido_cliente
from trata_clientes
join clientes on clientes.id_cliente = trata_clientes.id_cliente
join tratamientos on tratamientos.id_tratamiento = trata_clientes.id_tratamiento
where id_trata_clientes =
" & DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value & "")
                Dim com As New SqlCommand(sql, con)
                Try

                    Dim ds As New DataSet
                    Dim da As New SqlDataAdapter(com)
                    da.Fill(ds, "clientes")
                    frmTratamientosClientes.TextBox1.Text = ds.Tables("clientes").Rows(0).Item(0)
                    frmTratamientosClientes.TextBox2.Text = ds.Tables("clientes").Rows(0).Item(1)
                    frmTratamientosClientes.TextBox3.Text = ds.Tables("clientes").Rows(0).Item(2)
                    frmTratamientosClientes.TextBox4.Text = ds.Tables("clientes").Rows(0).Item(3)
                    frmTratamientosClientes.DateTimePicker1.Text = ds.Tables("clientes").Rows(0).Item(3)
                    frmTratamientosClientes.TextBox5.Text = ds.Tables("clientes").Rows(0).Item(4)
                    frmTratamientosClientes.TextBox6.Text = ds.Tables("clientes").Rows(0).Item(5)
                    frmTratamientosClientes.TextBox7.Text = ds.Tables("clientes").Rows(0).Item(6)
                    frmTratamientosClientes.TextBox8.Text = ds.Tables("clientes").Rows(0).Item(7)
                    frmTratamientosClientes.TextBox9.Text = ds.Tables("clientes").Rows(0).Item(8)
                    frmTratamientosClientes.TextBox9.Text = frmTratamientosClientes.TextBox9.Text + " " + ds.Tables("clientes").Rows(0).Item(9)
                    Hide()
                    frmTratamientosClientes.ShowDialog()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Dim con As New SqlConnection(My.Settings.myConnectionString3)
                Dim sql As String = ("select id_trata_clientes, trata_clientes.id_tratamiento,
trata_clientes.id_cliente, fecha_inicio, cant_sesiones, cant_horas,
detalles_sesiones, nombre_tratamiento, nombre_cliente, apellido_cliente
from trata_clientes
join clientes on clientes.id_cliente = trata_clientes.id_cliente
join tratamientos on tratamientos.id_tratamiento = trata_clientes.id_tratamiento
where id_trata_clientes =" & DataGridView1.Rows(DataGridView1.CurrentRow.Index - 1).Cells(0).Value & "")
                Dim com As New SqlCommand(sql, con)
                Try

                    Dim ds As New DataSet
                    Dim da As New SqlDataAdapter(com)
                    da.Fill(ds, "clientes")
                    frmTratamientosClientes.TextBox1.Text = ds.Tables("clientes").Rows(0).Item(0)
                    frmTratamientosClientes.TextBox2.Text = ds.Tables("clientes").Rows(0).Item(1)
                    frmTratamientosClientes.TextBox3.Text = ds.Tables("clientes").Rows(0).Item(2)
                    frmTratamientosClientes.TextBox4.Text = ds.Tables("clientes").Rows(0).Item(3)
                    frmTratamientosClientes.DateTimePicker1.Text = ds.Tables("clientes").Rows(0).Item(3)
                    frmTratamientosClientes.TextBox5.Text = ds.Tables("clientes").Rows(0).Item(4)
                    frmTratamientosClientes.TextBox6.Text = ds.Tables("clientes").Rows(0).Item(5)
                    frmTratamientosClientes.TextBox7.Text = ds.Tables("clientes").Rows(0).Item(6)
                    frmTratamientosClientes.TextBox8.Text = ds.Tables("clientes").Rows(0).Item(7)
                    frmTratamientosClientes.TextBox9.Text = ds.Tables("clientes").Rows(0).Item(8)
                    frmTratamientosClientes.TextBox9.Text = frmTratamientosClientes.TextBox9.Text + " " + ds.Tables("clientes").Rows(0).Item(9)
                    Hide()
                    frmTratamientosClientes.ShowDialog()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

        End If
    End Sub
    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If (e.KeyCode = Keys.B) Then
            tbxBus.Select()
        End If
    End Sub

End Class