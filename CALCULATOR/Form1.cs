using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CALCULATOR
{
    public partial class my : Form
    {
        bool first = true;
        int n1, n2;
        char opr;
        
        public my()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            n2 = int.Parse(textBox1.Text);
            switch (opr)
            {
                case '+':
                    textBox1.Text=(n1+n2).ToString();
                    break;
                case '-':
                    textBox1.Text = (n1 - n2).ToString();
                    break;
                case '*':
                    textBox1.Text = (n1 * n2).ToString();
                    break;
                case '/':
                    if (n2==0)
                    {
                        textBox1.Text = "Undefined";
                        break;
                    }
                    textBox1.Text = (n1 / n2).ToString();
                    break;
                case 'c':
                    
                    textBox1.Text = (Math.Cos(n2)).ToString();
                    break;
                case 's':

                    textBox1.Text = (Math.Sin(n2)).ToString();
                    break;
                case 'l':
                    textBox1.Text = (Math.Log10(n2)).ToString();
                    break;
                case 't':
                    textBox1.Text = (Math.Tanh(n2)).ToString();
                    break;
                case 'a':
                    textBox1.Text = (Math.Abs(n2)).ToString();
                    break;
                case 'f':
                    int result = 1;
                    while (n2 != 1)
                    {
                        result = result * n2;
                        n2 = n2 - 1;
                    }
                    textBox1.Text = (result).ToString();
                    break;
                case 'm':
                    textBox1.Text = (n1%n2).ToString();
                    break;
                case 'p':
                    textBox1.Text = (Math.Pow(n1,n2)).ToString();
                    break;

            }
            first = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            n1 = (int)Math.Floor(num);

            opr = 'a';
            first = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (first)
            {
                textBox1.Text = "";
                first = false;
            }
            textBox1.Text += '3';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (first)
            {
                textBox1.Text = "";
                first = false;
            }
            textBox1.Text += '5';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            n1 = (int)Math.Floor(num);
            opr = '*';
            first = true;
        }

        private void my_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (first)
            {
                textBox1.Text = "";
                first = false;
            }
            textBox1.Text += '1';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (first)
            {
                textBox1.Text = "";
                first = false;
            }
            textBox1.Text += '2';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (first)
            {
                textBox1.Text = "";
                first = false;
            }
            textBox1.Text += '0';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (first)
            {
                textBox1.Text = "";
                first = false;
            }
            textBox1.Text += '6';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (first)
            {
                textBox1.Text = "";
                first = false;
            }
            textBox1.Text += '4';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (first)
            {
                textBox1.Text = "";
                first = false;
            }
            textBox1.Text += '7';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (first)
            {
                textBox1.Text = "";
                first = false;
            }
            textBox1.Text += '8';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            n1 = (int)Math.Floor(num);
            opr = '+';
            first = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text); 
            n1 = (int)Math.Floor(num);

            opr = '-';
            first = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            n1 = (int)Math.Floor(num);
            opr = '/';
            first = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            n1 = (int)Math.Floor(num);
            opr = 't';
            first = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            n1 = (int)Math.Floor(num);
            opr = 'c';
            first = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            n1 = (int)Math.Floor(num);
            opr = 'l';
            first = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            n1 = (int)Math.Floor(num);
            opr = 's';
            first = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            n1 = (int)Math.Floor(num);
            opr = 'f';
            first = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            n1 = (int)Math.Floor(num);
            opr = 'p';
            first = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            n1 = (int)Math.Floor(num);
            opr = 'm';
            first = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text.Remove(textBox1.Text.Length-1, 1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (first)
            {
                textBox1.Text = "";
                first = false;
            }
            textBox1.Text += '9';
        }
    }
}
