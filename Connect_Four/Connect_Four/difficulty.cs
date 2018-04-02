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
    public partial class difficulty : Form
    {
        public static int SetTheDifficulty = 0;
        public difficulty()
        {
            InitializeComponent();
        }

        private void diffEasy_click(object sender, EventArgs e)
        {
            SetTheDifficulty = 1;
            this.Hide();
        }

        private void diffHard_click(object sender, EventArgs e)
        {
            SetTheDifficulty = 2;
            this.Hide();
        }

        private void difficulty_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
