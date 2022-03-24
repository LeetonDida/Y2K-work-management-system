using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y2K_WMS.Model;

namespace Y2K_WMS.Controller
{
    class EditProjectController
    {
        private static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\leeto\source\repos\Y2K_work_management_system\Y2K WMS\Y2Kdb.mdf;Integrated Security=True");

        string selectedProjectId;
        internal static void loadComboBox(ComboBox cmboBoxSelectProject, List<int> projectId)
        {
            string query = "SELECT * FROM Project";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);


            for (int i = 0; i < table.Rows.Count; ++i)
            {
                projectId.Add((int)table.Rows[i]["Id"]);
                string member = Convert.ToString(table.Rows[i]["projectName"]);
                cmboBoxSelectProject.Items.Add(member);
            }

        }

        internal void updateFields(TextBox txtCompletionStatus, ComboBox cmboBoxSelectProject, TextBox taskTxtBox)
        {
            string query = string.Format("SELECT Id, completionStatus FROM Project WHERE projectName = '{0}'", cmboBoxSelectProject.SelectedItem.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            //DataSet dataSet = new DataSet();
            adapter.Fill(table);

            selectedProjectId = Convert.ToString(table.Rows[0]["Id"]);
            string completionStatus = Convert.ToString(table.Rows[0]["completionStatus"]);

            //updates the completion status label
            txtCompletionStatus.Text = completionStatus;

            updateTaskField(selectedProjectId, taskTxtBox);
        }

        private void updateTaskField(string selectedProjectId, TextBox taskTxtBox)
        {
            taskTxtBox.Clear();
            string query = string.Format("SELECT * from Task where projectId = '{0}'", selectedProjectId);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; ++i)
            {
                string task = Convert.ToString(table.Rows[i]["name"]);
                taskTxtBox.Text = task;
            }
        }

        internal bool updateProject(Model.ProjectModel project)
        {
            int i = 0;
            connection.Open();
            string query = string.Format("UPDATE Project SET completionStatus = '{0}' WHERE Id = {1}", project.completionStatus, selectedProjectId);
            SqlCommand command = new SqlCommand(query, connection);
            i += command.ExecuteNonQuery();
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

        internal bool updateTask(TaskModel taskModel)
        {
            int i = 0;
            connection.Open();
            string query = string.Format("UPDATE Task SET name = '{0}', subTask = '{1}', comment = '{2}' WHERE projectID = {3}", taskModel.name, taskModel.subTask, taskModel.comment, selectedProjectId);
            SqlCommand command = new SqlCommand(query, connection);
            i += command.ExecuteNonQuery();
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

        internal bool deleteProject()
        {
            int i = 0;
            connection.Open();
            string query = string.Format("DELETE FROM Project where Id = '{0}'", selectedProjectId);
            SqlCommand command = new SqlCommand(query, connection);
            i += command.ExecuteNonQuery();
            connection.Close();
            if (!(i < 1) && deleteTask())
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        private bool deleteTask()
        {
            int i = 0;
            connection.Open();
            string query = string.Format("DELETE FROM Task where projectID = '{0}'", selectedProjectId);
            SqlCommand command = new SqlCommand(query, connection);
            i += command.ExecuteNonQuery();
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
