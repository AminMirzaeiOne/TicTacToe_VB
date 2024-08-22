Public Class Board
    Public Sub Draw()
        Console.WriteLine()
        Console.ForegroundColor = Themes.BoardColor
        Console.WriteLine("                ")
        Console.WriteLine("   ╔═══╦═══╦═══╗")
        Console.WriteLine("   ║{0}║{1}║{2}║", TicTacToe.Program.XO(0), TicTacToe.Program.XO(1), TicTacToe.Program.XO(2))
        Console.WriteLine("   ╠═══╬═══╬═══╣")
        Console.WriteLine("   ║{0}║{1}║{2}║", TicTacToe.Program.XO(3), TicTacToe.Program.XO(4), TicTacToe.Program.XO(5))
        Console.WriteLine("   ╠═══╬═══╬═══╣")
        Console.WriteLine("   ║{0}║{1}║{2}║", TicTacToe.Program.XO(6), TicTacToe.Program.XO(7), TicTacToe.Program.XO(8))
        Console.WriteLine("   ╚═══╩═══╩═══╝")
        Console.WriteLine()
    End Sub
End Class
