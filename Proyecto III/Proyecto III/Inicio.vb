Imports System.Data.OleDb

Public Class Inicio
    Dim MenuP As New MenuP
    'declaramos variables
    Dim conexionDB As New OleDbConnection
    Dim comandos As New OleDbCommand
    Dim adaptador As New OleDbDataAdapter
    Dim lector As OleDbDataReader
    Dim consulta As String
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'declaramos MenuP como Nuevo MenuP
        'hacemos una consula para corroborar datos en la BD 
        'si los datos coinciden con la BD nos dara acceso a la aplicacion 
        consulta = "SELECT Usuario, Contraseña From Usuarios WHERE Usuario ='" & TextUser.Text & "' AND Contraseña = '" & TextPass.Text & "'"
        comandos = New OleDbCommand(consulta, conexionDB)
        adaptador.SelectCommand = comandos
        lector = comandos.ExecuteReader
        If lector.HasRows = True Then
            'MsgBox("Bienvenido", vbInformation, "Bien!")

            '_________________________________
            Dim enlaceDB As New OleDbConnection
            enlaceDB.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cosby\OneDrive\Documentos\ProyectoFinalProgra III\Base de datos Proyecto.accdb")
            enlaceDB.Open()
            Dim consults As String
            Dim oda As New OleDbDataAdapter
            Dim ods As DataSet
            Dim check As Byte

            consults = "Select *From Usuarios WHERE Usuario= '" & TextUser.Text & "' "
            oda = New OleDbDataAdapter(consults, enlaceDB)
            ods = New DataSet
            oda.Fill(ods, "Usuarios")
            check = ods.Tables("Usuarios").Rows.Count

            '__________________________________


            limpiar()
            Dim f2 As New MenuP()
            MenuP.Show()
            Me.Hide()
        Else
            ' caso contrario si los datos son incorrectos y no coinciden con la BD no nos dara acceso a la aplicacion 
            msgbox()
            limpiar()

        End If
    End Sub

    Private Shared Function msgbox() As (String, vbCritical As MsgBoxStyle, String)
        msgbox = ("El Usuario o Contraseña es Incorrecto.", vbCritical, "Atencion!")
    End Function

    Private Sub limpiar()
        TextUser.Clear()
        TextPass.Clear()
        TextUser.Focus()
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'iniciamos un try 
            'verdadero 
            'iniciamos una coneccion a la BD por medio de la Llave 
            conexionDB.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cosby\OneDrive\Documentos\ProyectoFinalProgra III\Base de datos Proyecto.accdb")
            'abrimos coneccion con ld BD
            conexionDB.Open()
        Catch ex As Exception
            'caso contrrio si la BD no funciona nos mandara una alerta
            'falso
            'msgbox("Error al conectar con la Base de Datos", vbCritical, "Sin Coneccion")
        End Try
    End Sub
End Class
