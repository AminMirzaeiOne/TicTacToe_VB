﻿Module Program

    Public XO = {" 1 ", " 2 ", " 3 ", " 4 ", " 5 ", " 6 ", " 7 ", " 8 ", " 9 "}

    Sub Main()
        Dim board As TicTacToe.Board = New TicTacToe.Board()
        Dim player = 1
        Dim temp = 0


        For i = 0 To 8

            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(" Player1:X and Player2:O")
            Console.ForegroundColor = ConsoleColor.Gray
            board.Draw()

            If temp <> 1 Then

                If player Mod 2 = 0 Then
                    Console.WriteLine(" Turn Player O " & vbLf)
                Else
                    Console.WriteLine(" Turn Player X " & vbLf)
                End If

                Console.Write(" Enter Row No.: ")
                Dim r As Integer = Convert.ToInt32(Console.ReadLine())

                If r > 9 OrElse r <= 0 Then
                    Console.WriteLine(" please Enter number between 1 to 9")
                    Console.Write(" Enter Row No.: ")
                    r = Convert.ToInt32(Console.ReadLine())
                End If



                If XO(r - 1) IsNot " O " AndAlso XO(r - 1) IsNot " X " Then
                    If player Mod 2 = 0 Then


                        XO(r - 1) = " O "

                        player += 1
                    Else
                        XO(r - 1) = " X "
                        player += 1
                    End If
                Else
                    Console.WriteLine(" Sorry this row and column is filled " & vbLf & " Please again Enter row & column")


                    Console.ReadKey()
                End If
                Console.Clear()
                board.Draw()

                temp = check()
            End If

        Next

        If temp = 1 Then
            Console.ForegroundColor = ConsoleColor.Magenta
            Console.WriteLine(" Player {0} has won", player Mod 2 + 1)
        Else
            Console.WriteLine("The game ended without a winner")
        End If



        Console.ReadKey()

    End Sub

    Private Function check() As Integer
        If XO(0) Is XO(1) AndAlso XO(1) Is XO(2) OrElse XO(3) Is XO(4) AndAlso XO(4) Is XO(5) OrElse XO(6) Is XO(7) AndAlso XO(7) Is XO(8) Then
            Return 1

        ElseIf XO(0) Is XO(3) AndAlso XO(3) Is XO(6) OrElse XO(1) Is XO(4) AndAlso XO(4) Is XO(7) OrElse XO(2) Is XO(5) AndAlso XO(5) Is XO(8) Then
            Return 1

        ElseIf XO(0) Is XO(4) AndAlso XO(4) Is XO(8) OrElse XO(2) Is XO(4) AndAlso XO(4) Is XO(6) Then
            Return 1
        Else
            Return 0
        End If

    End Function


End Module