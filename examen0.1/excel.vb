Public Class excel
    Dim conectar As New conecxion
    Dim control As New controlador
    Private Sub excel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar.exe(DataGridView1)
        Label1.Text = "Usuario  " + inicio.nombre.Text
    End Sub

    Private Sub excel_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        inicio.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        menuform.Show()
        control.cerrar_exel()
    End Sub


End Class