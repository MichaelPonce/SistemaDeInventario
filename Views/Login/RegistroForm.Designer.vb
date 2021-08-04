<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistroForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Nombre_Reg = New System.Windows.Forms.TextBox()
        Me.txt_Usuario_Reg = New System.Windows.Forms.TextBox()
        Me.txt_Contraseña_Reg = New System.Windows.Forms.TextBox()
        Me.btn_Registro_Usuario = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.comBox_Cargo = New System.Windows.Forms.ComboBox()
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Completo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cargo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(366, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(346, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contraseña"
        '
        'txt_Nombre_Reg
        '
        Me.txt_Nombre_Reg.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_Nombre_Reg.Location = New System.Drawing.Point(148, 59)
        Me.txt_Nombre_Reg.Name = "txt_Nombre_Reg"
        Me.txt_Nombre_Reg.Size = New System.Drawing.Size(175, 27)
        Me.txt_Nombre_Reg.TabIndex = 4
        '
        'txt_Usuario_Reg
        '
        Me.txt_Usuario_Reg.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_Usuario_Reg.Location = New System.Drawing.Point(429, 59)
        Me.txt_Usuario_Reg.Name = "txt_Usuario_Reg"
        Me.txt_Usuario_Reg.Size = New System.Drawing.Size(159, 27)
        Me.txt_Usuario_Reg.TabIndex = 6
        '
        'txt_Contraseña_Reg
        '
        Me.txt_Contraseña_Reg.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_Contraseña_Reg.Location = New System.Drawing.Point(429, 109)
        Me.txt_Contraseña_Reg.Name = "txt_Contraseña_Reg"
        Me.txt_Contraseña_Reg.Size = New System.Drawing.Size(159, 27)
        Me.txt_Contraseña_Reg.TabIndex = 7
        '
        'btn_Registro_Usuario
        '
        Me.btn_Registro_Usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.btn_Registro_Usuario.FlatAppearance.BorderSize = 0
        Me.btn_Registro_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Registro_Usuario.ForeColor = System.Drawing.Color.White
        Me.btn_Registro_Usuario.Location = New System.Drawing.Point(379, 192)
        Me.btn_Registro_Usuario.Name = "btn_Registro_Usuario"
        Me.btn_Registro_Usuario.Size = New System.Drawing.Size(75, 28)
        Me.btn_Registro_Usuario.TabIndex = 8
        Me.btn_Registro_Usuario.Text = "Registrar"
        Me.btn_Registro_Usuario.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(303, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Registro"
        '
        'comBox_Cargo
        '
        Me.comBox_Cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comBox_Cargo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.comBox_Cargo.FormattingEnabled = True
        Me.comBox_Cargo.Items.AddRange(New Object() {"Ing. En Sistemas", "Contadora", "Recursos Humanos", "Marketing"})
        Me.comBox_Cargo.Location = New System.Drawing.Point(148, 105)
        Me.comBox_Cargo.Name = "comBox_Cargo"
        Me.comBox_Cargo.Size = New System.Drawing.Size(175, 28)
        Me.comBox_Cargo.TabIndex = 10
        '
        'btn_Volver
        '
        Me.btn_Volver.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.btn_Volver.FlatAppearance.BorderSize = 0
        Me.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Volver.ForeColor = System.Drawing.Color.White
        Me.btn_Volver.Location = New System.Drawing.Point(242, 192)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(75, 28)
        Me.btn_Volver.TabIndex = 11
        Me.btn_Volver.Text = "Volver"
        Me.btn_Volver.UseVisualStyleBackColor = False
        '
        'RegistroForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(690, 255)
        Me.Controls.Add(Me.btn_Volver)
        Me.Controls.Add(Me.comBox_Cargo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_Registro_Usuario)
        Me.Controls.Add(Me.txt_Contraseña_Reg)
        Me.Controls.Add(Me.txt_Usuario_Reg)
        Me.Controls.Add(Me.txt_Nombre_Reg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistroForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistroForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Nombre_Reg As TextBox
    Friend WithEvents txt_Usuario_Reg As TextBox
    Friend WithEvents txt_Contraseña_Reg As TextBox
    Friend WithEvents btn_Registro_Usuario As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents comBox_Cargo As ComboBox
    Friend WithEvents btn_Volver As Button
End Class
