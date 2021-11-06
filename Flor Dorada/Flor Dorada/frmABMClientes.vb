Imports System.Data.SqlClient
Public Class frmABMClientes
    '  Data Source=192.168.0.116,1433;Initial Catalog=flor_d;User ID=Admin;Password=x
    '  Data Source=10HOME\SQLEXPRESS;Initial Catalog=flor_d;Integrated Security=True
    '  Data Source=192.168.0.116;Initial Catalog=flor_d;User ID=santa;Password=x
    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With

    End Sub
    Private Sub frmABMClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreVentFlicker()

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
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim con2 As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql2 As String = ("use flor_d select max(cast(id_cliente as int)) from clientes")
        Dim com2 As New SqlCommand(sql2, con2)
        Try
            Dim ds2 As New DataSet
            Dim da2 As New SqlDataAdapter(com2)
            da2.Fill(ds2, "clientes")
            TextBox1.Text = ds2.Tables(0).Rows(0).Item(0)
            TextBox1.Text = TextBox1.Text + 1
            TextBox5.Text = DateTime.Now.ToShortDateString
            TextBox2.Select()
        Catch ex As Exception
            TextBox1.Text = "1"
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = ""
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        Close()
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
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
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
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim con3 As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql3 As String = ("use flor_d select max(cast(id_cliente as int)) from clientes")
        Dim com3 As New SqlCommand(sql3, con3)
        Try
            Dim ds3 As New DataSet
            Dim da3 As New SqlDataAdapter(com3)
            da3.Fill(ds3, "clientes")
            TextBox1.Text = ds3.Tables(0).Rows(0).Item(0)
            TextBox1.Text = TextBox1.Text + 1
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox5.Text = Format(DateTimePicker1.Value, "dd/MM/yyyy")
        Dim d1 As Date = Format(DateTimePicker1.Value, "dd/MM/yyyy")
        Dim d2 As Date = Today
        Dim diff2 As String = (d2 - d1).TotalDays.ToString
        diff2 = (diff2 / 30) / 12
        TextBox6.Text = Format(Val(diff2))
        Dim str As String = TextBox6.Text
        str = Replace(TextBox6.Text, ",", ".")
        TextBox6.Text = str
    End Sub

    Private Sub DateTimePicker1_Click(sender As Object, e As EventArgs) Handles DateTimePicker1.Click
        TextBox5.Text = Format(DateTimePicker1.Value, "dd/MM/yyyy")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmHabitos.TextBox2.Text = TextBox1.Text
        frmHabitos.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim result As DialogResult = MsgBox("Quiere eliminar al cliente?", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then

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

            ElseIf (IsNumeric(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value))

                Dim con As New SqlConnection(My.Settings.myConnectionString3)
                Dim sql As String = ("use flor_d delete from clientes
where id_cliente = " & Val(DataGridView1.Rows(e.RowIndex).Cells(0).Value) & "")
                Dim com As New SqlCommand(sql, con)
                Try
                    Dim ds As New DataSet
                    Dim da As New SqlDataAdapter(com)
                    da.Fill(ds, "clientes")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Dim con As New SqlConnection(My.Settings.myConnectionString3)
                Dim sql As String = ("use flor_d delete from clientes
where id_cliente = " & DataGridView1.Rows(e.RowIndex).Cells(0).Value & "")
                Dim com As New SqlCommand(sql, con)
                Try
                    Dim ds As New DataSet
                    Dim da As New SqlDataAdapter(com)
                    da.Fill(ds, "clientes")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            Dim con4 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql4 As String = ("select cast(id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido', dni as 'DNI', fecha_nac as 'Nacimiento',
edad as 'Edad',
domicilio as 'Domicilio', mail as 'Mail', telefono as 'Teléfono' from clientes")
            Dim com4 As New SqlCommand(sql4, con4)
            Try
                Dim ds4 As New DataSet
                Dim da4 As New SqlDataAdapter(com4)
                da4.Fill(ds4, "clientes")
                DataGridView1.DataSource = ds4.Tables("clientes")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim con3 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql3 As String = ("use flor_d select max(cast(id_cliente as int)) from clientes")
            Dim com3 As New SqlCommand(sql3, con3)
            Try
                Dim ds3 As New DataSet
                Dim da3 As New SqlDataAdapter(com3)
                da3.Fill(ds3, "clientes")
                TextBox1.Text = ds3.Tables(0).Rows(0).Item(0)
                TextBox1.Text = TextBox1.Text + 1
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox2.Select()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TextBox9_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox9.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            If (Not TextBox2.Text = "") Then
                If (Not TextBox1.Text = "") Then
                    If (Not TextBox3.Text = "") Then
                        If (Not TextBox4.Text = "") Then
                            If (Not TextBox5.Text = "") Then
                                If (Not TextBox6.Text = "") Then
                                    If (Not TextBox7.Text = "") Then
                                        If (Not TextBox8.Text = "") Then
                                            If (Not TextBox9.Text = "") Then
                                                Dim con As New SqlConnection(My.Settings.myConnectionString3)
                                                Dim sql As String = ("use flor_d
insert into clientes 
values(" & TextBox1.Text & ", '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "', '" & TextBox7.Text & "', '" & TextBox8.Text & "', '" & TextBox9.Text & "')")
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
                                                Dim sql2 As String = ("use flor_d select cast(id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido', dni as 'DNI', fecha_nac as 'Nacimiento',
edad as 'Edad',
domicilio as 'Domicilio', mail as 'Mail', telefono as 'Teléfono' from clientes")
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
                                                Dim sql3 As String = ("use flor_d select max(cast(id_cliente as int)) from clientes")
                                                Dim com3 As New SqlCommand(sql3, con3)
                                                Try
                                                    Dim ds3 As New DataSet
                                                    Dim da3 As New SqlDataAdapter(com3)
                                                    da3.Fill(ds3, "clientes")
                                                    Button4.PerformClick()


                                                Catch ex As Exception
                                                    MsgBox(ex.Message)
                                                End Try
                                            Else
                                                MsgBox("Falta el teléfono!")
                                            End If
                                        Else
                                            MsgBox("Falta el mail!")
                                        End If
                                    Else
                                        MsgBox("Falta el domicilio!")
                                    End If
                                Else
                                    MsgBox("Falta la edad!")
                                End If
                            Else
                                MsgBox("Falta la fecha de nacimiento! Con cambiarle la fecha al calendario por cualquier fecha basta.")
                            End If
                        Else
                            MsgBox("Falta el DNI!")
                        End If
                    Else

                        MsgBox("Falta el apellido!")
                    End If
                Else
                    MsgBox("Falta el número de cliente!")
                End If
            Else
                MsgBox("Falta el nombre!")
            End If
        End If

    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If (e.KeyCode = Keys.Tab) Then
            DateTimePicker1.Select()
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Close()
        ElseIf (e.KeyCode = Keys.Down) Then
            tbxBus.Select()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "") Then
            MsgBox("Faltan campos por completar!")
        Else

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("use flor_d
update clientes set nombre_cliente = '" & TextBox2.Text & "',  apellido_cliente = '" & TextBox3.Text & "', dni = '" & TextBox4.Text & "', fecha_nac = '" & TextBox5.Text & "',
edad = '" & TextBox6.Text & "',
domicilio = '" & TextBox7.Text & "',
mail = '" & TextBox8.Text & "',
telefono = '" & TextBox9.Text & "'
where id_cliente = '" & TextBox1.Text & "'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "clientes")
                DataGridView1.DataSource = ds.Tables("clientes")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Catch ex4 As Exception
                MsgBox("Hay datos cargados de ese cliente!")
            End Try

            Dim con2 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql2 As String = ("select cast(id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido', dni as 'DNI', fecha_nac as 'Nacimiento',
edad as 'Edad',
domicilio as 'Domicilio', mail as 'Mail', telefono as 'Teléfono' from clientes")
            Dim com2 As New SqlCommand(sql2, con2)
            Try
                Dim ds2 As New DataSet
                Dim da2 As New SqlDataAdapter(com2)
                da2.Fill(ds2, "clientes")
                DataGridView1.DataSource = ds2.Tables("clientes")
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Catch ex3 As Exception
                MsgBox(ex3.Message)
            End Try

            Dim con3 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql3 As String = ("use flor_d select max(cast(id_cliente as int)) from clientes")
            Dim com3 As New SqlCommand(sql3, con3)
            Try
                Dim ds3 As New DataSet
                Dim da3 As New SqlDataAdapter(com3)
                da3.Fill(ds3, "clientes")
                TextBox1.Text = ds3.Tables(0).Rows(0).Item(0)
                TextBox1.Text = TextBox1.Text + 1
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""

                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
            Catch ex2 As Exception
                MsgBox(ex2.Message)
            End Try
        End If

    End Sub

    Private Sub tbxBus_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxBus.KeyDown
        If (e.KeyCode = Keys.Up) Then
            TextBox2.Select()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim result As DialogResult = MsgBox("¿Quiere abrir tratamientos del cliente?", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then

            Dim con7 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql7 As String = ("use flor_d select cast(id_cliente as int)
as 'ID', nombre_cliente as 'Nombre', apellido_cliente as 'Apellido', dni as 'DNI', fecha_nac as 'Nacimiento',
edad as 'Edad', domicilio as 'Domicilio', mail as 'Mail', telefono as 'Teléfono' from clientes  
where cast(id_cliente as int) = " & DataGridView1.Rows(e.RowIndex).Cells(0).Value)
            Dim com7 As New SqlCommand(sql7, con7)
            Try
                Dim ds7 As New DataSet
                Dim da7 As New SqlDataAdapter(com7)
                da7.Fill(ds7, "clientes")
                Visor_IDTRATACLIENTE.tbxBus.Text = ds7.Tables("clientes").Rows(0).Item(1)
                Close()
                SendKeys.Send("{ENTER}")
                Visor_IDTRATACLIENTE.Show()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
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
                    TextBox1.Text = ds.Tables("clientes").Rows(0).Item(0)
                    TextBox2.Text = ds.Tables("clientes").Rows(0).Item(1)
                    TextBox3.Text = ds.Tables("clientes").Rows(0).Item(2)
                    TextBox4.Text = ds.Tables("clientes").Rows(0).Item(3)
                    TextBox5.Text = ds.Tables("clientes").Rows(0).Item(4)
                    DateTimePicker1.Value = ds.Tables("clientes").Rows(0).Item(4)
                    TextBox6.Text = ds.Tables("clientes").Rows(0).Item(5)
                    TextBox7.Text = ds.Tables("clientes").Rows(0).Item(6)
                    TextBox8.Text = ds.Tables("clientes").Rows(0).Item(7)
                    TextBox9.Text = ds.Tables("clientes").Rows(0).Item(8)
                    Dim str As String = TextBox6.Text
                    str = Replace(TextBox6.Text, ",", ".")
                    TextBox6.Text = str
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If

    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Close()
        ElseIf (e.KeyCode = Keys.H)
            frmHabitos.Show()
        End If
    End Sub
End Class
