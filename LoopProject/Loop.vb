'This loop prints every number from 1 to 100'

Module Module1
    Sub Main()

        'These are variables'
        Dim currentNumber = 1 'currentNumber is set to 1'
        Dim lastNumber = 100 'lastNumber is set to 100'

        'The "Do-While loop'
        Do While currentNumber <= lastNumber 'The loop will continue as long as "currentNumber is less than or equal to "lastNumber"
            Console.WriteLine(currentNumber) 'This prints "currentNumber"'
            currentNumber = currentNumber + 1 'This adds 1 to "currentNumber"
        Loop

        'Console.ReadKey() stops the app until a key is pressed'
        'It is used here so that you can read the console before it closes'
        Console.ReadKey()

    End Sub

End Module
