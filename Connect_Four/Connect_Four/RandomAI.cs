using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_Four
{
    class RandomAI
    {
        private int player;
        private int ROW;
        private int COL;
        private int boardColums;
        private int boardRows;
        private int[,] board;
        private bool[] fullColumnsList;

        public void findMove(int[,] arr, int p)
        {
            // assignments
            this.board = arr;
            this.player = p;
            boardColums = GameBoard.COLS;
            boardRows = GameBoard.ROWS;
            this.fullColumnsList = new bool[boardColums];

            // sees if any of the columns are full, thus cant play in them
            fullCols();

            // picks a random column to play in
            int playCol = pickCol();

            // find the row to play in for the chosen col
            int playRow = pickRow(playCol);

            //sets the ROW and COL of the move
            ROW = playRow;
            COL = playCol;
        }

        // finds the amount of columns that are full in the games, so we don't play there
        private void fullCols()
        {
            for (int i = 0; i < boardColums; i++)
            {
                if ((board[0, i] == 1) || (board[0, i] == 2))
                    fullColumnsList[i] = true;
                else
                    fullColumnsList[i] = false;
            }
        }

        // picks a random column thats available to be played in
        private int pickCol()
        {
            bool valid = false;
            int c = -1;
            while (valid == false)
            {
                Random rnd = new Random();
                c = rnd.Next(boardColums);
                if(fullColumnsList[c] == false)
                {
                    valid = true;
                }
            }
            return c;
        }

        // finds the bottom row to play in of the chosen column
        private int pickRow(int col)
        {
            for(int i = boardRows - 1; i >= 0; i--)
            {
                if((board[i,col] != 1) && (board[i, col] != 2))
                {
                    return i;
                }
            }
            return -1;
        }

        // returns the row chosen
        public int getRow()
        {
            return ROW;
        }

        // returns the col chosen
        public int getCol()
        {
            return COL;
        }
    }
}
