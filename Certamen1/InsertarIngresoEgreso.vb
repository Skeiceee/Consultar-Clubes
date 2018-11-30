Public Class frmInsertarIngresoEgreso
    Dim bsnNegocio As New BsnNegocio()
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmInsertarIngresoEgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbTipoMovimiento.DataSource = bsnNegocio.GetTipoMovimiento()
        cbTipoMovimiento.DisplayMember = "Nombre"
        cbTipoMovimiento.ValueMember = "ID"

        cbClub.DataSource = bsnNegocio.GetClubes()
        cbClub.DisplayMember = "Nombre"
        cbClub.ValueMember = "ID"
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Dim IngresoEgreso As New IngresoEgreso()

        If (txtNombre.Text.Equals("") Or txtMonto.Text.Equals("") Or txtDetalle.Text.Equals("")) Then
            MsgBox("Algunos de los campos estan vacios.", MsgBoxStyle.Information, "Alerta")
        Else
            IngresoEgreso.Nombre = txtNombre.Text
            IngresoEgreso.Detalle = txtDetalle.Text
            IngresoEgreso.Monto = txtMonto.Text

            IngresoEgreso.Fecha = dtpIngresoEgreso.Value

            IngresoEgreso.IDTipoMovimiento = cbTipoMovimiento.SelectedValue
            IngresoEgreso.IDClub = cbClub.SelectedValue

            MsgBox("El Ingreso o Egreso ha sido insertado correctamente.", MsgBoxStyle.Information, "Agregado")
            bsnNegocio.InsertarIngresosEgresos(IngresoEgreso)

            Me.Close()
        End If

    End Sub
End Class