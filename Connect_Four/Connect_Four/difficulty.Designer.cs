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
            this.pickAI_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filePath_label = new System.Windows.Forms.Label();
            this.chooseAI_button = new System.Windows.Forms.Button();
            this.fileName_TextBox = new System.Windows.Forms.TextBox();
            this.filePath_TextBox = new System.Windows.Forms.TextBox();
            this.AIChoiceSub_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pickAI_label
            // 
            this.pickAI_label.AutoSize = true;
            this.pickAI_label.Font = new System.Drawing.Font("Tempus Sans ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickAI_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pickAI_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pickAI_label.Location = new System.Drawing.Point(68, 19);
            this.pickAI_label.Name = "pickAI_label";
            this.pickAI_label.Size = new System.Drawing.Size(133, 46);
            this.pickAI_label.TabIndex = 2;
            this.pickAI_label.Text = "Pick AI";
            this.pickAI_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(1, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "File Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // filePath_label
            // 
            this.filePath_label.AutoSize = true;
            this.filePath_label.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePath_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.filePath_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.filePath_label.Location = new System.Drawing.Point(10, 183);
            this.filePath_label.Name = "filePath_label";
            this.filePath_label.Size = new System.Drawing.Size(68, 17);
            this.filePath_label.TabIndex = 6;
            this.filePath_label.Text = "File Path:";
            this.filePath_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chooseAI_button
            // 
            this.chooseAI_button.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseAI_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.chooseAI_button.Location = new System.Drawing.Point(76, 89);
            this.chooseAI_button.Name = "chooseAI_button";
            this.chooseAI_button.Size = new System.Drawing.Size(132, 33);
            this.chooseAI_button.TabIndex = 3;
            this.chooseAI_button.Text = "Choose AI";
            this.chooseAI_button.UseVisualStyleBackColor = true;
            this.chooseAI_button.Click += new System.EventHandler(this.chooseAI_click);
            // 
            // fileName_TextBox
            // 
            this.fileName_TextBox.Location = new System.Drawing.Point(84, 143);
            this.fileName_TextBox.Name = "fileName_TextBox";
            this.fileName_TextBox.ReadOnly = true;
            this.fileName_TextBox.Size = new System.Drawing.Size(188, 20);
            this.fileName_TextBox.TabIndex = 7;
            // 
            // filePath_TextBox
            // 
            this.filePath_TextBox.Location = new System.Drawing.Point(84, 182);
            this.filePath_TextBox.Name = "filePath_TextBox";
            this.filePath_TextBox.ReadOnly = true;
            this.filePath_TextBox.Size = new System.Drawing.Size(188, 20);
            this.filePath_TextBox.TabIndex = 8;
            // 
            // AIChoiceSub_button
            // 
            this.AIChoiceSub_button.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AIChoiceSub_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AIChoiceSub_button.Location = new System.Drawing.Point(76, 216);
            this.AIChoiceSub_button.Name = "AIChoiceSub_button";
            this.AIChoiceSub_button.Size = new System.Drawing.Size(132, 33);
            this.AIChoiceSub_button.TabIndex = 9;
            this.AIChoiceSub_button.Text = "Submit";
            this.AIChoiceSub_button.UseVisualStyleBackColor = true;
            this.AIChoiceSub_button.Click += new System.EventHandler(this.AIChoiceSub_click);
            // 
            // difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AIChoiceSub_button);
            this.Controls.Add(this.filePath_TextBox);
            this.Controls.Add(this.fileName_TextBox);
            this.Controls.Add(this.filePath_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseAI_button);
            this.Controls.Add(this.pickAI_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "difficulty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect Four";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.difficulty_FormClosing);
            this.Load += new System.EventHandler(this.difficulty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pickAI_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label filePath_label;
        private System.Windows.Forms.Button chooseAI_button;
        private System.Windows.Forms.TextBox fileName_TextBox;
        private System.Windows.Forms.TextBox filePath_TextBox;
        private System.Windows.Forms.Button AIChoiceSub_button;
    }
}