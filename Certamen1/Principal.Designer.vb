<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClubesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarClubesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarIngresoEgresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarIngresoEgresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarIngresoEgresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarIngresoEgresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoIngresoEgresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.ClubesToolStripMenuItem, Me.IngresarToolStripMenuItem, Me.OtrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(418, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem})
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.LoginToolStripMenuItem.Text = "Inicio"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar sesión"
        '
        'ClubesToolStripMenuItem
        '
        Me.ClubesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarClubesToolStripMenuItem})
        Me.ClubesToolStripMenuItem.Name = "ClubesToolStripMenuItem"
        Me.ClubesToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ClubesToolStripMenuItem.Text = "Clubes"
        '
        'ConsultarClubesToolStripMenuItem
        '
        Me.ConsultarClubesToolStripMenuItem.Name = "ConsultarClubesToolStripMenuItem"
        Me.ConsultarClubesToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ConsultarClubesToolStripMenuItem.Text = "Consultar Clubes"
        '
        'IngresarToolStripMenuItem
        '
        Me.IngresarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarIngresoEgresoToolStripMenuItem, Me.IngresarIngresoEgresoToolStripMenuItem, Me.ModificarIngresoEgresoToolStripMenuItem, Me.EliminarIngresoEgresoToolStripMenuItem})
        Me.IngresarToolStripMenuItem.Name = "IngresarToolStripMenuItem"
        Me.IngresarToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.IngresarToolStripMenuItem.Text = "Ingresos/egresos"
        '
        'ConsultarIngresoEgresoToolStripMenuItem
        '
        Me.ConsultarIngresoEgresoToolStripMenuItem.Name = "ConsultarIngresoEgresoToolStripMenuItem"
        Me.ConsultarIngresoEgresoToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ConsultarIngresoEgresoToolStripMenuItem.Text = "Consultar Ingreso/Egreso"
        '
        'IngresarIngresoEgresoToolStripMenuItem
        '
        Me.IngresarIngresoEgresoToolStripMenuItem.Name = "IngresarIngresoEgresoToolStripMenuItem"
        Me.IngresarIngresoEgresoToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.IngresarIngresoEgresoToolStripMenuItem.Text = "Ingresar Ingreso/Egreso"
        '
        'ModificarIngresoEgresoToolStripMenuItem
        '
        Me.ModificarIngresoEgresoToolStripMenuItem.Name = "ModificarIngresoEgresoToolStripMenuItem"
        Me.ModificarIngresoEgresoToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ModificarIngresoEgresoToolStripMenuItem.Text = "Modificar Ingreso/Egreso"
        '
        'EliminarIngresoEgresoToolStripMenuItem
        '
        Me.EliminarIngresoEgresoToolStripMenuItem.Name = "EliminarIngresoEgresoToolStripMenuItem"
        Me.EliminarIngresoEgresoToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.EliminarIngresoEgresoToolStripMenuItem.Text = "Eliminar Ingreso/Egreso"
        '
        'OtrosToolStripMenuItem
        '
        Me.OtrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoIngresoEgresoToolStripMenuItem})
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.OtrosToolStripMenuItem.Text = "Otros"
        '
        'TipoIngresoEgresoToolStripMenuItem
        '
        Me.TipoIngresoEgresoToolStripMenuItem.Name = "TipoIngresoEgresoToolStripMenuItem"
        Me.TipoIngresoEgresoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TipoIngresoEgresoToolStripMenuItem.Text = "Tipo Ingreso/Egreso"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 275)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClubesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarClubesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarIngresoEgresoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarIngresoEgresoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarIngresoEgresoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarIngresoEgresoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoIngresoEgresoToolStripMenuItem As ToolStripMenuItem
End Class
