using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y2K_WMS.View
{
    public partial class AddProjectView : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\leeto\source\repos\Y2K_work_management_system\Y2K WMS\Y2Kdb.mdf;Integrated Security=True");

        Model.ProjectModel project = new Model.ProjectModel();
        Model.TaskModel task = new Model.TaskModel();

        Controller.AddProjectController projectController = new Controller.AddProjectController();

        List<string> assignedMembers = new List<string>();
        List<int> assignedUserId = new List<int>();

        public AddProjectView()
        {
            InitializeComponent();
            loadComboBox();
            btnCreateProject.Enabled = false;

            ComboBox selectedMemberCmboBox = cmboBxSelectMember;
            ListBox assignedMembersLstBox = lstBxAssignedMembers;
            //if (!(string.IsNullOrEmpty(assignedMembersLstBox.Text) && string.IsNullOrEmpty(cmboBxSelectMember.Text)))
            //{
            //    btnCreateProject.Enabled = true;
            //}


        }


        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            string comment = "";

            if (txtProjectTitle.Text == "" || txtTaskName.Text == "" || txtSubTasks.Text == "")
            {
                MessageBox.Show("Please enter all the required fields.");
            }
            else if (lstBxAssignedMembers.Items.Count == 0)
            {
                MessageBox.Show("Please assign at least one member to the project.", "Insuffisient details");
            }
            else
            {
                //adding values to project model and pass project to controller
                project.projectName = txtProjectTitle.Text.Trim();


                //adding values to task model and pass task to controller
                if (txtComments.Text == "")
                {
                    task.name = txtTaskName.Text.Trim();
                    task.subTask = txtSubTasks.Text.Trim();//no comment
                }
                else
                {
                    comment = txtComments.Text.Trim();
                    task.name = txtTaskName.Text.Trim();
                    task.subTask = txtSubTasks.Text.Trim();//with comment
                }

                //checking if insertion succeded
                if (projectController.InsertData(task, project, comment))
                {
                    MessageBox.Show("Project created succesfully.");
                    grpBoxAddTasks.Enabled = false;
                    txtProjectTitle.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Could not create project. Please make sure that all fields are filled in correctly.", "Error");
                }

                assignProject();
            }
        }



        private void btnAssignMember_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmboBxSelectMember.Text))
            {
                MessageBox.Show("Please assign at least one member to the project.", "Insufficient details");
            }
            else
            {
                if (!assignedMembers.Contains(cmboBxSelectMember.SelectedItem))
                {
                    assignedMembers.Add(cmboBxSelectMember.SelectedItem.ToString());
                    lstBxAssignedMembers.Items.Add(cmboBxSelectMember.SelectedItem.ToString());
                    btnCreateProject.Enabled = true;
                }
                else
                {
                    MessageBox.Show("The member selected has already been assigned to the project", "Member already exist");
                }

            }
        }

        private void loadComboBox()
        {
            string query = "SELECT Id, firstName, lastName FROM Users where isAdmin = 'false'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);


            for (int i = 0; i < table.Rows.Count; ++i)
            {
                assignedUserId.Add((int)table.Rows[i]["Id"]);
                string member = Convert.ToString(table.Rows[i]["firstName"]) + " " + Convert.ToString(table.Rows[i]["lastName"]);
                cmboBxSelectMember.Items.Add(member);
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void assignProject()
        {
            if (lstBxAssignedMembers.Items.Count == 0 || cmboBxSelectMember.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please assign at least one member to the project.", "Insuffisient details");
            }

            else
            {
                bool check = projectController.AssignProject(assignedMembers, assignedUserId);
                if (check)
                {
                    MessageBox.Show("Members assigned successfully", "Success");
                    //go to next form
                    View.DashboardView dash = new DashboardView();
                    this.Hide();
                    dash.Show();
                }
                else
                {
                    MessageBox.Show("Failed to assign members!", "Error");
                }
            }
        }

    }
}
