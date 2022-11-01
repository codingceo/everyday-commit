using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_2_계산기프로젝트_최승호_1A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6"); // = textBox1.Text = textBox1.Text = "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            textBox1.AppendText("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.AppendText("000");
        }
        Boolean bJieom_Flag = false; // true : 점 직힘, False : 점 안찍힘
        private void button10_Click(object sender, EventArgs e)
        {//"." 버튼을 눌렀을 때
            if (bJieom_Flag == false)
            {
                if (textBox1.Text == "")
                    textBox1.Text = "0";
                textBox1.AppendText(".");
                bJieom_Flag = true;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {// "C"버튼을 눌었을 때
            textBox1.Text = "";
            bJieom_Flag = false;

        }

        private void button14_Click(object sender, EventArgs e)
        {// "<-" 버튼을 눌렀을 때
            if (textBox1.Text != "")
            {
                if (textBox1.Text.Substring(textBox1.TextLength - 1) == ".")
                    bJieom_Flag = false; // 그전에 "." 깃발 올렸던거 내리게하기
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
                if (textBox1.Text == "0") // "0." 한 번찍고 "." 지우면 0이 계속 남아있고 그 뒤에 숫자 입력하면 "01234" 이렇게 이상하게 되잖아 그래서 0만 남아있으면 다 지우게 하는 것
                    textBox1.Text = "";
            }
                

        }
    }
}
