﻿Imports System.Data.SqlClient
Public Class frmCargarVentaProductosClientes
    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With

    End Sub
    Private Sub tbxBus_TextChanged(sender As Object, e As EventArgs) Handles tbxBus.TextChanged
        If tbxBus.Text = "" Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select cast(id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido', dni as 'DNI', fecha_nac as 'Nacimiento',
edad as 'Edad',
domicilio as 'Domicilio', mail as 'Mail', telefono as 'Teléfono' from clientes")
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
            Dim sql As String = ("use flor_d select cast(id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido', dni as 'DNI', fecha_nac as 'Nacimiento',
edad as 'Edad',
domicilio as 'Domicilio', mail as 'Mail', telefono as 'Teléfono' from clientes
where concat(id_cliente, nombre_cliente, apellido_cliente, dni, fecha_nac,edad, domicilio, mail, telefono) like '%" & tbxBus.Text & "%' ORDER BY cast(id_cliente as int)")
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
        Dim sql As String = ("use flor_d select cast(id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido', dni as 'DNI', fecha_nac as 'Nacimiento',
edad as 'Edad',
domicilio as 'Domicilio', mail as 'Mail', telefono as 'Teléfono' from clientes")
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
            Dim sql As String = ("use flor_d select cast(id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido', dni as 'DNI', fecha_nac as 'Nacimiento',
edad as 'Edad',
domicilio as 'Domicilio', mail as 'Mail', telefono as 'Teléfono' from clientes")
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
            Dim sql As String = ("use flor_d select cast(id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido', dni as 'DNI', fecha_nac as 'Nacimiento',
edad as 'Edad', domicilio as 'Domicilio', mail as 'Mail', telefono as 'Teléfono' from clientes  
where concat(cast(id_cliente as int), nombre_cliente, apellido_cliente, dni, fecha_nac, edad, domicilio, mail, telefono)
like '%" & DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value & "%'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "clientes")
                frmCargarVentaProductos.TextBox2.Text = ds.Tables("clientes").Rows(0).Item(0)
                frmCargarVentaProductos.TextBox4.Text = ds.Tables("clientes").Rows(0).Item(1)
                frmCargarVentaProductos.TextBox4.Text = frmCargarVentaProductos.TextBox4.Text + " " + ds.Tables("clientes").Rows(0).Item(2)
                Close()
                frmCargarVentaProductos.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub frmConsultaCli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_consulta.Hide()
        PreVentFlicker()
        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("use flor_d select cast(id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido', dni as 'DNI', fecha_nac as 'Nacimiento',
edad as 'Edad',
domicilio as 'Domicilio', mail as 'Mail', telefono as 'Teléfono' from clientes")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cargar_consulta.Close()
        Close()
    End Sub
End Class