Imports System.Data.SqlClient
Public Class frmBuscarVentasRealizadas
    Private Sub frmBuscarTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxBus.Select()
        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("select nombre_cliente as 'Cliente', apellido_cliente as 'Apellido',
nombre_producto as 'Producto',
fecha_venta as 'Fecha',
cantidades as 'Unidades vendidas',
detalles_venta as 'Detalles'
from venta_productos

join clientes on clientes.id_cliente = venta_productos.id_cliente
join productos on productos.id_producto = venta_productos.id_producto")
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
        Dim sql As String = ("select nombre_cliente as 'Cliente', apellido_cliente as 'Apellido',
nombre_producto as 'Producto',
fecha_venta as 'Fecha',
cantidades as 'Unidades vendidas',
detalles_venta as 'Detalles'
from venta_productos

join clientes on clientes.id_cliente = venta_productos.id_cliente
join productos on productos.id_producto = venta_productos.id_producto")
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

        If Application.OpenForms().OfType(Of frmCargarVentaProductos).Any Then
            frmCargarVentaProductos.Close()
            Close()
        Else
            Close()
        End If
    End Sub

    Private Sub tbxBus_TextChanged(sender As Object, e As EventArgs) Handles tbxBus.TextChanged
        If tbxBus.Text = "" Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select nombre_cliente as 'Cliente', apellido_cliente as 'Apellido',
nombre_producto as 'Producto',
fecha_venta as 'Fecha',
cantidades as 'Unidades vendidas',
detalles_venta as 'Detalles'
from venta_productos

join clientes on clientes.id_cliente = venta_productos.id_cliente
join productos on productos.id_producto = venta_productos.id_producto")
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
            Dim sql As String = ("select nombre_cliente as 'Cliente', apellido_cliente as 'Apellido',
nombre_producto as 'Producto',
fecha_venta as 'Fecha',
cantidades as 'Unidades vendidas',
detalles_venta as 'Detalles'
from venta_productos

join clientes on clientes.id_cliente = venta_productos.id_cliente
join productos on productos.id_producto = venta_productos.id_producto

where concat(nombre_cliente, apellido_cliente, nombre_producto, fecha_venta,
cantidades, detalles_venta) like '%" & tbxBus.Text & "%' ORDER BY nombre_cliente")
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
            Dim sql As String = ("select nombre_cliente as 'Cliente', apellido_cliente as 'Apellido',
nombre_producto as 'Producto',
fecha_venta as 'Fecha',
cantidades as 'Unidades vendidas',
detalles_venta as 'Detalles'
from venta_productos

join clientes on clientes.id_cliente = venta_productos.id_cliente
join productos on productos.id_producto = venta_productos.id_producto")
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
            Dim sql As String = ("select id_venta, 
venta_productos.id_cliente, 
venta_productos.id_producto,
nombre_cliente, 
apellido_cliente ,
nombre_producto,
fecha_venta,
cantidades,
detalles_venta
from venta_productos


join clientes on clientes.id_cliente = venta_productos.id_cliente
join productos on productos.id_producto = venta_productos.id_producto

where concat(id_venta, venta_productos.id_cliente, venta_productos.id_producto,
nombre_cliente, apellido_cliente, nombre_producto, fecha_venta,
cantidades, detalles_venta) like '%" & DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value & "%'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "clientes")
                frmCargarVentaProductos.TextBox1.Text = ds.Tables("clientes").Rows(0).Item(0)
                frmCargarVentaProductos.TextBox2.Text = ds.Tables("clientes").Rows(0).Item(1)
                frmCargarVentaProductos.TextBox3.Text = ds.Tables("clientes").Rows(0).Item(2)
                frmCargarVentaProductos.TextBox4.Text = ds.Tables("clientes").Rows(0).Item(3)
                frmCargarVentaProductos.TextBox4.Text = frmCargarVentaProductos.TextBox4.Text + " " + ds.Tables("clientes").Rows(0).Item(4)
                frmCargarVentaProductos.TextBox5.Text = ds.Tables("clientes").Rows(0).Item(5)
                frmCargarVentaProductos.TextBox6.Text = ds.Tables("clientes").Rows(0).Item(6)
                frmCargarVentaProductos.DateTimePicker1.Text = ds.Tables("clientes").Rows(0).Item(6)
                frmCargarVentaProductos.TextBox7.Text = ds.Tables("clientes").Rows(0).Item(7)
                frmCargarVentaProductos.TextBox8.Text = ds.Tables("clientes").Rows(0).Item(8)
                Hide()
                frmCargarVentaProductos.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class