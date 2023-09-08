Imports System.Data.OleDb

Public Class conecxion
    Dim cadena As New OleDbConnection 'Se declara variable para manejo de conexion con DB
    Dim comando As New OleDbCommand
    Dim id As String
    Dim cedula As Boolean = True
    Public Sub exe(vistaEx)
        Dim v As String
        Try

            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim dataSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter

            Dim path As String

            v = "no se establecio la coneccion "
            path = My.Computer.FileSystem.ReadAllText("C:\Users\mecho\OneDrive\programcion 3\exubicacion.txt")

            v = "no se pudo conectar a exel"

            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;")
            v = "hoja de exel no existe"

            MsgBox("coneccion establecida...")

            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [hoja1$]", MyConnection)

            dataSet = New System.Data.DataSet

            MyCommand.Fill(dataSet)
            vistaEx.DataSource = dataSet.Tables(0)

            MyConnection.Close()
            MyConnection.Close()
        Catch ex As Exception
            MsgBox("errror..." + v)
        End Try
    End Sub
    'primera coneccion.......................................................................
    Public Sub ingresoacc(data)
        Dim path As String
        path = My.Computer.FileSystem.ReadAllText("C:\Users\mecho\OneDrive\programcion 3\acubicacion.txt")
        Try
            cadena.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
            'muestra datos de la tabla principal...
            Mostrar(data)
            '...........................

            'muestra los datos relacionados con la base de datos que se alojan en un combobox
            Genero(data)
            provincia(data)
            canton(data)
            distrito(data)
            '........................................................................
            'Si la conexion resulta exitosa.. despeglamos un mesaje!!
            MsgBox("Conexión Exitosa con la Base de Datos", vbInformation, "Aviso")
        Catch ex As Exception
            'Si la conexion FALLA.. despeglamos un mesaje!!p
            MsgBox(" error al entrar a la Base de Datos", vbInformation, "Aviso")
            menuform.Show()
            access.Close()
        End Try

    End Sub
    '.................................................................................

    Private Sub Mostrar(datagrid)

        Dim oda As New OleDbDataAdapter ' Permite conectar la sentencia con access
        Dim ods As New DataSet ' Permite almacenar registros de una DB
        Dim consulta As String ' Permite almacenar sentencia SQL
        consulta = "Select * from proveedores"

        oda = New OleDbDataAdapter(consulta, cadena) ' Conecta consulta con DB
        ods.Tables.Add("proveedores")
        oda.Fill(ods.Tables("proveedores"))
        datagrid.DataSource = ods.Tables("proveedores")
        cadena.Close()
    End Sub

    Public Sub ingresar()
        Dim path As String
        path = My.Computer.FileSystem.ReadAllText("C:\Users\mecho\OneDrive\programcion 3\acubicacion.txt")
        Try
            cadena.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path  ' Establezco la cadena de conexion
            cadena.Open() 'Se inicia la conexion con la DB previamente seleccionada

            comando = New OleDbCommand("INSERT INTO proveedores (cedula,nombre,genero,direccion,telefono,NomContacto,email,lugar,juridica) values (access.TextBoxnombre,access.nombretext,access.genrocombo,access.direccion,access.telefono,access.contacto,access.TextBox1,lugar,juridica)", cadena)

            comando.Parameters.AddWithValue("@cedula", (access.identidad))
            comando.Parameters.AddWithValue("@nombre", (access.nombretext.Text))
            comando.Parameters.AddWithValue("@genero", (access.genrocombo.Text))
            comando.Parameters.AddWithValue("@direccion", (access.direccion.Text))
            comando.Parameters.AddWithValue("@telefono", (access.telefono.Text))
            comando.Parameters.AddWithValue("@NomContacto", (access.contacto.Text))
            comando.Parameters.AddWithValue("@email", (access.correo.Text))
            comando.Parameters.AddWithValue("@lugar", lugar())
            comando.Parameters.AddWithValue("@juridica", juridica())



            comando.ExecuteNonQuery()

            MsgBox("Registro Almacenado Exitosamente", vbInformation, "Aviso")

        Catch ex As Exception

            MsgBox("Error al procesar registro", vbInformation, "Aviso")

        End Try

        cadena.Close()

    End Sub
    Public Sub Genero(mos)
        Dim oda As New OleDbDataAdapter ' Permite conectar la sentencia con access
        Dim tabla As New DataTable ' Permite almacenar registros de una DB
        Dim consulta As String ' Permite almacenar sentencia SQL
        consulta = "Select campo1 from genero"

        oda = New OleDbDataAdapter(consulta, cadena) ' Conecta consulta con DB

        oda.Fill(tabla)
        access.genrocombo.DataSource = tabla
        access.genrocombo.DisplayMember = "genero"
        access.genrocombo.ValueMember = "campo1"


        cadena.Close()
    End Sub
    Public Sub provincia(provinvia)
        Dim x As String
        Dim oda As New OleDbDataAdapter ' Permite conectar la sentencia con access
        Dim tabla As New DataTable ' Permite almacenar registros de una DB
        Dim consulta As String ' Permite almacenar sentencia SQL
        consulta = "Select id, provincia from provincia"

        Dim consulta2 As String ' Permite almacenar sentencia SQL
        consulta2 = "Select id,cantones,id_provincia from canton where id_provincia =" & id

        oda = New OleDbDataAdapter(consulta, cadena) ' Conecta consulta con DB

        oda.Fill(tabla)
        access.provincia.DataSource = tabla
        access.provincia.ValueMember = "id"
        access.provincia.DisplayMember = "provincia"



        ' x = access.provincia2.Text

        cadena.Close()
        'MsgBox(x)

    End Sub

    Public Sub canton(canton)
        'variable que guarda la id de canton relacional
        id = access.provincia.SelectedValue.ToString


        Dim oda As New OleDbDataAdapter ' Permite conectar la sentencia con access
        Dim tabla As New DataTable ' Permite almacenar registros de una DB
        Dim consulta As String ' Permite almacenar sentencia SQL
        consulta = "Select id,cantones,id_provincia from canton where id_provincia =" & id

        oda = New OleDbDataAdapter(consulta, cadena) ' Conecta consulta con DB

        oda.Fill(tabla)
        access.canton.DataSource = tabla
        access.canton.DisplayMember = "cantones"
        access.canton.ValueMember = "id"

        cadena.Close()


    End Sub

    Public Sub distrito(canton)
        'variable que guarda la id de canton relacional
        id = access.canton.SelectedValue.ToString
        '  MsgBox(id)

        Dim oda As New OleDbDataAdapter ' Permite conectar la sentencia con access
        Dim tabla As New DataTable ' Permite almacenar registros de una DB
        Dim consulta As String ' Permite almacenar sentencia SQL
        consulta = "Select id,distrito,id_canton from distrito where id_canton =" & id

        oda = New OleDbDataAdapter(consulta, cadena) ' Conecta consulta con DB

        oda.Fill(tabla)
        access.distrito.DataSource = tabla
        access.distrito.DisplayMember = "distrito"
        access.distrito.ValueMember = "id"

        cadena.Close()


    End Sub

    Public Function lugar()

        Dim plugar As String
        plugar = access.provincia.Text + " " + access.canton.Text + " " + access.distrito.Text
        Return plugar
    End Function

    Public Function juridica()
        If access.texjuridica.Enabled Then
            cedula = True
        Else
            cedula = False
        End If
        Return cedula
    End Function
End Class
