Imports System

Module Program
    Sub Main(args As String())
        Hangman("applebees")
    End Sub

    Sub Hangman(mysteryWord as String)
        'Creates the hidden word displayed to the player
        Dim displayWord as String =""
        For Each character in mysteryWord
            displayWord=displayWord & "*"
        Next
        
        'Declares needed variables
        Dim wrongGuesses as String =""
        Dim numWrongGuesses as Integer = 0
        Dim tempIndex as Integer = 0
        Console.WriteLine("It's time to play Hangman!")
        
        'Runs the game
        While Not displayWord = mysteryWord
            Console.WriteLine("")
            Console.WriteLine("Here is the word to guess: " & displayWord)
            Console.WriteLine("You get six wrong guesses, here are the wrong ones so far: " & wrongGuesses)
            Console.WriteLine("Give me a letter or the whole word:")
            Dim guess as String = Console.ReadLine()

            'Checks for the guess matching the full word'
            If String.Equals(guess, mysteryWord) Then 
                Console.WriteLine("You got it!")
                Exit While
            End If

            'Checks for wrong answers and updates related variables'
            If Not mysteryWord.IndexOf(guess) >= 0
                wrongGuesses=wrongGuesses & guess & " "
                numWrongGuesses=numWrongGuesses + 1
                If numWrongGuesses >= 6 Then
                    Console.WriteLine("That was six wrong guesses, you lose!")
                    Exit While
                End If
                Continue While
            End If

            'Handles display for correct answers'
            tempIndex=mysteryWord.IndexOf(guess)
            While tempIndex <> -1
                displayWord=displayWord.Remove(tempIndex,1)
                displayWord=displayWord.Insert(tempIndex,mysteryWord(tempIndex))
                tempIndex=tempIndex+1
                tempIndex=mysteryWord.IndexOf(guess, tempIndex)
            End While
            tempIndex=0

        End While
        If displayWord=mysteryWord Then Console.WriteLine("You got it!")
        Console.WriteLine("The word was " & mysteryWord)
    End Sub
End Module