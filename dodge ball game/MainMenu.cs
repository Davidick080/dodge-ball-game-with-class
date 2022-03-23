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
            Form1.ChangeScreen(this, new GameScreen());

        }
    }
}
