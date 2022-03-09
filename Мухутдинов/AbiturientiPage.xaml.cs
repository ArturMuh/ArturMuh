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
    /// Логика взаимодействия для AbiturientiPage.xaml
    /// </summary>
    public partial class AbiturientiPage : Page
    {
        public AbiturientiPage()
        {
            InitializeComponent();
            ReloadProducts();
        }

        private void ReloadProducts()
        {
            AbiturientinDataGrid.ItemsSource = (from l in App.DB.Abiturenti
                                             select l).ToList();
            AbiturientinDataGrid.Items.Refresh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.header.HeaderText.Text = this.Title;
            ReloadAbiturienti();
        }

        private void ReloadAbiturienti()
        {
            AbiturientinDataGrid.ItemsSource = (from o in App.DB.Abiturenti select o).ToList();
            AbiturientinDataGrid.Items.Refresh(); 
        }

        private void AbiturientiTable_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
