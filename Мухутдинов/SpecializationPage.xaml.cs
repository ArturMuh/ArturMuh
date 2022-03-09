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

namespace Мухутдинов
{
    /// <summary>
    /// Логика взаимодействия для SpecializationPage.xaml
    /// </summary>
    public partial class SpecializationPage : Page
    {
        public SpecializationPage()
        {
            InitializeComponent();
            ReloadProducts();
        }

        private void ReloadProducts()
        {
            SpecializationDataGrid.ItemsSource = (from l in App.DB.Specilization
                                                select l).ToList();
            SpecializationDataGrid.Items.Refresh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.header.HeaderText.Text = this.Title;
            SpecializationDataGrid.Items.Refresh();
        }

        private void SpecializationTable_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
