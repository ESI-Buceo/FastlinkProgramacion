<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenúTool_Gestor = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosDeMédicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_CargarUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_ModificarUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_EliminarUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiagnósticosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_CargarDiagnostico = New System.Windows.Forms.ToolStripMenuItem()
        Me.SintomasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_CargarSintomas = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatologíasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_CargarPatologia = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsociaciónEntreSintomasYPatologíasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_CargarAsociacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúTool_Gestor})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(491, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúTool_Gestor
        '
        Me.MenúTool_Gestor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosDeMédicosToolStripMenuItem, Me.DiagnósticosToolStripMenuItem, Me.SintomasToolStripMenuItem, Me.PatologíasToolStripMenuItem, Me.AsociaciónEntreSintomasYPatologíasToolStripMenuItem})
        Me.MenúTool_Gestor.Name = "MenúTool_Gestor"
        Me.MenúTool_Gestor.Size = New System.Drawing.Size(87, 20)
        Me.MenúTool_Gestor.Text = "Menú Gestor"
        '
        'UsuariosDeMédicosToolStripMenuItem
        '
        Me.UsuariosDeMédicosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_CargarUsuarios, Me.MenuItem_ModificarUsuarios, Me.MenuItem_EliminarUsuarios})
        Me.UsuariosDeMédicosToolStripMenuItem.Name = "UsuariosDeMédicosToolStripMenuItem"
        Me.UsuariosDeMédicosToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.UsuariosDeMédicosToolStripMenuItem.Text = "Usuarios de Médicos"
        '
        'MenuItem_CargarUsuarios
        '
        Me.MenuItem_CargarUsuarios.Name = "MenuItem_CargarUsuarios"
        Me.MenuItem_CargarUsuarios.Size = New System.Drawing.Size(173, 22)
        Me.MenuItem_CargarUsuarios.Text = "Cargar Usuarios"
        '
        'MenuItem_ModificarUsuarios
        '
        Me.MenuItem_ModificarUsuarios.Name = "MenuItem_ModificarUsuarios"
        Me.MenuItem_ModificarUsuarios.Size = New System.Drawing.Size(173, 22)
        Me.MenuItem_ModificarUsuarios.Text = "Modificar Usuarios"
        '
        'MenuItem_EliminarUsuarios
        '
        Me.MenuItem_EliminarUsuarios.Name = "MenuItem_EliminarUsuarios"
        Me.MenuItem_EliminarUsuarios.Size = New System.Drawing.Size(173, 22)
        Me.MenuItem_EliminarUsuarios.Text = "Eliminar Usuarios"
        '
        'DiagnósticosToolStripMenuItem
        '
        Me.DiagnósticosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_CargarDiagnostico})
        Me.DiagnósticosToolStripMenuItem.Name = "DiagnósticosToolStripMenuItem"
        Me.DiagnósticosToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.DiagnósticosToolStripMenuItem.Text = "Diagnósticos"
        '
        'MenuItem_CargarDiagnostico
        '
        Me.MenuItem_CargarDiagnostico.Name = "MenuItem_CargarDiagnostico"
        Me.MenuItem_CargarDiagnostico.Size = New System.Drawing.Size(175, 22)
        Me.MenuItem_CargarDiagnostico.Text = "Cargar Diagnóstico"
        '
        'SintomasToolStripMenuItem
        '
        Me.SintomasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_CargarSintomas})
        Me.SintomasToolStripMenuItem.Name = "SintomasToolStripMenuItem"
        Me.SintomasToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.SintomasToolStripMenuItem.Text = "Sintomas"
        '
        'MenuItem_CargarSintomas
        '
        Me.MenuItem_CargarSintomas.Name = "MenuItem_CargarSintomas"
        Me.MenuItem_CargarSintomas.Size = New System.Drawing.Size(156, 22)
        Me.MenuItem_CargarSintomas.Text = "Cargar Sintoma"
        '
        'PatologíasToolStripMenuItem
        '
        Me.PatologíasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_CargarPatologia})
        Me.PatologíasToolStripMenuItem.Name = "PatologíasToolStripMenuItem"
        Me.PatologíasToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.PatologíasToolStripMenuItem.Text = "Patologías"
        '
        'MenuItem_CargarPatologia
        '
        Me.MenuItem_CargarPatologia.Name = "MenuItem_CargarPatologia"
        Me.MenuItem_CargarPatologia.Size = New System.Drawing.Size(162, 22)
        Me.MenuItem_CargarPatologia.Text = "Cargar Patología"
        '
        'AsociaciónEntreSintomasYPatologíasToolStripMenuItem
        '
        Me.AsociaciónEntreSintomasYPatologíasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_CargarAsociacion})
        Me.AsociaciónEntreSintomasYPatologíasToolStripMenuItem.Name = "AsociaciónEntreSintomasYPatologíasToolStripMenuItem"
        Me.AsociaciónEntreSintomasYPatologíasToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.AsociaciónEntreSintomasYPatologíasToolStripMenuItem.Text = "Asociación entre Sintomas y Patologías"
        '
        'MenuItem_CargarAsociacion
        '
        Me.MenuItem_CargarAsociacion.Name = "MenuItem_CargarAsociacion"
        Me.MenuItem_CargarAsociacion.Size = New System.Drawing.Size(198, 22)
        Me.MenuItem_CargarAsociacion.Text = "Crear nueva Asociación"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 225)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Aplicación de Gestión"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenúTool_Gestor As ToolStripMenuItem
    Friend WithEvents UsuariosDeMédicosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuItem_CargarUsuarios As ToolStripMenuItem
    Friend WithEvents MenuItem_ModificarUsuarios As ToolStripMenuItem
    Friend WithEvents MenuItem_EliminarUsuarios As ToolStripMenuItem
    Friend WithEvents DiagnósticosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuItem_CargarDiagnostico As ToolStripMenuItem
    Friend WithEvents SintomasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuItem_CargarSintomas As ToolStripMenuItem
    Friend WithEvents PatologíasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuItem_CargarPatologia As ToolStripMenuItem
    Friend WithEvents AsociaciónEntreSintomasYPatologíasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuItem_CargarAsociacion As ToolStripMenuItem
End Class
