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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRegistroAlumnos = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.btnRegistroAlumnos, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button4, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Button6, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Button7, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Button5, 1, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'btnRegistroAlumnos
        '
        resources.ApplyResources(Me.btnRegistroAlumnos, "btnRegistroAlumnos")
        Me.btnRegistroAlumnos.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistroAlumnos.FlatAppearance.BorderSize = 0
        Me.btnRegistroAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRegistroAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRegistroAlumnos.Name = "btnRegistroAlumnos"
        Me.btnRegistroAlumnos.UseVisualStyleBackColor = False
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button5.Name = "Button5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button6.Name = "Button6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        resources.ApplyResources(Me.Button7, "Button7")
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button7.Name = "Button7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnRegistroAlumnos As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button5 As Button
End Class
