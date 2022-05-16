Public Class MenuP
    Dim Usuario As New Usuario
    Dim Citas As New Citas
    Dim Pacientes As New Pacientes
    Dim FichaAdulto As New FichaAdulto
    Dim FichaNiños As New FichaNiños
    Dim Reportes As New Reportes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Usuario.Show()
        Me.Hide()
    End Sub
    Private Sub MenuP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Pacientes.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FichaAdulto.Show()
        Me.Hide()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Citas.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FichaNiños.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Reportes.Show()
        Me.Hide()
    End Sub
End Class