Module Options
    Enum BoardSizes
        Small = 3
        Medium = 6
        Large = 9
    End Enum

    Public Property CharOne As Char = "x"
    Public Property CharTwo As Char = "o"
    Public Property BoardSize As TicTacToe.BoardSizes = BoardSizes.Small

    Public Sub QuestionCharOne()
        System.Console.Write("Enter the one character for example, 'x' : ")
        TicTacToe.Options.CharOne = System.Console.ReadLine().Trim()
    End Sub

    Public Sub QuestionCharTwo()
        System.Console.Write("Enter the two character for example, 'o' : ")
        TicTacToe.Options.CharTwo = System.Console.ReadLine().Trim()
    End Sub

    Public Sub QuestionBoardSize()
QBoardSize:
        System.Console.Write("Specify the page size (Small , Medium , Large) : ")
        Dim size As String = System.Console.ReadLine().Trim()
        Select Case size
            Case "small".ToLower()
                TicTacToe.Options.BoardSize = BoardSizes.Small
            Case "medium".ToLower()
                TicTacToe.Options.BoardSize = BoardSizes.Medium
            Case "large".ToLower()
                TicTacToe.Options.BoardSize = BoardSizes.Large
            Case Else
                System.Console.Write("The size is invalid. Please enter one of the three items small, medium or large")
                System.Console.ReadKey()
                GoTo QBoardSize
        End Select
    End Sub



End Module
