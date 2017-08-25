Public Class Form1

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Estas seguro que desea salir?", "ABM", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_tipo.Items.Add("DNI")
        cmb_tipo.Items.Add("L.E")
        cmb_tipo.Items.Add("Pasaporte")

    End Sub


    Private Sub txt_apellido_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_apellido.KeyPress

        If IsNumeric(e.KeyChar) = True Then
            e.KeyChar = ""
            MessageBox.Show("Se ha ingresado un apellido no valido")
        End If

    End Sub

    Private Sub txt_nombre_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress

        If IsNumeric(e.KeyChar) = True Then
            e.KeyChar = ""
            MessageBox.Show("Se ha ingresado un nombre no valido")
        End If
    End Sub

    Private Sub txt_fecha_TextChanged(sender As Object, e As EventArgs)
        If IsDate(sender.Text) Then
            MessageBox.Show("Se ha ingresado una Fecha no valida")
            sender.Text = ""
        End If
    End Sub

    Private Sub txt_documento_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_doc.KeyPress

        If IsNumeric(e.KeyChar) = False Then
            e.KeyChar = ""
            MessageBox.Show("Se ha ingresado una letra")
        End If
    End Sub

    Private Sub btn_fem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmb_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo.SelectedIndexChanged

    End Sub

    Private Sub cmd_exit_Click(sender As Object, e As EventArgs) Handles cmd_exit.Click
        Me.Close()
    End Sub



    Private Sub cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click
        If txt_apellido.Text = "" Or txt_nombre.Text = "" Or txt_doc.Text = "" Or txt_calle.Text = "" Or txt_num.Value = 0 Then
            MessageBox.Show("Ha dejado algun campo vacio")

        ElseIf cmb_tipo.SelectedIndex = -1 Then
            MessageBox.Show("No se ha ingresado tipo de documento")

        End If
    End Sub

    Private Sub btn_fem_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        txt_apellido.Enabled = True
        txt_nombre.Enabled = True
        DateTimePicker1.Enabled = True
        cmb_tipo.Enabled = True
        txt_doc.Enabled = True
        txt_calle.Enabled = True
        txt_num.Enabled = True
        cmd_save.Enabled = True
        cmd_erase.Enabled = True
    End Sub


End Class
