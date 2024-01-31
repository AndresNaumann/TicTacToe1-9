using System;

namespace mission4Assignment
{
    class Driver
    {
        static void Main(string[] args)
        {
            TicTacToeGame game = new TicTacToeGame();
            char currentPlayer = 'X';
            bool gameEnded = false;

            while (!gameEnded)
            {

                Console.Clear();

                // Console.WriteLine("Welcome to Tic-Tac-Toe!");

                game.PrintBoard();

                Console.WriteLine($"Player {currentPlayer}, enter your move (row and column): ");

                int row = int.Parse(Console.ReadLine());

                int col = int.Parse(Console.ReadLine());

                game.MakeMove(row, col, currentPlayer);

                gameEnded = game.CheckForWinner(out char winner);

                if (gameEnded)

                {

                    Console.Clear();

                    game.PrintBoard();

                    Console.WriteLine(winner == ' ' ? "It's a draw!" : $"Player {winner} wins!");

                }

                else

                {

                    currentPlayer = currentPlayer == 'X' ? 'O' : 'X';

                }

            }

        }

    }

}

