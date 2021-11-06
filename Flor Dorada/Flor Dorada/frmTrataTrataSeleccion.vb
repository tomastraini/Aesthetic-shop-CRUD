Imports System.Data.SqlClient
Public Class frmTrataTrataSeleccion
    Private Sub tbxBus_TextChanged(sender As Object, e As EventArgs) Handles tbxBus.TextChanged
        If tbxBus.Text = "" Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select
cast(id_tratamiento as int) as 'ID', nombre_tratamiento as 'Tratamiento', precio_tratamiento as 'Precio' 
from tratamientos")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "clientes")
                DataGridView1.DataSource = ds.Tables("clientes")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select
cast(id_tratamiento as int) as 'ID', nombre_tratamiento as 'Tratamiento', precio_tratamiento as 'Precio' 
from tratamientos
where concat(cast(id_tratamiento as int), nombre_tratamiento,
precio_tratamiento) like '%" & tbxBus.Text & "%' ORDER BY cast(id_tratamiento as int)")
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("select
cast(id_tratamiento as int) as 'ID', nombre_tratamiento as 'Tratamiento', precio_tratamiento as 'Precio' 
from tratamientos")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "clientes")
            DataGridView1.DataSource = ds.Tables("clientes")
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex = -1 Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select
cast(id_tratamiento as int) as 'ID', nombre_tratamiento as 'Tratamiento', precio_tratamiento as 'Precio' 
from tratamientos")
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
            Dim sql As String = ("use flor_d select
cast(id_tratamiento as int) as 'ID', nombre_tratamiento as 'Tratamiento', precio_tratamiento as 'Precio' 
from tratamientos
where concat(cast(id_tratamiento as int), nombre_tratamiento,
precio_tratamiento)
like '%" & DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value & "%'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "clientes")
                frmTratamientosClientes.TextBox2.Text = ds.Tables("clientes").Rows(0).Item(0)
                frmTratamientosClientes.TextBox8.Text = ds.Tables("clientes").Rows(0).Item(1)
                Hide()
                frmTratamientosClientes.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Dim con2 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql2 As String = ("use flor_d select max(cast(id_trata_clientes as int)) from trata_clientes")
            Dim com2 As New SqlCommand(sql2, con2)
            Try
                Dim ds2 As New DataSet
                Dim da2 As New SqlDataAdapter(com2)
                da2.Fill(ds2, "clientes")
                frmTratamientosClientes.TextBox1.Text = ds2.Tables(0).Rows(0).Item(0)
                frmTratamientosClientes.TextBox1.Text = frmTratamientosClientes.TextBox1.Text + 1
                Hide()
                frmTratamientosClientes.Show()
            Catch ex As Exception
                frmTratamientosClientes.TextBox1.Text = "1"
            End Try
        End If
    End Sub
    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With

    End Sub

    Private Sub frmConsultaCli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreVentFlicker()
        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("select 
cast(id_tratamiento as int) as 'ID', nombre_tratamiento as 'Tratamiento', precio_tratamiento as 'Precio' 
from tratamientos")
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
        Cargar_consulta.Close()
        Close()
    End Sub
End Class