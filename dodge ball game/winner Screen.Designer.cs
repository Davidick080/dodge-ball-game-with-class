namespace dodge_ball_game
{
    partial class UserControl1
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
            this.winner_Label = new System.Windows.Forms.Label();
            this.main_Menu = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winner_Label
            // 
            this.winner_Label.AutoSize = true;
            this.winner_Label.Location = new System.Drawing.Point(160, 76);
            this.winner_Label.Name = "winner_Label";
            this.winner_Label.Size = new System.Drawing.Size(92, 13);
            this.winner_Label.TabIndex = 0;
            this.winner_Label.Text = "Congrats you won";
            // 
            // main_Menu
            // 
            this.main_Menu.Location = new System.Drawing.Point(82, 134);
            this.main_Menu.Name = "main_Menu";
            this.main_Menu.Size = new System.Drawing.Size(75, 23);
            this.main_Menu.TabIndex = 1;
            this.main_Menu.Text = "Main menu";
            this.main_Menu.UseVisualStyleBackColor = true;
            this.main_Menu.Click += new System.EventHandler(this.main_Menu_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Location = new System.Drawing.Point(244, 134);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(75, 23);
            this.exit_Button.TabIndex = 2;
            this.exit_Button.Text = "exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.main_Menu);
            this.Controls.Add(this.winner_Label);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(456, 302);
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label winner_Label;
        private System.Windows.Forms.Button main_Menu;
        private System.Windows.Forms.Button exit_Button;
    }
}
