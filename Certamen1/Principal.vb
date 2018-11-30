Public Class Principal
    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Dim Login As New frmLogin()
        Login.Show()
        Me.Close()

    End Sub

    Private Sub ConsultarClubesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarClubesToolStripMenuItem.Click
        Dim ConsultarClubes As New frmConsultarClubes()
        ConsultarClubes.ShowDialog()
    End Sub

    Private Sub ConsultarIngresoEgresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarIngresoEgresoToolStripMenuItem.Click
        Dim ConsultarIngresosEgresos As New frmConsultarIngresosEgresos()
        ConsultarIngresosEgresos.ShowDialog()
    End Sub

    Private Sub IngresarIngresoEgresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarIngresoEgresoToolStripMenuItem.Click
        Dim InsertarIngresoEgreso As New frmInsertarIngresoEgreso()
        InsertarIngresoEgreso.ShowDialog()
    End Sub

    Private Sub ModificarIngresoEgresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarIngresoEgresoToolStripMenuItem.Click
        Dim ModificarIngresoEgreso As New frmModificarIngresoEgreso()
        ModificarIngresoEgreso.ShowDialog()
    End Sub

    Private Sub EliminarIngresoEgresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarIngresoEgresoToolStripMenuItem.Click
        Dim ModificarIngresoEgreso As New frmModificarIngresoEgreso()
        ModificarIngresoEgreso.ShowDialog()
    End Sub

    Private Sub TipoIngresoEgresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoIngresoEgresoToolStripMenuItem.Click
        Dim TipoIngresoEgreso As New frmTipoIngresoEgreso()
        TipoIngresoEgreso.ShowDialog()
    End Sub
End Class