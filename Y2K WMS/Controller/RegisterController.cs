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

            if(person.isAdmin == "true")
            {
                insertIntoAdmin(person);
            }
            else
            {
                insertIntoDeveloper(person);
            }

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

        private void insertIntoDeveloper(PersonModel person)
        {
           
            string query = string.Format("insert into Developer (firstName, lastName, email, phone, password) values ('{0}', '{1}', '{2}', '{3}', '{4}')", person.firstName, person.lastName, person.email.ToLower(), person.phone, person.password);

            SqlCommand command = new SqlCommand(query, connection);
            MessageBox.Show(query);
            int i = command.ExecuteNonQuery();
            
            if (!(i < 1))
            {
                MessageBox.Show("succesfully inserted into developer table");//delete this
            }
            else
            {
                MessageBox.Show("failed to insert into developer table");//delete this
            }
           
        }

        private void insertIntoAdmin(PersonModel person)
        {
            
            string query = string.Format("insert into Admin (firstName, lastName, email, phone, password) values ('{0}', '{1}', '{2}', '{3}', '{4}')", person.firstName, person.lastName, person.email.ToLower(), person.phone, person.password);

            SqlCommand command = new SqlCommand(query, connection);
            MessageBox.Show(query);
            int i = command.ExecuteNonQuery();
            
            if (!(i < 1))
            {
                MessageBox.Show("succesfully inserted into developer table");//delete this
            }
            else
            {
                MessageBox.Show("failed to insert into admin table");//delete this
            }
        }
    }
    
}
