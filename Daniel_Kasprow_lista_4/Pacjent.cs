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
        public string imie;
        public string nazwisko;

        public long pesel;

        public Pacjent()
        {
            imie = "...";
            nazwisko = "...";
            pesel = 0;
        }

        public Pacjent(string imie, string nazwisko, long pesel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
        }

        public void Writeimie(ListBox lp)
        {
            lp.Items.Add(imie);
            //lp.Items.Add(nazwisko);
            //lp.Items.Add(pesel);
        }
        public void Writenazwisko(ListBox lp)
        {
            //lp.Items.Add(imie);
            lp.Items.Add(nazwisko);
            //lp.Items.Add(pesel);
        }
        public void Writepesel(ListBox lp)
        {
            //lp.Items.Add(imie);
            //lp.Items.Add(nazwisko);
            lp.Items.Add(pesel);
        }
    }
}
