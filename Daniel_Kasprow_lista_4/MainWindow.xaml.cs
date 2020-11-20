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
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Daniel_Kasprow_lista_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
        partial class MainWindow : Window
        {

        public static ObservableCollection<Pacjent> klient = new ObservableCollection<Pacjent>();

            AddPacjent addPacjent = new AddPacjent();

            public MainWindow()
            {
                InitializeComponent();
                addPacjent = new AddPacjent(this);
                initializeBinding();
        }

        private void initializeBinding()
        {
            klient = new ObservableCollection<Pacjent>();
            Persons.ItemsSource = klient;
        }

        public void refresh()
        {
            Persons.ItemsSource = "";
            Persons.ItemsSource = klient;
        }

        public void savefile()
            {
                Stream stream = File.Create(Environment.CurrentDirectory + "\\myText.txt");
            {
             //   BinaryFormatter formatter = new BinaryFormatter();
             //   formatter.Serialize(stream, klient);
            }
            XmlSerializer xmlSer = new XmlSerializer(typeof(ObservableCollection<Pacjent>));

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
            {
             //   BinaryFormatter formatter = new BinaryFormatter();
             //   formatter.Serialize(stream, klient);
            }
            XmlSerializer xmlSer = new XmlSerializer(typeof(ObservableCollection<Pacjent>));

                klient = (ObservableCollection<Pacjent>)xmlSer.Deserialize(stream);
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

