Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Public Class RegistroForm

    Private fcon As New FirebaseConfig() With
        {
            .AuthSecret = "YeERFJXQk9gKBrqwXsootLVjQx7SzmrLy33YZuno",
            .BasePath = "https://erp-uni-default-rtdb.firebaseio.com/"
        }
    Private client As IFirebaseClient
    Private Sub btn_Registro_Usuario_Click(sender As Object, e As EventArgs) Handles btn_Registro_Usuario.Click
#Region "Condition"
        If (String.IsNullOrWhiteSpace(txt_Nombre_Reg.Text) AndAlso
            String.IsNullOrWhiteSpace(txt_Contraseña_Reg.Text) AndAlso
            String.IsNullOrWhiteSpace(comBox_Cargo.Text) AndAlso
            String.IsNullOrWhiteSpace(txt_Usuario_Reg.Text)
            ) Then
            MessageBox.Show("Por favor rellene todos los campos")
            Return
        End If
#End Region



        Dim NewUser As New Usuario() With
            {
            .Username = txt_Usuario_Reg.Text,
            .Password = txt_Contraseña_Reg.Text,
            .Position = comBox_Cargo.Text,
            .Fullname = txt_Nombre_Reg.Text
            }

        Dim Muestra = client.Set("Usuario/" + txt_Usuario_Reg.Text, NewUser)
        MessageBox.Show("Registrado Con Exito")

        Me.Hide()
        Dim Log As New Login
        Log.ShowDialog()
    End Sub

    Private Sub RegistroForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btn_Volver_Click(sender As Object, e As EventArgs) Handles btn_Volver.Click
        Me.Hide()
        Dim Log As New Login
        Log.ShowDialog()
    End Sub
End Class