using System;

namespace tictaktoe2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] myArray = { "o", "p", "o", "q", "o", "e" , "r", "t", "o"};
            //Game newGame = new Game();
            //newGame.WinGame(myArray);
            Game.WinGame(myArray);
            Game.PrintBoard(myArray);
        }
    }
}
