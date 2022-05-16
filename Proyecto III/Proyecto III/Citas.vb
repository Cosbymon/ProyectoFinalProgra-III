

Imports System.Data.OleDb

Public Class Citas
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
            sql = "Select * from Citas"
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cadena.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cosby\OneDrive\Documentos\ProyectoFinalProgra III\Base de datos Proyecto.accdb")

        Dim consults As String
        Dim odap As New OleDbDataAdapter
        Dim ods As DataSet
        Dim check As Byte


        If NombreCitas.Text <> " " Then

            consults = "Select *From Citas WHERE Nombre= '" & NombreCitas.Text & " '"
            odap = New OleDbDataAdapter(consults, cadena)
            ods = New DataSet
            odap.Fill(ods, "Citas")
            check = ods.Tables("Citas").Rows.Count


            If check <> 0 Then

                '_________________________

                '"',Nombre='" & TextNombre.Text &
                If NombreCitas.Text <> " " Then

                    Try
                        cadena.Open()
                        actualizar = "Update Citas SET Nombre ='" & NombreCitas.Text &
                             "',Nombre='" & NombreCitas.Text &
                            "',Fecha='" & CalendarioCitas.Text &
                            "',Telefono='" & TelefonoCitas.Text &
                            "',Motivo='" & MotivoCitas.Text & "'"

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

                If (NombreCitas.Text <> "") Then

                    Try
                        con.Open()
                        sql = "INSERT INTO Citas (Nombre,Telefono,Fecha,Motivo) values ('" & NombreCitas.Text & "', '" & TelefonoCitas.Text & "', '" & CalendarioCitas.Text & "', '" & MotivoCitas.Text &"' );"
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
        sqll = "Select *From Citas"
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

        NombreCitas.Clear()
        MotivoCitas.Clear()
        TelefonoCitas.Clear()


    End Sub

    Private Sub regresar_Click(sender As Object, e As EventArgs) Handles regresar.Click
        Dim MenuP As New MenuP
        MenuP.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cadena.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cosby\OneDrive\Documentos\ProyectoFinalProgra III\Base de datos Proyecto.accdb")
        cadena.Open()

        Dim consults As String
        Dim odap As New OleDbDataAdapter
        Dim ods As DataSet
        Dim check As Byte

        If TextBuscadorCitas.Text <> " " Then

            consults = "Select *From Pacientes WHERE Nombre= '" & TextBuscadorCitas.Text & " '"
            odap = New OleDbDataAdapter(consults, cadena)
            ods = New DataSet
            odap.Fill(ods, "Pacientes")
            check = ods.Tables("Pacientes").Rows.Count

            If check <> 0 Then
                'DataGridView1.DataSource = ods
                'DataGridView1.DataMenber = "Usuarios"

                NombreCitas.Text = ods.Tables("Pacientes").Rows(0).Item("Nombre")
                TelefonoCitas.Text = ods.Tables("Pacientes").Rows(0).Item("Telefono")

                cadena.Close()
            Else
                'MsgBox("No Existe el Registro", vbCritical, "Aviso")
                cadena.Close()
            End If


        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class