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
    public partial class MLV3 : Form
    {


        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public MLV3()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 6;

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

                if (questionNumber == 5)
                {
                    money += 50;
                }
                else if (questionNumber == 6)
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



            switch (qnum)
            {

                case 1:

                    pictureBox2.Image = Properties.Resources.questions;
                    labelQuestion.Text = "Calculați suma următoarelor fracții: 1/3 + 2/5 + 3/4 ";

                    button5.Text = "2/3 ";
                    button6.Text = "19/20 ";
                    button7.Text = "1 ";
                    button8.Text = "17/12 ";

                    correctAnswer = 2;

                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.questions;
                    labelQuestion.Text = "Într-o clasă, 24 de elevi învață matematica, 18 învață științele, iar 12 învață ambele. Câți elevi nu învață nici matematica, nici științele? ";

                    button5.Text = "15";
                    button6.Text = "12";
                    button7.Text = "18";
                    button8.Text = "21";

                    correctAnswer = 1;

                    break;

                case 3:

                    pictureBox2.Image = Properties.Resources.questions;
                    labelQuestion.Text = "Care dintre următoarele numere este prim?";

                    button5.Text = "27";
                    button6.Text = "42";
                    button7.Text = "31";
                    button8.Text = "50";

                    correctAnswer = 3;

                    break;
                case 4:

                    pictureBox2.Image = Properties.Resources.questions;

                    labelQuestion.Text = "Un cub are lungimea laturii de 5 cm. Care este volumul său? ";

                    button5.Text = "50 cm³ ";
                    button6.Text = "100 cm³";
                    button7.Text = "125 cm³";
                    button8.Text = "150 cm³";

                    correctAnswer = 2;

                    break;

                case 5:

                    pictureBox2.Image = Properties.Resources.questions;

                    labelQuestion.Text = "Dacă x + 8 = 15, care este valoarea lui x? ";

                    button5.Text = "5";
                    button6.Text = "9";
                    button7.Text = "8";
                    button8.Text = "4";

                    correctAnswer = 1;

                    break;

                case 6:

                    pictureBox2.Image = Properties.Resources.questions;

                    labelQuestion.Text = "Punctul A are coordonatele (3, 7), iar punctul B are coordonatele (9, 2). Care este distanța între aceste două puncte?";

                    button5.Text = "6";
                    button6.Text = "5";
                    button7.Text = "8";
                    button8.Text = "7";

                    correctAnswer = 2;

                    break;

            }




        }

    }
}
