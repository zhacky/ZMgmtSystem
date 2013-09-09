Imports System.Data.SqlClient


Module CurrentConfig

    '-----------PUBLIC VARIABLES---------
    Public usernameToFind As String
    Public DisplayName As String
    Public UserLevel As Integer
    Public ConnectionString As String

    '-------ACCESS LEVELS-------------
    Public StocksAccess As Boolean
    Public ProductionAccess As Boolean
    Public POSAccess As Boolean
    Public LodgingAccess As Boolean
    Public ReportsAccess As Boolean
    Public SupervisorAccess As Boolean
    Public SettingsAccess As Boolean
    '-------FUNCTIONS---------


    Function findUserName(ByVal username As String) As Boolean
        SetConnectionString()
        Dim userpass As String
        Dim result As Boolean = False
        '--------------------------
        usernameToFind = username


        Console.WriteLine("Finding data from username: " & usernameToFind)
        Dim sqlConn As New SqlConnection(ConnectionString)
        Dim sqlFind As String = "SELECT password FROM Users WHERE username=@username"

        sqlConn.Open()

        Dim findData As New SqlCommand(sqlFind, sqlConn)
        findData.Parameters.Add("@username", SqlDbType.VarChar, 255).Value = username
        Dim reader As SqlDataReader = findData.ExecuteReader()
        If reader.HasRows Then 'then it does exist
            result = True
            While reader.Read
                userpass = reader("password").ToString
            End While
        Else

        End If


        Return result
    End Function
    Function checkUserName(ByVal username As String) As String
        Dim usernameToFind As String
        Dim userpass As String

        '--------------------------
        usernameToFind = username


        Console.WriteLine("Finding data from username: " & usernameToFind)
        Dim sqlConn As New SqlConnection(ConnectionString)
        Dim sqlFind As String = "SELECT username, password FROM Users INNER JOIN Employees" & _
" ON Users.employee_id = Employees.employee_id WHERE username =@username"

        sqlConn.Open()

        Dim findData As New SqlCommand(sqlFind, sqlConn)
        findData.Parameters.Add("@username", SqlDbType.VarChar, 255).Value = usernameToFind
        Dim reader As SqlDataReader = findData.ExecuteReader()
        If reader.HasRows Then 'then it does exist

            While reader.Read
                userpass = reader("password").ToString
                'DisplayName = reader("FirstName").ToString & " " & reader("MiddleName").ToString & " " & reader("LastName").ToString

                Console.WriteLine("Role ID: " & UserLevel.ToString)
            End While

        Else
            userpass = String.Empty
        End If

        sqlConn.Close()

        Return userpass
    End Function

    Private Sub SetConnectionString()
        ConnectionString = _
            "Data Source=" & My.Settings.DbServer & _
            ";Initial Catalog=" & My.Settings.DbDatabase & _
            ";Persist Security Info=True;User ID=" & My.Settings.DbUserName & _
            ";Password=" & My.Settings.DbPassword & ";"

    End Sub

    Function GetRoleSettings(ByVal CurrentUserName As String) As Boolean()
        Dim UserRoles As Boolean() = {}

        '--------------------------

        Console.WriteLine("Finding data from username: " & CurrentUserName)
        Dim sqlConn As New SqlConnection(ConnectionString)
        Dim sqlFind As String = "SELECT username, role_name, role_desc, access_level, role_production, role_stocks, role_pos, role_lodging, role_reports, role_supervisor, role_settings" & _
                                " FROM Users INNER JOIN Roles ON users.role_id = roles.role_id WHERE username = @username"
        Try

            sqlConn.Open()

            Dim findData As New SqlCommand(sqlFind, sqlConn)
            Console.WriteLine("Username to Find: " & usernameToFind)

            findData.Parameters.Add("@username", SqlDbType.VarChar, 255).Value = usernameToFind
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
        Catch ex As Exception
            Console.WriteLine("Exception at getting role settings: " & ex.Message)
        End Try
        Return UserRoles
    End Function

   
End Module
