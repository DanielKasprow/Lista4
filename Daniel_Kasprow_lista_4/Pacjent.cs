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
        public string ulica { get; set; }
        public string miasto { get; set; }
        public string kraj { get; set; }

        public long pesel { get; set; }
        public long nr { get; set; }
        public long wiek { get; set; }

      /*  public BitmapImage obraz = new BitmapImage();

        public Uri uri { get; set; }*/


        /* public Pacjent()
         {
             imie = "...";
             nazwisko = "...";
             pesel = 0;
         }*/

       /* public Uri IconUrl
        {
            get
            {
                return obraz.UriSource;
            }
            set
            {
                obraz.UriSource = value;
            }
        }*/

        public Pacjent(string nimie, string nnazwisko,string nulica,string nmiasto,string nkraj,long nnr,long nwiek, long npesel/*, Uri nobraz*/)
        {
            imie = nimie;
            nazwisko = nnazwisko;
            ulica = nulica;
            miasto = nmiasto;
            kraj = nkraj;
            nr = nnr;
            wiek = nwiek;
            pesel = npesel;
           /* uri = nobraz;

            obraz.BeginInit();
            obraz.UriSource = uri;
            obraz.EndInit();*/
        }
    }
}
