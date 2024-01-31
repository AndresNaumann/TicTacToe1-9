using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission4Assignment
{
    internal class TicTacToeGame
    {

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



        public void PrintBoard()

        {

            for (int i = 0; i < 3; i++)

            {

                for (int j = 0; j < 3; j++)

                {

                    Console.Write(board[i, j]);

                    if (j < 2) Console.Write(" | ");

                }

                Console.WriteLine();

                if (i < 2) Console.WriteLine("---------");

            }

        }



        public void MakeMove(int row, int col, char player)

        {

            if (row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == ' ')

            {

                board[row, col] = player;

            }

        }



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


