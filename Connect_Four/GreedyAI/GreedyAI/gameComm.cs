using System;
using System.IO;
namespace RandomAI.cs
{
    class gameComm
    {
        public static int ROW, COL;
        private static int[,] board;
        static void Main(string[] args)
        {
            // gets the board and places it in an array
            StreamReader inFile = new StreamReader("board.txt");
            string turnString = inFile.ReadLine();
            string rowString = inFile.ReadLine();
            string colString = inFile.ReadLine();

            int turn = Convert.ToInt32(turnString);
            ROW = Convert.ToInt32(rowString);
            COL = Convert.ToInt32(colString);

            board = new int[ROW, COL];
            for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL; j++)
                {
                    string temp = inFile.ReadLine();
                    int x = Convert.ToInt32(temp);
                    board[i, j] = x;
                }
            }
            inFile.Close();

            // creates the AI
            AI ai = new AI();
            ai.findMove(board, turn);

            // gets and prints the move
            int aiRow = ai.getRow();
            int aiCol = ai.getCol();

            //output the move to a text file
            StreamWriter outFile = new StreamWriter("move.txt");
            outFile.WriteLine(aiRow);
            outFile.WriteLine(aiCol);
            outFile.Close();
        }
    }
}
