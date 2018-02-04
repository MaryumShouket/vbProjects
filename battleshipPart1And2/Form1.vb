Public Class Form1
    Dim firePosition As String
    Dim generator As Random
    Dim number As Integer
    Dim NumberOfShips As Integer = 5
    Dim isGuessTrue As Boolean
    Dim intFirePosition As Integer
    Dim firePositionError As Boolean
    Dim misses As Integer = 0
    Dim previousFirePositionNumber As Integer = 0
    Dim previousLocationSame As Boolean
    Dim randomNumber As Integer
    Dim previousFirePosition(49) As Integer
    Dim shipLocations(49) As Integer
    Dim ships(4) As Integer

    Private Sub btnFire_Click(sender As Object, e As EventArgs) Handles btnFire.Click
        game()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generator = New System.Random
        For i As Integer = 0 To 4 Step +1
            ships(i) = generator.Next(0, 49)

            ''For testing to make the two successive values same
            'If (i = 2) Then
            '    ships(i) = ships(i - 1)
            'End If

            If i > 0 Then
                For j As Integer = 0 To i - 1 Step +1
                    If ships(i).Equals(ships(j)) Then
                        ships.SetValue(generator.Next(0, 49), i)
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub game()
        firePositionError = False
        firePosition = txtMove.Text

        If (Not firePosition Is Nothing) And (Integer.TryParse(firePosition, intFirePosition)) And (intFirePosition < 49) And (intFirePosition > -1) Then
            isGuessTrue = False
            previousLocationSame = False

            If previousFirePositionNumber > 0 Then
                For i As Integer = 0 To previousFirePositionNumber - 1 Step +1
                    If (previousFirePosition(i).Equals(intFirePosition)) Then
                        MsgBox("You cannot enter the same value again. Please try again")
                        previousLocationSame = True
                    End If
                Next
            End If
            previousFirePosition(previousFirePositionNumber) = intFirePosition
            previousFirePositionNumber += 1
            If previousLocationSame = False Then
                For i As Integer = 0 To 4 Step +1
                    If intFirePosition.Equals(ships(i)) Then
                        isGuessTrue = True
                        ships(i) = -1
                        NumberOfShips -= 1
                        If NumberOfShips = 0 Then
                            MsgBox("Congratulation! You have won.")
                        Else
                            MsgBox("Well done! You just hit a ship. The number of remaining ships is " & NumberOfShips & ". The number of misses is " & misses)
                        End If
                    End If
                Next

                If isGuessTrue = False Then
                    misses += 1
                    MsgBox("Oops! you missed the ship. The number of remaining ships is " & NumberOfShips & ". The number of misses is " & misses)
                End If
            Else
                firePositionError = True
            End If
        Else
            firePositionError = True
        End If
        If previousLocationSame = False And firePositionError = True Then
            MsgBox("please enter a valid integer value between 0 and 49")
        End If


    End Sub

    Private Sub txtMove_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMove.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            game()
        End If
    End Sub
End Class
