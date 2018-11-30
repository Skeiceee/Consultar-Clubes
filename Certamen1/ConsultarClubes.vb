Public Class frmConsultarClubes
    Dim bsnNegocio As New BsnNegocio()
    Private Sub frmConsultarClubes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvClubes.DataSource = bsnNegocio.GetClubes()
        dgvClubes.Rows(0).Selected = True
        dgvClubes.Columns(0).Visible = False
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnTipoMovimiento_Click(sender As Object, e As EventArgs) Handles btnTipoMovimiento.Click
        Dim Club As New Clubes()

        Club.ID = Integer.Parse(dgvClubes.SelectedRows.Item(0).Cells(0).Value.ToString())


        Dim ConsultarIngresosEgresos As New frmModificarIngresoEgreso(Club, 1)
        ConsultarIngresosEgresos.ShowDialog()

    End Sub
End Class