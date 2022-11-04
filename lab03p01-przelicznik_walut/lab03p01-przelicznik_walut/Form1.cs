namespace lab03p01_przelicznik_walut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            opisz();
        }

        private void opisz()
        {
            if (radioButton1.Checked)
                label1.Text = radioButton1.Text;
            else if (radioButton2.Checked)
                label1.Text = radioButton2.Text;
            else
                label1.Text = radioButton3.Text;

            if (radioButton4.Checked)
                label2.Text = radioButton4.Text;
            else if (radioButton5.Checked)
                label2.Text = radioButton5.Text;
            else
                label2.Text = radioButton6.Text;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
            textBox2.Text = przelicz(hScrollBar1.Value).ToString();
        }

        private double przelicz(double x)
        {
            //przelicznie na walutê poœredni¹ PLN
            double posrednia = 0;
            if(radioButton1.Checked)
            {
                posrednia = x;
            } else if(radioButton2.Checked)
            {
                posrednia = x * 4.77;
            } else
            {
                posrednia = x * 4.73;
            }
            //przeliczenie na walitê wynikow¹
            double wynik = 0;
            if (radioButton4.Checked)
            {
                wynik = posrednia;
            }
            else if (radioButton5.Checked)
            {
                wynik= posrednia / 4.77;
            }
            else
            {
                wynik = posrednia / 4.73;
            }

            wynik = Math.Round(wynik, 2);

            return wynik;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = przelicz(hScrollBar1.Value).ToString();
            opisz();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = przelicz(hScrollBar1.Value).ToString();
            opisz();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = przelicz(hScrollBar1.Value).ToString();
            opisz();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = przelicz(hScrollBar1.Value).ToString();
            opisz();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = przelicz(hScrollBar1.Value).ToString();
            opisz();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = przelicz(hScrollBar1.Value).ToString();
            opisz();
        }
    }
}