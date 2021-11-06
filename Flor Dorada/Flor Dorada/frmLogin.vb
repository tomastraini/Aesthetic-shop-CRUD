Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Public Class frmLogin
    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With

    End Sub
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreVentFlicker()
        frmLoginUS.Close()
    End Sub
    Private Sub txtUs_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles tbxUs.PreviewKeyDown
        If e.KeyCode = Keys.Tab Then

            Dim con As New SqlConnection(My.Settings.myConnectionString3)
            Dim sql As String = ("use flor_d select * from usuarios where usu = '" & tbxUs.Text & "'")
            Dim com As New SqlCommand(sql, con)
            Try
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(com)
                da.Fill(ds, "usuarios")
                Label2.Text = CStr(ds.Tables(0).Rows(0).Item(1))
                Label3.Text = CStr(ds.Tables(0).Rows(0).Item(2))
                Label5.Text = CStr(ds.Tables(0).Rows(0).Item(3))
                Label4.Visible = True
                Label2.Visible = True
            Catch ex As Exception
                MsgBox("No existe ese usuario!")
                tbxUs.Select()
            End Try
        End If
    End Sub
    Private Sub txtCon_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles tbxCon.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            If (tbxUs.Text = "" Or tbxCon.Text = "") Then
                MsgBox("Introduce algún valor", vbCritical, "Sin información")

            ElseIf (tbxUs.Text = Label2.Text) And (tbxCon.Text = Label3.Text) Then
                Dim frm As New frmMenu
                Hide()

                frm.ShowDialog()
            ElseIf (tbxUs.Text <> Label2.Text) Or (tbxCon.Text <> Label3.Text) Then
                MsgBox("Contraseña incorrecta!")
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        frmLoginUS.Close()
        Close()
        Application.Exit()
    End Sub



    Private Sub tbxCon_Click(sender As Object, e As EventArgs) Handles tbxCon.Click

        Dim con As New SqlConnection(My.Settings.myConnectionString3)
        Dim sql As String = ("select * from usuarios where usu = '" & tbxUs.Text & "'")
        Dim com As New SqlCommand(sql, con)
        Try
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(com)
            da.Fill(ds, "usuarios")
            Label2.Text = CStr(ds.Tables(0).Rows(0).Item(1))
            Label3.Text = CStr(ds.Tables(0).Rows(0).Item(2))
            Label5.Text = CStr(ds.Tables(0).Rows(0).Item(3))
            Label4.Visible = True
            Label2.Visible = True
        Catch ex As Exception
            MsgBox("No existe ese usuario!")
            tbxUs.Select()
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim frm As New frmLoginUS
        Hide()
        frm.ShowDialog()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox("Te tengo la solución!")
        Dim webAddress As String = "https://www.youtube.com/watch?v=oHg5SJYRHA0"
        Process.Start(webAddress)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (tbxUs.Text = "" Or tbxCon.Text = "") Then
            MsgBox("Introduce algún valor", vbCritical, "Sin información")
        ElseIf (tbxUs.Text = Label2.Text) And (tbxCon.Text = Label3.Text) Then
            Dim frm As New frmMenu
            Hide()
            frm.ShowDialog()
        ElseIf (tbxUs.Text <> Label2.Text) Or (tbxCon.Text <> Label3.Text) Then
            MsgBox("Contraseña incorrecta!")

        End If
    End Sub

    Private Sub tbxUs_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxUs.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            frmLoginUS.Close()
            Close()
            Application.Exit()
        End If
    End Sub
End Class
