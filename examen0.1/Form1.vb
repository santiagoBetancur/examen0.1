Public Class inicio
    'variables
    Dim con As New controlador
    Dim control As Boolean = True
    Dim control2 As Boolean = True
    '0 nombre, 1 contrase;a 
    Dim usuario(1, 9) As String
    Dim cont As New controlador


    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuario(0, 0) = "pedro"
        usuario(1, 0) = "pedro"
        ' access.Show()
        ' menuform.Show()
        'excel.Show()
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles nombre.MaskInputRejected

    End Sub

    Private Sub registro_Click(sender As Object, e As EventArgs) Handles registro.Click
        'manejo de los botones y label
        If control = True Then
            nombre.Visible = False
            contrase.Visible = False
            Label6ingreso.Visible = False
            regnombre.Visible = True
            regcontr.Visible = True
            Label5registro.Visible = True

            Button1.Visible = True
            control = False
            registro.Visible = False
            ingresar.Visible = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nombre.Visible = True
        contrase.Visible = True
        regnombre.Visible = False
        regcontr.Visible = False
        Label5registro.Visible = False
        Label6ingreso.Visible = True
        Button1.Visible = False
        registro.Visible = True
        ingresar.Visible = True
        control = True
        Try
            If (regnombre.Text <> Nothing) Then

                For y = 0 To 9
                    If (usuario(0, y) = Nothing And usuario(1, y) = Nothing) Then
                        usuario(0, y) = regnombre.Text
                        usuario(1, y) = regcontr.Text
                        MsgBox("usuario registrado...", vbInformation, "informacion")
                        Exit For
                    End If

                Next
            Else
                MsgBox("ponga un nombre en usuario", vbExclamation, "")
            End If
        Catch ex As Exception

            MsgBox("error al ingrar usuario")
        End Try
    End Sub

    Private Sub ingresar_Click(sender As Object, e As EventArgs) Handles ingresar.Click
        For y = 0 To 9
            If (usuario(0, y) = nombre.Text And usuario(0, y) <> Nothing And usuario(1, y) = contrase.Text And usuario(1, y) <> Nothing) Then
                menuform.Show()
                con.cerrar()
                control2 = False
                Exit For

            Else


            End If
        Next
        If (control2 = True) Then
            MsgBox("usuario o contraseña invalida")
        End If

    End Sub


End Class
