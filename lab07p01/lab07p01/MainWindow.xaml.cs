using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Color = System.Windows.Media.Color;
using FontFamily = System.Windows.Media.FontFamily;

namespace lab07p01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            oknoTekstowe.Text = "  Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum convallis, quam nec malesuada rhoncus, odio metus vestibulum quam, in laoreet ex odio scelerisque mi. Sed sit amet egestas augue. Proin fermentum sit amet nibh eget facilisis. Suspendisse ultrices et lacus at placerat..";
        }

        private void bt_styl_fomtu_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FontDialog fontDialog1 = new System.Windows.Forms.FontDialog();
            if(fontDialog1.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                oknoTekstowe.FontFamily = new FontFamily(fontDialog1.Font.FontFamily.Name.ToString());
                oknoTekstowe.FontSize = fontDialog1.Font.Size;
            }
        }

        private void bt_kolor_fomtu_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.ColorDialog colorDialog1 = new System.Windows.Forms.ColorDialog();
            if(colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                byte R = colorDialog1.Color.R;
                byte G = colorDialog1.Color.G;
                byte B = colorDialog1.Color.B;
                Color kolor = Color.FromRgb(R, G, B);
                oknoTekstowe.Foreground = new SolidColorBrush(kolor);
            }
           
        }

        private void bt_kolor_tla_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.ColorDialog colorDialog1 = new System.Windows.Forms.ColorDialog();
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                byte R = colorDialog1.Color.R;
                byte G = colorDialog1.Color.G;
                byte B = colorDialog1.Color.B;
                Color kolor = Color.FromRgb(R, G, B);
                oknoTekstowe.Background = new SolidColorBrush(kolor);
            }
        }

        private void suwak_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            oknoTekstowe.FontSize = suwak.Value;
        }
    }
}
