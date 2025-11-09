using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form

    {
        double firstNumber, secondNumber, result;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button01_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "Result:";

        }

        // ------------------ NUMBER BUTTONS ------------------
        private void button1_Click(object sender, EventArgs e) { textBox1.Text += "1"; }
        private void button2_Click(object sender, EventArgs e) { textBox1.Text += "2"; }
        private void button3_Click(object sender, EventArgs e) { textBox1.Text += "3"; }
        private void button4_Click(object sender, EventArgs e) { textBox1.Text += "4"; }
        private void button5_Click(object sender, EventArgs e) { textBox1.Text += "5"; }
        private void button7_Click(object sender, EventArgs e) { textBox1.Text += "6"; }
        private void button8_Click(object sender, EventArgs e) { textBox1.Text += "7"; }
        private void button9_Click(object sender, EventArgs e) { textBox1.Text += "8"; }
        private void button10_Click(object sender, EventArgs e) { textBox1.Text += "9"; }
        private void button11_Click(object sender, EventArgs e) { textBox1.Text += "0"; }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                firstNumber = Convert.ToDouble(textBox1.Text);
                operation = "+";
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Enter a number first!");
            }
        }

        private void buttonmines_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                firstNumber = Convert.ToDouble(textBox1.Text);
                operation = "-";
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Enter a number first!");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                firstNumber = Convert.ToDouble(textBox1.Text);
                operation = "*";
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Enter a number first!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                firstNumber = Convert.ToDouble(textBox1.Text);
                operation = "/";
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Enter a number first!");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                secondNumber = Convert.ToDouble(textBox1.Text);
                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        if (secondNumber == 0)
                        {
                            MessageBox.Show("Cannot divide by zero!");
                            return;
                        }
                        result = firstNumber / secondNumber;
                        break;
                }

                label1.Text = "Result: " + result.ToString();
                textBox1.Clear();
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers before pressing '='.");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "Result:";
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button011_Click(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
