namespace lab02p02
{
    public partial class Form1 : Form
    {

        public int licznik = 0;
        public int ile = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            licznik++;
            ile++;
            koloruj();
            label1.Text = licznik.ToString();
            blokada();
            progressBar1.Value = ile;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            licznik--;
            ile++;
            koloruj();
            label1.Text = licznik.ToString();
            blokada();
            progressBar1.Value = ile;
        }
        private void koloruj()
        {
            if(licznik>0)
            {
                label1.ForeColor = Color.Green;
            } else if(licznik<0)
            {
                label1.ForeColor= Color.Red;
            } else
            {
                label1.ForeColor= Color.Black;
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            licznik=0;
            koloruj();
            label1.Text = licznik.ToString() ;
        }
        private void blokada()
        {
            if(ile>=progressBar1.Maximum)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                label1.Enabled = false;
            }
        }
    }
}