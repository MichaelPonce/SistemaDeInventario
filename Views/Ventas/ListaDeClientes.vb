Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Newtonsoft.Json
Public Class ListaDeClientes

    'Conexion con Firebase'
    Private fcon As New FirebaseConfig() With
        {
            .AuthSecret = "YeERFJXQk9gKBrqwXsootLVjQx7SzmrLy33YZuno",
            .BasePath = "https://erp-uni-default-rtdb.firebaseio.com/"
        }
    Private client As IFirebaseClient

    'Final de Conexion Con Firebase'
    Private Sub ConexionDataGrid()
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        Dim res As FirebaseResponse = client.Get("Clientes/")
        Dim data As Dictionary(Of String, ClientesConexion) = JsonConvert.DeserializeObject(Of Dictionary(Of String, ClientesConexion))(res.Body.ToString())
        UpdateDataGrid(data)
    End Sub

    Sub UpdateDataGrid(ByVal records As Dictionary(Of String, ClientesConexion))
        dataGV_ListaClientes.Rows.Clear()
        dataGV_ListaClientes.Columns.Clear()

        dataGV_ListaClientes.Columns.Add("Id", "ID")
        dataGV_ListaClientes.Columns.Add("Nombres", "Nombres")
        dataGV_ListaClientes.Columns.Add("Ciudad", "Ciudad")
        dataGV_ListaClientes.Columns.Add("Telefono", "Telefono")
        dataGV_ListaClientes.Columns.Add("TipoCliente", "Tipo De Cliente")
        dataGV_ListaClientes.Columns.Add("DNI", "DNI")
        dataGV_ListaClientes.Columns.Add("Email", "Email")

        For Each item In records
            dataGV_ListaClientes.Rows.Add(item.Value.Id, item.Value.Nombres, item.Value.Ciudad,
                                        item.Value.Telefono, item.Value.TipoCliente, item.Value.DNI,
                                        item.Value.Email)
        Next

    End Sub

    Sub Limpiar()
        txtNombreCli.Clear()
        ComboxCiudad.Items.Clear()
        txtTelefonoCli.Clear()
        txtTipoCliente.Clear()
        txtDniCli.Clear()
        txtEmailCli.Clear()
        txtIDCli.Clear()

    End Sub
    Private Sub ListaDeClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        ConexionDataGrid()
        Limpiar()
    End Sub

    Private Sub btn_AgregarCliente_Click(sender As Object, e As EventArgs) Handles btn_AgregarCliente.Click
        If btn_AgregarCliente.Text = "Agregar" Then
            If txtNombreCli.Text = Nothing Then
                MessageBox.Show("Campo Nombre Vacio." & vbCrLf & "Por favor Rellena Este Campo Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If ComboxCiudad.Text = Nothing Then
                MessageBox.Show("Ciudad Esta Vacio." & vbCrLf & "Por favor Rellena El Campo Id Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtTelefonoCli.Text = Nothing Then
                MessageBox.Show("Campo Telefono Esta Vacio." & vbCrLf & "Por favor Rellena El Campo Ciudad Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtTipoCliente.Text = Nothing Then
                MessageBox.Show("Campo Tipo Cliente Compra Esta Vacio." & vbCrLf & "Por favor Rellena El Campo Empresa Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtDniCli.Text = Nothing Then
                MessageBox.Show("Campo Dni Esta Vacio." & vbCrLf & "Por favor Rellena El Campo Email Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtEmailCli.Text = Nothing Then
                MessageBox.Show("Campo Email Esta Vacio." & vbCrLf & "Por favor Rellena El Campo Telefono Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtIDCli.Text = Nothing Then
                MessageBox.Show("Campo Id Esta Vacio." & vbCrLf & "Por favor Rellena El Campo Numero Ruc Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try

                Dim NewCliente As New ClientesConexion() With
            {
            .Id = txtIDCli.Text,
            .Nombres = txtNombreCli.Text,
            .Ciudad = ComboxCiudad.Text,
            .Telefono = txtTelefonoCli.Text,
            .TipoCliente = txtTipoCliente.Text,
            .DNI = txtDniCli.Text,
            .Email = txtEmailCli.Text
            }

                Dim Show = client.Set("Clientes/" + txtIDCli.Text, NewCliente)
                MessageBox.Show("Registrado Con Exito")

                btnLimpiarCliente_Click(sender, e)
                ConexionDataGrid()
            Catch ex As Exception
                If ex.Message = "Uno o Mas Errores Han Ocurrido." Then
                    MessageBox.Show("No Es Posible Conectarse Con Firebase, Revisa Tu Conexion !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End Try

        Else

            If txtNombreCli.Text = Nothing Then
                MessageBox.Show("Name field is empty." & vbCrLf & "Please fill in the name field to continue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtIDCli.Text = Nothing Then
                MessageBox.Show("City field is empty." & vbCrLf & "Please fill in the name field to continue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


        End If

    End Sub

    Private Sub btnGenerarId_Click(sender As Object, e As EventArgs) Handles btnGenerarId.Click
        Try

            Dim random As Random = New Random
            Dim num As Integer
            num = (random.Next(1, 999))
            Dim IDresults As String = Strings.Right("000" & num.ToString(), 3)

            Dim Check_ID = client.Get("Clientes/" + IDresults)

            '-------------------------------------------Condicion para revisar si el id a sido asignado.
            If Check_ID.Body <> "null" Then
                MessageBox.Show("El mismo ID a sido asignado, Crea un Nuevo ID Presionando El Boton Generar ID.", "Mensaje De Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                txtIDCli.Text = IDresults
            End If
            '-------------------------------------------
        Catch ex As Exception
            If ex.Message = "Uno o Mas Errores Han Ocurrido." Then
                txtIDCli.Clear()
                MessageBox.Show("No es posible Conectarse, Revisa tu conexion a Internet !", "Mensaje De Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                txtIDCli.Clear()
                MessageBox.Show(ex.Message, "Mensaje De Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Private Sub btnLimpiarCliente_Click(sender As Object, e As EventArgs) Handles btnLimpiarCliente.Click
        Limpiar()
    End Sub

    Private Sub btn_EditarCliente_Click(sender As Object, e As EventArgs) Handles btn_EditarCliente.Click
        If dataGV_ListaClientes.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor Selecione Una Fila Para Editar", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If dataGV_ListaClientes.SelectedRows.Count > 1 Then
            MessageBox.Show("Seleccionaste " & dataGV_ListaClientes.SelectedRows.Count & " Fila En La Tabla." & vbCrLf & "Solo Puedes Editar Un Elemento A La Vez", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try

            Dim NewCLiente As New ClientesConexion() With
            {
            .Id = txtIDCli.Text,
            .Nombres = txtNombreCli.Text,
            .Ciudad = ComboxCiudad.Text,
            .Telefono = txtTelefonoCli.Text,
            .TipoCliente = txtTipoCliente.Text,
            .DNI = txtDniCli.Text,
            .Email = txtEmailCli.Text
            }

            Dim update = client.Update("Clientes/" + txtIDCli.Text, NewCLiente) 'To update data to Firebase Database.


            MessageBox.Show("Datos Actualizados satisfatoriamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnLimpiarCliente_Click(sender, e)
            ConexionDataGrid()
        Catch ex As Exception
            If ex.Message = "Ha Ocurrido Un Error." Then
                MessageBox.Show("No Es Posible Conectarse, Revisa Tu Conexion!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End Try
    End Sub

    Private Sub btn_EliminarCliente_Click(sender As Object, e As EventArgs) Handles btn_EliminarCliente.Click
        Try
            If dataGV_ListaClientes.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor seleccione una fila para eliminar.", "Mensaje De Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If MsgBox("Quiere eliminar esta Fila?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmacion") = MsgBoxResult.Cancel Then Return

            Me.Text = "VB Net Firebase RealTime Database (Eliminando. Por favor Espere...)"

            For Each Fila As DataGridViewRow In dataGV_ListaClientes.SelectedRows
                If Fila.Selected = True Then
                    Dim Eliminar = client.Delete("Mercancias/" + txtIDCli.Text)
                End If
            Next

            ConexionDataGrid()
            MessageBox.Show("Informacion Eliminada Con Exito.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            If ex.Message = "Uno o Mas Errores Han Ocurrido" Then
                MessageBox.Show("No es Posible conectarse, Revisa Tu Conexion", "Mensaje De Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(ex.Message, "Mensaje De Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Private Sub dataGV_ListaClientes_SelectionChanged(sender As Object, e As EventArgs) Handles dataGV_ListaClientes.SelectionChanged
        'Obtén el número de la fila que se seleccionó en el Datagridview
        Dim FilaActual As Integer
        FilaActual = dataGV_ListaClientes.CurrentRow.Index

        'Mostrar en el cuadro de texto o TextBox1 en valor de la columna ID del usuario seleccionado
        txtIDCli.Text = dataGV_ListaClientes.Rows(FilaActual).Cells(0).Value
        txtNombreCli.Text = dataGV_ListaClientes.Rows(FilaActual).Cells(1).Value
        ComboxCiudad.Text = dataGV_ListaClientes.Rows(FilaActual).Cells(2).Value
        txtTelefonoCli.Text = dataGV_ListaClientes.Rows(FilaActual).Cells(3).Value
        txtTipoCliente.Text = dataGV_ListaClientes.Rows(FilaActual).Cells(4).Value
        txtDniCli.Text = dataGV_ListaClientes.Rows(FilaActual).Cells(5).Value
        txtEmailCli.Text = dataGV_ListaClientes.Rows(FilaActual).Cells(6).Value
    End Sub
End Class