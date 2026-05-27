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
        Me.chkperro = New System.Windows.Forms.CheckBox()
        Me.chkgato = New System.Windows.Forms.CheckBox()
        Me.chkraton = New System.Windows.Forms.CheckBox()
        Me.lblmostrar = New System.Windows.Forms.Label()
        Me.btnmostrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkperro
        '
        Me.chkperro.AutoSize = True
        Me.chkperro.Location = New System.Drawing.Point(74, 56)
        Me.chkperro.Name = "chkperro"
        Me.chkperro.Size = New System.Drawing.Size(65, 21)
        Me.chkperro.TabIndex = 0
        Me.chkperro.Text = "Perro"
        Me.chkperro.UseVisualStyleBackColor = True
        '
        'chkgato
        '
        Me.chkgato.AutoSize = True
        Me.chkgato.Location = New System.Drawing.Point(74, 134)
        Me.chkgato.Name = "chkgato"
        Me.chkgato.Size = New System.Drawing.Size(61, 21)
        Me.chkgato.TabIndex = 1
        Me.chkgato.Text = "Gato"
        Me.chkgato.UseVisualStyleBackColor = True
        '
        'chkraton
        '
        Me.chkraton.AutoSize = True
        Me.chkraton.Location = New System.Drawing.Point(74, 217)
        Me.chkraton.Name = "chkraton"
        Me.chkraton.Size = New System.Drawing.Size(68, 21)
        Me.chkraton.TabIndex = 2
        Me.chkraton.Text = "Ratón"
        Me.chkraton.UseVisualStyleBackColor = True
        '
        'lblmostrar
        '
        Me.lblmostrar.AutoSize = True
        Me.lblmostrar.Location = New System.Drawing.Point(71, 380)
        Me.lblmostrar.Name = "lblmostrar"
        Me.lblmostrar.Size = New System.Drawing.Size(0, 17)
        Me.lblmostrar.TabIndex = 3
        '
        'btnmostrar
        '
        Me.btnmostrar.Location = New System.Drawing.Point(74, 293)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(112, 42)
        Me.btnmostrar.TabIndex = 4
        Me.btnmostrar.Text = "Mostrar"
        Me.btnmostrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnmostrar)
        Me.Controls.Add(Me.lblmostrar)
        Me.Controls.Add(Me.chkraton)
        Me.Controls.Add(Me.chkgato)
        Me.Controls.Add(Me.chkperro)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkperro As CheckBox
    Friend WithEvents chkgato As CheckBox
    Friend WithEvents chkraton As CheckBox
    Friend WithEvents lblmostrar As Label
    Friend WithEvents btnmostrar As Button
End Class
