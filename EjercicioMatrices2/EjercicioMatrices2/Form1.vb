Public Class Form1
    Dim numeros(20) As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num As Integer
        num = TextBox2.Text
        numeros(Int(TextBox1.Text)) = num
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Int(TextBox1.Text) + 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = Int(TextBox1.Text) - 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox3.Text = ""
        TextBox4.Text = ""
        For i As Integer = 0 To 19
            If numeros(i) = Nothing Then
                TextBox3.Text = TextBox3.Text + "Posición: " & i & vbCrLf
            Else
                TextBox4.Text = TextBox4.Text + "Posición: " & i & vbCrLf
            End If


        Next
    End Sub
End Class
