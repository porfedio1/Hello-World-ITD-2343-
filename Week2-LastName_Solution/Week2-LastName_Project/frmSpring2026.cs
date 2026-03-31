/* Rafael Gonzales
   ITD-2343 Obj-Orient
   Due: 1/18/2026
*/

namespace Week2_LastName_Project
{
    public partial class frmSpring2026 : Form
    {
        public frmSpring2026()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clears the text in the label2 only
            label2.Text = "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Saves the text and copies in the label2
            String text = textBox1.Text;
            label2.Text = text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Closes the program and exits 
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //This is the cancel button that clears the textbox1 only
            textBox1.Clear();
        }
    }
}
