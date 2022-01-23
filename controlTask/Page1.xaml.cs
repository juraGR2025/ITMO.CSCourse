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

namespace controlTask
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            
        }

        private void Password_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Connecting_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Login_TextBox.Text.Length > 0) // проверяем введён ли логин     
            {
                if (Password_Box.Password.Length > 0) // проверяем введён ли пароль         
                {     // Сравниваем, введенные логин и пароль с заданными значениями: логин BigBoss, пароль 1111         
                    if (Login_TextBox.Text == "BigBoss" && Password_Box.Password == "1111") // если логин и пароль соответствуют...       
                    {
                        MessageBox.Show("Пользователь авторизовался"); // говорим, что авторизовался
                                                                       // 
                    }
                    else MessageBox.Show("Пользователь не найден"); // выводим ошибку  
                }
                else MessageBox.Show("Введите пароль"); // выводим ошибку    
            }
            else MessageBox.Show("Введите логин"); // выводим ошибку
        }
    }
}
