using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        // Class-Level Variables (as per slide 2)
        private string currentInput = "";
        private double firstNumber = 0;
        private double secondNumber = 0;
        private string currentOperator = "";
        private bool isNewInput = true;

        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for number buttons (0-9)
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isNewInput)
            {
                txtDisplay.Text = "";
                isNewInput = false;
            }

            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = button.Text;
            }
            else
            {
                txtDisplay.Text += button.Text;
            }

            currentInput = txtDisplay.Text;
        }

        // Event handler for decimal point button
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                txtDisplay.Text = "0";
                isNewInput = false;
            }

            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }

            currentInput = txtDisplay.Text;
        }

        // Event handler for operator buttons (+, -, ×, ÷)
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (currentInput != "")
            {
                firstNumber = double.Parse(currentInput);
            }

            currentOperator = button.Text;
            isNewInput = true;
        }

        // Event handler for equals button
        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (currentInput != "" && currentOperator != "")
            {
                secondNumber = double.Parse(currentInput);
                double result = 0;

                try
                {
                    switch (currentOperator)
                    {
                        case "+":
                            result = firstNumber + secondNumber;
                            break;
                        case "-":
                            result = firstNumber - secondNumber;
                            break;
                        case "×":
                            result = firstNumber * secondNumber;
                            break;
                        case "÷":
                            if (secondNumber != 0)
                            {
                                result = firstNumber / secondNumber;
                            }
                            else
                            {
                                MessageBox.Show("Cannot divide by zero!", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ClearCalculator();
                                return;
                            }
                            break;
                    }

                    txtDisplay.Text = result.ToString();
                    currentInput = result.ToString();
                    currentOperator = "";
                    isNewInput = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Calculation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearCalculator();
                }
            }
        }

        // Event handler for clear button
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearCalculator();
        }

        // Event handler for backspace button
        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            // Only allow backspace when not starting new input
            if (!isNewInput && !string.IsNullOrEmpty(currentInput) && currentInput != "0")
            {
                // Delete the last character
                currentInput = currentInput.Substring(0, currentInput.Length - 1);

                // If input becomes empty, reset to "0"
                if (string.IsNullOrEmpty(currentInput))
                {
                    currentInput = "0";
                    txtDisplay.Text = "0";
                    isNewInput = true;
                }
                else
                {
                    txtDisplay.Text = currentInput;
                }
            }
        }

        // Helper method to reset calculator
        private void ClearCalculator()
        {
            txtDisplay.Text = "0";
            currentInput = "";
            firstNumber = 0;
            secondNumber = 0;
            currentOperator = "";
            isNewInput = true;
        }

        // Keyboard support
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Numbers 0-9
            if (char.IsDigit(e.KeyChar))
            {
                Button btn = null;
                switch (e.KeyChar)
                {
                    case '0': btn = btn0; break;
                    case '1': btn = btn1; break;
                    case '2': btn = btn2; break;
                    case '3': btn = btn3; break;
                    case '4': btn = btn4; break;
                    case '5': btn = btn5; break;
                    case '6': btn = btn6; break;
                    case '7': btn = btn7; break;
                    case '8': btn = btn8; break;
                    case '9': btn = btn9; break;
                }
                if (btn != null) NumberButton_Click(btn, EventArgs.Empty);
            }
            // Operators
            else if (e.KeyChar == '+')
            {
                OperatorButton_Click(btnPlus, EventArgs.Empty);
            }
            else if (e.KeyChar == '-')
            {
                OperatorButton_Click(btnMinus, EventArgs.Empty);
            }
            else if (e.KeyChar == '*')
            {
                OperatorButton_Click(btnMultiply, EventArgs.Empty);
            }
            else if (e.KeyChar == '/')
            {
                OperatorButton_Click(btnDivide, EventArgs.Empty);
            }
            // Decimal point
            else if (e.KeyChar == '.')
            {
                DecimalButton_Click(btnDecimal, EventArgs.Empty);
            }
            // Equals
            else if (e.KeyChar == '=' || e.KeyChar == '\r') // Enter key
            {
                EqualButton_Click(btnEqual, EventArgs.Empty);
            }
            // Clear
            else if (e.KeyChar == 'c' || e.KeyChar == 'C')
            {
                ClearButton_Click(btnClear, EventArgs.Empty);
            }
            // Backspace
            else if (e.KeyChar == '\b')
            {
                BackspaceButton_Click(btnBackspace, EventArgs.Empty);
            }
        }
    }
}