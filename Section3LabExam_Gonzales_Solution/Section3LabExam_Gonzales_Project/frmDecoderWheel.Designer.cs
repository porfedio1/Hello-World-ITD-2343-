namespace Sec3LabExam_Gonzales
{
    partial class frmDecoderWheel
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
            btnExit = new Button();
            btnReset = new Button();
            btnConvert = new Button();
            txtOutput = new TextBox();
            lblOutput = new Label();
            rdoCipherToPlain = new RadioButton();
            rdoPlainToCipher = new RadioButton();
            grpConversion = new GroupBox();
            txtInput = new TextBox();
            lblInput = new Label();
            grpConversion.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(300, 270);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 35);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(160, 270);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 35);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.Click += btnReset_Click;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(20, 270);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(100, 35);
            btnConvert.TabIndex = 5;
            btnConvert.Text = "Convert";
            btnConvert.Click += btnConvert_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(20, 225);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(400, 31);
            txtOutput.TabIndex = 4;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(20, 200);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(133, 25);
            lblOutput.TabIndex = 3;
            lblOutput.Text = "Converted Text:";
            // 
            // rdoCipherToPlain
            // 
            rdoCipherToPlain.AutoSize = true;
            rdoCipherToPlain.Location = new Point(20, 60);
            rdoCipherToPlain.Name = "rdoCipherToPlain";
            rdoCipherToPlain.Size = new Size(151, 29);
            rdoCipherToPlain.TabIndex = 1;
            rdoCipherToPlain.Text = "Cipher → Plain";
            // 
            // rdoPlainToCipher
            // 
            rdoPlainToCipher.AutoSize = true;
            rdoPlainToCipher.Location = new Point(20, 30);
            rdoPlainToCipher.Name = "rdoPlainToCipher";
            rdoPlainToCipher.Size = new Size(151, 29);
            rdoPlainToCipher.TabIndex = 0;
            rdoPlainToCipher.Text = "Plain → Cipher";
            // 
            // grpConversion
            // 
            grpConversion.Controls.Add(rdoPlainToCipher);
            grpConversion.Controls.Add(rdoCipherToPlain);
            grpConversion.Location = new Point(20, 80);
            grpConversion.Name = "grpConversion";
            grpConversion.Size = new Size(400, 100);
            grpConversion.TabIndex = 2;
            grpConversion.TabStop = false;
            grpConversion.Text = "Conversion Type";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(20, 45);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(400, 31);
            txtInput.TabIndex = 1;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(20, 20);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(91, 25);
            lblInput.TabIndex = 0;
            lblInput.Text = "Enter Text:";
            // 
            // frmDecoderWheel
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(450, 340);
            Controls.Add(lblInput);
            Controls.Add(txtInput);
            Controls.Add(grpConversion);
            Controls.Add(lblOutput);
            Controls.Add(txtOutput);
            Controls.Add(btnConvert);
            Controls.Add(btnReset);
            Controls.Add(btnExit);
            Name = "frmDecoderWheel";
            Text = "Decoder Wheel";
            grpConversion.ResumeLayout(false);
            grpConversion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnExit;
        private Button btnReset;
        private Button btnConvert;
        private TextBox txtOutput;
        private Label lblOutput;
        private RadioButton rdoCipherToPlain;
        private RadioButton rdoPlainToCipher;
        private GroupBox grpConversion;
        private TextBox txtInput;
        private Label lblInput;
    }
}