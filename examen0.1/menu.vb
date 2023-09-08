Public Class menuform
    Dim control As New controlador
    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub menuform_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        inicio.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        excel.Show()
        control.cerrar_menu()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        control.cerrar_menu()
        access.Show()

    End Sub
End Class