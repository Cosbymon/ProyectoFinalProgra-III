Imports System.Data.OleDb

Public Class Pacientes
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
            sql = "Select * from Pacientes"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cadena1 As OleDbConnection = cadena
        cadena1.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cosby\OneDrive\Documentos\ProyectoFinalProgra III\Base de datos Proyecto.accdb")

        Dim consults As String
        Dim oda As New OleDbDataAdapter
        Dim ods As DataSet
        Dim check As Byte


        If PacienteNuevo.Text <> " " Then

            consults = "Select *From Pacientes WHERE Nombre= '" & PacienteNuevo.Text & " '"
            oda = New OleDbDataAdapter(consults, cadena)
            ods = New DataSet
            oda.Fill(ods, "Pacientes")
            check = ods.Tables("Pacientes").Rows.Count


            If check <> 0 Then

                '_________________________

                '"',Nombre='" & TextNombre.Text &
                If PacienteNuevo.Text <> " " Then

                    Try
                        cadena.Open()
                        actualizar = "Update Pacientes SET Nombre ='" & PacienteNuevo.Text &
                             "',Nombre='" & PacienteNuevo.Text &
                            "',DPI='" & DocumentoPersonal.Text &
                            "',Fecha='" & FechaInicio.Text &
                            "',Edad='" & EdadPaciente.Text &
                            "',Sexo='" & GeneroPaciente.Text &
                            "',Telefono='" & NumeroTelefono.Text &
                            "',Direccion='" & DireccionPaciente.Text & "'"

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

                If (PacienteNuevo.Text <> "") Then

                    Try
                        con.Open()
                        sql = "INSERT INTO Pacientes (Nombre,DPI,Fecha,Edad,sexo, Telefono, Direccion) values ('" & PacienteNuevo.Text & "', '" & DocumentoPersonal.Text & "', '" & FechaInicio.Text & "', '" & EdadPaciente.Text & "', '" & GeneroPaciente.Text & "', '" & NumeroTelefono.Text & "' , '" & DireccionPaciente.Text & "' );"
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
        sqll = "Select *From Pacientes"
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
        PacienteNuevo.Clear()
        DocumentoPersonal.Clear()
        FechaInicio.Clear()
        GeneroPaciente.Items.Clear()
        EdadPaciente.Clear()
        NumeroTelefono.Clear()
        DireccionPaciente.Clear()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim MenuP As New MenuP
        MenuP.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim FichaAdulto As New FichaAdulto
        FichaAdulto.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim FichaNiños As New FichaNiños
        FichaNiños.Show()
        Me.Hide()
    End Sub
End Class