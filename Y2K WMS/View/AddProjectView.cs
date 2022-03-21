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
    public partial class AddProjectView : Form
    {
        Model.ProjectModel project = new Model.ProjectModel();
        Model.TaskModel task = new Model.TaskModel();

        public AddProjectView()
        {
            InitializeComponent();
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            if(txtProjectTitle.Text == ""||txtTaskName.Text == "")
            {
                MessageBox.Show("Please enter all the required fields.");
            }
            else if(lstBxAssignedMembers.Items.Count == 0)
            {
                MessageBox.Show("Please assign at least one member to the project.", "Insuffisient details");
            }
            else
            {  
                //adding values to task task model
                project.projectName = txtProjectTitle.Text.Trim();
                project.completionStatus = 0;
                
                //write code to pass to controller
              

            }
        }

        private void bindProjectModel()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTaskName.Text == ""||txtSubTasks.Text == ""|| txtComments.Text == "")
            {
                MessageBox.Show("Please enter all the required fields.");
            }
            else
            {
                //adding values to task model
                task.comment = txtComments.Text.Trim();
                task.name = txtTaskName.Text.Trim();
                task.subTask = txtSubTasks.Text.Trim();

                //code to pass task to controller
            }
            
        }

        private void btnAssignMember_Click(object sender, EventArgs e)
        {
            if (lstBxAssignedMembers.Items.Count == 0)
            {
                MessageBox.Show("Please assign at least one member to the project.", "Insuffisient details");
            }
            else
            {
                //write code to pass to controller
            }
        }
    }
}
