Public Class SupervisorForm


    Private Sub ListRoles()
        ListBoxRoles.Items.AddRange(DatabaseModule.GetRolesList().ToArray)
    End Sub

    Private Sub SupervisorForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListRoles()

    End Sub

    
    
    Private Sub ListBoxRoles_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxRoles.MouseClick

        Dim rolename As String = ListBoxRoles.SelectedItem.ToString
        Dim roledesc As String = DatabaseModule.GetRoleItemByName(rolename, 
        Dim role_production As Integer
        Dim role_stocks As Integer
        Dim role_pos As Integer
        Dim role_lodging As Integer
        Dim role_reports As Integer
        Dim role_supervisor As Integer
        Dim role_settings As Integer
    End Sub

    

End Class
