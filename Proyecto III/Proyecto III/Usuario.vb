Imports System.Data.OleDb

Public Class Usuario
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cosby\OneDrive\Documentos\ProyectoFinalProgra III\Base de datos Proyecto.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As Integer
    Dim cadena As New OleDbConnection
    Dim comando As New OleDbCommand
    Dim actualizar As String

    Dim da As New OleDb.OleDbDataAdapter

    Sub loadrecord()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()
            sql = "Select * from Usuarios"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            ' DataGridView1.DataSource = dt
        Catch ex As Exception
            '  MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim MenuP As New MenuP
        MenuP.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cadena.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cosby\OneDrive\Documentos\ProyectoFinalProgra III\Base de datos Proyecto.accdb")

        Dim consults As String
        Dim oda As New OleDbDataAdapter
        Dim ods As DataSet
        Dim check As Byte


        If TextNombre.Text <> " " Then

            consults = "Select *From Usuarios WHERE Nombre= '" & TextNombre.Text & " '"
            oda = New OleDbDataAdapter(consults, cadena)
            ods = New DataSet
            oda.Fill(ods, "Usuarios")
            check = ods.Tables("Usuarios").Rows.Count


            If check <> 0 Then

                '_________________________

                '"',Nombre='" & TextNombre.Text &
                If TextNombre.Text <> " " Then

                    Try
                        cadena.Open()
                        actualizar = "Update Usuarios SET Nombre ='" & TextNombre.Text &
                            "',Usuario='" & TexttipoUser.Text &
                            "',Contraseña='" & TextContraseña.Text &
                            "',TipoDeUsuario='" & TexttipoUser.Text &
                            "' Where nombre ='" & TextNombre.Text & "'"

                        comando = New OleDbCommand(actualizar, cadena)
                        comando.ExecuteNonQuery()
                        ' MsgBox("Registro actualizado correctamente", vbInformation, "Aviso")
                        cadena.Close()

                    Catch ex As Exception
                        'MsgBox("No se pudo actualizar el registro", vbCritical, "Aviso")
                        cadena.Close()
                    End Try

                    limpiar()
                End If
                '__________________________-


                cadena.Close()
            Else

                If (TextNombre.Text <> "") Then

                    Try
                        con.Open()
                        sql = "INSERT INTO Usuarios (Nombre,Usuario,Contraseña,TipoDeUsuario) values ('" & TextNombre.Text & "', '" & TextUsuario.Text & "', '" & TextContraseña.Text & "', '" & TexttipoUser.Text & "' );"
                        cmd.Connection = con
                        cmd.CommandText = sql

                        i = cmd.ExecuteNonQuery
                        If i > 0 Then
                            ' MsgBox("!Un nuevo dato ha sido agregado Correctamente!!")

                        Else
                            'MsgBox("¡No se ha insertado ningún registro correctamente!")
                        End If
                    Catch ex As Exception
                        'MsgBox(ex.Message)
                    Finally
                        con.Close()
                        loadrecord()
                    End Try
                    limpiar()

                Else
                    'MsgBox("¡No se ha insertado ningún registro correctamente!")
                    limpiar()
                End If


                cadena.Close()

            End If

        End If
        cadena.Open()
        Dim sqll As String
        sqll = "Select *From Usuarios"
        Dim adapt As New OleDb.OleDbDataAdapter(sqll, cadena)
        Dim obtenerdatos As New DataSet
        adapt.Fill(obtenerdatos, "Nombre")
        DataGridView1.DataSource = obtenerdatos
        DataGridView1.DataMember = "Nombre"
        cadena.Close()
        Me.Refresh()
        limpiar()
    End Sub

    Private Sub limpiar()
        TextNombre.Clear()
        TextContraseña.Clear()
        TextUsuario.Clear()
        TextBusqueda.Clear()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextNombre.Clear()
        TextUsuario.Clear()
        TextContraseña.Clear()

    End Sub

    Private Sub TextBuscar_Click(sender As Object, e As EventArgs) Handles TextBuscar.Click

    End Sub
End Class