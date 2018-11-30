Public Class frmTipoIngresoEgreso
    Dim bsnNegocio As New BsnNegocio()
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmTipoIngresoEgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvTipo.DataSource = bsnNegocio.GetTipoIngresoEgresos()
        dgvTipo.Rows(0).Selected = True
        dgvTipo.Columns(0).Visible = False
    End Sub
End Class