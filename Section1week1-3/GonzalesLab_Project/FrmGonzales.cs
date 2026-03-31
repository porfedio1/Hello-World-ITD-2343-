/*
 Rafael Gonzales
ITD-2343 Obj-Orient
Due:1/20/2026
 */
namespace GonzalesLab_Project
{
    public partial class FrmGonzales : Form
    {
        public FrmGonzales()
        {
            InitializeComponent();
        }

        private void lblTheDominator_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btn6.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btn8.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes and exits the program
            Close();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            //This clears the screen of number and turns screen back to white.
            lblTheDominator.Text = "";
            lblTheDominator.BackColor = Color.White;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = Color.Red;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = Color.Orange;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = Color.Green;
        }

        private void btnPink_Click_1(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = Color.Pink;
        }

        private void btnCyan_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = Color.Cyan;
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = Color.Purple;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = Color.Yellow;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = Color.Blue;
        }

        private void btnSilver_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = Color.Silver;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btn1.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btn4.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btn7.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btn2.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btn5.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btn3.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btn9.Text;
        }
    }
}
