namespace Traughnslaughtaughr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string str;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            str = textBox1.Text;
            string result = string.Empty;
            foreach (char c in str)
            {
                if (c == 'a' || c == 'o')
                {
                    result += "augh";
                }
                else if (c == 'A' || c == 'O')
                {
                    result += "Augh";
                }
                else
                {
                    result += c;
                }
            }

            textBox2.Text = result;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}