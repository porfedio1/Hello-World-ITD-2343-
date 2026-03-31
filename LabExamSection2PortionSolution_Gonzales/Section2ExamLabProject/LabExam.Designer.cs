using System.Drawing;
using System.Windows.Forms;
/*
Rafael Gonzales
Exam Section 2 Lab Portion
ITD 2343 – Object Oriented Programming with C#
*/

namespace LabExam
{
    partial class LabExam
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblShow = new Label();
            btnShowModulus = new Button();
            btnShowFactorial = new Button();
            btnShowFibonacci = new Button();
            lblDo = new Label();
            btnDoModulus = new Button();
            btnDoFactorial = new Button();
            btnDoFibonacci = new Button();
            lblOperand1 = new Label();
            txtOperand1 = new TextBox();
            lblOperand2 = new Label();
            txtOperand2 = new TextBox();
            btnClear = new Button();
            btnExit = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lblShow
            // 
            lblShow.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblShow.Location = new Point(30, 40);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(100, 30);
            lblShow.TabIndex = 99;
            lblShow.Text = "Show:";
            // 
            // btnShowModulus
            // 
            btnShowModulus.BackColor = Color.FromArgb(255, 128, 128);
            btnShowModulus.Font = new Font("Courier New", 14F);
            btnShowModulus.Location = new Point(150, 30);
            btnShowModulus.Name = "btnShowModulus";
            btnShowModulus.Size = new Size(187, 45);
            btnShowModulus.TabIndex = 0;
            btnShowModulus.Text = "Modulus";
            btnShowModulus.UseVisualStyleBackColor = false;
            btnShowModulus.Click += btnShowModulus_Click;
            // 
            // btnShowFactorial
            // 
            btnShowFactorial.BackColor = Color.FromArgb(255, 128, 128);
            btnShowFactorial.Font = new Font("Courier New", 14F);
            btnShowFactorial.Location = new Point(374, 30);
            btnShowFactorial.Name = "btnShowFactorial";
            btnShowFactorial.Size = new Size(187, 45);
            btnShowFactorial.TabIndex = 2;
            btnShowFactorial.Text = "Factorial";
            btnShowFactorial.UseVisualStyleBackColor = false;
            btnShowFactorial.Click += btnShowFactorial_Click;
            // 
            // btnShowFibonacci
            // 
            btnShowFibonacci.BackColor = Color.FromArgb(255, 128, 128);
            btnShowFibonacci.Font = new Font("Courier New", 14F);
            btnShowFibonacci.Location = new Point(592, 30);
            btnShowFibonacci.Name = "btnShowFibonacci";
            btnShowFibonacci.Size = new Size(187, 45);
            btnShowFibonacci.TabIndex = 4;
            btnShowFibonacci.Text = "Fibonacci";
            btnShowFibonacci.UseVisualStyleBackColor = false;
            btnShowFibonacci.Click += btnShowFibonacci_Click;
            // 
            // lblDo
            // 
            lblDo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDo.Location = new Point(30, 100);
            lblDo.Name = "lblDo";
            lblDo.Size = new Size(100, 30);
            lblDo.TabIndex = 99;
            lblDo.Text = "Do:";
            // 
            // btnDoModulus
            // 
            btnDoModulus.BackColor = Color.FromArgb(255, 128, 128);
            btnDoModulus.Enabled = false;
            btnDoModulus.Font = new Font("Courier New", 14F);
            btnDoModulus.Location = new Point(150, 90);
            btnDoModulus.Name = "btnDoModulus";
            btnDoModulus.Size = new Size(187, 45);
            btnDoModulus.TabIndex = 1;
            btnDoModulus.Text = "&Modulus";
            btnDoModulus.UseVisualStyleBackColor = false;
            btnDoModulus.Click += btnDoModulus_Click;
            // 
            // btnDoFactorial
            // 
            btnDoFactorial.BackColor = Color.FromArgb(255, 128, 128);
            btnDoFactorial.Enabled = false;
            btnDoFactorial.Font = new Font("Courier New", 14F);
            btnDoFactorial.Location = new Point(374, 90);
            btnDoFactorial.Name = "btnDoFactorial";
            btnDoFactorial.Size = new Size(187, 45);
            btnDoFactorial.TabIndex = 3;
            btnDoFactorial.Text = "&Factorial";
            btnDoFactorial.UseVisualStyleBackColor = false;
            btnDoFactorial.Click += btnDoFactorial_Click;
            // 
            // btnDoFibonacci
            // 
            btnDoFibonacci.BackColor = Color.FromArgb(255, 128, 128);
            btnDoFibonacci.Enabled = false;
            btnDoFibonacci.Font = new Font("Courier New", 14F);
            btnDoFibonacci.Location = new Point(592, 90);
            btnDoFibonacci.Name = "btnDoFibonacci";
            btnDoFibonacci.Size = new Size(187, 45);
            btnDoFibonacci.TabIndex = 5;
            btnDoFibonacci.Text = "&Fibonacci";
            btnDoFibonacci.UseVisualStyleBackColor = false;
            btnDoFibonacci.Click += btnDoFibonacci_Click;
            // 
            // lblOperand1
            // 
            lblOperand1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOperand1.Location = new Point(30, 170);
            lblOperand1.Name = "lblOperand1";
            lblOperand1.Size = new Size(200, 30);
            lblOperand1.TabIndex = 99;
            lblOperand1.Text = "Operand 1:";
            lblOperand1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtOperand1
            // 
            txtOperand1.Font = new Font("Courier New", 14F);
            txtOperand1.Location = new Point(250, 170);
            txtOperand1.Name = "txtOperand1";
            txtOperand1.Size = new Size(200, 39);
            txtOperand1.TabIndex = 99;
            txtOperand1.TabStop = false;
            // 
            // lblOperand2
            // 
            lblOperand2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOperand2.Location = new Point(30, 220);
            lblOperand2.Name = "lblOperand2";
            lblOperand2.Size = new Size(200, 30);
            lblOperand2.TabIndex = 99;
            lblOperand2.Text = "Operand 2:";
            lblOperand2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtOperand2
            // 
            txtOperand2.Font = new Font("Courier New", 14F);
            txtOperand2.Location = new Point(250, 220);
            txtOperand2.Name = "txtOperand2";
            txtOperand2.Size = new Size(200, 39);
            txtOperand2.TabIndex = 99;
            txtOperand2.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightGray;
            btnClear.Font = new Font("Courier New", 14F);
            btnClear.Location = new Point(592, 170);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(187, 45);
            btnClear.TabIndex = 6;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Black;
            btnExit.Font = new Font("Courier New", 14F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(592, 220);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(187, 45);
            btnExit.TabIndex = 7;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.LightBlue;
            lblMessage.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            lblMessage.ForeColor = Color.Black;
            lblMessage.Location = new Point(39, 343);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(749, 246);
            lblMessage.TabIndex = 99;
            // 
            // LabExam
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(827, 641);
            Controls.Add(lblShow);
            Controls.Add(btnShowModulus);
            Controls.Add(btnShowFactorial);
            Controls.Add(btnShowFibonacci);
            Controls.Add(lblDo);
            Controls.Add(btnDoModulus);
            Controls.Add(btnDoFactorial);
            Controls.Add(btnDoFibonacci);
            Controls.Add(lblOperand1);
            Controls.Add(txtOperand1);
            Controls.Add(lblOperand2);
            Controls.Add(txtOperand2);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(lblMessage);
            Name = "LabExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Operations Rafael Gonzales";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblShow;
        private Button btnShowModulus;
        private Button btnShowFactorial;
        private Button btnShowFibonacci;
        private Label lblDo;
        private Button btnDoModulus;
        private Button btnDoFactorial;
        private Button btnDoFibonacci;
        private Label lblOperand1;
        private TextBox txtOperand1;
        private Label lblOperand2;
        private TextBox txtOperand2;
        private Button btnClear;
        private Button btnExit;
        private Label lblMessage;
    }
}
