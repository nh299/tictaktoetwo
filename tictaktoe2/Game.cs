using System;
using System.Collections.Generic;
using System.Text;

namespace tictaktoe2
{

    // game class
        public static class Game
        {
            // this method WinGame takes a string array to check to see the possible options of 3 in
            // a row, to see if a player has won the game. It keeps track of the winning character (x or o)
            // to be displayed at the end so the winner is identified
            public static string WinGame(string[] board)
            {
                bool win = false;
                string winnerChar = "";

                if ((board[0] == board[1] && board[1] == board[2]))
                {
                    win = true;
                    winnerChar = board[0];
                }
                else if ((board[3] == board[4] && board[4] == board[5]))
                {
                    win = true;
                    winnerChar = board[3];
                }
                else if ((board[0] == board[3] && board[3] == board[6]))
                {
                    win = true;
                    winnerChar = board[0];
                }
                else if ((board[6] == board[7] && board[7] == board[8]))
                {
                    win = true;
                    winnerChar = board[6];
                }
                else if ((board[1] == board[4] && board[4] == board[7]))
                {
                    win = true;
                    winnerChar = board[1];
                }
                else if ((board[2] == board[5] && board[5] == board[8]))
                {
                    win = true;
                    winnerChar = board[2];
                }
                else if ((board[0] == board[4] && board[4] == board[8]))
                {
                    win = true;
                    winnerChar = board[0];
                }
                else if ((board[2] == board[4] && board[4] == board[6]))
                {
                    win = true;
                    winnerChar = board[2];
                }
                if (win == true)
                {
                // this is the output if there is a winner
                    return winnerChar + " is the winner!\n";
                }
                else
                {
                    return "";
                }
            }
               // This method inherits a string array and prints the tic tac toe board according to the values in that array
               // it doesn't return a value, just prints the board to the screen
            public static void PrintBoard(string[] board)
            {
                for (int i = 0; i < board.Length; i++)
                {
                    // if the array is at position 2, 5, or 8 a newline is needed to begin the next row of the board
                    if (i == 2 || i == 5 || i == 8)
                    {
                        Console.Write(board[i] + "\n");
                    }
                    else
                    {
                    // This '|' creates the outline of the tic tac toe board
                        Console.Write(board[i] + "|");
                    }
                }
            }
        }
    }