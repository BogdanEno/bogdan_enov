using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double a = 0, b = 0, c = 0;
        bool check = true;
        char Symbol = '+';
        public Form1()
        {
            InitializeComponent();
        }

        private void beq_Click(object sender, EventArgs e)
        {
            switch (Symbol)
            {
                case '+' : 
                    b = Convert.ToDouble(textBox1.Text);
                    c = a + b;
                    label2.Text = c.ToString();
                    Symbol = '|';     
                    break;
                case '-':
                    b = Convert.ToDouble(textBox1.Text);
                    c = a - b;
                    label2.Text = c.ToString();
                    Symbol = '/';
                    break;
                case 'X':
                    b = Convert.ToDouble(textBox1.Text);
                    c = a * b;
                    label2.Text = c.ToString();
                    Symbol = ']';
                    break;
                case '÷':
                    b = Convert.ToDouble(textBox1.Text);
                    c = a / b;
                    label2.Text = c.ToString();
                    Symbol = '[';
                    break;
                case '|':
                    c += b;
                    break;
                case '/':
                    c -= b;
                    break;
                case ']':
                    c *= b;
                    break;
                case '[':
                    c /= b;
                    break;
                default:
                    break;
            }
            textBox1.Text = c.ToString();
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void plusOrMinus_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if(textBox1.Text[0] == '-')
                {
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                } else
                {
                    textBox1.Text = '-' + textBox1.Text;
                }
            }
        }

        private void BackSpace_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "0";
            label4.Text = "?";
            Symbol = '=';
            check = false;
        }

        private void perX_Click(object sender, EventArgs e)
        {
            label4.Text = "%";
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text)/100);
            label2.Text = textBox1.Text;
        }

        private void quadX_Click(object sender, EventArgs e)
        {
            label4.Text = "√";
            textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
            label2.Text = textBox1.Text;
        }

        private void sqrtX_Click(object sender, EventArgs e)
        {
            label4.Text = "x²";
            textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text), 2));
            label2.Text = textBox1.Text;
        }

        private void devX_Click(object sender, EventArgs e)
        {
            label4.Text = "1/X";
            textBox1.Text = Convert.ToString(1/Convert.ToDouble(textBox1.Text));
            label2.Text = textBox1.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(','))
            {
                bfloat.Enabled = false;
            }
            else bfloat.Enabled = true;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { 
                if (check == false)
                {
                    textBox1.Clear();
                    textBox1.Text += (sender as Button).Text;
                    Symbol = '+';
                    label4.Text = "?";
                    check = true;
                }
                else
                {
                    textBox1.Clear();
                    textBox1.Text += (sender as Button).Text;
                }
            }
            else if(Symbol == '=')
            {
                Symbol = '+';
                textBox1.Clear();
                textBox1.Text += (sender as Button).Text; 
            }
            else if(label4.Text != "+" & label4.Text != "-" & label4.Text != "X" & label4.Text != "÷" & label4.Text != "?")
            {
                label4.Text = "?";
                textBox1.Clear();
                textBox1.Text += (sender as Button).Text;
            }
            else
            {
                textBox1.Text += (sender as Button).Text;
            }
        }

        private void sum_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            Symbol = (sender as Button).Text[0];
            label4.Text = Symbol.ToString();
            label2.Text = Convert.ToString(a);
            textBox1.Text = "";
        }
    }
}
