<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_sumplementos
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
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.NumericUpDown()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_preciocompra = New System.Windows.Forms.NumericUpDown()
        Me.txt_precioventa = New System.Windows.Forms.NumericUpDown()
        Me.cmb_proveedor = New System.Windows.Forms.ComboBox()
        Me.ckb_activo = New System.Windows.Forms.CheckBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        CType(Me.txt_codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_preciocompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_precioventa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(367, 327)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(42, 29)
        Me.btn_salir.TabIndex = 23
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.Enabled = False
        Me.btn_borrar.Location = New System.Drawing.Point(176, 306)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(56, 50)
        Me.btn_borrar.TabIndex = 20
        Me.btn_borrar.Text = "Borrar"
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Location = New System.Drawing.Point(92, 306)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(57, 50)
        Me.btn_guardar.TabIndex = 21
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(14, 306)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(53, 50)
        Me.btn_nuevo.TabIndex = 22
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Precio Compra"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Precio Venta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Proveedor"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(114, 28)
        Me.txt_codigo.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(216, 20)
        Me.txt_codigo.TabIndex = 30
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(114, 68)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(214, 20)
        Me.txt_nombre.TabIndex = 31
        '
        'txt_preciocompra
        '
        Me.txt_preciocompra.Enabled = False
        Me.txt_preciocompra.Location = New System.Drawing.Point(112, 113)
        Me.txt_preciocompra.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txt_preciocompra.Name = "txt_preciocompra"
        Me.txt_preciocompra.Size = New System.Drawing.Size(216, 20)
        Me.txt_preciocompra.TabIndex = 30
        '
        'txt_precioventa
        '
        Me.txt_precioventa.Enabled = False
        Me.txt_precioventa.Location = New System.Drawing.Point(112, 160)
        Me.txt_precioventa.Maximum = New Decimal(New Integer() {-1530494976, 232830, 0, 0})
        Me.txt_precioventa.Name = "txt_precioventa"
        Me.txt_precioventa.Size = New System.Drawing.Size(216, 20)
        Me.txt_precioventa.TabIndex = 30
        '
        'cmb_proveedor
        '
        Me.cmb_proveedor.Enabled = False
        Me.cmb_proveedor.FormattingEnabled = True
        Me.cmb_proveedor.Location = New System.Drawing.Point(112, 204)
        Me.cmb_proveedor.Name = "cmb_proveedor"
        Me.cmb_proveedor.Size = New System.Drawing.Size(216, 21)
        Me.cmb_proveedor.TabIndex = 32
        '
        'ckb_activo
        '
        Me.ckb_activo.AutoSize = True
        Me.ckb_activo.Enabled = False
        Me.ckb_activo.Location = New System.Drawing.Point(112, 249)
        Me.ckb_activo.Name = "ckb_activo"
        Me.ckb_activo.Size = New System.Drawing.Size(56, 17)
        Me.ckb_activo.TabIndex = 33
        Me.ckb_activo.Text = "Activo"
        Me.ckb_activo.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(354, 28)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(55, 20)
        Me.btn_buscar.TabIndex = 34
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'ABM_sumplementos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 359)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.ckb_activo)
        Me.Controls.Add(Me.cmb_proveedor)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_precioventa)
        Me.Controls.Add(Me.txt_preciocompra)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Name = "ABM_sumplementos"
        Me.Text = "Suplementos"
        CType(Me.txt_codigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_preciocompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_precioventa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_borrar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_codigo As NumericUpDown
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_preciocompra As NumericUpDown
    Friend WithEvents txt_precioventa As NumericUpDown
    Friend WithEvents cmb_proveedor As ComboBox
    Friend WithEvents ckb_activo As CheckBox
    Friend WithEvents btn_buscar As Button
End Class
