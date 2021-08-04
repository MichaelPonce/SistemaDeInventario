Public Class Inicio

    Public Shared Fname As String

    Sub Bienvenida()
        Bienvenido.Text += Fname + "!"
    End Sub
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubMenu()
        Bienvenida()
    End Sub

    Private Sub hideSubMenu()
        panelSubCompras.Visible = False
        panelSubVenta.Visible = False
    End Sub

    Private Sub showSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubMenu()
            submenu.Visible = True

        Else submenu.Visible = False
        End If
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        showSubMenu(panelSubCompras)
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        showSubMenu(panelSubVenta)
    End Sub



    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private FormActivo As Form = Nothing
    Private Sub AbrirPanelPrincipal(FormNuevo As Form)
        If FormActivo IsNot Nothing Then FormActivo.Close()
        FormActivo = FormNuevo
        FormNuevo.TopLevel = False
        FormNuevo.Dock = DockStyle.Fill
        panelPrincipal.Controls.Add(FormNuevo)
        panelPrincipal.Tag = FormNuevo
        FormNuevo.BringToFront()
        FormNuevo.Show()

    End Sub

    Private Sub BtnListProveedores_Click(sender As Object, e As EventArgs) Handles BtnListProveedores.Click
        AbrirPanelPrincipal(New ListaDeProveedores())
    End Sub

    Private Sub BtnMercancia_Click(sender As Object, e As EventArgs) Handles BtnMercancia.Click
        AbrirPanelPrincipal(New Mercancia)
    End Sub

    Private Sub btnOrdenCompra_Click(sender As Object, e As EventArgs) Handles btnOrdenCompra.Click
        AbrirPanelPrincipal(New OrdenDeCompras)
    End Sub

    Private Sub btnFacturasPendientes_Click(sender As Object, e As EventArgs) Handles btnFacturasPendientes.Click
        AbrirPanelPrincipal(New FacturaProveedores)
    End Sub

    Private Sub panelPrincipal_Paint(sender As Object, e As PaintEventArgs) Handles panelPrincipal.Paint

    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnListaClientes_Click(sender As Object, e As EventArgs) Handles btnListaClientes.Click
        AbrirPanelPrincipal(New ListaDeClientes)
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        AbrirPanelPrincipal(New Ventas)
    End Sub

    Private Sub btnListaVentas_Click(sender As Object, e As EventArgs) Handles btnListaVentas.Click
        AbrirPanelPrincipal(New ListaDeVentas)
    End Sub

    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
        AbrirPanelPrincipal(New Factura)
    End Sub
End Class