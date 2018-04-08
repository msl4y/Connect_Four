namespace Connect_Four
{
    partial class size
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(size));
            this.size_label = new System.Windows.Forms.Label();
            this.smallSize_button = new System.Windows.Forms.Button();
            this.standardSize_button = new System.Windows.Forms.Button();
            this.largeSize_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // size_label
            // 
            this.size_label.AutoSize = true;
            this.size_label.Font = new System.Drawing.Font("Tempus Sans ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.size_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.size_label.Location = new System.Drawing.Point(53, 23);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(178, 46);
            this.size_label.TabIndex = 1;
            this.size_label.Text = "Game Size";
            this.size_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // smallSize_button
            // 
            this.smallSize_button.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallSize_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.smallSize_button.Location = new System.Drawing.Point(77, 85);
            this.smallSize_button.Name = "smallSize_button";
            this.smallSize_button.Size = new System.Drawing.Size(132, 33);
            this.smallSize_button.TabIndex = 2;
            this.smallSize_button.Text = "Small";
            this.smallSize_button.UseVisualStyleBackColor = true;
            this.smallSize_button.Click += new System.EventHandler(this.smallSize_click);
            // 
            // standardSize_button
            // 
            this.standardSize_button.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardSize_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.standardSize_button.Location = new System.Drawing.Point(77, 134);
            this.standardSize_button.Name = "standardSize_button";
            this.standardSize_button.Size = new System.Drawing.Size(132, 33);
            this.standardSize_button.TabIndex = 3;
            this.standardSize_button.Text = "Standard";
            this.standardSize_button.UseVisualStyleBackColor = true;
            this.standardSize_button.Click += new System.EventHandler(this.standardSize_click);
            // 
            // largeSize_button
            // 
            this.largeSize_button.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeSize_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.largeSize_button.Location = new System.Drawing.Point(77, 186);
            this.largeSize_button.Name = "largeSize_button";
            this.largeSize_button.Size = new System.Drawing.Size(132, 33);
            this.largeSize_button.TabIndex = 4;
            this.largeSize_button.Text = "Large";
            this.largeSize_button.UseVisualStyleBackColor = true;
            this.largeSize_button.Click += new System.EventHandler(this.largeSize_click);
            // 
            // size
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.largeSize_button);
            this.Controls.Add(this.standardSize_button);
            this.Controls.Add(this.smallSize_button);
            this.Controls.Add(this.size_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "size";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect Four";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.size_FormClosing);
            this.Load += new System.EventHandler(this.size_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.Button smallSize_button;
        private System.Windows.Forms.Button standardSize_button;
        private System.Windows.Forms.Button largeSize_button;
    }
}