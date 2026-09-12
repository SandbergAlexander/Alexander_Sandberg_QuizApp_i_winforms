using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{

    public partial class Form1 : Form
    {
    int antalRätt = 0; 

        public Form1()
        {
            InitializeComponent();
        //    lblQuestion.Text = "Din nya text";


        }

        private void button5_Click(object sender, EventArgs e)
        {

        
            string värde = label1.Text;

            MessageBox.Show(värde);
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            antalRätt = 1;
            label1.Text = "1/1"+" rätt svar det är c#";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            antalRätt = 0;
            label1.Text = "0/1" + " Fel";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            antalRätt = 0;
            label1.Text = "0/1" + " Fel";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            antalRätt = 0;
            label1.Text = "0/1" + " Fel";
        }
    }
}
