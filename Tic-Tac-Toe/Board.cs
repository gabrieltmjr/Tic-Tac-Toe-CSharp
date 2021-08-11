using System;

namespace Tic_Tac_Toe
{
    public class Board
    {
        private char[] board;

        public Board() {
            board = new char[9];
            sbyte j = 49; //ascii code for 1
            for (sbyte i = 0; i < board.Length; i++) {
                board[i] = (char)j; 
                j++;
            }
        }

        protected void PrintBoard()
        {
            sbyte aux = 0;
            while (aux < 9)
            {
                Console.WriteLine("[" + board[aux] + "|" + board[aux + 1] + "|" + board[aux + 2] + "]");
                aux += 3;
            }
        }

        protected bool PlaceSymbol(char symbol, sbyte index)
        {
            index--;
            if (board[index] == 'X' || board[index] == 'O') {
                return false;
            }

            board[index] = symbol;
            return true;
        }

        private bool CheckWinnerVertical(char symbol)
        {
            if (board[0] == symbol && board[3] == symbol && board[6] == symbol)
            {
                return true;
            }

            if (board[1] == symbol && board[4] == symbol && board[7] == symbol)
            {
                return true;
            }

            if (board[2] == symbol && board[5] == symbol && board[8] == symbol)
            {
                return true;
            }

            return false;
        }

        private bool CheckWinnerHorizontal(char symbol)
        {
            if (board[0] == symbol && board[1] == symbol && board[2] == symbol)
            {
                return true;
            }

            if (board[3] == symbol && board[4] == symbol && board[5] == symbol)
            {
                return true;
            }

            if (board[6] == symbol && board[7] == symbol && board[8] == symbol)
            {
                return true;
            }

            return false;
        }

        private bool CheckWinnerDiagonal(char symbol)
        {
            if (board[0] == symbol && board[4] == symbol && board[8] == symbol)
            {
                return true;
            }

            if (board[2] == symbol && board[4] == symbol && board[6] == symbol)
            {
                return true;
            }

            return false;
        }

        protected bool CheckWinner(char symbol)
        {
            if (CheckWinnerVertical(symbol) || CheckWinnerDiagonal(symbol) || 
                CheckWinnerHorizontal(symbol)) {
                return true;
            }

            return false;
        }

        protected bool CheckDraw()
        {
            sbyte checkDraw = 0;
            foreach (var position in board) {
                if (position == 'X' || position == 'O') {
                    checkDraw++;
                }
            }

            if (checkDraw == 9) { return true; }

            return false;
        }
        
        
    }
}