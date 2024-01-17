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
        int totalScore;

        public string ReturnValue1 { get; set; }
        public string ReturnValue2 { get; set; }

        public CGLV3()
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

                    pictureBox1.Image = Properties.Resources.triunghi;
                    labelQuestion.Text = "Câte laturi are un tringhi?";

                    button1.Text = "4";
                    button2.Text = "5";
                    button3.Text = "3";
                    button4.Text = "6";

                    correctAnswer = 3;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.sfecla;
                    labelQuestion.Text = "Din prelucrarea sfeclei de zahăr se obține:";

                    button1.Text = "zahăr";
                    button2.Text = "sare";
                    button3.Text = "ulei";
                    button4.Text = "miere ";

                    correctAnswer = 1;

                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.crrreanga_1_1024x695;

                    labelQuestion.Text = " Unde s-a născut prozatorul român Ion Creangă (1837-1890)? ";

                    button1.Text = "Piteşti";
                    button2.Text = "Ipoteşti";
                    button3.Text = "Humuleşti ";
                    button4.Text = "Iaşi ";

                    correctAnswer = 3;

                    break;

                case 4:

                    pictureBox1.Image = Properties.Resources.roma;

                    labelQuestion.Text = "Roma este capitala :";

                    button1.Text = "Italiei";
                    button2.Text = "Bulgariei";
                    button3.Text = "Franței";
                    button4.Text = "Germaniei";

                    correctAnswer = 1;

                    break;

                case 5:

                    pictureBox1.Image = Properties.Resources.cuprins;

                    labelQuestion.Text = "Partea cea mai dezvoltată a unei compuneri se numeşte:";

                    button1.Text = "text  ";
                    button2.Text = " deznodământ ";
                    button3.Text = "cuprins";
                    button4.Text = " introducere";

                    correctAnswer = 3;

                    break;

                case 6:

                    pictureBox1.Image = Properties.Resources.cheia_sol;

                    labelQuestion.Text = "La începutul unui portativ muzical se scrie cheia:";

                    button1.Text = "la";
                    button2.Text = "do";
                    button3.Text = "re ";
                    button4.Text = "sol";

                    correctAnswer = 4;

                    break;

                case 7:

                    pictureBox1.Image = Properties.Resources.piele;

                    labelQuestion.Text = "Organul pipăitului este :";

                    button1.Text = "ochiul";
                    button2.Text = " nasul ";
                    button3.Text = "pielea";
                    button4.Text = " urechea ";

                    correctAnswer = 3;

                    break;

                case 8:

                    pictureBox1.Image = Properties.Resources.polar;

                    labelQuestion.Text = " Ce animal nu trăieşte în zonele polare?";

                    button1.Text = "pinguinul";
                    button2.Text = "elefantul";
                    button3.Text = "foca";
                    button4.Text = "vulpea polară";

                    correctAnswer = 2;

                    break;




            }




        }

        private void ajutor(object sender, EventArgs e)
        {
            if (money >= 100)
            {
                money -= 100;
                moneyLabel.Text = GlobalVariables.money.ToString();
                if (correctAnswer == 1)
                    MessageBox.Show(
                        Environment.NewLine +
                        "Raspunsul este cel din stanga sus " +
                        Environment.NewLine +
                        "A costat 100$. Mai ai: " + money + "$" +
                        Environment.NewLine
                        );
                else if (correctAnswer == 2)
                    MessageBox.Show(
                        Environment.NewLine +
                        "Raspunsul este cel din dreapta sus" +
                        Environment.NewLine +
                        "A costat 100$. Mai ai: " + money + "$" +
                        Environment.NewLine
                        );
                else if (correctAnswer == 3)
                    MessageBox.Show(
                        Environment.NewLine +
                        "Raspunsul este cel din stanga jos" +
                        Environment.NewLine +
                        "A costat 100$. Mai ai: " + money + "$" +
                        Environment.NewLine
                        );
                else if (correctAnswer == 4)
                    MessageBox.Show(
                        Environment.NewLine +
                        "Raspunsul este cel din dreapta jos" +
                        Environment.NewLine +
                        "A costat 100$. Mai ai: " + money + "$" +
                        Environment.NewLine
                        );

            }
        }
    }
}
