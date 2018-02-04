Public Class admin
    Dim currencyAndRate(9, 1) As String
    Dim number As Integer = 0


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        currencyAndRate(number, 0) = txtCurrencyName.Text
        currencyAndRate(number, 1) = txtRate.Text
        number += 1

    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
