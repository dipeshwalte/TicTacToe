using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToe
    {
        char[] gameBoard;
        public TicTacToe()
        {
            gameBoard = new char[10];
            for (int i = 1; i < 10; i++)
            {
                gameBoard[i] = '-';
            }
        }

    }
}
