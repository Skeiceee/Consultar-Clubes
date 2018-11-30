<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarClubes
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
        Me.dgvClubes = New System.Windows.Forms.DataGridView()
        Me.gbClubes = New System.Windows.Forms.GroupBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnTipoMovimiento = New System.Windows.Forms.Button()
        CType(Me.dgvClubes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbClubes.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvClubes
        '
        Me.dgvClubes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClubes.Location = New System.Drawing.Point(6, 19)
        Me.dgvClubes.Name = "dgvClubes"
        Me.dgvClubes.Size = New System.Drawing.Size(452, 150)
        Me.dgvClubes.TabIndex = 0
        '
        'gbClubes
        '
        Me.gbClubes.Controls.Add(Me.dgvClubes)
        Me.gbClubes.Location = New System.Drawing.Point(12, 12)
        Me.gbClubes.Name = "gbClubes"
        Me.gbClubes.Size = New System.Drawing.Size(466, 177)
        Me.gbClubes.TabIndex = 1
        Me.gbClubes.TabStop = False
        Me.gbClubes.Text = "Clubes"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(12, 195)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnTipoMovimiento
        '
        Me.btnTipoMovimiento.Location = New System.Drawing.Point(335, 195)
        Me.btnTipoMovimiento.Name = "btnTipoMovimiento"
        Me.btnTipoMovimiento.Size = New System.Drawing.Size(143, 23)
        Me.btnTipoMovimiento.TabIndex = 3
        Me.btnTipoMovimiento.Text = "Ver tipos de movimiento"
        Me.btnTipoMovimiento.UseVisualStyleBackColor = True
        '
        'frmConsultarClubes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 228)
        Me.Controls.Add(Me.btnTipoMovimiento)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gbClubes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultarClubes"
        Me.Text = "Consultar clubes"
        CType(Me.dgvClubes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbClubes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvClubes As DataGridView
    Friend WithEvents gbClubes As GroupBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnTipoMovimiento As Button
End Class
