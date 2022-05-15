Imports System.Data.OleDb

Public Class FichaAdulto
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
            sql = "Select * from Adultos"
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
        cadena.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cosby\OneDrive\Documentos\ProyectoFinalProgra III\Base de datos Proyecto.accdb")

        Dim consults As String
        Dim oda As New OleDbDataAdapter
        Dim ods As DataSet
        Dim check As Byte


        If TextBox1.Text <> " " Then

            consults = "Select *From Adultos WHERE Nombre= '" & TextBox1.Text & " '"
            oda = New OleDbDataAdapter(consults, cadena)
            ods = New DataSet
            oda.Fill(ods, "Adultos")
            check = ods.Tables("Adultos").Rows.Count


            If check <> 0 Then

                '_________________________

                '"',Nombre='" & TextNombre.Text &
                If TextBox1.Text <> " " Then

                    Try
                        cadena.Open()
                        actualizar = "Update Adultos SET Nombre ='" & TextBox1.Text &
                            "',Edad='" & TextBox2.Text &
                            "',Sexo='" & TextBox3.Text &
                            "',DPI='" & TextBox4.Text &
                            "',Direccion='" & TextBox5.Text &
                            "',Ocupacion='" & TextBox6.Text &
                            "',Telefono='" & TextBox7.Text &
                            "',Dentista='" & TextBox8.Text &
                            "',Motivo='" & TextBox9.Text &
                            "',Toma1='" & Toma1.Text &
                            "',Alergias1='" & Alergias1.Text &
                            "',Diabetes1='" & Diabetes1.Text &
                            "',Presion1='" & Presion1.Text &
                            "',Embarazo1='" & Embarazo1.Text &
                            "',Cirugias1='" & Cirugias1.Text &
                            "',Accidentes1='" & Accidentes1.Text &
                            "',Otras1='" & Otras1.Text &
                            "',Dolor1='" & Dolor1.Text &
                            "',Habitos1='" & Habitos1.Text &
                            "',Ulceras1='" & Ulceras1.Text &
                            "',Sangrado1='" & Sangrado1.Text &
                            "',Extracciones='" & Extracciones1.Text &
                            "',Cepillar1='" & Cepillar1.Text &
                            "',Hilo1='" & Hilo1.Text &
                            "',Anestecia1='" & Anestecia1.Text &
                            "' Where nombre ='" & TextBox1.Text & "'"

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

                If (TextBox1.Text <> "") Then

                    Try
                        con.Open()
                        sql = "INSERT INTO Adultos (Nombre,Edad, Sexo,DPI,Direccion,Ocupacion,Telefono,Dentista,Motivo,Toma1, Alergias1, Diabetes1, Presion1, Embarazo1, Cirugias1, Accidentes1, Otras1, Dolor1, Habitos1, Ulceras1, Sangrado1, Extracciones1, Cepillar1, Hilo1, Anestecia1) values ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "', '" & TextBox7.Text & "', '" & TextBox8.Text & "', '" & TextBox9.Text & "' , '" & Toma1.Text & "', '" & Alergias1.Text & "', '" & Diabetes1.Text & "', '" & Presion1.Text & "', '" & Embarazo1.Text & "', '" & Cirugias1.Text & "', '" & Accidentes1.Text & "', '" & Otras1.Text & "', '" & Dolor1.Text & "', '" & Habitos1.Text & "', '" & Ulceras1.Text & "', '" & Sangrado1.Text & "', '" & Extracciones1.Text & "', '" & Cepillar1.Text & "', '" & Hilo1.Text & "', '" & Anestecia1.Text & "');"
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
        sqll = "Select *From Adultos"
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
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox7.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cadena.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cosby\OneDrive\Documentos\ProyectoFinalProgra III\Base de datos Proyecto.accdb")
        cadena.Open()

        Dim consults As String
        Dim oda As New OleDbDataAdapter
        Dim ods As DataSet
        Dim check As Byte

        If BuscadorAdultos.Text <> " " Then

            consults = "Select * From Pacientes WHERE Nombre = '" & BuscadorAdultos.Text & " '"
            oda = New OleDbDataAdapter(consults, cadena)
            ods = New DataSet
            oda.Fill(ods, "Pacientes")
            check = ods.Tables("Pacientes").Rows.Count

            If check <> 0 Then
                'DataGridView1.DataSource = ods
                'DataGridView1.DataMenber = "Usuarios"

                TextBox1.Text = ods.Tables("Pacientes").Rows(0).Item("Nombre")
                TextBox2.Text = ods.Tables("Pacientes").Rows(0).Item("Edad")
                TextBox3.Text = ods.Tables("Pacientes").Rows(0).Item("Sexo")
                TextBox4.Text = ods.Tables("Pacientes").Rows(0).Item("Documento")
                TextBox5.Text = ods.Tables("Pacientes").Rows(0).Item("Direccion")
                TextBox7.Text = ods.Tables("Pacientes").Rows(0).Item("Telefono")

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