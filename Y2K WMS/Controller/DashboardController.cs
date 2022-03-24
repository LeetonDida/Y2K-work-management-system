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
    class DashboardController
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\leeto\source\repos\Y2K_work_management_system\Y2K WMS\Y2Kdb.mdf;Integrated Security=True");

        public void loadComboBox(ComboBox projectCmboBox, List<int> projectId)
        {
            string query = "SELECT * FROM Project";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);


            for (int i = 0; i < table.Rows.Count; ++i)
            {
                projectId.Add((int)table.Rows[i]["Id"]);
                string member = Convert.ToString(table.Rows[i]["projectName"]);
                projectCmboBox.Items.Add(member);
            }
        }

        internal void updateDashBoard(ComboBox projectCmboBox, Label lblCompletionStatus, ListBox assignedMembers, ListBox tasks)
        {
            string query = string.Format("SELECT Id, completionStatus FROM Project WHERE projectName = '{0}'", projectCmboBox.SelectedItem.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            //DataSet dataSet = new DataSet();
            adapter.Fill(table);

            string selectedProjectId = Convert.ToString(table.Rows[0]["Id"]);
            string completionStatus = Convert.ToString(table.Rows[0]["completionStatus"]);

            //updates the completion status label
            lblCompletionStatus.Text = completionStatus;

            updateMembersListBox(selectedProjectId, assignedMembers);
            updateTaskListBox(tasks, selectedProjectId);

        }

        private void updateTaskListBox(ListBox tasksListBox, string selectedProjectId)
        {
            tasksListBox.Items.Clear();
            string query = string.Format("SELECT * from Task where projectId = '{0}'", selectedProjectId);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; ++i)
            {
                string task = Convert.ToString(table.Rows[i]["name"]);
                tasksListBox.Items.Add(task);
            }
        }

        internal void updateMembersListBox(string projectId, ListBox assignedMembers)
        {
            assignedMembers.Items.Clear();
            string query = string.Format("SELECT * from Developer where projectId = '{0}'", projectId);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; ++i)
            {
                string member = Convert.ToString(table.Rows[i]["firstName"]) + " " + Convert.ToString(table.Rows[i]["lastName"]);
                assignedMembers.Items.Add(member);
            }
        }
    }
}
