

namespace TicTacToe
{
    internal class Board
    {
        private string[] _matrix = new string[]
            {
                " ", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

        public bool HasWinner { get; private set;  } = false;

        public void Display()
        {
            Console.WriteLine(@$"
                 {_matrix[6]} | {_matrix[7]} | {_matrix[8]}
                ---+---+---
                 {_matrix[3]} | {_matrix[4]} | {_matrix[5]}
                ---+---+---
                 {_matrix[0]} | {_matrix[1]} | {_matrix[2]}
            ");
        }

        public bool IsGameOver()
        {
            if ((_matrix[0] == _matrix[1] && _matrix[1] == _matrix[2] && _matrix[0] != " ") ||
                (_matrix[3] == _matrix[4] && _matrix[4] == _matrix[5] && _matrix[3] != " ") ||
                (_matrix[6] == _matrix[7] && _matrix[7] == _matrix[8] && _matrix[6] != " ") ||
                (_matrix[0] == _matrix[3] && _matrix[3] == _matrix[6] && _matrix[0] != " ") ||
                (_matrix[1] == _matrix[4] && _matrix[4] == _matrix[7] && _matrix[1] != " ") ||
                (_matrix[2] == _matrix[5] && _matrix[5] == _matrix[8] && _matrix[2] != " ") ||
                (_matrix[0] == _matrix[4] && _matrix[4] == _matrix[8] && _matrix[0] != " ") ||
                (_matrix[2] == _matrix[4] && _matrix[4] == _matrix[6] && _matrix[2] != " "))
            {
                HasWinner = true;
                return true;
            } else if (!_matrix.Contains(" ")) {
                return true;
            }
            return false;
        }

        public bool IsMarkedAt(int square)
        {
            if (_matrix[square - 1] != " ")
            {
                Console.WriteLine("Square has already been taken!");
                return true;
            }
            return false;
        }

        public void Mark(string symbol, int square)
        {
            _matrix[square - 1] = symbol;
        }

    }
}
