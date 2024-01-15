using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static quizGame.GlobalVariables;

namespace quizGame
{


    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();

            moneyLabel.Text = GlobalVariables.money.ToString();


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadLevelMenu(object sender, EventArgs e)
        {
            LevelMenu gameWindow = new LevelMenu();

            gameWindow.Show();

        }

        private void LoadMagazin(object sender, EventArgs e)
        {
            Magazin gameWindow = new Magazin();

            gameWindow.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

    public static class GlobalVariables
    {
        public static int money = 100;
    }
}
