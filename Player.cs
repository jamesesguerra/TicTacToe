namespace TicTacToe
{
    internal class Player
    {
        public string Symbol { get; }

        public Player(string symbol)
        {
            Symbol = symbol;
        }

        public int SelectSquare()
        {
            Console.Write("What square do you want to play in? ");
            int selectedSquare = int.Parse(Console.ReadLine()!);
            Console.WriteLine();
            return selectedSquare;
        }
    }
}
