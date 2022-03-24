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
    public partial class EditProjectView : Form
    {
        Controller.EditProjectController editProjectController = new Controller.EditProjectController();
        List<int> projectId = new List<int>();
        Model.ProjectModel projectModel = new Model.ProjectModel();
        Model.TaskModel taskModel = new Model.TaskModel();
        List<string> subtasksList = new List<string>();
        List<string> commentsList = new List<string>();

        public EditProjectView()
        {
            InitializeComponent();
            taskGrpBox.Enabled = false;
            Controller.EditProjectController.loadComboBox(cmboBoxSelectProject, projectId);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboBoxSelectProject.SelectedIndex == -1)
            {
                taskGrpBox.Enabled = false;
            }
            else
            {
                taskGrpBox.Enabled = true;
            }
            editProjectController.updateFields(txtCompletionStatus, cmboBoxSelectProject, txtTaskName);
            subtasksList.Clear();
            commentsList.Clear();
            txtComment.Clear();
            txtSubTask.Clear();
        }

        private void chkBoxCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBoxCompleted.Checked == true)
            {
                taskGrpBox.Enabled = false;
                txtCompletionStatus.Enabled = false;
                lblCompletionStatus.Enabled = false;
                lblSelectProject.Enabled = false;
                cmboBoxSelectProject.Enabled = false;
            }
            else
            {
                taskGrpBox.Enabled = true;
                txtCompletionStatus.Enabled = true;
                lblCompletionStatus.Enabled = true;
                lblSelectProject.Enabled = true;
                cmboBoxSelectProject.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!(txtComment.Text == "" || txtSubTask.Text == ""))
            {
                if (!subtasksList.Contains(txtSubTask.Text))
                {
                    subtasksList.Add(txtSubTask.Text.Trim());
                    MessageBox.Show("Subtask added", "Success");
                }
                else
                {
                    MessageBox.Show("Sub task already added!", "Error");
                }

                if (!commentsList.Contains(txtComment.Text))
                {
                    commentsList.Add(txtComment.Text.Trim());
                    MessageBox.Show("Comment added", "Success");
                }
                else
                {
                    MessageBox.Show("Comment already added!", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please all the feilds!", "Error");
            }
            

            txtComment.Clear();
            txtSubTask.Clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if(chkBoxCompleted.Checked == true)
            {
                //delete the project
                if (editProjectController.deleteProject())
                {
                    MessageBox.Show("Project deleted successfully", "Success");
                }
            }
            else
            {
                if (!(cmboBoxSelectProject.SelectedIndex == -1 || subtasksList.Count == 0 && commentsList.Count == 0))
                {
                    string subtasks = string.Join(",", subtasksList);
                    string comments = string.Join(",", commentsList);

                    taskModel.name = txtTaskName.Text.Trim();
                    taskModel.comment = comments;
                    taskModel.subTask = subtasks;
                    projectModel.completionStatus = int.Parse(txtCompletionStatus.Text.Trim());

                    bool check = editProjectController.updateProject(projectModel);
                    bool check2 = editProjectController.updateTask(taskModel);

                    if (check && check2)
                    {
                        MessageBox.Show("Project updated", "Success!");
                        //go to new form
                    }
                    else
                    {
                        MessageBox.Show("Failed to save data. Check your details and try again", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a project and enter all the required fields.", "Error");
                }

            }
        }

        private void allocateTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.AllocateTaskView allocateTaskView = new AllocateTaskView();
            this.Hide();
            allocateTaskView.Show();
        }
    }
}
