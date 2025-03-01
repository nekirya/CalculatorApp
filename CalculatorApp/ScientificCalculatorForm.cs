using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp// by GitHub @nekirya
{
    public partial class ScientificCalculatorForm : Form
    {
        private decimal firstNumber = 0;
        private string currentOperator = "";
        private decimal baseNumber = 0;
        private bool waitingForSecondOperand = false;
        private bool newNumberInput = true; // by GitHub @nekirya
        private bool waitingForSecondNumber = false;
        public ScientificCalculatorForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
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

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // by GitHub @nekirya
            if (decimal.TryParse(textBox1.Text, out firstNumber))
            {
                currentOperator = "+";  // by GitHub @nekirya
                textBox1.Text += "+";   // by GitHub @nekirya
                newNumberInput = true;  // by GitHub @nekirya
            }
            else
            {
                textBox1.Text = "Ошибка"; // by GitHub @nekirya
            }
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

        private void button24_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != "0")
            {
                if (textBox1.Text.Length == 1)
                {
                    textBox1.Text = "";
                }
                else
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            firstNumber = 0;
            currentOperator = "";
            newNumberInput = true;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal number))
            {
                if (number >= 0)
                {
                    number = (decimal)Math.Sqrt((double)number) * 2;
                    textBox1.Text = number.ToString();// by GitHub @nekirya
                }
                else
                {
                    textBox1.Text = "Ошибка: корень из отриц. числа";// by GitHub @nekirya
                }
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal number))
            {
                number = number * number;
                textBox1.Text = number.ToString();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal number))
            {
                if (number != 0)
                {
                    number = 1 / number;
                    textBox1.Text = number.ToString();
                }
                else// by GitHub @nekirya
                {
                    textBox1.Text = "Ошибка: деление на 0";
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            decimal currentValue = decimal.Parse(textBox1.Text);
            textBox1.Text = (-currentValue).ToString();// by GitHub @nekirya
        }

        private void button32_Click(object sender, EventArgs e)// by GitHub @nekirya
        {
            if (!waitingForSecondOperand)
            {
                // by GitHub @nekirya
                if (decimal.TryParse(textBox1.Text, out baseNumber))
                {
                    waitingForSecondOperand = true;
                    textBox1.Text = ""; // by GitHub @nekirya
                }
                else
                {
                    MessageBox.Show("Некорректный ввод числа!", "Ошибка");
                    textBox1.Text = "";
                }
            }
            else
            {
                // by GitHub @nekirya
                decimal exponent;
                if (decimal.TryParse(textBox1.Text, out exponent))
                {
                    try
                    {
                        decimal result = (decimal)Math.Pow((double)baseNumber, (double)exponent);
                        textBox1.Text = result.ToString();
                        baseNumber = 0; // by GitHub @nekirya
                        waitingForSecondOperand = false;
                    }
                    catch (OverflowException ex)
                    {
                        textBox1.Text = "Переполнение";
                    }
                }
                else
                {
                    MessageBox.Show("Некорректный ввод числа!", "Ошибка");
                    textBox1.Text = "0";
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3,1415926535897932384626433832795";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            try
            {
                decimal x = decimal.Parse(textBox1.Text);
                decimal result = (decimal)Math.Pow(10, (double)x);
                textBox1.Text = result.ToString();
            }
            catch (FormatException ex)
            {
                textBox1.Text = "Ошибка ввода";
            }
            catch (OverflowException ex)
            {
                textBox1.Text = "Переполнение";
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox1.Text);

                if (x <= 0)
                {
                    textBox1.Text = "Ошибка: X должен быть > 0";
                    return;
                }

                double result = Math.Log10(x); // by GitHub @nekirya
                textBox1.Text = result.ToString();
            }
            catch (FormatException ex)
            {
                textBox1.Text = "Ошибка ввода";
            }
            catch (Exception ex)
            {
                textBox1.Text = "Ошибка";
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox1.Text);

                if (x <= 0)
                {
                    textBox1.Text = "Ошибка: X должен быть > 0";
                    return;
                }

                double result = Math.Log(x); // by GitHub @nekirya
                textBox1.Text = result.ToString();
            }
            catch (FormatException ex)
            {
                textBox1.Text = "Ошибка ввода";
            }
            catch (Exception ex)
            {
                textBox1.Text = "Ошибка";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                decimal x = decimal.Parse(textBox1.Text);
                decimal result = Math.Abs(x);
                textBox1.Text = result.ToString();
            }
            catch (FormatException ex)
            {
                textBox1.Text = "Ошибка ввода";
            }
            catch (OverflowException ex)
            {
                textBox1.Text = "Переполнение";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox1.Text); // by GitHub @nekirya

                if (n < 0)
                {
                    textBox1.Text = "Ошибка: Факториал для отрицательных чисел не определён";
                    return;
                }
                else if (n > 20) // by GitHub @nekirya
                {
                    textBox1.Text = "Ошибка: Слишком большое число для факториала (макс. 20)";
                    return;
                }

                decimal factorial = CalculateFactorial(n); // by GitHub @nekirya
                textBox1.Text = factorial.ToString();
            }
            catch (FormatException ex)
            {
                textBox1.Text = "Ошибка ввода";
            }
            catch (OverflowException ex)
            {
                textBox1.Text = "Переполнение";
            }
        }

        private decimal CalculateFactorial(int n) // by GitHub @nekirya
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                decimal result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox1.Text);
                double result = Math.Exp(x);
                textBox1.Text = result.ToString();
            }
            catch (FormatException ex)
            {
                textBox1.Text = "Ошибка ввода";
            }
            catch (OverflowException ex)
            {
                textBox1.Text = "Переполнение";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (!waitingForSecondNumber)
            {
                // by GitHub @nekirya
                if (decimal.TryParse(textBox1.Text, out firstNumber))
                {
                    waitingForSecondNumber = true;
                    textBox1.Text = "0"; // by GitHub @nekirya
                }
                else
                {
                    MessageBox.Show("Некорректный ввод числа!", "Ошибка");
                    textBox1.Text = "0";
                }
            }
            else
            {
                // by GitHub @nekirya
                decimal secondNumber;
                if (decimal.TryParse(textBox1.Text, out secondNumber))
                {
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Деление на ноль невозможно!", "Ошибка");
                        textBox1.Text = "0";
                        waitingForSecondNumber = false; // by GitHub @nekirya
                        return;
                    }

                    decimal result = firstNumber % secondNumber;
                    textBox1.Text = result.ToString();
                    firstNumber = 0;
                    waitingForSecondNumber = false;
                }
                else
                {
                    MessageBox.Show("Некорректный ввод числа!", "Ошибка");
                    textBox1.Text = "0";
                }
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.E.ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {
            ProgrammerCalculatorForm newForm = new ProgrammerCalculatorForm();
            newForm.Show();
        }
    }
}
