<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaDeClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.ComboxCiudad = New System.Windows.Forms.ComboBox()
        Me.txtDniCli = New System.Windows.Forms.TextBox()
        Me.txtEmailCli = New System.Windows.Forms.TextBox()
        Me.txtTipoCliente = New System.Windows.Forms.TextBox()
        Me.txtTelefonoCli = New System.Windows.Forms.TextBox()
        Me.txtIDCli = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGenerarId = New System.Windows.Forms.Button()
        Me.txtNombreCli = New System.Windows.Forms.TextBox()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.btnLimpiarCliente = New System.Windows.Forms.Button()
        Me.dataGV_ListaClientes = New System.Windows.Forms.DataGridView()
        Me.btnRefrescarCliente = New System.Windows.Forms.Button()
        Me.btn_AgregarCliente = New System.Windows.Forms.Button()
        Me.btn_EliminarCliente = New System.Windows.Forms.Button()
        Me.btn_EditarCliente = New System.Windows.Forms.Button()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        CType(Me.dataGV_ListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Controls.Add(Me.ComboxCiudad)
        Me.PanelSuperior.Controls.Add(Me.txtDniCli)
        Me.PanelSuperior.Controls.Add(Me.txtEmailCli)
        Me.PanelSuperior.Controls.Add(Me.txtTipoCliente)
        Me.PanelSuperior.Controls.Add(Me.txtTelefonoCli)
        Me.PanelSuperior.Controls.Add(Me.txtIDCli)
        Me.PanelSuperior.Controls.Add(Me.Label7)
        Me.PanelSuperior.Controls.Add(Me.Label6)
        Me.PanelSuperior.Controls.Add(Me.Label5)
        Me.PanelSuperior.Controls.Add(Me.Label4)
        Me.PanelSuperior.Controls.Add(Me.Label3)
        Me.PanelSuperior.Controls.Add(Me.Label2)
        Me.PanelSuperior.Controls.Add(Me.Label1)
        Me.PanelSuperior.Controls.Add(Me.btnGenerarId)
        Me.PanelSuperior.Controls.Add(Me.txtNombreCli)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(800, 220)
        Me.PanelSuperior.TabIndex = 0
        '
        'ComboxCiudad
        '
        Me.ComboxCiudad.FormattingEnabled = True
        Me.ComboxCiudad.Items.AddRange(New Object() {"Rivas", "Managua", "Masaya", "Leon", "Carazo", "Chinandega", "Granada", "Esteli", "Jinotega", "Matagalpa"})
        Me.ComboxCiudad.Location = New System.Drawing.Point(204, 84)
        Me.ComboxCiudad.Name = "ComboxCiudad"
        Me.ComboxCiudad.Size = New System.Drawing.Size(185, 23)
        Me.ComboxCiudad.TabIndex = 30
        '
        'txtDniCli
        '
        Me.txtDniCli.Location = New System.Drawing.Point(576, 37)
        Me.txtDniCli.Name = "txtDniCli"
        Me.txtDniCli.Size = New System.Drawing.Size(149, 23)
        Me.txtDniCli.TabIndex = 29
        '
        'txtEmailCli
        '
        Me.txtEmailCli.Location = New System.Drawing.Point(576, 84)
        Me.txtEmailCli.Name = "txtEmailCli"
        Me.txtEmailCli.Size = New System.Drawing.Size(149, 23)
        Me.txtEmailCli.TabIndex = 28
        '
        'txtTipoCliente
        '
        Me.txtTipoCliente.Location = New System.Drawing.Point(204, 161)
        Me.txtTipoCliente.Name = "txtTipoCliente"
        Me.txtTipoCliente.Size = New System.Drawing.Size(185, 23)
        Me.txtTipoCliente.TabIndex = 27
        '
        'txtTelefonoCli
        '
        Me.txtTelefonoCli.Location = New System.Drawing.Point(204, 123)
        Me.txtTelefonoCli.Name = "txtTelefonoCli"
        Me.txtTelefonoCli.Size = New System.Drawing.Size(185, 23)
        Me.txtTelefonoCli.TabIndex = 26
        '
        'txtIDCli
        '
        Me.txtIDCli.Location = New System.Drawing.Point(576, 123)
        Me.txtIDCli.Name = "txtIDCli"
        Me.txtIDCli.Size = New System.Drawing.Size(100, 23)
        Me.txtIDCli.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(527, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 19)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(516, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 19)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "DNI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(502, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 19)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(62, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 19)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Tipo De Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(109, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(121, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Ciudad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(109, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 19)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nombres"
        '
        'btnGenerarId
        '
        Me.btnGenerarId.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGenerarId.FlatAppearance.BorderSize = 0
        Me.btnGenerarId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarId.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnGenerarId.Location = New System.Drawing.Point(576, 161)
        Me.btnGenerarId.Name = "btnGenerarId"
        Me.btnGenerarId.Size = New System.Drawing.Size(100, 23)
        Me.btnGenerarId.TabIndex = 16
        Me.btnGenerarId.Text = "Generar Id"
        Me.btnGenerarId.UseVisualStyleBackColor = False
        '
        'txtNombreCli
        '
        Me.txtNombreCli.Location = New System.Drawing.Point(204, 41)
        Me.txtNombreCli.Name = "txtNombreCli"
        Me.txtNombreCli.Size = New System.Drawing.Size(185, 23)
        Me.txtNombreCli.TabIndex = 15
        '
        'PanelInferior
        '
        Me.PanelInferior.Controls.Add(Me.btnLimpiarCliente)
        Me.PanelInferior.Controls.Add(Me.dataGV_ListaClientes)
        Me.PanelInferior.Controls.Add(Me.btnRefrescarCliente)
        Me.PanelInferior.Controls.Add(Me.btn_AgregarCliente)
        Me.PanelInferior.Controls.Add(Me.btn_EliminarCliente)
        Me.PanelInferior.Controls.Add(Me.btn_EditarCliente)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelInferior.Location = New System.Drawing.Point(0, 220)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(800, 280)
        Me.PanelInferior.TabIndex = 1
        '
        'btnLimpiarCliente
        '
        Me.btnLimpiarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpiarCliente.FlatAppearance.BorderSize = 0
        Me.btnLimpiarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarCliente.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLimpiarCliente.Location = New System.Drawing.Point(498, 0)
        Me.btnLimpiarCliente.Name = "btnLimpiarCliente"
        Me.btnLimpiarCliente.Size = New System.Drawing.Size(83, 28)
        Me.btnLimpiarCliente.TabIndex = 12
        Me.btnLimpiarCliente.Text = "Limpiar"
        Me.btnLimpiarCliente.UseVisualStyleBackColor = False
        '
        'dataGV_ListaClientes
        '
        Me.dataGV_ListaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dataGV_ListaClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dataGV_ListaClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGV_ListaClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGV_ListaClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataGV_ListaClientes.ColumnHeadersHeight = 30
        Me.dataGV_ListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGV_ListaClientes.EnableHeadersVisualStyles = False
        Me.dataGV_ListaClientes.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.dataGV_ListaClientes.Location = New System.Drawing.Point(0, 35)
        Me.dataGV_ListaClientes.MultiSelect = False
        Me.dataGV_ListaClientes.Name = "dataGV_ListaClientes"
        Me.dataGV_ListaClientes.ReadOnly = True
        Me.dataGV_ListaClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGV_ListaClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dataGV_ListaClientes.RowHeadersVisible = False
        Me.dataGV_ListaClientes.RowHeadersWidth = 50
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dataGV_ListaClientes.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dataGV_ListaClientes.RowTemplate.Height = 25
        Me.dataGV_ListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGV_ListaClientes.Size = New System.Drawing.Size(800, 245)
        Me.dataGV_ListaClientes.TabIndex = 7
        '
        'btnRefrescarCliente
        '
        Me.btnRefrescarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRefrescarCliente.FlatAppearance.BorderSize = 0
        Me.btnRefrescarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrescarCliente.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRefrescarCliente.Location = New System.Drawing.Point(383, 0)
        Me.btnRefrescarCliente.Name = "btnRefrescarCliente"
        Me.btnRefrescarCliente.Size = New System.Drawing.Size(83, 28)
        Me.btnRefrescarCliente.TabIndex = 11
        Me.btnRefrescarCliente.Text = "Refrescar"
        Me.btnRefrescarCliente.UseVisualStyleBackColor = False
        '
        'btn_AgregarCliente
        '
        Me.btn_AgregarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AgregarCliente.FlatAppearance.BorderSize = 0
        Me.btn_AgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AgregarCliente.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_AgregarCliente.Location = New System.Drawing.Point(63, 0)
        Me.btn_AgregarCliente.Name = "btn_AgregarCliente"
        Me.btn_AgregarCliente.Size = New System.Drawing.Size(83, 28)
        Me.btn_AgregarCliente.TabIndex = 8
        Me.btn_AgregarCliente.Text = "Agregar"
        Me.btn_AgregarCliente.UseVisualStyleBackColor = False
        '
        'btn_EliminarCliente
        '
        Me.btn_EliminarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_EliminarCliente.FlatAppearance.BorderSize = 0
        Me.btn_EliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_EliminarCliente.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_EliminarCliente.Location = New System.Drawing.Point(280, 0)
        Me.btn_EliminarCliente.Name = "btn_EliminarCliente"
        Me.btn_EliminarCliente.Size = New System.Drawing.Size(83, 28)
        Me.btn_EliminarCliente.TabIndex = 10
        Me.btn_EliminarCliente.Text = "Eliminar"
        Me.btn_EliminarCliente.UseVisualStyleBackColor = False
        '
        'btn_EditarCliente
        '
        Me.btn_EditarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_EditarCliente.FlatAppearance.BorderSize = 0
        Me.btn_EditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_EditarCliente.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_EditarCliente.Location = New System.Drawing.Point(172, 0)
        Me.btn_EditarCliente.Name = "btn_EditarCliente"
        Me.btn_EditarCliente.Size = New System.Drawing.Size(83, 28)
        Me.btn_EditarCliente.TabIndex = 9
        Me.btn_EditarCliente.Text = "Editar"
        Me.btn_EditarCliente.UseVisualStyleBackColor = False
        '
        'ListaDeClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListaDeClientes"
        Me.Text = "ListaDeClientes"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.dataGV_ListaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents txtDniCli As TextBox
    Friend WithEvents txtEmailCli As TextBox
    Friend WithEvents txtTipoCliente As TextBox
    Friend WithEvents txtTelefonoCli As TextBox
    Friend WithEvents txtIDCli As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGenerarId As Button
    Friend WithEvents txtNombreCli As TextBox
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ComboxCiudad As ComboBox
    Friend WithEvents btnLimpiarCliente As Button
    Friend WithEvents dataGV_ListaClientes As DataGridView
    Friend WithEvents btnRefrescarCliente As Button
    Friend WithEvents btn_AgregarCliente As Button
    Friend WithEvents btn_EliminarCliente As Button
    Friend WithEvents btn_EditarCliente As Button
End Class
