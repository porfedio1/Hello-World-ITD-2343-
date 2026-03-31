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
    partial class frmOfDataTypes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnByte = new Button();
            btnShort = new Button();
            btnInteger = new Button();
            btnLong = new Button();
            btnFloat = new Button();
            btnDouble = new Button();
            btnDecimal = new Button();
            btnPow = new Button();
            btnRound = new Button();
            btnSqrt = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblDisplay = new Label();
            SuspendLayout();
            // 
            // btnByte
            // 
            btnByte.BackColor = Color.Red;
            btnByte.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnByte.Location = new Point(15, 255);
            btnByte.Name = "btnByte";
            btnByte.Size = new Size(213, 72);
            btnByte.TabIndex = 0;
            btnByte.Text = "&Byte Integer";
            btnByte.UseVisualStyleBackColor = false;
            btnByte.Click += btnByte_Click;
            // 
            // btnShort
            // 
            btnShort.BackColor = Color.Red;
            btnShort.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnShort.Location = new Point(266, 255);
            btnShort.Name = "btnShort";
            btnShort.Size = new Size(213, 72);
            btnShort.TabIndex = 1;
            btnShort.Text = "&Short Integer";
            btnShort.UseVisualStyleBackColor = false;
            btnShort.Click += btnShort_Click;
            // 
            // btnInteger
            // 
            btnInteger.BackColor = Color.Red;
            btnInteger.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnInteger.Location = new Point(505, 255);
            btnInteger.Name = "btnInteger";
            btnInteger.Size = new Size(213, 72);
            btnInteger.TabIndex = 2;
            btnInteger.Text = "&Integer";
            btnInteger.UseVisualStyleBackColor = false;
            btnInteger.Click += btnInteger_Click;
            // 
            // btnLong
            // 
            btnLong.BackColor = Color.Red;
            btnLong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnLong.Location = new Point(747, 255);
            btnLong.Name = "btnLong";
            btnLong.Size = new Size(213, 72);
            btnLong.TabIndex = 3;
            btnLong.Text = "&Long Integer";
            btnLong.UseVisualStyleBackColor = false;
            btnLong.Click += btnLong_Click;
            // 
            // btnFloat
            // 
            btnFloat.BackColor = Color.Blue;
            btnFloat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnFloat.ForeColor = Color.White;
            btnFloat.Location = new Point(15, 360);
            btnFloat.Name = "btnFloat";
            btnFloat.Size = new Size(213, 72);
            btnFloat.TabIndex = 4;
            btnFloat.Text = "&Float Decimal";
            btnFloat.UseVisualStyleBackColor = false;
            btnFloat.Click += btnFloat_Click;
            // 
            // btnDouble
            // 
            btnDouble.BackColor = Color.Blue;
            btnDouble.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnDouble.ForeColor = Color.White;
            btnDouble.Location = new Point(266, 360);
            btnDouble.Name = "btnDouble";
            btnDouble.Size = new Size(213, 72);
            btnDouble.TabIndex = 5;
            btnDouble.Text = "&Double Decimal";
            btnDouble.UseVisualStyleBackColor = false;
            btnDouble.Click += btnDouble_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.Blue;
            btnDecimal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnDecimal.ForeColor = Color.White;
            btnDecimal.Location = new Point(505, 360);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(213, 72);
            btnDecimal.TabIndex = 6;
            btnDecimal.Text = "D&ecimal";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.Yellow;
            btnPow.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnPow.Location = new Point(15, 450);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(213, 72);
            btnPow.TabIndex = 7;
            btnPow.Text = "&Pow";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btnRound
            // 
            btnRound.BackColor = Color.Yellow;
            btnRound.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnRound.Location = new Point(266, 450);
            btnRound.Name = "btnRound";
            btnRound.Size = new Size(213, 72);
            btnRound.TabIndex = 8;
            btnRound.Text = "&Round Op";
            btnRound.UseVisualStyleBackColor = false;
            btnRound.Click += btnRound_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = Color.Yellow;
            btnSqrt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSqrt.Location = new Point(505, 450);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(213, 72);
            btnSqrt.TabIndex = 9;
            btnSqrt.Text = "S&quare Root";
            btnSqrt.UseVisualStyleBackColor = false;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnClear.Location = new Point(15, 548);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(213, 72);
            btnClear.TabIndex = 10;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveCaptionText;
            btnExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(266, 548);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(213, 72);
            btnExit.TabIndex = 11;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.BackColor = Color.FromArgb(192, 255, 255);
            lblDisplay.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplay.Location = new Point(24, 16);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(931, 203);
            lblDisplay.TabIndex = 12;
            lblDisplay.Text = "Click a Button";
            lblDisplay.TextAlign = ContentAlignment.MiddleCenter;
            lblDisplay.Click += lblDisplay_Click;
            // 
            // frmOfDataTypes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(978, 644);
            Controls.Add(lblDisplay);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSqrt);
            Controls.Add(btnRound);
            Controls.Add(btnPow);
            Controls.Add(btnDecimal);
            Controls.Add(btnDouble);
            Controls.Add(btnFloat);
            Controls.Add(btnLong);
            Controls.Add(btnInteger);
            Controls.Add(btnShort);
            Controls.Add(btnByte);
            Name = "frmOfDataTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Week 4 - Data Types";
            ResumeLayout(false);
        }

        #endregion

        private Button btnByte;
        private Button btnShort;
        private Button btnInteger;
        private Button btnLong;
        private Button btnFloat;
        private Button btnDouble;
        private Button btnDecimal;
        private Button btnPow;
        private Button btnRound;
        private Button btnSqrt;
        private Button btnClear;
        private Button btnExit;
        private Label lblDisplay;
    }
}
