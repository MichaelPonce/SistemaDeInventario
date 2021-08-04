Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Public Class Login

    Private fcon As New FirebaseConfig() With
        {
            .AuthSecret = "YeERFJXQk9gKBrqwXsootLVjQx7SzmrLy33YZuno",
            .BasePath = "https://erp-uni-default-rtdb.firebaseio.com/"
        }
    Private cliente As IFirebaseClient
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cliente = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btn_Ingresar_Click(sender As Object, e As EventArgs) Handles btn_Ingresar.Click

        Dim res = cliente.Get("Usuario/" + txt_Usuario.Text)
        Dim resUser = res.ResultAs(Of Usuario)

        Dim CurUser As New Usuario With
            {
            .Username = txt_Usuario.Text,
            .Password = txt_Contraseña.Text
            }

        If (Usuario.IsEqual(resUser, CurUser)) Then
            Dim Inicio As New Inicio
            Inicio.Fname = resUser.Fullname
            Me.Hide()
            Inicio.ShowDialog()
            Me.Close()
            'MessageBox.Show("Inicio De Sesion Satisfactorio")

        Else
            Usuario.ShowError()
        End If

    End Sub

    Private Sub btn_Salir_Click_2(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Hide()
        Dim reg As New RegistroForm
        reg.ShowDialog()
    End Sub

    Private Sub btn_exit_Click_1(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

End Class
