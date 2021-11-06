Imports System.Data.SqlClient
Public Class frmUsuarios
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex = -1 Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select id_usuario as ID, usu as 'Nombre de usuario', psw as 'Contraseña', permiso as 'Permisos' from usuarios")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "usuarios")
                DataGridView1.DataSource = ds.Tables("usuarios")
                DataGridView1.Sort(DataGridView1.Columns(e.ColumnIndex), System.ComponentModel.ListSortDirection.Ascending)
                DataGridView1.Sort(DataGridView1.Columns(e.ColumnIndex), System.ComponentModel.ListSortDirection.Descending)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf IsNumeric(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select * from usuarios 
where id_usuario = '" & DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value & "'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "usuarios")
                TextBox1.Text = ds.Tables("usuarios").Rows(0).Item(0)
                TextBox2.Text = ds.Tables("usuarios").Rows(0).Item(1)
                TextBox3.Text = ds.Tables("usuarios").Rows(0).Item(2)
                ComboBox1.Text = ds.Tables("usuarios").Rows(0).Item(3)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select * from usuarios
where usu = '" & DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value & "' or psw = '" & DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value & "'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "usuarios")
                TextBox1.Text = ds.Tables("usuarios").Rows(0).Item(0)
                TextBox2.Text = ds.Tables("usuarios").Rows(0).Item(1)
                TextBox3.Text = ds.Tables("usuarios").Rows(0).Item(2)
                ComboBox1.Text = ds.Tables("usuarios").Rows(0).Item(3)
            Catch ex As Exception
                MsgBox(ex.Message)
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
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreVentFlicker()
        tbxBus.Select()

        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("select id_usuario as ID, 
usu as 'Nombre de usuario', psw as 'Contraseña', permiso as 'Permisos' from usuarios")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "usuarios")
            DataGridView1.DataSource = ds.Tables("usuarios")
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim con3 As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql3 As String = ("select max(cast(id_usuario as int)) from usuarios")
        Dim com3 As New SqlCommand(sql3, con3)
        Try
            Dim ds3 As New DataSet
            Dim da3 As New SqlDataAdapter(com3)
            da3.Fill(ds3, "usuarios")
            TextBox1.Text = ds3.Tables(0).Rows(0).Item(0)
            TextBox1.Text = TextBox1.Text + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("select id_usuario as ID, usu as 'Nombre de usuario', psw as 'Contraseña', permiso as 'Permisos' from usuarios")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "usuarios")
            DataGridView1.DataSource = ds.Tables("usuarios")
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        Close()
    End Sub

    Private Sub tbxBus_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxBus.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select id_usuario as ID, usu as 'Nombre de usuario', psw as 'Contraseña', 
permiso as 'Permisos' from usuarios where id_usuario = '" & tbxBus.Text & "' or usu = '" & tbxBus.Text & "' or psw = '" & tbxBus.Text & "'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "usuarios")
                DataGridView1.DataSource = ds.Tables("usuarios")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        If (TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "") Then
            MsgBox("Faltan campos por completar!")
        Else

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("use flor_d insert into usuarios values('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & ComboBox1.Text & "')")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "usuarios")
                DataGridView1.DataSource = ds.Tables("usuarios")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim con2 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql2 As String = ("select id_usuario as ID, usu as 'Nombre de usuario', 
psw as 'Contraseña', permiso as 'Permisos' from usuarios")
            Dim com2 As New SqlCommand(sql2, con2)
            Try
                Dim ds2 As New DataSet
                Dim da2 As New SqlDataAdapter(com2)
                da2.Fill(ds2, "usuarios")
                DataGridView1.DataSource = ds2.Tables("usuarios")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim con3 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql3 As String = ("select max(cast(id_usuario as int)) from usuarios")
            Dim com3 As New SqlCommand(sql3, con3)
            Try
                Dim ds3 As New DataSet
                Dim da3 As New SqlDataAdapter(com3)
                da3.Fill(ds3, "usuarios")
                TextBox1.Text = ds3.Tables(0).Rows(0).Item(0)
                TextBox1.Text = TextBox1.Text + 1
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "") Then
            MsgBox("Faltan campos por completar!")
        Else

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("use flor_d delete from usuarios
where id_usuario = " & TextBox1.Text & " and usu = '" & TextBox2.Text & "' and psw = '" & TextBox3.Text & "' and permiso = '" & ComboBox1.Text & "'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "usuarios")
                DataGridView1.DataSource = ds.Tables("usuarios")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim con2 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql2 As String = ("select id_usuario as ID, usu as 'Nombre de usuario', 
psw as 'Contraseña', permiso as 'Permisos' from usuarios")
            Dim com2 As New SqlCommand(sql2, con2)
            Try
                Dim ds2 As New DataSet
                Dim da2 As New SqlDataAdapter(com2)
                da2.Fill(ds2, "usuarios")
                DataGridView1.DataSource = ds2.Tables("usuarios")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim con3 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql3 As String = ("select max(cast(id_usuario as int)) from usuarios")
            Dim com3 As New SqlCommand(sql3, con3)
            Try
                Dim ds3 As New DataSet
                Dim da3 As New SqlDataAdapter(com3)
                da3.Fill(ds3, "usuarios")
                TextBox1.Text = ds3.Tables(0).Rows(0).Item(0)
                TextBox1.Text = TextBox1.Text + 1
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
            Dim sql As String = ("use flor_d update usuarios set usu = '" & TextBox2.Text & "', psw= '" & TextBox3.Text & "', permiso= '" & ComboBox1.Text & "' 
where id_usuario = " & TextBox1.Text & "")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "usuarios")
                DataGridView1.DataSource = ds.Tables("usuarios")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim con2 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql2 As String = ("select id_usuario as ID, usu as 'Nombre de usuario', psw as 'Contraseña', permiso as 'Permisos' from usuarios")
            Dim com2 As New SqlCommand(sql2, con2)
            Try
                Dim ds2 As New DataSet
                Dim da2 As New SqlDataAdapter(com2)
                da2.Fill(ds2, "usuarios")
                DataGridView1.DataSource = ds2.Tables("usuarios")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim con3 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql3 As String = ("select max(cast(id_usuario as int)) from usuarios")
            Dim com3 As New SqlCommand(sql3, con3)
            Try
                Dim ds3 As New DataSet
                Dim da3 As New SqlDataAdapter(com3)
                da3.Fill(ds3, "usuarios")
                TextBox1.Text = ds3.Tables(0).Rows(0).Item(0)
                TextBox1.Text = TextBox1.Text + 1
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub tbxBus_TextChanged(sender As Object, e As EventArgs) Handles tbxBus.TextChanged

        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("use flor_d select id_usuario as ID, usu as 'Nombre de usuario', psw as 'Contraseña', permiso as 'Permisos' 
from usuarios where concat(id_usuario, usu, psw, permiso) like '%" & tbxBus.Text & "%'")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "usuarios")
            DataGridView1.DataSource = ds.Tables("usuarios")
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
    End Sub
End Class
