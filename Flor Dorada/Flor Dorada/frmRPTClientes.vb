Public Class frmRPTClientes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        frmMenu.Show()
    End Sub

    Private Sub frmRPTClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bd_proy4DataSet.view_cliente' Puede moverla o quitarla según sea necesario.
        Me.view_clienteTableAdapter.Fill(Me.bd_proy4DataSet.view_cliente)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class