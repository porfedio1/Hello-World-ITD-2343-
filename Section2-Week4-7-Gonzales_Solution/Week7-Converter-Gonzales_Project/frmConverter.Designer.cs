
namespace Week7_Converter_Gonzales_Project
{
    partial class frmConverter
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
            lblConvertFrom = new Label();
            txtConvertFrom = new TextBox();
            lblBase = new Label();
            txtBase = new TextBox();
            lblMessage = new Label();
            btnClear = new Button();
            btnProcess = new Button();
            btnBinary = new Button();
            btnHex = new Button();
            btnOctal = new Button();
            btnBase6 = new Button();
            btnBase9 = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblConvertFrom
            // 
            lblConvertFrom.BackColor = SystemColors.ActiveCaption;
            lblConvertFrom.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblConvertFrom.Location = new Point(50, 36);
            lblConvertFrom.Name = "lblConvertFrom";
            lblConvertFrom.Size = new Size(150, 50);
            lblConvertFrom.TabIndex = 0;
            lblConvertFrom.Text = "Convert From";
            lblConvertFrom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtConvertFrom
            // 
            txtConvertFrom.Location = new Point(309, 36);
            txtConvertFrom.Multiline = true;
            txtConvertFrom.Name = "txtConvertFrom";
            txtConvertFrom.Size = new Size(200, 50);
            txtConvertFrom.TabIndex = 1;
            txtConvertFrom.TextChanged += txtConvertFrom_TextChanged;
            // 
            // lblBase
            // 
            lblBase.BackColor = SystemColors.ActiveCaption;
            lblBase.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblBase.Location = new Point(50, 118);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(150, 50);
            lblBase.TabIndex = 2;
            lblBase.Text = "Base Number";
            lblBase.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(309, 118);
            txtBase.Multiline = true;
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(200, 50);
            txtBase.TabIndex = 3;
            txtBase.TextChanged += txtBase_TextChanged;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.FromArgb(192, 255, 192);
            lblMessage.Location = new Point(25, 366);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(750, 75);
            lblMessage.TabIndex = 4;
            lblMessage.Click += lblMessage_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(605, 46);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 40);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(606, 128);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(112, 40);
            btnProcess.TabIndex = 6;
            btnProcess.Text = "Process";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // btnBinary
            // 
            btnBinary.Location = new Point(50, 193);
            btnBinary.Name = "btnBinary";
            btnBinary.Size = new Size(112, 40);
            btnBinary.TabIndex = 7;
            btnBinary.Text = "Binary";
            btnBinary.UseVisualStyleBackColor = true;
            btnBinary.Click += btnBinary_Click;
            // 
            // btnHex
            // 
            btnHex.Location = new Point(344, 193);
            btnHex.Name = "btnHex";
            btnHex.Size = new Size(112, 40);
            btnHex.TabIndex = 8;
            btnHex.Text = "Hex";
            btnHex.UseVisualStyleBackColor = true;
            btnHex.Click += btnHex_Click;
            // 
            // btnOctal
            // 
            btnOctal.Location = new Point(605, 193);
            btnOctal.Name = "btnOctal";
            btnOctal.Size = new Size(112, 40);
            btnOctal.TabIndex = 9;
            btnOctal.Text = "Octal";
            btnOctal.UseVisualStyleBackColor = true;
            btnOctal.Click += btnOctal_Click;
            // 
            // btnBase6
            // 
            btnBase6.Location = new Point(50, 250);
            btnBase6.Name = "btnBase6";
            btnBase6.Size = new Size(112, 40);
            btnBase6.TabIndex = 10;
            btnBase6.Text = " Base 6";
            btnBase6.UseVisualStyleBackColor = true;
            btnBase6.Click += btnBase6_Click;
            // 
            // btnBase9
            // 
            btnBase9.Location = new Point(344, 250);
            btnBase9.Name = "btnBase9";
            btnBase9.Size = new Size(112, 40);
            btnBase9.TabIndex = 11;
            btnBase9.Text = "Base 9";
            btnBase9.UseVisualStyleBackColor = true;
            btnBase9.Click += btnBase9_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(50, 309);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 40);
            btnExit.TabIndex = 12;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmConverter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnBase9);
            Controls.Add(btnBase6);
            Controls.Add(btnOctal);
            Controls.Add(btnHex);
            Controls.Add(btnBinary);
            Controls.Add(btnProcess);
            Controls.Add(btnClear);
            Controls.Add(lblMessage);
            Controls.Add(txtBase);
            Controls.Add(lblBase);
            Controls.Add(txtConvertFrom);
            Controls.Add(lblConvertFrom);
            Name = "frmConverter";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblConvertFrom;
        private TextBox txtConvertFrom;
        private Label lblBase;
        private TextBox txtBase;
        private Label lblMessage;
        private Button btnClear;
        private Button btnProcess;
        private Button btnBinary;
        private Button btnHex;
        private Button btnOctal;
        private Button btnBase6;
        private Button btnBase9;
        private Button btnExit;
    }
}
