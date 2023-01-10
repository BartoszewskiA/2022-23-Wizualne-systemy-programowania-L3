using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab08p01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog oknoOtwierania;
        SaveFileDialog oknoZapisywania;
        public MainWindow()
        {
            InitializeComponent();
            oknoOtwierania = new OpenFileDialog();
            oknoOtwierania.Title = "Otwórz plik";
            oknoOtwierania.Filter = "Pliki tekstowe|*.txt|Wszystkie pliki|*.*";
            oknoZapisywania = new SaveFileDialog();
            oknoZapisywania.Title = "Zapisz plik";
            oknoZapisywania.Filter = "Pliki tekstowe|*.txt|Wszystkie pliki|*.*";
            oknoZapisywania.DefaultExt = "txt";
        }

        private void bt_open_Click(object sender, RoutedEventArgs e)
        {
            if(oknoOtwierania.ShowDialog()==true)
            {
                oknoTekstowe.Text = File.ReadAllText(oknoOtwierania.FileName);
            }

        }

        private void bt_save_Click(object sender, RoutedEventArgs e)
        {
            if (oknoZapisywania.ShowDialog() == true)
            {
                File.WriteAllText(oknoZapisywania.FileName, oknoTekstowe.Text);
            }
        }
    }
}
