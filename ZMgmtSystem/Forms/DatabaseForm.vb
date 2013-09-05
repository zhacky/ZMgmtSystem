Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class DatabaseForm

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel

        Me.Close()
    End Sub
    Private Sub listDatabases()
        Dim server As String = cboServer.Text
        Dim username As String = txtDbUser.Text
        Dim password As String = txtDbPassword.Text

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

    Private Sub btnDbTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDbTest.Click
        saveDatabaseSettings()
        If checkConnection() Then
            lblTestResult.Text = "Result: Connected"
        Else
            lblTestResult.Text = "Result: Can't connect"
        End If

    End Sub
    Public Function checkConnection()
        lblTestResult.Text = String.Empty
        Dim connected As Boolean = False
        Dim server As String = cboServer.Text
        Dim username As String = txtDbUser.Text
        Dim userpass As String = txtDbPassword.Text
        Dim database As String = cboDatabase.Text

        Try


            Dim connectionString As String = "Data Source=" & _
                server & ";Initial Catalog=" & _
                database & ";Persist Security Info=True;User ID=" & username & ";Password=" & userpass & ""
            lblTestResult.Text = "Running Database Test..."
            Dim conn As New SqlConnection(connectionString)
            conn.Open()
            connected = True
            lblTestResult.Text = "Connection State: " & conn.State.ToString

            conn.Close()

        Catch ex As Exception
            lblTestResult.Text = "Error connecting to the database..." & vbCrLf & ex.Message



        End Try




        Return connected
    End Function

    
    Private Sub cboDatabase_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDatabase.DropDown
        cboDatabase.Items.Clear()
        listDatabases()
    End Sub

    Private Sub cboServer_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboServer.DropDown
        findServers()
    End Sub

    Private Sub findServers()
        Dim oTable As New Data.DataTable
        Dim lstServers As New List(Of String)
        Try
            If cboServer.Items.Count = 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                oTable = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources

                For Each oRow As DataRow In oTable.Rows
                    If oRow("InstanceName").ToString = "" Then
                        cboServer.Items.Add(oRow("ServerName"))
                    Else
                        cboServer.Items.Add(oRow("ServerName").ToString & "\" & oRow("InstanceName").ToString)
                    End If
                Next oRow
            End If
        Catch ex As Exception
            'ErrHandler(Me, "frmLogin", "cmbServer_DropDown", ex.Source, ex.Message, ex.InnerException)
            MessageBox.Show("Error: " & ex.Message)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

            If oTable IsNot Nothing Then
                oTable.Dispose()
            End If
        End Try
    End Sub

    Private Sub DatabaseForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTestResult.Text = String.Empty
        loadDbSettingsToBoxes()
    End Sub

    Private Sub saveDatabaseSettings()
        My.Settings.DbServer = cboServer.Text
        My.Settings.DbUserName = txtDbUser.Text
        My.Settings.DbPassword = txtDbPassword.Text
        My.Settings.DbDatabase = cboDatabase.Text
        My.Settings.Save()
       
    End Sub

    Private Sub loadDbSettingsToBoxes()
        cboServer.Text = My.Settings.DbServer
        cboDatabase.Text = My.Settings.DbDatabase
        txtDbUser.Text = My.Settings.DbUserName
        txtDbPassword.Text = My.Settings.DbPassword
    End Sub

End Class
