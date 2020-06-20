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
        Me.ListBox_Solicitudes = New System.Windows.Forms.ListBox()
        Me.lbl_SolicitudChat = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox_Solicitudes
        '
        Me.ListBox_Solicitudes.FormattingEnabled = True
        Me.ListBox_Solicitudes.Items.AddRange(New Object() {"Chat 1 (Urgencia)", "Chat 2 (Grave)", "Chat 3 (Leve)"})
        Me.ListBox_Solicitudes.Location = New System.Drawing.Point(124, 80)
        Me.ListBox_Solicitudes.Name = "ListBox_Solicitudes"
        Me.ListBox_Solicitudes.Size = New System.Drawing.Size(120, 95)
        Me.ListBox_Solicitudes.TabIndex = 0
        '
        'lbl_SolicitudChat
        '
        Me.lbl_SolicitudChat.AutoSize = True
        Me.lbl_SolicitudChat.Location = New System.Drawing.Point(133, 51)
        Me.lbl_SolicitudChat.Name = "lbl_SolicitudChat"
        Me.lbl_SolicitudChat.Size = New System.Drawing.Size(101, 13)
        Me.lbl_SolicitudChat.TabIndex = 1
        Me.lbl_SolicitudChat.Text = "Solicitudes Médicas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 267)
        Me.Controls.Add(Me.lbl_SolicitudChat)
        Me.Controls.Add(Me.ListBox_Solicitudes)
        Me.Name = "Form1"
        Me.Text = "Aplicación de Medicos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox_Solicitudes As ListBox
    Friend WithEvents lbl_SolicitudChat As Label
End Class
