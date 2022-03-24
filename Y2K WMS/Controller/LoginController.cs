using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Y2K_WMS.Controller
{
    public class loginController
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\leeto\source\repos\Y2K_work_management_system\Y2K WMS\Y2Kdb.mdf;Integrated Security=True");

        public bool isAdmin { get; set; }
        public int userId{ get; set; }
        public bool login(string email, string pass)
        {
            connection.Open();

            string query = string.Format("select * from Users where password = '" + pass+ "' and email ='"+email+"'");
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            userId = Convert.ToInt32(dataTable.Rows[0]["Id"]);
            if (dataTable.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool verifyUser(string email, string pass)
        {
            connection.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = connection;
            com.CommandText = "select isAdmin from Users where password = '" + pass + "' and email ='" + email + "'";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if(Convert.ToBoolean(dr["isAdmin"]) == true)
                {
                    isAdmin = true;
                    return true;
                }
                else
                {
                    isAdmin = false;
                    return false;
                }
            }
            else
            {
                connection.Close();
                return false;
            }

            
        }
    }
}
