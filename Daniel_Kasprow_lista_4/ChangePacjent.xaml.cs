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
using System.IO;
using Microsoft.Win32;

namespace Daniel_Kasprow_lista_4
{
    /// <summary>
    /// Interaction logic for ChangePacjent.xaml
    /// </summary>
    public partial class ChangePacjent : Window
    {
        Pacjent kln;

        MainWindow mainwindow;

        public ChangePacjent()
        {
            InitializeComponent();
        }
        public ChangePacjent(MainWindow mainwindow) : this()
        {
            this.mainwindow = mainwindow;
        }
        private string picture="";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                openFileDialog.Title = "Select picture of patient";
                openFileDialog.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.Multiselect = false;
            }
            if (openFileDialog.ShowDialog() == true)
            {
                picture = openFileDialog.FileName;
                //uri = new Uri(picture, UriKind.Absolute);
                Zdjecie.Source = new BitmapImage(new Uri(picture));
            }
        }

        private void ButtonZapisz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt64(TextPesel.Text) > 9999999999 && Convert.ToInt64(TextPesel.Text) <= 99999999999)
                {
                    kln = new Pacjent(TextImie.Text, TextNazwisko.Text, TextUlica.Text, TextUlica.Text, TextKraj.Text, Convert.ToInt32(TextNr.Text), Convert.ToInt32(TextWiek.Text), Convert.ToInt64(TextPesel.Text), picture);
                    MainWindow.klient[mainwindow.i]=(kln);
                    this.Hide();
                }
                else MessageBox.Show("zla dlugosc pesela");
            }
            catch
            {
                MessageBox.Show("nr ulicy,wiek i pesel musi byc liczba");
            }
        }

        public void refresh()
        {
            TextImie.Text = MainWindow.klient[mainwindow.i].imie;
            TextNazwisko.Text = MainWindow.klient[mainwindow.i].nazwisko;
            TextUlica.Text = MainWindow.klient[mainwindow.i].ulica;
            TextNr.Text = MainWindow.klient[mainwindow.i].nr + "";
            TextMiasto.Text = MainWindow.klient[mainwindow.i].miasto;
            TextNazwisko.Text = MainWindow.klient[mainwindow.i].nazwisko;
            TextKraj.Text = MainWindow.klient[mainwindow.i].kraj;
            TextWiek.Text = MainWindow.klient[mainwindow.i].wiek + "";
            TextPesel.Text = MainWindow.klient[mainwindow.i].pesel + "";
            picture = MainWindow.klient[mainwindow.i].picture;
            Zdjecie.Source = new BitmapImage(new Uri(picture));
        }
    }
}
