using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Tic Tac Toe !");
            TicTacToe game = new TicTacToe();
            game.DisplayBoard();
            game.ChooseLetter();
            Console.WriteLine("Player chose : "+game.playerCharacter);
            Console.WriteLine("Computer chose : "+game.computerCharacter);
        }
    }
}
