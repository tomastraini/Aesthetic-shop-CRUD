Imports System.Data.SqlClient
Imports System.Net.Mail
Public Class frmTratamientosClientes
    Dim mail As String
    Public Sub sendmail()
        Try


            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("tomas.traini@institutozonaoeste.edu.ar", "1614811481Aa")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("tomas.traini@institutozonaoeste.edu.ar")
            e_mail.To.Add("ma_lejandra30@gmail.com")
            e_mail.Subject = "Flor dorada confirmación de turnos"
            e_mail.IsBodyHtml = False
            e_mail.Body = mail
            Smtp_Server.Send(e_mail)

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub

    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With

    End Sub
    Private Sub frmTratamientosClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreVentFlicker()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Visor_IDTRATACLIENTE.Close()
        Close()
    End Sub



    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox4.Text = Format(DateTimePicker1.Value, "dd/MM/yyyy")
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Visor_IDTRATACLIENTE.ShowDialog()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        frmTrataTrataSeleccion.Show()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        frmTrataClientesSeleccionarForSearch.Show()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TextBox5.Select()
    End Sub
    Private Sub TextBox7_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox7.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("use flor_d
INSERT INTO trata_clientes (id_trata_clientes,
id_tratamiento, id_cliente ,fecha_inicio, cant_sesiones, cant_horas, detalles_sesiones) 
SELECT " & TextBox1.Text & ", " & TextBox2.Text & ", " & TextBox3.Text & ", 
      '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "',
	  '" & TextBox7.Text & "'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "clientes")
                MsgBox("Carga realizada con éxito!")
                mail = "Tratamiento confirmado con fecha de inicio el " & TextBox4.Text & "
para el cliente Nº " & TextBox3.Text & ""

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("update trata_clientes 
set id_trata_clientes= '" & TextBox1.Text & "', id_tratamiento='" & TextBox2.Text & "', id_cliente='" & TextBox3.Text & "', 
fecha_inicio='" & TextBox4.Text & "', cant_sesiones='" & TextBox5.Text & "', cant_horas='" & TextBox6.Text & "', 
 detalles_sesiones='" & TextBox7.Text & "'
 where id_trata_clientes= '" & TextBox1.Text & "'")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "clientes")
            MsgBox("Modificación exitosa!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("use flor_d delete from trata_clientes where id_trata_clientes= " & TextBox1.Text)
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "proveedores")
            MsgBox("Elementos eliminados!")
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("use flor_d
INSERT INTO trata_clientes (id_trata_clientes,
id_tratamiento, id_cliente ,fecha_inicio, cant_sesiones, cant_horas, detalles_sesiones) 
SELECT " & TextBox1.Text & ", " & TextBox2.Text & ", " & TextBox3.Text & ", 
      '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "',
	  '" & TextBox7.Text & "'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "clientes")
                MsgBox("Carga realizada con éxito!")
                mail = "Tratamiento confirmado con fecha de inicio el " & TextBox4.Text & "
para el cliente Nº " & TextBox3.Text & ""

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("use flor_d
INSERT INTO trata_clientes (id_trata_clientes,
id_tratamiento, id_cliente ,fecha_inicio, cant_sesiones, cant_horas, detalles_sesiones) 
SELECT " & TextBox1.Text & ", " & TextBox2.Text & ", " & TextBox3.Text & ", 
      '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "',
	  '" & TextBox7.Text & "'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "clientes")
                MsgBox("Carga realizada con éxito!")
                mail = "Tratamiento confirmado con fecha de inicio el " & TextBox4.Text & "
para el cliente Nº " & TextBox3.Text & ""

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf (e.KeyCode = Keys.Escape)
            Close()
            Visor_IDTRATACLIENTE.Close()
        End If
    End Sub

End Class