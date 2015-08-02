Module Module1
    Sub Main()
        Dim currentNumber = 1
        Dim lastNumber = 100

        Do While currentNumber <= lastNumber
            Console.WriteLine(currentNumber)
            currentNumber = currentNumber + 1
        Loop

        Console.ReadKey()

    End Sub

End Module
