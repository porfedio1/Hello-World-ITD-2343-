using System;
using System.Text;
using System.Windows.Forms;

/*
Rafael Gonzales
ITD 2343 – Object Oriented Programming with C#
Due: March 4, 2026
*/

namespace CollectionLab
{
    public partial class frmCollections : Form
    {
        // ============================
        // Class-level constants
        // ============================
        private const int MAX_ITEMS = 17;
        private const int MIN_VALUE = -1217;
        private const int MAX_VALUE = 1217;

        // ============================
        // Class-level collection state
        // ============================
        private readonly int[] numbers = new int[MAX_ITEMS];
        private int count = 0;

        public frmCollections()
        {
            InitializeComponent();

            this.Text = "Collection Lab";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Enter key triggers Add
            this.AcceptButton = btnAddNumber;

            // Escape key triggers Exit
            this.CancelButton = btnExit;

            rtbCollectionDisplay.ReadOnly = true;
            rtbStats.ReadOnly = true;

            rtbCollectionDisplay.TabStop = false;
            rtbStats.TabStop = false;

            ShowStatsMessage("Enter an integer and click Add Number (or press Enter).");
        }

        // ==================================================
        // BUTTON EVENTS
        // ==================================================

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearCollection();
            ClearDisplays();

            txtNumber.Text = "";
            txtNumber.Focus();

            ShowStatsMessage("Collection has been cleared. Enter a new number to begin.");
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            // Clear display areas when new number is added
            ClearDisplays();

            if (!TryGetValidInput(out int value))
                return;

            if (count >= MAX_ITEMS)
            {
                txtNumber.Text = "";
                ShowStatsMessage("Collection Full Error: Maximum of 17 numbers has already been entered.");
                return;
            }

            numbers[count] = value;
            count++;

            txtNumber.Text = "";
            txtNumber.Focus();

            ShowStatsMessage($"Added {value}. Items in collection: {count} of {MAX_ITEMS}.");
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            ClearDisplays();

            if (count == 0)
            {
                ShowStatsMessage("No numbers in the collection. Add at least one number before showing statistics.");
                return;
            }

            // Display collection
            for (int i = 0; i < count; i++)
            {
                rtbCollectionDisplay.AppendText(numbers[i] + Environment.NewLine);
            }

            // Walk array 
            long sum = 0;
            int low = numbers[0];
            int high = numbers[0];

            for (int i = 0; i < count; i++)
            {
                int current = numbers[i];

                sum += current;

                if (current < low)
                    low = current;

                if (current > high)
                    high = current;
            }

            double average = (double)sum / count;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Count: {count}");
            sb.AppendLine($"High Number: {high}");
            sb.AppendLine($"Low Number: {low}");
            sb.AppendLine($"Average: {average:0.0000}");

            rtbStats.Text = sb.ToString().TrimEnd();

            // Clear collection after statistics 
            ClearCollection();
            txtNumber.Text = "";
            txtNumber.Focus();
        }

        // ==================================================
        // VALIDATION METHOD
        // ==================================================

        private bool TryGetValidInput(out int value)
        {
            value = 0;

            string text = txtNumber.Text.Trim();

            if (text == "")
            {
                txtNumber.Text = "";
                ShowStatsMessage("Input Error: Please enter an integer value.");
                return false;
            }

            // Error for decimal numbers 
            if (decimal.TryParse(text, out decimal decValue) &&
                !int.TryParse(text, out value))
            {
                txtNumber.Text = "";
                ShowStatsMessage("Input Error: Decimals are not allowed. Enter a whole number (integer) only.");
                return false;
            }

            // Error for letters or symbols
            if (!int.TryParse(text, out value))
            {
                txtNumber.Text = "";
                ShowStatsMessage("Input Error: Letters or symbols are not allowed. Enter a whole number (integer) only.");
                return false;
            }

            // Too small
            if (value < MIN_VALUE)
            {
                txtNumber.Text = "";
                ShowStatsMessage($"Value Out Of Range Error: Entries less than the minimum value of {MIN_VALUE:N0} are not allowed.");
                return false;
            }

            // Too large
            if (value > MAX_VALUE)
            {
                txtNumber.Text = "";
                ShowStatsMessage($"Value Out Of Range Error: Entries greater than the maximum value of {MAX_VALUE:N0} are not allowed.");
                return false;
            }

            return true;
        }

        // ==================================================
        // HELPER METHODS
        // ==================================================

        private void ClearCollection()
        {
            count = 0;
        }

        private void ClearDisplays()
        {
            rtbCollectionDisplay.Text = "";
            rtbStats.Text = "";
        }

        private void ShowStatsMessage(string message)
        {
            rtbStats.Text = message;
        }
    }
}