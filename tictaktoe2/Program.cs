using System;

namespace tictaktoe2
{
    class Program
    {
        static void Main(string[] args)
        {

            // initialize vars, turn indicates if we display the welcome message, 
            // win of false means continue with the game, position is the player's choice of where to put their X or O
            // initialize the board array so it displays simply the options for players to choose for their turn
            int turn = 0;
            bool win = false;
            int position;
            string[] board = { "1", "2", "3", "4", "5", "6" , "7", "8", "9"};

            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            // Loop through this until someone has won the game
            while (win == false) 
            {
                if (turn == 0)
                {
                    // Receive as input player 1's choice position
                    Console.WriteLine("Player one (X) choose a position");
                    //call the printboard method from the game class to display the board of options for moving
                    Game.PrintBoard(board);

                    position = int.Parse(Console.ReadLine());

                    // Make sure a player has not already chosen the desired square in a previous turn
                    if (board[position - 1] != "X" && board[position - 1] != "O")
                    {
                        board[position - 1] = "X";
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose an open spot.");
                    }

                    // incrememnt the number of turns 
                    turn = (turn + 1) % 2;

                }
                else
                {
                    // same process for player two as above for player 1
                    Console.WriteLine("Player two (O) choose a position");
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

                // check to see if either player has won the game with the last move with the method in the game class
                string output = Game.WinGame(board);

                // output is initialized as "" and only changes when someone has won
                if (output == "")
                {
                    win = false;
                }
                else
                {

                    // if the method returns an output, someone has won, so we change win to true to get out
                    // of the while loop and print the final board along with the output of who won!
                    win = true;
                    Game.PrintBoard(board);
                    Console.WriteLine(output);
                }
            }
           
        }
    }
}