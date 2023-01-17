Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Excel

Public Class Form1
    Dim conexion As New OleDbConnection()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\pablo\Documents\GitHub\Ejercicios_vb_.net\Bases_Datos\database\dbbanco.accdb"
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            conexion.Open()
            Dim consulta = New OleDbCommand("select * from tbcuentas where Numero_Cuenta = " & TextBox1.Text, conexion)
            Dim datareader As OleDbDataReader
            datareader = consulta.ExecuteReader
            If datareader.Read() Then
                TextBox2.Text = datareader("Nombre")
                TextBox3.Text = datareader("Saldo")
            Else
                MsgBox("no existe un número de cuenta como el introducido")
            End If
        End If
        conexion.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            conexion.Open()
            If TextBox1.Text <> Nothing And TextBox2.Text <> Nothing Then
                Dim cantidad = InputBox("Introduce el dinero a retirar")
                If cantidad > 0 Then
                    Dim consulta = New OleDbCommand("update tbcuentas set Saldo = Saldo - " & cantidad & " where Numero_Cuenta = " & TextBox1.Text, conexion)
                    consulta.ExecuteNonQuery()
                    Dim aux = TextBox3.Text - cantidad
                    MsgBox("Dinero retirado")
                    TextBox3.Text = aux

                Else MsgBox("Introduce una cantidad valida o mayor a cero")
                End If
            Else MsgBox("Introduce un numero de cuenta")
            End If
        Catch ex As Exception
            MsgBox("Error no identificado, repita el proceso correctamente")
        End Try

        conexion.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Try
            conexion.Open()
            If TextBox1.Text <> Nothing And TextBox2.Text <> Nothing Then
                Dim cantidad = InputBox("Introduce el dinero a ingresar")
                If cantidad > 0 Then
                    Dim consulta = New OleDbCommand("update tbcuentas set Saldo = Saldo + " & cantidad & " where Numero_Cuenta = " & TextBox1.Text, conexion)
                    consulta.ExecuteNonQuery()
                    MsgBox("Dinero ingresado")
                    Dim aux = TextBox3.Text + cantidad
                    TextBox3.Text = aux

                Else MsgBox("Introduce una cantidad valida o mayor a cero")
                End If
            Else MsgBox("Introduce un numero de cuenta")
            End If

        Catch ex As Exception
            MsgBox("Error desconocido")
        End Try
        conexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            conexion.Open()
            Dim numeroCuenta As Integer = InputBox("Introduce un número de cuenta")
            Dim Nombre As String = InputBox("Introduce el nombre")
            Dim Saldo As Integer = InputBox("Introduce el saldo ")
            Dim insert = New OleDbCommand("insert into tbcuentas values(@a,@b,@c)", conexion)
            insert.Parameters.AddWithValue("@a", numeroCuenta)
            insert.Parameters.AddWithValue("@b", Nombre)
            insert.Parameters.AddWithValue("@c", Saldo)
            insert.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error desconocido")
        End Try
        conexion.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            conexion.Open()
            Dim numeroCuenta As Integer = InputBox("Introduce un número de cuenta que quieres dar de baja")
            Dim delete = New OleDbCommand("delete from tbcuentas where Numero_Cuenta = " & numeroCuenta, conexion)
            delete.ExecuteNonQuery()
            MsgBox("Cuenta número: " & numeroCuenta & " eliminada")
        Catch ex As Exception
            MsgBox("Error, no se puede borrar esa cuenta")
        End Try
        conexion.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conexion.Open()
        Try
            Dim numCuenta = InputBox("Introduce el número de cuenta que quieres modificar")
            Dim opcion As Integer = InputBox("Que quieres modificar: /n Numero de cuenta --> 1  Nombre --> 2 Saldo --> 3")
            Select Case opcion
                Case 1
                    Dim nuevoNumeroCuenta As Integer = InputBox("Introduce el nuevo número de cuenta")
                    Dim update = New OleDbCommand("update from tbcuentas set Numero_Cuenta = " & nuevoNumeroCuenta & "where Numero_Cuenta = " & numCuenta, conexion)
                    update.ExecuteNonQuery()
                    MsgBox("Cuenta modificada")
                Case 2
                    Dim nuevoNombre As Integer = InputBox("Introduce el nuevo nombre")
                    Dim update = New OleDbCommand("update from tbcuentas set Nombre = " & nuevoNombre & " where Numero_Cuenta = " & numCuenta, conexion)
                    update.ExecuteNonQuery()
                    MsgBox("Cuenta modificada")
                Case 3
                    Dim nuevoSaldo As Integer = InputBox("Introduce el nuevo saldo")
                    Dim update = New OleDbCommand("update from tbcuentas set Saldo = " & nuevoSaldo & " where Numero_Cuenta = " & numCuenta, conexion)
                    update.ExecuteNonQuery()
                    MsgBox("Cuenta modificada")
                Case Else
                    MsgBox("Introduce un valor correcto")
            End Select
        Catch ex As Exception
            MsgBox("Error")
        End Try
        conexion.Close()
    End Sub
End Class
