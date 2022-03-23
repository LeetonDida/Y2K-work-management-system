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

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\leeto\source\repos\Y2K_work_management_system\Y2K WMS\Y2Kdb.mdf;Integrated Security=True");

        Controller.DashboardController dashboardController = new Controller.DashboardController();
        List<int> projectId = new List<int>();
        ComboBox projectCmboBox;
        ListBox assignedMembersLstBox;
        ListBox tasksLstBox;

        public DashboardView()
        {
            InitializeComponent();
            assignedMembersLstBox = lstBxAssignedMembers;
            projectCmboBox = cmboBxSelectProject;

            dashboardController.loadComboBox(projectCmboBox, projectId);

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
            tasksLstBox = lstBoxTasks;
            dashboardController.updateDashBoard(projectCmboBox, lblProjectStatus, assignedMembersLstBox, lstBoxTasks);

        }

        private void editProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.EditProjectView editProjectView = new EditProjectView();
            this.Hide();
            editProjectView.Show();
        }
    }
}
