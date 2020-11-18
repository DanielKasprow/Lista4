using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Daniel_Kasprow_lista_4
{
    /// <summary>
    /// Interaction logic for AddPacjent.xaml
    /// </summary>
    public partial class AddPacjent : Window
    {
        Pacjent kln;

        MainWindow mainwindow;

        public AddPacjent()
        {
            InitializeComponent();
        }

        public AddPacjent(MainWindow mainwindow) : this()
        {
            this.mainwindow = mainwindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt64(Textpesel.Text) > 9999999999 && Convert.ToInt64(Textpesel.Text) <= 99999999999)
                {
                    kln = new Pacjent(Textimie.Text, TextNazwisko.Text, Convert.ToInt64(Textpesel.Text));
                    MainWindow.klient.Add(kln);
                   // mainwindow.refresh();
                    this.Hide();
                }
                else MessageBox.Show("zla dlugosc pesela");
            }
            catch
            {
                MessageBox.Show("Pesel musi byc liczba");
            }
        }

    }
 }

