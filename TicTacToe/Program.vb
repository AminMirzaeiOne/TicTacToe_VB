Module Program

    Public XO = {" 1 ", " 2 ", " 3 ", " 4 ", " 5 ", " 6 ", " 7 ", " 8 ", " 9 "}

    Sub Main()
        Dim board As TicTacToe.Board = New TicTacToe.Board()
        board.Draw()
        System.Console.ReadKey()
    End Sub

End Module