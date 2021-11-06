Imports System.Data.SqlClient
Public Class frmHabitos
    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With

    End Sub
    Private Sub frmHabitos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreVentFlicker()
        TextBox3.Select()

        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("select * from habitos where id_cliente = '" & TextBox2.Text & "'")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "habitos")
            TextBox1.Text = ds.Tables("habitos").Rows(0).Item(0)
            TextBox3.Text = ds.Tables("habitos").Rows(0).Item(2)
            TextBox4.Text = ds.Tables("habitos").Rows(0).Item(3)
            TextBox5.Text = ds.Tables("habitos").Rows(0).Item(4)
            TextBox6.Text = ds.Tables("habitos").Rows(0).Item(5)
        Catch ex As Exception

            Dim con2 As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql2 As String = ("use flor_d select max(cast(id_habitos as int)) from habitos")
            Dim com2 As New SqlCommand(sql2, con2)
            Try
                Dim ds2 As New DataSet
                Dim da2 As New SqlDataAdapter(com2)
                da2.Fill(ds2, "habitos")
                TextBox1.Text = ds2.Tables(0).Rows(0).Item(0)
                TextBox1.Text = TextBox1.Text + 1
            Catch ex2 As Exception
                TextBox1.Text = "1"
            End Try
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

        frmABMClientes.TextBox2.Text = ""
        frmABMClientes.TextBox3.Text = ""
        frmABMClientes.TextBox4.Text = ""
        frmABMClientes.TextBox5.Text = ""
        frmABMClientes.TextBox6.Text = ""
        frmABMClientes.TextBox7.Text = ""
        frmABMClientes.TextBox8.Text = ""
        frmABMClientes.TextBox9.Text = ""
        Close()
    End Sub
    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown
        If (e.KeyCode = Keys.Enter) Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("insert into habitos values(" & TextBox1.Text & ", " & TextBox2.Text & ", '" & TextBox3.Text & "','" & TextBox4.Text & "','
" & TextBox5.Text & "','" & TextBox6.Text & "')")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "clientes")
                MsgBox("Se cargaron los registros exitosamente!")
                Dim result2 As DialogResult = MsgBox("¿Quiere cargar ficha médica?", MessageBoxButtons.YesNo)
                If (result2 = DialogResult.Yes) Then
                    frmFichaMedica.TextBox1.Text = frmABMClientes.TextBox1.Text
                    frmFichaMedica.TextBox2.Text = frmABMClientes.TextBox2.Text
                    frmFichaMedica.TextBox3.Text = frmABMClientes.TextBox3.Text
                    Close()
                    frmABMClientes.Close()
                    frmFichaMedica.TextBox5.Select()
                    frmFichaMedica.ShowDialog(Me)
                Else
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox3.Text = ""
                    TextBox4.Text = ""
                    TextBox5.Text = ""
                    TextBox6.Text = ""

                    frmABMClientes.TextBox2.Text = ""
                    frmABMClientes.TextBox3.Text = ""
                    frmABMClientes.TextBox4.Text = ""
                    frmABMClientes.TextBox5.Text = ""
                    frmABMClientes.TextBox6.Text = ""
                    frmABMClientes.TextBox7.Text = ""
                    frmABMClientes.TextBox8.Text = ""
                    frmABMClientes.TextBox9.Text = ""
                    frmABMClientes.TextBox2.Select()
                    Close()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("use flor_d
update habitos set 
id_habitos = '" & TextBox1.Text & "',  
id_cliente = '" & TextBox2.Text & "', 
fuma = '" & TextBox3.Text & "', 
deportes = '" & TextBox4.Text & "',
agua = '" & TextBox5.Text & "',
horas_sueño = '" & TextBox6.Text & "'
where id_habitos = '" & TextBox1.Text & "'")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "clientes")
            MsgBox("Datos modificados exitosamente!")
        Catch ex As Exception
            MsgBox("No se puede borrar!")
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("use flor_d delete from habitos
where id_habitos = '" & TextBox1.Text & "'")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "habitos")
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            MsgBox("Se eliminaron los registros exitosamente!")
        Catch ex As Exception
            MsgBox("Hay datos cargados de ese cliente!")
        End Try
    End Sub
End Class