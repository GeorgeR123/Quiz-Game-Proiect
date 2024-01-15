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
    public partial class Magazin : Form
    {
        public Magazin()
        {
            InitializeComponent();

            moneyLabel.Text = GlobalVariables.money.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdaugaBani(object sender, EventArgs e)
        {
            money += 10;
            moneyLabel.Refresh();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
