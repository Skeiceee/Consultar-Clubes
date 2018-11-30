Public Class frmModificarIngresoEgreso
    Dim bsnNegocio As New BsnNegocio
    Dim Club As Clubes
    Dim num As Integer
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(Club As Clubes, num As Integer)

        InitializeComponent()
        Me.Club = Club
        Me.num = num

    End Sub
    Public Sub ModificarIngresoEgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If num = 1 Then
            dgvIngresosEgresos.DataSource = bsnNegocio.GetIngresosEgresosClub(Club)
        Else
            dgvIngresosEgresos.DataSource = bsnNegocio.GetIngresosEgresos()
            dgvIngresosEgresos.Rows(0).Selected = True
        End If

        dgvIngresosEgresos.Columns(0).Visible = False
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim IngresoEgreso As New IngresoEgreso()

        IngresoEgreso.ID = Integer.Parse(dgvIngresosEgresos.SelectedRows.Item(0).Cells(0).Value.ToString())
        IngresoEgreso.Nombre = dgvIngresosEgresos.SelectedRows.Item(0).Cells(1).Value.ToString()
        IngresoEgreso.Detalle = dgvIngresosEgresos.SelectedRows.Item(0).Cells(2).Value.ToString()
        IngresoEgreso.Fecha = Date.Parse(dgvIngresosEgresos.SelectedRows.Item(0).Cells(3).Value.ToString())
        IngresoEgreso.Monto = Integer.Parse(dgvIngresosEgresos.SelectedRows.Item(0).Cells(4).Value.ToString())
        IngresoEgreso.IDTipoMovimiento = Integer.Parse(dgvIngresosEgresos.SelectedRows.Item(0).Cells(5).Value.ToString())
        IngresoEgreso.IDClub = Integer.Parse(dgvIngresosEgresos.SelectedRows.Item(0).Cells(6).Value.ToString())

        Dim frmMod As New frmModificarUnIngresoEgreso(Me, IngresoEgreso)
        frmMod.ShowDialog()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim IngresoEgreso As New IngresoEgreso

        IngresoEgreso.ID = Integer.Parse(dgvIngresosEgresos.SelectedRows.Item(0).Cells(0).Value.ToString())

        If MessageBox.Show("¿Esta seguro que desea eliminar el ingreso o egreso?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

            bsnNegocio.EliminarIngresoEgreso(IngresoEgreso)

            MsgBox("Ingreso o egreso ha sido eliminado", MsgBoxStyle.Information, "Alerta")

        End If

        Me.ModificarIngresoEgreso_Load(Me, Nothing)
    End Sub
End Class