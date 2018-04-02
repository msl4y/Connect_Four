namespace Connect_Four
{
    partial class difficulty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(difficulty));
            this.size_label = new System.Windows.Forms.Label();
            this.diffEasy_button = new System.Windows.Forms.Button();
            this.diffHard_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // size_label
            // 
            this.size_label.AutoSize = true;
            this.size_label.Font = new System.Drawing.Font("Tempus Sans ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.size_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.size_label.Location = new System.Drawing.Point(-4, 32);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(292, 46);
            this.size_label.TabIndex = 2;
            this.size_label.Text = "Choose Difficulty";
            this.size_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // diffEasy_button
            // 
            this.diffEasy_button.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diffEasy_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.diffEasy_button.Location = new System.Drawing.Point(76, 108);
            this.diffEasy_button.Name = "diffEasy_button";
            this.diffEasy_button.Size = new System.Drawing.Size(132, 33);
            this.diffEasy_button.TabIndex = 3;
            this.diffEasy_button.Text = "Easy";
            this.diffEasy_button.UseVisualStyleBackColor = true;
            this.diffEasy_button.Click += new System.EventHandler(this.diffEasy_click);
            // 
            // diffHard_button
            // 
            this.diffHard_button.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diffHard_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.diffHard_button.Location = new System.Drawing.Point(76, 171);
            this.diffHard_button.Name = "diffHard_button";
            this.diffHard_button.Size = new System.Drawing.Size(132, 33);
            this.diffHard_button.TabIndex = 4;
            this.diffHard_button.Text = "Hard";
            this.diffHard_button.UseVisualStyleBackColor = true;
            this.diffHard_button.Click += new System.EventHandler(this.diffHard_click);
            // 
            // difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.diffHard_button);
            this.Controls.Add(this.diffEasy_button);
            this.Controls.Add(this.size_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "difficulty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect Four";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.difficulty_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.Button diffEasy_button;
        private System.Windows.Forms.Button diffHard_button;
    }
}