
namespace Y2K_WMS.View
{
    partial class AllocateTaskView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmboBoxSelectTask = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboBoxSelectedMember = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.LstBoxSelectedMembers = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allocateTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmboBoxSelectTask
            // 
            this.cmboBoxSelectTask.FormattingEnabled = true;
            this.cmboBoxSelectTask.Location = new System.Drawing.Point(421, 63);
            this.cmboBoxSelectTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboBoxSelectTask.Name = "cmboBoxSelectTask";
            this.cmboBoxSelectTask.Size = new System.Drawing.Size(250, 28);
            this.cmboBoxSelectTask.TabIndex = 0;
            this.cmboBoxSelectTask.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select task";
            // 
            // cmboBoxSelectedMember
            // 
            this.cmboBoxSelectedMember.FormattingEnabled = true;
            this.cmboBoxSelectedMember.Location = new System.Drawing.Point(421, 153);
            this.cmboBoxSelectedMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboBoxSelectedMember.Name = "cmboBoxSelectedMember";
            this.cmboBoxSelectedMember.Size = new System.Drawing.Size(250, 28);
            this.cmboBoxSelectedMember.TabIndex = 0;
            this.cmboBoxSelectedMember.SelectedIndexChanged += new System.EventHandler(this.cmboBoxSelectedMember_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select member";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(546, 364);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(125, 31);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // LstBoxSelectedMembers
            // 
            this.LstBoxSelectedMembers.FormattingEnabled = true;
            this.LstBoxSelectedMembers.ItemHeight = 20;
            this.LstBoxSelectedMembers.Location = new System.Drawing.Point(421, 217);
            this.LstBoxSelectedMembers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LstBoxSelectedMembers.Name = "LstBoxSelectedMembers";
            this.LstBoxSelectedMembers.Size = new System.Drawing.Size(250, 124);
            this.LstBoxSelectedMembers.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.editToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.logoutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "Home";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProjectToolStripMenuItem,
            this.editProjectToolStripMenuItem,
            this.allocateTasksToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addProjectToolStripMenuItem
            // 
            this.addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            this.addProjectToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.addProjectToolStripMenuItem.Text = "Add project";
            this.addProjectToolStripMenuItem.Click += new System.EventHandler(this.addProjectToolStripMenuItem_Click);
            // 
            // editProjectToolStripMenuItem
            // 
            this.editProjectToolStripMenuItem.Name = "editProjectToolStripMenuItem";
            this.editProjectToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.editProjectToolStripMenuItem.Text = "Edit project";
            this.editProjectToolStripMenuItem.Click += new System.EventHandler(this.editProjectToolStripMenuItem_Click);
            // 
            // allocateTasksToolStripMenuItem
            // 
            this.allocateTasksToolStripMenuItem.Name = "allocateTasksToolStripMenuItem";
            this.allocateTasksToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.allocateTasksToolStripMenuItem.Text = "Allocate tasks";
            this.allocateTasksToolStripMenuItem.Click += new System.EventHandler(this.allocateTasksToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.logoutToolStripMenuItem.Text = "About";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // AllocateTaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 475);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LstBoxSelectedMembers);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboBoxSelectedMember);
            this.Controls.Add(this.cmboBoxSelectTask);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AllocateTaskView";
            this.Text = "Allocate Task";
            this.Load += new System.EventHandler(this.AllocateTaskView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboBoxSelectTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboBoxSelectedMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.ListBox LstBoxSelectedMembers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allocateTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
    }
}