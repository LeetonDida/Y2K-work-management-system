using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y2K_WMS.Controller
{
    class AddProjectController
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\leeto\source\repos\Y2K_work_management_system\Y2K WMS\Y2Kdb.mdf;Integrated Security=True");

        int insertedProjectId;

        public bool InsertData(Model.TaskModel task, Model.ProjectModel projectModel, string comment)
        {
            bool check = false;
            if (AddProject(projectModel))
            {
                //operator overloading
                if (comment == "")
                {
                    if (AddTask(task, projectModel))
                    {
                        
                        check = true;
                    }
                }
                else
                {
                    if(AddTask(task, comment))
                    {
                        check = true;
                    }
                }
                
            }
            else
            {
                check = false;
            }

            return check;
        }

        private bool AddTask(Model.TaskModel task, string comment)
        {
            connection.Open();
            string query = string.Format("insert into Task values ('{0}', '{1}', '{2}')", task.name, task.subTask, comment);

            SqlCommand command = new SqlCommand(query, connection);
            int i = command.ExecuteNonQuery();
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

        //function overloading to add a optional comment feature
        private bool AddTask(Model.TaskModel task, Model.ProjectModel projectModel)
        {
            MessageBox.Show(projectModel.Id.ToString());
            connection.Open();
            string query = string.Format("insert into Task (name, subTask, projectID) values ('{0}', '{1}', '{2}')", task.name, task.subTask, insertedProjectId);
            SqlCommand command = new SqlCommand(query, connection);
            int i = command.ExecuteNonQuery(); //insert projectid
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

    private bool AddProject(Model.ProjectModel projectModel)
    {
        connection.Open();
        string query = string.Format("insert into Project (projectName) values ('{0}'); SELECT SCOPE_IDENTITY()", projectModel.projectName);

        SqlCommand command = new SqlCommand(query, connection);
        string result = Convert.ToString(command.ExecuteScalar());
       // MessageBox.Show("ID of projec is: " + insertedProjectId);
       // int i = command.ExecuteNonQuery();
        connection.Close();
        if (!(result == null))
        {
                insertedProjectId = Convert.ToInt32(result);
                return true;
        }
        else
        {
            return false;
        }
    }
}
}
