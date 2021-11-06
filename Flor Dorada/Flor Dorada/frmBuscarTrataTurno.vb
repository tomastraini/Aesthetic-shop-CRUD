Imports System.Data.SqlClient
Public Class frmBuscarTrataTurno
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
        Dim sql As String = ("use flor_d
select  id_trata_clientes as 'ID Sesiones', nombre_cliente as 'Cliente',  nombre_tratamiento as 'Tratamiento',
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex = -1 Then
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
                DataGridView1.Sort(DataGridView1.Columns(e.ColumnIndex), System.ComponentModel.ListSortDirection.Ascending)
                DataGridView1.Sort(DataGridView1.Columns(e.ColumnIndex), System.ComponentModel.ListSortDirection.Descending)
                For i = 0 To DataGridView1.Rows.Count - 1
                    Dim r As DataGridViewRow = DataGridView1.Rows(i)
                    r.Height = 50
                Next
            Catch ex As Exception
                Close()
                frmTratamientosClientes.Show()
            End Try
        Else
            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select id_trata_clientes as 'ID Sesiones', nombre_tratamiento as 'Tratamiento', nombre_cliente as 'Cliente',
fecha_inicio as 'Fecha de inicio', cant_sesiones as 'Cantidad de sesiones', cant_horas as 'Cantidad de horas', detalles_sesiones as 'Detalles'
from trata_clientes
join clientes on clientes.id_cliente = trata_clientes.id_cliente
join tratamientos on tratamientos.id_tratamiento = trata_clientes.id_tratamiento
where concat(id_trata_clientes, 
nombre_tratamiento, 
nombre_cliente, 
fecha_inicio, 
fecha_nac,
detalles_sesiones) like '%" & DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value & "%'")
            Dim com As New SqlCommand(sql, con)
            Try

                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "clientes")
                frmAgregarTurno.TextBox1.Text = ds.Tables("clientes").Rows(0).Item(1)
                frmAgregarTurno.TextBox2.Text = ds.Tables("clientes").Rows(0).Item(2)
                frmAgregarTurno.TextBox6.Text = ds.Tables("clientes").Rows(0).Item(0)
                frmAgregarTurno.Show()
                Close()
            Catch ex As Exception
                Close()
                frmAgregarTurno.Show()
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
    End Sub

    Private Sub tbxBus_TextChanged(sender As Object, e As EventArgs) Handles tbxBus.TextChanged
        If tbxBus.Text = "" Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select id_trata_clientes as 'ID Sesiones', nombre_tratamiento as 'Tratamiento', nombre_cliente as 'Cliente',
fecha_inicio as 'Fecha de inicio', cant_sesiones as 'Cantidad de sesiones', cant_horas as 'Cantidad de horas', foto_final as 'Foto final', detalles_sesiones as 'Detalles'
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
fecha_inicio as 'Fecha de inicio', cant_sesiones as 'Cantidad de sesiones', cant_horas as 'Cantidad de horas',
detalles_sesiones as 'Detalles'
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
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class