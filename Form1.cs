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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            str = textBox1.Text;
            string str2 = str.Replace("a", "augh");
            string str3 = str2.Replace("o", "augh");
            string str4 = str3.Replace("A", "Augh");
            string str5 = str4.Replace("O", "Augh");

            textBox2.Text = str5;
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
    }
}