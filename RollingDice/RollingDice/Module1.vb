Module Module1


    Sub Main()
        Dim DiceRoll As ConsoleKeyInfo
        Dim number As Integer
        Static Dim Generator As Random = New System.Random()
        Dim displayCharacterArray() As String = New String() {"", "", "", "", "", ""}

        DiceRoll = readUserKey()

        Console.SetBufferSize(300, 300)
        While (Not DiceRoll.KeyChar.Equals("q"c))

            number = Generator.Next(1, 7)

            Console.WriteLine("number = {0}", number)

            'NEW SINGLE LOOP TECHNIQUE
            For i As Integer = 0 To 5 Step +1
                If i < number Then
                    displayCharacterArray(i) = "#"
                ElseIf i > number Then
                    displayCharacterArray(i) = " "
                End If
            Next


            'OLD SEPERATE LOOPS TECHNIQUE
            'For i As Integer = 0 To number - 1 Step +1
            '    displayCharacterArray(i) = "#"
            'Next

            'For i As Integer = number To 5 Step +1
            '    displayCharacterArray(i) = " "
            'Next

            Console.WriteLine(Environment.NewLine)
            Console.WriteLine(Environment.NewLine)

            printDice("ooooooooooooooooooooooooooo", Nothing, Nothing)

            printDice("oo                       oo", Nothing, Nothing)

            printDice("oo     {0}        {1}        oo", displayCharacterArray(0), displayCharacterArray(1))

            printDice("oo                       oo", Nothing, Nothing)

            printDice("oo     {0}        {1}        oo", displayCharacterArray(2), displayCharacterArray(3))

            printDice("oo                       oo", Nothing, Nothing)

            printDice("oo     {0}        {1}        oo", displayCharacterArray(4), displayCharacterArray(5))

            printDice("oo                       oo", Nothing, Nothing)

            printDice("ooooooooooooooooooooooooooo", Nothing, Nothing)

            Console.WriteLine(Environment.NewLine)
            Console.WriteLine(Environment.NewLine)

            DiceRoll = readUserKey()

        End While

    End Sub

    Sub printDice(ByVal printString As String, ByVal firstCharacter As String, ByVal secondCharacter As String)
        Console.CursorLeft = 10
        Console.WriteLine(printString, firstCharacter, secondCharacter)
    End Sub

    Function readUserKey() As ConsoleKeyInfo
        Console.WriteLine("please press any key to roll the dice and if you want to quit press q")
        Return Console.ReadKey()
    End Function


End Module
