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
    public partial class size : Form
    {
        public static int SetTheSize = 0;
        public size()
        {
            InitializeComponent();
        }

        private void size_Load(object sender, EventArgs e)
        {

        }

        private void smallSize_click(object sender, EventArgs e)
        {
            SetTheSize = 1;
            this.Hide();
        }

        private void standardSize_click(object sender, EventArgs e)
        {
            SetTheSize = 2;
            this.Hide();
        }

        private void largeSize_click(object sender, EventArgs e)
        {
            SetTheSize = 3;
            this.Hide();
        }

        private void size_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
