using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

/*
Rafael Gonzales
ITD 2343
Week8_10ProgrammingLab_Project
Due: 3/15/2026
*/

namespace Week8_10ProgrammingLab_Project
{
    // Main form that performs text analysis
    public partial class TextStats : Form
    {
        // Constructor – sets default form state
        public TextStats()
        {
            InitializeComponent();
            ResetForm();
        }

        private void TextStats_Load(object sender, EventArgs e)
        {
            txtInputText.Focus();
        }

        // When text changes, clear old results and update controls
        private void txtInputText_TextChanged(object sender, EventArgs e)
        {
            txtListOutput.Clear();
            ClearStats();
            UpdateControlStates();
        }

        private void rdoAllWords_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControlStates();
        }

        private void rdoUniqueWords_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControlStates();
        }

        private void rdoTwoWordPairs_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControlStates();
        }

        // Enable/disable controls based on user selections
        private void UpdateControlStates()
        {
            bool hasText = txtInputText.Text.Trim() != "";
            btnProcess.Enabled = hasText;

            if (rdoUniqueWords.Checked)
                chkFrequency.Enabled = true;
            else
            {
                chkFrequency.Enabled = false;
                chkFrequency.Checked = false;
            }
        }

        // Loads text from a .txt file into the input textbox
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open Text File";
            dialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtInputText.Text = File.ReadAllText(dialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to load file.\n\n" + ex.Message);
                }
            }
        }

        // Main processing button
        private void btnProcess_Click(object sender, EventArgs e)
        {
            string inputText = txtInputText.Text;

            if (!ValidateInput(inputText))
                return;

            int sentenceCount = CountSentences(inputText);
            int characterCount = inputText.Length;

            List<string> words = GetWords(inputText);

            List<string> sortedWords = new List<string>(words);
            sortedWords.Sort();

            Dictionary<string, int> frequencies = GetWordFrequencies(words);
            List<string> uniqueWords = GetUniqueWords(frequencies);

            List<string> twoWordPairs = GetTwoWordPairs(words);
            List<string> repeatedPairs = GetRepeatedTwoWordPairs(twoWordPairs);

            double avgWordLength = GetAverageLength(words);
            double avgUniqueWordLength = GetAverageLength(uniqueWords);

            DisplayStats(
                sentenceCount,
                words.Count,
                uniqueWords.Count,
                repeatedPairs.Count,
                characterCount,
                avgWordLength,
                avgUniqueWordLength);

            DisplayRequestedList(sortedWords, uniqueWords, frequencies, repeatedPairs);
        }

        // Prevent processing when input is empty
        private bool ValidateInput(string text)
        {
            if (text.Trim() == "")
            {
                MessageBox.Show("Please enter text or load a text file.");
                txtInputText.Focus();
                return false;
            }
            return true;
        }

        // Count sentences by looking for . ? !
        private int CountSentences(string text)
        {
            int count = 0;

            foreach (char c in text)
                if (c == '.' || c == '?' || c == '!')
                    count++;

            return count;
        }

        // Extract valid words from text
        private List<string> GetWords(string text)
        {
            List<string> words = new List<string>();
            StringBuilder currentWord = new StringBuilder();

            foreach (char c in text)
            {
                char ch = char.ToLower(c);

                if (char.IsLetter(ch) || ch == '\'' || ch == '-')
                    currentWord.Append(ch);
                else
                    AddWordIfValid(words, currentWord);
            }

            AddWordIfValid(words, currentWord);
            return words;
        }

        // Adds completed word to list if valid
        private void AddWordIfValid(List<string> words, StringBuilder currentWord)
        {
            if (currentWord.Length == 0)
                return;

            string word = TrimEdgePunctuation(currentWord.ToString());

            if (word != "" && ContainsLetter(word))
                words.Add(word);

            currentWord.Clear();
        }

        // Removes leading or trailing hyphens/apostrophes
        private string TrimEdgePunctuation(string word)
        {
            while (word.Length > 0 && (word[0] == '\'' || word[0] == '-'))
                word = word.Substring(1);

            while (word.Length > 0 && (word[word.Length - 1] == '\'' || word[word.Length - 1] == '-'))
                word = word.Substring(0, word.Length - 1);

            return word;
        }

        private bool ContainsLetter(string word)
        {
            foreach (char c in word)
                if (char.IsLetter(c))
                    return true;

            return false;
        }

        // Builds frequency dictionary
        private Dictionary<string, int> GetWordFrequencies(List<string> words)
        {
            Dictionary<string, int> frequencies = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (frequencies.ContainsKey(word))
                    frequencies[word]++;
                else
                    frequencies.Add(word, 1);
            }

            return frequencies;
        }

        // Extract unique words
        private List<string> GetUniqueWords(Dictionary<string, int> frequencies)
        {
            List<string> uniqueWords = new List<string>(frequencies.Keys);
            uniqueWords.Sort();
            return uniqueWords;
        }

        // Build two-word pairs
        private List<string> GetTwoWordPairs(List<string> words)
        {
            List<string> pairs = new List<string>();

            for (int i = 0; i < words.Count - 1; i++)
                pairs.Add(words[i] + " " + words[i + 1]);

            return pairs;
        }

        // Keep only pairs appearing more than once
        private List<string> GetRepeatedTwoWordPairs(List<string> pairs)
        {
            Dictionary<string, int> pairCounts = new Dictionary<string, int>();

            foreach (string pair in pairs)
            {
                if (pairCounts.ContainsKey(pair))
                    pairCounts[pair]++;
                else
                    pairCounts.Add(pair, 1);
            }

            List<string> repeatedPairs = new List<string>();

            foreach (var item in pairCounts)
            {
                if (item.Value > 1)
                    for (int i = 0; i < item.Value; i++)
                        repeatedPairs.Add(item.Key);
            }

            repeatedPairs.Sort();
            return repeatedPairs;
        }

        // Calculate average length of strings
        private double GetAverageLength(List<string> items)
        {
            if (items.Count == 0)
                return 0;

            int total = 0;

            foreach (string item in items)
                total += item.Length;

            return (double)total / items.Count;
        }

        // Display statistics based on selected radio button
        private void DisplayStats(
            int sentenceCount,
            int wordCount,
            int uniqueWordCount,
            int twoWordPairCount,
            int characterCount,
            double avgWordLength,
            double avgUniqueWordLength)
        {
            txtSentenceCount.Text = sentenceCount.ToString();
            txtCharacterCount.Text = characterCount.ToString();

            if (rdoAllWords.Checked)
            {
                txtWordCount.Text = wordCount.ToString();
                txtAvgWordLength.Text = avgWordLength.ToString("F2");

                txtUniqueWordCount.Clear();
                txtTwoWordPairCount.Clear();
                txtAvgUniqueWordLength.Clear();
            }
            else if (rdoUniqueWords.Checked)
            {
                txtWordCount.Text = wordCount.ToString();
                txtUniqueWordCount.Text = uniqueWordCount.ToString();
                txtAvgWordLength.Text = avgWordLength.ToString("F2");
                txtAvgUniqueWordLength.Text = avgUniqueWordLength.ToString("F2");

                txtTwoWordPairCount.Clear();
            }
            else
            {
                txtWordCount.Text = wordCount.ToString();
                txtTwoWordPairCount.Text = twoWordPairCount.ToString();
                txtAvgWordLength.Text = avgWordLength.ToString("F2");

                txtUniqueWordCount.Clear();
                txtAvgUniqueWordLength.Clear();
            }
        }

        // Display the selected word list
        private void DisplayRequestedList(
            List<string> sortedWords,
            List<string> uniqueWords,
            Dictionary<string, int> frequencies,
            List<string> repeatedPairs)
        {
            StringBuilder output = new StringBuilder();

            if (rdoAllWords.Checked)
                foreach (string word in sortedWords)
                    output.AppendLine(word);

            else if (rdoUniqueWords.Checked)
                foreach (string word in uniqueWords)
                    output.AppendLine(
                        chkFrequency.Checked
                        ? word + " (" + frequencies[word] + ")"
                        : word);

            else
                foreach (string pair in repeatedPairs)
                    output.AppendLine(pair);

            txtListOutput.Text = output.ToString();
        }

        // Reset form
        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtInputText.Clear();
            txtListOutput.Clear();

            rdoAllWords.Checked = true;
            chkFrequency.Checked = false;
            chkFrequency.Enabled = false;

            txtListOutput.ReadOnly = true;

            ClearStats();
            UpdateControlStates();

            txtInputText.Focus();
        }

        // Clear statistic textboxes
        private void ClearStats()
        {
            txtSentenceCount.Clear();
            txtWordCount.Clear();
            txtUniqueWordCount.Clear();
            txtTwoWordPairCount.Clear();
            txtCharacterCount.Clear();
            txtAvgWordLength.Clear();
            txtAvgUniqueWordLength.Clear();
        }

        // Confirm before exiting
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to close the application?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}