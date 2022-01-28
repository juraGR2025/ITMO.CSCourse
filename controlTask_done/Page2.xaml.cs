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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void RichTextBox_Page_2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Btn_1_Page2_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog = AdventureWorks2017;Data Source=."))//Создание объекта для соединения.                                                                  
            { //Вносим в него Connection string... 
                cn.Open();//Открываем соединение с базой данных...
                using (SqlCommand cmd = new SqlCommand("SELECT TOP (20) ProductModelID, IllustrationID, ModifiedDate FROM AdventureWorks2017.Production.ProductModelIllustration", cn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // MessageBox.Show(reader[0] + " " + reader[1]);
                            ListBox_Page_2.Items.Add(reader[0] + " \t-- " + reader[1] + " \t-- " + reader[2]);
                        }
                    }
                }
            }
        }

        private void ListBox_Page_2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Btn_2_Page_2_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection cn_2 = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog = AdventureWorks2017;Data Source=."))//Создание объекта для соединения.                                                                  
            { //Вносим в него Connection string... 
                cn_2.Open();//Открываем соединение с базой данных...
                using (SqlCommand cmd_2 = new SqlCommand("SELECT TOP (20) DepartmentID, Name, GroupName, ModifiedDate FROM AdventureWorks2017.HumanResources.Department", cn_2))
                {
                    using (SqlDataReader reader = cmd_2.ExecuteReader())
                    {
                        ListBox_Page_2.Items.Clear();//Очищаем ListBox перед заполнением новыми данными...
                        while (reader.Read())
                        {
                            ListBox_Page_2.Items.Add(reader[0] + " \t-- " + reader[1] + " \t-- " + reader[2] + " \t-- " + reader[3]);
                        }
                    }
                }
            }
        }
    }
}
