<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.nombre = New System.Windows.Forms.MaskedTextBox()
        Me.Label1nombre = New System.Windows.Forms.Label()
        Me.contrase = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.regcontr = New System.Windows.Forms.MaskedTextBox()
        Me.regnombre = New System.Windows.Forms.MaskedTextBox()
        Me.registro = New System.Windows.Forms.Button()
        Me.Label5registro = New System.Windows.Forms.Label()
        Me.Label6ingreso = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ingresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(96, 48)
        Me.nombre.Mask = "????????????????????????????????????????????????????????????"
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(152, 20)
        Me.nombre.TabIndex = 0
        '
        'Label1nombre
        '
        Me.Label1nombre.AutoSize = True
        Me.Label1nombre.Location = New System.Drawing.Point(20, 48)
        Me.Label1nombre.Name = "Label1nombre"
        Me.Label1nombre.Size = New System.Drawing.Size(44, 13)
        Me.Label1nombre.TabIndex = 1
        Me.Label1nombre.Text = "Nombre"
        '
        'contrase
        '
        Me.contrase.Location = New System.Drawing.Point(96, 94)
        Me.contrase.Name = "contrase"
        Me.contrase.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contrase.Size = New System.Drawing.Size(152, 20)
        Me.contrase.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "contraseña"
        '
        'regcontr
        '
        Me.regcontr.Location = New System.Drawing.Point(96, 94)
        Me.regcontr.Name = "regcontr"
        Me.regcontr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.regcontr.Size = New System.Drawing.Size(152, 20)
        Me.regcontr.TabIndex = 6
        Me.regcontr.Visible = False
        '
        'regnombre
        '
        Me.regnombre.Location = New System.Drawing.Point(96, 48)
        Me.regnombre.Mask = "????????????????????????????????????????????????????????????"
        Me.regnombre.Name = "regnombre"
        Me.regnombre.Size = New System.Drawing.Size(152, 20)
        Me.regnombre.TabIndex = 4
        Me.regnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.regnombre.Visible = False
        '
        'registro
        '
        Me.registro.Location = New System.Drawing.Point(302, 8)
        Me.registro.Name = "registro"
        Me.registro.Size = New System.Drawing.Size(75, 23)
        Me.registro.TabIndex = 8
        Me.registro.Text = "registro"
        Me.registro.UseVisualStyleBackColor = True
        '
        'Label5registro
        '
        Me.Label5registro.AutoSize = True
        Me.Label5registro.Location = New System.Drawing.Point(113, 14)
        Me.Label5registro.Name = "Label5registro"
        Me.Label5registro.Size = New System.Drawing.Size(41, 13)
        Me.Label5registro.TabIndex = 9
        Me.Label5registro.Text = "registro"
        Me.Label5registro.Visible = False
        '
        'Label6ingreso
        '
        Me.Label6ingreso.AutoSize = True
        Me.Label6ingreso.Location = New System.Drawing.Point(113, 14)
        Me.Label6ingreso.Name = "Label6ingreso"
        Me.Label6ingreso.Size = New System.Drawing.Size(41, 13)
        Me.Label6ingreso.TabIndex = 10
        Me.Label6ingreso.Text = "ingreso"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(302, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'ingresar
        '
        Me.ingresar.Location = New System.Drawing.Point(302, 67)
        Me.ingresar.Name = "ingresar"
        Me.ingresar.Size = New System.Drawing.Size(75, 23)
        Me.ingresar.TabIndex = 12
        Me.ingresar.Text = "Ingresar"
        Me.ingresar.UseVisualStyleBackColor = True
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 175)
        Me.Controls.Add(Me.ingresar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6ingreso)
        Me.Controls.Add(Me.Label5registro)
        Me.Controls.Add(Me.registro)
        Me.Controls.Add(Me.regcontr)
        Me.Controls.Add(Me.regnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.contrase)
        Me.Controls.Add(Me.Label1nombre)
        Me.Controls.Add(Me.nombre)
        Me.Name = "inicio"
        Me.Text = "inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nombre As MaskedTextBox
    Friend WithEvents Label1nombre As Label
    Friend WithEvents contrase As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents regcontr As MaskedTextBox
    Friend WithEvents regnombre As MaskedTextBox
    Friend WithEvents registro As Button
    Friend WithEvents Label5registro As Label
    Friend WithEvents Label6ingreso As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ingresar As Button
End Class
