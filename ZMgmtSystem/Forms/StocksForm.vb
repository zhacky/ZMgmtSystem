Public Class StocksForm

    

    Private Sub StocksForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserDataSet.pur_stocks' table. You can move, or remove it, as needed.
        Me.Pur_stocksTableAdapter.Fill(Me.UserDataSet.pur_stocks)

    End Sub
End Class
