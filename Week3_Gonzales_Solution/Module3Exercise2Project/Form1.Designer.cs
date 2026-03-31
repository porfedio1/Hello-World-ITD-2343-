using System.ComponentModel.Design;

///Rafael Gonzales
///ITD-2343 Obj-Orient C#
///1/25/2026
namespace Module3Exercise2Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
       
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.ForeColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(32, 25);
            this.btnRed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(140, 69);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "RED";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.ForeColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(564, 25);
            this.btnBlue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(140, 69);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.Text = "BLUE";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(564, 239);
            this.btnR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(140, 69);
            this.btnR.TabIndex = 3;
            this.btnR.Text = "&R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(32, 239);
            this.btnL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(140, 69);
            this.btnL.TabIndex = 2;
            this.btnL.Text = "&L";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(204, 360);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(324, 149);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(200, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 283);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(722, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

    
        ///Buttons were changed to their new Names. 
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

