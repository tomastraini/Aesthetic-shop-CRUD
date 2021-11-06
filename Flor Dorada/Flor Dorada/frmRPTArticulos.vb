Public Class frmRPTArticulos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        frmMenu.Show()
    End Sub

    Private Sub frmRPTArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_proy4DataSet.view_articulos' Puede moverla o quitarla según sea necesario.
        Me.view_articulosTableAdapter.Fill(Me.bd_proy4DataSet.view_articulos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class