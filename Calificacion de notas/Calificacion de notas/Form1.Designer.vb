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
        Me.btnCalificar = New System.Windows.Forms.Button()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalificar
        '
        Me.btnCalificar.Location = New System.Drawing.Point(58, 67)
        Me.btnCalificar.Name = "btnCalificar"
        Me.btnCalificar.Size = New System.Drawing.Size(213, 46)
        Me.btnCalificar.TabIndex = 0
        Me.btnCalificar.Text = "Mostrar"
        Me.btnCalificar.UseVisualStyleBackColor = True
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(298, 67)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(220, 22)
        Me.txtNota.TabIndex = 1
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(594, 71)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 17)
        Me.lblResultado.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.btnCalificar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalificar As Button
    Friend WithEvents txtNota As TextBox
    Friend WithEvents lblResultado As Label
End Class
