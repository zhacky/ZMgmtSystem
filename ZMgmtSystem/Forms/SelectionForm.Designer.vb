<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectionForm
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
        Me.gbSelection = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLodging = New System.Windows.Forms.Button()
        Me.btnPOS = New System.Windows.Forms.Button()
        Me.btnSupervisor = New System.Windows.Forms.Button()
        Me.btnProduction = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnStocks = New System.Windows.Forms.Button()
        Me.gbSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSelection
        '
        Me.gbSelection.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbSelection.Controls.Add(Me.btnExit)
        Me.gbSelection.Controls.Add(Me.btnLodging)
        Me.gbSelection.Controls.Add(Me.btnPOS)
        Me.gbSelection.Controls.Add(Me.btnSupervisor)
        Me.gbSelection.Controls.Add(Me.btnProduction)
        Me.gbSelection.Controls.Add(Me.btnSettings)
        Me.gbSelection.Controls.Add(Me.btnReports)
        Me.gbSelection.Controls.Add(Me.btnStocks)
        Me.gbSelection.Location = New System.Drawing.Point(49, 44)
        Me.gbSelection.Name = "gbSelection"
        Me.gbSelection.Size = New System.Drawing.Size(491, 275)
        Me.gbSelection.TabIndex = 0
        Me.gbSelection.TabStop = False
        Me.gbSelection.Text = "Please select an Operation"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(354, 140)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 100)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLodging
        '
        Me.btnLodging.Image = Global.ZMgmtSystem.My.Resources.Resources.bed
        Me.btnLodging.Location = New System.Drawing.Point(354, 34)
        Me.btnLodging.Name = "btnLodging"
        Me.btnLodging.Size = New System.Drawing.Size(100, 100)
        Me.btnLodging.TabIndex = 4
        Me.btnLodging.Text = "Lodging"
        Me.btnLodging.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLodging.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLodging.UseVisualStyleBackColor = True
        '
        'btnPOS
        '
        Me.btnPOS.Image = Global.ZMgmtSystem.My.Resources.Resources.payment
        Me.btnPOS.Location = New System.Drawing.Point(248, 34)
        Me.btnPOS.Name = "btnPOS"
        Me.btnPOS.Size = New System.Drawing.Size(100, 100)
        Me.btnPOS.TabIndex = 3
        Me.btnPOS.Text = "Point-Of-Sale"
        Me.btnPOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPOS.UseVisualStyleBackColor = True
        '
        'btnSupervisor
        '
        Me.btnSupervisor.Location = New System.Drawing.Point(142, 140)
        Me.btnSupervisor.Name = "btnSupervisor"
        Me.btnSupervisor.Size = New System.Drawing.Size(100, 100)
        Me.btnSupervisor.TabIndex = 6
        Me.btnSupervisor.Text = "Supervisor"
        Me.btnSupervisor.UseVisualStyleBackColor = True
        '
        'btnProduction
        '
        Me.btnProduction.Image = Global.ZMgmtSystem.My.Resources.Resources.steak
        Me.btnProduction.Location = New System.Drawing.Point(142, 34)
        Me.btnProduction.Name = "btnProduction"
        Me.btnProduction.Size = New System.Drawing.Size(100, 100)
        Me.btnProduction.TabIndex = 2
        Me.btnProduction.Text = "Production"
        Me.btnProduction.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProduction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProduction.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(248, 140)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(100, 100)
        Me.btnSettings.TabIndex = 7
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Image = Global.ZMgmtSystem.My.Resources.Resources.clipboard
        Me.btnReports.Location = New System.Drawing.Point(36, 140)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(100, 100)
        Me.btnReports.TabIndex = 5
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnStocks
        '
        Me.btnStocks.Image = Global.ZMgmtSystem.My.Resources.Resources.cart
        Me.btnStocks.Location = New System.Drawing.Point(36, 34)
        Me.btnStocks.Name = "btnStocks"
        Me.btnStocks.Size = New System.Drawing.Size(100, 100)
        Me.btnStocks.TabIndex = 1
        Me.btnStocks.Text = "Stocks"
        Me.btnStocks.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnStocks.UseVisualStyleBackColor = True
        '
        'SelectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(589, 362)
        Me.Controls.Add(Me.gbSelection)
        Me.Name = "SelectionForm"
        Me.gbSelection.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbSelection As System.Windows.Forms.GroupBox
    Friend WithEvents btnStocks As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnLodging As System.Windows.Forms.Button
    Friend WithEvents btnPOS As System.Windows.Forms.Button
    Friend WithEvents btnSupervisor As System.Windows.Forms.Button
    Friend WithEvents btnProduction As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
End Class
