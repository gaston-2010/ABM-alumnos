Public Class Menu
    Private Sub MaquinasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaquinasToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Form1.ShowDialog()

    End Sub
End Class