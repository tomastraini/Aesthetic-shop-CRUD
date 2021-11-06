Imports System.Data.SqlClient
Public Class frmBuscarProductos
    Private Sub frmBuscarTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxBus.Select()
        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("select id_producto as 'ID producto',
nombre_producto as 'Producto',
precio_producto as 'Precio',
stock as 'Stock'
from productos")
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
        Dim sql As String = ("select id_producto as 'ID producto',
nombre_producto as 'Producto',
precio_producto as 'Precio',
stock as 'Stock'
from productos")
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
        Close()
    End Sub

    Private Sub tbxBus_TextChanged(sender As Object, e As EventArgs) Handles tbxBus.TextChanged
        If tbxBus.Text = "" Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select id_producto as 'ID producto',
nombre_producto as 'Producto',
precio_producto as 'Precio',
stock as 'Stock'
from productos")
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
            Dim sql As String = ("select id_producto as 'ID producto',
nombre_producto as 'Producto',
precio_producto as 'Precio',
stock as 'Stock'
from productos

where concat(id_producto, nombre_producto, precio_producto, stock)
like '%" & tbxBus.Text & "%' ORDER BY cast(id_producto as int)")
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
            Dim sql As String = ("select id_producto as 'ID producto',
nombre_producto as 'Producto',
precio_producto as 'Precio',
stock as 'Stock'
from productos")
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
            Dim sql As String = ("select id_producto as 'ID producto',
nombre_producto as 'Producto',
precio_producto as 'Precio',
stock as 'Stock'
from productos

where concat(id_producto, nombre_producto, precio_producto, stock)
like '%" & DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value & "%' ORDER BY cast(id_producto as int)")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "clientes")
                frmAgregarProductos.TextBox4.Text = ds.Tables("clientes").Rows(0).Item(0)
                frmAgregarProductos.TextBox1.Text = ds.Tables("clientes").Rows(0).Item(1)
                frmAgregarProductos.TextBox2.Text = ds.Tables("clientes").Rows(0).Item(2)
                frmAgregarProductos.TextBox3.Text = ds.Tables("clientes").Rows(0).Item(3)
                Hide()
                frmAgregarProductos.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class