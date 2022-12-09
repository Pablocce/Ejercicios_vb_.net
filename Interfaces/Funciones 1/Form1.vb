Public Class Form1

    Sub saludo1()
        MsgBox("Hola DAM")
    End Sub

    Function saludo2()
        Dim variable As String
        variable = "Adios DAM"
        Return variable
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hola As String
        hola = saludo2()
        MsgBox(hola)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        saludo1()
    End Sub
End Class
