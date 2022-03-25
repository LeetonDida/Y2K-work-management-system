using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y2K_WMS.View
{
    public partial class AllocateTaskView : Form
    {
        Controller.AllocateTaskController controller = new Controller.AllocateTaskController();
        List<string> assignedMembers = new List<string>();

        public AllocateTaskView()
        {
            InitializeComponent();
            controller.loadComboBox(cmboBoxSelectTask);
            controller.loadComboBoxMember(cmboBoxSelectedMember);
            btnAssign.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.getSelectedTask(cmboBoxSelectTask);
        }

        private void cmboBoxSelectedMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (!assignedMembers.Contains(cmboBoxSelectedMember.SelectedItem))
            {
                assignedMembers.Add(cmboBoxSelectedMember.SelectedItem.ToString());
                LstBoxSelectedMembers.Items.Add(cmboBoxSelectedMember.SelectedItem.ToString());
                btnAssign.Enabled = true;
            }
                
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (controller.assignMember())
            {
                MessageBox.Show("Task assigned!", "Success");
                LstBoxSelectedMembers.Items.Clear();
                assignedMembers.Clear();
                btnAssign.Enabled = false;

            }
            else
            {
                MessageBox.Show("Task failed to assign!", "Error");
            }
        }

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.AddProjectView addProjectView = new View.AddProjectView();
            this.Hide();
            addProjectView.Show();
        }

        private void editProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.EditProjectView editProjectView = new View.EditProjectView();
            this.Hide();
            editProjectView.Show();
        }

        private void allocateTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {

            View.AllocateTaskView allocateTaskView = new View.AllocateTaskView();
            this.Hide();
            allocateTaskView.Show();
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

        private void AllocateTaskView_Load(object sender, EventArgs e)
        {

        }
    }
}
