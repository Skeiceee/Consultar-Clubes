<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarUnIngresoEgreso
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblClub = New System.Windows.Forms.Label()
        Me.cbClub = New System.Windows.Forms.ComboBox()
        Me.cbTipoMovimiento = New System.Windows.Forms.ComboBox()
        Me.dtpIngresoEgreso = New System.Windows.Forms.DateTimePicker()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblTipoMovimiento = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(199, 218)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 27
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(15, 218)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 26
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblClub
        '
        Me.lblClub.AutoSize = True
        Me.lblClub.Location = New System.Drawing.Point(12, 180)
        Me.lblClub.Name = "lblClub"
        Me.lblClub.Size = New System.Drawing.Size(28, 13)
        Me.lblClub.TabIndex = 25
        Me.lblClub.Text = "Club"
        '
        'cbClub
        '
        Me.cbClub.FormattingEnabled = True
        Me.cbClub.Location = New System.Drawing.Point(100, 177)
        Me.cbClub.Name = "cbClub"
        Me.cbClub.Size = New System.Drawing.Size(174, 21)
        Me.cbClub.TabIndex = 24
        '
        'cbTipoMovimiento
        '
        Me.cbTipoMovimiento.FormattingEnabled = True
        Me.cbTipoMovimiento.Location = New System.Drawing.Point(100, 150)
        Me.cbTipoMovimiento.Name = "cbTipoMovimiento"
        Me.cbTipoMovimiento.Size = New System.Drawing.Size(174, 21)
        Me.cbTipoMovimiento.TabIndex = 23
        '
        'dtpIngresoEgreso
        '
        Me.dtpIngresoEgreso.Location = New System.Drawing.Point(100, 113)
        Me.dtpIngresoEgreso.Name = "dtpIngresoEgreso"
        Me.dtpIngresoEgreso.Size = New System.Drawing.Size(174, 20)
        Me.dtpIngresoEgreso.TabIndex = 22
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(100, 67)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(174, 20)
        Me.txtMonto.TabIndex = 21
        '
        'txtDetalle
        '
        Me.txtDetalle.Location = New System.Drawing.Point(100, 41)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(174, 20)
        Me.txtDetalle.TabIndex = 20
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(100, 15)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(174, 20)
        Me.txtNombre.TabIndex = 19
        '
        'lblTipoMovimiento
        '
        Me.lblTipoMovimiento.AutoSize = True
        Me.lblTipoMovimiento.Location = New System.Drawing.Point(12, 153)
        Me.lblTipoMovimiento.Name = "lblTipoMovimiento"
        Me.lblTipoMovimiento.Size = New System.Drawing.Size(82, 13)
        Me.lblTipoMovimiento.TabIndex = 18
        Me.lblTipoMovimiento.Text = "Tipo novimiento"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(12, 119)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 17
        Me.lblFecha.Text = "Fecha"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(12, 70)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(37, 13)
        Me.lblMonto.TabIndex = 16
        Me.lblMonto.Text = "Monto"
        '
        'lblDetalle
        '
        Me.lblDetalle.AutoSize = True
        Me.lblDetalle.Location = New System.Drawing.Point(12, 44)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(40, 13)
        Me.lblDetalle.TabIndex = 15
        Me.lblDetalle.Text = "Detalle"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 18)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 14
        Me.lblNombre.Text = "Nombre"
        '
        'frmModificarUnIngresoEgreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 255)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblClub)
        Me.Controls.Add(Me.cbClub)
        Me.Controls.Add(Me.cbTipoMovimiento)
        Me.Controls.Add(Me.dtpIngresoEgreso)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblTipoMovimiento)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.lblDetalle)
        Me.Controls.Add(Me.lblNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmModificarUnIngresoEgreso"
        Me.Text = "Modificar un ingreso o egreso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblClub As Label
    Friend WithEvents cbClub As ComboBox
    Friend WithEvents cbTipoMovimiento As ComboBox
    Friend WithEvents dtpIngresoEgreso As DateTimePicker
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblTipoMovimiento As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents lblDetalle As Label
    Friend WithEvents lblNombre As Label
End Class
