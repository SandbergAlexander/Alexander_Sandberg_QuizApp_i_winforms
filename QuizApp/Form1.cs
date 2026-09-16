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
        string[] rättaSvar =
             {
    "C#",
    "Utföra en handling",
    "C#",
    "Visa text"
};
        string[] olikaSvar =
     {
    "C#",    "python#",    "js",    "c++",
    "Utföra en handling",   "ta bort en handling",   "skapar en handling",   "hämtar ett träd",
    "C#",    "python#",    "js",    "c++",
    "Visa text"   , "ta bort ",    "hämtar",    "ladda ner",   
};
        static int antalRätt = 0;

       public void KontrolleraSvar(string svar) {
        
        if (svar == rättaSvar[i])
            {

                antalRätt++;
            }
            label1.Text = antalRätt + "/" + Frågor.Count;
            i++;
            if (i>= Frågor.Count) {i=0; }
            
        }


        private int i = 0;


        public Form1()
        {
            InitializeComponent();
        }
 

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Text = olikaSvar[i];
            button2.Text = olikaSvar[i+2];
            button3.Text = olikaSvar[i+1];
            button4.Text = olikaSvar[i+3];

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

            button2.Text =  "/" + Frågor.Count;

            if (antalRätt != 4)
            {
                        antalRätt++;


            }
            else {    antalRätt = 4; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

   
        }

        private void button4_Click(object sender, EventArgs e)
        {

            
        }

       private void Form1_Load(object sender, EventArgs e)
        {

        }
 }
}
