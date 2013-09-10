Imports System.Data.SqlClient

Module DatabaseModule
    Private ConnString As String = CurrentConfig.ConnectionString

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
        Dim roledesc As String = ""
        Return roledesc
    End Function
    Function GetRoleItemByName(ByVal rolename As String, ByVal ACCESS As Integer) As Integer
        Dim ROLE As Integer = ACCESS
        Dim result As Integer
        Return result
    End Function

    Function GetAccess(ByVal rolename As String) As List(Of Boolean)
        Dim UserRoles As Boolean() = {}

        '--------------------------

        'Console.WriteLine("Finding data from username: " & CurrentConfig.Roles)
        Dim sqlConn As New SqlConnection(ConnectionString)
        'Dim sqlFind As String = "SELECT username, role_name, role_desc, access_level, role_production, role_stocks, role_pos, role_lodging, role_reports, role_supervisor, role_settings" & _
        '                        " FROM Users INNER JOIN Roles ON users.role_id = roles.role_id WHERE username = @username"
        Dim sqlFind As String = "SELECT * FROM Roles WHERE role_name = @role_name"
        Try

            sqlConn.Open()

            Dim findData As New SqlCommand(sqlFind, sqlConn)
            Console.WriteLine("Rolename to Find: " & rolename)

            findData.Parameters.Add("@role_name", SqlDbType.VarChar, 255).Value = rolename
            Dim reader As SqlDataReader = findData.ExecuteReader()
            If reader.HasRows Then 'then it does exist
                Console.WriteLine("Reader has rows")
                While reader.Read

                    StocksAccess = reader("role_stocks")
                    Console.WriteLine(StocksAccess.ToString)
                    ProductionAccess = reader("role_production")
                    POSAccess = reader("role_pos")
                    LodgingAccess = reader("role_lodging")
                    ReportsAccess = reader("role_reports")
                    SupervisorAccess = reader("role_supervisor")
                    SettingsAccess = reader("role_settings")
                    Console.WriteLine("Settings Access: " & SettingsAccess.ToString)
                    'UserRoles = {StocksAccess, ProductionAccess, POSAccess, ReportsAccess, SupervisorAccess, SettingsAccess, 0}
                    Array.Resize(UserRoles, 7)
                    UserRoles.SetValue(StocksAccess, 0)
                    UserRoles.SetValue(ProductionAccess, 1)
                    UserRoles.SetValue(POSAccess, 2)
                    UserRoles.SetValue(LodgingAccess, 3)
                    UserRoles.SetValue(ReportsAccess, 4)
                    UserRoles.SetValue(SupervisorAccess, 5)
                    UserRoles.SetValue(SettingsAccess, 6)

                    Console.WriteLine("Role Settings: " & UserRoles.ToString)
                End While



            End If

            sqlConn.Close()
            sqlConn.Dispose()
        Catch ex As Exception
            Console.WriteLine("Exception at getting role settings: " & ex.Message)
        End Try
        Return UserRoles.ToList
    End Function

    Sub SaveRoleSettings(ByVal supervisorForm As SupervisorForm)
        Dim CheckedBoxes As Boolean() = {}
        Array.Resize(CheckedBoxes, supervisorForm.gbPrivileges.Controls.Count + 2)
        CheckedBoxes.SetValue(supervisorForm.chkStocks.Checked, 0)
        CheckedBoxes.SetValue(supervisorForm.chkProduction.Checked, 1)
        CheckedBoxes.SetValue(supervisorForm.chkPOS.Checked, 2)
        CheckedBoxes.SetValue(supervisorForm.chkLodging.Checked, 3)
        CheckedBoxes.SetValue(supervisorForm.chkReports.Checked, 4)
        CheckedBoxes.SetValue(supervisorForm.chkAdmin.Checked, 5)
        CheckedBoxes.SetValue(supervisorForm.chkSettings.Checked, 6)
        SaveRolesAccess(supervisorForm.txtRoleName.Text, supervisorForm.txtRoleDesc.Text, CheckedBoxes)
    End Sub

    Private Sub SaveRolesAccess(ByVal p1 As String, ByVal p2 As String, ByVal CheckedBoxes As Boolean())
        Dim rolename As String = p1
        Dim roledesc As String = p2

        Dim sqlConn As New SqlConnection(ConnString)
        Dim sqlQuery As String = "INSERT INTO Roles(role_name, role_desc,  role_stocks, role_production, role_pos, role_lodging, role_reports, role_supervisor, role_settings)" _
                                 & " VALUES(@rolename,@roledesc, @role_stocks, @role_production, @role_pos, @role_lodging, @role_reports, @role_supervisor, @role_settings)"
        Dim sqlCmd As New SqlCommand(sqlQuery, sqlConn)
        sqlCmd.Parameters.Add("@rolename", SqlDbType.NVarChar, 50).Value = rolename
        sqlCmd.Parameters.Add("@roledesc", SqlDbType.NVarChar, 50).Value = roledesc
        sqlCmd.Parameters.Add("@role_stocks", SqlDbType.Bit, 50).Value = CheckedBoxes(0)
        sqlCmd.Parameters.Add("@role_production", SqlDbType.Bit, 50).Value = CheckedBoxes(1)
        sqlCmd.Parameters.Add("@role_pos", SqlDbType.Bit, 50).Value = CheckedBoxes(2)
        sqlCmd.Parameters.Add("@role_lodging", SqlDbType.Bit, 50).Value = CheckedBoxes(3)
        sqlCmd.Parameters.Add("@role_reports", SqlDbType.Bit, 50).Value = CheckedBoxes(4)
        sqlCmd.Parameters.Add("@role_supervisor", SqlDbType.Bit, 50).Value = CheckedBoxes(5)
        sqlCmd.Parameters.Add("@role_settings", SqlDbType.Bit, 50).Value = CheckedBoxes(6)

        Try
            sqlConn.Open()
            sqlCmd.ExecuteNonQuery()

            Console.WriteLine("Saved to Database...")
        Catch ex As Exception
            Console.WriteLine("ex." & ex.Message)
        Finally
            sqlConn.Close()
            sqlConn.Dispose()
        End Try
    End Sub




End Module
