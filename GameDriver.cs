
namespace TicTacToe
{
    internal class GameDriver
    {
        private Player PlayerOne { get; }
        private Player PlayerTwo { get; }
        private Board Board { get; }


        public GameDriver()
        {
            PlayerOne = new("X");
            PlayerTwo = new("O");
            Board = new Board();
        }

        public void Run()
        {
            Player currentPlayer = PlayerOne;

            while (true)
            {
                int playerChoice = PromptPlayerForInput(currentPlayer);
                Board.Mark(currentPlayer.Symbol, playerChoice);

                if (Board.IsGameOver()) break;

                currentPlayer = currentPlayer == PlayerOne ? PlayerTwo : PlayerOne;
            }

            Board.Display();

            if (Board.HasWinner)
            {
                Console.WriteLine($"{currentPlayer.Symbol} won!");
            } else
            {
                Console.WriteLine("It's a tie.");
            }
        }

        private int PromptPlayerForInput(Player player)
        {
            int playerChoice;
            Console.WriteLine($"It is {player.Symbol}'s turn");
            
            Board.Display();

            do
            {
                playerChoice = player.SelectSquare();
            } while (Board.IsMarkedAt(playerChoice));

            return playerChoice;
        }
    }

    enum Symbol { X, O }
}
