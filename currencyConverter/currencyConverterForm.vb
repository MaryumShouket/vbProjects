Public Class currencyConverterForm
    Dim currencyAndRate(9, 1) As String
    Dim number As Integer = 0
    Dim amount As String
    Dim currency As String
    Dim result As Decimal
    Dim amountInDecimal As Decimal
    Dim text As String
    Dim textExists As Boolean = False


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        text = txtCurrencyName.Text
        textExists = False

        For i As Integer = 0 To 9 Step +1
            If (Not currencyAndRate(i, 0) Is Nothing) Then
                If (Not text Is Nothing) And (text.Length > 0) And (currencyAndRate(i, 0).Equals(text)) Then
                    textExists = True
                    Exit For
                End If

            End If
        Next

        If (Not text Is Nothing) And (text.Length > 0) And (textExists = False) Then
            currencyAndRate(number, 0) = text
            currencyAndRate(number, 1) = txtRate.Text
            cboCurrencyNames.Items.Add(currencyAndRate(number, 0) & "(" & currencyAndRate(number, 1) & ")")
            number += 1
            'Console.WriteLine("Rate of {0} is {1}", currencyAndRate(number, 0), currencyAndRate(number, 1))
            'Console.WriteLine("{0}-{1}", currencyAndRate(number, 0), currencyAndRate(number, 1))
            'Console.WriteLine(currencyAndRate(number, 0) & "-" & currencyAndRate(number, 1))
        End If
    End Sub


    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        currency = cboCurrencyNames.SelectedItem
        Dim length As Integer = currency.IndexOf("(")
        currency = currency.Substring(0, length)
        amount = txtAmount.Text

        If Decimal.TryParse(amount, amountInDecimal) Then

            Dim valueFound As Boolean = False
            For i As Integer = 0 To 9 Step +1
                If Not currencyAndRate(i, 0) Is Nothing Then
                    If currencyAndRate(i, 0).Equals(currency) Then
                        result = currencyAndRate(i, 1) * amount
                        MsgBox("Amount in " & currency & " is " & result)
                        valueFound = True
                        Exit For
                    End If
                End If

            Next
            If valueFound.Equals(False) Then
                MsgBox("Currency not found")
            End If
        Else
                MsgBox("please enter a valid number")
        End If
    End Sub

    Private Sub cboCurrencyNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCurrencyNames.SelectedIndexChanged

    End Sub
End Class