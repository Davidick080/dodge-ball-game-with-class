using System;
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
    public partial class Main_menu : UserControl
    {
   

        public Main_menu()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
           GameScreen.lives = 3;
            Form1.ChangeScreen(this, new GameScreen());
            
        }

        private void medium_Button_Click(object sender, EventArgs e)
        {
            GameScreen.lives = 2; 
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void hard_Button_Click(object sender, EventArgs e)
        {
            GameScreen.lives = 1;
            Form1.ChangeScreen(this, new GameScreen());
        }
    }
}
