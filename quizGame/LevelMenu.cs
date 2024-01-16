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

        private void LoadMButton1(object sender, EventArgs e)
        {
            MLV1 gameWindow = new MLV1();

            gameWindow.Show();
        }
        /*
        private void LoadMButton2(object sender, EventArgs e)
        {
            MLV2 gameWindow = new MLV2();

            gameWindow.Show();
        }
        
        private void LoadMButton3(object sender, EventArgs e)
        {
            MLV3 gameWindow = new MLV3();

            gameWindow.Show();
        }
        */
        private void LoadCTButton1(object sender, EventArgs e)
        {
            CGLV1 gameWindow = new CGLV1();

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

        private void LevelMenu_Load(object sender, EventArgs e)
        {

        }

        private void LoadLvl2_2(object sender, EventArgs e)
        {
            
        }
    }
}
