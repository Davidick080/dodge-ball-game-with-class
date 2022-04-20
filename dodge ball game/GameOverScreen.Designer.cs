namespace dodge_ball_game
{
    partial class GameOverScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.retry_Button = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Location = new System.Drawing.Point(261, 87);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(65, 13);
            this.gameOverLabel.TabIndex = 0;
            this.gameOverLabel.Text = "You are ded";
            // 
            // retry_Button
            // 
            this.retry_Button.Location = new System.Drawing.Point(212, 157);
            this.retry_Button.Name = "retry_Button";
            this.retry_Button.Size = new System.Drawing.Size(75, 23);
            this.retry_Button.TabIndex = 1;
            this.retry_Button.Text = "main menu";
            this.retry_Button.UseVisualStyleBackColor = true;
            this.retry_Button.Click += new System.EventHandler(this.retry_Button_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(357, 156);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "quit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.retry_Button);
            this.Controls.Add(this.gameOverLabel);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(850, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Button retry_Button;
        private System.Windows.Forms.Button exit;
    }
}
