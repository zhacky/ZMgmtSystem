Imports System.Data.SqlClient
Imports System.ComponentModel
Imports ZMgmtSystem.Param
Imports System.IO

Public Class Employee
    Implements IDisposable
    Public user As String
    Public password As String
    Public role As Integer
    Public employee_id As Integer
    Public LastName As String
    Public MiddleName As String
    Public FirstName As String
    Public Title As String
    Public Position As String
    Public BirthDate As DateTime
    Public HireDate As DateTime
    Public Address As String
    Public City As String
    Public Province As String
    Public PostalCode As String
    Public Phone As String
    Public Mobile As String
    Public Photo As Image

    Public Notes As String
    Public PhotoPath As String
    Private supervisorForm As SupervisorForm

    Sub New()

    End Sub
    Sub New(ByVal emp_id As Integer)

    End Sub
    Sub New(ByVal _supervisorForm As Form)
        Try
            supervisorForm = _supervisorForm
            user = supervisorForm.txtUsername.Text
            password = supervisorForm.txtUserPassword.Text
            role = GetRoleID(supervisorForm.cboUsersRole.Text)
            employee_id = supervisorForm.txtEmpID.Text
            LastName = supervisorForm.txtLastName.Text
            MiddleName = supervisorForm.txtMiddleName.Text
            FirstName = supervisorForm.txtLastName.Text
            Title = supervisorForm.cboCourtesyTitle.Text
            Position = supervisorForm.txtPosition.Text
            BirthDate = supervisorForm.dateBirth.Value
            HireDate = supervisorForm.dateHire.Value
            Address = supervisorForm.txtEmpAddress.Text
            City = supervisorForm.txtCity.Text
            Province = supervisorForm.txtProvince.Text
            PostalCode = supervisorForm.txtPostal.Text
            Phone = supervisorForm.txtPhone.Text
            Mobile = supervisorForm.txtMobile.Text
            Photo = supervisorForm.empPhoto.Image
            Notes = supervisorForm.txtEmpNotes.Text
            Console.WriteLine(Param.ImgDir & "\" & employee_id & ".jpg")
            Photo.Save(Param.ImgDir & "\" & employee_id & ".jpg")
            
            Dim fileExists As Boolean
            fileExists = My.Computer.FileSystem.FileExists("C:\Test.txt")




            PhotoPath = Param.ImgDir & "\" & employee_id & ".jpg"
            
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub





#Region "Get All Employees"
    Shared Function GetAllEmployees(ByVal ColumnIndex As Integer) As String()
        Dim ConnString As String = CurrentConfig.ConnectionString
        Dim conn As New SqlConnection(ConnString)
        Dim SqlQuery As String = "SELECT * FROM Users INNER JOIN Employees ON Users.employee_id = Employees.employee_id"
        Dim cmd As New SqlCommand(SqlQuery, conn)
        Dim data As SqlDataReader
        Dim result As New List(Of String)
        Dim returnString As String()

        Dim previousConnectionState As ConnectionState = conn.State
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            data = cmd.ExecuteReader()
            'Array.Resize(result, data.RecordsAffected)
            Using data

                While data.Read

                    Select Case ColumnIndex
                        Case EMPLOYEEID
                            result.Add(data(3).ToString)

                        Case FULLNAME
                            Console.WriteLine(data(1).ToString & vbCrLf & data(2).ToString & vbCrLf & data(3).ToString)
                            Dim item As String = data(7).ToString & "," & data(9).ToString & " " & data(8).ToString
                            result.Add(item)

                        Case 3

                        Case Else

                    End Select


                End While
            End Using
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
                conn.Dispose()
            End If
        End Try
        returnString = result.ToArray
        Return returnString
    End Function

#End Region






#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

    Sub Save()
        Dim rowCount As Integer
        Dim conn As New SqlConnection(CurrentConfig.ConnectionString)
        Dim SqlQuery1 As String = "INSERT INTO Users(username, password, employee_id, role_id) VALUES(@user,@password,@empid,@role)"
        Dim SqlQuery2 As String = "INSERT INTO Employees(EmpID, employee_id, LastName, MiddleName, FirstName, " & _
                      "Position, TitleOfCourtesy, BirthDate, HireDate, Address, " & _
                      "Province, City, Phone, PostalCode, Mobile,  Notes, PhotoPath)" & _
                      "VALUES (@empid,@empid2,@lastname,@middlename,@firstname," & _
                      "@position,@title,@birthdate,@hiredate,@address," & _
                      "@province,@city,@phone,@postal,@mobile,@notes,@photopath)"
        Dim cmd1 As New SqlCommand(SqlQuery1, conn)
        Dim cmd2 As New SqlCommand(SqlQuery2, conn)
        '-------add parameters------
        cmd1.Parameters.AddWithValue("@user", user)
        cmd1.Parameters.AddWithValue("@password", password)
        cmd1.Parameters.AddWithValue("@empid", employee_id)
        cmd1.Parameters.AddWithValue("@role", role)
        '---
        cmd2.Parameters.AddWithValue("@empid", employee_id)
        cmd2.Parameters.AddWithValue("@empid2", employee_id)

        cmd2.Parameters.AddWithValue("@lastname", LastName)
        cmd2.Parameters.AddWithValue("@middlename", MiddleName)
        cmd2.Parameters.AddWithValue("@firstname", FirstName)
        cmd2.Parameters.AddWithValue("@position", Position)
        cmd2.Parameters.AddWithValue("@title", Title)
        cmd2.Parameters.AddWithValue("@birthdate", BirthDate)
        cmd2.Parameters.AddWithValue("@hiredate", HireDate)
        cmd2.Parameters.AddWithValue("@address", Address)
        cmd2.Parameters.AddWithValue("@province", Province)
        cmd2.Parameters.AddWithValue("@city", City)
        cmd2.Parameters.AddWithValue("@phone", Phone)
        cmd2.Parameters.AddWithValue("@postal", PostalCode)
        cmd2.Parameters.AddWithValue("@mobile", Mobile)
        'Dim ms As New MemoryStream()
        'Photo.Save(ms, Photo.RawFormat)
        'Dim picdata As Byte() = ms.GetBuffer()
        'Dim p As New SqlParameter("@photo", SqlDbType.Image)
        'p.Value = picdata
        'cmd2.Parameters.Add(p)

        cmd2.Parameters.AddWithValue("@notes", Notes)
        cmd2.Parameters.AddWithValue("@photopath", PhotoPath)
        '---------------------------
        Dim previousConnectionState As ConnectionState
        previousConnectionState = conn.State
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            rowCount = cmd1.ExecuteNonQuery()
            rowCount = cmd2.ExecuteNonQuery()

        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try

    End Sub

    Private Function GetRoleID(ByVal p1 As String) As Integer
        Dim roleInt As Integer
        Dim conn As New SqlConnection(CurrentConfig.ConnectionString)
        Dim SqlQuery As String = "SELECT role_id FROM Roles WHERE role_name = @rolename"
        Dim cmd As New SqlCommand(SqlQuery, conn)
        cmd.Parameters.AddWithValue("@rolename", p1)
        Dim result As Integer
        Dim previousConnectionState As ConnectionState = conn.State
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            result = cmd.ExecuteScalar()
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()

            End If
        End Try

        roleInt = result
        Return roleInt
    End Function




End Class
