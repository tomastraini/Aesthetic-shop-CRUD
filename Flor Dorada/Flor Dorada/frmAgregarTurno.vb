Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class frmAgregarTurno
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
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
        frmBuscarTurno.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmBuscarTrataTurno.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = (" select max(cast(id_turno as int)) from turnos")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "clientes")
            Dim inx As Integer
            TextBox5.Text = ds.Tables("clientes").Rows(0).Item(0)
            inx = TextBox5.Text
            inx = inx + 1
            TextBox5.Text = inx
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox6.Text = ""
            DateTimePicker1.Text = Today
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("insert into turnos values(" & TextBox6.Text & ", '" & TextBox3.Text & "', '" & TextBox4.Text & "')")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "turnos")
            MsgBox("Carga exitosa!")
            mail = "Turno confirmado para el día " & TextBox3.Text & "para el cliente " & TextBox2.Text & "!"
            sendmail()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("
use flor_d 
update turnos set 
id_trata_clientes = '" & TextBox6.Text & "', 
fecha_turno = '" & TextBox3.Text & "',
detalles_turno = '" & TextBox4.Text & "'
where id_turno = '" & TextBox5.Text & "'")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "turnos")
            MsgBox("Modificación exitosa!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("use flor_d delete from turnos where id_turno = " & TextBox5.Text)
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "clientes")
            MsgBox("Eliminación exitosa!")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox3.Text = Format(DateTimePicker1.Value, "dd/MM/yyyy")
    End Sub
End Class