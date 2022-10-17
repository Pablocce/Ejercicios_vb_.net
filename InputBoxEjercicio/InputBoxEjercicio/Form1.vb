Public Class Form1
    Dim cantidad As Integer
    Dim interes As Integer
    Dim meses As Integer
    Dim total As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cantidad = InputBox("Cual es la cantidad de dinero", "Cantidad", "Introducelo aquí")
        Label1.Text = cantidad
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        interes = InputBox("Cuanto interés tiene el prestamo?", "Prestamo", "Introducelo aquí")
        Label2.Text = interes
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        meses = InputBox("En cuantos meses lo quieres aplazar?", "Periodo", "Introducelo aquí")
        Label3.Text = meses
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        total = ((Label1.Text * Label2.Text / 100) + Label1.Text) / Label3.Text
        Label4.Text = total
    End Sub
End Class
