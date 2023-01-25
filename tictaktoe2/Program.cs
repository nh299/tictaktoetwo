using System;

namespace tictaktoe2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] myArray = { "1", "2", "3", "4", "5", "6" , "7", "8", "9"};
            //Game newGame = new Game();
            //newGame.WinGame(myArray);
            Game.WinGame(myArray);
            Game.PrintBoard(myArray);
        }
    }
}
