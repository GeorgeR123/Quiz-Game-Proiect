using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace quizGame
{
    public partial class Duel : Form
    {
        public Duel()
        {
            InitializeComponent();
        }

        private void LoadCTButton1(object sender, EventArgs e)
        {
            CGLV1 gameWindow = new CGLV1();

            string player_name1 = textBox1.Text;
            string player_name2 = textBox2.Text;

            gameWindow.Show();
        }

        private void LoadCTButton2(object sender, EventArgs e)
        {
            CGLV2 gameWindow = new CGLV2();

            gameWindow.Show();
        }
        private void LoadCTButton3(object sender, EventArgs e)
        {
            CGLV3 gameWindow = new CGLV3();

            gameWindow.Show();
        }
    }
}
