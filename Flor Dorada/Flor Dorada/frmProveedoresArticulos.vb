Imports System.Data.SqlClient
Public Class frmProveedoresArticulos

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex = -1 Then
            Dim myConnectionString = "Data Source=DESKTOP-K6OA7P5\SQLEXPRESS;" &
"Initial Catalog=bd_proy4;" &
"Integrated Security=True"
            Dim con As New SqlConnection(myConnectionString)
            Dim sql As String = ("select id_proveedor as 'ID', razon_social_proveedor as 'Nombre' from proveedores")
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
        ElseIf IsNumeric(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
            Dim myConnectionString = "Data Source=DESKTOP-K6OA7P5\SQLEXPRESS;" &
        "Initial Catalog=bd_proy4;" &
        "Integrated Security=True"
            Dim con As New SqlConnection(myConnectionString)
            Dim sql As String = ("select id_proveedor as 'ID' from proveedores where id_proveedor = '" & DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value & "'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "proveedores")
                frmABMArtículos.TextBox4.Text = ds.Tables("proveedores").Rows(0).Item(0)
                frmABMArtículos.TextBox1.Text = Label1.Text
                frmABMArtículos.TextBox2.Text = Label2.Text
                frmABMArtículos.TextBox3.Text = Label3.Text
                Hide()
                frmABMArtículos.Show()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Dim myConnectionString = "Data Source=DESKTOP-K6OA7P5\SQLEXPRESS;" &
"Initial Catalog=bd_proy4;" &
"Integrated Security=True"
            Dim con As New SqlConnection(myConnectionString)
            Dim sql As String = ("select id_proveedor as 'ID' from proveedores where razon_social_proveedor = '" & DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value & "'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "proveedores")
                frmABMArtículos.TextBox4.Text = ds.Tables("proveedores").Rows(0).Item(0)
                frmABMArtículos.TextBox1.Text = Label1.Text
                frmABMArtículos.TextBox2.Text = Label2.Text
                frmABMArtículos.TextBox3.Text = Label3.Text
                Hide()
                frmABMArtículos.Show()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub frmProveedoresArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
        Label1.Text = frmABMArtículos.TextBox1.Text
        Label2.Text = frmABMArtículos.TextBox2.Text
        Label3.Text = frmABMArtículos.TextBox3.Text
        Dim myConnectionString = "Data Source=DESKTOP-K6OA7P5\SQLEXPRESS;" &
"Initial Catalog=bd_proy4;" &
"Integrated Security=True"
        Dim con As New SqlConnection(myConnectionString)
        Dim sql As String = ("select id_proveedor as 'ID', razon_social_proveedor as 'Nombre' from proveedores")
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
        Hide()
        frmABMArtículos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myConnectionString = "Data Source=DESKTOP-K6OA7P5\SQLEXPRESS;" &
"Initial Catalog=bd_proy4;" &
"Integrated Security=True"
        Dim con As New SqlConnection(myConnectionString)
        Dim sql As String = ("select id_proveedor as 'ID', razon_social_proveedor as 'Nombre' from proveedores")
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

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsNumeric(TextBox1.Text) Then
                Dim myConnectionString = "Data Source=DESKTOP-K6OA7P5\SQLEXPRESS;" &
"Initial Catalog=bd_proy4;" &
"Integrated Security=True"
                Dim con As New SqlConnection(myConnectionString)
                Dim sql As String = ("select id_proveedor as 'ID', razon_social_proveedor as 'Nombre' from proveedores where id_proveedor = " & TextBox1.Text)
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
            ElseIf TextBox1.Text = "" Then
                MsgBox("No se ha ingresado datos!")
            Else
                Dim myConnectionString = "Data Source=DESKTOP-K6OA7P5\SQLEXPRESS;" &
"Initial Catalog=bd_proy4;" &
"Integrated Security=True"
                Dim con As New SqlConnection(myConnectionString)
                Dim sql As String = ("select id_proveedor as 'ID', razon_social_proveedor as 'Nombre' from proveedores where razon_social_proveedor = '" & TextBox1.Text & "'")
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
            End If
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) Then
            Dim myConnectionString = "Data Source=DESKTOP-K6OA7P5\SQLEXPRESS;" &
"Initial Catalog=bd_proy4;" &
"Integrated Security=True"
            Dim con As New SqlConnection(myConnectionString)
            Dim sql As String = ("select id_proveedor as 'ID', razon_social_proveedor as 'Nombre' from proveedores 
where id_proveedor like '%" & TextBox1.Text & "%'")
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
        ElseIf TextBox1.Text = "" Then
            Dim myConnectionString = "Data Source=DESKTOP-K6OA7P5\SQLEXPRESS;" &
"Initial Catalog=bd_proy4;" &
"Integrated Security=True"
            Dim con As New SqlConnection(myConnectionString)
            Dim sql As String = ("select id_proveedor as 'ID', razon_social_proveedor as 'Nombre' from proveedores")
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
            Dim myConnectionString = "Data Source=DESKTOP-K6OA7P5\SQLEXPRESS;" &
"Initial Catalog=bd_proy4;" &
"Integrated Security=True"
            Dim con As New SqlConnection(myConnectionString)
            Dim sql As String = ("select id_proveedor as 'ID', razon_social_proveedor as 'Nombre' 
from proveedores where razon_social_proveedor like '%" & TextBox1.Text & "%'")
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
        End If
    End Sub
End Class