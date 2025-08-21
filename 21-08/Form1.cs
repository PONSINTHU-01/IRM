using System;
using System.Windows.Forms;

namespace forms
{
    public partial class Form1 : Form
    {
        string currentInput = "";
        double result = 0;
        string operation = "";
        bool operationPending = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentInput == "") return; 

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
            catch (Exception)
            {
                textBox1.Text = "Error";
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            try
            {
                Evaluate();
            }
            catch (Exception)
            {
                textBox1.Text = "Error";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            operation = "";
            operationPending = false;
            textBox1.Text = "";
        }


        private void Evaluate()
        {
            double secondNumber = double.Parse(currentInput);

            switch (operation)
            {
                case "+": result += secondNumber; break;
                case "-": result -= secondNumber; break;
                case "*": result *= secondNumber; break;
                case "/":
                    if (secondNumber != 0)
                        result /= secondNumber;
                    else
                    {
                        textBox1.Text = "Cannot divide by zero";
                        return;
                    }
                    break;
            }

            textBox1.Text = result.ToString();
            currentInput = "";
            operationPending = false;
        }
    }
}
