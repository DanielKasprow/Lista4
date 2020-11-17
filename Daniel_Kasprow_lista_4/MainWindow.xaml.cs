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
using System.IO;
using System.Xml.Serialization;

namespace Daniel_Kasprow_lista_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
        partial class MainWindow : Window
        {
            public static List<Pacjent> klient = new List<Pacjent>();

            Pacjent kln;
            AddPacjent addPacjent = new AddPacjent();

            private int i = 0;

            public MainWindow()
            {
                InitializeComponent();
                addPacjent = new AddPacjent(this);
                refresh();
                if (klient.Count > 0)
                {
                    klient[0].Writeimie(listaimie);
                    klient[0].Writenazwisko(listanazwisko);
                    klient[0].Writepesel(listapesel);
                }
            }

            public void refresh()
            {
                listaimie.Items.Clear();
                listanazwisko.Items.Clear();
                listapesel.Items.Clear();
                // i = 0;
                foreach (Pacjent c in klient)
                {
                    c.Writeimie(listaimie);
                    c.Writenazwisko(listanazwisko);
                    c.Writepesel(listapesel);
                }
                /*  try
                  {
                      do
                      {
                          klient[i].Writeimie(listaimie);
                          klient[i].Writenazwisko(listanazwisko);
                          klient[i].Writepesel(listapesel);
                          i++;
                      }
                      while (i >= 0);
                  }
                  catch { }*/
            }

            public void savefile()
            {
                Stream stream = File.Create(Environment.CurrentDirectory + "\\myText.txt");

                XmlSerializer xmlSer = new XmlSerializer(typeof(List<Pacjent>));

                xmlSer.Serialize(stream, klient);

                stream.Close();
            }

            public void openfile()
            {
                if (!File.Exists(Environment.CurrentDirectory + "\\myText.txt"))
                {
                    savefile();
                }
                FileStream stream = File.OpenRead(Environment.CurrentDirectory + "\\myText.txt");

                XmlSerializer xmlSer = new XmlSerializer(typeof(List<Pacjent>));

                klient = (List<Pacjent>)xmlSer.Deserialize(stream);
                stream.Close();
                refresh();
            }
            private void ButtonDodaj_Click(object sender, RoutedEventArgs e)
            {
                addPacjent.Show();
            }

            private void ButtonZapisz_Click(object sender, RoutedEventArgs e)
            {
                savefile();
            }

            private void ButtonWczytaj_Click(object sender, RoutedEventArgs e)
            {
                openfile();
            }
        }
    }

