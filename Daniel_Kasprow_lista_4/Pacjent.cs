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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Daniel_Kasprow_lista_4
{
    public class Pacjent
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }

        public long pesel { get; set; }

        private BitmapImage obraz = new BitmapImage();

       /* public Pacjent()
        {
            imie = "...";
            nazwisko = "...";
            pesel = 0;
        }*/

        public Uri IconUrl
        {
            get
            {
                return obraz.UriSource;
            }
            set
            {
                obraz.UriSource = value;
            }
        }

        public Pacjent(string nimie, string nnazwisko, long npesel, string nobraz)
        {
            imie = nimie;
            nazwisko = nnazwisko;
            pesel = npesel;
            //obraz = nobraz;
            obraz.BeginInit();
            obraz.UriSource = new Uri(nobraz, UriKind.Absolute);
            obraz.EndInit();
        }
    }
}
