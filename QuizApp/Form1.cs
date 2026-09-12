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
    List<string> Frågor = new List<string>
    {
    "Vilket språk använder WinForms?",
    "Vad används en Button till?",
    "Vad heter Microsofts programmeringsspråk?",
    "Vad används en Label till?"
    };

      private int antalRätt = 0;
      private  int i = 0;


        public Form1()
        {
            InitializeComponent();
            Frågor.Add("Vilket språk använder WinForms?");
        }

        private void button5_Click(object sender, EventArgs e)
        {            
        
            lblQuestion.Text = Frågor[i];
            i++;
            if (i >= Frågor.Count) {
                i = 0; 

            }
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

         antalRätt = 1;
         label1.Text = "1/1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            antalRätt = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            antalRätt = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            antalRätt = 0;
        }

       private void Form1_Load(object sender, EventArgs e)
        {

        }
 }
}
