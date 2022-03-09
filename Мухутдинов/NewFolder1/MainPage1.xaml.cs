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

namespace Мухутдинов.NewFolder1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class MainPage1 : Page
    {
        public SpecializationPage specilization;
        public AbiturientiPage Abiturenti;
        public Lgotnie_documentiPage lgotnie_Documenti;
        public ObrazovaniePage obrazovanie;
        public Pasportnie_danniePage pasportnie;
        public Zaconie_predstaviteliPage zaconie_predstaviteli;
        public ZaivleniePage zaivlenie;
        public MainPage1()
        {
            InitializeComponent();
            specilization = new SpecializationPage();
            Abiturenti = new AbiturientiPage();
            lgotnie_Documenti = new Lgotnie_documentiPage();
            obrazovanie = new ObrazovaniePage();
            pasportnie = new Pasportnie_danniePage();
            zaconie_predstaviteli = new Zaconie_predstaviteliPage();
            zaivlenie = new ZaivleniePage();
            SotrudnikiNameblock.Text = App.currentUser.FIO;


    }

        private void ZaivlenieMenuEntry_Click(object sender, RoutedEventArgs e)
        {
            App.mainWindow.MainFrame.Navigate(zaivlenie);
        }

        private void Lgotnie_documentiMenuEntry_Click(object sender, RoutedEventArgs e)
        {
            App.mainWindow.MainFrame.Navigate(lgotnie_Documenti);

        }

        private void Zaconie_predstaviteliMenuEntry_Click(object sender, RoutedEventArgs e)
        {
            App.mainWindow.MainFrame.Navigate(zaconie_predstaviteli);
        }

        private void Pasportnie_dannieMenuEntry_Click(object sender, RoutedEventArgs e)
        {
            App.mainWindow.MainFrame.Navigate(pasportnie);
        }

        private void ObrazovanieMenuEntry_Click(object sender, RoutedEventArgs e)
        {
            App.mainWindow.MainFrame.Navigate(obrazovanie);
        }

        private void AbiturentiMenuEntry_Click(object sender, RoutedEventArgs e)
        {
            App.mainWindow.MainFrame.Navigate(Abiturenti);
        }

        private void SpecilizationMenuEntry_Click(object sender, RoutedEventArgs e)
        {
            App.mainWindow.MainFrame.Navigate(specilization);
        }
    }
}
