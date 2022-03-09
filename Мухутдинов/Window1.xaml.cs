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
using System.Windows.Shapes;

namespace Мухутдинов
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginField.Text))
            {
                MessageBox.Show("Поле логин не должно быть пустым!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(PasswordField.Password))
            {
                MessageBox.Show("Поле логин не должно быть пустым!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                App.currentUser = (from user in App.DB.Sotrudniki where user.Login == LoginField.Text && user.Password == PasswordField.Password select user).First();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Не найдено пользователя с такими логином и паролем!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            App.mainWindow = new MainWindow();
            App.mainWindow.Show();
            Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoginField_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }

        private void chkbxShowPass_Unchecked(object sender, RoutedEventArgs e)
        {
           

        }

        private void ChkbxShowPass_Unchecked_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void ChkbxShowPass_Checked(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
