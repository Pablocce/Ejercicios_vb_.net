Public Class Form1
    Dim numero As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        numero = TextBox2.Text
        For i As Integer = 0 To 9

            TextBox1.Text = ToString(TextBox1.Text) + ToString(numero * i)

        Next

    End Sub
End Class
