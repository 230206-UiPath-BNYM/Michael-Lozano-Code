Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        dim greeting as String = "Whats uuuuuup"
        Console.WriteLine(greeting)
        'GuessingGame(2)
        'Counter(6)
        GuessingGame2()
    End Sub

    Function greeter(greeting_type as String) as String
        Select Case greeting_type
            Case "casual"
                Return "sup"
            Case "business casual"
                Return "salutations"
            Case "business professional"
                return "to whom it make concern"
            Case Else
                Return "I am not saying hello to you"
        End select

    End Function

    Sub GuessingGame(guess as Integer)
        dim rand as Random = new Random()
        dim mysteryNumber as integer = rand.Next(1,3)
        Console.WriteLine(mysteryNumber)
        if guess <> mysteryNumber
            Console.WriteLine("WRONG")
        Else Console.WriteLIne("RIGHT")
        End If
    End Sub

    Sub Counter(stopping_point as INteger)
        dim start as INteger = 0
        While start < stopping_point
            Console.WriteLIne(start)
            start=start +1
        End While

        For index As integer = 0 To stopping_point
            Console.WriteLIne(index)
        Next
    End Sub

    Sub GuessingGame2()
        dim rand as Random = new Random()
        dim mysteryNumber as Integer = rand.Next(1,101)
        Console.WriteLine(mysteryNumber)
        Console.WriteLine("Enter guess:")
        dim guess as Integer = Integer.Parse(Console.ReadLine())
        While guess <> mysteryNumber
            If guess < mysteryNumber Then 
                Console.WriteLine("Too Low, Try again!")
            Else Console.WriteLine("Too high, try again!")
            End If
            guess = Integer.Parse(Console.ReadLine())
        End While
        Console.WriteLine("Correct! Goodbye.")
    End Sub

    Sub Hangman(mysteryWord as String)
        displayWord=""
        For counter as Integer=0 To String.Length(mysteryWord)
            displayWord=displayWord & "*"
        Next
    End Sub
End Module
