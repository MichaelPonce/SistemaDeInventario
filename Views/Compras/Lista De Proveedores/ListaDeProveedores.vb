Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Newtonsoft.Json
Imports System.ComponentModel

Public Class ListaDeProveedores

    'Conexion con Firebase'
    Private fcon As New FirebaseConfig() With
        {
            .AuthSecret = "YeERFJXQk9gKBrqwXsootLVjQx7SzmrLy33YZuno",
            .BasePath = "https://erp-uni-default-rtdb.firebaseio.com/"
        }
    Private client As IFirebaseClient

    'Final de Conexion COn Firebase'

    Private Sub ConexionDataGrid()
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        Dim res As FirebaseResponse = client.Get("Proveedores/")
        Dim data As Dictionary(Of String, ListaDeProveedoresVb) = JsonConvert.DeserializeObject(Of Dictionary(Of String, ListaDeProveedoresVb))(res.Body.ToString())
        UpdateDataGrid(data)
    End Sub

    'Obtener datos para DataGridView'
    Sub UpdateDataGrid(ByVal records As Dictionary(Of String, ListaDeProveedoresVb))
        dataGV_Proveedores.Rows.Clear()
        dataGV_Proveedores.Columns.Clear()

        dataGV_Proveedores.Columns.Add("Id", "ID")
        dataGV_Proveedores.Columns.Add("Nombres", "Nombres")
        dataGV_Proveedores.Columns.Add("Empresa", "Empresa")
        dataGV_Proveedores.Columns.Add("Direccion", "Direccion")
        dataGV_Proveedores.Columns.Add("Email", "Email")
        dataGV_Proveedores.Columns.Add("Telefono", "Telefono")
        dataGV_Proveedores.Columns.Add("NumeroRuc", "Numero Ruc")

        For Each item In records
            dataGV_Proveedores.Rows.Add(item.Value.Id, item.Value.Nombres, item.Value.Empresa,
                                        item.Value.Ciudad, item.Value.Email, item.Value.Telefono,
                                        item.Value.NumeroRuc)
        Next
    End Sub
    Private Sub ListaDeProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        ConexionDataGrid()
        Limpiar()
    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        If btn_Agregar.Text = "Agregar" Then
            If txtNombreProv.Text = Nothing Then
                MessageBox.Show("Campo Nombre Vacio." & vbCrLf & "Por favor Rellena Este Campo Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtGenerarId.Text = Nothing Then
                MessageBox.Show("Id Esta Vacio." & vbCrLf & "Por favor Rellena El Campo Id Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtCiudadProv.Text = Nothing Then
                MessageBox.Show("Campo Ciudad Esta Vacio." & vbCrLf & "Por favor Rellena El Campo Ciudad Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtEmpresaProv.Text = Nothing Then
                MessageBox.Show("Campo Empresa Esta Vacio." & vbCrLf & "Por favor Rellena El Campo Empresa Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtEmailProv.Text = Nothing Then
                MessageBox.Show("Campo Email Esta Vacio." & vbCrLf & "Por favor Rellena El Campo Email Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtTelefonoProv.Text = Nothing Then
                MessageBox.Show("Campo Telefono Esta Vacio." & vbCrLf & "Por favor Rellena El Campo Telefono Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtNumeroRucProv.Text = Nothing Then
                MessageBox.Show("Campo Numero Ruc Esta Vacio." & vbCrLf & "Por favor Rellena El Campo Numero Ruc Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try

                Dim NewProveedor As New ListaDeProveedoresVb() With
            {
            .Id = txtGenerarId.Text,
            .Nombres = txtNombreProv.Text,
            .Ciudad = txtCiudadProv.Text,
            .Email = txtEmailProv.Text,
            .Telefono = txtTelefonoProv.Text,
            .NumeroRuc = txtNumeroRucProv.Text,
            .Empresa = txtEmpresaProv.Text
            }

                Dim Show = client.Set("Proveedores/" + txtGenerarId.Text, NewProveedor)
                MessageBox.Show("Registrado Con Exito")

                btnLimpiar_Click(sender, e)
                btnRefrescar_Click(sender, e)
            Catch ex As Exception
                If ex.Message = "Uno o Mas Errores Han Ocurrido." Then
                    MessageBox.Show("No Es Posible Conectarse Con Firebase, Revisa Tu Conexion !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End Try

        Else 'Conditions for updating data to a database.

            If txtNombreProv.Text = Nothing Then
                MessageBox.Show("Name field is empty." & vbCrLf & "Please fill in the name field to continue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtCiudadProv.Text = Nothing Then
                MessageBox.Show("City field is empty." & vbCrLf & "Please fill in the name field to continue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


        End If

    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        ConexionDataGrid()
        Limpiar()
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click

        If dataGV_Proveedores.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor Selecione Una Fila Para Editar", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If dataGV_Proveedores.SelectedRows.Count > 1 Then
            MessageBox.Show("Seleccionaste " & dataGV_Proveedores.SelectedRows.Count & " Fila En La Tabla." & vbCrLf & "Solo Puedes Editar Un Elemento A La Vez", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try

            Dim NewProveedor As New ListaDeProveedoresVb() With
                    {
                    .Id = txtGenerarId.Text,
                    .Nombres = txtNombreProv.Text,
                    .Ciudad = txtCiudadProv.Text,
                    .Email = txtEmailProv.Text,
                    .Telefono = txtTelefonoProv.Text,
                    .NumeroRuc = txtNumeroRucProv.Text,
                    .Empresa = txtEmpresaProv.Text
                    }

            Dim update = client.Update("Proveedores/" + txtGenerarId.Text, NewProveedor) 'To update data to Firebase Database.


            MessageBox.Show("Datos Actualizados satisfatoriamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnLimpiar_Click(sender, e)
            btnRefrescar_Click(sender, e)
        Catch ex As Exception
            If ex.Message = "Ha Ocurrido Un Error." Then
                MessageBox.Show("No Es Posible Conectarse, Revisa Tu Conexion!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End Try

    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click

        Try
            If dataGV_Proveedores.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor seleccione una fila para eliminar.", "Mensaje De Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If MsgBox("Quiere eliminar esta Fila?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmacion") = MsgBoxResult.Cancel Then Return

            Me.Text = "VB Net Firebase RealTime Database (Eliminando. Por favor Espere...)"

            For Each Fila As DataGridViewRow In dataGV_Proveedores.SelectedRows
                If Fila.Selected = True Then
                    Dim Eliminar = client.Delete("Proveedores/" + txtGenerarId.Text)
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

    Private Sub Generar_Id_Click(sender As Object, e As EventArgs) Handles Generar_Id.Click
        Try

            Dim random As Random = New Random
            Dim num As Integer
            num = (random.Next(1, 999))
            Dim IDresults As String = Strings.Right("000" & num.ToString(), 3)

            Dim Check_ID = client.Get("Proveedores/" + IDresults)

            '-------------------------------------------Condicion para revisar si el id a sido asignado.
            If Check_ID.Body <> "null" Then
                MessageBox.Show("El mismo ID a sido asignado, Crea un Nuevo ID Presionando El Boton Generar ID.", "Mensaje De Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                txtGenerarId.Text = IDresults
            End If
            '-------------------------------------------
        Catch ex As Exception
            If ex.Message = "Uno o Mas Errores Han Ocurrido." Then
                txtGenerarId.Clear()
                MessageBox.Show("No es posible Conectarse, Revisa tu conexion a Internet !", "Mensaje De Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                txtGenerarId.Clear()
                MessageBox.Show(ex.Message, "Mensaje De Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()

    End Sub

    Sub Limpiar()
        txtNombreProv.Clear()
        txtGenerarId.Clear()
        txtEmpresaProv.Clear()
        txtNumeroRucProv.Clear()
        txtCiudadProv.Clear()
        txtEmailProv.Clear()
        txtTelefonoProv.Clear()

    End Sub

    Private Sub dataGV_Proveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGV_Proveedores.CellContentClick

    End Sub

    Private Sub dataGV_Proveedores_SelectionChanged(sender As Object, e As EventArgs) Handles dataGV_Proveedores.SelectionChanged

        'Obtén el número de la fila que se seleccionó en el Datagridview
        Dim FilaActual As Integer
        FilaActual = dataGV_Proveedores.CurrentRow.Index

        'Mostrar en el cuadro de texto o TextBox1 en valor de la columna CorreoDeUsuario del usuario seleccionado
        txtGenerarId.Text = dataGV_Proveedores.Rows(FilaActual).Cells(0).Value
        txtNombreProv.Text = dataGV_Proveedores.Rows(FilaActual).Cells(1).Value
        txtEmpresaProv.Text = dataGV_Proveedores.Rows(FilaActual).Cells(2).Value
        txtCiudadProv.Text = dataGV_Proveedores.Rows(FilaActual).Cells(3).Value
        txtEmailProv.Text = dataGV_Proveedores.Rows(FilaActual).Cells(4).Value
        txtTelefonoProv.Text = dataGV_Proveedores.Rows(FilaActual).Cells(5).Value
        txtNumeroRucProv.Text = dataGV_Proveedores.Rows(FilaActual).Cells(6).Value
    End Sub
End Class