using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0927
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//홀수합
            int num1, num2, sum = 0;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            textBox3.Text = "";
            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                    textBox3.Text = textBox3.Text + i + "+";
                }

            }
            textBox3.Text = textBox3.Text.Substring(0, textBox3.TextLength - 1) + "=" + sum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1, num2, sum = 0;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text); 
            textBox3.Text = "";
            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    textBox3.Text = textBox3.Text + i + "+";
                }

            }
            textBox3.Text = textBox3.Text.Substring(0, textBox3.TextLength - 1) + "=" + sum;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1, num2, sum = 0;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            textBox3.Text = "";
            for (int i = num1; i <= num2; i++)
            {
                sum += i;
                textBox3.Text = textBox3.Text + i + "+";
            }
            textBox3.Text = textBox3.Text.Substring(0, textBox3.TextLength - 1) + "=" + sum;
        }
    }
}
