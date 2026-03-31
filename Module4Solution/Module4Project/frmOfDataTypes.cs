/*
Rafael Gonzales
ITD 2343 – Object Oriented Programming with C#
2/4/2026

Program Description:
This Windows Forms application demonstrates integer and decimal
data types, arithmetic operations, numeric precision, and Math
class methods.
*/

namespace Module4Project
{
    public partial class frmOfDataTypes : Form
    {
        public frmOfDataTypes()
        {
            InitializeComponent();
        }
        // Byte button shows an addition (+) problem.
        private void btnByte_Click(object sender, EventArgs e)
        {
            byte leftOperand = 200;
            byte rightOperand = 25;

            byte result = (byte)(leftOperand + rightOperand);

            lblDisplay.Text = String.Format("{0} + {1} = {2}", leftOperand, rightOperand, result);
        }
        // Short button shows a subtraction (-) problem.
        private void btnShort_Click(object sender, EventArgs e)
        {
            short leftOperand = 1200;
            short rightOperand = 345;

            short result = (short)(leftOperand - rightOperand);

            lblDisplay.Text = String.Format("{0} - {1} = {2}", leftOperand, rightOperand, result);
        }
        // Integer button shows a division (/) problem.
        private void btnInteger_Click(object sender, EventArgs e)
        {
            int leftOperand = 25;
            int rightOperand = 4;

            int result = leftOperand / rightOperand;

            lblDisplay.Text = String.Format("{0} / {1} = {2}", leftOperand, rightOperand, result);
        }
        // Long button shows a Modulus (%) problem.
        private void btnLong_Click(object sender, EventArgs e)
        {
            long leftOperand = 125;
            long rightOperand = 7;

            long result = leftOperand % rightOperand;

            lblDisplay.Text = String.Format("{0} % {1} = {2}", leftOperand, rightOperand, result);
        }
        // Float button shows a Modulus (%) problem with 7-digit precision.
        private void btnFloat_Click(object sender, EventArgs e)
        {
            float leftOperand = 17.1234567f;
            float rightOperand = 3.0f;

            float result = leftOperand % rightOperand;

            lblDisplay.Text = String.Format("{0:G7} % {1:G7} = {2:G7}", leftOperand, rightOperand, result);
        }
        // Double Decimal buttons shows a division (/) problem with 16-digit of precision.
        private void btnDouble_Click(object sender, EventArgs e)
        {
            double leftOperand = 7.6825;
            double rightOperand = 2.178;
            double result = leftOperand / rightOperand;
            lblDisplay.Text = String.Format("{0:G16} / {1:G16} = {2:G16}", leftOperand, rightOperand, result);
        }
        // Decimal button shows a Multiplication (*) problem with 29-digit of precision.
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            decimal leftOperand = 1.234567890123456789012345678m;
            decimal rightOperand = 3.0m;
            decimal result = leftOperand * rightOperand;
            lblDisplay.Text = String.Format("{0:G29} * {1:G29} = {2:G29}", leftOperand, rightOperand, result);
        }
        // Pow button uses Math.Pow with two values
        private void btnPow_Click(object sender, EventArgs e)
        {
            double baseValue = 2.0;
            double exponent = 8.0;

            double result = Math.Pow(baseValue, exponent);

            lblDisplay.Text = baseValue + " to the power of " + exponent + " is " + result;
        }
        // Round — uses Math.Round (second parameter must be int)
        private void btnRound_Click(object sender, EventArgs e)
        {
            
            double value = 3.141592653589793;
            int digits = 3;

            double result = Math.Round(value, digits);

            lblDisplay.Text = String.Format("Rounding {0:G16} to {1} digits gives {2}", value, digits, result);
        }
        // Sqrt button uses Math.Sqrt.
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double value = 49.0;

            double result = Math.Sqrt(value);

            lblDisplay.Text = "The square root of " + value + " is " + result;
        }
        // Clear only the large label text
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
        }
        // Close the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Displays the corresponding button picked each showing different math problems.
        private void lblDisplay_Click(object sender, EventArgs e)
        {
             
        }
    }
}
