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
        Me.btnVerificarPrimo = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnVerificarPrimo
        '
        Me.btnVerificarPrimo.Location = New System.Drawing.Point(188, 84)
        Me.btnVerificarPrimo.Name = "btnVerificarPrimo"
        Me.btnVerificarPrimo.Size = New System.Drawing.Size(158, 49)
        Me.btnVerificarPrimo.TabIndex = 0
        Me.btnVerificarPrimo.Text = "Verificar"
        Me.btnVerificarPrimo.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(585, 84)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(51, 17)
        Me.lblResultado.TabIndex = 1
        Me.lblResultado.Text = "Label1"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(406, 84)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 22)
        Me.txtNumero.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnVerificarPrimo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVerificarPrimo As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtNumero As TextBox
End Class
