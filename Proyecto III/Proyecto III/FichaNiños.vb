Imports System.Data.OleDb

Public Class FichaNiños
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cosby\OneDrive\Documentos\ProyectoFinalProgra III\Base de datos Proyecto.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As Integer
    Dim cadena As New OleDbConnection
    Dim comando As New OleDbCommand
    Dim actualizar As String

    Dim da As New OleDb.OleDbDataAdapter
    Private btneditar As Object
    Public Property DataGridView1 As Object

    Sub loadrecord()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()
            sql = "Select * from Fichaniños"
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
    Private Sub limpiar()

    End Sub

    Private Sub FichaNiños_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        cadena.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cosby\OneDrive\Documentos\ProyectoFinalProgra III\Base de datos Proyecto.accdb")

        Dim consults As String
        Dim oda As New OleDbDataAdapter
        Dim ods As DataSet
        Dim check As Byte


        If NombreCliente.Text <> " " Then

            consults = "Select *From Fichaniños WHERE Nombre= '" & NombreCliente.Text & " '"
            oda = New OleDbDataAdapter(consults, cadena)
            ods = New DataSet
            oda.Fill(ods, "FichaNiños")
            check = ods.Tables("FichaNiños").Rows.Count


            If check <> 0 Then

                '_________________________

                '"',Nombre='" & TextNombre.Text &
                If NombreCliente.Text <> " " Then

                    Try
                        cadena.Open()
                        actualizar = "Update Fichaniños SET Nombre ='" & NombreCliente.Text &
                            "',Edad='" & Edad.Text &
                            "',Sexo='" & Sexo.Text &
                            "',Encargado='" & Encargado.Text &
                            "',DPI='" & DPI.Text &
                            "',Direccion='" & Direccion.Text &
                            "',Ocupacion='" & Profesion.Text &
                            "',Telefono='" & Telefono.Text &
                            "',Dentista='" & DentistaDoc.Text &
                            "',Motivo='" & Motivo.Text &
                            "',TomaMedicamento='" & TomaMedicamento.Text &
                            "',Alergias='" & Alergias.Text &
                            "',Diabetes='" & Diabetes.Text &
                            "',Presion='" & Presion.Text &
                            "',Embarazo='" & Embarazo.Text &
                            "',Cirugias='" & Cirugias.Text &
                            "',Accidentes='" & Accidentes.Text &
                             "',Dolor='" & Dolor.Text &
                            "',Habitos='" & Habitos.Text &
                            "',Ulceras='" & Ulceras.Text &
                            "',Sangrado='" & Sangrado.Text &
                            "',Extracciones='" & Extracciones.Text &
                            "',Cepilla='" & Cepilla.Text &
                           "',HiloDental='" & HiloDental.Text &
                            "',ProAnestecia='" & ProAnestecia.Text &
                            "' Where Nombre ='" & NombreCliente.Text & "'"

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

                If (Direccion.Text <> "") Then

                    Try
                        con.Open()
                        sql = "INSERT INTO Fichaniños (Nombre,Edad,Sexo,Encargado,DPI,Direccion,Ocupacion,Telefono,Dentista,Motivo,TomaMedicamento, Alergias, Diabetes,Presion, Embarazo, Cirugias, Accidentes, Dolor, Habitos, Ulceras, Sangrado, Extracciones, Cepilla, HiloDental, ProAnestecia) values ('" & NombreCliente.Text & "', '" & Edad.Text & "', '" & Sexo.Text & "', '" & Encargado.Text & "', '" & DPI.Text & "', '" & Direccion.Text & "', '" & Profesion.Text & "', '" & Telefono.Text & "', '" & DentistaDoc.Text & "', '" & Motivo.Text & "', '" & TomaMedicamento.Text & "', '" & Alergias.Text & "', '" & Diabetes.Text & "', '" & Presion.Text & "', '" & Embarazo.Text & "', '" & Cirugias.Text & "', '" & Accidentes.Text & "', '" & Dolor.Text & "', '" & Habitos.Text & "', '" & Ulceras.Text & "', '" & Sangrado.Text & "', '" & Extracciones.Text & "', '" & Cepilla.Text & "', '" & HiloDental.Text & "', '" & ProAnestecia.Text & "' );"
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
        sqll = "Select *From Fichaniños"
        Dim adapt As New OleDb.OleDbDataAdapter(sqll, cadena)
        Dim obtenerdatos As New DataSet
        adapt.Fill(obtenerdatos, "Nombre")
        DataGridViewNiños.DataSource = obtenerdatos
        DataGridViewNiños.DataMember = "Nombre"
        cadena.Close()
        Me.Refresh()
        limpiar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cadena.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cosby\OneDrive\Documentos\ProyectoFinalProgra III\Base de datos Proyecto.accdb")
        cadena.Open()

        Dim consults As String
        Dim oda As New OleDbDataAdapter
        Dim ods As DataSet
        Dim check As Byte

        If BuscadorNiños.Text <> " " Then

            consults = "Select * From Pacientes WHERE Nombre = '" & BuscadorNiños.Text & " '"
            oda = New OleDbDataAdapter(consults, cadena)
            ods = New DataSet
            oda.Fill(ods, "Pacientes")
            check = ods.Tables("Pacientes").Rows.Count

            If check <> 0 Then
                'DataGridView1.DataSource = ods
                'DataGridView1.DataMenber = "Usuarios"

                NombreCliente.Text = ods.Tables("Pacientes").Rows(0).Item("Nombre")
                Edad.Text = ods.Tables("Pacientes").Rows(0).Item("Edad")
                Sexo.Text = ods.Tables("Pacientes").Rows(0).Item("Sexo")
                DPI.Text = ods.Tables("Pacientes").Rows(0).Item("Documento")
                Direccion.Text = ods.Tables("Pacientes").Rows(0).Item("Direccion")
                Telefono.Text = ods.Tables("Pacientes").Rows(0).Item("Telefono")

                cadena.Close()
            Else
                'MsgBox("No Existe el Registro", vbCritical, "Aviso")
                cadena.Close()
            End If


        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim MenuP As New MenuP
        MenuP.Show()
        Me.Hide()

    End Sub

End Class