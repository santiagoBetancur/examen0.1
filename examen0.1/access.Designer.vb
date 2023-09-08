<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class access
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.texjuridica = New System.Windows.Forms.MaskedTextBox()
        Me.texfisica = New System.Windows.Forms.MaskedTextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.genrocombo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nombretext = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.telefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.contacto = New System.Windows.Forms.TextBox()
        Me.correo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.provincia = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.canton = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.distrito = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(18, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(942, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Identificacion"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(790, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 36)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(265, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "JURIDICA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(265, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "FISICA"
        '
        'texjuridica
        '
        Me.texjuridica.Location = New System.Drawing.Point(100, 196)
        Me.texjuridica.Mask = "##########"
        Me.texjuridica.Name = "texjuridica"
        Me.texjuridica.Size = New System.Drawing.Size(159, 20)
        Me.texjuridica.TabIndex = 1
        '
        'texfisica
        '
        Me.texfisica.Enabled = False
        Me.texfisica.Location = New System.Drawing.Point(100, 226)
        Me.texfisica.Mask = "#########"
        Me.texfisica.Name = "texfisica"
        Me.texfisica.Size = New System.Drawing.Size(159, 20)
        Me.texfisica.TabIndex = 2
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(328, 203)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(328, 229)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton2.TabIndex = 9
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nombre"
        '
        'genrocombo
        '
        Me.genrocombo.FormattingEnabled = True
        Me.genrocombo.Location = New System.Drawing.Point(100, 301)
        Me.genrocombo.Name = "genrocombo"
        Me.genrocombo.Size = New System.Drawing.Size(159, 21)
        Me.genrocombo.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Genero"
        '
        'nombretext
        '
        Me.nombretext.Location = New System.Drawing.Point(100, 264)
        Me.nombretext.Mask = "????????????????????????????????????????????????????????????????"
        Me.nombretext.Name = "nombretext"
        Me.nombretext.Size = New System.Drawing.Size(159, 20)
        Me.nombretext.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 340)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Direccion"
        '
        'direccion
        '
        Me.direccion.Location = New System.Drawing.Point(100, 340)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(159, 20)
        Me.direccion.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 381)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Telefono"
        '
        'telefono
        '
        Me.telefono.Location = New System.Drawing.Point(100, 378)
        Me.telefono.Mask = "#######"
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(159, 20)
        Me.telefono.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(381, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Nombre de contacto"
        '
        'contacto
        '
        Me.contacto.Location = New System.Drawing.Point(542, 196)
        Me.contacto.Name = "contacto"
        Me.contacto.Size = New System.Drawing.Size(159, 20)
        Me.contacto.TabIndex = 7
        '
        'correo
        '
        Me.correo.Location = New System.Drawing.Point(542, 229)
        Me.correo.Name = "correo"
        Me.correo.Size = New System.Drawing.Size(159, 20)
        Me.correo.TabIndex = 8
        Me.correo.Text = "ejemplo@.com"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(381, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Direccion de correo electronico"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(381, 261)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Provincia"
        '
        'provincia
        '
        Me.provincia.FormattingEnabled = True
        Me.provincia.Location = New System.Drawing.Point(542, 261)
        Me.provincia.Name = "provincia"
        Me.provincia.Size = New System.Drawing.Size(159, 21)
        Me.provincia.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(381, 293)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Canton"
        '
        'canton
        '
        Me.canton.FormattingEnabled = True
        Me.canton.Location = New System.Drawing.Point(542, 293)
        Me.canton.Name = "canton"
        Me.canton.Size = New System.Drawing.Size(159, 21)
        Me.canton.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(381, 327)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Distrito"
        '
        'distrito
        '
        Me.distrito.FormattingEnabled = True
        Me.distrito.Location = New System.Drawing.Point(542, 327)
        Me.distrito.Name = "distrito"
        Me.distrito.Size = New System.Drawing.Size(159, 21)
        Me.distrito.TabIndex = 11
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(705, 13)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(31, 13)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "inicio"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(15, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Label13"
        '
        'access
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 450)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.distrito)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.canton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.provincia)
        Me.Controls.Add(Me.correo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.contacto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.telefono)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nombretext)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.genrocombo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.texfisica)
        Me.Controls.Add(Me.texjuridica)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "access"
        Me.Text = "access"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents texjuridica As MaskedTextBox
    Friend WithEvents texfisica As MaskedTextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents genrocombo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nombretext As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents direccion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents telefono As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents contacto As TextBox
    Friend WithEvents correo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents provincia As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents canton As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents distrito As ComboBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label13 As Label
End Class
