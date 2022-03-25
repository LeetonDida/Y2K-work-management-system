
namespace Y2K_WMS.View
{
    partial class AddProjectView
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubTasks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.grpBoxAddTasks = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpBoxAssignMembers = new System.Windows.Forms.GroupBox();
            this.btnAssignMember = new System.Windows.Forms.Button();
            this.lstBxAssignedMembers = new System.Windows.Forms.ListBox();
            this.cmboBxSelectMember = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.txtProjectTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allocateTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxAddTasks.SuspendLayout();
            this.grpBoxAssignMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Task title";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(551, 29);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(247, 27);
            this.txtTaskName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sub-task";
            // 
            // txtSubTasks
            // 
            this.txtSubTasks.Location = new System.Drawing.Point(550, 101);
            this.txtSubTasks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubTasks.Name = "txtSubTasks";
            this.txtSubTasks.Size = new System.Drawing.Size(247, 27);
            this.txtSubTasks.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Comments";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(550, 185);
            this.txtComments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(247, 27);
            this.txtComments.TabIndex = 3;
            // 
            // grpBoxAddTasks
            // 
            this.grpBoxAddTasks.Controls.Add(this.txtSubTasks);
            this.grpBoxAddTasks.Controls.Add(this.txtTaskName);
            this.grpBoxAddTasks.Controls.Add(this.label6);
            this.grpBoxAddTasks.Controls.Add(this.label2);
            this.grpBoxAddTasks.Controls.Add(this.txtComments);
            this.grpBoxAddTasks.Controls.Add(this.label4);
            this.grpBoxAddTasks.Controls.Add(this.label3);
            this.grpBoxAddTasks.Location = new System.Drawing.Point(70, 147);
            this.grpBoxAddTasks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxAddTasks.Name = "grpBoxAddTasks";
            this.grpBoxAddTasks.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxAddTasks.Size = new System.Drawing.Size(1051, 317);
            this.grpBoxAddTasks.TabIndex = 4;
            this.grpBoxAddTasks.TabStop = false;
            this.grpBoxAddTasks.Text = "Add tasks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(800, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "(optional)";
            // 
            // grpBoxAssignMembers
            // 
            this.grpBoxAssignMembers.Controls.Add(this.btnAssignMember);
            this.grpBoxAssignMembers.Controls.Add(this.lstBxAssignedMembers);
            this.grpBoxAssignMembers.Controls.Add(this.cmboBxSelectMember);
            this.grpBoxAssignMembers.Controls.Add(this.label5);
            this.grpBoxAssignMembers.Location = new System.Drawing.Point(70, 541);
            this.grpBoxAssignMembers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxAssignMembers.Name = "grpBoxAssignMembers";
            this.grpBoxAssignMembers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxAssignMembers.Size = new System.Drawing.Size(1051, 339);
            this.grpBoxAssignMembers.TabIndex = 4;
            this.grpBoxAssignMembers.TabStop = false;
            this.grpBoxAssignMembers.Text = "Assign members";
            // 
            // btnAssignMember
            // 
            this.btnAssignMember.Location = new System.Drawing.Point(663, 91);
            this.btnAssignMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAssignMember.Name = "btnAssignMember";
            this.btnAssignMember.Size = new System.Drawing.Size(136, 31);
            this.btnAssignMember.TabIndex = 5;
            this.btnAssignMember.Text = "Assign member";
            this.btnAssignMember.UseVisualStyleBackColor = true;
            this.btnAssignMember.Click += new System.EventHandler(this.btnAssignMember_Click);
            // 
            // lstBxAssignedMembers
            // 
            this.lstBxAssignedMembers.FormattingEnabled = true;
            this.lstBxAssignedMembers.ItemHeight = 20;
            this.lstBxAssignedMembers.Location = new System.Drawing.Point(277, 144);
            this.lstBxAssignedMembers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstBxAssignedMembers.Name = "lstBxAssignedMembers";
            this.lstBxAssignedMembers.Size = new System.Drawing.Size(522, 164);
            this.lstBxAssignedMembers.TabIndex = 4;
            // 
            // cmboBxSelectMember
            // 
            this.cmboBxSelectMember.FormattingEnabled = true;
            this.cmboBxSelectMember.Location = new System.Drawing.Point(551, 33);
            this.cmboBxSelectMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboBxSelectMember.Name = "cmboBxSelectMember";
            this.cmboBxSelectMember.Size = new System.Drawing.Size(247, 28);
            this.cmboBxSelectMember.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select a member";
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Location = new System.Drawing.Point(454, 932);
            this.btnCreateProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(299, 52);
            this.btnCreateProject.TabIndex = 5;
            this.btnCreateProject.Text = "Create project";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // txtProjectTitle
            // 
            this.txtProjectTitle.Location = new System.Drawing.Point(621, 91);
            this.txtProjectTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProjectTitle.Name = "txtProjectTitle";
            this.txtProjectTitle.Size = new System.Drawing.Size(247, 27);
            this.txtProjectTitle.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Project title";
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
            this.menuStrip1.Size = new System.Drawing.Size(1218, 30);
            this.menuStrip1.TabIndex = 8;
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
            // AddProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1218, 1023);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtProjectTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.grpBoxAssignMembers);
            this.Controls.Add(this.grpBoxAddTasks);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddProjectView";
            this.Text = "Add Project";
            this.Load += new System.EventHandler(this.AddProjectView_Load);
            this.grpBoxAddTasks.ResumeLayout(false);
            this.grpBoxAddTasks.PerformLayout();
            this.grpBoxAssignMembers.ResumeLayout(false);
            this.grpBoxAssignMembers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubTasks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.GroupBox grpBoxAddTasks;
        private System.Windows.Forms.GroupBox grpBoxAssignMembers;
        private System.Windows.Forms.Button btnAssignMember;
        private System.Windows.Forms.ListBox lstBxAssignedMembers;
        private System.Windows.Forms.ComboBox cmboBxSelectMember;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.TextBox txtProjectTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label6;
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