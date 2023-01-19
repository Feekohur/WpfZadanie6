using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfZadanie6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            osoby.Add(new Osoba("Bogusław", "Łęcina", "blecina1@gmail.com", 100, "Białystok", 1));
            osoby.Add(new Osoba("Dominik", "Jachaś", "dominogalakpizza@gmail.com", 0.00M, "Warszawa", 5));
            osoby.Add(new Osoba("Adam", "Małysz", "amalysz@pb.edu.pl", 25.50M, "Kraków", 3));
            osoby.Add(new Osoba("Robert", "Kubica", null, null, null, null));
            regiony.Add("Białystok");
            regiony.Add("Warszawa");
            regiony.Add("Kraków");
            regiony.Add("Poznań");
            regiony.Add("Gdańsk");
            regiony.Add("Brak");
        }
        Collection<Osoba> osoby { get; } = new ObservableCollection<Osoba>();
        List<string> regiony { get; } = new List<string>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = osoby;
            region.ItemsSource = regiony;
        }

        private void Button_Usun(object sender, RoutedEventArgs e)
        {
            if(lista.SelectedItem != null)
            {
                osoby.RemoveAt(lista.SelectedIndex);
            }

        }

        private void Button_Dodaj(object sender, RoutedEventArgs e)
        {
            osoby.Add(new Osoba());
            lista.SelectedIndex = osoby.Count - 1;
        }

        private void Dane_szczegółówe_Click(object sender, RoutedEventArgs e)
        {
            if(Dane_szczegółówe.IsChecked == true)
            {
                Dodatkowe_dane.IsEnabled = true;
            }
            else
            {
                Dodatkowe_dane.IsEnabled = false;
            }
        }
    }
}
