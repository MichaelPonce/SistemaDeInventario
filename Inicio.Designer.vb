<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.Button7 = New System.Windows.Forms.Button()
        Me.panelSideMenu = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.panelSubVenta = New System.Windows.Forms.Panel()
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.btnListaVentas = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnListaClientes = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.panelSubCompras = New System.Windows.Forms.Panel()
        Me.btnFacturasPendientes = New System.Windows.Forms.Button()
        Me.btnOrdenCompra = New System.Windows.Forms.Button()
        Me.BtnListProveedores = New System.Windows.Forms.Button()
        Me.BtnMercancia = New System.Windows.Forms.Button()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.panelSideLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Bienvenido = New System.Windows.Forms.Label()
        Me.panelPrincipal = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panelSideMenu.SuspendLayout()
        Me.panelSubVenta.SuspendLayout()
        Me.panelSubCompras.SuspendLayout()
        Me.panelSideLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPrincipal.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(1116, 254)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 70)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Imprimir"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = False
        '
        'panelSideMenu
        '
        Me.panelSideMenu.AutoScroll = True
        Me.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.panelSideMenu.Controls.Add(Me.btnSalir)
        Me.panelSideMenu.Controls.Add(Me.btnCerrarSesion)
        Me.panelSideMenu.Controls.Add(Me.panelSubVenta)
        Me.panelSideMenu.Controls.Add(Me.btnVentas)
        Me.panelSideMenu.Controls.Add(Me.panelSubCompras)
        Me.panelSideMenu.Controls.Add(Me.btnCompras)
        Me.panelSideMenu.Controls.Add(Me.panelSideLogo)
        Me.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelSideMenu.Name = "panelSideMenu"
        Me.panelSideMenu.Size = New System.Drawing.Size(200, 500)
        Me.panelSideMenu.TabIndex = 9
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnSalir.Location = New System.Drawing.Point(0, 571)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnSalir.Size = New System.Drawing.Size(183, 38)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 533)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnCerrarSesion.Size = New System.Drawing.Size(183, 38)
        Me.btnCerrarSesion.TabIndex = 10
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'panelSubVenta
        '
        Me.panelSubVenta.Controls.Add(Me.btnFactura)
        Me.panelSubVenta.Controls.Add(Me.btnListaVentas)
        Me.panelSubVenta.Controls.Add(Me.btnProductos)
        Me.panelSubVenta.Controls.Add(Me.btnListaClientes)
        Me.panelSubVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSubVenta.Location = New System.Drawing.Point(0, 379)
        Me.panelSubVenta.Name = "panelSubVenta"
        Me.panelSubVenta.Size = New System.Drawing.Size(183, 154)
        Me.panelSubVenta.TabIndex = 10
        '
        'btnFactura
        '
        Me.btnFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFactura.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFactura.FlatAppearance.BorderSize = 0
        Me.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFactura.Location = New System.Drawing.Point(0, 114)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnFactura.Size = New System.Drawing.Size(183, 40)
        Me.btnFactura.TabIndex = 18
        Me.btnFactura.Text = "Factura"
        Me.btnFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFactura.UseVisualStyleBackColor = False
        '
        'btnListaVentas
        '
        Me.btnListaVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnListaVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnListaVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListaVentas.FlatAppearance.BorderSize = 0
        Me.btnListaVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListaVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListaVentas.Location = New System.Drawing.Point(0, 76)
        Me.btnListaVentas.Name = "btnListaVentas"
        Me.btnListaVentas.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnListaVentas.Size = New System.Drawing.Size(183, 38)
        Me.btnListaVentas.TabIndex = 17
        Me.btnListaVentas.Text = "Lista De Ventas"
        Me.btnListaVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListaVentas.UseVisualStyleBackColor = False
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.Location = New System.Drawing.Point(0, 38)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnProductos.Size = New System.Drawing.Size(183, 38)
        Me.btnProductos.TabIndex = 16
        Me.btnProductos.Text = "Ventas"
        Me.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'btnListaClientes
        '
        Me.btnListaClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnListaClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnListaClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListaClientes.FlatAppearance.BorderSize = 0
        Me.btnListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListaClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListaClientes.Location = New System.Drawing.Point(0, 0)
        Me.btnListaClientes.Name = "btnListaClientes"
        Me.btnListaClientes.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnListaClientes.Size = New System.Drawing.Size(183, 38)
        Me.btnListaClientes.TabIndex = 15
        Me.btnListaClientes.Text = "Lista De Clientes"
        Me.btnListaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListaClientes.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnVentas.BackgroundImage = CType(resources.GetObject("btnVentas.BackgroundImage"), System.Drawing.Image)
        Me.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Location = New System.Drawing.Point(0, 341)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnVentas.Size = New System.Drawing.Size(183, 38)
        Me.btnVentas.TabIndex = 11
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'panelSubCompras
        '
        Me.panelSubCompras.Controls.Add(Me.btnFacturasPendientes)
        Me.panelSubCompras.Controls.Add(Me.btnOrdenCompra)
        Me.panelSubCompras.Controls.Add(Me.BtnListProveedores)
        Me.panelSubCompras.Controls.Add(Me.BtnMercancia)
        Me.panelSubCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSubCompras.Location = New System.Drawing.Point(0, 190)
        Me.panelSubCompras.Name = "panelSubCompras"
        Me.panelSubCompras.Size = New System.Drawing.Size(183, 151)
        Me.panelSubCompras.TabIndex = 10
        '
        'btnFacturasPendientes
        '
        Me.btnFacturasPendientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnFacturasPendientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFacturasPendientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFacturasPendientes.FlatAppearance.BorderSize = 0
        Me.btnFacturasPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacturasPendientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFacturasPendientes.Location = New System.Drawing.Point(0, 114)
        Me.btnFacturasPendientes.Name = "btnFacturasPendientes"
        Me.btnFacturasPendientes.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnFacturasPendientes.Size = New System.Drawing.Size(183, 37)
        Me.btnFacturasPendientes.TabIndex = 14
        Me.btnFacturasPendientes.Text = "Factura Pendientes"
        Me.btnFacturasPendientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFacturasPendientes.UseVisualStyleBackColor = False
        '
        'btnOrdenCompra
        '
        Me.btnOrdenCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnOrdenCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnOrdenCompra.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrdenCompra.FlatAppearance.BorderSize = 0
        Me.btnOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrdenCompra.Location = New System.Drawing.Point(0, 76)
        Me.btnOrdenCompra.Name = "btnOrdenCompra"
        Me.btnOrdenCompra.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnOrdenCompra.Size = New System.Drawing.Size(183, 38)
        Me.btnOrdenCompra.TabIndex = 13
        Me.btnOrdenCompra.Text = "Orden De Compra"
        Me.btnOrdenCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrdenCompra.UseVisualStyleBackColor = False
        '
        'BtnListProveedores
        '
        Me.BtnListProveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnListProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnListProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnListProveedores.FlatAppearance.BorderSize = 0
        Me.BtnListProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnListProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnListProveedores.Location = New System.Drawing.Point(0, 38)
        Me.BtnListProveedores.Name = "BtnListProveedores"
        Me.BtnListProveedores.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.BtnListProveedores.Size = New System.Drawing.Size(183, 38)
        Me.BtnListProveedores.TabIndex = 12
        Me.BtnListProveedores.Text = "Lista De Proveedores"
        Me.BtnListProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnListProveedores.UseVisualStyleBackColor = False
        '
        'BtnMercancia
        '
        Me.BtnMercancia.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnMercancia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnMercancia.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMercancia.FlatAppearance.BorderSize = 0
        Me.BtnMercancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMercancia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMercancia.Location = New System.Drawing.Point(0, 0)
        Me.BtnMercancia.Name = "BtnMercancia"
        Me.BtnMercancia.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.BtnMercancia.Size = New System.Drawing.Size(183, 38)
        Me.BtnMercancia.TabIndex = 11
        Me.BtnMercancia.Text = "Mercancia"
        Me.BtnMercancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMercancia.UseVisualStyleBackColor = False
        '
        'btnCompras
        '
        Me.btnCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnCompras.BackgroundImage = CType(resources.GetObject("btnCompras.BackgroundImage"), System.Drawing.Image)
        Me.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCompras.FlatAppearance.BorderSize = 0
        Me.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.Location = New System.Drawing.Point(0, 152)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnCompras.Size = New System.Drawing.Size(183, 38)
        Me.btnCompras.TabIndex = 10
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.UseVisualStyleBackColor = False
        '
        'panelSideLogo
        '
        Me.panelSideLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.panelSideLogo.Controls.Add(Me.PictureBox1)
        Me.panelSideLogo.Controls.Add(Me.Bienvenido)
        Me.panelSideLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSideLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelSideLogo.Name = "panelSideLogo"
        Me.panelSideLogo.Size = New System.Drawing.Size(183, 152)
        Me.panelSideLogo.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(52, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Bienvenido
        '
        Me.Bienvenido.AutoSize = True
        Me.Bienvenido.Font = New System.Drawing.Font("Montserrat", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Bienvenido.Location = New System.Drawing.Point(36, 82)
        Me.Bienvenido.Name = "Bienvenido"
        Me.Bienvenido.Size = New System.Drawing.Size(100, 21)
        Me.Bienvenido.TabIndex = 0
        Me.Bienvenido.Text = "Bienvenido"
        '
        'panelPrincipal
        '
        Me.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.panelPrincipal.Controls.Add(Me.Panel1)
        Me.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPrincipal.Location = New System.Drawing.Point(200, 0)
        Me.panelPrincipal.Name = "panelPrincipal"
        Me.panelPrincipal.Size = New System.Drawing.Size(800, 500)
        Me.panelPrincipal.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(228, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 400)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(400, 400)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 500)
        Me.Controls.Add(Me.panelPrincipal)
        Me.Controls.Add(Me.panelSideMenu)
        Me.Controls.Add(Me.Button7)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.panelSideMenu.ResumeLayout(False)
        Me.panelSubVenta.ResumeLayout(False)
        Me.panelSubCompras.ResumeLayout(False)
        Me.panelSideLogo.ResumeLayout(False)
        Me.panelSideLogo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPrincipal.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button7 As Button
    Friend WithEvents panelSideMenu As Panel
    Friend WithEvents panelSubCompras As Panel
    Friend WithEvents btnFacturasPendientes As Button
    Friend WithEvents btnOrdenCompra As Button
    Friend WithEvents BtnListProveedores As Button
    Friend WithEvents BtnMercancia As Button
    Friend WithEvents btnCompras As Button
    Friend WithEvents panelSideLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelSubVenta As Panel
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnFactura As Button
    Friend WithEvents btnListaVentas As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnListaClientes As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents panelPrincipal As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Bienvenido As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnSalir As Button
End Class
