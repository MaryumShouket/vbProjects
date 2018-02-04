Module Module1

    Sub Main()
        Dim weightStones As String
        Dim heightInches As String
        Dim weightKg As Decimal
        Dim heightCm As Decimal
        Dim weightResult As Decimal
        Dim heightResult As Decimal

        Console.Write("please enter the weight in stones and enter 'q' to quit : ")
        weightStones = Console.ReadLine()

        While (Not weightStones.Equals("q"))

            While (Not Decimal.TryParse(weightStones, weightResult))
                Console.Write("{0}Please enter a valid value for weight in stones : ", Environment.NewLine)
                weightStones = Console.ReadLine()
            End While

            Console.Write("{0}Please enter the height in inches : ", Environment.NewLine)
            heightInches = Console.ReadLine()

            While (Not Decimal.TryParse(heightInches, heightResult))
                Console.Write("{0}Please enter a valid value for height in inches : ", Environment.NewLine)
                heightInches = Console.ReadLine()
            End While

            weightKg = Math.Round(weightStones * 6.364, 2)
            heightCm = Math.Round(heightInches * 2.54, 2)

            Console.WriteLine("{0}Your weight in kilograms is {1}kg.{0}Your height in centimeters is {2}cm.", Environment.NewLine, weightKg, heightCm)

            Console.Write("{0}please enter the weight in stones and enter 'q' to quit : ", Environment.NewLine)
            weightStones = Console.ReadLine()
        End While



    End Sub

End Module
