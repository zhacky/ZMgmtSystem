Imports System.Windows.Forms

Public Class SettingsDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        My.Settings.Save()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    
    Private Sub SettingsDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadDefaultLogo()
    End Sub

    Private Sub loadDefaultLogo()
        Dim filename As String = My.Settings.SplashLogo

        If FileIO.FileSystem.FileExists(filename) Then
            txtImageFile.Text = filename
            Dim imageFile As Image = Image.FromFile(filename)
            PictureBoxLogo.BackgroundImage = imageFile
            PictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom
        Else
            PictureBoxLogo.BackgroundImage = My.Resources.logo
            PictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom
        End If
    End Sub


    Private Sub btnOpenImageFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenImageFile.Click
        Dim filename As String

        OpenFileDialogSaveLogo.DefaultExt() = ".jpg"
        OpenFileDialogSaveLogo.FileName = ""
        If OpenFileDialogSaveLogo.ShowDialog() Then
            filename = OpenFileDialogSaveLogo.FileName
            Try
                txtImageFile.Text = filename
                Dim imageOpened As Image
                imageOpened = Image.FromFile(filename)
                PictureBoxLogo.BackgroundImage = imageOpened
                PictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom
                My.Settings.SplashLogo = filename


            Catch ex As Exception
                Console.WriteLine("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefault.Click
        My.Settings.SplashLogo = String.Empty
        loadDefaultLogo()
    End Sub

    Private Sub btnOpenDbSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenDbSettings.Click
        DatabaseForm.ShowDialog()
    End Sub
End Class
