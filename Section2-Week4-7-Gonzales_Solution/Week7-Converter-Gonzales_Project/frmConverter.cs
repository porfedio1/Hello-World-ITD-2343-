using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

/*
Rafael Gonzales
ITD 2343 – Obj-Orient Prg Using C#
Due: February 22, 2026
*/

namespace Week7_Converter_Gonzales_Project
{
    public partial class frmConverter : Form
    {
        // Base constants 
        private const int BINARY = 2;
        private const int OCTAL = 8;
        private const int HEX = 16;
        private const int BASE6 = 6;
        private const int BASE9 = 9;

        // Message colors (extra credit)
        private readonly Color _errorColor = Color.Firebrick;
        private readonly Color _okColor = Color.Black;

        public frmConverter()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.CancelButton = btnExit; // Esc exits 

            lblMessage.Text = "";
            lblMessage.ForeColor = _okColor;

            UpdateButtonStates();
        }

        // ========= Button enabling rules =========
        private void UpdateButtonStates()
        {
            bool hasFrom = txtConvertFrom.Text.Trim() != "";
            bool hasBase = txtBase.Text.Trim() != "";

            // Preset buttons only need Convert From content
            btnBinary.Enabled = hasFrom;
            btnOctal.Enabled = hasFrom;
            btnHex.Enabled = hasFrom;
            btnBase6.Enabled = hasFrom;
            btnBase9.Enabled = hasFrom;

            // Process needs BOTH fields
            btnProcess.Enabled = hasFrom && hasBase;

            // Always enabled
            btnClear.Enabled = true;
            btnExit.Enabled = true;
        }

        private void txtConvertFrom_TextChanged(object sender, EventArgs e)
        {
            ClearMessage();
            UpdateButtonStates();
        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {
            ClearMessage();
            UpdateButtonStates();
        }

        // ========= Button clicks =========
        private void btnBinary_Click(object sender, EventArgs e) => ConvertPresetBase(BINARY);
        private void btnOctal_Click(object sender, EventArgs e) => ConvertPresetBase(OCTAL);
        private void btnHex_Click(object sender, EventArgs e) => ConvertPresetBase(HEX);
        private void btnBase6_Click(object sender, EventArgs e) => ConvertPresetBase(BASE6);
        private void btnBase9_Click(object sender, EventArgs e) => ConvertPresetBase(BASE9);

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate BOTH fields
                if (!TryGetPositiveWholeNumber(txtConvertFrom.Text, "Convert From", out long value, out string valueErr))
                {
                    ShowError(valueErr);
                    return;
                }

                if (!TryGetPositiveWholeNumber(txtBase.Text, "Base", out long baseLong, out string baseErr))
                {
                    ShowError(baseErr);
                    return;
                }

                // Base must be integer 2..16
                if (baseLong < 2 || baseLong > 16)
                {
                    ShowError("Base must be a whole number from 2 to 16.");
                    return;
                }

                int toBase = (int)baseLong;

                string result = ConvertDecimalToBase(value, toBase);
                ShowOk(result);
            }
            catch (Exception ex)
            {
                ShowError("Unexpected error: " + ex.Message);
            }
        }

        private void ConvertPresetBase(int toBase)
        {
            try
            {
                // Validate Convert From only
                if (!TryGetPositiveWholeNumber(txtConvertFrom.Text, "Convert From", out long value, out string err))
                {
                    ShowError(err);
                    return;
                }

                string result = ConvertDecimalToBase(value, toBase);
                ShowOk(result);
            }
            catch (Exception ex)
            {
                ShowError("Unexpected error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConvertFrom.Text = "";
            txtBase.Text = "";
            lblMessage.Text = "";
            lblMessage.ForeColor = _okColor;
            txtConvertFrom.Focus();
            UpdateButtonStates();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ========= Messaging =========
        private void ClearMessage()
        {
            lblMessage.Text = "";
            lblMessage.ForeColor = _okColor;
        }

        private void ShowError(string message)
        {
            lblMessage.ForeColor = _errorColor;
            lblMessage.Text = message;
        }

        private void ShowOk(string message)
        {
            lblMessage.ForeColor = _okColor;
            lblMessage.Text = message;
        }

        // ========= Validation Rules: =========
        // cannot be empty
        // must be digits only (no decimals, no negatives, no +, no spaces, no commas)
        // must be > 0 (positive)
        private bool TryGetPositiveWholeNumber(string text, string fieldName, out long value, out string errorMessage)
        {
            value = 0;
            errorMessage = "";

            string trimmed = text.Trim();

            if (trimmed == "")
            {
                errorMessage = fieldName + " field cannot be empty.";
                return false;
            }

            // Digits-only check prevents 12.4, -5, +7, 1,000, 2e3, etc.
            if (!IsAllDigits(trimmed))
            {
                errorMessage = fieldName + " must be a whole number using digits only (example: 48).";
                return false;
            }

            // Now you can parse
            if (!long.TryParse(trimmed, out value))
            {
                errorMessage = fieldName + " is too large. Please enter a smaller whole number.";
                return false;
            }

            // Positive (>0). Change to <0.
            if (value <= 0)
            {
                errorMessage = fieldName + " must be a positive whole number greater than 0.";
                return false;
            }

            return true;
        }

        private bool IsAllDigits(string s)
        {
            // returns true only if every char is 0-9
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < '0' || s[i] > '9')
                    return false;
            }
            return true;
        }

        // ========= ONE conversion method =========
        private string ConvertDecimalToBase(long number, int toBase)
        {
            // number is positive here due to validation

            StringBuilder digits = new StringBuilder();
            long working = number;

            while (working > 0)
            {
                int remainder = (int)(working % toBase);
                digits.Insert(0, RemainderToChar(remainder));
                working /= toBase;
            }

            return GetPrefix(toBase) + digits.ToString();
        }

        private string GetPrefix(int toBase)
        {
            if (toBase == 16)
                return "0x";

            return toBase.ToString() + "x";
        }

        private char RemainderToChar(int remainder)
        {
            if (remainder >= 0 && remainder <= 9)
                return (char)('0' + remainder);

            return (char)('A' + (remainder - 10)); // 10->A ... 15->F
        }
    }
}

