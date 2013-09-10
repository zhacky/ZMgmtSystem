Public Class ProductionForm

    
    Private Sub ProductionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim units As New UnitOfMeasure
        cboUnitOfMeasure.Items.AddRange(units.units.ToArray)
    End Sub

    Private Sub btnUnitsDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnitsDialog.Click
        UnitsDialog.ShowDialog()
    End Sub
End Class
