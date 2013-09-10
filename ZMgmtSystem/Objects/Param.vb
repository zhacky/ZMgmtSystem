Public Class Param
    Public Shared EMPLOYEEID As Integer = 1
    Public Shared FULLNAME As Integer = 2

    Public Shared ImgDir As New String
      ImgDir = Me.getAppPath()

    Function getAppPath() As String
        Dim folder As String = ""
        Dim folderExists As Boolean
        folderExists = My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\" & "EmpPhotos\")
        If folderExists Then
            folder = Application.StartupPath & "\" & "EmpPhotos\"
        Else
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\" & "EmpPhotos\")
        End If
        Return folder
    End Function





End Class
