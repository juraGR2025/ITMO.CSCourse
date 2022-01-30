using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace controlTask_done
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }
        int ProductModelIllustration_MAX = 0;//Переменная для определения максимального количества записей в таблице Production.ProductModelIllustration.
        private void Button_1_Page_3_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection cn_3 = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog = AdventureWorks2017;Data Source=."))//Создание объекта для соединения.                                                                  
            { //Вносим в него Connection string... 
                cn_3.Open();//Открываем соединение с базой данных...
                using (SqlCommand cmd_3 = new SqlCommand("SELECT count(*) FROM AdventureWorks2017.Production.ProductModelIllustration", cn_3))
                {
                    ProductModelIllustration_MAX = (int)cmd_3.ExecuteScalar();
                    ListBox_Edit.Items.Add("Общее количество записей в таблице Production.ProductModelIllustration: ");
                    ListBox_Edit.Items.Add(cmd_3.ExecuteScalar());

                }
                using (SqlCommand cmd_4 = new SqlCommand("SELECT TOP (200) ProductModelID, IllustrationID, ModifiedDate FROM AdventureWorks2017.Production.ProductModelIllustration", cn_3))
                {
                    using (SqlDataReader reader = cmd_4.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            int tbPars = int.Parse(TextBox_Page_3.Text);

                            if (tbPars == int.Parse(reader[0].ToString()))
                            {
                                string SqlStr = "DELETE FROM AdventureWorks2017.Production.ProductModelIllustration WHERE ProductModelID = " + tbPars;
                                using (SqlCommand cmd_5 = new SqlCommand(SqlStr, cn_3))//Команда, которая удаляет из таблицы Production.ProductModelIllustration данные в соответствии с выбранным ID
                                {
                                    reader.Close();//Закрываем DataReader.
                                    ListBox_Edit.Items.Add(cmd_5.ExecuteNonQuery());
                                }
                                break;
                            }
                            else reader.Read();//reader снова читает.
                            if (tbPars == 0) MessageBox.Show("Модель не найдена"); // выводим ошибку  
                        }
                    }
                }
            }
        }

        private void Button_2_Page_3_Click(object sender, RoutedEventArgs e)
        {
            try//Ловим ошибки ввода
            {
                Convert.ToInt32(TextBox_3_Page_3.Text);
                Convert.ToInt32(TextBox_4_Page_3.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите в поле ProductModelID целое число!");
                MessageBox.Show("Введите в поле IllustrationID целое число в диапазоне от 3 до 7!");
                TextBox_3_Page_3.Clear();
                TextBox_4_Page_3.Clear();
                return;
            }
            //Создаем переменные для записи в таблицу Production.ProductModelIllustration
            int ProductModelID = int.Parse(TextBox_3_Page_3.Text);
            int IllustrationID = int.Parse(TextBox_4_Page_3.Text);
            DateTime ModifiedDate = new DateTime();
            ListBox_Edit.Items.Add(ModifiedDate);
            if (IllustrationID < 3 || IllustrationID > 7)
            {
                MessageBox.Show("Значение IllustrationID должно быть целым числом в диапазоне от 3 до 7"); // выводим ошибку  
                return;
            }

            using (SqlConnection cn_3 = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog = AdventureWorks2017;Data Source=."))//Создание объекта для соединения.
            {
                cn_3.Open();
                string SqlStr_1 = "INSERT INTO AdventureWorks2017.Production.ProductModelIllustration(ProductModelID, IllustrationID, ModifiedDate) VALUES(" + ProductModelID +", " + IllustrationID + ", " + "GETDATE())";//Формируем строку для записи.
                using (SqlCommand cmd_3 = new SqlCommand(SqlStr_1, cn_3))
                {
                    cmd_3.ExecuteNonQuery();
                }
            }
        }

        
    }
    }


