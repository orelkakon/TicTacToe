using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class GameBoard
    {
        private char[,] Board;
        private char Turn;
        public GameBoard()
        {
            Board = new char[3,3];
            ResetBoard();
            WhoStart();
        }

        private void WhoStart()
        {
            Random rand = new Random();
            int r = rand.Next(2);
            if (r == 0)
                Turn = 'X';
            else
                Turn = 'O';
        }

        private void ResetBoard()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Board[i, j] = ' ';
                }
            }
        }

        public string GetWinner()
        {
            if (Board[0, 0] == Board[0, 1] && Board[0, 1] == Board[0, 2] && (Board[0, 0] == 'X' || Board[0, 0] == 'O'))
                return Board[0, 0] + "";
            else if (Board[1, 0] == Board[1, 1] && Board[1, 1] == Board[1, 2] && (Board[1, 0] == 'X' || Board[1, 0] == 'O'))
                return Board[1, 0] + "";
            else if (Board[2, 0] == Board[2, 1] && Board[2, 1] == Board[2, 2] && (Board[2, 0] == 'X' || Board[2, 0] == 'O'))
                return Board[2, 0] + "";

            else if (Board[0, 0] == Board[1, 0] && Board[1, 0] == Board[2, 0] && (Board[0, 0] == 'X' || Board[0, 0] == 'O'))
                return Board[0, 0] + "";
            else if (Board[0, 1] == Board[1, 1] && Board[1, 1] == Board[2, 1] && (Board[0, 1] == 'X' || Board[0, 1] == 'O'))
                return Board[0, 1] + "";
            else if (Board[0, 2] == Board[1, 2] && Board[1, 2] == Board[2, 2] && (Board[0, 2] == 'X' || Board[0, 2] == 'O'))
                return Board[0, 2] + "";

            else if (Board[0, 0] == Board[1, 1] && Board[1, 1] == Board[2, 2] && (Board[0, 0] == 'X' || Board[0, 0] == 'O'))
                return Board[0, 0] + "";
            else if (Board[0, 2] == Board[1, 1] && Board[1, 1] == Board[2, 0] && (Board[0, 2] == 'X' || Board[0, 2] == 'O'))
                return Board[0, 2] + "";
            else
                return "Tie";
        }

        public char GetTurn()
        {
            return Turn;
        }

        public void SetTurn()
        {
            if (Turn == 'X')
                Turn = 'O';
            else
                Turn = 'X';
        }

        public void PressButton(int x , int y , char sign)
        {
            Board[x, y] = sign;
        }

        internal string GetPaintCells()
        {
            if (Board[0, 0] == Board[0, 1] && Board[0, 1] == Board[0, 2] && (Board[0, 0] == 'X' || Board[0, 0] == 'O'))
                return "000102";
            else if (Board[1, 0] == Board[1, 1] && Board[1, 1] == Board[1, 2] && (Board[1, 0] == 'X' || Board[1, 0] == 'O'))
                return "101112";
            else if (Board[2, 0] == Board[2, 1] && Board[2, 1] == Board[2, 2] && (Board[2, 0] == 'X' || Board[2, 0] == 'O'))
                return "202120";

            else if (Board[0, 0] == Board[1, 0] && Board[1, 0] == Board[2, 0] && (Board[0, 0] == 'X' || Board[0, 0] == 'O'))
                return "001020";
            else if (Board[0, 1] == Board[1, 1] && Board[1, 1] == Board[2, 1] && (Board[0, 1] == 'X' || Board[0, 1] == 'O'))
                return "011121";
            else if (Board[0, 2] == Board[1, 2] && Board[1, 2] == Board[2, 2] && (Board[0, 2] == 'X' || Board[0, 2] == 'O'))
                return "021222";

            else if (Board[0, 0] == Board[1, 1] && Board[1, 1] == Board[2, 2] && (Board[0, 0] == 'X' || Board[0, 0] == 'O'))
                return "001122";
            else if (Board[0, 2] == Board[1, 1] && Board[1, 1] == Board[2, 0] && (Board[0, 2] == 'X' || Board[0, 2] == 'O'))
                return "021120";
            else
                return null;
        }
    }
}
