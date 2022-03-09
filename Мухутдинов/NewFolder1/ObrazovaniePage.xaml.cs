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
    /// Логика взаимодействия для ObrazovaniePage.xaml
    /// </summary>
    public partial class ObrazovaniePage : Page
    {
        public ObrazovaniePage()
        {
            InitializeComponent();
            ReloadObrazovanie();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.header.HeaderText.Text = this.Title;
            ReloadObrazovanie();

        }

        public void ReloadObrazovanie()
        {
            ObrazovanieDataGrid.ItemsSource = (from o in App.DB.Obrazovanie select o).ToList();
            ObrazovanieDataGrid.Items.Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Obrazovanie obrazovanieRow = ObrazovanieDataGrid.SelectedItem as Obrazovanie;
            Obrazovanie Obrazovanie = (from p in App.DB.Obrazovanie
                                       where p.id == obrazovanieRow.id
                                       select p).Single();

            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить это название?", "подтверждение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                App.DB.Obrazovanie.Remove(Obrazovanie);
                try
                {
                    App.DB.SaveChanges();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        $"Произошла ошибка во время удаления: {exception.Message} Обычно, эта ошибка связана с тем,что данное образование был использован", "Ошибка удаления", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                ReloadObrazovanie();
            }
        }

        private void ObrazovanieTable_Click(object sender, RoutedEventArgs e)
        {
            ReloadObrazovanie();
        }

        
    }
    
}
