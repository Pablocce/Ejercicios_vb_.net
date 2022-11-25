Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Dim A As Integer = 10
    Dim operacion As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        operacion = 3 * A + Int(TextBox1.Text)
        Label1.Text = operacion



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
