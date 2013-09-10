Imports System.Windows.Forms

Public Class UnitsDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    
    Private Sub UnitsDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listUnits()
    End Sub

    Private Sub listUnits()
        cboUnitSelect.Items.AddRange((New UnitOfMeasure).units.ToArray)
    End Sub

    Private Sub btnAddUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUnit.Click
        If btnAddUnit.Text = "Add New" Then
            EnableSaveAndDelete(True)
            EmptyBoxes(True)
            cboUnitSelect.Enabled = False
            btnAddUnit.Text = "Cancel"
        Else
            btnAddUnit.Text = "Add New"
            cboUnitSelect.Enabled = True
            EnableSaveAndDelete(False)
        End If
    End Sub

    Private Sub EmptyBoxes(ByVal p1 As Boolean)
        If p1 Then
            txtUnitName.Clear()
            txtUnitDescription.Clear()
        End If
    End Sub

    Private Sub btnSaveUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveUnit.Click

        If txtUnitName.Text <> String.Empty Then
            If Not cboUnitSelect.Enabled Then
                Dim units As New UnitOfMeasure(txtUnitName.Text)

                units.Save(txtUnitName.Text, txtUnitDescription.Text)
                units.Dispose()
            Else
                Dim units As New UnitOfMeasure(txtUnitName.Text)

                units.Update(cboUnitSelect.SelectedIndex + 1, txtUnitName.Text, txtUnitDescription.Text)
                units.Dispose()
            End If
            EmptyBoxes(True)
            cboUnitSelect.Enabled = True
        Else
            MessageBox.Show("Unit name cannot be empty...")
        End If
        


    End Sub



    Private Sub EnableSaveAndDelete(ByVal p1 As Boolean)
        btnSaveUnit.Enabled = p1
        btnDelete.Enabled = p1
    End Sub

    Private Sub cboUnitSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUnitSelect.SelectedIndexChanged
        If cboUnitSelect.Text = String.Empty Then
            EnableSaveAndDelete(True)
            PopulateFields()
        Else
            EnableSaveAndDelete(False)
        End If
    End Sub

    Private Sub PopulateFields()
        Dim unitname As String = cboUnitSelect.SelectedItem.ToString
        Dim unit As New UnitOfMeasure(unitname)
        txtUnitName.Text = unit.unit_name.ToString
        txtUnitDescription.Text = unit.unit_description.ToString
      
    End Sub

End Class
