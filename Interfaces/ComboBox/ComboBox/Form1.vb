Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex <> -1 And TextBox1.Text <> Nothing Then
            ListBox1.Items.Add(TextBox1.Text)
            ListBox2.Items.Add(ComboBox1.SelectedItem)
        Else
            MsgBox("No has rellenado todo correctamente")
        End If
    End Sub

    'Boton Eliminar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex <> -1 And ListBox2.SelectedIndex <> -1 And ListBox1.SelectedIndex = ListBox2.SelectedIndex Then
            Dim aux As Integer = ListBox1.SelectedIndex
            ListBox1.Items.RemoveAt(aux)
            ListBox2.Items.RemoveAt(aux)
        End If
        If ListBox1.SelectedIndex <> -1 And ListBox2.SelectedIndex <> -1 And ListBox1.SelectedIndex <> ListBox2.SelectedIndex Then
            MsgBox("Los elementos seleccionados no coinciden")
        End If
        If ListBox1.Items.Count > 0 Then
            If ListBox1.SelectedIndex = -1 Then
                ListBox1.Items.RemoveAt(0)
                ListBox2.Items.RemoveAt(0)
            End If
        Else
            MsgBox("No puedes borrar algo que no existe")

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub
End Class
