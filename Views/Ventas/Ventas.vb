Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Newtonsoft.Json

Public Class Ventas

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

    Sub RellenarDatagrid()
        'References to source and target grid.

        Dim sourceGrid As DataGridView = Me.dataGV_Mercancia

        Dim targetGrid As DataGridView = Me.datagventas

        'Copy all rows and cells.

        Dim targetRows = New List(Of DataGridViewRow)

        For Each sourceRow As DataGridViewRow In sourceGrid.Rows

            If (Not sourceRow.IsNewRow) Then

                Dim targetRow = CType(sourceRow.Clone(), DataGridViewRow)

                'The Clone method do not copy the cell values so we must do this manually.
                'See: https://msdn.microsoft.com/en-us/library/system.windows.forms.datagridviewrow.clone(v=vs.110).aspx

                For Each cell As DataGridViewCell In sourceRow.Cells
                    targetRow.Cells(cell.ColumnIndex).Value = cell.Value
                Next

                targetRows.Add(targetRow)

            End If
        Next

        'Clear target columns and then clone all source columns.

        targetGrid.Columns.Clear()

        For Each column As DataGridViewColumn In sourceGrid.Columns
            targetGrid.Columns.Add(CType(column.Clone(), DataGridViewColumn))
        Next

        'It's recommended to use the AddRange method (if available)
        'when adding multiple items to a collection.

        targetGrid.Rows.AddRange(targetRows.ToArray())

    End Sub
    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        RellenarDatagrid()
    End Sub

    Private Sub dataGV_Mercancia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGV_Mercancia.CellContentClick

    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        ConexionDataGrid()
    End Sub
End Class