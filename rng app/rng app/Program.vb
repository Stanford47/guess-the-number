Imports System
Imports rng_app.RNG


Module Program
    Sub main()
        'create vars
        Dim number_to_guess As Integer
        Dim correct As Boolean = False

        Console.WriteLine("Welcome to my simple random number guessing game!")
        Console.WriteLine("Generating number...")

        'generate the number
        For i As Integer = 1 To RNG.rng_gen()
            number_to_guess = RNG.rng_gen()
        Next

        Console.WriteLine("Number has been generated!")
        Console.WriteLine("Guess the number!")

        Dim a_o_t As Int16 = 5

        Do
            Dim guessed_number As Integer = Convert.ToInt16(Console.ReadLine())

            If guessed_number = number_to_guess Then
                correct = True
            Else
                a_o_t = a_o_t - 1
                Console.WriteLine("That number is incorrect. you now have " & a_o_t & " tries left")
            End If

            If a_o_t = 0 Then
                correct = True
            End If
        Loop While correct = False

        If a_o_t = 0 Then
            correct = False
        End If

        If correct = True Then
            Console.WriteLine("You guessed correctly!")
            Console.WriteLine("The correct number is: " & number_to_guess)
        Else
            Console.WriteLine("You have run out of tries!")
            Console.WriteLine("The correct number was: " & number_to_guess)
        End If
    End Sub
End Module