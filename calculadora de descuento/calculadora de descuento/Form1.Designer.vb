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
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblresultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(159, 84)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 22)
        Me.txtPrecio.TabIndex = 0
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(247, 141)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(100, 22)
        Me.txtDescuento.TabIndex = 1
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(317, 233)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(125, 50)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Porcentaje de Descuento"
        '
        'lblresultado
        '
        Me.lblresultado.AutoSize = True
        Me.lblresultado.Location = New System.Drawing.Point(314, 310)
        Me.lblresultado.Name = "lblresultado"
        Me.lblresultado.Size = New System.Drawing.Size(51, 17)
        Me.lblresultado.TabIndex = 5
        Me.lblresultado.Text = "Label3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblresultado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.txtPrecio)
        Me.Name = "Form1"
        Me.Text = "Descuento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblresultado As Label
End Class
