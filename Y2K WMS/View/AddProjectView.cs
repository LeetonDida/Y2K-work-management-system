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
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
        //AttachDbFilename=C:\Users\leeto\source\repos\Y2K_work_management_system\Y2K WMS\Y2Kdb.mdf;Integrated Security=True");

        Model.ProjectModel project = new Model.ProjectModel();
        Model.TaskModel task = new Model.TaskModel();

        Controller.AddProjectController controller = new Controller.AddProjectController();

        List<string> assignedMembers = new List<string>();
        List<int> assignedUserId = new List<int>();

        public AddProjectView()
        {
            InitializeComponent();
            ComboBox selectedMemberCmboBox = cmboBxSelectMember;
            ListBox assignedMembersLstBox = lstBxAssignedMembers;

            controller.loadComboBox(selectedMemberCmboBox, assignedUserId);
            btnCreateProject.Enabled = false;
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
                if (controller.InsertData(task, project, comment))
                {
                    MessageBox.Show("Project created succesfully.");
                    grpBoxAddTasks.Enabled = false;
                    txtProjectTitle.Enabled = false;
                    DashboardView dashboardView = new DashboardView();
                    this.Hide();
                    dashboardView.Show();
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
                bool check = controller.AssignProject(assignedMembers, assignedUserId);
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

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.AddProjectView addProjectView = new View.AddProjectView();
            this.Hide();
            addProjectView.Show();
        }

        private void allocateTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {

            View.AllocateTaskView allocateTaskView = new View.AllocateTaskView();
            this.Hide();
            allocateTaskView.Show();
        }

        private void editProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.EditProjectView editProjectView = new View.EditProjectView();
            this.Hide();
            editProjectView.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.DashboardView dashboardView = new View.DashboardView();
            this.Hide();
            dashboardView.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginView loginView = new LoginView();
            this.Hide();
            loginView.Show();
        }
    }
}
