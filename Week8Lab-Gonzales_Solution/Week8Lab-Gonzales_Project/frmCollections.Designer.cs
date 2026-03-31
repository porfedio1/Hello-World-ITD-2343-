namespace CollectionLab
/*
Rafael Gonzales
ITD 2343 – Object Oriented Programming with C#
Due: March 4, 2026
*/
{
    partial class frmCollections
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
            lblNumber = new Label();
            txtNumber = new TextBox();
            btnAddNumber = new Button();
            btnStatistics = new Button();
            btnReset = new Button();
            btnExit = new Button();
            lblCollection = new Label();
            lblStats = new Label();
            rtbCollectionDisplay = new RichTextBox();
            rtbStats = new RichTextBox();
            SuspendLayout();
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(28, 25);
            lblNumber.Margin = new Padding(4, 0, 4, 0);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(141, 25);
            lblNumber.TabIndex = 0;
            lblNumber.Text = "Enter an Integer:";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(32, 54);
            txtNumber.Margin = new Padding(4);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(274, 31);
            txtNumber.TabIndex = 1;
            // 
            // btnAddNumber
            // 
            btnAddNumber.Location = new Point(338, 50);
            btnAddNumber.Margin = new Padding(4);
            btnAddNumber.Name = "btnAddNumber";
            btnAddNumber.Size = new Size(275, 41);
            btnAddNumber.TabIndex = 2;
            btnAddNumber.Text = "Add Number to Collection";
            btnAddNumber.UseVisualStyleBackColor = true;
            btnAddNumber.Click += btnAddNumber_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.Location = new Point(638, 50);
            btnStatistics.Margin = new Padding(4);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(150, 41);
            btnStatistics.TabIndex = 3;
            btnStatistics.Text = "Statistics";
            btnStatistics.UseVisualStyleBackColor = true;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(812, 50);
            btnReset.Margin = new Padding(4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 41);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(988, 50);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 41);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblCollection
            // 
            lblCollection.AutoSize = true;
            lblCollection.Location = new Point(28, 112);
            lblCollection.Margin = new Padding(4, 0, 4, 0);
            lblCollection.Name = "lblCollection";
            lblCollection.Size = new Size(153, 25);
            lblCollection.TabIndex = 6;
            lblCollection.Text = "Collection Display";
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Location = new Point(338, 112);
            lblStats.Margin = new Padding(4, 0, 4, 0);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(84, 25);
            lblStats.TabIndex = 7;
            lblStats.Text = "Stats Box";
            // 
            // rtbCollectionDisplay
            // 
            rtbCollectionDisplay.BackColor = Color.AliceBlue;
            rtbCollectionDisplay.Location = new Point(32, 141);
            rtbCollectionDisplay.Margin = new Padding(4);
            rtbCollectionDisplay.Name = "rtbCollectionDisplay";
            rtbCollectionDisplay.Size = new Size(274, 374);
            rtbCollectionDisplay.TabIndex = 8;
            rtbCollectionDisplay.Text = "";
            // 
            // rtbStats
            // 
            rtbStats.BackColor = Color.Honeydew;
            rtbStats.Location = new Point(338, 141);
            rtbStats.Margin = new Padding(4);
            rtbStats.Name = "rtbStats";
            rtbStats.Size = new Size(799, 374);
            rtbStats.TabIndex = 9;
            rtbStats.Text = "";
            // 
            // frmCollections
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 550);
            Controls.Add(rtbStats);
            Controls.Add(rtbCollectionDisplay);
            Controls.Add(lblStats);
            Controls.Add(lblCollection);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnStatistics);
            Controls.Add(btnAddNumber);
            Controls.Add(txtNumber);
            Controls.Add(lblNumber);
            Margin = new Padding(4);
            Name = "frmCollections";
            Text = "Collection Lab";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnAddNumber;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCollection;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.RichTextBox rtbCollectionDisplay;
        private System.Windows.Forms.RichTextBox rtbStats;
    }
}