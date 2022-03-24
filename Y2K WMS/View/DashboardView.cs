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
    public partial class DashboardView : Form
    {
        AddProjectView addProject = new AddProjectView();

        Controller.DashboardController dashboardController = new Controller.DashboardController();
        List<int> projectId = new List<int>();
        ComboBox projectCmboBox;
        ListBox assignedMembersLstBox;
        Controller.loginController loginController = new Controller.loginController();
        bool isAdmin;
        public DashboardView()
        {
            InitializeComponent();
            assignedMembersLstBox = lstBxAssignedMembers;
            projectCmboBox = cmboBxSelectProject;
            dashboardController.loadComboBox(projectCmboBox, projectId);
            isAdmin = loginController.isAdmin;

            //sandboxing the user interface
            if (!isAdmin)
            {
                addProjectToolStripMenuItem.Visible = false;
                allocateTasksToolStripMenuItem.Visible = false;
            }
        }

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            addProject.Show();
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {

        }

        private void cmboBxSelectProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label lblCompletionStatus = lblProjectStatus;
            dashboardController.updateDashBoard(projectCmboBox, lblProjectStatus, assignedMembersLstBox, lstBoxTasks, lstBxSubtask);

        }

        private void editProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.EditProjectView editProjectView = new EditProjectView();
            this.Hide();
            editProjectView.Show();
        }

        private void addProjectToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void editProjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void editProjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            View.EditProjectView editProjectView = new View.EditProjectView();
            this.Hide();
            editProjectView.Show();
        }

        private void lstBxSubtask_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.DashboardView dashboardView = new View.DashboardView();
            this.Hide();
            dashboardView.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginView loginView = new LoginView();
            this.Hide();
            loginView.Show();
        }
    }
}
