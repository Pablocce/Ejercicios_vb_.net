Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim botonArray(6, 6) As Button

        Dim i As Integer
        For i = 1 To 6
            For j = 1 To 6
                botonArray(i, j) = New Button
                botonArray(i, j).Text = "DAM" & i & j
                botonArray(i, j).Width = 120
                botonArray(i, j).Height = 30

                botonArray(i, j).TextAlign = ContentAlignment.MiddleCenter

                botonArray(i, j).Font = New Font("Arial", 10, FontStyle.Bold)
                botonArray(i, j).Location = New Point(j * 100, i * 50)

                Me.Controls.Add(botonArray(i, j))
            Next
        Next
    End Sub
End Class
