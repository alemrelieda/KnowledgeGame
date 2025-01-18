using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnowledgeQuizz
{
    public partial class Form1 : Form
        {   
            int correctAnswer;
            int questionNumber = 1;
            int score;
            int percentage;
            int totalQuestions;

        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject =(Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;

            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100 ) / totalQuestions);

                MessageBox.Show(
                    "Game Ended!" +Environment.NewLine + 
                    "You have answered " +score + " questions correctly." +Environment.NewLine +
                    "Your total percentage is " +percentage + "%" +Environment.NewLine +
                    "Click OK to play again"
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
                    pictureBox1.Image = Properties.Resources._4mevsim;

                    lblQuestion.Text = "How many seasons are there in a year?";

                    button1.Text = "1";
                    button2.Text = "2";
                    button3.Text = "3";
                    button4.Text = "4";

                    correctAnswer = 4;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.dunya;

                    lblQuestion.Text = "What is the fastest ground animal on the earth?";

                    button1.Text = "leopar";
                    button2.Text = "tiger";
                    button3.Text = "cheetah";
                    button4.Text = "lion";

                    correctAnswer = 3;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.Turkey;

                    lblQuestion.Text = "How many regions does Turkey have";

                    button1.Text = "4";
                    button2.Text = "7";
                    button3.Text = "10";
                    button4.Text = "5";

                    correctAnswer = 2;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.gezegen;

                    lblQuestion.Text = "How many planets are there in the solar system?";

                    button1.Text = "6";
                    button2.Text = "8";
                    button3.Text = "9";
                    button4.Text = "3";

                    correctAnswer = 2;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.italy;

                    lblQuestion.Text = "What is the capital of Italy?";

                    button1.Text = "Roma";
                    button2.Text = "Bakü";
                    button3.Text = "Milano";
                    button4.Text = "Ankara";

                    correctAnswer = 1;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.lakesalt;

                    lblQuestion.Text = "Which is the largest lake in Turkey?";

                    button1.Text = "Beyşehir Gölü";
                    button2.Text = "Tortum Gölü";
                    button3.Text = "Van Gölü";
                    button4.Text = "Akşehir Gölü";

                    correctAnswer = 3;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.kapıkaya;

                    lblQuestion.Text = "Which is the longest river in Turkey?";

                    button1.Text = "Kızılırmak";
                    button2.Text = "Yeşilırmak";
                    button3.Text = "Dicle";
                    button4.Text = "Fırat";

                    correctAnswer = 1;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.gezegen2;

                    lblQuestion.Text = "Which is the smallest planet?";

                    button1.Text = "Merkür";
                    button2.Text = "Venüs";
                    button3.Text = "Mars";
                    button4.Text = "Uranüs";

                    correctAnswer = 1;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.turkey_map;

                    lblQuestion.Text = "Who is our world-famous known Historian?";

                    button1.Text = "İlber Ortaylı";
                    button2.Text = "Halil İnalcık";
                    button3.Text = "Mehmet Fuat Köprülü";
                    button4.Text = "Cahit Arf";

                    correctAnswer = 2;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.voleybol;

                    lblQuestion.Text = "Which athlete wears different uniforms in volleyball?";

                    button1.Text = "Pasör";
                    button2.Text = "Kaptan";
                    button3.Text = "Smaçör";
                    button4.Text = "Libero";

                    correctAnswer = 4;

                    break;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
