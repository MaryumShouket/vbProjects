Module Module1

    Sub Main()
        Dim stringRainfall(12) As String
        Dim rainfall(12) As Decimal
        Dim months() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
        Dim total As Decimal
        Dim average As Decimal
        Dim minimum As Decimal

        Console.WriteLine("Please enter the rainfall: ")
        For i As Integer = 0 To 11 Step +1
            Console.Write("{0}{1}: ", Environment.NewLine, months(i))
            stringRainfall(i) = Console.ReadLine()
            While Not Decimal.TryParse(stringRainfall(i), rainfall(i))
                Console.CursorTop -= 1
                Console.CursorLeft = 0
                Console.Write("Please enter a valid input for {0}: ", months(i))
                stringRainfall(i) = Console.ReadLine()
            End While
            total += Math.Round(rainfall(i), 2)

        Next
        average = Math.Round(total / 12, 2)
        Console.WriteLine("{0}The total rainfall is {1}.{0}Average rainfall is {2}", Environment.NewLine, total, average)
        'Dim minimumRainfall As Decimal
        'minimumRainfall =  rainfall.m()
        'Console.WriteLine("{1}Minimum Rainfall was {0}", minimumRainfall, Environment.NewLine)
        Console.WriteLine("{1}Maximum Rainfall was {0}", rainfall.Max(), Environment.NewLine)
        Console.Write("{0}Show me months with rainfall less than: ", Environment.NewLine)
        minimum = Console.ReadLine()
        Console.WriteLine("{0}Months with rainfall lower than {1} are: ", Environment.NewLine, minimum)

        Dim outputString As String = ""

        For i As Integer = 0 To 11 Step +1
            If rainfall(i) < minimum Then
                outputString = outputString & months(i) & " = " & rainfall(i) & ", "
            End If
        Next
        outputString = outputString.Substring(0, outputString.Length - 2)
        Console.WriteLine("{0}", outputString)






        Console.ReadLine()
    End Sub

End Module
