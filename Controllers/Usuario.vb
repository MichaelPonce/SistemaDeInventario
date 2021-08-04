Public Class Usuario
    Public Property Username() As String
    Public Property Password() As String
    Public Property Position() As String
    Public Property Fullname() As String

    Private Shared TheError As String = "Usuario No Encontrado"

    Public Shared Sub ShowError()
        MessageBox.Show(TheError)
    End Sub

    Public Shared Function IsEqual(user1 As Usuario, user2 As Usuario)

        If (user1 Is Nothing Or user2 Is Nothing) Then
            TheError = "Usuario No Encontrado"
            Return False
        End If

        If (user1.Username <> user2.Username) Then
            TheError = "Usuario No Encontrado"
            Return False

        ElseIf (user1.Password <> user2.Password) Then
            TheError = "Usuario y contraseña invalida"
            Return False
        End If

        Return True

    End Function

End Class
