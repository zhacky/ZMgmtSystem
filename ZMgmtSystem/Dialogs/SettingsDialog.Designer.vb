<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TabControlSettings = New System.Windows.Forms.TabControl()
        Me.TabPageAppSettings = New System.Windows.Forms.TabPage()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.TabPageDbConfiguration = New System.Windows.Forms.TabPage()
        Me.OpenFileDialogSaveLogo = New System.Windows.Forms.OpenFileDialog()
        Me.txtImageFile = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOpenImageFile = New System.Windows.Forms.Button()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.gbDisplay = New System.Windows.Forms.GroupBox()
        Me.chkFullScreenMode = New System.Windows.Forms.CheckBox()
        Me.btnOpenDbSettings = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControlSettings.SuspendLayout()
        Me.TabPageAppSettings.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageDbConfiguration.SuspendLayout()
        Me.gbDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 341)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'TabControlSettings
        '
        Me.TabControlSettings.Controls.Add(Me.TabPageAppSettings)
        Me.TabControlSettings.Controls.Add(Me.TabPageDbConfiguration)
        Me.TabControlSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControlSettings.Location = New System.Drawing.Point(0, 0)
        Me.TabControlSettings.Name = "TabControlSettings"
        Me.TabControlSettings.SelectedIndex = 0
        Me.TabControlSettings.Size = New System.Drawing.Size(435, 342)
        Me.TabControlSettings.TabIndex = 1
        '
        'TabPageAppSettings
        '
        Me.TabPageAppSettings.Controls.Add(Me.gbDisplay)
        Me.TabPageAppSettings.Controls.Add(Me.btnDefault)
        Me.TabPageAppSettings.Controls.Add(Me.btnOpenImageFile)
        Me.TabPageAppSettings.Controls.Add(Me.Label1)
        Me.TabPageAppSettings.Controls.Add(Me.txtImageFile)
        Me.TabPageAppSettings.Controls.Add(Me.PictureBoxLogo)
        Me.TabPageAppSettings.Location = New System.Drawing.Point(4, 22)
        Me.TabPageAppSettings.Name = "TabPageAppSettings"
        Me.TabPageAppSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAppSettings.Size = New System.Drawing.Size(427, 316)
        Me.TabPageAppSettings.TabIndex = 0
        Me.TabPageAppSettings.Text = "Application Settings"
        Me.TabPageAppSettings.UseVisualStyleBackColor = True
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Location = New System.Drawing.Point(8, 6)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(203, 303)
        Me.PictureBoxLogo.TabIndex = 0
        Me.PictureBoxLogo.TabStop = False
        '
        'TabPageDbConfiguration
        '
        Me.TabPageDbConfiguration.Controls.Add(Me.btnOpenDbSettings)
        Me.TabPageDbConfiguration.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDbConfiguration.Name = "TabPageDbConfiguration"
        Me.TabPageDbConfiguration.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDbConfiguration.Size = New System.Drawing.Size(427, 316)
        Me.TabPageDbConfiguration.TabIndex = 1
        Me.TabPageDbConfiguration.Text = "Configuration"
        Me.TabPageDbConfiguration.UseVisualStyleBackColor = True
        '
        'OpenFileDialogSaveLogo
        '
        Me.OpenFileDialogSaveLogo.FileName = "OpenFileDialog1"
        '
        'txtImageFile
        '
        Me.txtImageFile.Location = New System.Drawing.Point(220, 48)
        Me.txtImageFile.Name = "txtImageFile"
        Me.txtImageFile.Size = New System.Drawing.Size(196, 20)
        Me.txtImageFile.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "File"
        '
        'btnOpenImageFile
        '
        Me.btnOpenImageFile.Location = New System.Drawing.Point(220, 74)
        Me.btnOpenImageFile.Name = "btnOpenImageFile"
        Me.btnOpenImageFile.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenImageFile.TabIndex = 3
        Me.btnOpenImageFile.Text = "Open"
        Me.btnOpenImageFile.UseVisualStyleBackColor = True
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(301, 74)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(75, 23)
        Me.btnDefault.TabIndex = 4
        Me.btnDefault.Text = "Default"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'gbDisplay
        '
        Me.gbDisplay.Controls.Add(Me.chkFullScreenMode)
        Me.gbDisplay.Location = New System.Drawing.Point(221, 103)
        Me.gbDisplay.Name = "gbDisplay"
        Me.gbDisplay.Size = New System.Drawing.Size(200, 206)
        Me.gbDisplay.TabIndex = 5
        Me.gbDisplay.TabStop = False
        Me.gbDisplay.Text = "Display"
        '
        'chkFullScreenMode
        '
        Me.chkFullScreenMode.AutoSize = True
        Me.chkFullScreenMode.Location = New System.Drawing.Point(6, 19)
        Me.chkFullScreenMode.Name = "chkFullScreenMode"
        Me.chkFullScreenMode.Size = New System.Drawing.Size(177, 30)
        Me.chkFullScreenMode.TabIndex = 0
        Me.chkFullScreenMode.Text = "Always Set To FullScreen Mode" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Shortcut: F7)"
        Me.chkFullScreenMode.UseVisualStyleBackColor = True
        '
        'btnOpenDbSettings
        '
        Me.btnOpenDbSettings.Location = New System.Drawing.Point(8, 6)
        Me.btnOpenDbSettings.Name = "btnOpenDbSettings"
        Me.btnOpenDbSettings.Size = New System.Drawing.Size(168, 23)
        Me.btnOpenDbSettings.TabIndex = 0
        Me.btnOpenDbSettings.Text = "Open Database Settings"
        Me.btnOpenDbSettings.UseVisualStyleBackColor = True
        '
        'SettingsDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 382)
        Me.Controls.Add(Me.TabControlSettings)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControlSettings.ResumeLayout(False)
        Me.TabPageAppSettings.ResumeLayout(False)
        Me.TabPageAppSettings.PerformLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageDbConfiguration.ResumeLayout(False)
        Me.gbDisplay.ResumeLayout(False)
        Me.gbDisplay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TabControlSettings As System.Windows.Forms.TabControl
    Friend WithEvents TabPageAppSettings As System.Windows.Forms.TabPage
    Friend WithEvents TabPageDbConfiguration As System.Windows.Forms.TabPage
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialogSaveLogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnOpenImageFile As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtImageFile As System.Windows.Forms.TextBox
    Friend WithEvents btnDefault As System.Windows.Forms.Button
    Friend WithEvents gbDisplay As System.Windows.Forms.GroupBox
    Friend WithEvents chkFullScreenMode As System.Windows.Forms.CheckBox
    Friend WithEvents btnOpenDbSettings As System.Windows.Forms.Button

End Class
