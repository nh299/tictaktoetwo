using System;

namespace tictaktoe2
{
    class Program
    {
        static void Main(string[] args)
        {

            int turn = 0;
            bool win = false;
            int position;
            string[] board = { "1", "2", "3", "4", "5", "6" , "7", "8", "9"};

            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            while (win == false) 
            {
                if (turn == 0)
                {
                    Console.WriteLine("Player one choose a position");
                    Game.PrintBoard(board);

                    position = int.Parse(Console.ReadLine());

                    if (board[position - 1] != "X" && board[position - 1] != "O")
                    {
                        board[position - 1] = "X";
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose an open spot.");
                    }

                    turn = (turn + 1) % 2;

                }
                else
                {
                    Console.WriteLine("Player two choose a position");
                    Game.PrintBoard(board);

                    position = int.Parse(Console.ReadLine());

                    if (board[position - 1] != "X" && board[position - 1] != "O")
                    {
                        board[position - 1] = "O";
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose an open spot.");
                    }

                    turn = (turn + 1) % 2;
                }
            }
        }
    }
}