<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mercancia
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreMer = New System.Windows.Forms.TextBox()
        Me.txtIdMer = New System.Windows.Forms.TextBox()
        Me.txtSubCatMer = New System.Windows.Forms.TextBox()
        Me.txtCatMer = New System.Windows.Forms.TextBox()
        Me.txtCodigoMer = New System.Windows.Forms.TextBox()
        Me.txtStockMer = New System.Windows.Forms.TextBox()
        Me.txtCompraMer = New System.Windows.Forms.TextBox()
        Me.txtPrecioMer = New System.Windows.Forms.TextBox()
        Me.btnGenerarIdMer = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAgregarMer = New System.Windows.Forms.Button()
        Me.btnEditarMer = New System.Windows.Forms.Button()
        Me.btnEliminarMer = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.dataGV_Mercancia = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dataGV_Mercancia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNombreMer)
        Me.Panel1.Controls.Add(Me.txtIdMer)
        Me.Panel1.Controls.Add(Me.txtSubCatMer)
        Me.Panel1.Controls.Add(Me.txtCatMer)
        Me.Panel1.Controls.Add(Me.txtCodigoMer)
        Me.Panel1.Controls.Add(Me.txtStockMer)
        Me.Panel1.Controls.Add(Me.txtCompraMer)
        Me.Panel1.Controls.Add(Me.txtPrecioMer)
        Me.Panel1.Controls.Add(Me.btnGenerarIdMer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 211)
        Me.Panel1.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(460, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 15)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Subcategoria"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(476, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 15)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Categoria"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(460, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Codigo Barra"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(505, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(114, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Stock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Precio Compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Precio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nombre"
        '
        'txtNombreMer
        '
        Me.txtNombreMer.Location = New System.Drawing.Point(173, 51)
        Me.txtNombreMer.Name = "txtNombreMer"
        Me.txtNombreMer.Size = New System.Drawing.Size(152, 23)
        Me.txtNombreMer.TabIndex = 12
        '
        'txtIdMer
        '
        Me.txtIdMer.Location = New System.Drawing.Point(542, 51)
        Me.txtIdMer.Name = "txtIdMer"
        Me.txtIdMer.Size = New System.Drawing.Size(100, 23)
        Me.txtIdMer.TabIndex = 11
        '
        'txtSubCatMer
        '
        Me.txtSubCatMer.Location = New System.Drawing.Point(542, 169)
        Me.txtSubCatMer.Name = "txtSubCatMer"
        Me.txtSubCatMer.Size = New System.Drawing.Size(120, 23)
        Me.txtSubCatMer.TabIndex = 10
        '
        'txtCatMer
        '
        Me.txtCatMer.Location = New System.Drawing.Point(542, 128)
        Me.txtCatMer.Name = "txtCatMer"
        Me.txtCatMer.Size = New System.Drawing.Size(120, 23)
        Me.txtCatMer.TabIndex = 8
        '
        'txtCodigoMer
        '
        Me.txtCodigoMer.Location = New System.Drawing.Point(542, 89)
        Me.txtCodigoMer.Name = "txtCodigoMer"
        Me.txtCodigoMer.Size = New System.Drawing.Size(100, 23)
        Me.txtCodigoMer.TabIndex = 7
        '
        'txtStockMer
        '
        Me.txtStockMer.Location = New System.Drawing.Point(173, 169)
        Me.txtStockMer.Name = "txtStockMer"
        Me.txtStockMer.Size = New System.Drawing.Size(119, 23)
        Me.txtStockMer.TabIndex = 5
        '
        'txtCompraMer
        '
        Me.txtCompraMer.Location = New System.Drawing.Point(173, 128)
        Me.txtCompraMer.Name = "txtCompraMer"
        Me.txtCompraMer.Size = New System.Drawing.Size(119, 23)
        Me.txtCompraMer.TabIndex = 4
        '
        'txtPrecioMer
        '
        Me.txtPrecioMer.Location = New System.Drawing.Point(173, 89)
        Me.txtPrecioMer.Name = "txtPrecioMer"
        Me.txtPrecioMer.Size = New System.Drawing.Size(119, 23)
        Me.txtPrecioMer.TabIndex = 3
        '
        'btnGenerarIdMer
        '
        Me.btnGenerarIdMer.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGenerarIdMer.FlatAppearance.BorderSize = 0
        Me.btnGenerarIdMer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarIdMer.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnGenerarIdMer.Location = New System.Drawing.Point(648, 49)
        Me.btnGenerarIdMer.Name = "btnGenerarIdMer"
        Me.btnGenerarIdMer.Size = New System.Drawing.Size(100, 23)
        Me.btnGenerarIdMer.TabIndex = 2
        Me.btnGenerarIdMer.Text = "Generar Id"
        Me.btnGenerarIdMer.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnAgregarMer)
        Me.Panel2.Controls.Add(Me.btnEditarMer)
        Me.Panel2.Controls.Add(Me.btnEliminarMer)
        Me.Panel2.Controls.Add(Me.BtnLimpiar)
        Me.Panel2.Controls.Add(Me.dataGV_Mercancia)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 211)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 289)
        Me.Panel2.TabIndex = 5
        '
        'btnAgregarMer
        '
        Me.btnAgregarMer.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgregarMer.FlatAppearance.BorderSize = 0
        Me.btnAgregarMer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarMer.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAgregarMer.Location = New System.Drawing.Point(111, -1)
        Me.btnAgregarMer.Name = "btnAgregarMer"
        Me.btnAgregarMer.Size = New System.Drawing.Size(100, 28)
        Me.btnAgregarMer.TabIndex = 6
        Me.btnAgregarMer.Text = "Agregar"
        Me.btnAgregarMer.UseVisualStyleBackColor = False
        '
        'btnEditarMer
        '
        Me.btnEditarMer.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEditarMer.FlatAppearance.BorderSize = 0
        Me.btnEditarMer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarMer.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEditarMer.Location = New System.Drawing.Point(248, -1)
        Me.btnEditarMer.Name = "btnEditarMer"
        Me.btnEditarMer.Size = New System.Drawing.Size(100, 28)
        Me.btnEditarMer.TabIndex = 3
        Me.btnEditarMer.Text = "Editar"
        Me.btnEditarMer.UseVisualStyleBackColor = False
        '
        'btnEliminarMer
        '
        Me.btnEliminarMer.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEliminarMer.FlatAppearance.BorderSize = 0
        Me.btnEliminarMer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarMer.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEliminarMer.Location = New System.Drawing.Point(371, -1)
        Me.btnEliminarMer.Name = "btnEliminarMer"
        Me.btnEliminarMer.Size = New System.Drawing.Size(100, 28)
        Me.btnEliminarMer.TabIndex = 4
        Me.btnEliminarMer.Text = "Eliminar"
        Me.btnEliminarMer.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLimpiar.FlatAppearance.BorderSize = 0
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnLimpiar.Location = New System.Drawing.Point(518, 0)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(100, 27)
        Me.BtnLimpiar.TabIndex = 5
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'dataGV_Mercancia
        '
        Me.dataGV_Mercancia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dataGV_Mercancia.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dataGV_Mercancia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGV_Mercancia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGV_Mercancia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGV_Mercancia.ColumnHeadersHeight = 30
        Me.dataGV_Mercancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGV_Mercancia.EnableHeadersVisualStyles = False
        Me.dataGV_Mercancia.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.dataGV_Mercancia.Location = New System.Drawing.Point(0, 39)
        Me.dataGV_Mercancia.MultiSelect = False
        Me.dataGV_Mercancia.Name = "dataGV_Mercancia"
        Me.dataGV_Mercancia.ReadOnly = True
        Me.dataGV_Mercancia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGV_Mercancia.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataGV_Mercancia.RowHeadersVisible = False
        Me.dataGV_Mercancia.RowHeadersWidth = 50
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dataGV_Mercancia.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dataGV_Mercancia.RowTemplate.Height = 25
        Me.dataGV_Mercancia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGV_Mercancia.Size = New System.Drawing.Size(800, 250)
        Me.dataGV_Mercancia.TabIndex = 1
        '
        'Mercancia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Mercancia"
        Me.Text = "Mercancia"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dataGV_Mercancia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dataGV_Mercancia As DataGridView
    Friend WithEvents btnGenerarIdMer As Button
    Friend WithEvents btnAgregarMer As Button
    Friend WithEvents btnEditarMer As Button
    Friend WithEvents btnEliminarMer As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents txtNombreMer As TextBox
    Friend WithEvents txtIdMer As TextBox
    Friend WithEvents txtSubCatMer As TextBox
    Friend WithEvents txtCatMer As TextBox
    Friend WithEvents txtCodigoMer As TextBox
    Friend WithEvents txtStockMer As TextBox
    Friend WithEvents txtCompraMer As TextBox
    Friend WithEvents txtPrecioMer As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
