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
    /// Логика взаимодействия для ZaivleniePage.xaml
    /// </summary>
    public partial class ZaivleniePage : Page
    {
        public ZaivleniePage()
        {
            InitializeComponent();
            ReloadProducts();
        }

        private void ReloadProducts()
        {
            ZaivlenieDataGrid.ItemsSource = (from l in App.DB.Zaivlenie
                                                    select l).ToList();
            ZaivlenieDataGrid.Items.Refresh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.header.HeaderText.Text = this.Title;
            ReloadZaivlenie();
        }

        private void ReloadZaivlenie()
        {
            ZaivlenieDataGrid.ItemsSource = (from o in App.DB.Zaivlenie select o).ToList();
            ZaivlenieDataGrid.Items.Refresh();
        }

        private void ZaivlenieTable_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
