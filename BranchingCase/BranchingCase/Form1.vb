Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case TextBox3.Text
            Case "+"
                Dim suma As Integer
                suma = Int(TextBox1.Text) + Int(TextBox2.Text)
                Label4.Text = suma
                Return
            Case "-"
                Dim resta As Integer
                resta = Int(TextBox1.Text) - Int(TextBox2.Text)
                Label4.Text = resta
                Return
            Case "*"
                Dim multiplicacion As Integer
                multiplicacion = Int(TextBox1.Text) * Int(TextBox2.Text)
                Label4.Text = multiplicacion
                Return
            Case "/"
                Dim division As Double
                division = Int(TextBox1.Text) / Int(TextBox2.Text)
                Label4.Text = division
                Return
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
