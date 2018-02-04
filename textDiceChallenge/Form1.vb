Public Class Form1
    Private Sub btnRollDice_Click(sender As Object, e As EventArgs) Handles btnRollDice.Click
        Dim number As Integer
        Dim nummberText As String = vbNull
        Dim generator As Random
        generator = New Random()
        number = generator.Next(1, 7)

        Select Case number
            Case 1 : nummberText = "One"
            Case 2 : nummberText = "Two"
            Case 3 : nummberText = "Three"
            Case 4 : nummberText = "Four"
            Case 5 : nummberText = "Five"
            Case 6 : nummberText = "Six"
        End Select

        lblOutput.Text = nummberText



    End Sub
End Class
