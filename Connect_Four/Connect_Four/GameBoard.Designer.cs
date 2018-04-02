namespace Connect_Four
{
    partial class GameBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.consoleShow_button = new System.Windows.Forms.Button();
            this.toMainMenu_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // consoleShow_button
            // 
            this.consoleShow_button.Location = new System.Drawing.Point(12, 12);
            this.consoleShow_button.Name = "consoleShow_button";
            this.consoleShow_button.Size = new System.Drawing.Size(117, 29);
            this.consoleShow_button.TabIndex = 0;
            this.consoleShow_button.Text = "Display Console";
            this.consoleShow_button.UseVisualStyleBackColor = true;
            this.consoleShow_button.Click += new System.EventHandler(this.consoleShow_click);
            // 
            // toMainMenu_button
            // 
            this.toMainMenu_button.Location = new System.Drawing.Point(144, 12);
            this.toMainMenu_button.Name = "toMainMenu_button";
            this.toMainMenu_button.Size = new System.Drawing.Size(117, 29);
            this.toMainMenu_button.TabIndex = 1;
            this.toMainMenu_button.Text = "Exit to Main Menu";
            this.toMainMenu_button.UseVisualStyleBackColor = true;
            this.toMainMenu_button.Click += new System.EventHandler(this.toMainMenu_click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toMainMenu_button);
            this.Controls.Add(this.consoleShow_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect Four";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameBoard_FormClosing);
            this.Load += new System.EventHandler(this.GameBoard_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameBoard_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameBoard_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button consoleShow_button;
        private System.Windows.Forms.Button toMainMenu_button;
        private System.Windows.Forms.Timer timer1;
    }
}