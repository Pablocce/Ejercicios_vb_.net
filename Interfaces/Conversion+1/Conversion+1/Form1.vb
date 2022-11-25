Public Class Form1
    Dim fecha As Date = Now
    Dim Valor As String = Format(fecha, "dd/MM/yy")
    Dim aux As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Valor


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        aux = Int(TextBox2.Text)
        TextBox2.Text = Int(aux) + 1
        TextBox3.Text = Int(TextBox2.Text) * 1.8 + 32
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        aux = Int(TextBox3.Text)
        TextBox3.Text = Int(aux) + 1
        TextBox2.Text = (Int(TextBox3.Text) - 32) / 1.8
    End Sub
End Class
