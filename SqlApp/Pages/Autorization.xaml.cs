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

namespace SqlApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Page
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Login = TextLogin.Text.Trim();
            string Password = TextPassword.Text.Trim();
            if (4>Login.Length&&Login.Length<16)
            {
                MessageBox.Show("Ошибка!Поле должно принимать от 6 до 15 символов латинского" +
                    " алфавита в нижнем и верхнем регистре.");

            }
            else if (4 > Password.Length && Password.Length < 16)
            {
                MessageBox.Show("Ошибка!Поле должно принимать от 6 до 30 символов латинского алфавита в нижнем и верхнем регистре, а также специальные символы ( ! ' # $ % & ' ( ) * + , - . / : ; < = > ? @ [ ] ^ _` { | } ~)'");

            }
            else
            {
                if (TextLogin.Text == "ADMIN" && TextPassword.Text == "ADMIN")
                {
                    NavigationService.Navigate(new ClientPage());
                    MessageBox.Show("Вы успешно зашли");
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }
    }
}
