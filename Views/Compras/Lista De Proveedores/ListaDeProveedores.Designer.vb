<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaDeProveedores
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.btn_Editar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.dataGV_Proveedores = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNumeroRucProv = New System.Windows.Forms.TextBox()
        Me.txtEmailProv = New System.Windows.Forms.TextBox()
        Me.txtTelefonoProv = New System.Windows.Forms.TextBox()
        Me.txtEmpresaProv = New System.Windows.Forms.TextBox()
        Me.txtCiudadProv = New System.Windows.Forms.TextBox()
        Me.txtGenerarId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Generar_Id = New System.Windows.Forms.Button()
        Me.txtNombreProv = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dataGV_Proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Agregar
        '
        Me.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Agregar.FlatAppearance.BorderSize = 0
        Me.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Agregar.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Agregar.Location = New System.Drawing.Point(63, 20)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(83, 27)
        Me.btn_Agregar.TabIndex = 2
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = False
        '
        'btn_Editar
        '
        Me.btn_Editar.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Editar.FlatAppearance.BorderSize = 0
        Me.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Editar.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Editar.Location = New System.Drawing.Point(172, 20)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(83, 27)
        Me.btn_Editar.TabIndex = 3
        Me.btn_Editar.Text = "Editar"
        Me.btn_Editar.UseVisualStyleBackColor = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Eliminar.FlatAppearance.BorderSize = 0
        Me.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Eliminar.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Eliminar.Location = New System.Drawing.Point(280, 20)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(83, 27)
        Me.btn_Eliminar.TabIndex = 4
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btnRefrescar
        '
        Me.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRefrescar.FlatAppearance.BorderSize = 0
        Me.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrescar.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRefrescar.Location = New System.Drawing.Point(383, 20)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(83, 27)
        Me.btnRefrescar.TabIndex = 5
        Me.btnRefrescar.Text = "Refrescar"
        Me.btnRefrescar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.dataGV_Proveedores)
        Me.Panel1.Controls.Add(Me.btnRefrescar)
        Me.Panel1.Controls.Add(Me.btn_Agregar)
        Me.Panel1.Controls.Add(Me.btn_Eliminar)
        Me.Panel1.Controls.Add(Me.btn_Editar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 283)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 317)
        Me.Panel1.TabIndex = 6
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLimpiar.Location = New System.Drawing.Point(498, 20)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(83, 27)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'dataGV_Proveedores
        '
        Me.dataGV_Proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dataGV_Proveedores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dataGV_Proveedores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGV_Proveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGV_Proveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGV_Proveedores.ColumnHeadersHeight = 30
        Me.dataGV_Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGV_Proveedores.EnableHeadersVisualStyles = False
        Me.dataGV_Proveedores.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.dataGV_Proveedores.Location = New System.Drawing.Point(0, 67)
        Me.dataGV_Proveedores.MultiSelect = False
        Me.dataGV_Proveedores.Name = "dataGV_Proveedores"
        Me.dataGV_Proveedores.ReadOnly = True
        Me.dataGV_Proveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGV_Proveedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataGV_Proveedores.RowHeadersVisible = False
        Me.dataGV_Proveedores.RowHeadersWidth = 50
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dataGV_Proveedores.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dataGV_Proveedores.RowTemplate.Height = 25
        Me.dataGV_Proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGV_Proveedores.Size = New System.Drawing.Size(800, 306)
        Me.dataGV_Proveedores.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtNumeroRucProv)
        Me.Panel2.Controls.Add(Me.txtEmailProv)
        Me.Panel2.Controls.Add(Me.txtTelefonoProv)
        Me.Panel2.Controls.Add(Me.txtEmpresaProv)
        Me.Panel2.Controls.Add(Me.txtCiudadProv)
        Me.Panel2.Controls.Add(Me.txtGenerarId)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Generar_Id)
        Me.Panel2.Controls.Add(Me.txtNombreProv)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 283)
        Me.Panel2.TabIndex = 7
        '
        'txtNumeroRucProv
        '
        Me.txtNumeroRucProv.Location = New System.Drawing.Point(531, 50)
        Me.txtNumeroRucProv.Name = "txtNumeroRucProv"
        Me.txtNumeroRucProv.Size = New System.Drawing.Size(100, 23)
        Me.txtNumeroRucProv.TabIndex = 14
        '
        'txtEmailProv
        '
        Me.txtEmailProv.Location = New System.Drawing.Point(531, 97)
        Me.txtEmailProv.Name = "txtEmailProv"
        Me.txtEmailProv.Size = New System.Drawing.Size(100, 23)
        Me.txtEmailProv.TabIndex = 13
        '
        'txtTelefonoProv
        '
        Me.txtTelefonoProv.Location = New System.Drawing.Point(159, 174)
        Me.txtTelefonoProv.Name = "txtTelefonoProv"
        Me.txtTelefonoProv.Size = New System.Drawing.Size(185, 23)
        Me.txtTelefonoProv.TabIndex = 12
        '
        'txtEmpresaProv
        '
        Me.txtEmpresaProv.Location = New System.Drawing.Point(159, 136)
        Me.txtEmpresaProv.Name = "txtEmpresaProv"
        Me.txtEmpresaProv.Size = New System.Drawing.Size(185, 23)
        Me.txtEmpresaProv.TabIndex = 11
        '
        'txtCiudadProv
        '
        Me.txtCiudadProv.Location = New System.Drawing.Point(159, 93)
        Me.txtCiudadProv.Name = "txtCiudadProv"
        Me.txtCiudadProv.Size = New System.Drawing.Size(185, 23)
        Me.txtCiudadProv.TabIndex = 10
        '
        'txtGenerarId
        '
        Me.txtGenerarId.Location = New System.Drawing.Point(531, 136)
        Me.txtGenerarId.Name = "txtGenerarId"
        Me.txtGenerarId.Size = New System.Drawing.Size(100, 23)
        Me.txtGenerarId.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(482, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(409, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Numero Ruc"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(457, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(64, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(64, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Empresa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(76, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ciudad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(64, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombres"
        '
        'Generar_Id
        '
        Me.Generar_Id.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Generar_Id.FlatAppearance.BorderSize = 0
        Me.Generar_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Generar_Id.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Generar_Id.Location = New System.Drawing.Point(531, 174)
        Me.Generar_Id.Name = "Generar_Id"
        Me.Generar_Id.Size = New System.Drawing.Size(100, 23)
        Me.Generar_Id.TabIndex = 1
        Me.Generar_Id.Text = "Generar Id"
        Me.Generar_Id.UseVisualStyleBackColor = False
        '
        'txtNombreProv
        '
        Me.txtNombreProv.Location = New System.Drawing.Point(159, 54)
        Me.txtNombreProv.Name = "txtNombreProv"
        Me.txtNombreProv.Size = New System.Drawing.Size(185, 23)
        Me.txtNombreProv.TabIndex = 0
        '
        'ListaDeProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListaDeProveedores"
        Me.Text = "ListaDeProveedores"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dataGV_Proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents btn_Editar As Button
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dataGV_Proveedores As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Generar_Id As Button
    Friend WithEvents txtNombreProv As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtGenerarId As TextBox
    Friend WithEvents txtNumeroRucProv As TextBox
    Friend WithEvents txtEmailProv As TextBox
    Friend WithEvents txtTelefonoProv As TextBox
    Friend WithEvents txtEmpresaProv As TextBox
    Friend WithEvents txtCiudadProv As TextBox
    Friend WithEvents btnLimpiar As Button
End Class
