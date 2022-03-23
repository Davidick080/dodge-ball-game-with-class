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
            this.SuspendLayout();
            // 
            // easyButton
            // 
            this.easyButton.Location = new System.Drawing.Point(406, 204);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(75, 23);
            this.easyButton.TabIndex = 0;
            this.easyButton.Text = "Start";
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
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
    }
}
