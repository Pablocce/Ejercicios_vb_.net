Public Class Form1
    Dim tablaParking(9, 9) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If tablaParking(Int(TextBox1.Text), Int(TextBox2.Text)) = 0 Then
            tablaParking(Int(TextBox1.Text), Int(TextBox2.Text)) = 1
            MsgBox("Libre, aparcado")
            TextBox3.Text = Int(TextBox3.Text) - 1
            TextBox4.Text = Int(TextBox4.Text) + 1
        Else MsgBox("Plaza ocupada")
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If tablaParking(Int(TextBox1.Text), Int(TextBox2.Text)) = 1 Then
            tablaParking(Int(TextBox1.Text), Int(TextBox2.Text)) = 0
            MsgBox("Coche sacado, plaza libre")
            TextBox4.Text = Int(TextBox4.Text) - 1
            TextBox3.Text = Int(TextBox3.Text) + 1
        Else MsgBox("No hay coche en esta plaza para sacar")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i As Integer = 0 To 9
            Dim num As Integer = i
            If (tablaParking(i, 0) = 0) Then
                TextBox5.Text = TextBox5.Text + "1" + "          " & i & vbCrLf
            End If
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For i As Integer = 0 To 9
            Dim num As Integer = i
            If (tablaParking(i, 0) = 1) Then
                TextBox6.Text = TextBox6.Text + "1" + "          " & i & vbCrLf
            End If
        Next
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class
