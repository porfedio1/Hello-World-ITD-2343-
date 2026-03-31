using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

/*
Rafael Gonzales
ITD 2343 – Obj-Orient Prg Using C#
Due: February 15, 2026
*/

namespace Module6MethodsProjectDL
{
    public partial class frmRealID : Form
    {
        // Operation constants
        private const byte ADD = 0;
        private const byte SUBTRACT = 1;
        private const byte MULTIPLY = 2;
        private const byte DIVIDE = 3;
        private const byte MODULUS = 4;

        // Extra credit: pick readable colors
        private readonly Color _errorColor = Color.Firebrick;
        private readonly Color _okColor = Color.Black;

        public frmRealID()
        {
            InitializeComponent();

            // MODULE 7 specs 
            this.Text = "Valid ID Required";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Escape key closes program
            this.CancelButton = btnExit;

        }

        // Method
        private decimal DoMath(decimal left, decimal right, byte operation)
        {
            decimal answer = 0m;

            if (operation == ADD)
                answer = left + right;
            else if (operation == SUBTRACT)
                answer = left - right;
            else if (operation == MULTIPLY)
                answer = left * right;
            else if (operation == DIVIDE)
                answer = left / right;
            else if (operation == MODULUS)
                answer = left % right;

            return answer;
        }

        // ====== Validation shows ALL errors  ======
        private bool TryGetOperands(out decimal left, out decimal right, out string errorMessage)
        {
            left = 0m;
            right = 0m;

            StringBuilder errors = new StringBuilder();

            string leftText = txtLeftOperand.Text.Trim();
            string rightText = txtRightOperand.Text.Trim();

            // Empty checks (shows both if both are left empty)
            if (leftText == "")
                errors.AppendLine("Left operand is required (cannot be empty).");

            if (rightText == "")
                errors.AppendLine("Right operand is required (cannot be empty).");

            // Only attempt parsing if they entered something
            if (leftText != "")
            {
                try
                {
                    if (!decimal.TryParse(leftText, out left))
                        errors.AppendLine("Left operand must be a valid decimal number.");
                }
                catch (Exception ex)
                {
                    errors.AppendLine("Left operand could not be converted: " + ex.Message);
                }
            }

            if (rightText != "")
            {
                try
                {
                    if (!decimal.TryParse(rightText, out right))
                        errors.AppendLine("Right operand must be a valid decimal number.");
                }
                catch (Exception ex)
                {
                    errors.AppendLine("Right operand could not be converted: " + ex.Message);
                }
            }

            errorMessage = errors.ToString().TrimEnd();
            return errorMessage == "";
        }

        // each button still triggers validation/handling
        private void ProcessOperation(byte operation)
        {
            try
            {
                lblDisplayAnswer.Text = "";

                if (!TryGetOperands(out decimal left, out decimal right, out string errors))
                {
                    ShowError(errors);
                    return;
                }

                // Operation-specific validation
                if (operation == DIVIDE && right == 0m)
                {
                    ShowError("Division cannot be performed because the right operand is 0 (divide by zero).");
                    return;
                }

                if (operation == MODULUS)
                {
                    if (left < 0m || right < 0m)
                    {
                        ShowError("Modulus cannot be performed with negative numbers. Please enter non-negative operands.");
                        return;
                    }

                    if (right == 0m)
                    {
                        ShowError("Modulus cannot be performed because the right operand is 0 (remainder by zero).");
                        return;
                    }
                }

                decimal answer = DoMath(left, right, operation);

                string symbol = "+";
                if (operation == SUBTRACT) symbol = "-";
                else if (operation == MULTIPLY) symbol = "*";
                else if (operation == DIVIDE) symbol = "/";
                else if (operation == MODULUS) symbol = "%";

                ShowOk($"{left} {symbol} {right} = {answer}");
            }
            catch (DivideByZeroException)
            {
                // Even though we validate
                ShowError("Division by zero is not allowed.");
            }
            catch (Exception ex)
            {
                // Unexpected exception for this operation
                ShowError("Unexpected error: " + ex.Message);
            }
        }

        private void ShowError(string message)
        {
            lblDisplayAnswer.ForeColor = _errorColor; // extra credit
            lblDisplayAnswer.Text = message;
        }

        private void ShowOk(string message)
        {
            lblDisplayAnswer.ForeColor = _okColor; // extra credit
            lblDisplayAnswer.Text = message;
        }

        // ===== Buttons =====
        private void btnAdd_Click(object sender, EventArgs e) => ProcessOperation(ADD);
        private void btnSubtract_Click(object sender, EventArgs e) => ProcessOperation(SUBTRACT);
        private void btnMultiply_Click(object sender, EventArgs e) => ProcessOperation(MULTIPLY);
        private void btnDivide_Click(object sender, EventArgs e) => ProcessOperation(DIVIDE);
        private void btnModulus_Click(object sender, EventArgs e) => ProcessOperation(MODULUS);

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLeftOperand.Text = "";
            txtRightOperand.Text = "";
            lblDisplayAnswer.Text = "";
            lblDisplayAnswer.ForeColor = _okColor;
            txtLeftOperand.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clears the message when the user edits inputs
        private void txtLeftOperand_TextChanged(object sender, EventArgs e)
        {
            lblDisplayAnswer.Text = "";
        }

        private void txtRightOperand_TextChanged(object sender, EventArgs e)
        {
            lblDisplayAnswer.Text = "";
        }
    }
}
