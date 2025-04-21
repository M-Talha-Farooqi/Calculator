using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_1
{
    public partial class Form1 : Form
    {
        // Variable Declarations
        string currentInput = "";
        double result;
        string operation = "";
        bool operationPending = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Downcasting of a button
            Button button = (Button)sender;
            // Getting Button Value pressed
            currentInput = currentInput + button.Text;
            // Passing and showing value entered by button in TEXT BOX
            textBox1.Text = currentInput;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Downcasting of a button
            Button button = (Button)sender;
            // Getting Button Value pressed
            currentInput = currentInput + button.Text;
            // Passing and showing value entered by button in TEXT BOX
            textBox1.Text = currentInput;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            operation = "";
            operationPending = false;
            textBox1.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Evaluate();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            // Downcasting of a button
            Button button = (Button)sender;
            // Getting Button Value pressed
            currentInput = currentInput + button.Text;
            // Passing and showing value entered by button in TEXT BOX
            textBox1.Text = currentInput;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            // Downcasting of a button
            Button button = (Button)sender;
            // Getting Button Value pressed
            currentInput = currentInput + button.Text;
            // Passing and showing value entered by button in TEXT BOX
            textBox1.Text = currentInput;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            // Downcasting of a button
            Button button = (Button)sender;
            // Getting Button Value pressed
            currentInput = currentInput + button.Text;
            // Passing and showing value entered by button in TEXT BOX
            textBox1.Text = currentInput;
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            // Downcasting of a button
            Button button = (Button)sender;
            // Getting Button Value pressed
            currentInput = currentInput + button.Text;
            // Passing and showing value entered by button in TEXT BOX
            textBox1.Text = currentInput;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            // Downcasting of a button
            Button button = (Button)sender;
            // Getting Button Value pressed
            currentInput = currentInput + button.Text;
            // Passing and showing value entered by button in TEXT BOX
            textBox1.Text = currentInput;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            // Downcasting of a button
            Button button = (Button)sender;
            // Getting Button Value pressed
            currentInput = currentInput + button.Text;
            // Passing and showing value entered by button in TEXT BOX
            textBox1.Text = currentInput;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            // Downcasting of a button
            Button button = (Button)sender;
            // Getting Button Value pressed
            currentInput = currentInput + button.Text;
            // Passing and showing value entered by button in TEXT BOX
            textBox1.Text = currentInput;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            // Downcasting of a button
            Button button = (Button)sender;
            // Getting Button Value pressed
            currentInput = currentInput + button.Text;
            // Passing and showing value entered by button in TEXT BOX
            textBox1.Text = currentInput;
        }

        // function
        private void Evaluate()
        {
            if (operationPending)
            {
                double secondNumber = double.Parse(currentInput);

                switch (operation)
                {
                    case "+":
                        {
                            result += secondNumber;
                            break;
                        }

                    case "-":
                        {
                            result -= secondNumber;
                            break;
                        }

                    case "*":
                        {
                            result *= secondNumber;
                            break;
                        }

                    case "/":
                        {
                            if (secondNumber != 0)
                            {
                                result /= secondNumber;
                            }
                            else
                            {
                                textBox1.Text = "Error!";
                                return;
                            }

                            break;

                        }

                }
                textBox1.Text = result.ToString();
                currentInput = "";
                operationPending = false;
            }

        }

    }
}
