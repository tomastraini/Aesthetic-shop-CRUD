Imports System.Data.SqlClient
Public Class frmLoginUS
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


        If (e.RowIndex = -1) Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("use flor_d select id_usuario as ID, usu as 'Usuario' from usuarios")
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
            Dim sql As String = ("use flor_d select id_usuario as ID, usu as 'Usuario' from usuarios where id_usuario = '" & DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value & "'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "usuarios")
                frmLogin.tbxUs.Text = ds.Tables("usuarios").Rows(0).Item(1)
                frmLogin.tbxUs.Select()
                Hide()
                frmLogin.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("use flor_d select id_usuario as ID, usu as 'Usuario' from usuarios where usu = '" & DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value & "'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "usuarios")

                frmLogin.tbxUs.Text = ds.Tables("usuarios").Rows(0).Item(1)
                Hide()
                frmLogin.tbxUs.Select()
                frmLogin.Show()
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

    Private Sub frmLoginUS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreVentFlicker()
        TextBox1.Select()

        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("use flor_d select id_usuario as ID, usu as 'Usuario' from usuarios")
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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        frmLogin.tbxUs.Select()
        frmLogin.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("use flor_d select id_usuario as ID, usu as 'Usuario' from usuarios")
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
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsNumeric(TextBox1.Text) Then

                Dim con As New SqlConnection(My.Settings.myConnectionString3)
                Dim sql As String = ("use flor_d select id_usuario as ID, usu as 'Usuario' from usuarios where id_usuario = " & TextBox1.Text & "")
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
            ElseIf TextBox1.Text = "" Then
                MsgBox("No se ha ingresado datos!")
            Else

                Dim con As New SqlConnection(My.Settings.myConnectionString3)
                Dim sql As String = ("use flor_d select id_usuario as ID, usu as 'Usuario' from usuarios where usuario = '" & TextBox1.Text & "'")
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
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("use flor_d 
select id_usuario as ID, usu as 'Usuario' 
from usuarios where id_usuario = '%" & TextBox1.Text & "%'")
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
        ElseIf TextBox1.Text = "" Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("use flor_d select id_usuario as ID, usu as 'Usuario' from usuarios")
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
        Else

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("use flor_d 
select id_usuario as ID, usu as 'Usuario' 
from usuarios where usu like '%" & TextBox1.Text & "%'")
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
        End If
    End Sub
End Class