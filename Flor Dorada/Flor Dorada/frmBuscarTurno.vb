Imports System.Data.SqlClient
Imports System.Linq ' need to add 
Public Class frmBuscarTurno
    Private Sub frmBuscarTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxBus.Select()
        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("select 
clientes.nombre_cliente as 'Cliente',
tratamientos.nombre_tratamiento as 'Tratamiento',
fecha_turno as 'Fecha de turno', detalles_turno as 'Detalles', cast(id_turno as int) as 'ID Turno', 
turnos.id_trata_clientes as 'ID'
 from turnos
 join trata_clientes on trata_clientes.id_trata_clientes = turnos.id_trata_clientes
 join clientes on trata_clientes.id_cliente = clientes.id_cliente
 join tratamientos on tratamientos.id_tratamiento = trata_clientes.id_tratamiento
")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "clientes")
            DataGridView1.DataSource = ds.Tables("clientes")
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tbxBus.Select()
        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("select 
clientes.nombre_cliente as 'Cliente',
tratamientos.nombre_tratamiento as 'Tratamiento',
fecha_turno as 'Fecha de turno', detalles_turno as 'Detalles', cast(id_turno as int) as 'Turno', 
turnos.id_trata_clientes as 'Tratamiento'
 from turnos
 join trata_clientes on trata_clientes.id_trata_clientes = turnos.id_trata_clientes
 join clientes on trata_clientes.id_cliente = clientes.id_cliente
 join tratamientos on tratamientos.id_tratamiento = trata_clientes.id_tratamiento
")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "clientes")
            DataGridView1.DataSource = ds.Tables("clientes")
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Application.OpenForms().OfType(Of frmAgregarTurno).Any Then
            frmAgregarTurno.Close()
            Close()
        Else
            Close()
        End If
    End Sub

    Private Sub tbxBus_TextChanged(sender As Object, e As EventArgs) Handles tbxBus.TextChanged
        If tbxBus.Text = "" Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select 
clientes.nombre_cliente as 'Cliente',
tratamientos.nombre_tratamiento as 'Tratamiento',
fecha_turno as 'Fecha de turno', detalles_turno as 'Detalles', cast(id_turno as int) as 'Turno', 
turnos.id_trata_clientes as 'Tratamiento'
 from turnos
 join trata_clientes on trata_clientes.id_trata_clientes = turnos.id_trata_clientes
 join clientes on trata_clientes.id_cliente = clientes.id_cliente
 join tratamientos on tratamientos.id_tratamiento = trata_clientes.id_tratamiento")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "clientes")
                DataGridView1.DataSource = ds.Tables("clientes")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select 
clientes.nombre_cliente as 'Cliente',
tratamientos.nombre_tratamiento as 'Tratamiento',
fecha_turno as 'Fecha de turno', detalles_turno as 'Detalles', cast(id_turno as int) as 'Turno', 
turnos.id_trata_clientes as 'Tratamiento'
 from turnos
 join trata_clientes on trata_clientes.id_trata_clientes = turnos.id_trata_clientes
 join clientes on trata_clientes.id_cliente = clientes.id_cliente
 join tratamientos on tratamientos.id_tratamiento = trata_clientes.id_tratamiento

where concat(clientes.nombre_cliente, tratamientos.nombre_tratamiento, cast(id_turno as int), turnos.id_trata_clientes
, fecha_turno, detalles_turno) like '%" & tbxBus.Text & "%' ORDER BY cast(id_turno as int)")
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex = -1 Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select 
clientes.nombre_cliente as 'Cliente',
tratamientos.nombre_tratamiento as 'Tratamiento',
fecha_turno as 'Fecha de turno', detalles_turno as 'Detalles', cast(id_turno as int) as 'Turno', 
turnos.id_trata_clientes as 'Tratamiento'
 from turnos
 join trata_clientes on trata_clientes.id_trata_clientes = turnos.id_trata_clientes
 join clientes on trata_clientes.id_cliente = clientes.id_cliente
 join tratamientos on tratamientos.id_tratamiento = trata_clientes.id_tratamiento")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "clientes")
                DataGridView1.DataSource = ds.Tables("clientes")
                DataGridView1.Sort(DataGridView1.Columns(e.ColumnIndex), System.ComponentModel.ListSortDirection.Ascending)
                DataGridView1.Sort(DataGridView1.Columns(e.ColumnIndex), System.ComponentModel.ListSortDirection.Descending)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select 
clientes.nombre_cliente as 'Cliente',
tratamientos.nombre_tratamiento as 'Tratamiento',
fecha_turno as 'Fecha de turno', detalles_turno as 'Detalles', cast(id_turno as int) as 'Turno', 
turnos.id_trata_clientes as 'Tratamiento'
 from turnos
 join trata_clientes on trata_clientes.id_trata_clientes = turnos.id_trata_clientes
 join clientes on trata_clientes.id_cliente = clientes.id_cliente
 join tratamientos on tratamientos.id_tratamiento = trata_clientes.id_tratamiento

where concat(clientes.nombre_cliente, tratamientos.nombre_tratamiento, cast(id_turno as int), turnos.id_trata_clientes
, fecha_turno, detalles_turno)
like '%" & DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value & "%'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "clientes")
                frmAgregarTurno.TextBox1.Text = ds.Tables("clientes").Rows(0).Item(1)

                frmAgregarTurno.TextBox2.Text = ds.Tables("clientes").Rows(0).Item(0)

                frmAgregarTurno.TextBox3.Text = ds.Tables("clientes").Rows(0).Item(2)
                frmAgregarTurno.DateTimePicker1.Value = ds.Tables("clientes").Rows(0).Item(2)

                frmAgregarTurno.TextBox4.Text = ds.Tables("clientes").Rows(0).Item(3)
                frmAgregarTurno.TextBox5.Text = ds.Tables("clientes").Rows(0).Item(4)

                frmAgregarTurno.TextBox6.Text = ds.Tables("clientes").Rows(0).Item(5)
                Hide()
                frmAgregarTurno.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class