/*
 Name: Rafael Gonzales
 Class: Obj-Orient Prg Using C#
 Due Date: 2/8/2026
*/
namespace Project5Gonzales
{
    public partial class frmChoices : Form
    {
        public frmChoices()
        {
            InitializeComponent();
            // Enter runs Check, Esc runs Exit
            this.AcceptButton = btnCheck;
            this.CancelButton = btnExit;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all input boxes and the message label
            txtLowerNumber.Text = "";
            txtMaxNumber.Text = "";
            txtEnterNumber.Text = "";
            lblResult.Text = "";

            // Put focus back to the first range box
            txtLowerNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit closes the form (Escape key also triggers this)
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int low, high, number;

            // Try to convert all three values
            if (!int.TryParse(txtLowerNumber.Text, out low) ||
                !int.TryParse(txtMaxNumber.Text, out high) ||
                !int.TryParse(txtEnterNumber.Text, out number))
            {
                lblResult.Text = "Please enter valid numbers.";
                txtEnterNumber.Focus();
                return;
            }

            // Left textbox = LOW end range, Right textbox = UPPER end range

            if (number == low)
                lblResult.Text = "Equal to LOWER end range.";
            else if (number == high)
                lblResult.Text = "Equal to UPPER end range.";
            else if (number < low)
                lblResult.Text = "Below the LOWER end range.";
            else if (number > high)
                lblResult.Text = "Above the UPPER end range.";
            else
                lblResult.Text = string.Format(
                    "The number is in the range of {0} and {1}.", low, high);

            // Clear only the checked value
            txtEnterNumber.Text = "";

            // Return focus for quick entry
            txtEnterNumber.Focus();
        }
    }
}