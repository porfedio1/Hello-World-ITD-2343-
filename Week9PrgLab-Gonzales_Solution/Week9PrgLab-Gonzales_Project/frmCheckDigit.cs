using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

/*
Rafael Gonzales
ITD 2343
Week 9 - Programming Lab
Due: 3/8/2026
*/

namespace Week9PrgLab_Gonzales_Project
{
    public partial class frmCheckDigit : Form
    {
        private const int MIN_ACCOUNT_LENGTH = 8;
        private const int MAX_ACCOUNT_LENGTH = 10;

        public frmCheckDigit()
        {
            InitializeComponent();

            // Start form in center of screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Enter key for Process button
            this.AcceptButton = btnProcess;

            // Escape key for Exit button
            this.CancelButton = btnExit;

            ResetForm();
        }

        // =====================================================
        // Exit Button or when the Escape key is pressed
        // =====================================================
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =====================================================
        // Reset Button Clears all textboxes and message area
        // =====================================================
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // =====================================================
        // Process Button validates the input values and processes the payment
        // If everything is valid, it displays a success message
        // in the message area
        // =====================================================
        private void btnProcess_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            if (!TryValidateInputs(out string accountNumber, out decimal paymentAmount))
                return;

            string dateText = DateTime.Now.ToString("MMMM d, yyyy");

            lblMessage.Text =
                $"A payment of {paymentAmount:C} was applied to account {accountNumber} on {dateText}.";
        }

        // =====================================================
        // Validate Inputs: checks for empty textboxes, numeric values,
        // matching account numbers, and valid payment values
        // =====================================================
        private bool TryValidateInputs(out string accountNumber, out decimal paymentAmount)
        {
            accountNumber = "";
            paymentAmount = 0m;

            StringBuilder errors = new StringBuilder();

            string accountText = txtAccount.Text.Trim();
            string confirmText = txtConfirm.Text.Trim();
            string paymentText = txtPayment.Text.Trim();

            if (accountText == "")
                errors.AppendLine("Account number is required.");

            if (confirmText == "")
                errors.AppendLine("Confirmation account number is required.");

            if (paymentText == "")
                errors.AppendLine("Payment amount is required.");

            if (errors.Length > 0)
            {
                lblMessage.Text = errors.ToString();
                return false;
            }

            if (!IsDigitsOnly(accountText))
                errors.AppendLine("Account number must contain digits only.");

            if (!IsDigitsOnly(confirmText))
                errors.AppendLine("Confirmation account number must contain digits only.");

            if (accountText != confirmText)
                errors.AppendLine("Account numbers must match.");

            if (!decimal.TryParse(paymentText,
                NumberStyles.Currency,
                CultureInfo.CurrentCulture,
                out paymentAmount))
            {
                errors.AppendLine("Payment amount must be a valid currency value.");
            }

            if (errors.Length > 0)
            {
                lblMessage.Text = errors.ToString();
                return false;
            }

            if (!IsValidCheckDigit(accountText))
            {
                lblMessage.Text = "Account number failed check digit verification.";
                return false;
            }

            accountNumber = accountText;
            return true;
        }

        // =====================================================
        // Checks if a string contains digits only
        // =====================================================
        private bool IsDigitsOnly(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }

        // =====================================================
        // Check Digit Algorithm
        // Adds all digits except the last
        // Then compares the modulus result with the last digit
        // =====================================================
        private bool IsValidCheckDigit(string accountNumber)
        {
            int total = 0;

            for (int i = 0; i < accountNumber.Length - 1; i++)
            {
                total += accountNumber[i] - '0';
            }

            int checkDigit = total % 10;
            int lastDigit = accountNumber[accountNumber.Length - 1] - '0';

            return checkDigit == lastDigit;
        }

        // =====================================================
        // Reset Form Method
        // Clears all inputs and the message area
        // =====================================================
        private void ResetForm()
        {
            txtAccount.Text = "";
            txtConfirm.Text = "";
            txtPayment.Text = "";
            lblMessage.Text = "";

            txtAccount.Focus();
        }
    }
}