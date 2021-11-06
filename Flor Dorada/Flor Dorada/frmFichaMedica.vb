Imports System.Data.SqlClient
Public Class frmFichaMedica
    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With

    End Sub
    Private Sub frmFichaMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreVentFlicker()
        If (Me.Owner.Name = "frmMenu") Then
            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select cast(clientes.id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido',
id_ficha_clinica as 'Ficha médica', 
ocupacion as 'Ocupación', 
parado as 'Parado/sentado',
enfermedades as 'Enfermedades',
medicamentos as 'Medicamentos',
cirugias as 'Cirugías', 
embarazos as 'Embarazos',
tip_embarazo as 'Tipo de parto',
menopausia as 'Menopausia',
alergias as 'Alergias'
from clientes  
join ficha_medica on  ficha_medica.id_cliente =clientes.id_cliente")
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
            Dim sql2 As String = ("use flor_d select max(cast(id_ficha_clinica as int)) from ficha_medica")
            Dim com2 As New SqlCommand(sql2, con2)
            Try
                Dim ds2 As New DataSet
                Dim da2 As New SqlDataAdapter(com2)
                da2.Fill(ds2, "clientes")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ds2.Tables(0).Rows(0).Item(0)
                TextBox4.Text = TextBox4.Text + 1
                TextBox5.Text = ""
                ComboBox1.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                ComboBox2.Text = ""
                TextBox11.Text = ""
                frmFichaClientes.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf (Me.Owner.Name = "frmHabitos")
            Dim con5 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql5 As String = ("select cast(clientes.id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido',
id_ficha_clinica as 'Ficha médica', 
ocupacion as 'Ocupación', 
parado as 'Parado/sentado',
enfermedades as 'Enfermedades',
medicamentos as 'Medicamentos',
cirugias as 'Cirugías', 
embarazos as 'Embarazos',
tip_embarazo as 'Tipo de parto',
menopausia as 'Menopausia',
alergias as 'Alergias'
from clientes  
join ficha_medica on  ficha_medica.id_cliente =clientes.id_cliente")
            Dim com5 As New SqlCommand(sql5, con5)
            Try
                Dim ds5 As New DataSet
                Dim da5 As New SqlDataAdapter(com5)
                da5.Fill(ds5, "clientes")
                DataGridView1.DataSource = ds5.Tables("clientes")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim con7 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql7 As String = ("use flor_d select max(cast(id_ficha_clinica as int)) from ficha_medica")
            Dim com7 As New SqlCommand(sql7, con7)
            Try
                Dim ds7 As New DataSet
                Dim da7 As New SqlDataAdapter(com7)
                da7.Fill(ds7, "clientes")
                TextBox4.Text = ds7.Tables(0).Rows(0).Item(0)
                TextBox4.Text = TextBox4.Text + 1

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub tbxBus_TextChanged(sender As Object, e As EventArgs) Handles tbxBus.TextChanged
        If tbxBus.Text = "" Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select cast(clientes.id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido',
id_ficha_clinica as 'Ficha médica', 
ocupacion as 'Ocupación', 
parado as 'Parado/sentado',
enfermedades as 'Enfermedades',
medicamentos as 'Medicamentos',
cirugias as 'Cirugías', 
embarazos as 'Embarazos',
tip_embarazo as 'Tipo de parto',
menopausia as 'Menopausia',
alergias as 'Alergias'
from clientes  
join ficha_medica on  ficha_medica.id_cliente =clientes.id_cliente")
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
            Dim sql As String = ("select cast(clientes.id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido',
id_ficha_clinica as 'Ficha médica', 
ocupacion as 'Ocupación', 
parado as 'Parado/sentado',
enfermedades as 'Enfermedades',
medicamentos as 'Medicamentos',
cirugias as 'Cirugías', 
embarazos as 'Embarazos',
tip_embarazo as 'Tipo de parto',
menopausia as 'Menopausia',
alergias as 'Alergias'
from clientes  
join ficha_medica on  ficha_medica.id_cliente =clientes.id_cliente
where concat(cast(clientes.id_cliente as int), nombre_cliente, apellido_cliente,
id_ficha_clinica, ocupacion, parado, enfermedades, medicamentos, cirugias, embarazos, tip_embarazo, menopausia,
alergias) like '%" & tbxBus.Text & "%'")
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
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("select cast(clientes.id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido',
id_ficha_clinica as 'Ficha médica', 
ocupacion as 'Ocupación', 
parado as 'Parado/sentado',
enfermedades as 'Enfermedades',
medicamentos as 'Medicamentos',
cirugias as 'Cirugías', 
embarazos as 'Embarazos',
tip_embarazo as 'Tipo de parto',
menopausia as 'Menopausia',
alergias as 'Alergias'
from clientes  
join ficha_medica on  ficha_medica.id_cliente =clientes.id_cliente")
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        ComboBox2.Text = ""
        TextBox11.Text = ""
        Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim con2 As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql2 As String = ("use flor_d select max(cast(id_ficha_clinica as int)) from ficha_medica")
        Dim com2 As New SqlCommand(sql2, con2)
        Try
            Dim ds2 As New DataSet
            Dim da2 As New SqlDataAdapter(com2)
            da2.Fill(ds2, "clientes")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ds2.Tables(0).Rows(0).Item(0)
            TextBox4.Text = TextBox4.Text + 1
            TextBox5.Text = ""
            ComboBox1.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            ComboBox2.Text = ""
            TextBox11.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmFichaClientes.ShowDialog()
    End Sub
    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown
        If (e.KeyCode = Keys.Down) Then
            tbxBus.Select()

        ElseIf (e.KeyCode = Keys.Escape) Then
            Close()

        ElseIf (e.KeyCode = Keys.F1) Then
            frmFichaClientes.ShowDialog()
        End If
    End Sub

    Private Sub tbxBus_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxBus.KeyDown
        If (e.KeyCode = Keys.Up) Then
            TextBox5.Select()
        End If
    End Sub

    Private Sub TextBox11_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox11.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("use flor_d
insert into
ficha_medica values(" & TextBox4.Text & ", 
'" & TextBox1.Text & "', 
'" & TextBox5.Text & "', 
'" & ComboBox1.Text & "', 
'" & TextBox6.Text & "', 
'" & TextBox7.Text & "', 
'" & TextBox8.Text & "', 
'" & TextBox9.Text & "', 
'" & TextBox10.Text & "', 
'" & ComboBox2.Text & "', 
'" & TextBox11.Text & "')")
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
            Dim sql2 As String = ("select cast(clientes.id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido',
id_ficha_clinica as 'Ficha médica', 
ocupacion as 'Ocupación', 
parado as 'Parado/sentado',
enfermedades as 'Enfermedades',
medicamentos as 'Medicamentos',
cirugias as 'Cirugías', 
embarazos as 'Embarazos',
tip_embarazo as 'Tipo de parto',
menopausia as 'Menopausia',
alergias as 'Alergias'
from clientes  
join ficha_medica on  ficha_medica.id_cliente =clientes.id_cliente")
            Dim com2 As New SqlCommand(sql2, con2)
            Try
                Dim ds2 As New DataSet
                Dim da2 As New SqlDataAdapter(com2)
                da2.Fill(ds2, "clientes")
                DataGridView1.DataSource = ds2.Tables("clientes")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim con3 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql3 As String = ("use flor_d select max(cast(id_ficha_clinica as int)) from ficha_medica")
            Dim com3 As New SqlCommand(sql3, con3)
            Try
                Dim ds3 As New DataSet
                Dim da3 As New SqlDataAdapter(com3)
                da3.Fill(ds3, "clientes")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ds3.Tables(0).Rows(0).Item(0)
                TextBox4.Text = TextBox4.Text + 1
                TextBox5.Text = ""
                ComboBox1.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                ComboBox2.Text = ""
                TextBox11.Text = ""
                TextBox5.Select()
                If (Me.Owner.Name = "frmHabitos") Then
                    Dim result2 As DialogResult = MsgBox("¿Quiere continuar cargando clientes?", MessageBoxButtons.YesNo)
                    If (result2 = DialogResult.Yes) Then
                        frmABMClientes.Show()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim result As DialogResult = MsgBox("Quiere eliminar al cliente?", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            If e.RowIndex = -1 Then

                Dim con5 As New SqlConnection(My.Settings.myConnectionString3)
                Dim sql5 As String = ("select cast(clientes.id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido',
id_ficha_clinica as 'Ficha médica', 
ocupacion as 'Ocupación', 
parado as 'Parado/sentado',
enfermedades as 'Enfermedades',
medicamentos as 'Medicamentos',
cirugias as 'Cirugías', 
embarazos as 'Embarazos',
tip_embarazo as 'Tipo de parto',
menopausia as 'Menopausia',
alergias as 'Alergias'
from clientes  
join ficha_medica on  ficha_medica.id_cliente =clientes.id_cliente")
                Dim com5 As New SqlCommand(sql5, con5)
                Try
                    Dim ds5 As New DataSet
                    Dim da5 As New SqlDataAdapter(com5)
                    da5.Fill(ds5, "clientes")
                    DataGridView1.DataSource = ds5.Tables("clientes")
                    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            ElseIf (IsNumeric(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value))

                Dim con7 As New SqlConnection(My.Settings.myConnectionString3)
                Dim sql7 As String = ("use flor_d delete from ficha_medica
where id_cliente = " & Val(DataGridView1.Rows(e.RowIndex).Cells(0).Value) & "")
                Dim com7 As New SqlCommand(sql7, con7)
                Try
                    Dim ds7 As New DataSet
                    Dim da7 As New SqlDataAdapter(com7)
                    da7.Fill(ds7, "clientes")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Dim con4 As New SqlConnection(My.Settings.myConnectionString3)
                Dim sql4 As String = ("use flor_d delete from ficha_medica
where id_cliente = " & DataGridView1.Rows(e.RowIndex).Cells(0).Value & "")
                Dim com4 As New SqlCommand(sql4, con4)
                Try
                    Dim ds4 As New DataSet
                    Dim da4 As New SqlDataAdapter(com4)
                    da4.Fill(ds4, "clientes")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            Dim con10 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql10 As String = ("select cast(clientes.id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido',
id_ficha_clinica as 'Ficha médica', 
ocupacion as 'Ocupación', 
parado as 'Parado/sentado',
enfermedades as 'Enfermedades',
medicamentos as 'Medicamentos',
cirugias as 'Cirugías', 
embarazos as 'Embarazos',
tip_embarazo as 'Tipo de parto',
menopausia as 'Menopausia',
alergias as 'Alergias'
from clientes  
join ficha_medica on  ficha_medica.id_cliente =clientes.id_cliente")
            Dim com10 As New SqlCommand(sql10, con10)
            Try
                Dim ds10 As New DataSet
                Dim da10 As New SqlDataAdapter(com10)
                da10.Fill(ds10, "clientes")
                DataGridView1.DataSource = ds10.Tables("clientes")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim con2 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql2 As String = ("use flor_d select max(cast(id_ficha_clinica as int)) from ficha_medica")
            Dim com2 As New SqlCommand(sql2, con2)
            Try
                Dim ds2 As New DataSet
                Dim da2 As New SqlDataAdapter(com2)
                da2.Fill(ds2, "clientes")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ds2.Tables(0).Rows(0).Item(0)
                TextBox4.Text = TextBox4.Text + 1
                TextBox5.Text = ""
                ComboBox1.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                ComboBox2.Text = ""
                TextBox11.Text = ""
                TextBox5.Select()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox9.Text = "") Then
            MsgBox("Faltan campos por completar!")
        Else

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("update ficha_medica set 
ocupacion = '" & TextBox5.Text & "',
parado = '" & ComboBox1.Text & "',
enfermedades = '" & TextBox6.Text & "',
medicamentos = '" & TextBox7.Text & "', 
cirugias = '" & TextBox8.Text & "', 
embarazos = '" & TextBox9.Text & "', 
tip_embarazo = '" & TextBox10.Text & "',
menopausia = '" & ComboBox2.Text & "', 
alergias = '" & TextBox11.Text & "'
where id_ficha_clinica = '" & TextBox4.Text & "'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "ficha_medica")
                DataGridView1.DataSource = ds.Tables("ficha_medica")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim con2 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql2 As String = ("select cast(clientes.id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido',
id_ficha_clinica as 'Ficha médica', 
ocupacion as 'Ocupación', 
parado as 'Parado/sentado',
enfermedades as 'Enfermedades',
medicamentos as 'Medicamentos',
cirugias as 'Cirugías', 
embarazos as 'Embarazos',
tip_embarazo as 'Tipo de parto',
menopausia as 'Menopausia',
alergias as 'Alergias'
from clientes  
join ficha_medica on  ficha_medica.id_cliente =clientes.id_cliente")
            Dim com2 As New SqlCommand(sql2, con2)
            Try
                Dim ds2 As New DataSet
                Dim da2 As New SqlDataAdapter(com2)
                da2.Fill(ds2, "clientes")
                DataGridView1.DataSource = ds2.Tables("clientes")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim con3 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql3 As String = ("use flor_d select max(cast(id_ficha_clinica as int)) from ficha_medica")
            Dim com3 As New SqlCommand(sql3, con3)
            Try
                Dim ds3 As New DataSet
                Dim da3 As New SqlDataAdapter(com3)
                da3.Fill(ds3, "clientes")
                da3.Fill(ds3, "clientes")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ds3.Tables(0).Rows(0).Item(0)
                TextBox4.Text = TextBox4.Text + 1
                TextBox5.Text = ""
                ComboBox1.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                ComboBox2.Text = ""
                TextBox11.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex = -1 Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("select cast(clientes.id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido',
id_ficha_clinica as 'Ficha médica', 
ocupacion as 'Ocupación', 
parado as 'Parado/sentado',
enfermedades as 'Enfermedades',
medicamentos as 'Medicamentos',
cirugias as 'Cirugías', 
embarazos as 'Embarazos',
tip_embarazo as 'Tipo de parto',
menopausia as 'Menopausia',
alergias as 'Alergias'
from clientes  
join ficha_medica on  ficha_medica.id_cliente =clientes.id_cliente")
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
            Dim sql As String = ("select cast(clientes.id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido',
id_ficha_clinica as 'Ficha médica', 
ocupacion as 'Ocupación', 
parado as 'Parado/sentado',
enfermedades as 'Enfermedades',
medicamentos as 'Medicamentos',
cirugias as 'Cirugías', 
embarazos as 'Embarazos',
tip_embarazo as 'Tipo de parto',
menopausia as 'Menopausia',
alergias as 'Alergias'
from clientes  
join ficha_medica on  ficha_medica.id_cliente =clientes.id_cliente
where concat(cast(clientes.id_cliente as int), nombre_cliente, apellido_cliente,
id_ficha_clinica, ocupacion, parado, enfermedades, medicamentos, cirugias, embarazos, tip_embarazo, menopausia,
alergias) like '%" & DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value & "%'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "clientes")
                TextBox1.Text = ds.Tables("clientes").Rows(0).Item(0)
                TextBox2.Text = ds.Tables("clientes").Rows(0).Item(1)
                TextBox3.Text = ds.Tables("clientes").Rows(0).Item(2)
                TextBox4.Text = ds.Tables("clientes").Rows(0).Item(3)
                TextBox5.Text = ds.Tables("clientes").Rows(0).Item(4)
                ComboBox1.Text = ds.Tables("clientes").Rows(0).Item(5)
                TextBox6.Text = ds.Tables("clientes").Rows(0).Item(6)
                TextBox7.Text = ds.Tables("clientes").Rows(0).Item(7)
                TextBox8.Text = ds.Tables("clientes").Rows(0).Item(8)
                TextBox9.Text = ds.Tables("clientes").Rows(0).Item(9)
                TextBox10.Text = ds.Tables("clientes").Rows(0).Item(10)
                ComboBox2.Text = ds.Tables("clientes").Rows(0).Item(11)
                TextBox11.Text = ds.Tables("clientes").Rows(0).Item(12)
                TextBox5.Select()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

End Class