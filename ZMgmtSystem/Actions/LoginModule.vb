Module LoginModule
    Private username As String
    Private password As String

    Private Property ErrorMessage As String = ""




    Function loginOk(ByVal p1 As String, ByVal p2 As String, ByVal frmLogin As frmLogin) As Boolean
        Dim result As Boolean = False
        username = p1
        password = p2
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            ErrorMessage = "The username or password cannot be empty..."
            frmLogin.lblInfo.Text = ErrorMessage
            'MessageBox.Show(ErrorMessage, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        ElseIf username.Length < 4 Or password.Length < 4 Then
            ErrorMessage = "The username or password is too short..."
            frmLogin.lblInfo.Text = ErrorMessage
            'MessageBox.Show(ErrorMessage, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf CurrentConfig.findUserName(username) Then

            If password = CurrentConfig.checkUserName(username) Then
                frmLogin.lblInfo.Text = "Login Successful"
                result = True
            Else
                frmLogin.lblInfo.Text = "Login failed... Invalid Username or Password"
            End If


        Else
            frmLogin.lblInfo.Text = "Login failed... Invalid Username or Password"

        End If
        Return result
    End Function

    

   
End Module
