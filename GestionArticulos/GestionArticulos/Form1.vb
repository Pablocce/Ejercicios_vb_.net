Public Class Form1
    Dim cant As Integer
    Dim preciouni As Integer
    Dim dto As Double
    Dim pvp As Integer
    Dim cantTotal As Integer
    Dim articulos() As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        End If
    End Sub
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox5.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cant = Int(TextBox2.Text)
        preciouni = Int(TextBox3.Text)
        If cant = 1 Then
            dto = 0
        ElseIf cant <= 3 Then
            dto = 3
        ElseIf cant >= 4 And cant <= 7 Then
            dto = 7
        Else
            dto = 15
        End If
        TextBox4.Text = dto
        pvp = cant * preciouni
        TextBox5.Text = pvp
        cantTotal = pvp - (pvp * dto / 100)
        TextBox6.Text = cantTotal
        TextBox6.Visible = True
        Label6.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To 4
            articulos(i) = InputBox("Introduce un valor")
        Next

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For i As Integer = 0 To Len(articulos)

            TextBox6.Text = TextBox6.Text & articulos(i) & vbCrLf
        Next
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class
