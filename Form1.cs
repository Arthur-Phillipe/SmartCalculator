using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Windows.Forms;

namespace SmartCalc
{
    public partial class Form1 : Form
    {

        decimal val1 = 0, val2 = 0, result = 0;
        string oper = ""; // precisa iniciar com  "=";
        bool digitando = false; // se tá no meio da digitação do numero
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            lblOper.Text =  "+";
            Calcula();
            oper = "+";
        }
        private void buttonSubt_Click(object sender, EventArgs e)
        {
            lblOper.Text = "-";
            Calcula();
            oper = "-";
        }
        private void buttonMult_Click(object sender, EventArgs e)
        {
            lblOper.Text = "*";
            Calcula();
            oper = "*";
        }
        private void buttonDivi_Click(object sender, EventArgs e)
        {
            lblOper.Text = "/";
            Calcula();
            oper = "/";
        }
        private void buttonEqua_Click(object sender, EventArgs e)
        {
            lblOper.Text = "=";  
            Calcula();
            oper = "=";
        }

        void Calcula() //fecha o cálculo do operador anterior
        {
            digitando = false;
     
            val1 = decimal.Parse(txtVisor.Text);
            if (oper == "+")
            {
                result += val1;
               
            }
            else if (oper == "-")
            {
                result -= val1;
            
            }
            else if (oper == "*")
            {
                result *= val1;
              
            }
            else if (oper == "/")
            {
                result /= val1;
               
            }
            else // oper anterior é "=" INICIA AQUI (VOLTA ESTADO INICIAL)
            {
                result = val1;
                txtVisor.Text = Convert.ToString(result);
               
            }
            txtOper.Text = Convert.ToString(result);

            if (lblOper.Text == "=") txtVisor.Text = txtOper.Text;
            else LimpaVisor(); 
        }

        void LimpaVisor()
        {
    
            txtVisor.Text = "";
            
        }
        void TeclaNum(string n)
        {
            if (!digitando)
            {
                lblOper.Text = oper;
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
