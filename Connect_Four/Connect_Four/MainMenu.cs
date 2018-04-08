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
                GameBoard game = new GameBoard(2, "", "", rows, cols);
                if (game_size == 1)
                    game.Size = new Size(600, 450);
                else if (game_size == 3)
                    game.Size = new Size(1200, 900);
                game.Show();
                this.Hide();
            }
        }

        private void HumanVComp_click(object sender, EventArgs e)
        {
            // user chooses computer difficulty
            difficulty d = new difficulty("Pick AI");
            d.ShowDialog();
            string AI = difficulty.PickAI;


            // user can choose a game size
            size s = new size();
            s.ShowDialog();
            int game_size = size.SetTheSize;
            int rows = getRows(game_size);
            int cols = getCols(game_size);
            s.Hide();

            // if the menus weren't closed
            if (game_size != 0 && AI != "")
            {
                // make the gameboard and start playing
                GameBoard game = new GameBoard(1, AI, "", rows, cols);
                if (game_size == 1)
                    game.Size = new Size(600, 450);
                else if (game_size == 3)
                    game.Size = new Size(1200, 900);
                game.Show();
                this.Hide();
            }
        }

        private void CompVComp_click(object sender, EventArgs e)
        {
            string AIone_choice = "";
            string AItwo_choice = "";

            // user chooses computer AI #1 difficulty
            difficulty AIone = new difficulty("Pick AI 1");
            AIone.ShowDialog();
            AIone_choice = difficulty.PickAI;

            // user chooses computer AI #2 difficulty
            difficulty AItwo = new difficulty("Pick AI 2");
            AItwo.ShowDialog();
            AItwo_choice = difficulty.PickAI;

            // user can choose a game size
            size s = new size();
            s.ShowDialog();
            int game_size = size.SetTheSize;
            int rows = getRows(game_size);
            int cols = getCols(game_size);
            s.Hide();

            // if the menus weren't closed
            if (game_size != 0 && AIone_choice != "" && AItwo_choice != "")
            {
                // make the gameboard and start playing
                GameBoard game = new GameBoard(0, AIone_choice, AItwo_choice, rows, cols);
                if (game_size == 1)
                    game.Size = new Size(600, 450);
                else if (game_size == 3)
                    game.Size = new Size(1200, 900);
                game.Show();
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
