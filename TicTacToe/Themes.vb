Module Themes
    Public Property BackColor As System.ConsoleColor = System.ConsoleColor.Black
    Public Property ForeColor As System.ConsoleColor = System.ConsoleColor.White
    Public Property BoardColor As System.ConsoleColor = ConsoleColor.Cyan
    Public Property PlayerOneColor As System.ConsoleColor = ConsoleColor.Blue
    Public Property PlayerTwoColor As System.ConsoleColor = ConsoleColor.Red

    Private theme As String = "dark"

    Public Sub QuestionTheme()
ThemeQuestion:
        System.Console.Write("Enter A Theme (Light or Dark) : ")
        Dim themeQ As String = System.Console.ReadLine().ToLower()
        theme = themeQ
        Select Case themeQ
            Case "light"
                System.Console.BackgroundColor = ConsoleColor.White
                System.Console.Clear()
                System.Console.ForegroundColor = ConsoleColor.Black
            Case "dark"
                System.Console.BackgroundColor = ConsoleColor.Black
                System.Console.Clear()
                System.Console.ForegroundColor = ConsoleColor.White
            Case Else
                System.Console.ForegroundColor = ConsoleColor.Red
                System.Console.WriteLine("The color entered is invalid")
                System.Console.ResetColor()
                System.Console.ReadKey()
                GoTo ThemeQuestion
        End Select
    End Sub

    Public Sub QuestionBoardColor()
BoardQuestion:
        System.Console.Write("Enter the color of the board (Blue , Red , Green , Magenta , White , Black , Yellow) : ")
        Dim color As String = System.Console.ReadLine().ToLower()

        Select Case color
            Case "blue"
                TicTacToe.Themes.BoardColor = ConsoleColor.DarkCyan
            Case "red"
                TicTacToe.Themes.BoardColor = ConsoleColor.Red
            Case "green"
                TicTacToe.Themes.BoardColor = ConsoleColor.Green
            Case "magenta"
                TicTacToe.Themes.BoardColor = ConsoleColor.Magenta
            Case "yellow"
                TicTacToe.Themes.BoardColor = ConsoleColor.Yellow
            Case "black"
                TicTacToe.Themes.BoardColor = ConsoleColor.Black
            Case "white"
                TicTacToe.Themes.BoardColor = ConsoleColor.White
            Case Else
                System.Console.ForegroundColor = ConsoleColor.Red
                System.Console.WriteLine("The color entered is invalid")
                If (theme = "light") Then
                    TicTacToe.Themes.ForeColor = ConsoleColor.Black
                ElseIf (theme = "dark") Then
                    TicTacToe.Themes.ForeColor = ConsoleColor.White
                End If
                System.Console.ReadKey()
                GoTo BoardQuestion
        End Select
    End Sub

    Public Sub QuestionPlayerOneColor()
PlayerOneQuestion:
        System.Console.Write("Enter the color of the Player One (Blue , Red , Green , Magenta , White , Black , Yellow) : ")
        Dim color As String = System.Console.ReadLine().ToLower()

        Select Case color
            Case "blue"
                TicTacToe.Themes.PlayerOneColor = ConsoleColor.DarkCyan
            Case "red"
                TicTacToe.Themes.PlayerOneColor = ConsoleColor.Red
            Case "green"
                TicTacToe.Themes.PlayerOneColor = ConsoleColor.Green
            Case "magenta"
                TicTacToe.Themes.PlayerOneColor = ConsoleColor.Magenta
            Case "yellow"
                TicTacToe.Themes.PlayerOneColor = ConsoleColor.Yellow
            Case "black"
                TicTacToe.Themes.PlayerOneColor = ConsoleColor.Black
            Case "white"
                TicTacToe.Themes.PlayerOneColor = ConsoleColor.White
            Case Else
                System.Console.ForegroundColor = ConsoleColor.Red
                System.Console.WriteLine("The color entered is invalid")
                If (theme = "light") Then
                    TicTacToe.Themes.ForeColor = ConsoleColor.Black
                ElseIf (theme = "dark") Then
                    TicTacToe.Themes.ForeColor = ConsoleColor.White
                End If
                System.Console.ReadKey()
                GoTo PlayerOneQuestion
        End Select
    End Sub

    Public Sub QuestionPlayerTwoColor()
PlayerTwoQuestion:
        System.Console.Write("Enter the color of the Player One (Blue , Red , Green , Magenta , White , Black , Yellow) : ")
        Dim color As String = System.Console.ReadLine().ToLower()

        Select Case color
            Case "blue"
                TicTacToe.Themes.PlayerTwoColor = ConsoleColor.DarkCyan
            Case "red"
                TicTacToe.Themes.PlayerTwoColor = ConsoleColor.Red
            Case "green"
                TicTacToe.Themes.PlayerTwoColor = ConsoleColor.Green
            Case "magenta"
                TicTacToe.Themes.PlayerTwoColor = ConsoleColor.Magenta
            Case "yellow"
                TicTacToe.Themes.PlayerTwoColor = ConsoleColor.Yellow
            Case "black"
                TicTacToe.Themes.PlayerTwoColor = ConsoleColor.Black
            Case "white"
                TicTacToe.Themes.PlayerTwoColor = ConsoleColor.White
            Case Else
                System.Console.ForegroundColor = ConsoleColor.Red
                System.Console.WriteLine("The color entered is invalid")
                If (theme = "light") Then
                    TicTacToe.Themes.ForeColor = ConsoleColor.Black
                Else
                    TicTacToe.Themes.ForeColor = ConsoleColor.White
                End If
                System.Console.ReadKey()
                GoTo PlayerTwoQuestion
        End Select
    End Sub

End Module
