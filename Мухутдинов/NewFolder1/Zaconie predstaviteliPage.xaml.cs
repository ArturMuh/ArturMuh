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
    /// Логика взаимодействия для Zaconie_predstaviteliPage.xaml
    /// </summary>
    public partial class Zaconie_predstaviteliPage : Page
    {
        public object ZaconiepredstaviteliRow { get; private set; }

        public Zaconie_predstaviteliPage()
        {
            InitializeComponent();
            ReloadProducts();
        }

        private void ReloadProducts()
        {
            ZaconiepredstaviteliDataGrid.ItemsSource = (from l in App.DB.Zaconie_predstaviteli
                                                    select l).ToList();
            ZaconiepredstaviteliDataGrid.Items.Refresh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.header.HeaderText.Text = this.Title;
            

        }
        private void ZaconiepredstaviteliTable_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReloadZaconiepredstaviteli()
        {
            throw new NotImplementedException();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Zaconiepredstaviteli ZaconiepredstaviteliRow = ZaconiepredstaviteliDataGrid.SelectedItem as Zaconiepredstaviteli;
            Zaconiepredstaviteli Zaconiepredstaviteli = (from p in App.DB.Zaconie_predstaviteli
                                                         where p.id == ZaconiepredstaviteliRow.id
                                                         select p).Single();

            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить это название?", "подтверждение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                App.DB.Zaconie_predstaviteli.Remove(Zaconiepredstaviteli);
                try
                {
                    App.DB.SaveChanges();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        $"Произошла ошибка во время удаления: {exception.Message} Обычно, эта ошибка связана с тем,что данное образование был использован", "Ошибка удаления", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                ReloadZaconiepredstaviteli();
            }
        }
    }
}
