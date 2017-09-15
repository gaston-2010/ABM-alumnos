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
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_tdoc = New System.Windows.Forms.Label()
        Me.lbl_doc = New System.Windows.Forms.Label()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_doc = New System.Windows.Forms.TextBox()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_save = New System.Windows.Forms.Button()
        Me.cmd_erase = New System.Windows.Forms.Button()
        Me.lbl_alumnos = New System.Windows.Forms.Label()
        Me.cmd_exit = New System.Windows.Forms.Button()
        Me.txt_num = New System.Windows.Forms.NumericUpDown()
        Me.lbx_alumnos = New System.Windows.Forms.ListBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.txt_num, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(29, 21)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 0
        Me.lbl_apellido.Text = "Apellido"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(29, 54)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 1
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(7, 89)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(91, 13)
        Me.lbl_fecha.TabIndex = 2
        Me.lbl_fecha.Text = "Fecha nacimiento"
        '
        'lbl_tdoc
        '
        Me.lbl_tdoc.AutoSize = True
        Me.lbl_tdoc.Location = New System.Drawing.Point(12, 123)
        Me.lbl_tdoc.Name = "lbl_tdoc"
        Me.lbl_tdoc.Size = New System.Drawing.Size(86, 13)
        Me.lbl_tdoc.TabIndex = 5
        Me.lbl_tdoc.Text = "Tipo Documento"
        '
        'lbl_doc
        '
        Me.lbl_doc.AutoSize = True
        Me.lbl_doc.Location = New System.Drawing.Point(11, 163)
        Me.lbl_doc.Name = "lbl_doc"
        Me.lbl_doc.Size = New System.Drawing.Size(62, 13)
        Me.lbl_doc.TabIndex = 6
        Me.lbl_doc.Text = "Documento"
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Location = New System.Drawing.Point(12, 198)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(30, 13)
        Me.lbl_calle.TabIndex = 7
        Me.lbl_calle.Text = "Calle"
        '
        'txt_apellido
        '
        Me.txt_apellido.Enabled = False
        Me.txt_apellido.Location = New System.Drawing.Point(99, 14)
        Me.txt_apellido.MaxLength = 50
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(222, 20)
        Me.txt_apellido.TabIndex = 14
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(99, 48)
        Me.txt_nombre.MaxLength = 50
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(222, 20)
        Me.txt_nombre.TabIndex = 14
        '
        'txt_doc
        '
        Me.txt_doc.Enabled = False
        Me.txt_doc.Location = New System.Drawing.Point(99, 156)
        Me.txt_doc.MaxLength = 8
        Me.txt_doc.Name = "txt_doc"
        Me.txt_doc.Size = New System.Drawing.Size(222, 20)
        Me.txt_doc.TabIndex = 14
        '
        'txt_calle
        '
        Me.txt_calle.Enabled = False
        Me.txt_calle.Location = New System.Drawing.Point(99, 198)
        Me.txt_calle.MaxLength = 50
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(129, 20)
        Me.txt_calle.TabIndex = 14
        '
        'cmb_tipo
        '
        Me.cmb_tipo.Enabled = False
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New System.Drawing.Point(99, 115)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(222, 21)
        Me.cmb_tipo.TabIndex = 15
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(10, 270)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(53, 50)
        Me.cmd_nuevo.TabIndex = 17
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_save
        '
        Me.cmd_save.Enabled = False
        Me.cmd_save.Location = New System.Drawing.Point(88, 270)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(57, 50)
        Me.cmd_save.TabIndex = 17
        Me.cmd_save.Text = "Guardar"
        Me.cmd_save.UseVisualStyleBackColor = True
        '
        'cmd_erase
        '
        Me.cmd_erase.Enabled = False
        Me.cmd_erase.Location = New System.Drawing.Point(172, 270)
        Me.cmd_erase.Name = "cmd_erase"
        Me.cmd_erase.Size = New System.Drawing.Size(56, 50)
        Me.cmd_erase.TabIndex = 17
        Me.cmd_erase.Text = "Borrar"
        Me.cmd_erase.UseVisualStyleBackColor = True
        '
        'lbl_alumnos
        '
        Me.lbl_alumnos.AutoSize = True
        Me.lbl_alumnos.Location = New System.Drawing.Point(358, 11)
        Me.lbl_alumnos.Name = "lbl_alumnos"
        Me.lbl_alumnos.Size = New System.Drawing.Size(99, 13)
        Me.lbl_alumnos.TabIndex = 18
        Me.lbl_alumnos.Text = "Clientes Ingresados"
        '
        'cmd_exit
        '
        Me.cmd_exit.Location = New System.Drawing.Point(530, 295)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.Size = New System.Drawing.Size(42, 29)
        Me.cmd_exit.TabIndex = 19
        Me.cmd_exit.Text = "Salir"
        Me.cmd_exit.UseVisualStyleBackColor = True
        '
        'txt_num
        '
        Me.txt_num.Enabled = False
        Me.txt_num.Location = New System.Drawing.Point(246, 199)
        Me.txt_num.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(75, 20)
        Me.txt_num.TabIndex = 20
        '
        'lbx_alumnos
        '
        Me.lbx_alumnos.FormattingEnabled = True
        Me.lbx_alumnos.Location = New System.Drawing.Point(361, 38)
        Me.lbx_alumnos.Name = "lbx_alumnos"
        Me.lbx_alumnos.Size = New System.Drawing.Size(211, 251)
        Me.lbx_alumnos.TabIndex = 22
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(104, 82)
        Me.DateTimePicker1.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(217, 20)
        Me.DateTimePicker1.TabIndex = 23
        Me.DateTimePicker1.Value = New Date(2001, 1, 1, 0, 0, 0, 0)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 332)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lbx_alumnos)
        Me.Controls.Add(Me.txt_num)
        Me.Controls.Add(Me.cmd_exit)
        Me.Controls.Add(Me.lbl_alumnos)
        Me.Controls.Add(Me.cmd_erase)
        Me.Controls.Add(Me.cmd_save)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.txt_calle)
        Me.Controls.Add(Me.txt_doc)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.lbl_calle)
        Me.Controls.Add(Me.lbl_doc)
        Me.Controls.Add(Me.lbl_tdoc)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Name = "Form1"
        Me.Text = "Clientes"
        CType(Me.txt_num, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_tdoc As System.Windows.Forms.Label
    Friend WithEvents lbl_doc As System.Windows.Forms.Label
    Friend WithEvents lbl_calle As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_doc As System.Windows.Forms.TextBox
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_save As System.Windows.Forms.Button
    Friend WithEvents cmd_erase As System.Windows.Forms.Button
    Friend WithEvents lbl_alumnos As System.Windows.Forms.Label
    Friend WithEvents cmd_exit As System.Windows.Forms.Button
    Friend WithEvents txt_num As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbx_alumnos As System.Windows.Forms.ListBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker

End Class
