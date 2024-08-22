Module Program

    Public XO = {" 1 ", " 2 ", " 3 ", " 4 ", " 5 ", " 6 ", " 7 ", " 8 ", " 9 "}
    Private color As System.ConsoleColor = ConsoleColor.White
    Sub Main()
        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Enter your item is menu (play or info or theme) : ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        Dim x As String = Console.ReadLine().ToLower().Trim()
        If x = "play" Then
            Play()
        ElseIf x = "info" Then
            Info()
        ElseIf x = "theme" Then
            ThemeSettings()
            Play()
        Else
            System.Console.WriteLine("Error")
        End If
        Console.ReadKey()

    End Sub

    Sub Play()
        Dim board As TicTacToe.Board = New TicTacToe.Board()
        Dim player = 1
        Dim temp = 0


        For i = 0 To 8

            Console.Clear()
            Console.ForegroundColor = TicTacToe.Themes.PlayerOneColor
            Console.Write(" Player1 : X")
            System.Console.ForegroundColor = TicTacToe.Themes.ForeColor
            System.Console.Write(" - ")
            System.Console.ForegroundColor = TicTacToe.Themes.PlayerTwoColor
            System.Console.WriteLine("Player2 : O")
            board.Draw()

            If temp <> 1 Then

                If player Mod 2 = 0 Then
                    System.Console.ForegroundColor = TicTacToe.Themes.PlayerTwoColor
                    Console.WriteLine(" Turn Player O " & vbLf)
                Else
                    System.Console.ForegroundColor = TicTacToe.Themes.PlayerOneColor
                    Console.WriteLine(" Turn Player X " & vbLf)
                End If
                System.Console.ForegroundColor = color


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
            Info()
        Else
            Console.WriteLine("The game ended without a winner")
            Info()
        End If

    End Sub

    Sub Info()
        ' Display a separator line with Magenta foreground color
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")

        ' Set the foreground color to Red for programmer information
        System.Console.ForegroundColor = ConsoleColor.Red

        ' Display programmer information
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")
    End Sub

    Sub ThemeSettings()
        TicTacToe.Themes.QuestionTheme()
        color = TicTacToe.Themes.ForeColor
        TicTacToe.Themes.QuestionBoardColor()
        TicTacToe.Themes.QuestionPlayerOneColor()
        TicTacToe.Themes.QuestionPlayerTwoColor()

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