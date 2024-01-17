using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static quizGame.GlobalVariables;

namespace quizGame
{
    public partial class CGLV2 : Form
    {

        // variables list for this quiz game
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        int totalScore;

        public string ReturnValue1 { get; set; }
        public string ReturnValue2 { get; set; }


        public CGLV2()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 8;

            moneyLabel.Text = GlobalVariables.money.ToString();

        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);




            if (buttonTag == correctAnswer)
            {
                score++;


            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage here
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);


                MessageBox.Show("Quiz-ul a luat sfarsit" + Environment.NewLine +
                                "Ai raspuns corect la " + score + " din intrebari" + Environment.NewLine +
                                "Scorul tau final este " + percentage + " % " + Environment.NewLine

                    );
                if (questionNumber == 7)
                {
                    money += 50;
                }
                else if (questionNumber == 8)
                {
                    money += 100;
                }

                this.ReturnValue1 = score.ToString();
                this.ReturnValue2 = score.ToString();

                score = 0;
                questionNumber = 0;

                askQuestion(questionNumber);

                this.Close();
            }

            questionNumber++;

            askQuestion(questionNumber);



        }

        private void askQuestion(int qnum)
        {

            

            switch(qnum)
            {

                case 1:

                    pictureBox1.Image = Properties.Resources.semafor;
                    lblQuestion.Text = "Culorile semaforului sunt:";

                    button1.Text = " verde-roşu-galben";
                    button2.Text = " albastru-verde-roşu";
                    button3.Text = "roşu-alb-galben";
                    button4.Text = "verde-galben-alb";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.cardinal_soare;
                    lblQuestion.Text = " Din ce punct cardinal răsare soarele:";

                    button1.Text = "vest ";
                    button2.Text = " est";
                    button3.Text = "nord";
                    button4.Text = " de sus";

                    correctAnswer = 2;

                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.forma_relief_brazi;

                    lblQuestion.Text = "Cum se numeşte forma de relief în care predomină brazii? ";

                    button1.Text = "deal";
                    button2.Text = "câmpie";
                    button3.Text = "luncă ";
                    button4.Text = " munte";

                    correctAnswer = 4;

                    break;

                case 4:

                    pictureBox1.Image = Properties.Resources.pesti;

                    lblQuestion.Text = "Peştii îşi iau oxigenul pentru respirație din:";

                    button1.Text = "uscat";
                    button2.Text = "apă";
                    button3.Text = "aer";
                    button4.Text = "pământ";

                    correctAnswer = 2;

                    break;

                case 5:

                    pictureBox1.Image = Properties.Resources.lizuca_e1478255883872;

                    lblQuestion.Text = "Lizuca este personajul feminin din:";

                    button1.Text = " Tom Degetel ";
                    button2.Text = "Crăiaza zapezii ";
                    button3.Text = "Dumbrava minunată";
                    button4.Text = "alt răspuns ";

                    correctAnswer = 3;

                    break;

                case 6:

                    pictureBox1.Image = Properties.Resources.grau;

                    lblQuestion.Text = "Cum se numeşte cereala din făina căreia se fac prăjituri:";

                    button1.Text = "orz";
                    button2.Text = "orez";
                    button3.Text = "grâu ";
                    button4.Text = "porumb";

                    correctAnswer = 3;

                    break;

                case 7:

                    pictureBox1.Image = Properties.Resources.constanta;

                    lblQuestion.Text = "Care este oraşul cel mai apropiat de Marea Neagră:";

                    button1.Text = "Constanța";
                    button2.Text = " Roman ";
                    button3.Text = "Bucureşti";
                    button4.Text = " Suceava ";

                    correctAnswer = 1;

                    break;

                case 8:

                    pictureBox1.Image = Properties.Resources.minori;

                    lblQuestion.Text = "Copii sub 18 ani sunt considerați :";

                    button1.Text = "majori";
                    button2.Text = "adulți";
                    button3.Text = "minori";
                    button4.Text = "vârstnici";

                    correctAnswer = 3;

                    break;




            }




        }

    }
}
