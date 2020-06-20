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
        Me.lbl_Sintomas = New System.Windows.Forms.Label()
        Me.ChBox_Sintomas = New System.Windows.Forms.CheckedListBox()
        Me.btn_Si = New System.Windows.Forms.Button()
        Me.btn_No = New System.Windows.Forms.Button()
        Me.list_Diagnostico = New System.Windows.Forms.ListView()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Sintomas
        '
        Me.lbl_Sintomas.AutoSize = True
        Me.lbl_Sintomas.Location = New System.Drawing.Point(113, 59)
        Me.lbl_Sintomas.Name = "lbl_Sintomas"
        Me.lbl_Sintomas.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Sintomas.TabIndex = 1
        Me.lbl_Sintomas.Text = "Sintomas"
        '
        'ChBox_Sintomas
        '
        Me.ChBox_Sintomas.FormattingEnabled = True
        Me.ChBox_Sintomas.Items.AddRange(New Object() {"Dolor de Cabeza", "Tos", "Fiebre", "Deficiencia Respiratoria", "Dolor Lumbar", "Ardor "})
        Me.ChBox_Sintomas.Location = New System.Drawing.Point(209, 59)
        Me.ChBox_Sintomas.Name = "ChBox_Sintomas"
        Me.ChBox_Sintomas.Size = New System.Drawing.Size(146, 184)
        Me.ChBox_Sintomas.TabIndex = 2
        '
        'btn_Si
        '
        Me.btn_Si.Location = New System.Drawing.Point(396, 219)
        Me.btn_Si.Name = "btn_Si"
        Me.btn_Si.Size = New System.Drawing.Size(75, 23)
        Me.btn_Si.TabIndex = 4
        Me.btn_Si.Text = "Si"
        Me.btn_Si.UseVisualStyleBackColor = True
        '
        'btn_No
        '
        Me.btn_No.Location = New System.Drawing.Point(592, 219)
        Me.btn_No.Name = "btn_No"
        Me.btn_No.Size = New System.Drawing.Size(75, 23)
        Me.btn_No.TabIndex = 5
        Me.btn_No.Text = "No"
        Me.btn_No.UseVisualStyleBackColor = True
        '
        'list_Diagnostico
        '
        Me.list_Diagnostico.HideSelection = False
        Me.list_Diagnostico.Location = New System.Drawing.Point(396, 59)
        Me.list_Diagnostico.Name = "list_Diagnostico"
        Me.list_Diagnostico.Size = New System.Drawing.Size(271, 133)
        Me.list_Diagnostico.TabIndex = 7
        Me.list_Diagnostico.UseCompatibleStateImageBehavior = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Location = New System.Drawing.Point(249, 268)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Aceptar.TabIndex = 8
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.list_Diagnostico)
        Me.Controls.Add(Me.btn_No)
        Me.Controls.Add(Me.btn_Si)
        Me.Controls.Add(Me.ChBox_Sintomas)
        Me.Controls.Add(Me.lbl_Sintomas)
        Me.Name = "Form1"
        Me.Text = "Aplicacion de Consulta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Sintomas As Label
    Friend WithEvents ChBox_Sintomas As CheckedListBox
    Friend WithEvents btn_Si As Button
    Friend WithEvents btn_No As Button
    Friend WithEvents list_Diagnostico As ListView
    Friend WithEvents btn_Aceptar As Button
End Class
