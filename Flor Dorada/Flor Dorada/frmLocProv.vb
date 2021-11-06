﻿Imports System.Data.SqlClient
Public Class frmLocProv
    Private Sub frmLocProv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
        Dim myConnectionString = "Data Source=DESKTOP-K6OA7P5\SQLEXPRESS;" &
             "Initial Catalog=bd_proy4;" &
             "Integrated Security=True"
        Dim con As New SqlConnection(myConnectionString)
        Dim sql As String = ("use bd_proy4 select id_provincia as 'ID', provincia as 'Provincia' from provincias")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "provincias")
            DataGridView1.DataSource = ds.Tables("provincias")
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex = -1 Then
            Dim myConnectionString = "Data Source=DESKTOP-K6OA7P5\SQLEXPRESS;" &
      "Initial Catalog=bd_proy4;" &
      "Integrated Security=True"
            Dim con As New SqlConnection(myConnectionString)
            Dim sql As String = ("use bd_proy4 select id_provincia as 'ID', provincia as 'Provincia' from provincias")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "provincias")
                DataGridView1.DataSource = ds.Tables("provincias")
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
            Dim sql As String = ("use bd_proy4 select id_provincia as 'ID', provincia as 'Provincia' from provincias where id_provincia = '" & DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value & "'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "provincias")

                frmABMLocalidades.TextBox3.Text = ds.Tables("provincias").Rows(0).Item(0)
                Hide()
                frmABMLocalidades.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Dim myConnectionString = "Data Source=DESKTOP-K6OA7P5\SQLEXPRESS;" &
"Initial Catalog=bd_proy4;" &
"Integrated Security=True"
        Dim con As New SqlConnection(myConnectionString)
        Dim sql As String = ("use bd_proy4 select id_provincia as 'ID', provincia as 'Provincia' from provincias where provincia = '" & DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value & "'")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "provincias")

            frmABMLocalidades.TextBox3.Text = ds.Tables("provincias").Rows(0).Item(0)
            Hide()
            frmABMLocalidades.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        frmABMLocalidades.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myConnectionString = "Data Source=DESKTOP-K6OA7P5\SQLEXPRESS;" &
     "Initial Catalog=bd_proy4;" &
     "Integrated Security=True"
        Dim con As New SqlConnection(myConnectionString)
        Dim sql As String = ("use bd_proy4 select id_provincia as 'ID', provincia as 'Provincia' from provincias")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "provincias")
            DataGridView1.DataSource = ds.Tables("provincias")
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
                Dim sql As String = ("use bd_proy4 select id_provincia as 'ID', provincia as 'Provincia' from provincias where id_provincia = " & TextBox1.Text & "")
                Dim com As New SqlCommand(sql, con)
                Try
                    Dim ds As New DataSet
                    Dim da As New SqlDataAdapter(com)
                    da.Fill(ds, "provincias")
                    DataGridView1.DataSource = ds.Tables("provincias")
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
                Dim sql As String = ("use bd_proy4 select id_provincia as 'ID', provincia as 'Provincia' from provincias where provincia = '" & TextBox1.Text & "'")
                Dim com As New SqlCommand(sql, con)
                Try
                    Dim ds As New DataSet
                    Dim da As New SqlDataAdapter(com)
                    da.Fill(ds, "provincias")
                    DataGridView1.DataSource = ds.Tables("provincias")
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
            Dim sql As String = ("use bd_proy4 
select id_provincia as 'ID', provincia as 'Provincia' 
from provincias where id_provincia like '%" & TextBox1.Text & "%'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "provincias")
                DataGridView1.DataSource = ds.Tables("provincias")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf TextBox1.Text = "" Then
            Dim myConnectionString = "Data Source=DESKTOP-K6OA7P5\SQLEXPRESS;" &
                  "Initial Catalog=bd_proy4;" &
                  "Integrated Security=True"
            Dim con As New SqlConnection(myConnectionString)
            Dim sql As String = ("use bd_proy4 select id_provincia as 'ID', provincia as 'Provincia' from provincias")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "provincias")
                DataGridView1.DataSource = ds.Tables("provincias")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Dim myConnectionString = "Data Source=DESKTOP-K6OA7P5\SQLEXPRESS;" &
 "Initial Catalog=bd_proy4;" &
 "Integrated Security=True"
            Dim con As New SqlConnection(myConnectionString)
            Dim sql As String = ("use bd_proy4 
select id_provincia as 'ID', provincia as 'Provincia' 
from provincias where provincia like '%" & TextBox1.Text & "%'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "provincias")
                DataGridView1.DataSource = ds.Tables("provincias")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class