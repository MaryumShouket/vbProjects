Module Module1

    Sub Main()
        Dim numbers As String
        Dim size As Integer
        Dim average As Decimal
        Dim sum As Decimal
        Dim ResultNumbers As Integer



        Console.Write("Enter the number of numbers that you want to take an average of or enter 'q' to quit : ")
        numbers = Console.ReadLine()

        While (Not numbers.Equals("q"))
            While (Not Integer.TryParse(numbers, ResultNumbers))
                Console.Write("Please enter a valid number : ")
                numbers = Console.ReadLine()
            End While

            size = numbers - 1

            Dim averageNumbers(size) As String
            Dim iResult(size) As Decimal
            sum = 0
            average = 0


            For i As Integer = 0 To size Step +1
                Console.Write("{0}Enter number {1} : ", Environment.NewLine, i + 1)
                averageNumbers(i) = Console.ReadLine()
                While Not Decimal.TryParse(averageNumbers(i), iResult(i))
                    Console.Write("Please enter a valid number : ")
                    averageNumbers(i) = Console.ReadLine()
                End While

                sum += iResult(i)

                average = sum / numbers

            Next
            Console.WriteLine("{0}The sum is {1} and the average is {2}", Environment.NewLine, sum, average)
            Console.Write("{0}Enter the number of numbers that you want to take an average of or enter 'q' to quit : ", Environment.NewLine)
            numbers = Console.ReadLine()

        End While


    End Sub

End Module
