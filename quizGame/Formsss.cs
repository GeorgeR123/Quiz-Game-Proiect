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
    public partial class Formsss : Form
    {
        
        public Formsss()
        {
            InitializeComponent();

            moneyLabel.Text = GlobalVariables.money.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
