using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCalc
{
    public partial class Form1 : Form
    {

        decimal val1 = 0, val2 = 0, result = 0;
        string oper = "="; // precisa iniciar com  "=";
        bool digitando = false; // se já iniciou digitar numero
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            Calcula();
            lblOper.Text = oper = "+";
        }
        private void buttonSubt_Click(object sender, EventArgs e)
        {
            Calcula();
            lblOper.Text = oper = "-";
        }
        private void buttonMult_Click(object sender, EventArgs e)
        {
            Calcula();
            lblOper.Text = oper = "*";
        }
        private void buttonDivi_Click(object sender, EventArgs e)
        {
            Calcula();
            lblOper.Text = oper = "/";
        }
        private void buttonEqua_Click(object sender, EventArgs e)
        {

            Calcula();
            lblOper.Text = oper = "=";
        }

        void Calcula() //fecha o cálculo do operador anterior
        {
            digitando = false;
            val1 = decimal.Parse(txtVisor.Text);
            if (oper == "+")
            {
                result += val1;
                LimpaVisor();
            }
            else if (oper == "-")
            {
                result -= val1;
                LimpaVisor();
            }
            else if (oper == "*")
            {
                result *= val1;
                LimpaVisor();
            }
            else if (oper == "/")
            {
                result /= val1;
                LimpaVisor();
            }
            else // oper anterior é "="
            {
                result = val1;

              //   txtVisor.Text = Convert.ToString(result);  // por como comentário
              //   txtOper.Text = txtVisor.Text;  // por como comentário
            }
            txtOper.Text = Convert.ToString(result);

        }



        void LimpaVisor()
        {
            lblOper.Text = oper;
            txtVisor.Text = "";
            val1 = 0;
        }
        void TeclaNum(string n)
        {
            if (!digitando)
            {
              //   txtOper.Text = txtVisor.Text; //  por como comentário
                LimpaVisor();
            }
            txtVisor.Text += n;
            digitando = true;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            TeclaNum("0");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TeclaNum("1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TeclaNum("2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            TeclaNum("3");

        }
        private void button4_Click(object sender, EventArgs e)
        {
            TeclaNum("4");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            TeclaNum("5");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            TeclaNum("6");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            TeclaNum("7");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            TeclaNum("8");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            TeclaNum("9");
        }

    }
}
