<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultarIngresosEgresos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvIngresosEgresos = New System.Windows.Forms.DataGridView()
        Me.gbIngresosEgresos = New System.Windows.Forms.GroupBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.dgvIngresosEgresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbIngresosEgresos.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvIngresosEgresos
        '
        Me.dgvIngresosEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngresosEgresos.Location = New System.Drawing.Point(6, 19)
        Me.dgvIngresosEgresos.Name = "dgvIngresosEgresos"
        Me.dgvIngresosEgresos.Size = New System.Drawing.Size(671, 150)
        Me.dgvIngresosEgresos.TabIndex = 0
        '
        'gbIngresosEgresos
        '
        Me.gbIngresosEgresos.Controls.Add(Me.dgvIngresosEgresos)
        Me.gbIngresosEgresos.Location = New System.Drawing.Point(13, 12)
        Me.gbIngresosEgresos.Name = "gbIngresosEgresos"
        Me.gbIngresosEgresos.Size = New System.Drawing.Size(686, 178)
        Me.gbIngresosEgresos.TabIndex = 1
        Me.gbIngresosEgresos.TabStop = False
        Me.gbIngresosEgresos.Text = "Ingresos y Egresos"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(13, 196)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmConsultarIngresosEgresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 228)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gbIngresosEgresos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultarIngresosEgresos"
        Me.Text = "Consultar ingresos y egresos"
        CType(Me.dgvIngresosEgresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbIngresosEgresos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvIngresosEgresos As DataGridView
    Friend WithEvents gbIngresosEgresos As GroupBox
    Friend WithEvents btnCerrar As Button
End Class
