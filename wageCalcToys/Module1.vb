Module Module1

    Sub Main()
        Dim hours As String
        Dim toys As String
        Dim hoursResult As Decimal
        Dim toysResult As Integer
        Dim wage As Decimal
        Dim perHoursRate As Decimal = 9
        Dim perToyRate As Decimal = 0.6

        Console.WriteLine("Calculate your wage or and enter 'q' to quit: ")
        Console.Write("Enter the number of hours per day : ")
        hours = Console.ReadLine()

        While (Not hours.Equals("q"))
            While (Not Decimal.TryParse(hours, hoursResult))
            Console.Write("please enter a valid value for the number of hours per day : ")
            hours = Console.ReadLine()
            End While

            Console.Write("Enter the number of toy cars made per day : ")
            toys = Console.ReadLine()

            While (Not Decimal.TryParse(toys, toysResult))
                Console.Write("please enter a valid value for the number of toys made per day : ")
            toys = Console.ReadLine()
            End While

            wage = Math.Round((perHoursRate * hours) + (perToyRate * toys), 2)
            Console.WriteLine("{0}The wage per day is £{1}", Environment.NewLine, wage)

            Console.WriteLine("{0}Calculate your wage or and enter 'q' to quit: ", Environment.NewLine)
            Console.Write("Enter the number of hours per day : ")
            hours = Console.ReadLine()
        End While
    End Sub

End Module
