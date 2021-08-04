<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.btn_Ingresar = New System.Windows.Forms.Button()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.txt_Contraseña = New System.Windows.Forms.TextBox()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Ingresar
        '
        Me.btn_Ingresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.btn_Ingresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Ingresar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Ingresar.ForeColor = System.Drawing.Color.White
        Me.btn_Ingresar.Location = New System.Drawing.Point(293, 213)
        Me.btn_Ingresar.Name = "btn_Ingresar"
        Me.btn_Ingresar.Size = New System.Drawing.Size(75, 28)
        Me.btn_Ingresar.TabIndex = 4
        Me.btn_Ingresar.Text = "Ingresar"
        Me.btn_Ingresar.UseVisualStyleBackColor = False
        '
        'txt_Usuario
        '
        Me.txt_Usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Usuario.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_Usuario.ForeColor = System.Drawing.Color.White
        Me.txt_Usuario.Location = New System.Drawing.Point(340, 90)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(134, 20)
        Me.txt_Usuario.TabIndex = 6
        '
        'txt_Contraseña
        '
        Me.txt_Contraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txt_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Contraseña.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_Contraseña.ForeColor = System.Drawing.Color.White
        Me.txt_Contraseña.Location = New System.Drawing.Point(339, 162)
        Me.txt_Contraseña.Name = "txt_Contraseña"
        Me.txt_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Contraseña.Size = New System.Drawing.Size(135, 20)
        Me.txt_Contraseña.TabIndex = 7
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Salir.ForeColor = System.Drawing.Color.White
        Me.btn_Salir.Location = New System.Drawing.Point(413, 213)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(75, 28)
        Me.btn_Salir.TabIndex = 8
        Me.btn_Salir.Text = "Registrar"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(351, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Login"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(275, 275)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(293, 83)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(293, 151)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'btn_exit
        '
        Me.btn_exit.BackgroundImage = CType(resources.GetObject("btn_exit.BackgroundImage"), System.Drawing.Image)
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Location = New System.Drawing.Point(471, 12)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(25, 25)
        Me.btn_exit.TabIndex = 14
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(508, 275)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.txt_Contraseña)
        Me.Controls.Add(Me.txt_Usuario)
        Me.Controls.Add(Me.btn_Ingresar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Ingresar As Button
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents txt_Contraseña As TextBox
    Friend WithEvents btn_Salir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_exit As Button
End Class
