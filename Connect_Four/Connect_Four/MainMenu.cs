using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_Four
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void HumanVComp_click(object sender, EventArgs e)
        {
            // user chooses computer difficulty
            difficulty d = new difficulty();
            d.ShowDialog();
            int game_difficulty = difficulty.SetTheDifficulty;


            // user can choose a game size
            size s = new size();
            s.ShowDialog();
            int game_size = size.SetTheSize;
            int rows = getRows(game_size);
            int cols = getCols(game_size);
            s.Hide();

            // if the menus weren't closed
            if (game_size != 0 && game_difficulty != 0)
            {
                // make the gameboard and start playing
                GameBoard game = new GameBoard(2, game_difficulty, rows, cols);
                if (game_size == 1)
                    game.Size = new Size(600, 450);
                else if (game_size == 3)
                    game.Size = new Size(1200, 900);
                game.Show();
                this.Hide();
            }
        }

        private void HumanVHuman_click(object sender, EventArgs e)
        {
            // user can choose a game size
            size s = new size();
            s.ShowDialog();
            int game_size = size.SetTheSize;
            int rows = getRows(game_size);
            int cols = getCols(game_size);
            s.Hide();

            if (game_size != 0)
            {
                // make the gameboard and start playing
                GameBoard game = new GameBoard(2, 0, rows, cols);
                if (game_size == 1)
                    game.Size = new Size(600, 450);
                else if (game_size == 3)
                    game.Size = new Size(1200, 900);
                game.Show();
                this.Hide();
            }
        }

        private void Exit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private int getRows(int gameSize)
        {
            if (gameSize == 1)
                return 3;
            else if (gameSize == 2)
                return 6;
            else
                return 9;
        }

        private int getCols(int gameSize)
        {
            if (gameSize == 1)
                return 4;
            else if (gameSize == 2)
                return 7;
            else
                return 10;
        }
    }
}
