using System;
using System.Windows.Forms;

/*
Rafael Gonzales
ITD 2343 – Obj-Orient Prg Using C# 
Due: February 15, 2026
*/

namespace Module6MethodsProjectDL
{
    public partial class frmMethodActing : Form
    {
        // Operation constants
        const byte ADD = 0;
        const byte SUBTRACT = 1;
        const byte MULTIPLY = 2;
        const byte DIVIDE = 3;
        const byte MODULUS = 4;

        public frmMethodActing()
        {
            InitializeComponent();

            // Form settings
            this.Text = "Gonzales Methods";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Escape key closes program
            this.CancelButton = btnExit;
        }

        // SINGLE method (Chapter 6 requirement)
        // 3 parameters, one return at the end
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal left, right;

            if (!decimal.TryParse(txtLeftOperand.Text, out left) ||
                !decimal.TryParse(txtRightOperand.Text, out right))
            {
                MessageBox.Show("Enter valid numbers for both operands.");
                return;
            }


            decimal answer = DoMath(left, right, ADD);

            lblDisplayAnswer.Text = txtLeftOperand.Text + " + " + txtRightOperand.Text + " = " + answer;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            decimal left, right;

            if (!decimal.TryParse(txtLeftOperand.Text, out left) ||
                !decimal.TryParse(txtRightOperand.Text, out right))
            {
                MessageBox.Show("Enter valid numbers for both operands.");
                return;
            }


            decimal answer = DoMath(left, right, SUBTRACT);

            lblDisplayAnswer.Text = txtLeftOperand.Text + " - " + txtRightOperand.Text + " = " + answer;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            decimal left, right;

            if (!decimal.TryParse(txtLeftOperand.Text, out left) ||
                !decimal.TryParse(txtRightOperand.Text, out right))
            {
                MessageBox.Show("Enter valid numbers for both operands.");
                return;
            }


            decimal answer = DoMath(left, right, MULTIPLY);

            lblDisplayAnswer.Text = txtLeftOperand.Text + " * " + txtRightOperand.Text + " = " + answer;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            decimal left, right;

            if (!decimal.TryParse(txtLeftOperand.Text, out left) ||
                !decimal.TryParse(txtRightOperand.Text, out right))
            {
                MessageBox.Show("Enter valid numbers for both operands.");
                return;
            }


            decimal answer = DoMath(left, right, DIVIDE);

            lblDisplayAnswer.Text = txtLeftOperand.Text + " / " + txtRightOperand.Text + " = " + answer;

        }
                
        private void btnModulus_Click(object sender, EventArgs e)
        {
            decimal left, right;

            if (!decimal.TryParse(txtLeftOperand.Text, out left) ||
                !decimal.TryParse(txtRightOperand.Text, out right))
            {
                MessageBox.Show("Enter valid numbers for both operands.");
                return;
            }


            decimal answer = DoMath(left, right, MODULUS);

            lblDisplayAnswer.Text = txtLeftOperand.Text + " % " + txtRightOperand.Text + " = " + answer;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLeftOperand.Text = "";
            txtRightOperand.Text = "";
            lblDisplayAnswer.Text = "";
            txtLeftOperand.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

