namespace lab04p01_gra_w_kolory
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int nr_koloru;
        int wynik = 0;
        String[] nazwy_kolorow = new String[] { "Zielony",
                                                "Niebieski",
                                                "Czerwony",
                                                "¯ó³ty"};
        Color[] barwy = new Color[] {   Color.Green,
                                        Color.Blue,
                                        Color.Red,
                                        Color.Yellow};
        public Form1()
        {
            InitializeComponent();
            losuj();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            if(nr_koloru == 0)
                wynik++;
            else
                wynik--;
            label2.Text= wynik.ToString();
            losuj();
        }

        private void losuj()
        {
            nr_koloru = random.Next(4);
            int barwa = random.Next(4);
            label1.Text = nazwy_kolorow[nr_koloru];
            label1.ForeColor = barwy[barwa];
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            if (nr_koloru == 1)
                wynik++;
            else
                wynik--;
            label2.Text = wynik.ToString();
            losuj();
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            if (nr_koloru ==2)
                wynik++;
            else
                wynik--;
            label2.Text = wynik.ToString();
            losuj();
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            if (nr_koloru == 3)
                wynik++;
            else
                wynik--;
            label2.Text = wynik.ToString();
            losuj();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            losuj();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel1.BackColor = Color.Gray;
            panel2.BackColor = Color.Gray;
            panel3.BackColor = Color.Gray;
            panel4.BackColor = Color.Gray;
            label3.Visible = true;
            timer2.Stop();
        }
    }
}