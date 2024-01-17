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
    public partial class MLV2 : Form
    {

        
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public MLV2()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 6;



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
                                "Scorul tau final este " + percentage + " % " + Environment.NewLine +
                                "Apasa butonul ok pentru a juca din nou"

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
                    labelQuestion.Text = "Numărul 261 798 se rotunjeşte la zeci de mii la:  ";

                    button5.Text = "261 000 ";
                    button6.Text = "200 000 ";
                    button7.Text = "260 000 ";
                    button8.Text = "300 000 ";

                    correctAnswer = 3;

                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.questions;
                    labelQuestion.Text = "Termenul necunoscut din egalitatea   7 x a = 133 are valoarea: ";

                    button5.Text = "18";
                    button6.Text = "21";
                    button7.Text = "19";
                    button8.Text = "16";

                    correctAnswer = 3;

                    break;

                case 3:

                    pictureBox2.Image = Properties.Resources.questions;
                    labelQuestion.Text = "Suma dintre jumătatea şi sfertul numărului 116 este:";

                    button5.Text = "29";
                    button6.Text = "58";
                    button7.Text = "87";
                    button8.Text = "77";

                    correctAnswer = 3;

                    break;
                case 4:

                    pictureBox2.Image = Properties.Resources.questions;

                    labelQuestion.Text = "Ce număr trebuie scăzut din 723 pentru a obține împătritul numărului 12? ";

                    button5.Text = "720 ";
                    button6.Text = "675";
                    button7.Text = "726";
                    button8.Text = "771";

                    correctAnswer = 2;

                    break;

                case 5:

                    pictureBox2.Image = Properties.Resources.questions;

                    labelQuestion.Text = "Produsul a cinci numere naturale este 5. Suma lor este: ";

                    button5.Text = "5";
                    button6.Text = "9";
                    button7.Text = "25";
                    button8.Text = "4";

                    correctAnswer = 1;

                    break;

                case 6:

                    pictureBox2.Image = Properties.Resources.questions;

                    labelQuestion.Text = "Termenul necunoscut din egalitatea 5xa=475 are valoarea:";

                    button5.Text = "75";
                    button6.Text = "95";
                    button7.Text = "85";
                    button8.Text = "125";

                    correctAnswer = 2;

                    break;

            }




        }

    }
}
