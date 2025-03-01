// by GitHub @nekirya
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// by GitHub @nekirya
namespace CalculatorApp
{
    public partial class ProgrammerCalculatorForm : Form
    {
        public ProgrammerCalculatorForm()
        {
            InitializeComponent();// by GitHub @nekirya
        }

        private void button25_Click(object sender, EventArgs e)
        {
            buttonsToMakeTransparent.Clear();
            // by GitHub @nekirya
            buttonsToMakeTransparent.Add(button3);
            buttonsToMakeTransparent.Add(button4);
            buttonsToMakeTransparent.Add(button5);
            buttonsToMakeTransparent.Add(button6);
            buttonsToMakeTransparent.Add(button7);// by GitHub @nekirya
            buttonsToMakeTransparent.Add(button8);
            buttonsToMakeTransparent.Add(button9);
            buttonsToMakeTransparent.Add(button10);
            buttonsToMakeTransparent.Add(button30);
            buttonsToMakeTransparent.Add(button31);
            buttonsToMakeTransparent.Add(button32);
            buttonsToMakeTransparent.Add(button33);
            buttonsToMakeTransparent.Add(button34);
            buttonsToMakeTransparent.Add(button36);

            foreach (Button button in buttonsToMakeTransparent)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.BackColor = Color.Transparent;
                button.ForeColor = desiredTextColor;
                button.Enabled = false;
            }// by GitHub @nekirya
        }
        private List<Button> buttonsToMakeTransparent = new List<Button>();
        private Color desiredTextColor = Color.Gray; 

        private void button28_Click(object sender, EventArgs e)
        {
            
            buttonsToMakeTransparent.Clear();

            // by GitHub @nekirya
            buttonsToMakeTransparent.Add(button30);
            buttonsToMakeTransparent.Add(button31);
            buttonsToMakeTransparent.Add(button32);
            buttonsToMakeTransparent.Add(button33);
            buttonsToMakeTransparent.Add(button34);// by GitHub @nekirya
            buttonsToMakeTransparent.Add(button36);

            foreach (Button button in buttonsToMakeTransparent)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0; 

                button.BackColor = Color.Transparent; 
                button.ForeColor = desiredTextColor; 
                button.Enabled = false; 
            }
        }
        // by GitHub @nekirya
        private void button23_Click(object sender, EventArgs e)
        {
            
            buttonsToMakeTransparent.Clear();


            
            buttonsToMakeTransparent.Add(button9);
            buttonsToMakeTransparent.Add(button10);                         // by GitHub @nekirya
            buttonsToMakeTransparent.Add(button30);
            buttonsToMakeTransparent.Add(button31);
            buttonsToMakeTransparent.Add(button32);
            buttonsToMakeTransparent.Add(button33);
            buttonsToMakeTransparent.Add(button34);
            buttonsToMakeTransparent.Add(button36);

            foreach (Button button in buttonsToMakeTransparent)
            {
                button.FlatStyle = FlatStyle.Flat;           // by GitHub @nekirya
                button.FlatAppearance.BorderSize = 0; 
                button.BackColor = Color.Transparent; 
                button.ForeColor = desiredTextColor;  // by GitHub @nekirya
                button.Enabled = false; 
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8"; // by GitHub @nekirya
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // by GitHub @nekirya
        }
        // by GitHub @nekirya
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";

        }
        // by GitHub @nekirya
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";

        }
        // by GitHub @nekirya
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }
        // by GitHub @nekirya
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }
        // by GitHub @nekirya
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
        // by GitHub @nekirya
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }
        // by GitHub @nekirya
        // by GitHub @nekirya

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
        // by GitHub @nekirya
        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }
        // by GitHub @nekirya
        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }
        // by GitHub @nekirya
        private struct ButtonOriginalState
        {
            public FlatStyle FlatStyle;
            public int BorderSize;
            public Color BackColor;
            public Color ForeColor;
            public bool Enabled;
        }
        private void button27_Click(object sender, EventArgs e)
        {
            
            buttonsToMakeTransparent.Clear();
            // by GitHub @nekirya

            buttonsToMakeTransparent.Add(button3);
            buttonsToMakeTransparent.Add(button4);
            buttonsToMakeTransparent.Add(button5);
            buttonsToMakeTransparent.Add(button6);
            buttonsToMakeTransparent.Add(button7);
            buttonsToMakeTransparent.Add(button8);
            buttonsToMakeTransparent.Add(button9);
            buttonsToMakeTransparent.Add(button10);
            buttonsToMakeTransparent.Add(button30);
            buttonsToMakeTransparent.Add(button31);
            buttonsToMakeTransparent.Add(button32);
            buttonsToMakeTransparent.Add(button33);
            buttonsToMakeTransparent.Add(button34);
            buttonsToMakeTransparent.Add(button36);
            // by GitHub @nekirya
            foreach (Button button in buttonsToMakeTransparent)
            {
                if (!originalButtonStates.ContainsKey(button))
                {
                    
                    originalButtonStates[button] = new ButtonOriginalState
                    {
                        FlatStyle = button.FlatStyle,
                        BorderSize = button.FlatAppearance.BorderSize,
                        BackColor = button.BackColor,
                        ForeColor = button.ForeColor,
                        Enabled = button.Enabled
                    };
                }

                // by GitHub @nekirya
                button.FlatStyle = FlatStyle.Flat; 
                button.FlatAppearance.BorderSize = 0; 

                button.BackColor = Color.FromArgb(255, 64, 64, 64); 

                button.ForeColor = Color.White;
                button.Enabled = true;
            }
        }
        // by GitHub @nekirya
        private Dictionary<Button, ButtonOriginalState> originalButtonStates = new Dictionary<Button, ButtonOriginalState>();
        private void buttonResetButtons_Click(object sender, EventArgs e)
        {
            foreach (Button button in buttonsToMakeTransparent)
            {
                if (originalButtonStates.ContainsKey(button))
                {
                    // by GitHub @nekirya
                    button.FlatStyle = originalButtonStates[button].FlatStyle;
                    button.FlatAppearance.BorderSize = originalButtonStates[button].BorderSize;
                    button.BackColor = originalButtonStates[button].BackColor;
                    button.ForeColor = originalButtonStates[button].ForeColor;
                    button.Enabled = originalButtonStates[button].Enabled;
                }
            }

            // by GitHub @nekirya
            buttonsToMakeTransparent.Clear();
            originalButtonStates.Clear();
        }
    }
}
