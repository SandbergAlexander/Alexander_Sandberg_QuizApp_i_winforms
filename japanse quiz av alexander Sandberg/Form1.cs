using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace japanse_quiz_av_alexander_Sandberg
{
    public partial class Form1 : Form
    {
        List<string> frågor = new List<string>();

        string[] rättsvar =
        {
            "Katakana",
            "Kinesiska tecken som används i japanskan"
        };

        int frågaNummer = 0;
        int poäng = 0;

        public Form1()
        {
            InitializeComponent();

            frågor.Add("Vad heter det japanska alfabetet som används för främmande ord?");
            frågor.Add("Vad används Kanji främst för?");

            VisaFråga();
        }

        private void VisaFråga()
        {
            // Byt label1 till namnet på din fråge-label
            label1.Text = frågor[frågaNummer];

            // Exempel på svarsalternativ
            button1.Text = frågaNummer == 0
                ? "Katakana"
                : "Kinesiska tecken som används i japanskan";

            button2.Text = frågaNummer == 0
                ? "Hiragana"
                : "Endast siffror";

            button3.Text = frågaNummer == 0
                ? "Kanji"
                : "Endast utländska ord";
        }

        private void KontrolleraSvar(string svar)
        {
            if (svar == rättsvar[frågaNummer])
            {
                poäng++;
                MessageBox.Show("Rätt!");
            }
            else
            {
                MessageBox.Show("Fel!");
            }

            frågaNummer++;

            if (frågaNummer < frågor.Count)
            {
                VisaFråga();
            }
            else
            {
                MessageBox.Show("Quiz klart! Poäng: " + poäng + "/" + frågor.Count);
            }
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
    }
}
