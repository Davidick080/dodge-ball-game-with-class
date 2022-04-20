namespace dodge_ball_game
{
    partial class Main_menu
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
            this.easyButton = new System.Windows.Forms.Button();
            this.dodgeGameText = new System.Windows.Forms.Label();
            this.medium_Button = new System.Windows.Forms.Button();
            this.hard_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // easyButton
            // 
            this.easyButton.Location = new System.Drawing.Point(394, 111);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(75, 23);
            this.easyButton.TabIndex = 0;
            this.easyButton.Text = "easy";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // dodgeGameText
            // 
            this.dodgeGameText.AutoSize = true;
            this.dodgeGameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dodgeGameText.Location = new System.Drawing.Point(403, 75);
            this.dodgeGameText.Name = "dodgeGameText";
            this.dodgeGameText.Size = new System.Drawing.Size(66, 13);
            this.dodgeGameText.TabIndex = 1;
            this.dodgeGameText.Text = "dodge game";
            // 
            // medium_Button
            // 
            this.medium_Button.Location = new System.Drawing.Point(394, 174);
            this.medium_Button.Name = "medium_Button";
            this.medium_Button.Size = new System.Drawing.Size(75, 23);
            this.medium_Button.TabIndex = 2;
            this.medium_Button.Text = "medium ";
            this.medium_Button.UseVisualStyleBackColor = true;
            this.medium_Button.Click += new System.EventHandler(this.medium_Button_Click);
            // 
            // hard_Button
            // 
            this.hard_Button.Location = new System.Drawing.Point(394, 240);
            this.hard_Button.Name = "hard_Button";
            this.hard_Button.Size = new System.Drawing.Size(75, 23);
            this.hard_Button.TabIndex = 3;
            this.hard_Button.Text = "Hard ";
            this.hard_Button.UseVisualStyleBackColor = true;
            this.hard_Button.Click += new System.EventHandler(this.hard_Button_Click);
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.hard_Button);
            this.Controls.Add(this.medium_Button);
            this.Controls.Add(this.dodgeGameText);
            this.Controls.Add(this.easyButton);
            this.Name = "Main_menu";
            this.Size = new System.Drawing.Size(850, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Label dodgeGameText;
        private System.Windows.Forms.Button medium_Button;
        private System.Windows.Forms.Button hard_Button;
    }
}
