Imports System.Dynamic
Imports System.Linq.Expressions

Public Class Form1

    Public Structure Libros
        Public titulo As String
        Public autor As String
        Public tema As String
        Public paginas As String
        Public formato As String
        Public estado As String
    End Structure

    Public x As Integer = 0

    Function Borrar()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.SelectedIndex = -1
        TextBox4.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Function

    Dim libro(x) As Libros
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click  'Dar de alta
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox4.Text = Nothing Or ComboBox1.SelectedItem = -1 Then
            MsgBox("Introduce todos los valores")
        End If
        libro(x).titulo = TextBox1.Text
        libro(x).autor = TextBox2.Text
        libro(x).tema = ComboBox1.SelectedItem
        libro(x).paginas = TextBox4.Text
        If (CheckBox1.Checked) Then
            libro(x).formato = CheckBox1.Text
        End If
        If (CheckBox2.Checked) Then
            libro(x).formato = CheckBox2.Text
        End If
        If (CheckBox3.Checked) Then
            libro(x).formato = CheckBox3.Text
        End If

        If (RadioButton1.Checked) Then
            libro(x).estado = RadioButton1.Text
        Else libro(x).estado = RadioButton2.Text
        End If

        ListBox1.Items.Add(libro(x).titulo)
        Borrar()
        x += 1

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If (CheckBox3.Checked) Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Borrar()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim aux As Integer = ListBox1.SelectedIndex
        TextBox1.Text = libro(aux).titulo
        TextBox2.Text = libro(aux).autor
        ComboBox1.SelectedItem = libro(aux).tema
        TextBox4.Text = libro(aux).paginas
        If (libro(aux).formato = "Cartone") Then
            CheckBox1.Checked = True
        End If
        If (libro(aux).formato = "Rústica") Then
            CheckBox2.Checked = True
        End If
        If (libro(aux).formato = "TapaDura") Then
            CheckBox3.Checked = True
        End If

        If (libro(aux).estado = "Novedad") Then
            RadioButton1.Checked = True
        Else RadioButton2.Checked = True
        End If


    End Sub
End Class
