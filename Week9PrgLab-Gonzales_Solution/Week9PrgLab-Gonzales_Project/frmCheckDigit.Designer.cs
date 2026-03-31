using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
/*
Rafael Gonzales
ITD 2343
Week 9 - Programming Lab
Due: 3/8/2026
*/
namespace Week9PrgLab_Gonzales_Project
{
    partial class frmCheckDigit
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblAccount = new Label();
            lblConfirm = new Label();
            lblPayment = new Label();
            txtAccount = new TextBox();
            txtConfirm = new TextBox();
            txtPayment = new TextBox();
            btnProcess = new Button();
            btnReset = new Button();
            btnExit = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lblAccount
            // 
            lblAccount.Location = new Point(60, 40);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(200, 25);
            lblAccount.TabIndex = 0;
            lblAccount.Text = "Account Number:";
            // 
            // lblConfirm
            // 
            lblConfirm.Location = new Point(60, 90);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(200, 25);
            lblConfirm.TabIndex = 1;
            lblConfirm.Text = "Confirm Account:";
            // 
            // lblPayment
            // 
            lblPayment.Location = new Point(60, 140);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(200, 25);
            lblPayment.TabIndex = 2;
            lblPayment.Text = "Payment Amount:";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(260, 40);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(200, 31);
            txtAccount.TabIndex = 3;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(260, 90);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(200, 31);
            txtConfirm.TabIndex = 4;
            // 
            // txtPayment
            // 
            txtPayment.Location = new Point(260, 140);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(200, 31);
            txtPayment.TabIndex = 5;
            // 
            // btnProcess
            // 
            btnProcess.BackColor = SystemColors.ButtonHighlight;
            btnProcess.Location = new Point(60, 200);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(120, 40);
            btnProcess.TabIndex = 6;
            btnProcess.Text = "&Process";
            btnProcess.UseVisualStyleBackColor = false;
            btnProcess.Click += btnProcess_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ButtonHighlight;
            btnReset.Location = new Point(200, 200);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 40);
            btnReset.TabIndex = 7;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(340, 200);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 40);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.FromArgb(255, 255, 192);
            lblMessage.BorderStyle = BorderStyle.FixedSingle;
            lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblMessage.Location = new Point(20, 280);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(740, 120);
            lblMessage.TabIndex = 9;
            lblMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmCheckDigit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 420);
            Controls.Add(lblAccount);
            Controls.Add(lblConfirm);
            Controls.Add(lblPayment);
            Controls.Add(txtAccount);
            Controls.Add(txtConfirm);
            Controls.Add(txtPayment);
            Controls.Add(btnProcess);
            Controls.Add(btnReset);
            Controls.Add(btnExit);
            Controls.Add(lblMessage);
            Name = "frmCheckDigit";
            Text = "Check Digit Verification";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccount;
        private Label lblConfirm;
        private Label lblPayment;

        private TextBox txtAccount;
        private TextBox txtConfirm;
        private TextBox txtPayment;

        private Button btnProcess;
        private Button btnReset;
        private Button btnExit;

        private Label lblMessage;
    }
}
