Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Bryan" And TextBox2.Text = "1234" Then
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Usuario o Contraseña incorrecta.")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"
    End Sub
End Class
