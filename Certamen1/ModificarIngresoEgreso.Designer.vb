<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarIngresoEgreso
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
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.gbIngresosEgresos = New System.Windows.Forms.GroupBox()
        Me.dgvIngresosEgresos = New System.Windows.Forms.DataGridView()
        Me.gbIngresosEgresos.SuspendLayout()
        CType(Me.dgvIngresosEgresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(623, 196)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(542, 196)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 7
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(12, 196)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'gbIngresosEgresos
        '
        Me.gbIngresosEgresos.Controls.Add(Me.dgvIngresosEgresos)
        Me.gbIngresosEgresos.Location = New System.Drawing.Point(12, 12)
        Me.gbIngresosEgresos.Name = "gbIngresosEgresos"
        Me.gbIngresosEgresos.Size = New System.Drawing.Size(686, 178)
        Me.gbIngresosEgresos.TabIndex = 5
        Me.gbIngresosEgresos.TabStop = False
        Me.gbIngresosEgresos.Text = "Modificar y eliminar Ingresos y Egresos"
        '
        'dgvIngresosEgresos
        '
        Me.dgvIngresosEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngresosEgresos.Location = New System.Drawing.Point(6, 19)
        Me.dgvIngresosEgresos.Name = "dgvIngresosEgresos"
        Me.dgvIngresosEgresos.Size = New System.Drawing.Size(671, 150)
        Me.dgvIngresosEgresos.TabIndex = 0
        '
        'frmModificarIngresoEgreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 232)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gbIngresosEgresos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmModificarIngresoEgreso"
        Me.Text = "Modificar y eliminar ingreso o egreso"
        Me.gbIngresosEgresos.ResumeLayout(False)
        CType(Me.dgvIngresosEgresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents gbIngresosEgresos As GroupBox
    Friend WithEvents dgvIngresosEgresos As DataGridView
End Class
