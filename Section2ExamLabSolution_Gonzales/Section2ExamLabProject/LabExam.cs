using System;
using System.Text;
using System.Windows.Forms;

/*
Rafael Gonzales
Exam Section 2 Lab Portion
ITD 2343 – Object Oriented Programming with C#
*/

namespace LabExam
{
    public partial class LabExam : Form
    {
        private enum OperationMode
        {
            None,
            Modulus,
            Factorial,
            Fibonacci
        }

        private OperationMode currentMode = OperationMode.None;

        public LabExam()
        {
            InitializeComponent();

            // Form settings
            this.FormClosing += LabExam_FormClosing;

            // Title bar
            this.Text = "Operations Rafael Gonzales";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Escape key exits and makes FormClosing message box
            this.CancelButton = btnExit;

            // Message setup
            lblMessage.AutoSize = false;
            lblMessage.TabStop = false;

            // Operand textboxes 
            txtOperand1.TabStop = false;
            txtOperand2.TabStop = false;

            // Startup
            DisableAllDoButtons();
            ShowOperands(0);

            AppendMessage("Click a SHOW button to begin.");
        }

        // ==================================================
        // Show Buttons
        // ==================================================

        private void btnShowModulus_Click(object sender, EventArgs e)
        {
            currentMode = OperationMode.Modulus;

            DisableAllDoButtons();
            btnDoModulus.Enabled = true;

            ShowOperands(2);
            lblOperand1.Text = "Dividend:";
            lblOperand2.Text = "Divisor:";

            AppendMessage("Enter two non-negative integers, then click Do Modulus.");
        }

        private void btnShowFactorial_Click(object sender, EventArgs e)
        {
            currentMode = OperationMode.Factorial;

            DisableAllDoButtons();
            btnDoFactorial.Enabled = true;

            ShowOperands(1);
            lblOperand1.Text = "Value (0–15):";

            AppendMessage("Enter an integer from 0 to 15, then click Do Factorial.");
        }

        private void btnShowFibonacci_Click(object sender, EventArgs e)
        {
            currentMode = OperationMode.Fibonacci;

            DisableAllDoButtons();
            btnDoFibonacci.Enabled = true;

            ShowOperands(1);
            lblOperand1.Text = "Term (0–45):";

            AppendMessage("Enter an integer from 0 to 45, then click Do Fibonacci.");
        }

        // =============================================
        // Do Buttons
        // =============================================

        private void btnDoModulus_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentMode != OperationMode.Modulus)
                {
                    AppendMessage("Click Show Modulus first.");
                    return;
                }

                StringBuilder msg = new StringBuilder();
                int dividend, divisor;

                bool ok1 = TryGetInteger(txtOperand1, "Dividend", msg, out dividend);
                bool ok2 = TryGetInteger(txtOperand2, "Divisor", msg, out divisor);

                if (!ok1 || !ok2)
                {
                    AppendMessage(msg.ToString().TrimEnd());
                    return;
                }

                // Validation
                if (dividend < 0)
                    msg.AppendLine("Dividend must be 0 or greater.");

                if (divisor <= 0)
                    msg.AppendLine("Divisor must be greater than 0.");

                if (msg.Length > 0)
                {
                    AppendMessage(msg.ToString().TrimEnd());
                    return;
                }

                int quotient, remainder;
                LongDivision(dividend, divisor, out quotient, out remainder);

                AppendMessage(dividend + " divided by " + divisor +
                              " is " + quotient +
                              " with a remainder of " + remainder + ".");
            }
            catch (FormatException)
            {
                AppendMessage("Numbers must be whole integers only (no decimals).");
            }
            catch (Exception)
            {
                AppendMessage("An unexpected error occurred.");
            }
        }

        private void btnDoFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentMode != OperationMode.Factorial)
                {
                    AppendMessage("Click Show Factorial first.");
                    return;
                }

                StringBuilder msg = new StringBuilder();
                int n;

                if (!TryGetInteger(txtOperand1, "Value", msg, out n))
                {
                    AppendMessage(msg.ToString().TrimEnd());
                    return;
                }

                if (n < 0)
                {
                    AppendMessage("Factorial cannot be calculated on negative numbers.");
                    return;
                }

                if (!ValidateRange(n, 0, 15, "Factorial", msg))
                {
                    AppendMessage(msg.ToString().TrimEnd());
                    return;
                }

                long result = CalculateFactorial(n);
                AppendMessage("The answer to " + n + "! is " + result + ".");
            }
            catch (FormatException)
            {
                AppendMessage("Value must be a whole integer only (no decimals).");
            }
            catch (Exception)
            {
                AppendMessage("An unexpected error occurred.");
            }
        }

        private void btnDoFibonacci_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentMode != OperationMode.Fibonacci)
                {
                    AppendMessage("Click Show Fibonacci first.");
                    return;
                }

                StringBuilder msg = new StringBuilder();
                int n;

                if (!TryGetInteger(txtOperand1, "Term", msg, out n))
                {
                    AppendMessage(msg.ToString().TrimEnd());
                    return;
                }

                if (n < 0)
                {
                    AppendMessage("Fibonacci cannot be calculated on negative numbers.");
                    return;
                }

                if (!ValidateRange(n, 0, 45, "Fibonacci", msg))
                {
                    AppendMessage(msg.ToString().TrimEnd());
                    return;
                }

                if (n == 0)
                {
                    AppendMessage("Fibonacci(0) = 0");
                    return;
                }

                if (n == 1)
                {
                    AppendMessage("Fibonacci(1) = 1");
                    return;
                }

                long fn, f1, f2;
                Fibonacci(n, out fn, out f1, out f2);

                AppendMessage("Fibonacci(" + n + ") = Fibonacci(" + (n - 1) +
                              ") + Fibonacci(" + (n - 2) + ") = " +
                              f1 + " + " + f2 + " = " + fn);
            }
            catch (FormatException)
            {
                AppendMessage("Term must be a whole integer only (no decimals).");
            }
            catch (Exception)
            {
                AppendMessage("An unexpected error occurred.");
            }
        }

        //====================================================
        // Clear/Exit
        //====================================================

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            AppendMessage("Message cleared (operands unchanged).");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabExam_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(
                "Thank you for using the Operations program!",
                "Goodbye",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =====================================================
        // Validation
        // =====================================================

        private bool TryGetInteger(TextBox tb, string field, StringBuilder msg, out int value)
        {
            value = 0;
            string text = tb.Text.Trim();

            if (text == "")
            {
                msg.AppendLine(field + " cannot be empty.");
                return false;
            }

            // Decimal check 
            if (text.Contains(".") || text.Contains(","))
            {
                msg.AppendLine(field + " cannot be decimal. Whole numbers only.");
                return false;
            }

            // Letters/invalid format
            if (!int.TryParse(text, out value))
            {
                msg.AppendLine(field + " must be a valid integer.");
                return false;
            }

            return true;
        }

        //========================================================
        // Single range validator for Factorial and Fibonacci
        //========================================================
        private bool ValidateRange(int value, int min, int max, string name, StringBuilder msg)
        {
            if (value < min || value > max)
            {
                msg.AppendLine(name + " must be between " + min + " and " + max + ".");
                return false;
            }
            return true;
        }

        // ================================================
        // Algorithms
        // ================================================

        // Long division using subtraction only
        private void LongDivision(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient = 0;
            remainder = dividend;

            while (remainder >= divisor)
            {
                remainder = remainder - divisor;   // explicit -
                quotient = quotient + 1;          // explicit +
            }
        }

        private long CalculateFactorial(int n)
        {
            long f = 1;
            int i = 1;

            while (i <= n)
            {
                f *= i;
                i++;
            }

            return f;
        }

        private void Fibonacci(int n, out long fn, out long prev1, out long prev2)
        {
            if (n == 0)
            {
                fn = 0; prev1 = 0; prev2 = 0;
                return;
            }

            if (n == 1)
            {
                fn = 1; prev1 = 1; prev2 = 0;
                return;
            }

            long a = 0;
            long b = 1;
            long c = 0;

            int i = 2;
            while (i <= n)
            {
                c = a + b;
                a = b;
                b = c;
                i++;
            }

            fn = b;
            prev1 = a;       // F(n-1)
            prev2 = b - a;   // F(n-2)
        }

        // =====================================================
        // User Interface
        // =====================================================

        private void DisableAllDoButtons()
        {
            btnDoModulus.Enabled = false;
            btnDoFactorial.Enabled = false;
            btnDoFibonacci.Enabled = false;
        }

        // count: 0 = none, 1 = operand1 only, 2 = both operands
        private void ShowOperands(int count)
        {
            lblOperand1.Visible = count >= 1;
            txtOperand1.Visible = count >= 1;

            lblOperand2.Visible = count >= 2;
            txtOperand2.Visible = count >= 2;

            lblMessage.Visible = true;
        }

        private void AppendMessage(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return;

            if (lblMessage.Text.Length > 0)
                lblMessage.Text += Environment.NewLine;

            lblMessage.Text += text;
        }
    }
}