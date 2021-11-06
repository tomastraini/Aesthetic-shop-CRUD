Public Class frmRPTProveedores
    Private Sub frmRPTProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_proy4DataSet.view_proveedores' Puede moverla o quitarla según sea necesario.
        Me.view_proveedoresTableAdapter.Fill(Me.bd_proy4DataSet.view_proveedores)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        frmMenu.Show()
    End Sub
End Class