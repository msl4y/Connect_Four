using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace RandomAI.cs
{
    class AI
    {

        //globals
        private int player;
        private int opponent;
        private int ROW;
        private int COL;
        private int boardColums;
        private int boardRows;
        private int[,] board;
        private bool[] fullColumnsList;
        private int movesAmount = 0;
        private int winningAmount = -99999;
        private int fullColumns = 0;
        
        private int[] possibleRows;
        private int[] possibleCols;
        public void findMove(int[,] arr, int p)
        {
            // assignments
            this.board = arr;
            this.player = p;
            if (player == 1)
            {
                opponent = 2;
            }
            else
                opponent = 1;
            boardColums = gameComm.COL;
            boardRows = gameComm.ROW;
            this.fullColumnsList = new bool[boardColums];

            // sees if any of the columns are full, thus cant play in them
            greedySearch(board);
        }

        private void greedySearch(int[,] board)
        {
            int[,] tempBoard = board;
            int tempValue;
            // first, find columns with valid placement
            validCols(board);
            possibleCols = new int[boardColums - fullColumns];
            possibleRows = new int[boardColums - fullColumns];
            findPossibleMoves(board);
            // for every move in possibleMoves, see if it has the most connected pieces
            for (int i = 0; i < movesAmount; i++)
            {
                tempValue = addPiece(tempBoard, possibleRows[i], possibleCols[i]);
                if(tempValue > winningAmount)
                {
                    ROW = possibleRows[i];
                    COL = possibleCols[i];
                }
                // reset the tempBoard back to the original before trying to play another piece.
                tempBoard = board;
            }
        }

        // reports back if a column is full or not
        private void validCols(int[,] board)
        {
            for (int i = 0; i < boardColums; i++)
            {
                if ((board[0, i] == 1) || (board[0, i] == 2))
                {
                    fullColumnsList[i] = true; // column is full
                    fullColumns++;
                }
                else
                    fullColumnsList[i] = false; // column is not full
            }
        }

        // makes the list of all possible moves that can be played
        private void findPossibleMoves(int[,] board)
        {
            for (int col = 0; col < boardColums; col++)
            {
                if (fullColumnsList[col] == false)
                {
                    for (int row = boardRows - 1; row >= 0; row--)
                    {
                        if ((board[row, col] != 1) && (board[row, col] != 2))
                        {
                            possibleRows[col] = row;
                            possibleCols[col] = col;
                            movesAmount++;
                            break;
                        }
                    }
                }
            }
        }

        // temporarily adds a piece to the board and calculates the best amount of pieces are connected to it.
        private int addPiece(int[,] tempBoard, int row, int col)
        {
            tempBoard[row, col] = player;
            int bestValue = -99999;
            int tempValue = 1;
            int maxCol = boardColums;
            int maxRow = boardRows;
            // gets the best value from adding this piece
            // checks all of the surrounding pieces to see if they are player pieces,
            // if they are, it keeps track of how many are in a row.

            // note, we do not check for pieces above as that is impossible.
            // first, check the amount of pieces to the top left
            if (row - 1 >= 0 && col - 1 >= 0)
            {
                if (tempBoard[row - 1, col - 1] == player)
                {
                    tempValue++;
                    for (int i = row - 2, j = col - 2; i >= 0 && j >= 0; i--, j--)
                    {
                        if (tempBoard[i, j] == opponent || tempBoard[i, j] == 0)
                        {
                            break;
                        }
                        else
                            tempValue++;

                    }
                    if (tempValue > bestValue)
                        bestValue = tempValue;
                    tempValue = 1;
                }
            }
            // next, check the amount of pieces to the top right
            if (row - 1 >= 0 && col + 1 < maxCol)
            {
                if (tempBoard[row - 1, col + 1] == player)
                {
                    tempValue++;
                    for (int i = row - 2, j = col + 2; i >= 0 && j < maxCol; i--, j++)
                    {
                        if (tempBoard[i, j] == opponent || tempBoard[i, j] == 0)
                        {
                            break;
                        }
                        else
                            tempValue++;

                    }
                    if (tempValue > bestValue)
                        bestValue = tempValue;
                    tempValue = 1;
                }
            }
            // next, check the amount of pieces to the right
            if (col + 1 < maxCol)
            {
                if (tempBoard[row, col + 1] == player)
                {
                    tempValue++;
                    for (int j = col + 2; j < maxCol; j++)
                    {
                        if (tempBoard[row, j] == opponent || tempBoard[row, j] == 0)
                        {
                            break;
                        }
                        else
                            tempValue++;

                    }
                    if (tempValue > bestValue)
                        bestValue = tempValue;
                    tempValue = 1;
                }
            }
            // next, check the amount of pieces to the bottom right
            if (row + 1 < maxRow && col + 1 < maxCol)
            {
                if (tempBoard[row + 1, col + 1] == player)
                {
                    tempValue++;
                    for (int i = row + 2, j = col + 2; i < maxRow && j < maxCol; i++, j++)
                    {
                        if (tempBoard[i, j] == opponent || tempBoard[i, j] == 0)
                        {
                            break;
                        }
                        else
                            tempValue++;

                    }
                    if (tempValue > bestValue)
                        bestValue = tempValue;
                    tempValue = 1;
                }
            }
            // next, check the amount of pieces to the bottom
            if (row + 1 < maxRow)
            {
                if (tempBoard[row + 1, col] == player)
                {
                    tempValue++;
                    for (int i = row + 2; i < maxRow; i++)
                    {
                        if (tempBoard[i, col] == opponent || tempBoard[i, col] == 0)
                        {
                            break;
                        }
                        else
                            tempValue++;

                    }
                    if (tempValue > bestValue)
                        bestValue = tempValue;
                    tempValue = 1;
                }
            }
            // next, check the amount of pieces to the bottom left
            if (row + 1 < maxRow && col - 1 >= 0)
            {
                if (tempBoard[row + 1, col - 1] == player)
                {
                    tempValue++;
                    for (int i = row + 2, j = col - 2; i < maxRow && j >= 0; i++, j--)
                    {
                        if (tempBoard[i, j] == opponent || tempBoard[i, j] == 0)
                        {
                            break;
                        }
                        else
                            tempValue++;

                    }
                    if (tempValue > bestValue)
                        bestValue = tempValue;
                    tempValue = 1;
                }
            }
            // next, check the amount of pieces to the left
            if (col - 1 >= 0)
            {
                if (tempBoard[row, col - 1] == player)
                {
                    tempValue++;
                    for (int j = col - 2; j >= 0; j--)
                    {
                        if (tempBoard[row, j] == opponent || tempBoard[row, j] == 0)
                        {
                            break;
                        }
                        else
                            tempValue++;

                    }
                    if (tempValue > bestValue)
                        bestValue = tempValue;
                    tempValue = 1;
                }
            }

            //sends back the best value we calculated.
            return bestValue;
        }
        
        // returns the row to be played
        public int getRow()
        {
            return ROW;
        }
        // returns the col to be played
        public int getCol()
        {
            return COL;
        }
    }
}

