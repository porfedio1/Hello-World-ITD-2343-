using System.Drawing;
using System.Windows.Forms;

namespace Week8_10ProgrammingLab_Project
{
    /*
    Rafael Gonzales
    ITD 2343
    Week8_10ProgrammingLab_Project
    Due: 3/15/2026
    */

    partial class TextStats
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblInputText = new Label();
            lblListOutput = new Label();
            txtInputText = new TextBox();
            txtAvgUniqueWordLength = new TextBox();
            rdoAllWords = new RadioButton();
            rdoUniqueWords = new RadioButton();
            rdoTwoWordPairs = new RadioButton();
            chkFrequency = new CheckBox();
            grpListOptions = new GroupBox();
            btnLoadFile = new Button();
            btnProcess = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblSentenceCount = new Label();
            lblWordCount = new Label();
            lblUniqueWordCount = new Label();
            lblTwoWordPairCount = new Label();
            lblCharacterCount = new Label();
            lblAvgWordLength = new Label();
            lblAvgUniqueWordLength = new Label();
            txtSentenceCount = new TextBox();
            txtWordCount = new TextBox();
            txtUniqueWordCount = new TextBox();
            txtTwoWordPairCount = new TextBox();
            txtCharacterCount = new TextBox();
            txtAvgWordLength = new TextBox();
            txtListOutput = new TextBox();
            grpListOptions.SuspendLayout();
            SuspendLayout();
            // 
            // lblInputText
            // 
            lblInputText.AutoSize = true;
            lblInputText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInputText.Location = new Point(20, 15);
            lblInputText.Name = "lblInputText";
            lblInputText.Size = new Size(108, 28);
            lblInputText.TabIndex = 0;
            lblInputText.Text = "Input Text";
            // 
            // lblListOutput
            // 
            lblListOutput.AutoSize = true;
            lblListOutput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblListOutput.Location = new Point(690, 15);
            lblListOutput.Name = "lblListOutput";
            lblListOutput.Size = new Size(118, 28);
            lblListOutput.TabIndex = 1;
            lblListOutput.Text = "List Output";
            // 
            // txtInputText
            // 
            txtInputText.AcceptsReturn = true;
            txtInputText.BackColor = SystemColors.Control;
            txtInputText.Font = new Font("Segoe UI", 10F);
            txtInputText.Location = new Point(20, 50);
            txtInputText.Multiline = true;
            txtInputText.Name = "txtInputText";
            txtInputText.ScrollBars = ScrollBars.Vertical;
            txtInputText.Size = new Size(640, 420);
            txtInputText.TabIndex = 0;
            txtInputText.TextChanged += txtInputText_TextChanged;
            // 
            // txtAvgUniqueWordLength
            // 
            txtAvgUniqueWordLength.Location = new Point(600, 805);
            txtAvgUniqueWordLength.Name = "txtAvgUniqueWordLength";
            txtAvgUniqueWordLength.ReadOnly = true;
            txtAvgUniqueWordLength.Size = new Size(90, 31);
            txtAvgUniqueWordLength.TabIndex = 27;
            txtAvgUniqueWordLength.TabStop = false;
            // 
            // rdoAllWords
            // 
            rdoAllWords.AutoSize = true;
            rdoAllWords.Font = new Font("Segoe UI", 9F);
            rdoAllWords.Location = new Point(20, 35);
            rdoAllWords.Name = "rdoAllWords";
            rdoAllWords.Size = new Size(163, 29);
            rdoAllWords.TabIndex = 0;
            rdoAllWords.TabStop = true;
            rdoAllWords.Text = "Show All Words";
            rdoAllWords.UseVisualStyleBackColor = true;
            rdoAllWords.CheckedChanged += rdoAllWords_CheckedChanged;
            // 
            // rdoUniqueWords
            // 
            rdoUniqueWords.AutoSize = true;
            rdoUniqueWords.Font = new Font("Segoe UI", 9F);
            rdoUniqueWords.Location = new Point(20, 75);
            rdoUniqueWords.Name = "rdoUniqueWords";
            rdoUniqueWords.Size = new Size(199, 29);
            rdoUniqueWords.TabIndex = 1;
            rdoUniqueWords.TabStop = true;
            rdoUniqueWords.Text = "Show Unique Words";
            rdoUniqueWords.UseVisualStyleBackColor = true;
            rdoUniqueWords.CheckedChanged += rdoUniqueWords_CheckedChanged;
            // 
            // rdoTwoWordPairs
            // 
            rdoTwoWordPairs.AutoSize = true;
            rdoTwoWordPairs.Font = new Font("Segoe UI", 9F);
            rdoTwoWordPairs.Location = new Point(20, 115);
            rdoTwoWordPairs.Name = "rdoTwoWordPairs";
            rdoTwoWordPairs.Size = new Size(210, 29);
            rdoTwoWordPairs.TabIndex = 2;
            rdoTwoWordPairs.TabStop = true;
            rdoTwoWordPairs.Text = "Show Two-Word Pairs";
            rdoTwoWordPairs.UseVisualStyleBackColor = true;
            rdoTwoWordPairs.CheckedChanged += rdoTwoWordPairs_CheckedChanged;
            // 
            // chkFrequency
            // 
            chkFrequency.AutoSize = true;
            chkFrequency.Enabled = false;
            chkFrequency.Font = new Font("Segoe UI", 9F);
            chkFrequency.Location = new Point(20, 160);
            chkFrequency.Name = "chkFrequency";
            chkFrequency.Size = new Size(242, 29);
            chkFrequency.TabIndex = 3;
            chkFrequency.Text = "Include Frequency Counts";
            chkFrequency.UseVisualStyleBackColor = true;
            // 
            // grpListOptions
            // 
            grpListOptions.Controls.Add(chkFrequency);
            grpListOptions.Controls.Add(rdoTwoWordPairs);
            grpListOptions.Controls.Add(rdoUniqueWords);
            grpListOptions.Controls.Add(rdoAllWords);
            grpListOptions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpListOptions.Location = new Point(20, 490);
            grpListOptions.Name = "grpListOptions";
            grpListOptions.Size = new Size(310, 210);
            grpListOptions.TabIndex = 2;
            grpListOptions.TabStop = false;
            grpListOptions.Text = "List Options";
            // 
            // btnLoadFile
            // 
            btnLoadFile.BackColor = Color.LightSteelBlue;
            btnLoadFile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLoadFile.Location = new Point(350, 495);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(140, 50);
            btnLoadFile.TabIndex = 4;
            btnLoadFile.Text = "Load File";
            btnLoadFile.UseVisualStyleBackColor = false;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // btnProcess
            // 
            btnProcess.BackColor = Color.LightSteelBlue;
            btnProcess.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnProcess.Location = new Point(510, 495);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(140, 50);
            btnProcess.TabIndex = 5;
            btnProcess.Text = "Process";
            btnProcess.UseVisualStyleBackColor = false;
            btnProcess.Click += btnProcess_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightSteelBlue;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.Location = new Point(350, 560);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 50);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightSteelBlue;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.Location = new Point(510, 560);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(140, 50);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblSentenceCount
            // 
            lblSentenceCount.AutoSize = true;
            lblSentenceCount.Location = new Point(20, 730);
            lblSentenceCount.Name = "lblSentenceCount";
            lblSentenceCount.Size = new Size(136, 25);
            lblSentenceCount.TabIndex = 8;
            lblSentenceCount.Text = "Sentence Count";
            // 
            // lblWordCount
            // 
            lblWordCount.AutoSize = true;
            lblWordCount.Location = new Point(20, 770);
            lblWordCount.Name = "lblWordCount";
            lblWordCount.Size = new Size(109, 25);
            lblWordCount.TabIndex = 9;
            lblWordCount.Text = "Word Count";
            // 
            // lblUniqueWordCount
            // 
            lblUniqueWordCount.AutoSize = true;
            lblUniqueWordCount.Location = new Point(20, 810);
            lblUniqueWordCount.Name = "lblUniqueWordCount";
            lblUniqueWordCount.Size = new Size(170, 25);
            lblUniqueWordCount.TabIndex = 10;
            lblUniqueWordCount.Text = "Unique Word Count";
            // 
            // lblTwoWordPairCount
            // 
            lblTwoWordPairCount.AutoSize = true;
            lblTwoWordPairCount.Location = new Point(20, 850);
            lblTwoWordPairCount.Name = "lblTwoWordPairCount";
            lblTwoWordPairCount.Size = new Size(181, 25);
            lblTwoWordPairCount.TabIndex = 11;
            lblTwoWordPairCount.Text = "Two-Word Pair Count";
            // 
            // lblCharacterCount
            // 
            lblCharacterCount.AutoSize = true;
            lblCharacterCount.Location = new Point(350, 730);
            lblCharacterCount.Name = "lblCharacterCount";
            lblCharacterCount.Size = new Size(139, 25);
            lblCharacterCount.TabIndex = 12;
            lblCharacterCount.Text = "Character Count";
            // 
            // lblAvgWordLength
            // 
            lblAvgWordLength.AutoSize = true;
            lblAvgWordLength.Location = new Point(350, 770);
            lblAvgWordLength.Name = "lblAvgWordLength";
            lblAvgWordLength.Size = new Size(185, 25);
            lblAvgWordLength.TabIndex = 13;
            lblAvgWordLength.Text = "Average Word Length";
            // 
            // lblAvgUniqueWordLength
            // 
            lblAvgUniqueWordLength.AutoSize = true;
            lblAvgUniqueWordLength.Location = new Point(350, 810);
            lblAvgUniqueWordLength.Name = "lblAvgUniqueWordLength";
            lblAvgUniqueWordLength.Size = new Size(246, 25);
            lblAvgUniqueWordLength.TabIndex = 14;
            lblAvgUniqueWordLength.Text = "Average Unique Word Length";
            // 
            // txtSentenceCount
            // 
            txtSentenceCount.Location = new Point(210, 725);
            txtSentenceCount.Name = "txtSentenceCount";
            txtSentenceCount.ReadOnly = true;
            txtSentenceCount.Size = new Size(100, 31);
            txtSentenceCount.TabIndex = 21;
            txtSentenceCount.TabStop = false;
            // 
            // txtWordCount
            // 
            txtWordCount.Location = new Point(210, 765);
            txtWordCount.Name = "txtWordCount";
            txtWordCount.ReadOnly = true;
            txtWordCount.Size = new Size(100, 31);
            txtWordCount.TabIndex = 22;
            txtWordCount.TabStop = false;
            // 
            // txtUniqueWordCount
            // 
            txtUniqueWordCount.Location = new Point(210, 805);
            txtUniqueWordCount.Name = "txtUniqueWordCount";
            txtUniqueWordCount.ReadOnly = true;
            txtUniqueWordCount.Size = new Size(100, 31);
            txtUniqueWordCount.TabIndex = 23;
            txtUniqueWordCount.TabStop = false;
            // 
            // txtTwoWordPairCount
            // 
            txtTwoWordPairCount.Location = new Point(210, 845);
            txtTwoWordPairCount.Name = "txtTwoWordPairCount";
            txtTwoWordPairCount.ReadOnly = true;
            txtTwoWordPairCount.Size = new Size(100, 31);
            txtTwoWordPairCount.TabIndex = 24;
            txtTwoWordPairCount.TabStop = false;
            // 
            // txtCharacterCount
            // 
            txtCharacterCount.Location = new Point(600, 725);
            txtCharacterCount.Name = "txtCharacterCount";
            txtCharacterCount.ReadOnly = true;
            txtCharacterCount.Size = new Size(90, 31);
            txtCharacterCount.TabIndex = 25;
            txtCharacterCount.TabStop = false;
            // 
            // txtAvgWordLength
            // 
            txtAvgWordLength.Location = new Point(600, 765);
            txtAvgWordLength.Name = "txtAvgWordLength";
            txtAvgWordLength.ReadOnly = true;
            txtAvgWordLength.Size = new Size(90, 31);
            txtAvgWordLength.TabIndex = 26;
            txtAvgWordLength.TabStop = false;
            // 
            // txtListOutput
            // 
            txtListOutput.Font = new Font("Consolas", 10F);
            txtListOutput.Location = new Point(690, 50);
            txtListOutput.Multiline = true;
            txtListOutput.Name = "txtListOutput";
            txtListOutput.ReadOnly = true;
            txtListOutput.ScrollBars = ScrollBars.Vertical;
            txtListOutput.Size = new Size(330, 650);
            txtListOutput.TabIndex = 20;
            txtListOutput.TabStop = false;
            // 
            // TextStats
            // 
            AcceptButton = btnProcess;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            CancelButton = btnExit;
            ClientSize = new Size(1045, 900);
            Controls.Add(txtAvgUniqueWordLength);
            Controls.Add(txtAvgWordLength);
            Controls.Add(txtCharacterCount);
            Controls.Add(txtTwoWordPairCount);
            Controls.Add(txtUniqueWordCount);
            Controls.Add(txtWordCount);
            Controls.Add(txtSentenceCount);
            Controls.Add(lblAvgUniqueWordLength);
            Controls.Add(lblAvgWordLength);
            Controls.Add(lblCharacterCount);
            Controls.Add(lblTwoWordPairCount);
            Controls.Add(lblUniqueWordCount);
            Controls.Add(lblWordCount);
            Controls.Add(lblSentenceCount);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnProcess);
            Controls.Add(btnLoadFile);
            Controls.Add(grpListOptions);
            Controls.Add(txtListOutput);
            Controls.Add(txtInputText);
            Controls.Add(lblListOutput);
            Controls.Add(lblInputText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TextStats";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Week 8-10 Programming Lab - Text Statistics";
            Load += TextStats_Load;
            grpListOptions.ResumeLayout(false);
            grpListOptions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInputText;
        private Label lblListOutput;
        private TextBox txtInputText;
        private TextBox txtAvgUniqueWordLength;
        private RadioButton rdoAllWords;
        private RadioButton rdoUniqueWords;
        private RadioButton rdoTwoWordPairs;
        private CheckBox chkFrequency;
        private GroupBox grpListOptions;
        private Button btnLoadFile;
        private Button btnProcess;
        private Button btnClear;
        private Button btnExit;
        private Label lblSentenceCount;
        private Label lblWordCount;
        private Label lblUniqueWordCount;
        private Label lblTwoWordPairCount;
        private Label lblCharacterCount;
        private Label lblAvgWordLength;
        private Label lblAvgUniqueWordLength;
        private TextBox txtSentenceCount;
        private TextBox txtWordCount;
        private TextBox txtUniqueWordCount;
        private TextBox txtTwoWordPairCount;
        private TextBox txtCharacterCount;
        private TextBox txtAvgWordLength;
        private TextBox txtListOutput;
    }
}