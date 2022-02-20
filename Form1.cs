using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double Value1;

        double Value2;

        String Operator;

        double Result;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox1.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Operator = "/";

            Value1 = double.Parse(textBox1.Text);

            label1.Text = textBox1.Text + " / ";

            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Operator = "*";

            Value1 = double.Parse(textBox1.Text);

            label1.Text = textBox1.Text + " * ";

            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Operator = "-";

            Value1 = double.Parse(textBox1.Text);

            label1.Text = textBox1.Text + " - ";

            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Operator = "+";

            Value1 = double.Parse(textBox1.Text);

            label1.Text = textBox1.Text + " + ";

            textBox1.Clear();
        }


        private void button20_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                return;
            }

            Value2 = double.Parse(textBox1.Text);

            label1.Text = label1.Text + textBox1.Text + " = ";

            switch (Operator)
            {
                case "/":

                    Result = Value1 / Value2;

                    textBox1.Text = Result.ToString();

                    break;

                case "*":

                    Result = Value1 * Value2;

                    textBox1.Text = Result.ToString();

                    break;

                case "-":

                    Result = Value1 - Value2;

                    textBox1.Text = Result.ToString();

                    break;

                case "+":

                    Result = Value1 + Value2;

                    textBox1.Text = Result.ToString();

                    break;


            }


        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();

            label1.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1); ;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double Value = Convert.ToDouble(textBox1.Text);

            Value = Value * -1;

            textBox1.Text = Value.ToString();
        }
    }
}
