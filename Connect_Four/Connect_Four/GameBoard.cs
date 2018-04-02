using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Connect_Four
{
    public partial class GameBoard : Form
    {
        public static int ROWS;
        public static int COLS;
        int HEIGHT, WIDTH;
        int diff;
        private Rectangle[] columns;
        private int[,] board;
        private int turn;     // 1 is red, 2 is yellow
        private int turnCounter = 0;

        public GameBoard(int humanPlayers, int difficulty, int rows, int cols)
        {
            InitializeComponent();
            HEIGHT = this.Height;
            WIDTH = this.Width;
            ROWS = rows;
            COLS = cols;
            this.columns = new Rectangle[cols];
            this.board = new int[rows, cols];
            diff = difficulty;
            //red starts
            this.turn = 1;
        }

        // makes the connect 4 game board picture on screen (the start picture)
        private void GameBoard_Paint(object sender, PaintEventArgs e)
        {
            int drawWidth = 0, drawHeight = 0;
            if (ROWS == 3)
            {
                drawWidth = 340;
                drawHeight = 240;
            }
            else if (ROWS == 6)
            {
                drawWidth = 575;
                drawHeight = 425;
            }
            else if (ROWS == 9)
            {
                drawWidth = 815;
                drawHeight = 615;
            }
            e.Graphics.FillRectangle(Brushes.DodgerBlue, 100, 70, drawWidth, drawHeight);
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    if (i == 0)
                    {
                        this.columns[j] = new Rectangle(118 + 78 * j, 100, 70, drawHeight);
                    }
                    e.Graphics.FillEllipse(Brushes.LightGray, 118 + 78 * j, 88 + 65 * i, 60, 60);
                }
            }
        }

        // user chooses location to place the piece
        // this function signifies a round or a turn
        //      If it is Human v Comp, then the user is first, and when they click the piece is placed. Then the AI goes and places its piece before the method is called again.
        //      However, if it is Human v Human, then this signifies a turn
        private void GameBoard_MouseClick(object sender, MouseEventArgs e)
        {
            int winner;
            int column = this.verifyColumn(e.Location);
            // verifies click was in board before trying to find the free row
            if (column != -1)
            {
                int row = findRow(column);
                // verifies that the row was in the board space
                if (row != -1)
                { 
                    // places the piece on the board array
                    this.board[row, column] = this.turn;
                    // paints the color
                    fillColor(this.turn, row, column);
                    // writes the last turn made
                    lastTurn(column, this.turn);
                    // did the player win?
                    winner = this.gameOver(this.turn);
                    if (winner != -1)
                    {
                        string winnerColor = (winner == 1) ? "Red" : "Yellow";
                        MessageBox.Show("Game over! " + winnerColor + " has won the game.");
                        new MainMenu().Show();
                        this.Hide();
                    }
                    // update the active player
                    turnCounter++;
                    changeTurn();
                    // draw check
                    if (turnCounter >= (ROWS * COLS))
                    {
                        MessageBox.Show("Game over! Game is a draw.");
                        new MainMenu().Show();
                        this.Hide();
                    }

                    // if its not human v human, its the AI's turn
                    if(diff == 1 || diff == 2)
                    {
                        // for random AI
                        if(diff == 1)
                        {
                            // adds a sleep timer so the AI moves isnt played with the Human
                            int milliseconds = 500;
                            Thread.Sleep(milliseconds);
                            // AI can go
                            RandomAI r = new RandomAI();
                            r.findMove(board, turn);
                            int rRow = r.getRow();
                            int rCol = r.getCol();

                            // places and paints the AI move to the board array
                            this.board[rRow, rCol] = this.turn;
                            // paints the color
                            fillColor(this.turn, rRow, rCol);
                            // writes the last turn made
                            lastTurn(rCol, this.turn);
                        }
                        // for greedy AI
                        else
                        {

                        }
                        // did the AI win?
                        winner = this.gameOver(this.turn);
                        if (winner != -1)
                        {
                            string winnerColor = (winner == 1) ? "Red" : "Yellow";
                            MessageBox.Show("Game over! " + winnerColor + " has won the game.");
                            new MainMenu().Show();
                            this.Hide();
                        }
                        turnCounter++;
                        changeTurn();
                        // draw check
                        if (turnCounter >= (ROWS * COLS))
                        {
                            MessageBox.Show("Game over! Game is a draw.");
                            new MainMenu().Show();
                            this.Hide();
                        }
                    }
                }
            }
        }

        // verifies that the column clicked is in the board space and able to take a piece
        private int verifyColumn(Point mouse)
        {
            // insures that the click was in the board space
            for (int i = 0; i < this.columns.Length; i++)
            {
                if ((mouse.X >= this.columns[i].X) && (mouse.Y >= this.columns[i].Y))
                {
                    if ((mouse.X <= this.columns[i].X + this.columns[i].Width) && (mouse.Y <= this.columns[i].Y + this.columns[i].Height))
                    {
                        // return the column number
                        return i;
                    }
                }
            }
            // user clicked outside of the board
            return -1;
        }

        // finds the correct row to place a piece on in the column that the user selects
        private int findRow(int col)
        {
            // starts at the bottom and checks up to find the first free space
            for (int i = ROWS - 1; i >= 0; i--)
            {
                if (this.board[i, col] == 0)
                    return i;
            }
            return -1;
        }

        // fills the color in the space
        private void fillColor(int player, int i, int j)
        {
            if (player == 1)
            {
                Graphics g = this.CreateGraphics();
                g.FillEllipse(Brushes.Red, 118 + 78 * j, 88 + 65 * i, 60, 60);
            }
            else if (player == 2)
            {
                Graphics g = this.CreateGraphics();
                g.FillEllipse(Brushes.Gold, 118 + 78 * j, 88 + 65 * i, 60, 60);
            }
        }

        // changes the turns
        private void changeTurn()
        {
            if (turn == 1)
                turn = 2;
            else
                turn = 1;
        }

        // is there a winner? returns the winning player
        private int gameOver(int player)
        {
            // check horizontal
            for (int i = 0; i < this.board.GetLength(0); i++)
            {
                for (int j = 0; j < this.board.GetLength(1) - 3; j++)
                {
                    // checks for a winner down the cols, if so it returns the player as the winner
                    if (this.checkNums(player, this.board[i, j], this.board[i, j + 1], this.board[i, j + 2], this.board[i, j + 3]))
                        return player;
                }
            }

            // check vertical 
            for (int i = 0; i < this.board.GetLength(0) - 3; i++)
            {
                for (int j = 0; j < this.board.GetLength(1); j++)
                {
                    // checks for a winner down the rows, if so it returns the player as the winner
                    if (this.checkNums(player, this.board[i, j], this.board[i + 1, j], this.board[i + 2, j], this.board[i + 3, j]))
                        return player;
                }
            }

            // check diagonal -> top left to bot right win
            for (int i = 0; i < this.board.GetLength(0) - 3; i++)
            {
                for (int j = 0; j < this.board.GetLength(1) - 3; j++)
                {
                    // checks for a winner down the cols, if so it returns the player as the winner
                    if (this.checkNums(player, this.board[i, j], this.board[i + 1, j + 1], this.board[i + 2, j + 2], this.board[i + 3, j + 3]))
                        return player;
                }
            }

            // check diagonal -> top right to bot left win
            for (int i = 0; i < this.board.GetLength(0) - 3; i++)
            {
                for (int j = 3; j < this.board.GetLength(1); j++)
                {
                    // checks for a winner down the cols, if so it returns the player as the winner
                    if (this.checkNums(player, this.board[i, j], this.board[i + 1, j - 1], this.board[i + 2, j - 2], this.board[i + 3, j - 3]))
                        return player;
                }
            }

            return -1;

        }

        // checks the pieces on the board
        private bool checkNums(int player, params int[] nums)
        {
            foreach (int n in nums)
            {
                if (n != player)
                    return false;
            }
            return true;
        }

        // writes the last turn to the console
        private void lastTurn(int col, int player)
        {
            string playerColor = (this.turn == 1) ? "Red" : "Yellow";
            string lastTurn = "Move for " + playerColor + ": Column " + col;
            Console.Write(lastTurn);
        }

        // closes the game form permanently 
        private void GameBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void consoleShow_click(object sender, EventArgs e)
        {

        }

        private void toMainMenu_click(object sender, EventArgs e)
        {

            new MainMenu().Show();
            this.Hide();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
        }
    }
}
