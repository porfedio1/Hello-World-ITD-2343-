using System;
using System.Text;
using System.Windows.Forms;

/*
Rafael Gonzales
ITD 2343 – Object Oriented Programming with C#
Sec3LabExam – Decoder Wheel
*/

namespace Sec3LabExam_Gonzales
{
    public partial class frmDecoderWheel : Form
    {
        // Tracks Plain to Cipher conversions
        private int plainToCipherCount = 0;

        // Tracks Cipher to Plain conversions
        private int cipherToPlainCount = 0;

        public frmDecoderWheel()
        {
            InitializeComponent();

            this.Text = "Decoder Wheel";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.AcceptButton = btnConvert; // Enter key
            this.CancelButton = btnExit;    // Escape key

            txtInput.Select();
        }

        // =========================
        // Convert Button
        // =========================
        private void btnConvert_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            string inputText = txtInput.Text.Trim();

            // Validation
            if (inputText == "")
                errorMessage += "Input text cannot be empty.\n";

            if (!rdoPlainToCipher.Checked && !rdoCipherToPlain.Checked)
                errorMessage += "Please select a conversion type.\n";

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result;

            if (rdoPlainToCipher.Checked)
            {
                result = ConvertMessage(inputText, true);
                plainToCipherCount++;
            }
            else
            {
                result = ConvertMessage(inputText, false);
                cipherToPlainCount++;
            }

            txtOutput.Text = result;
        }

        // =========================
        // Reset Button
        // =========================
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();

            rdoPlainToCipher.Checked = false;
            rdoCipherToPlain.Checked = false;

            txtInput.Focus();
        }

        // =========================
        // Exit Button
        // =========================
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Plain → Cipher: " + plainToCipherCount +
                "\nCipher → Plain: " + cipherToPlainCount,
                "Conversion Summary",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }

        // =========================
        // METHOD 
        // =========================
        private string ConvertMessage(string input, bool toCipher)
        {
            // The cipher 
            string plain = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string cipher = "SRENACHPTIMGLXWVFUJBKOZYDQ";

            StringBuilder result = new StringBuilder();

            input = input.ToUpper();

            foreach (char ch in input)
            {
                int index;

                if (toCipher)
                {
                    // Plain to Cipher
                    index = plain.IndexOf(ch);

                    if (index >= 0)
                        result.Append(cipher[index]);
                    else
                        result.Append(ch); // keeps spaces, punctuation, numbers
                }
                else
                {
                    // Cipher to Plain
                    index = cipher.IndexOf(ch);

                    if (index >= 0)
                        result.Append(plain[index]);
                    else
                        result.Append(ch);
                }
            }

            return result.ToString();
        }
    }
}