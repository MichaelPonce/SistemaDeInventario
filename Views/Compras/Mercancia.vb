Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Newtonsoft.Json

Public Class Mercancia

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

        Dim res As FirebaseResponse = client.Get("Mercancias/")
        Dim data As Dictionary(Of String, MercanciasConexion) = JsonConvert.DeserializeObject(Of Dictionary(Of String, MercanciasConexion))(res.Body.ToString())
        UpdateDataGrid(data)
    End Sub

    Sub UpdateDataGrid(ByVal records As Dictionary(Of String, MercanciasConexion))
        dataGV_Mercancia.Rows.Clear()
        dataGV_Mercancia.Columns.Clear()

        dataGV_Mercancia.Columns.Add("Id", "ID")
        dataGV_Mercancia.Columns.Add("Nombre", "Nombre")
        dataGV_Mercancia.Columns.Add("Precio", "Precio")
        dataGV_Mercancia.Columns.Add("PrecioCompra", "Precio Compra")
        dataGV_Mercancia.Columns.Add("Stock", "Stock")
        dataGV_Mercancia.Columns.Add("Codigo", "Codigo")
        dataGV_Mercancia.Columns.Add("Categoria", "Categoria")
        dataGV_Mercancia.Columns.Add("Subcategoria", "Subcategoria")

        For Each item In records
            dataGV_Mercancia.Rows.Add(item.Value.Id, item.Value.Nombre, item.Value.Precio,
                                        item.Value.PrecioCompra, item.Value.Stock, item.Value.Codigo,
                                        item.Value.Categoria, item.Value.Subcategoria)
        Next

    End Sub

    Sub Limpiar()
        txtNombreMer.Clear()
        txtPrecioMer.Clear()
        txtCompraMer.Clear()
        txtStockMer.Clear()
        txtIdMer.Clear()
        txtCodigoMer.Clear()
        txtCatMer.Clear()
        txtSubCatMer.Clear()

    End Sub
    Private Sub Mercancia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        ConexionDataGrid()
        Limpiar()
    End Sub

    Private Sub btnGenerarIdMer_Click(sender As Object, e As EventArgs) Handles btnGenerarIdMer.Click
        Try

            Dim random As Random = New Random
            Dim num As Integer
            num = (random.Next(1, 999))
            Dim IDresults As String = Strings.Right("000" & num.ToString(), 3)

            Dim Check_ID = client.Get("Mercancias/" + IDresults)

            '-------------------------------------------Condicion para revisar si el id a sido asignado.
            If Check_ID.Body <> "null" Then
                MessageBox.Show("El mismo ID a sido asignado, Crea un Nuevo ID Presionando El Boton Generar ID.", "Mensaje De Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                txtIdMer.Text = IDresults
            End If
            '-------------------------------------------
        Catch ex As Exception
            If ex.Message = "Uno o Mas Errores Han Ocurrido." Then
                txtIdMer.Clear()
                MessageBox.Show("No es posible Conectarse, Revisa tu conexion a Internet !", "Mensaje De Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                txtIdMer.Clear()
                MessageBox.Show(ex.Message, "Mensaje De Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub btnAgregarMer_Click(sender As Object, e As EventArgs) Handles btnAgregarMer.Click
        If btnAgregarMer.Text = "Agregar" Then
            If txtNombreMer.Text = Nothing Then
                MessageBox.Show("Campo Nombre Vacio." & vbCrLf & "Por favor Rellena Este Campo Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtIdMer.Text = Nothing Then
                MessageBox.Show("Id Esta Vacio." & vbCrLf & "Por favor Rellena El Campo Id Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtPrecioMer.Text = Nothing Then
                MessageBox.Show("Campo Precio Esta Vacio." & vbCrLf & "Por favor Rellena El Campo Ciudad Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtCompraMer.Text = Nothing Then
                MessageBox.Show("Campo Precio Compra Esta Vacio." & vbCrLf & "Por favor Rellena El Campo Empresa Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtStockMer.Text = Nothing Then
                MessageBox.Show("Campo Stock Esta Vacio." & vbCrLf & "Por favor Rellena El Campo Email Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtCodigoMer.Text = Nothing Then
                MessageBox.Show("Campo Codigo Barra Esta Vacio." & vbCrLf & "Por favor Rellena El Campo Telefono Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtCatMer.Text = Nothing Then
                MessageBox.Show("Campo Categoria Esta Vacio." & vbCrLf & "Por favor Rellena El Campo Numero Ruc Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtSubCatMer.Text = Nothing Then
                MessageBox.Show("Campo Subcategoria Esta Vacio." & vbCrLf & "Por favor Rellena El Campo Numero Ruc Para Continuar.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try

                Dim NewMercancia As New MercanciasConexion() With
            {
            .Id = txtIdMer.Text,
            .Nombre = txtNombreMer.Text,
            .Precio = txtPrecioMer.Text,
            .PrecioCompra = txtCompraMer.Text,
            .Stock = txtStockMer.Text,
            .Codigo = txtCodigoMer.Text,
            .Categoria = txtCatMer.Text,
            .Subcategoria = txtSubCatMer.Text
            }

                Dim Show = client.Set("Mercancias/" + txtIdMer.Text, NewMercancia)
                MessageBox.Show("Registrado Con Exito")

                BtnLimpiar_Click(sender, e)
                ConexionDataGrid()
            Catch ex As Exception
                If ex.Message = "Uno o Mas Errores Han Ocurrido." Then
                    MessageBox.Show("No Es Posible Conectarse Con Firebase, Revisa Tu Conexion !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End Try

        Else

            If txtNombreMer.Text = Nothing Then
                MessageBox.Show("Name field is empty." & vbCrLf & "Please fill in the name field to continue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtIdMer.Text = Nothing Then
                MessageBox.Show("City field is empty." & vbCrLf & "Please fill in the name field to continue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


        End If

    End Sub

    Private Sub btnEditarMer_Click(sender As Object, e As EventArgs) Handles btnEditarMer.Click
        If dataGV_Mercancia.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor Selecione Una Fila Para Editar", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If dataGV_Mercancia.SelectedRows.Count > 1 Then
            MessageBox.Show("Seleccionaste " & dataGV_Mercancia.SelectedRows.Count & " Fila En La Tabla." & vbCrLf & "Solo Puedes Editar Un Elemento A La Vez", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try

            Dim NewMercancia As New MercanciasConexion() With
            {
            .Id = txtIdMer.Text,
            .Nombre = txtNombreMer.Text,
            .Precio = txtPrecioMer.Text,
            .PrecioCompra = txtCompraMer.Text,
            .Stock = txtStockMer.Text,
            .Codigo = txtCodigoMer.Text,
            .Categoria = txtCatMer.Text,
            .Subcategoria = txtSubCatMer.Text
            }

            Dim update = client.Update("Mercancias/" + txtIdMer.Text, NewMercancia) 'To update data to Firebase Database.


            MessageBox.Show("Datos Actualizados satisfatoriamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

            BtnLimpiar_Click(sender, e)
            ConexionDataGrid()
        Catch ex As Exception
            If ex.Message = "Ha Ocurrido Un Error." Then
                MessageBox.Show("No Es Posible Conectarse, Revisa Tu Conexion!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End Try
    End Sub

    Private Sub btnEliminarMer_Click(sender As Object, e As EventArgs) Handles btnEliminarMer.Click
        Try
            If dataGV_Mercancia.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor seleccione una fila para eliminar.", "Mensaje De Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If MsgBox("Quiere eliminar esta Fila?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmacion") = MsgBoxResult.Cancel Then Return

            Me.Text = "VB Net Firebase RealTime Database (Eliminando. Por favor Espere...)"

            For Each Fila As DataGridViewRow In dataGV_Mercancia.SelectedRows
                If Fila.Selected = True Then
                    Dim Eliminar = client.Delete("Mercancias/" + txtIdMer.Text)
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

    Private Sub dataGV_Mercancia_SelectionChanged(sender As Object, e As EventArgs) Handles dataGV_Mercancia.SelectionChanged
        'Obtén el número de la fila que se seleccionó en el Datagridview
        Dim FilaActual As Integer
        FilaActual = dataGV_Mercancia.CurrentRow.Index

        'Mostrar en el cuadro de texto o TextBox1 en valor de la columna ID del usuario seleccionado
        txtIdMer.Text = dataGV_Mercancia.Rows(FilaActual).Cells(0).Value
        txtNombreMer.Text = dataGV_Mercancia.Rows(FilaActual).Cells(1).Value
        txtPrecioMer.Text = dataGV_Mercancia.Rows(FilaActual).Cells(2).Value
        txtCompraMer.Text = dataGV_Mercancia.Rows(FilaActual).Cells(3).Value
        txtStockMer.Text = dataGV_Mercancia.Rows(FilaActual).Cells(4).Value
        txtCodigoMer.Text = dataGV_Mercancia.Rows(FilaActual).Cells(5).Value
        txtCatMer.Text = dataGV_Mercancia.Rows(FilaActual).Cells(6).Value
        txtSubCatMer.Text = dataGV_Mercancia.Rows(FilaActual).Cells(7).Value
    End Sub
End Class