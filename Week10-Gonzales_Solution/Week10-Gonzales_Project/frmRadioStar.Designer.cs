using System.Drawing;
using System.Windows.Forms;

namespace Radio_GonzalesProject
{
    partial class frmRadioStar
    {
        ///
        ///  Designer variable.
        ///
        private System.ComponentModel.IContainer components = null;

        /// 
        ///  Cleans up any resources being used.
        /// 
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblLeftOperand = new Label();
            txtLeftOperand = new TextBox();
            lblRightOperand = new Label();
            txtRightOperand = new TextBox();
            radAddition = new RadioButton();
            radSubtraction = new RadioButton();
            radMultiplication = new RadioButton();
            radDivision = new RadioButton();
            radModulus = new RadioButton();
            grpMathOperations = new GroupBox();
            chkVerbose = new CheckBox();
            btnCalculate = new Button();
            btnReset = new Button();
            btnExit = new Button();
            lblOutputMessage = new Label();
            grpMathOperations.SuspendLayout();
            SuspendLayout();
            // 
            // lblLeftOperand
            // 
            lblLeftOperand.AutoSize = true;
            lblLeftOperand.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLeftOperand.Location = new Point(36, 42);
            lblLeftOperand.Margin = new Padding(4, 0, 4, 0);
            lblLeftOperand.Name = "lblLeftOperand";
            lblLeftOperand.Size = new Size(141, 28);
            lblLeftOperand.TabIndex = 0;
            lblLeftOperand.Text = "&Left Operand:";
            // 
            // txtLeftOperand
            // 
            txtLeftOperand.BackColor = Color.LightYellow;
            txtLeftOperand.Location = new Point(214, 42);
            txtLeftOperand.Margin = new Padding(4, 5, 4, 5);
            txtLeftOperand.Name = "txtLeftOperand";
            txtLeftOperand.Size = new Size(198, 31);
            txtLeftOperand.TabIndex = 1;
            // 
            // lblRightOperand
            // 
            lblRightOperand.AutoSize = true;
            lblRightOperand.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRightOperand.Location = new Point(36, 108);
            lblRightOperand.Margin = new Padding(4, 0, 4, 0);
            lblRightOperand.Name = "lblRightOperand";
            lblRightOperand.Size = new Size(155, 28);
            lblRightOperand.TabIndex = 2;
            lblRightOperand.Text = "&Right Operand:";
            // 
            // txtRightOperand
            // 
            txtRightOperand.BackColor = Color.LightYellow;
            txtRightOperand.Location = new Point(214, 108);
            txtRightOperand.Margin = new Padding(4, 5, 4, 5);
            txtRightOperand.Name = "txtRightOperand";
            txtRightOperand.Size = new Size(198, 31);
            txtRightOperand.TabIndex = 3;
            // 
            // radAddition
            // 
            radAddition.AutoSize = true;
            radAddition.Checked = true;
            radAddition.Location = new Point(26, 47);
            radAddition.Margin = new Padding(4, 5, 4, 5);
            radAddition.Name = "radAddition";
            radAddition.Size = new Size(109, 32);
            radAddition.TabIndex = 0;
            radAddition.TabStop = true;
            radAddition.Text = "Add (+)";
            radAddition.UseVisualStyleBackColor = true;
            // 
            // radSubtraction
            // 
            radSubtraction.AutoSize = true;
            radSubtraction.Location = new Point(26, 97);
            radSubtraction.Margin = new Padding(4, 5, 4, 5);
            radSubtraction.Name = "radSubtraction";
            radSubtraction.Size = new Size(145, 32);
            radSubtraction.TabIndex = 1;
            radSubtraction.TabStop = true;
            radSubtraction.Text = "Subtract (-)";
            radSubtraction.UseVisualStyleBackColor = true;
            // 
            // radMultiplication
            // 
            radMultiplication.AutoSize = true;
            radMultiplication.Location = new Point(26, 147);
            radMultiplication.Margin = new Padding(4, 5, 4, 5);
            radMultiplication.Name = "radMultiplication";
            radMultiplication.Size = new Size(146, 32);
            radMultiplication.TabIndex = 2;
            radMultiplication.TabStop = true;
            radMultiplication.Text = "Multiply (*)";
            radMultiplication.UseVisualStyleBackColor = true;
            // 
            // radDivision
            // 
            radDivision.AutoSize = true;
            radDivision.Location = new Point(26, 197);
            radDivision.Margin = new Padding(4, 5, 4, 5);
            radDivision.Name = "radDivision";
            radDivision.Size = new Size(127, 32);
            radDivision.TabIndex = 3;
            radDivision.TabStop = true;
            radDivision.Text = "Divide (/)";
            radDivision.UseVisualStyleBackColor = true;
            // 
            // radModulus
            // 
            radModulus.AutoSize = true;
            radModulus.Location = new Point(26, 247);
            radModulus.Margin = new Padding(4, 5, 4, 5);
            radModulus.Name = "radModulus";
            radModulus.Size = new Size(156, 32);
            radModulus.TabIndex = 4;
            radModulus.TabStop = true;
            radModulus.Text = "Modulus (%)";
            radModulus.UseVisualStyleBackColor = true;
            // 
            // grpMathOperations
            // 
            grpMathOperations.Controls.Add(radModulus);
            grpMathOperations.Controls.Add(radDivision);
            grpMathOperations.Controls.Add(radMultiplication);
            grpMathOperations.Controls.Add(radSubtraction);
            grpMathOperations.Controls.Add(radAddition);
            grpMathOperations.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpMathOperations.Location = new Point(36, 183);
            grpMathOperations.Margin = new Padding(4, 5, 4, 5);
            grpMathOperations.Name = "grpMathOperations";
            grpMathOperations.Padding = new Padding(4, 5, 4, 5);
            grpMathOperations.Size = new Size(379, 300);
            grpMathOperations.TabIndex = 4;
            grpMathOperations.TabStop = false;
            grpMathOperations.Text = "Math Operations Available";
            // 
            // chkVerbose
            // 
            chkVerbose.AutoSize = true;
            chkVerbose.Checked = true;
            chkVerbose.CheckState = CheckState.Checked;
            chkVerbose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkVerbose.Location = new Point(36, 508);
            chkVerbose.Margin = new Padding(4, 5, 4, 5);
            chkVerbose.Name = "chkVerbose";
            chkVerbose.Size = new Size(268, 32);
            chkVerbose.TabIndex = 5;
            chkVerbose.Text = "Check for Verbose mode";
            chkVerbose.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCalculate.Location = new Point(479, 42);
            btnCalculate.Margin = new Padding(4, 5, 4, 5);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(171, 60);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReset.Location = new Point(479, 125);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(171, 60);
            btnReset.TabIndex = 7;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.Location = new Point(479, 208);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(171, 60);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblOutputMessage
            // 
            lblOutputMessage.BackColor = Color.LightYellow;
            lblOutputMessage.BorderStyle = BorderStyle.FixedSingle;
            lblOutputMessage.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblOutputMessage.Location = new Point(36, 583);
            lblOutputMessage.Margin = new Padding(4, 0, 4, 0);
            lblOutputMessage.Name = "lblOutputMessage";
            lblOutputMessage.Size = new Size(613, 157);
            lblOutputMessage.TabIndex = 9;
            lblOutputMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmRadioStar
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            CancelButton = btnExit;
            ClientSize = new Size(693, 783);
            Controls.Add(lblOutputMessage);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnCalculate);
            Controls.Add(chkVerbose);
            Controls.Add(grpMathOperations);
            Controls.Add(txtRightOperand);
            Controls.Add(lblRightOperand);
            Controls.Add(txtLeftOperand);
            Controls.Add(lblLeftOperand);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRadioStar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Radio Buttons in Action";
            grpMathOperations.ResumeLayout(false);
            grpMathOperations.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLeftOperand;
        private TextBox txtLeftOperand;
        private Label lblRightOperand;
        private TextBox txtRightOperand;
        private RadioButton radAddition;
        private RadioButton radSubtraction;
        private RadioButton radMultiplication;
        private RadioButton radDivision;
        private RadioButton radModulus;
        private GroupBox grpMathOperations;
        private CheckBox chkVerbose;
        private Button btnCalculate;
        private Button btnReset;
        private Button btnExit;
        private Label lblOutputMessage;
    }
}