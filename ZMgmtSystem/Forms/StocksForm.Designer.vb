<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StocksForm
    Inherits ZMgmtSystem.frmMain

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Pur_stocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataSet = New ZMgmtSystem.UserDataSet()
        Me.Pur_stocksTableAdapter = New ZMgmtSystem.UserDataSetTableAdapters.pur_stocksTableAdapter()
        Me.TableAdapterManager = New ZMgmtSystem.UserDataSetTableAdapters.TableAdapterManager()
        CType(Me.Pur_stocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pur_stocksBindingSource
        '
        Me.Pur_stocksBindingSource.DataMember = "pur_stocks"
        Me.Pur_stocksBindingSource.DataSource = Me.UserDataSet
        '
        'UserDataSet
        '
        Me.UserDataSet.DataSetName = "UserDataSet"
        Me.UserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pur_stocksTableAdapter
        '
        Me.Pur_stocksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.pur_stocksTableAdapter = Me.Pur_stocksTableAdapter
        Me.TableAdapterManager.UpdateOrder = ZMgmtSystem.UserDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'StocksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(644, 383)
        Me.Name = "StocksForm"
        CType(Me.Pur_stocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserDataSet As ZMgmtSystem.UserDataSet
    Friend WithEvents Pur_stocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pur_stocksTableAdapter As ZMgmtSystem.UserDataSetTableAdapters.pur_stocksTableAdapter
    Friend WithEvents TableAdapterManager As ZMgmtSystem.UserDataSetTableAdapters.TableAdapterManager

End Class
