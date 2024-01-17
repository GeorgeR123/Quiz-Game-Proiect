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
    public partial class CGLV1 : Form
    {

        // variables list for this quiz game
        int correctAnswer;
        int questionNumber = 1;
        int player_score;
        int score;
        int percentage;
        int totalQuestions;
        int totalScore;

        

        public CGLV1()
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

                player_score = score;
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

                    pictureBox1.Image = Properties.Resources.anul_are;
                    lblQuestion.Text = "Anul are:";

                    button1.Text = " 2 anotimpuri ";
                    button2.Text = " 4 anotimpuri";
                    button3.Text = " 3 anotimpuri";
                    button4.Text = "1 anotimp ";

                    correctAnswer = 2;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Elevii_încep_şcoala_în_anotimpul_;
                    lblQuestion.Text = "Elevii încep şcoala în anotimpul : ";

                    button1.Text = " Primăvara ";
                    button2.Text = " Vara ";
                    button3.Text = " Toamna ";
                    button4.Text = " Iarna ";

                    correctAnswer = 3;

                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.prima_luna_de_primavara;

                    lblQuestion.Text = " Prima lună de primăvară este luna:";

                    button1.Text = " decembrie";
                    button2.Text = " septembrie";
                    button3.Text = "martie";
                    button4.Text = "august ";

                    correctAnswer = 3;

                    break;

                case 4:

                    pictureBox1.Image = Properties.Resources.ziua_femeii;

                    lblQuestion.Text = " Ziua Femeii este la : ";

                    button1.Text = "1 decembrie";
                    button2.Text = " 24 ianuarie";
                    button3.Text = "1 iunie";
                    button4.Text = " 8 martie";

                    correctAnswer = 4;

                    break;

                case 5:

                    pictureBox1.Image = Properties.Resources.vestitor;

                    lblQuestion.Text = " Vestitorul primăverii este : ";

                    button1.Text = " trandafirul";
                    button2.Text = " laleaua ";
                    button3.Text = " ghiocelul";
                    button4.Text = " macul";

                    correctAnswer = 3;

                    break;

                case 6:

                    pictureBox1.Image = Properties.Resources.ce_fenomen_iarna;

                    lblQuestion.Text = "Ce fenomen al naturii întâlnim frecvent în anotimpul iarna ? ";

                    button1.Text = " ploi ";
                    button2.Text = " grindină ";
                    button3.Text = "brumă ";
                    button4.Text = "ninsoare";

                    correctAnswer = 4;

                    break;

                case 7:

                    pictureBox1.Image = Properties.Resources.copac_iarna;

                    lblQuestion.Text = "Ce copac îşi păstrează frunzele în timpul iernii?";

                    button1.Text = "  fagul  ";
                    button2.Text = " stejarul ";
                    button3.Text = "bradul";
                    button4.Text = "gutuiul  ";

                    correctAnswer = 3;

                    break;

                case 8:

                    pictureBox1.Image = Properties.Resources.capracutrei;

                    lblQuestion.Text = " Cine a mâncat cei doi iezi din povestea Capra cu trei iezi?";

                    button1.Text = "ursul";
                    button2.Text = "capra";
                    button3.Text = "lupul";
                    button4.Text = "vulpea";

                    correctAnswer = 3;

                    break;




            }




        }

    }
}
