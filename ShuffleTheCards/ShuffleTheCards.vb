'Luis Torres
'RCET0265
'Spring 2020
'Shuffle The Deck
'helped by Lane coleman
'https://github.com/LuisTorres0419/ShuffleTheCards.git

Option Strict On
Option Explicit On
Option Compare Text

Module ShuffleTheCards

    Sub Main()
        Dim i As Single
        Dim j As Single
        Dim newValue As Single
        Dim numberOfCards(52) As Integer
        Dim amount As Integer

        Randomize()

Shuffle:

        For amount = 0 To 51
            numberOfCards(amount) = amount + 1
        Next

        Do

            Console.WriteLine($"press enter to deal the cards. press Q to Quit. press spce bare to shuffle.")
            Console.ReadLine()

            For i = 0 To 51
                j = Int((51 - i + 1) * Rnd() + i)
                newValue = numberOfCards(CInt(i))
                numberOfCards(CInt(i)) = numberOfCards(CInt(j))
                numberOfCards(CInt(j)) = CInt(newValue)

                If numberOfCards(CInt(i)) >= 2 And numberOfCards(CInt(i)) <= 10 Then
                    Console.WriteLine($"{numberOfCards(CInt(i))} of Diamonds")
                ElseIf numberOfCards(CInt(i)) = 1 Then
                    Console.WriteLine($"ace of Diamonds")
                ElseIf numberOfCards(CInt(i)) = 11 Then
                    Console.WriteLine($"Jack of Diamonds")
                ElseIf numberOfCards(CInt(i)) = 12 Then
                    Console.WriteLine($"Queen of Diamonds")
                ElseIf numberOfCards(CInt(i)) = 13 Then
                    Console.WriteLine($"King of Diamonds")
                End If

                If numberOfCards(CInt(i)) >= 15 And numberOfCards(CInt(i)) <= 23 Then
                    Console.WriteLine($"{numberOfCards(CInt(i)) - 13} of Spades")
                ElseIf numberOfCards(CInt(i)) = 14 Then
                    Console.WriteLine($"ace of Spades")
                ElseIf numberOfCards(CInt(i)) = 24 Then
                    Console.WriteLine($"Jack of Spades")
                ElseIf numberOfCards(CInt(i)) = 25 Then
                    Console.WriteLine($"Queen of Spades")
                ElseIf numberOfCards(CInt(i)) = 26 Then
                    Console.WriteLine($"King of Spades")
                End If

                If numberOfCards(CInt(i)) >= 28 And numberOfCards(CInt(i)) <= 36 Then
                    Console.WriteLine($"{numberOfCards(CInt(i)) - 26} of Hearts")
                ElseIf numberOfCards(CInt(i)) = 27 Then
                    Console.WriteLine($"ace of Hearts")
                ElseIf numberOfCards(CInt(i)) = 37 Then
                    Console.WriteLine($"Jack of Hearts")
                ElseIf numberOfCards(CInt(i)) = 38 Then
                    Console.WriteLine($"Queen of Hearts")
                ElseIf numberOfCards(CInt(i)) = 39 Then
                    Console.WriteLine($"King of Hearts")
                End If

                If numberOfCards(CInt(i)) >= 41 And numberOfCards(CInt(i)) <= 49 Then
                    Console.WriteLine($"{numberOfCards(CInt(i)) - 39} of Clubs")
                ElseIf numberOfCards(CInt(i)) = 40 Then
                    Console.WriteLine($"ace of Clubs")
                ElseIf numberOfCards(CInt(i)) = 50 Then
                    Console.WriteLine($"Jack of Clubs")
                ElseIf numberOfCards(CInt(i)) = 51 Then
                    Console.WriteLine($"Queen of Clubs")
                ElseIf numberOfCards(CInt(i)) = 52 Then
                    Console.WriteLine($"King of Clubs")
                End If

                Select Case Console.ReadKey().Key
                    Case ConsoleKey.Q
                        Exit Sub
                    Case ConsoleKey.Spacebar
                        Console.Clear()
                        GoTo Shuffle
                End Select

            Next i

        Loop Until i = 52

        Console.WriteLine("All cards have been given")
        Console.WriteLine("press space to shuffle or start again. press q to quit")


        Do
            Select Case Console.ReadKey().Key
                Case ConsoleKey.Spacebar
                    Console.Clear()
                    GoTo Shuffle
                Case ConsoleKey.Enter

                Case ConsoleKey.Q
            End Select
        Loop
        'DisplayArry()
        'Console.Read()
    End Sub

    'Sub DisplayArry()
    '    Dim row As Integer = 12
    '    Dim column As Integer = 3
    '    Dim formattedString As String
    '    Dim currentArray(row, column) As Boolean
    '    Dim randomColumn As Integer
    '    Dim randomRow As Integer

    '    Randomize()

    '    For i = 1 To 52
    '        randomColumn = CInt(Int(4 * Rnd()))
    '        randomRow = CInt(Int(13 * Rnd()))
    '        If Not currentArray(randomRow, randomColumn) Then
    '            Console.WriteLine($"Row{randomRow}, Column{randomColumn}")
    '        Else
    '            currentArray(randomRow, randomColumn) = True
    '        End If

    '    Next

    '    For i = 0 To row
    '        For j = 0 To column
    '            formattedString = $"{i},{j}"
    '            If currentArray(i, j) Then
    '                Console.WriteLine("T")
    '            Else
    '                Console.WriteLine("F")
    '            End If

    '        Next
    '        Console.WriteLine()
    '    Next
    '    Console.Read()

    'End Sub
End Module
