using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This program is a tic tac toe game where users can play each other in a game of tic tac toe!

namespace TicTacToe
{
    internal class TicTacToeGame
    {
        // 2D array representing the game board. Each cell can be ' ', 'X', or 'O'.
        private char[,] board = new char[3, 3];

        public TicTacToeGame()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }
        }



        //This will print the current state of the game board
        public void PrintBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j]); // Print the value of the board cell
                    if (j < 2) Console.Write(" | "); // Print vertical separators between cells
                }
                Console.WriteLine();
                if (i < 2) Console.WriteLine("---------"); // Print horizontal separators between rows
            }
        }


        // This function attempts to place the player's marker ('X' or 'O') on the board at the specified row and column.
        public void MakeMove(int row, int col, char player)
        {
            if (row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == ' ')
            {
                board[row, col] = player;
            }
        }

        // This function checks the board to see if there is a winner, a draw, or if the game should continue.
        public bool CheckForWinner(out char winner)
        {
            // Check rows, columns, and diagonals for a winner
            for (int i = 0; i < 3; i++)
            {
                // Rows
                if (board[i, 0] != ' ' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    winner = board[i, 0];
                    return true;
                }

                // Columns
                if (board[0, i] != ' ' && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    winner = board[0, i];
                    return true;
                }
            }

            // Diagonals
            if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                winner = board[0, 0];
                return true;
            }

            if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                winner = board[0, 2];
                return true;
            }

            // Check for a draw
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                    {
                        winner = ' ';
                        return false;
                    }
                }
            }

            winner = ' ';
            return true;
        }
    }
}
