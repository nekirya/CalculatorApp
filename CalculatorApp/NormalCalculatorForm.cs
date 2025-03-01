// by GitHub @nekirya
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// by GitHub @nekirya
namespace CalculatorApp

{
    public partial class NormalCalculatorForm : Form
    {
        private decimal firstNumber = 0;
        private string currentOperator = "";
        private bool newNumberInput = true; // by GitHub @nekirya
        public NormalCalculatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // by GitHub @nekirya
            if (decimal.TryParse(textBox1.Text, out firstNumber))
            {
                currentOperator = "+";  // by GitHub @nekirya
                textBox1.Text += "+";   // by GitHub @nekirya
                newNumberInput = true;  // by GitHub @nekirya// by GitHub @nekirya// by GitHub @nekirya// by GitHub @nekirya
            }
            else
            {
                textBox1.Text = "Ошибка"; // by GitHub @nekirya// by GitHub @nekirya
            }
        }// by GitHub @nekirya
        // by GitHub @nekirya
        private void button14_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out firstNumber))
            {
                currentOperator = "-";
                textBox1.Text += "-";  // by GitHub @nekirya
                newNumberInput = true;
            }
            else
            {
                textBox1.Text = "Ошибка";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out firstNumber))
            {
                currentOperator = "*";
                textBox1.Text += "*";  // by GitHub @nekirya
                newNumberInput = true;
            }
            else
            {
                textBox1.Text = "Ошибка";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out firstNumber))
            {
                currentOperator = "/";
                textBox1.Text += "/";  // by GitHub @nekirya
                newNumberInput = true;
            }
            else
            {
                textBox1.Text = "Ошибка";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal secondNumber))
            {
                secondNumber = firstNumber * (secondNumber / 100); // by GitHub @nekirya
                textBox1.Text = secondNumber.ToString();
            }
            else
            {
                textBox1.Text = "Ошибка";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            firstNumber = 0;
            currentOperator = "";
            newNumberInput = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            decimal secondNumber;

            // by GitHub @nekirya
            string secondNumberText = textBox1.Text.Split(new char[] { '+', '-', '*', '/' })[1]; // by GitHub @nekirya
            if (!decimal.TryParse(secondNumberText, out secondNumber))
            {
                textBox1.Text = "Ошибка"; // by GitHub @nekirya
                return;
            }

            decimal result = 0;

            // by GitHub @nekirya
            switch (currentOperator)
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
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                    }
                    else
                    {
                        textBox1.Text = "Ошибка: деление на 0";
                        return;
                    }
                    break;
                default:
                    textBox1.Text = "Ошибка: неверный оператор";
                    return;
            }
            // by GitHub @nekirya
            textBox1.Text = result.ToString();
            currentOperator = ""; // by GitHub @nekirya
            newNumberInput = true; // by GitHub @nekirya
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            newNumberInput = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            decimal currentValue = decimal.Parse(textBox1.Text);
            textBox1.Text = (-currentValue).ToString();
        }// by GitHub @nekirya

        private void NormalCalculatorForm_Load(object sender, EventArgs e)
        {
            // by GitHub @nekirya
        }// by GitHub @nekirya

        private void button17_Click(object sender, EventArgs e) // by GitHub @nekirya
        {
            if (decimal.TryParse(textBox1.Text, out decimal number))
            {
                if (number != 0)
                {
                    number = 1 / number; // by GitHub @nekirya
                    textBox1.Text = number.ToString();
                }
                else
                {
                    textBox1.Text = "Ошибка: деление на 0"; // by GitHub @nekirya
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal number))
            { // by GitHub @nekirya
                number = number * number;
                textBox1.Text = number.ToString();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal number))
            { // by GitHub @nekirya
                if (number >= 0)
                {
                    number = (decimal)Math.Sqrt((double)number) * 2;
                    textBox1.Text = number.ToString();
                }
                else
                {
                    textBox1.Text = "Ошибка: корень из отриц. числа";
                } // by GitHub @nekirya
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != "0")
            {
                if (textBox1.Text.Length == 1)
                {
                    textBox1.Text = "";
                }
                else // by GitHub @nekirya
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }// by GitHub @nekirya
            }
        }
        // by GitHub @nekirya


        private void button25_Click_1(object sender, EventArgs e)
        {
            ScientificCalculatorForm newForm = new ScientificCalculatorForm();
            newForm.Show();
        }// by GitHub @nekirya

        private void label1_Click(object sender, EventArgs e)
        {
            // by GitHub @nekirya
        }
    }
}
