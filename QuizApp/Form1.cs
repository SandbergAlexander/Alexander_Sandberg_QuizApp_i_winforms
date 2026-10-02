using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form1 : Form
    {
       static int antalC = 0;
        List<string> Frågor = new List<string>
        {
            "Vilket språk använder WinForms?",
            "Vad används en Button till?",
            "Vad heter Microsofts programmeringsspråk?",
            "Vad används en Label till?"
        };

        string[] rättaSvar =
        {
            "C#",
            "Utföra en handling",
            "C#",
            "Visa text"
        };

        string[] olikaSvar =
        {
            // Fråga 1
            "C#", "python#", "js", "c++",

            // Fråga 2
            "Utföra en handling", "ta bort en handling",
            "skapar en handling", "hämtar ett träd",

            // Fråga 3
            "C#", "python#", "js", "c++",

            // Fråga 4
            "Visa text", "ta bort", "hämtar", "ladda ner"
        };

        private int i = 0;
        private int antalRätt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void VisaFråga()
        {
            lblQuestion.Text = Frågor[i];

            button1.Text = olikaSvar[i * 4];
            button2.Text = olikaSvar[i * 4 + 1];
            button3.Text = olikaSvar[i * 4 + 2];
            button4.Text = olikaSvar[i * 4 + 3];
        }



        private void KontrolleraSvar(string svar)
        {
            if (svar == rättaSvar[i])
            {
                antalRätt++;
            }

            antalC++;

            label1.Text = antalRätt + "/" + Frågor.Count;

            i++;

            if (antalC == 4)
            {
                lblQuestion.Text = "Quizet är klart!";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

                label1.Text = "Resultat: " + antalRätt + "/" + Frågor.Count;

                return;
            }

            VisaFråga();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            KontrolleraSvar(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KontrolleraSvar(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KontrolleraSvar(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KontrolleraSvar(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
    

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0/" + Frågor.Count;
        }
    }
}
