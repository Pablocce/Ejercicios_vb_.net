Imports System.Net.Security

Public Class Form1
    Private Structure Pedidos
        Public idPedido As Integer
        Public cantidad As Integer
        Public marca As String
        Public total As Double

    End Structure

    Public x As Integer = 0
    Dim pedido(10) As Pedidos

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Fortuna")
            ListBox1.Items.Add("Ducados")

        End If
        If ComboBox1.SelectedIndex = 1 Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Camel")
        End If
        If ComboBox1.SelectedIndex = 2 Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Malboro")
        End If
        If ComboBox1.SelectedIndex = -1 Then
            ListBox1.Items.Clear()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem = "Fortuna" Then
            TextBox2.Text = 20
            TextBox3.Text = 1
            TextBox4.Text = 3
            TextBox5.Text = "5% de descuento"
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\Fotos\FORTUNA.jpg")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If ListBox1.SelectedItem = "Ducados" Then
            TextBox2.Text = 15
            TextBox3.Text = 3
            TextBox4.Text = 5
            TextBox5.Text = "10% de descuento"
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\Fotos\DUCADOS.jpg")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If ListBox1.SelectedItem = "Camel" Then
            TextBox2.Text = 20
            TextBox3.Text = 5
            TextBox4.Text = 2
            TextBox5.Text = "5% de descuento"
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\Fotos\CAMEL.jpg")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        If ListBox1.SelectedItem = "Malboro" Then
            TextBox2.Text = 10
            TextBox3.Text = 5
            TextBox4.Text = 1
            TextBox5.Text = "5% de descuento"
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\Fotos\MALBORO.jpg")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage



        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim precioTotal As Double
        Dim descuento As Boolean
        If CheckBox1.Checked Then
            descuento = False
        Else descuento = True
        End If
        Dim cantidad As Integer = NumericUpDown1.Value
        Dim precio As Integer = TextBox4.Text
        Dim descuentoMarca As Integer

        If ListBox1.SelectedItem = "Ducados" Then
            descuentoMarca = 10
        Else descuentoMarca = 5
        End If

        Dim descuentoproducto As Double = (cantidad * precio) * descuentoMarca / 100


        precioTotal = (cantidad * precio) - descuentoproducto

        If descuento = True Then
            MsgBox("El precio total es de: " & precioTotal)
        Else MsgBox("El precio total es de: " & precioTotal * 2)
        End If

        pedido(x).idPedido = x
        pedido(x).cantidad = cantidad
        Dim auxiliar As String = ListBox1.SelectedItem
        pedido(x).marca = auxiliar
        pedido(x).total = precioTotal

        x = x + 1
        ListBox2.Items.Add(x)

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox2.SelectedIndex = -1 Then
            MsgBox("Selecciona un pedido para borrar")
        Else
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim auxiliar As Integer = ListBox2.SelectedIndex

        MsgBox("Pedido:" & auxiliar & " Unidades: " & pedido(auxiliar).cantidad & " Precio: " & pedido(auxiliar).total)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
