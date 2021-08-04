<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.dataGV_Mercancia = New System.Windows.Forms.DataGridView()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.datagventas = New System.Windows.Forms.DataGridView()
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.PanelInferior.SuspendLayout()
        CType(Me.dataGV_Mercancia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSuperior.SuspendLayout()
        CType(Me.datagventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCentral.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelInferior
        '
        Me.PanelInferior.Controls.Add(Me.dataGV_Mercancia)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 280)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(800, 220)
        Me.PanelInferior.TabIndex = 1
        '
        'dataGV_Mercancia
        '
        Me.dataGV_Mercancia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dataGV_Mercancia.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dataGV_Mercancia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGV_Mercancia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGV_Mercancia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataGV_Mercancia.ColumnHeadersHeight = 30
        Me.dataGV_Mercancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGV_Mercancia.EnableHeadersVisualStyles = False
        Me.dataGV_Mercancia.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.dataGV_Mercancia.Location = New System.Drawing.Point(0, 0)
        Me.dataGV_Mercancia.MultiSelect = False
        Me.dataGV_Mercancia.Name = "dataGV_Mercancia"
        Me.dataGV_Mercancia.ReadOnly = True
        Me.dataGV_Mercancia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(81, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGV_Mercancia.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dataGV_Mercancia.RowHeadersVisible = False
        Me.dataGV_Mercancia.RowHeadersWidth = 50
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dataGV_Mercancia.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dataGV_Mercancia.RowTemplate.Height = 25
        Me.dataGV_Mercancia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGV_Mercancia.Size = New System.Drawing.Size(800, 220)
        Me.dataGV_Mercancia.TabIndex = 2
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Controls.Add(Me.datagventas)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(800, 186)
        Me.PanelSuperior.TabIndex = 2
        '
        'datagventas
        '
        Me.datagventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagventas.Dock = System.Windows.Forms.DockStyle.Top
        Me.datagventas.Location = New System.Drawing.Point(0, 0)
        Me.datagventas.Name = "datagventas"
        Me.datagventas.RowTemplate.Height = 25
        Me.datagventas.Size = New System.Drawing.Size(800, 186)
        Me.datagventas.TabIndex = 0
        '
        'PanelCentral
        '
        Me.PanelCentral.Controls.Add(Me.btnFacturar)
        Me.PanelCentral.Controls.Add(Me.btnRefrescar)
        Me.PanelCentral.Controls.Add(Me.btnEliminarProducto)
        Me.PanelCentral.Controls.Add(Me.btnAgregarProducto)
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.Location = New System.Drawing.Point(0, 186)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Size = New System.Drawing.Size(800, 94)
        Me.PanelCentral.TabIndex = 3
        '
        'btnFacturar
        '
        Me.btnFacturar.Location = New System.Drawing.Point(345, 41)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(75, 23)
        Me.btnFacturar.TabIndex = 3
        Me.btnFacturar.Text = "Facturar"
        Me.btnFacturar.UseVisualStyleBackColor = True
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Location = New System.Drawing.Point(248, 41)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(75, 23)
        Me.btnRefrescar.TabIndex = 2
        Me.btnRefrescar.Text = "Refrescar"
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Location = New System.Drawing.Point(150, 41)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarProducto.TabIndex = 1
        Me.btnEliminarProducto.Text = "Eliminar"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(48, 41)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarProducto.TabIndex = 0
        Me.btnAgregarProducto.Text = "Agregar"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.PanelCentral)
        Me.Controls.Add(Me.PanelSuperior)
        Me.Controls.Add(Me.PanelInferior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventas"
        Me.Text = "Productos"
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.dataGV_Mercancia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSuperior.ResumeLayout(False)
        CType(Me.datagventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCentral.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelInferior As Panel
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PanelCentral As Panel
    Friend WithEvents dataGV_Mercancia As DataGridView
    Friend WithEvents datagventas As DataGridView
    Friend WithEvents btnFacturar As Button
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents btnAgregarProducto As Button
End Class
