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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static quizGame.GlobalVariables;

namespace quizGame
{
    public partial class MLV1 : Form
    {

       
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public MLV1()
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
                    lblQuestion.Text = "Rezultatul operatiei 29x100 este: ";

                    button1.Text = "290";
                    button2.Text = "2900";
                    button3.Text = "2090";
                    button4.Text = "29000";

                    correctAnswer = 2;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = "Rezultatul operatiei 120:4 este: ";

                    button1.Text = "30";
                    button2.Text = "116";
                    button3.Text = "124";
                    button4.Text = "40";

                    correctAnswer = 1;

                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = "Rezultatul operatiei 6x20+73 este:";

                    button1.Text = "99";
                    button2.Text = "193";
                    button3.Text = "200";
                    button4.Text = "190";

                    correctAnswer = 2;

                    break;
                case 4:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Rezultatul operatiei 100:5-15 este:";

                    button1.Text = "25";
                    button2.Text = "15";
                    button3.Text = "1";
                    button4.Text = "5";

                    correctAnswer = 4;

                    break;

                case 5:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Rezultatul operatiei 25x42:21 este:";

                    button1.Text = "69";
                    button2.Text = "45";
                    button3.Text = "50";
                    button4.Text = "38";

                    correctAnswer = 1;

                    break;

                case 6:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Rezultatul operatiei 276:23x16 este:";

                    button1.Text = "178";
                    button2.Text = "200";
                    button3.Text = "192";
                    button4.Text = "216";

                    correctAnswer = 3;

                    break;

                    case 7:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Rezultatul operatiei 23x45:15+75 este:";

                    button1.Text = "189";
                    button2.Text = "144";
                    button3.Text = "123";
                    button4.Text = "200";

                    correctAnswer = 2;

                    break;

                    case 8:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Rezultatul operatiei 65x86:43+175 este:";

                    button1.Text = "305";
                    button2.Text = "415";
                    button3.Text = "275";
                    button4.Text = "355";

                    correctAnswer = 1;

                    break;





            }




        }

    }
}
