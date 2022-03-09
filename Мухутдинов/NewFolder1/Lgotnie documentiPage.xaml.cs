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
    /// Логика взаимодействия для Lgotnie_documentiPage.xaml
    /// </summary>
    public partial class Lgotnie_documentiPage : Page
    {
        public Lgotnie_documentiPage()
        {
            InitializeComponent();
            ReloadProducts();
        }

        private void ReloadProducts()
        {
            LgotniedocumentiDataGrid.ItemsSource = (from l in App.DB.Lgotnie_documenti
                                                    select l).ToList();
            LgotniedocumentiDataGrid.Items.Refresh();


        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.header.HeaderText.Text = this.Title;
            LgotniedocumentiDataGrid.Items.Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Lgotniedocumenti_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
