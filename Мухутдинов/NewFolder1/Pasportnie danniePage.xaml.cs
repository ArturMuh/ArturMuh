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
    /// Логика взаимодействия для Pasportnie_danniePage.xaml
    /// </summary>
    public partial class Pasportnie_danniePage : Page
    {
        public Obrazovanie Pasportniedannie { get; private set; }

        public Pasportnie_danniePage()
        {
            InitializeComponent();
            ReloadProducts();
        }

        private void ReloadProducts()
        {
            PasportniedannieDataGrid.ItemsSource = (from l in App.DB.Pasportnie_dannie
                                                    select l).ToList();
            PasportniedannieDataGrid.Items.Refresh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.header.HeaderText.Text = this.Title;
            ReloadPasportniedannie();

        }

        private void ReloadPasportniedannie()
        {
            PasportniedannieDataGrid.ItemsSource = (from o in App.DB.Pasportnie_dannie select o).ToList();
            PasportniedannieDataGrid.Items.Refresh(); ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pasportnie_dannie Pasportnie_dannieRow = PasportniedannieDataGrid.SelectedItem as Pasportnie_dannie;
            Pasportnie_dannie Pasportnie_dannie = (from p in App.DB.Pasportnie_dannie
                                                   where p.id == Pasportnie_dannieRow.id
                                       select p).Single();

            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить это название?", "подтверждение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                App.DB.Obrazovanie.Remove(Pasportniedannie);
                try
                {
                    App.DB.SaveChanges();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        $"Произошла ошибка во время удаления: {exception.Message} Обычно, эта ошибка связана с тем,что данное образование был использован", "Ошибка удаления", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                ReloadPasportnie_dannie();
            }
        }

        private void ReloadPasportnie_dannie()
        {
            throw new NotImplementedException();
        }

        private void PasportniedannieTable_Click(object sender, RoutedEventArgs e)
        {
            ReloadPasportniedannie();
        }
    }

}
