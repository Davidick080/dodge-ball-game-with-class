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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void main_Menu_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new Main_menu());
            GameScreen.lives = 3;
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
