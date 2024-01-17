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
    public partial class CGLV3 : Form
    {

        // variables list for this quiz game
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public CGLV3()
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
                    labelQuestion.Text = "Câte laturi are un tringhi?";

                    button1.Text = "4";
                    button2.Text = "5";
                    button3.Text = "3";
                    button4.Text = "6";

                    correctAnswer = 3;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.questions;
                    labelQuestion.Text = "Din prelucrarea sfeclei de zahăr se obține:";

                    button1.Text = "zahăr";
                    button2.Text = "sare";
                    button3.Text = "ulei";
                    button4.Text = "miere ";

                    correctAnswer = 1;

                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.fortnite;

                    labelQuestion.Text = " Unde s-a născut prozatorul român Ion Creangă (1837-1890)? ";

                    button1.Text = "Piteşti";
                    button2.Text = "Ipoteşti";
                    button3.Text = "Humuleşti ";
                    button4.Text = "Iaşi ";

                    correctAnswer = 3;

                    break;

                case 4:

                    pictureBox1.Image = Properties.Resources.questions;

                    labelQuestion.Text = "Roma este capitala :";

                    button1.Text = "Italiei";
                    button2.Text = "Bulgariei";
                    button3.Text = "Franței";
                    button4.Text = "Germaniei";

                    correctAnswer = 1;

                    break;

                case 5:

                    pictureBox1.Image = Properties.Resources.gears_of_war;

                    labelQuestion.Text = "Partea cea mai dezvoltată a unei compuneri se numeşte:";

                    button1.Text = "text  ";
                    button2.Text = " deznodământ ";
                    button3.Text = "cuprins";
                    button4.Text = " introducere";

                    correctAnswer = 3;

                    break;

                case 6:

                    pictureBox1.Image = Properties.Resources.halo;

                    labelQuestion.Text = "La începutul unui portativ muzical se scrie cheia:";

                    button1.Text = "la";
                    button2.Text = "do";
                    button3.Text = "re ";
                    button4.Text = "sol";

                    correctAnswer = 4;

                    break;

                case 7:

                    pictureBox1.Image = Properties.Resources.csgo;

                    labelQuestion.Text = "Organul pipăitului este :";

                    button1.Text = "ochiul";
                    button2.Text = " nasul ";
                    button3.Text = "pielea";
                    button4.Text = " urechea ";

                    correctAnswer = 3;

                    break;

                case 8:

                    pictureBox1.Image = Properties.Resources.witcher3;

                    labelQuestion.Text = " Ce animal nu trăieşte în zonele polare?";

                    button1.Text = "pinguinul";
                    button2.Text = "elefantul";
                    button3.Text = "foca";
                    button4.Text = "vulpea polară";

                    correctAnswer = 2;

                    break;




            }




        }

    }
}
