Public Class frmModificarUnIngresoEgreso
    Dim bsnNegocio As New BsnNegocio()
    Dim frmMod As frmModificarIngresoEgreso
    Dim IngresoEgreso As New IngresoEgreso()
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Public Sub New(frmMod As frmModificarIngresoEgreso, IngresoEgreso As IngresoEgreso)

        InitializeComponent()

        Me.frmMod = frmMod
        Me.IngresoEgreso = IngresoEgreso

    End Sub

    Private Sub frmModificarUnIngresoEgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbTipoMovimiento.DataSource = BsnNegocio.GetTipoMovimiento()
        cbTipoMovimiento.DisplayMember = "Nombre"
        cbTipoMovimiento.ValueMember = "ID"

        cbClub.DataSource = BsnNegocio.GetClubes()
        cbClub.DisplayMember = "Nombre"
        cbClub.ValueMember = "ID"

        txtMonto.Text = IngresoEgreso.Monto
        txtNombre.Text = IngresoEgreso.Nombre
        txtDetalle.Text = IngresoEgreso.Detalle

        dtpIngresoEgreso.Value = IngresoEgreso.Fecha

        cbTipoMovimiento.SelectedValue = IngresoEgreso.IDTipoMovimiento
        cbClub.SelectedValue = IngresoEgreso.IDClub

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click



        If (txtNombre.Text.Equals("") Or txtMonto.Text.Equals("") Or txtDetalle.Text.Equals("")) Then
            MsgBox("Algunos de los campos estan vacios.", MsgBoxStyle.Information, "Alerta")
        Else
            IngresoEgreso.Monto = txtMonto.Text
            IngresoEgreso.Nombre = txtNombre.Text
            IngresoEgreso.Detalle = txtDetalle.Text

            IngresoEgreso.Fecha = dtpIngresoEgreso.Value

            IngresoEgreso.IDTipoMovimiento = cbTipoMovimiento.SelectedValue
            IngresoEgreso.IDClub = cbClub.SelectedValue

            MsgBox("El Ingreso o Egreso ha sido modificado correctamente.", MsgBoxStyle.Information, "Agregado")
            bsnNegocio.ModificarIngresoEgreso(IngresoEgreso)

            frmMod.ModificarIngresoEgreso_Load(Me, Nothing)
            Me.Close()

        End If
    End Sub
End Class