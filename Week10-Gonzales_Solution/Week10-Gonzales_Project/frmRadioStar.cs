using System;
using System.Text;
using System.Windows.Forms;

/*
Rafael Gonzales
ITD 2343 – Object Oriented Programming with C#
Due: 3/22/2026
*/

namespace Radio_GonzalesProject
{
    public partial class frmRadioStar : Form
    {
        // Starts the form
        public frmRadioStar()
        {
            InitializeComponent(); // Builds the form

            this.Text = "Radio Buttons in Action";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btnCalculate; // Enter key
            this.CancelButton = btnExit;      // Escape key

            ResetForm(); // Set startup defaults
        }

        // Calculate button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblOutputMessage.Text = ""; // Clear old message

            int leftOperand;
            int rightOperand;

            // Checks the input
            string errorMessage = ValidateInput(out leftOperand, out rightOperand);

            // Shows errors if any
            if (errorMessage != "")
            {
                lblOutputMessage.Text = errorMessage;
                return;
            }

            // Shows the answer
            lblOutputMessage.Text = CalculateAndFormatResult(leftOperand, rightOperand);
        }

        // Reset button
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Reset the form
        private void ResetForm()
        {
            txtLeftOperand.Text = "";
            txtRightOperand.Text = "";
            lblOutputMessage.Text = "";

            radAddition.Checked = true; // Default operation
            chkVerbose.Checked = true;  // Verbose ON

            txtLeftOperand.Focus();
        }

        // Checks the input
        private string ValidateInput(out int leftOperand, out int rightOperand)
        {
            StringBuilder errors = new StringBuilder();

            leftOperand = 0;
            rightOperand = 0;

            string leftText = txtLeftOperand.Text.Trim();
            string rightText = txtRightOperand.Text.Trim();

            bool leftValid = false;
            bool rightValid = false;

            // Checks for empty boxes
            if (leftText == "")
            {
                errors.AppendLine("Please enter a value for the left operand.");
            }

            if (rightText == "")
            {
                errors.AppendLine("Please enter a value for the right operand.");
            }

            // Checks the left number
            if (leftText != "")
            {
                if (int.TryParse(leftText, out leftOperand))
                {
                    leftValid = true;
                }
                else
                {
                    errors.AppendLine("The left operand must be a whole number integer.");
                }
            }

            // Checks the right number
            if (rightText != "")
            {
                if (int.TryParse(rightText, out rightOperand))
                {
                    rightValid = true;
                }
                else
                {
                    errors.AppendLine("The right operand must be a whole number integer.");
                }
            }

            // Checks for math errors
            if (leftValid && rightValid)
            {
                if (radDivision.Checked && rightOperand == 0)
                {
                    errors.AppendLine("Division by zero is not allowed.");
                }

                if (radModulus.Checked)
                {
                    if (rightOperand == 0)
                    {
                        errors.AppendLine("Modulus by zero is not allowed.");
                    }

                    if (leftOperand < 0 || rightOperand < 0)
                    {
                        errors.AppendLine("Modulus operations are not allowed with negative numbers.");
                    }
                }
            }

            return errors.ToString().TrimEnd();
        }

        // Does the math and formats the message.
        private string CalculateAndFormatResult(int leftOperand, int rightOperand)
        {
            int answer = 0;
            string symbol = "";

            if (radAddition.Checked)
            {
                answer = Add(leftOperand, rightOperand);
                symbol = "+";
            }
            else if (radSubtraction.Checked)
            {
                answer = Subtract(leftOperand, rightOperand);
                symbol = "-";
            }
            else if (radMultiplication.Checked)
            {
                answer = Multiply(leftOperand, rightOperand);
                symbol = "*";
            }
            else if (radDivision.Checked)
            {
                answer = Divide(leftOperand, rightOperand);
                symbol = "/";
            }
            else if (radModulus.Checked)
            {
                answer = Modulus(leftOperand, rightOperand);
                symbol = "%";
            }

            if (chkVerbose.Checked)
            {
                return leftOperand + " " + symbol + " " + rightOperand + " = " + answer;
            }
            else
            {
                return "The Answer is: " + answer;
            }
        }

        // Add
        private int Add(int x, int y)
        {
            return x + y;
        }

        // Subtract
        private int Subtract(int x, int y)
        {
            return x - y;
        }

        // Multiply
        private int Multiply(int x, int y)
        {
            return x * y;
        }

        // Divide
        private int Divide(int x, int y)
        {
            return x / y;
        }

        // Modulus
        private int Modulus(int x, int y)
        {
            return x % y;
        }
    }
}