using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame
{
    public partial class Form2 : Form
    {

        
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form2()
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

                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = "Numărul 261 798 se rotunjeşte la zeci de mii la:  ";

                    button1.Text = "261 000 ";
                    button2.Text = "200 000 ";
                    button3.Text = "260 000 ";
                    button4.Text = "300 000 ";

                    correctAnswer = 3;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = "Termenul necunoscut din egalitatea   7 x a = 133 are valoarea: ";

                    button1.Text = "18";
                    button2.Text = "21";
                    button3.Text = "19";
                    button4.Text = "16";

                    correctAnswer = 3;

                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = "Suma dintre jumătatea şi sfertul numărului 116 este:";

                    button1.Text = "29";
                    button2.Text = "58";
                    button3.Text = "87";
                    button4.Text = "77";

                    correctAnswer = 3;

                    break;
                case 4:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Ce număr trebuie scăzut din 723 pentru a obține împătritul numărului 12? ";

                    button1.Text = "720 ";
                    button2.Text = "675";
                    button3.Text = "726";
                    button4.Text = "771";

                    correctAnswer = 2;

                    break;

                case 5:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Produsul a cinci numere naturale este 5. Suma lor este: ";

                    button1.Text = "5";
                    button2.Text = "9";
                    button3.Text = "25";
                    button4.Text = "4";

                    correctAnswer = 1;

                    break;

                case 6:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Termenul necunoscut din egalitatea 5xa=475 are valoarea:";

                    button1.Text = "75";
                    button2.Text = "95";
                    button3.Text = "85";
                    button4.Text = "125";

                    correctAnswer = 2;

                    break;

            }




        }

    }
}
