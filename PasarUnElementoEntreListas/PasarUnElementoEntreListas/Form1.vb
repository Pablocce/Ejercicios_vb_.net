Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox3.SelectedIndex <> -1 Then
            Dim var As String = ListBox3.SelectedItem
            ListBox1.Items.Add(var)
            ListBox3.Items.Remove(var)
        End If
        If ListBox2.SelectedIndex <> -1 Then
            Dim var As String = ListBox2.SelectedItem
            ListBox1.Items.Add(var)
            ListBox2.Items.Remove(var)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex <> -1 Then
            Dim var As String = ListBox1.SelectedItem
            ListBox2.Items.Add(var)
            ListBox1.Items.Remove(var)
        End If
        If ListBox3.SelectedIndex <> -1 Then
            Dim var As String = ListBox3.SelectedItem
            ListBox2.Items.Add(var)
            ListBox3.Items.Remove(var)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox1.SelectedIndex <> -1 Then
            Dim var As String = ListBox1.SelectedItem
            ListBox3.Items.Add(var)
            ListBox1.Items.Remove(var)
        End If
        If ListBox2.SelectedIndex <> -1 Then
            Dim var As String = ListBox2.SelectedItem
            ListBox3.Items.Add(var)
            ListBox2.Items.Remove(var)
        End If

    End Sub
End Class
