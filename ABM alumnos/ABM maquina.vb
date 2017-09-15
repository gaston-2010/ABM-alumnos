Public Class Form2

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Estas seguro que desea salir?", "ABM", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub txt_nombre_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress

        If IsNumeric(e.KeyChar) = True Then
            e.KeyChar = ""
            MessageBox.Show("Se ha ingresado un nombre no valido")
        End If

    End Sub


    Private Sub cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click
        If txt_nombre.Text = "" Or txt_descripcion.Text = "" Or txt_descripcion.Text = "" Or txt_date.Text = "" Or txt_id.Value = 0 Then
            MessageBox.Show("Ha dejado algun campo vacio")

        ElseIf cmb_area.SelectedIndex = -1 Then
            MessageBox.Show("No se ha ingresado area de entrenamiento")
        ElseIf cmb_prov.SelectedIndex = -1 Then
            MessageBox.Show("No se ha ingresado proveedor")

        End If
    End Sub
    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click

        txt_nombre.Enabled = True

        cmb_area.Enabled = True
        txt_descripcion.Enabled = True
        cmb_prov.Enabled = True
        txt_id.Enabled = True
        cmd_save.Enabled = True
        cmd_erase.Enabled = True
    End Sub

    Private Sub cmd_exit_Click(sender As Object, e As EventArgs) Handles cmd_exit.Click
        Me.Close()
    End Sub
End Class