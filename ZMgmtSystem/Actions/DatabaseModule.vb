Imports System.Data.SqlClient

Module DatabaseModule

    Function GetRolesList() As List(Of String)
        Dim roles As New List(Of String)
        Dim ConnString As String = CurrentConfig.ConnectionString
        Dim conn As New SqlConnection(ConnString)
        Dim SqlQuery As String = "SELECT * FROM roles"
        Dim SqlCmd As New SqlCommand(SqlQuery, conn)
        Dim data As SqlDataReader

        Try
            '--------open connection
            conn.Open()
            data = SqlCmd.ExecuteReader()
            If data.HasRows Then
                While data.Read
                    roles.Add(data("role_name"))
                End While
            End If
            '--------close connection
            conn.Close()

        Catch ex As Exception
            Console.WriteLine("Error getting Roles List: " & ex.Message)
            MessageBox.Show("Error getting Roles List: " & ex.Message)
        End Try

        Return roles
    End Function

    Function GetRoleDescByName(ByVal rolename As String, ByVal ROLE_DESC As Integer) As String
        Dim role_description As Integer = ROLE_DESC
        Dim roledesc As String
        Return roledesc
    End Function
    Function GetRoleItemByName(ByVal rolename As String, ByVal ACCESS As Integer) As Integer
        Dim ROLE As Integer = ACCESS
        Dim result As Integer
        Return result
    End Function

End Module
