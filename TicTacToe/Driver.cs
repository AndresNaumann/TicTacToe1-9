using System;

namespace TicTacToe
{
    class Driver
    {
        static void Main(string[] args)
        {
            //Creating a new Tic Tac Toe instance
            TicTacToeGame game = new TicTacToeGame();

            //Set initial player to 'X'
            char currentPlayer = 'X';
            bool gameEnded = false;

            //Continue the game until it ends using a while loop
            while (!gameEnded)
            {

                Console.Clear();

                Console.WriteLine("Welcome to Tic-Tac-Toe!");

                //Print the current state of the board
                game.PrintBoard();

                //Explain the directions for the user
                Console.WriteLine("The board is set up so (0,0) would be in the top left corner");
                Console.WriteLine("Enter the row you would like and then hit 'enter.' After that, select the column you would like");
                Console.WriteLine($"Player {currentPlayer}, enter your move (row): ");

                int row;
                while (true)
                {
                    Console.WriteLine("Enter the row (0, 1, or 2):");
                    if (int.TryParse(Console.ReadLine(), out row) && row >= 0 && row <= 2)
                    {
                        break; // Exit the loop if the input is valid.
                    }
                    Console.WriteLine("Invalid input. Please enter 0, 1, or 2.");
                }

                int column;
                while (true)
                {
                    Console.WriteLine("Enter the column (0, 1, or 2):");
                    if (int.TryParse(Console.ReadLine(), out column) && column >= 0 && column <= 2)
                    {
                        break; // Exit the loop if the input is valid.
                    }
                    Console.WriteLine("Invalid input. Please enter 0, 1, or 2.");
                }

                //Make the move on the actual game board
                game.MakeMove(row, column, currentPlayer);

                gameEnded = game.CheckForWinner(out char winner);

                // If the game has ended, clear the console, print the final board, and display the result.
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
