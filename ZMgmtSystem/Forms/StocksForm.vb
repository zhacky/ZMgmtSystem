Public Class StocksForm

    

    Private Sub StocksForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim munits As New MUnits
        cboUnitMeasure.Items.AddRange(munits.units.ToArray)

    End Sub

    Private Sub btnUnitsDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnitsDialog.Click
        UnitsDialog.ShowDialog()
    End Sub
End Class
