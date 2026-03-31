/*
 Name: Rafael Gonzales
 Class: Obj-Orient Prg Using C#
 Due Date: 2/8/2026
*/
namespace Project5Gonzales
{
    partial class frmChoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoices));
            lblUserInstruction = new Label();
            lblLeft = new Label();
            lblRight = new Label();
            txtLowerNumber = new TextBox();
            txtMaxNumber = new TextBox();
            lblNumberChecked = new Label();
            txtEnterNumber = new TextBox();
            btnClear = new Button();
            btnExit = new Button();
            btnCheck = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblUserInstruction
            // 
            lblUserInstruction.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserInstruction.Location = new Point(142, 29);
            lblUserInstruction.Margin = new Padding(4, 0, 4, 0);
            lblUserInstruction.Name = "lblUserInstruction";
            lblUserInstruction.Size = new Size(895, 169);
            lblUserInstruction.TabIndex = 0;
            lblUserInstruction.Text = resources.GetString("lblUserInstruction.Text");
            lblUserInstruction.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLeft
            // 
            lblLeft.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLeft.Location = new Point(142, 233);
            lblLeft.Margin = new Padding(4, 0, 4, 0);
            lblLeft.Name = "lblLeft";
            lblLeft.Size = new Size(300, 60);
            lblLeft.TabIndex = 1;
            lblLeft.Text = "Left Number";
            lblLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRight
            // 
            lblRight.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRight.Location = new Point(737, 233);
            lblRight.Margin = new Padding(4, 0, 4, 0);
            lblRight.Name = "lblRight";
            lblRight.Size = new Size(300, 60);
            lblRight.TabIndex = 2;
            lblRight.Text = "Right Number";
            lblRight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLowerNumber
            // 
            txtLowerNumber.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            txtLowerNumber.Location = new Point(142, 310);
            txtLowerNumber.Multiline = true;
            txtLowerNumber.Name = "txtLowerNumber";
            txtLowerNumber.Size = new Size(300, 60);
            txtLowerNumber.TabIndex = 3;
            txtLowerNumber.TabStop = false;
            // 
            // txtMaxNumber
            // 
            txtMaxNumber.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            txtMaxNumber.Location = new Point(737, 310);
            txtMaxNumber.Multiline = true;
            txtMaxNumber.Name = "txtMaxNumber";
            txtMaxNumber.Size = new Size(300, 60);
            txtMaxNumber.TabIndex = 4;
            txtMaxNumber.TabStop = false;
            // 
            // lblNumberChecked
            // 
            lblNumberChecked.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumberChecked.Location = new Point(439, 404);
            lblNumberChecked.Name = "lblNumberChecked";
            lblNumberChecked.Size = new Size(300, 60);
            lblNumberChecked.TabIndex = 5;
            lblNumberChecked.Text = "Number to be Checked";
            lblNumberChecked.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEnterNumber
            // 
            txtEnterNumber.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEnterNumber.Location = new Point(439, 484);
            txtEnterNumber.Multiline = true;
            txtEnterNumber.Name = "txtEnterNumber";
            txtEnterNumber.Size = new Size(300, 60);
            txtEnterNumber.TabIndex = 6;
            txtEnterNumber.TabStop = false;
            txtEnterNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(142, 590);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 50);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clea&r";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(887, 590);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 50);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheck.Location = new Point(514, 590);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(150, 50);
            btnCheck.TabIndex = 8;
            btnCheck.Text = "&Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(255, 255, 192);
            lblResult.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(35, 712);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(1108, 95);
            lblResult.TabIndex = 10;
            // 
            // frmChoices
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1178, 844);
            Controls.Add(lblResult);
            Controls.Add(btnCheck);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(txtEnterNumber);
            Controls.Add(lblNumberChecked);
            Controls.Add(txtMaxNumber);
            Controls.Add(txtLowerNumber);
            Controls.Add(lblRight);
            Controls.Add(lblLeft);
            Controls.Add(lblUserInstruction);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmChoices";
            Text = "Gonzales Choices";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserInstruction;
        private Label lblLeft;
        private Label lblRight;
        private TextBox txtLowerNumber;
        private TextBox txtMaxNumber;
        private Label lblNumberChecked;
        private TextBox txtEnterNumber;
        private Button btnClear;
        private Button btnExit;
        private Button btnCheck;
        private Label lblResult;
    }
}
