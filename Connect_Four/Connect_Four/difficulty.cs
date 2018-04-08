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
        public static string PickAI = "";
        private static string AIlabel = "Pick AI";
        public difficulty(string label)
        {
            InitializeComponent();
            AIlabel = label;
        }

        private void difficulty_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        OpenFileDialog ofd = new OpenFileDialog();
        private void chooseAI_click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // returns the file path
                filePath_TextBox.Text = ofd.FileName;
                // returns the file name
                fileName_TextBox.Text = ofd.SafeFileName;
                // sets the AI file path to the program
                PickAI = ofd.FileName;
            }
        }

        private void AIChoiceSub_click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void difficulty_Load(object sender, EventArgs e)
        {
            pickAI_label.Text = AIlabel;
        }
    }
}
