<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_prov = New System.Windows.Forms.Label()
        Me.lbl_area = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.NumericUpDown()
        Me.cmb_prov = New System.Windows.Forms.ComboBox()
        Me.cmb_area = New System.Windows.Forms.ComboBox()
        Me.txt_date = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.cmd_exit = New System.Windows.Forms.Button()
        Me.cmd_erase = New System.Windows.Forms.Button()
        Me.cmd_save = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        CType(Me.txt_id, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(25, 29)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id.TabIndex = 0
        Me.lbl_id.Text = "ID"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(25, 62)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(25, 95)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_descripcion.TabIndex = 0
        Me.lbl_descripcion.Text = "Descripcion"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(25, 178)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(90, 13)
        Me.lbl_fecha.TabIndex = 0
        Me.lbl_fecha.Text = "Fecha de compra"
        '
        'lbl_prov
        '
        Me.lbl_prov.AutoSize = True
        Me.lbl_prov.Location = New System.Drawing.Point(25, 140)
        Me.lbl_prov.Name = "lbl_prov"
        Me.lbl_prov.Size = New System.Drawing.Size(56, 13)
        Me.lbl_prov.TabIndex = 0
        Me.lbl_prov.Text = "Proveedor"
        '
        'lbl_area
        '
        Me.lbl_area.AutoSize = True
        Me.lbl_area.Location = New System.Drawing.Point(25, 215)
        Me.lbl_area.Name = "lbl_area"
        Me.lbl_area.Size = New System.Drawing.Size(29, 13)
        Me.lbl_area.TabIndex = 0
        Me.lbl_area.Text = "Area"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(63, 27)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(34, 20)
        Me.txt_id.TabIndex = 1
        '
        'cmb_prov
        '
        Me.cmb_prov.Enabled = False
        Me.cmb_prov.FormattingEnabled = True
        Me.cmb_prov.Location = New System.Drawing.Point(102, 138)
        Me.cmb_prov.Name = "cmb_prov"
        Me.cmb_prov.Size = New System.Drawing.Size(190, 21)
        Me.cmb_prov.TabIndex = 2
        '
        'cmb_area
        '
        Me.cmb_area.Enabled = False
        Me.cmb_area.FormattingEnabled = True
        Me.cmb_area.Location = New System.Drawing.Point(102, 207)
        Me.cmb_area.Name = "cmb_area"
        Me.cmb_area.Size = New System.Drawing.Size(190, 21)
        Me.cmb_area.TabIndex = 3
        '
        'txt_date
        '
        Me.txt_date.Enabled = False
        Me.txt_date.Location = New System.Drawing.Point(137, 175)
        Me.txt_date.Mask = "00/00/0000"
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(68, 20)
        Me.txt_date.TabIndex = 4
        Me.txt_date.ValidatingType = GetType(Date)
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(100, 59)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(192, 20)
        Me.txt_nombre.TabIndex = 5
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Enabled = False
        Me.txt_descripcion.Location = New System.Drawing.Point(100, 93)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(192, 20)
        Me.txt_descripcion.TabIndex = 6
        '
        'cmd_exit
        '
        Me.cmd_exit.Location = New System.Drawing.Point(391, 274)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.Size = New System.Drawing.Size(52, 22)
        Me.cmd_exit.TabIndex = 23
        Me.cmd_exit.Text = "Salir"
        Me.cmd_exit.UseVisualStyleBackColor = True
        '
        'cmd_erase
        '
        Me.cmd_erase.Enabled = False
        Me.cmd_erase.Location = New System.Drawing.Point(186, 256)
        Me.cmd_erase.Name = "cmd_erase"
        Me.cmd_erase.Size = New System.Drawing.Size(62, 37)
        Me.cmd_erase.TabIndex = 20
        Me.cmd_erase.Text = "Borrar"
        Me.cmd_erase.UseVisualStyleBackColor = True
        '
        'cmd_save
        '
        Me.cmd_save.Enabled = False
        Me.cmd_save.Location = New System.Drawing.Point(100, 256)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(57, 37)
        Me.cmd_save.TabIndex = 21
        Me.cmd_save.Text = "Guardar"
        Me.cmd_save.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(12, 257)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(57, 36)
        Me.cmd_nuevo.TabIndex = 22
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 308)
        Me.Controls.Add(Me.cmd_exit)
        Me.Controls.Add(Me.cmd_erase)
        Me.Controls.Add(Me.cmd_save)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.cmb_area)
        Me.Controls.Add(Me.cmb_prov)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_area)
        Me.Controls.Add(Me.lbl_prov)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_id)
        Me.Name = "Form2"
        Me.Text = "ABM Maquinas"
        CType(Me.txt_id, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_descripcion As Label
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents lbl_prov As Label
    Friend WithEvents lbl_area As Label
    Friend WithEvents txt_id As NumericUpDown
    Friend WithEvents cmb_prov As ComboBox
    Friend WithEvents cmb_area As ComboBox
    Friend WithEvents txt_date As MaskedTextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents cmd_exit As Button
    Friend WithEvents cmd_erase As Button
    Friend WithEvents cmd_save As Button
    Friend WithEvents cmd_nuevo As Button
End Class
