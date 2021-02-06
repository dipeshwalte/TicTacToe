using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToe
    {
        char[] gameBoard;
        public char playerCharacter;
        public char computerCharacter;
        public TicTacToe()
        {
            gameBoard = new char[10];
            for (int i = 1; i < 10; i++)
            {
                gameBoard[i] = i.ToString()[0];
            }
        }
        public void DisplayBoard()
        {
            Console.WriteLine("-------------");
            for (int i = 1; i < 10; i++)
            {
                Console.Write($" {gameBoard[i]} ");
                if (i%3==0)
                {
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("-------------");
        }
        public void ChooseLetter()
        {
            Console.WriteLine("Choose Between X and O, Type your Choice");
            char inputChar = Console.ReadLine()[0];
            if (inputChar == 'X')
            {
                playerCharacter = inputChar;
                computerCharacter = 'O';
            }
            else if (inputChar == 'O')
            {
                playerCharacter = inputChar;
                computerCharacter = 'X';
            }
            else
            {
                Console.WriteLine("Choose Proper Character");
            }
        }
    }
}
