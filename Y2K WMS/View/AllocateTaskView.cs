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
    }
}
