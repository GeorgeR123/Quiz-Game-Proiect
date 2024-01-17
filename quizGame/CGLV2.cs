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


        public CGLV2()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 8;



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


                MessageBox.Show("Quiz Ended" + Environment.NewLine +
                                "You have answered " + score + " questions correcly" + Environment.NewLine +
                                "Your total percentage is " + percentage + " %" + Environment.NewLine +
                                "Click Ok to play again"

                    );
                if (questionNumber == 7)
                {
                    money += 50;
                }
                else if (questionNumber == 8)
                {
                    money += 100;
                }

                score = 0;
                questionNumber = 0;

                askQuestion(questionNumber);
            }

            questionNumber++;

            askQuestion(questionNumber);



        }

        private void askQuestion(int qnum)
        {

            

            switch(qnum)
            {

                case 1:

                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = "Culorile semaforului sunt:";

                    button1.Text = " verde-roşu-galben";
                    button2.Text = " albastru-verde-roşu";
                    button3.Text = "roşu-alb-galben";
                    button4.Text = "verde-galben-alb";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = " Din ce punct cardinal răsare soarele:";

                    button1.Text = "vest ";
                    button2.Text = " est";
                    button3.Text = "nord";
                    button4.Text = " de sus";

                    correctAnswer = 2;

                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.fortnite;

                    lblQuestion.Text = "Cum se numeşte forma de relief în care predomină brazii? ";

                    button1.Text = "deal";
                    button2.Text = "câmpie";
                    button3.Text = "luncă ";
                    button4.Text = " munte";

                    correctAnswer = 4;

                    break;

                case 4:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Peştii îşi iau oxigenul pentru respirație din:";

                    button1.Text = "uscat";
                    button2.Text = "apă";
                    button3.Text = "aer";
                    button4.Text = "pământ";

                    correctAnswer = 2;

                    break;

                case 5:

                    pictureBox1.Image = Properties.Resources.gears_of_war;

                    lblQuestion.Text = "Lizuca este personajul feminin din:";

                    button1.Text = " Tom Degetel ";
                    button2.Text = "Crăiaza zapezii ";
                    button3.Text = "Dumbrava minunată";
                    button4.Text = "alt răspuns ";

                    correctAnswer = 3;

                    break;

                case 6:

                    pictureBox1.Image = Properties.Resources.halo;

                    lblQuestion.Text = "Cum se numeşte cereala din făina căreia se fac prăjituri:";

                    button1.Text = "orz";
                    button2.Text = "orez";
                    button3.Text = "grâu ";
                    button4.Text = "porumb";

                    correctAnswer = 3;

                    break;

                case 7:

                    pictureBox1.Image = Properties.Resources.csgo;

                    lblQuestion.Text = "Care este oraşul cel mai apropiat de Marea Neagră:";

                    button1.Text = "Constanța";
                    button2.Text = " Roman ";
                    button3.Text = "Bucureşti";
                    button4.Text = " Suceava ";

                    correctAnswer = 1;

                    break;

                case 8:

                    pictureBox1.Image = Properties.Resources.witcher3;

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
