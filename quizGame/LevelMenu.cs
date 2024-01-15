using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame
{
    public partial class LevelMenu : Form
    {
        public LevelMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLevel1 gameWindow = new QLevel1();

            gameWindow.Show();
        }

        private void LevelMenu_Load(object sender, EventArgs e)
        {

        }

        private void LoadLvl2_2(object sender, EventArgs e)
        {
            Formsss gameWindow = new Formsss();

            gameWindow.Show();
        }
    }
}
