using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void numbertext_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {         
                numbertext.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numbertext.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numbertext.Text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numbertext.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numbertext.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numbertext.Text += '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numbertext.Text += '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numbertext.Text += '8'; 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numbertext.Text += '9';
        }

        private void button0_Click(object sender, EventArgs e)
        {
            numbertext.Text += '0';
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            numbertext.Text = "";
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            numbertext.Text += '+';
                
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            numbertext.Text += '-';
        }

        private void buttonmulti_Click(object sender, EventArgs e)
        {
            numbertext.Text += 'X';
        }

        private void buttondevide_Click(object sender, EventArgs e)
        {
            numbertext.Text += '/';
        }
        private void buttondot_Click(object sender, EventArgs e)
        {
            numbertext.Text += '.';
        }

        private void buttonequl_Click(object sender, EventArgs e)
        {
            numbertext.Text += '=';
            float num = 0;
            float num2 = 0;
            int i = 0;
            char sym;
            float result;
            String n = "";
            String m = "";
            String exp = numbertext.Text;



            while (!(exp[i] == '+' || exp[i] == '-' || exp[i] == 'X' || exp[i] == '/'))
            {
                n = n + exp[i];
                i++;
            }

            num = float.Parse(n);

            sym = exp[i];
            i = i + 1;

            while (!(exp[i] == '='))
            {
                m = m + exp[i];
                i++;
            }
            num2 = float.Parse(m);
              
                         

              if (sym == '+')
              {
                  result = num + num2;
                  numbertext.Text = result.ToString();
              }
              else if (sym == '-')
              {
                  result = num - num2;
                  numbertext.Text = result.ToString();
              }
              else if (sym == '/')
              {
                  Double result1 = (Double)num / num2;
                  numbertext.Text = result1.ToString();
              }
              else if (sym == 'X')
              {
                  result = num * num2;
                  numbertext.Text = result.ToString();
              }
            
        }       
    }
}
