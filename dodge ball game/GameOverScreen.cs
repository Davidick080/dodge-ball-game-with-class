﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dodge_ball_game
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void retry_Button_Click(object sender, EventArgs e)
        {
            
            Form1.ChangeScreen(this, new Main_menu());
            GameScreen.lives = 3;
            

           
    }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
