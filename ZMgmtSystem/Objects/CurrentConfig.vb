Imports System.Data.SqlClient
Imports ZMgmtSystem.UserDataSetTableAdapters

Module CurrentConfig

    '-----------PUBLIC VARIABLES---------
    Public usernameToFind As String
    Public DisplayName As String
    Public UserLevel As Integer


    '-------FUNCTIONS---------
    Function findUserName(ByVal username As String) As Boolean

        Dim userpass As String
        Dim result As Boolean = False
        '--------------------------
        usernameToFind = username


        Console.WriteLine("Finding data from username: " & usernameToFind)
        Dim sqlConn As New SqlConnection(My.Settings.TestPOSConnectionString & ";Password=" & My.Settings.DbPassword)
        Dim sqlFind As String = "SELECT password FROM users WHERE username =@username"

        sqlConn.Open()

        Dim findData As New SqlCommand(sqlFind, sqlConn)
        findData.Parameters.Add("@username", SqlDbType.VarChar, 255).Value = usernameToFind
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
        Dim sqlConn As New SqlConnection(My.Settings.TestPOSConnectionString & ";Password=" & My.Settings.DbPassword)
        Dim sqlFind As String = "SELECT * FROM users WHERE username =@username"

        sqlConn.Open()

        Dim findData As New SqlCommand(sqlFind, sqlConn)
        findData.Parameters.Add("@username", SqlDbType.VarChar, 255).Value = usernameToFind
        Dim reader As SqlDataReader = findData.ExecuteReader()
        If reader.HasRows Then 'then it does exist

            While reader.Read
                userpass = reader("password").ToString
                DisplayName = reader("fname").ToString & " " & reader("mname").ToString & " " & reader("lname").ToString
                UserLevel = reader("roleid")
                Console.WriteLine("Role ID: " & UserLevel.ToString)
            End While

        Else
            userpass = String.Empty
        End If


        Return userpass
    End Function
End Module
