Module Module1

    Sub Main()
        Dim answer As String
        Dim celsiusTemp As Decimal
        Dim result As Decimal

        Console.Write("please enter the temperature in farenhite or enter Q to quit : ")
        answer = Console.ReadLine()


        'just for learning

        'Do
        '    Console.WriteLine("My name is maryum")
        '    Console.WriteLine("press  q to quit")
        'Loop While (Not Console.Read().Equals("q"))


        While (Not answer.Equals("q"))
            While (Decimal.TryParse(answer, result).Equals(False))
                Console.Write("{0}Please enter a valid value : ", Environment.NewLine)
                answer = Console.ReadLine()
            End While

            celsiusTemp = (answer - 32) * (5 / 9)
            Console.WriteLine("{0}The temperature in celsius is {1}", Environment.NewLine, celsiusTemp)
            Console.Write("{0}please enter the temperature in farenhite or enter Q to quit : ", Environment.NewLine)
            answer = Console.ReadLine()
        End While



    End Sub

End Module
