using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class DBconnect : Form
    {
        public DBconnect()
        {
            InitializeComponent();
        }

        private void DBconnect_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AdventureWorks2017;Data Source=."))//Создание объекта для соединения.                                                                  
            { //Вносим в него Connection string...
                cn.Open();//Открываем соединение с базой данных...
                using (SqlCommand cmd = new SqlCommand("SELECT DepartmentID, GroupName FROM AdventureWorks2017.HumanResources.Department", cn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           // MessageBox.Show(reader[0] + " " + reader[1]);
                            lbResultData.Items.Add(reader[0] + " " + reader[1]);
                        }
                    }
                }
            }
          
        }
    }
}
