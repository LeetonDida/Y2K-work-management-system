using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Y2K_WMS
{
    
    public class registerController
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\leeto\source\repos\Y2K_work_management_system\Y2K WMS\Y2Kdb.mdf;Integrated Security=True");
        public bool registerUser(PersonModel person)
        {
            connection.Open();
            string query =string.Format( "insert into Users values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", person.firstName, person.lastName, person.email.ToLower(), person.phone, person.isAdmin, person.password);

            SqlCommand command = new SqlCommand(query, connection);
            MessageBox.Show(query);
            int i = command.ExecuteNonQuery();
            connection.Close();
            if (!(i <1))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        
    }
    
}
