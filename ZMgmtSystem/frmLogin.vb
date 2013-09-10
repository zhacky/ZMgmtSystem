Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class frmLogin
    Dim DbServer As String
    Dim DbUsername As String
    Dim DbPassword As String
    Dim DbName As String
    Dim connected As Boolean = False

    

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        lblInfo.Text = String.Empty
        Console.WriteLine("...OK button clicked")
        If connected Then
            ' If LoginModule.loginOk(UsernameTextBox.Text, PasswordTextBox.Text, Me) Then
            If LoginModule.loginOk("Zhack", "backfire", Me) Then
                SelectionForm.Show()
                Me.Close()
            End If
        Else
            lblInfo.Text = "...not connected to any database"
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetBounds(407, 220, 407, 220)
        Me.CenterToScreen()
        InitializeSettings()

        If DbServer = String.Empty Then
            lblInfo.Text = "Configuration Error: Server Not Found"
        Else
            TestConnection()
        End If

    End Sub
    Private Sub InitializeSettings()
        'clear boxes

        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        lblInfo.Text = ""

        'set db info
        
        DbServer = My.Settings.DbServer
        DbUsername = My.Settings.DbUserName
        DbPassword = My.Settings.DbPassword
        DbName = My.Settings.DbDatabase
        cboServer.Text = DbServer
        cboDatabase.Text = DbName
        txtUsername.Text = DbUsername
        If My.Settings.RememberPassword Then
            txtPassword.Text = DbPassword
            chkRemPass.Checked = True
        Else
            txtPassword.Clear()
            chkRemPass.Checked = False
        End If


    End Sub
    

    
   
    Private Sub chkDbConfig_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDbConfig.CheckedChanged
        lblInfo.Text = String.Empty
        If chkDbConfig.CheckState = CheckState.Unchecked Then

            Me.SetBounds(407, 220, 407, 220)
            Me.CenterToScreen()
        Else
            Me.SetBounds(Me.Bounds.Left, Me.Bounds.Top, 407, 340)


        End If
    End Sub

    Private Sub findServers()

        Dim oTable As Data.DataTable = Nothing
        'Dim lstServers As List(Of String)
        Try
            cboServer.Text = My.Settings.DbServer
            If cboServer.Items.Count = 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                oTable = SqlDataSourceEnumerator.Instance.GetDataSources

                For Each oRow As DataRow In oTable.Rows
                    Console.WriteLine(oRow("InstanceName").ToString)
                    If oRow("InstanceName").ToString = "" Then
                        Console.WriteLine(oRow("ServerName").ToString)
                        cboServer.Items.Add(oRow("ServerName").ToString)

                    Else
                        Console.WriteLine(oRow("ServerName").ToString)
                        cboServer.Items.Add(oRow("ServerName").ToString & "\" & oRow("InstanceName").ToString)
                    End If
                Next oRow
            End If


        Catch ex As Exception
            'ErrHandler("frmLogin", "cmbServer_DropDown", ex.Source, ex.Message, ex.InnerException)
            MessageBox.Show(ex.Message)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            If oTable IsNot Nothing Then
                oTable.Dispose()
            End If
        End Try

    End Sub

#Region "Search For Server"
    Private Sub cboServer_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboServer.DropDown
        Dim isAvailable = My.Computer.Network.IsAvailable

        If isAvailable Then
            findServers()
        Else
            lblInfo.Text = "Your computer is not connected to any network"
        End If
    End Sub
#End Region


    Private Sub btnTestConnection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestConnection.Click
        TestConnection()

    End Sub

    Public Function checkConnection()
        lblInfo.Text = String.Empty
        Dim connectedsql As Boolean = False
        Dim server As String = cboServer.Text
        Dim username As String = txtUsername.Text
        Dim userpass As String = txtPassword.Text
        Dim database As String = cboDatabase.Text
        Try
            Dim connectionString As String = "Data Source=" & _
                server & ";Initial Catalog=" & _
                database & ";Persist Security Info=True;User ID=" & username & ";Password=" & userpass & ""
            lblInfo.Text = "Running Database Test..."
            Dim conn As New SqlConnection(connectionString)
            conn.Open()
            connectedsql = True
            saveDatabaseSettings()
            lblInfo.Text = "Connection State: " & conn.State.ToString
            conn.Close()
        Catch ex As Exception
            lblInfo.Text = "Error connecting to the database..." & vbCrLf & ex.Message
        End Try
        Return connectedsql
    End Function

    Private Sub saveDatabaseSettings()

        My.Settings.DbServer = cboServer.Text
        My.Settings.DbUserName = txtUsername.Text
        My.Settings.DbPassword = txtPassword.Text
        My.Settings.DbDatabase = cboDatabase.Text
        My.Settings.Save()

    End Sub

    Private Sub TestConnection()
        saveDatabaseSettings()
        If checkConnection() Then
            lblInfo.Text = "Result: Connected"
            connected = True
        Else
            lblInfo.Text = "Result: Can't connect"
        End If
    End Sub






    Private Sub cboDatabase_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDatabase.DropDown
        cboDatabase.Items.Clear()
        listDatabases()
    End Sub

    Private Sub listDatabases()
        Dim server As String = cboServer.Text
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Dim testString As String = "Data Source=" & server & ";Initial Catalog=;Persist Security Info=True;User ID=" & username & ";Password=" & password & ""
        Dim sqlString As String = "SELECT * FROM [master].[dbo].[sysdatabases] WHERE name NOT IN ('tempbd', 'master', 'model', 'msdb')"
        'Dim sqlString As String = "SHOW databases;"

        Dim conn As SqlConnection
        Try
            conn = New SqlConnection(testString)
            conn.Open()
            Dim sqlComm As New SqlCommand(sqlString, conn)
            Dim data As SqlDataReader
            data = sqlComm.ExecuteReader()
            While data.Read
                'For i As Integer = 0 To data.FieldCount - 1
                cboDatabase.Items.Add(data("name").ToString)
                'Next
            End While
            conn.Close()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub chkRemPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRemPass.CheckedChanged
        If chkRemPass.CheckState = CheckState.Checked Then
            My.Settings.RememberPassword = True
            My.Settings.Save()
            My.Settings.Reload()

        ElseIf chkRemPass.CheckState = CheckState.Unchecked Then
            My.Settings.RememberPassword = False
            My.Settings.Save()
            My.Settings.Reload()
        Else
            My.Settings.RememberPassword = True
            My.Settings.Save()
            My.Settings.Reload()

        End If
    End Sub
End Class
