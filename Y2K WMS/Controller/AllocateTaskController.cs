using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y2K_WMS.Controller
{
    class AllocateTaskController
    {
        private static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\leeto\source\repos\Y2K_work_management_system\Y2K WMS\Y2Kdb.mdf;Integrated Security=True");

        List<int> taskId = new List<int>();
        List<int> memberId = new List<int>();
        int selectedTaskId;

        public void loadComboBox(ComboBox cmboBoxSelectProject)
        {
            string query = "SELECT * FROM Task";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);


            for (int i = 0; i < table.Rows.Count; ++i)
            {
                taskId.Add((int)table.Rows[i]["Id"]);
                string member = Convert.ToString(table.Rows[i]["name"]);
                cmboBoxSelectProject.Items.Add(member);
            }
        }

        internal void getSelectedTask(ComboBox cmboBoxSelectTask)
        {
            string query = string.Format("SELECT * FROM Task WHERE name = '{0}'", cmboBoxSelectTask.SelectedItem.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            selectedTaskId = Convert.ToInt32(table.Rows[0]["Id"]);
        }

        public void loadComboBoxMember(ComboBox cmboBoxSelectMember)
        {
            string query = "SELECT * FROM Developer";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);


            for (int i = 0; i < table.Rows.Count; ++i)
            {
                memberId.Add((int)table.Rows[i]["Id"]);
                string member = Convert.ToString(table.Rows[i]["firstName"]) + " " + Convert.ToString(table.Rows[i]["lastName"]);
                cmboBoxSelectMember.Items.Add(member);
            }
        }

        public bool assignMember()
        {
            int i = 0;
            connection.Open();
            for (int k = 0; k < memberId.Count; ++k)
            {
                //string[] memberName = assignedMembers[i].Split(' ');

                string query = string.Format("UPDATE Developer SET taskId = '{0}' WHERE Id = '{1}'", selectedTaskId, memberId[k]);
                SqlCommand command = new SqlCommand(query, connection);
                i += command.ExecuteNonQuery();//FIX THE EXCEPTION HERE ()
            }
            connection.Close();
            if (!(i < 1))
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
