Module Module1

    Sub Main()
        Dim numbers(20) As Integer
        numbers(0) = 0
        numbers(1) = 1


        For i As Integer = 2 To 19 Step +1
            numbers(i) = numbers(i - 2) + numbers(i - 1)
        Next

        Console.CursorLeft = 10
        Console.CursorTop = 5
        Console.WriteLine("Fibonacci sequence is: ")

        For i As Integer = 0 To 19 Step +1
            Console.CursorLeft = 35
            Console.WriteLine("{0}", numbers(i))
        Next
        Console.ReadLine()
    End Sub

End Module
