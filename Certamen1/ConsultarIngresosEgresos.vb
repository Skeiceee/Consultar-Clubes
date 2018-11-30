Public Class frmConsultarIngresosEgresos
    Dim bsnNegocio As New BsnNegocio()
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmConsultarIngresosEgresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvIngresosEgresos.DataSource = bsnNegocio.GetIngresosEgresos()
        dgvIngresosEgresos.Rows(0).Selected = True
        dgvIngresosEgresos.Columns(0).Visible = False

    End Sub

End Class