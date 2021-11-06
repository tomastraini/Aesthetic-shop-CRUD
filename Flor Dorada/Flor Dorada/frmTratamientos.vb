Imports System.Data.SqlClient
Public Class frmTratamientos
    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With

    End Sub
    Private Sub frmTratamientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreVentFlicker()
        TextBox2.Select()
        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("select id_tratamiento as 'ID tratamiento', 
nombre_tratamiento as 'Tratamiento', precio_tratamiento as 'Precio' from tratamientos")
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
        Dim con2 As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql2 As String = ("use flor_d select max(cast(id_tratamiento as int)) from tratamientos")
        Dim com2 As New SqlCommand(sql2, con2)
        Try
            Dim ds2 As New DataSet
            Dim da2 As New SqlDataAdapter(com2)
            da2.Fill(ds2, "clientes")
            TextBox1.Text = ds2.Tables(0).Rows(0).Item(0)
            TextBox1.Text = TextBox1.Text + 1
        Catch ex As Exception
            TextBox1.Text = "1"
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("select id_tratamiento as 'ID tratamiento', 
nombre_tratamiento as 'Tratamiento', precio_tratamiento as 'Precio' from tratamientos")
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

    Private Sub tbxBus_TextChanged(sender As Object, e As EventArgs) Handles tbxBus.TextChanged
        If tbxBus.Text = "" Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select id_tratamiento as 'ID tratamiento', 
nombre_tratamiento as 'Tratamiento', precio_tratamiento as 'Precio' from tratamientos")
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
            Dim sql As String = ("use flor_d select id_tratamiento as 'ID tratamiento', 
nombre_tratamiento as 'Tratamiento', precio_tratamiento as 'Precio' from tratamientos
where concat(id_tratamiento, nombre_tratamiento, precio_tratamiento) like '%" & tbxBus.Text & "%' ORDER BY cast(id_tratamiento as int)")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "tratamientos")
                DataGridView1.DataSource = ds.Tables("tratamientos")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        If (TextBox2.Text = "" Or TextBox1.Text = "" Or TextBox3.Text = "") Then
            MsgBox("Faltan campos por completar!")
        Else

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("use flor_d
insert into tratamientos
values(" & TextBox1.Text & ", '" & TextBox2.Text & "', '" & TextBox3.Text & "')")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "tratamientos")
                DataGridView1.DataSource = ds.Tables("tratamientos")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim con2 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql2 As String = ("select id_tratamiento as 'ID tratamiento', 
nombre_tratamiento as 'Tratamiento', precio_tratamiento as 'Precio' from tratamientos")
            Dim com2 As New SqlCommand(sql2, con2)
            Try
                Dim ds2 As New DataSet
                Dim da2 As New SqlDataAdapter(com2)
                da2.Fill(ds2, "clientes")
                DataGridView1.DataSource = ds2.Tables("clientes")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim con3 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql3 As String = ("use flor_d select max(cast(id_tratamiento as int)) from tratamientos")
            Dim com3 As New SqlCommand(sql3, con3)
            Try
                Dim ds3 As New DataSet
                Dim da3 As New SqlDataAdapter(com3)
                da3.Fill(ds3, "clientes")
                TextBox1.Text = ds3.Tables(0).Rows(0).Item(0)
                TextBox1.Text = TextBox1.Text + 1
                TextBox2.Text = ""
                TextBox3.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        If (TextBox2.Text = "" Or TextBox1.Text = "" Or TextBox3.Text = "") Then
            MsgBox("Faltan campos por completar!")
        Else

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("use flor_d delete from tratamientos
where id_tratamiento = '" & TextBox1.Text & "' 
and nombre_tratamiento = '" & TextBox2.Text & "' and precio_tratamiento = '" & TextBox3.Text & "'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "proveedores")
                DataGridView1.DataSource = ds.Tables("proveedores")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As Exception
                MsgBox("Hay datos cargados de ese cliente!")
            End Try

            Dim con2 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql2 As String = ("select id_tratamiento as 'ID tratamiento', 
nombre_tratamiento as 'Tratamiento', precio_tratamiento as 'Precio' from tratamientos")
            Dim com2 As New SqlCommand(sql2, con2)
            Try
                Dim ds2 As New DataSet
                Dim da2 As New SqlDataAdapter(com2)
                da2.Fill(ds2, "tratamientos")
                DataGridView1.DataSource = ds2.Tables("tratamientos")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim con3 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql3 As String = ("use flor_d select max(cast(id_tratamiento as int)) from tratamientos")
            Dim com3 As New SqlCommand(sql3, con3)
            Try
                Dim ds3 As New DataSet
                Dim da3 As New SqlDataAdapter(com3)
                da3.Fill(ds3, "tratamientos")
                TextBox1.Text = ds3.Tables(0).Rows(0).Item(0)
                TextBox1.Text = TextBox1.Text + 1
                TextBox2.Text = ""
                TextBox3.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "") Then
            MsgBox("Faltan campos por completar!")
        Else

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("use flor_d
update tratamientos set id_tratamiento = '" & TextBox1.Text & "', 
nombre_tratamiento = '" & TextBox2.Text & "',
precio_tratamiento = '" & TextBox3.Text & "'
where id_tratamiento = '" & TextBox1.Text & "'")
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

            Dim con2 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql2 As String = ("select id_tratamiento as 'ID tratamiento', 
nombre_tratamiento as 'Tratamiento', precio_tratamiento as 'Precio' from tratamientos")
            Dim com2 As New SqlCommand(sql2, con2)
            Try
                Dim ds2 As New DataSet
                Dim da2 As New SqlDataAdapter(com2)
                da2.Fill(ds2, "clientes")
                DataGridView1.DataSource = ds2.Tables("clientes")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim con3 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql3 As String = ("use flor_d select max(cast(id_tratamiento as int)) from tratamientos")
            Dim com3 As New SqlCommand(sql3, con3)
            Try
                Dim ds3 As New DataSet
                Dim da3 As New SqlDataAdapter(com3)
                da3.Fill(ds3, "clientes")
                TextBox1.Text = ds3.Tables(0).Rows(0).Item(0)
                TextBox1.Text = TextBox1.Text + 1
                TextBox2.Text = ""
                TextBox3.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex = -1 Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select id_tratamiento as 'ID tratamiento', 
nombre_tratamiento as 'Tratamiento', precio_tratamiento as 'Precio' from tratamientos")
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
            Dim sql As String = ("select id_tratamiento as 'ID tratamiento', 
nombre_tratamiento as 'Tratamiento', precio_tratamiento as 'Precio' from tratamientos
where concat(cast(id_tratamiento as int), nombre_tratamiento, precio_tratamiento)
like '%" & DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value & "%'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "clientes")
                TextBox1.Text = ds.Tables("clientes").Rows(0).Item(0)
                TextBox2.Text = ds.Tables("clientes").Rows(0).Item(1)
                TextBox3.Text = ds.Tables("clientes").Rows(0).Item(2)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con2 As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql2 As String = ("use flor_d select max(cast(id_tratamiento as int)) from tratamientos")
        Dim com2 As New SqlCommand(sql2, con2)
        Try
            Dim ds2 As New DataSet
            Dim da2 As New SqlDataAdapter(com2)
            da2.Fill(ds2, "clientes")
            TextBox1.Text = ds2.Tables(0).Rows(0).Item(0)
            TextBox1.Text = TextBox1.Text + 1
            TextBox2.Text = ""
            TextBox3.Text = ""
        Catch ex As Exception
            TextBox1.Text = "1"
        End Try
    End Sub
End Class