namespace lab02p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y, wynik;
            if(int.TryParse(textBox1.Text, out x)) { }
            else {
                x = 0;
                textBox1.Text = 0.ToString();
            }
            if (int.TryParse(textBox2.Text, out y)) { }
            else
            {
                y = 0;
                textBox2.Text = 0.ToString();
            }

            if (x > y) { wynik = x - y; }
            else
            {
                wynik = y - x;
            }
            label1.Text = "Odleg³oœc = "+wynik.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = 0.ToString();
            textBox2.Text = 0.ToString();
            label1.Text = "";
        }
    }
}