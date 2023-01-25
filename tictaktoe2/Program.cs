using System;

namespace tictaktoe2
{
    class Program
    {
        static void Main(string[] args)
        {

            int turn = 0;
            string playerOne = "";
            string playerTwo = "";
            bool win = false;
            int position;
            string[] board = new string[9];

            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            while (win == false) 
            {
                if (turn == 0)
                {
                    Console.WriteLine("Player one choose a position");
                    playerOne = Console.ReadLine();

                    // choice = int.Parse(Console.ReadLine());
                    for (int i = 0; i < board.Length; i++)
                    {
                        position = int.Parse(Console.ReadLine());

                        if (board[position] != "X" && board[position] != "O")
                        {
                            board[position] = "X";
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("That spot is already taken. Please choose an open spot.");
                        }

                        turn = (turn + 1) % 2;
                    }
                }
                else
                {
                    Console.WriteLine("Player two choose a position");
                    playerOne = Console.ReadLine();

                    // choice = int.Parse(Console.ReadLine());
                    for (int i = 0; i < board.Length; i++)
                    {
                        position = int.Parse(Console.ReadLine());

                        if (board[position] != "X" && board[position] != "O")
                        {
                            board[position] = "X";
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("That spot is already taken. Please choose an open spot.");
                        }

                        turn = (turn + 1) % 2;
                    }
                }
            }
        string[] myArray = { "o", "p", "o", "q", "o", "e" , "r", "t", "o"};
        //Game newGame = new Game();
        //newGame.WinGame(myArray);
        Game.WinGame(myArray);
        Game.PrintBoard(myArray);
        }
    }
}