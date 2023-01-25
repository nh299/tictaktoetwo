using System;
using System.Collections.Generic;
using System.Text;

namespace tictaktoe2
{

        public static class Game
        {
            public static void WinGame(string[] board)
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
                else if ((board[2] == board[4] && board[4] == board[8]))
                {
                    win = true;
                    winnerChar = board[2];
                }
                if (win == true)
                {
                    Console.Write(winnerChar + " is the winner!\n");
                }
            }
            public static void PrintBoard(string[] board)
            {
                for (int i = 0; i < board.Length; i++)
                {
                    if (i == 2 || i == 5 || i == 8)
                    {
                        Console.Write(board[i] + "\n");
                    }
                    else
                    {
                        Console.Write(board[i] + "|");
                    }
                }
            }
        }
    }