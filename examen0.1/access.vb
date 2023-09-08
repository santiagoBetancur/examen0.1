Public Class access
    Public control As Boolean = True
    Public control2 As Boolean = False
    Public identidad As Integer
    Public ayuda As String
    Public juridica As Boolean = True
    Dim llenar As New conecxion
    Dim controlac As New controlador



    '/////////////
    Private Sub access_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label13.Text = "Usuario  " + inicio.nombre.Text

        If control = True Then

            llenar.ingresoacc(DataGridView1)
            control = False
            control2 = True
        End If

        'MsgBox(Me.ayuda)
    End Sub

    Private Sub access_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        inicio.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'manejo que el primer digito no sea cero....................................
        Try

            If texjuridica.Enabled = True Then
                identidad = texjuridica.Text

            Else
                identidad = texfisica.Text

                juridica = False
            End If


        Catch ex As Exception
            MsgBox("Digite una identificacion ", MessageBoxIcon.Warning, "fallo falta de datos")

        End Try
        llenar.ingresar()
        llenar.ingresoacc(DataGridView1)




    End Sub
    'controles de el tipo de identidad........................................................................
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        genrocombo.Enabled = False
        texfisica.Enabled() = False
        texjuridica.Enabled = True
        texfisica.Clear()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        genrocombo.Enabled = True
        texfisica.Enabled() = True
        texjuridica.Enabled = False
        texjuridica.Clear()
    End Sub


    Private Sub provincia_TextChanged(sender As Object, e As EventArgs) Handles provincia.TextChanged


        If (control2 = True) Then

            llenar.canton(canton)
            llenar.distrito(distrito)
        End If
        llenar.lugar()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        menuform.Show()
        controlac.cerrar_acces()
    End Sub

    Private Sub canton_TextChanged(sender As Object, e As EventArgs) Handles canton.TextChanged
        If (control2 = True) Then
            llenar.distrito(distrito)

        End If
    End Sub


End Class