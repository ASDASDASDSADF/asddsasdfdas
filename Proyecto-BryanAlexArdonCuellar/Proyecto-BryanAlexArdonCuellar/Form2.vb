Public Class Form2
    Private Sub MatematicasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatematicasToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub LenguajeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LenguajeToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub CienciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CienciasToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub SeptimoGradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeptimoGradoToolStripMenuItem.Click

    End Sub

    Private Sub SocialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SocialesToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Process.Start("calc.exe")
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotepadToolStripMenuItem.Click
        Process.Start("notepad.exe")
    End Sub

    Private Sub CerrarProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarProgramaToolStripMenuItem.Click
        Dim msj As String
        msj = "¿Estás seguro que desea salir del programa?"

        Dim result As DialogResult
        result = MessageBox.Show(msj, "Ayuda de sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            End
        Else
        End If
    End Sub
End Class