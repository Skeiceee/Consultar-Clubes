<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsertarIngresoEgreso
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblTipoMovimiento = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.dtpIngresoEgreso = New System.Windows.Forms.DateTimePicker()
        Me.cbTipoMovimiento = New System.Windows.Forms.ComboBox()
        Me.cbClub = New System.Windows.Forms.ComboBox()
        Me.lblClub = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 19)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'lblDetalle
        '
        Me.lblDetalle.AutoSize = True
        Me.lblDetalle.Location = New System.Drawing.Point(12, 45)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(40, 13)
        Me.lblDetalle.TabIndex = 1
        Me.lblDetalle.Text = "Detalle"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(12, 71)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(37, 13)
        Me.lblMonto.TabIndex = 2
        Me.lblMonto.Text = "Monto"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(12, 120)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "Fecha"
        '
        'lblTipoMovimiento
        '
        Me.lblTipoMovimiento.AutoSize = True
        Me.lblTipoMovimiento.Location = New System.Drawing.Point(12, 154)
        Me.lblTipoMovimiento.Name = "lblTipoMovimiento"
        Me.lblTipoMovimiento.Size = New System.Drawing.Size(82, 13)
        Me.lblTipoMovimiento.TabIndex = 4
        Me.lblTipoMovimiento.Text = "Tipo novimiento"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(100, 16)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(174, 20)
        Me.txtNombre.TabIndex = 5
        '
        'txtDetalle
        '
        Me.txtDetalle.Location = New System.Drawing.Point(100, 42)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(174, 20)
        Me.txtDetalle.TabIndex = 6
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(100, 68)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(174, 20)
        Me.txtMonto.TabIndex = 7
        '
        'dtpIngresoEgreso
        '
        Me.dtpIngresoEgreso.Location = New System.Drawing.Point(100, 114)
        Me.dtpIngresoEgreso.Name = "dtpIngresoEgreso"
        Me.dtpIngresoEgreso.Size = New System.Drawing.Size(174, 20)
        Me.dtpIngresoEgreso.TabIndex = 8
        '
        'cbTipoMovimiento
        '
        Me.cbTipoMovimiento.FormattingEnabled = True
        Me.cbTipoMovimiento.Location = New System.Drawing.Point(100, 151)
        Me.cbTipoMovimiento.Name = "cbTipoMovimiento"
        Me.cbTipoMovimiento.Size = New System.Drawing.Size(174, 21)
        Me.cbTipoMovimiento.TabIndex = 9
        '
        'cbClub
        '
        Me.cbClub.FormattingEnabled = True
        Me.cbClub.Location = New System.Drawing.Point(100, 178)
        Me.cbClub.Name = "cbClub"
        Me.cbClub.Size = New System.Drawing.Size(174, 21)
        Me.cbClub.TabIndex = 10
        '
        'lblClub
        '
        Me.lblClub.AutoSize = True
        Me.lblClub.Location = New System.Drawing.Point(12, 181)
        Me.lblClub.Name = "lblClub"
        Me.lblClub.Size = New System.Drawing.Size(28, 13)
        Me.lblClub.TabIndex = 11
        Me.lblClub.Text = "Club"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(15, 219)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(199, 219)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 13
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'frmInsertarIngresoEgreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 260)
        Me.Controls.Add(Me.btnIngresar)
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
        Me.Name = "frmInsertarIngresoEgreso"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Insertar ingreso o egreso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDetalle As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblTipoMovimiento As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents dtpIngresoEgreso As DateTimePicker
    Friend WithEvents cbTipoMovimiento As ComboBox
    Friend WithEvents cbClub As ComboBox
    Friend WithEvents lblClub As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnIngresar As Button
End Class
