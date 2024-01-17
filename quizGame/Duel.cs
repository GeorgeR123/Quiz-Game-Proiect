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
        private int player_score1;
        private int player_score2;
        int player_score;

        public Duel()
        {
            InitializeComponent();
        }

        private void LoadCTButton1(object sender, EventArgs e)
        {
            CGLV1 gameWindow = new CGLV1();

            string player_name1 = textBox1.Text;
            string player_name2 = textBox2.Text;

            var dialogResult1= gameWindow.ShowDialog();

            //player_score1 = dialogResult1;

            var dialogResult2 = gameWindow.ShowDialog();

            //player_score2 = dialogResult2;
            if (player_score1 > player_score2)
            MessageBox.Show("Sfarsit!" + Environment.NewLine +
                            player_name1 + " a realizat " + player_score1 + " intrebari corecte!" + Environment.NewLine +
                            player_name2 + " a realizat " + player_score2 + " intrebari corecte!" + Environment.NewLine +
                             Environment.NewLine +
                            "A castigat " + player_name1 + ", Felicitari!" + Environment.NewLine 
             );
            else if (player_score1 < player_score2)
                MessageBox.Show("Sfarsit!" + Environment.NewLine +
                            player_name1 + " a realizat " + player_score1 + " intrebari corecte!" + Environment.NewLine +
                            player_name2 + " a realizat " + player_score2 + " intrebari corecte!" + Environment.NewLine +
                            Environment.NewLine +
                            "A castigat " + player_name2 + ", Felicitari!" + Environment.NewLine
             );
            else
                MessageBox.Show("Sfarsit!" + Environment.NewLine +
                            player_name1 + " a realizat " + player_score1 + " intrebari corecte!" + Environment.NewLine +
                            player_name2 + " a realizat " + player_score2 + " intrebari corecte!" + Environment.NewLine +
                            Environment.NewLine +
                            "Egalitate!" + Environment.NewLine
             );
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
