﻿
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
            this.label2.Location = new System.Drawing.Point(242, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Task title";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(482, 22);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(217, 23);
            this.txtTaskName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sub-task";
            // 
            // txtSubTasks
            // 
            this.txtSubTasks.Location = new System.Drawing.Point(481, 76);
            this.txtSubTasks.Name = "txtSubTasks";
            this.txtSubTasks.Size = new System.Drawing.Size(217, 23);
            this.txtSubTasks.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Comments";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(481, 139);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(217, 23);
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
            this.grpBoxAddTasks.Location = new System.Drawing.Point(61, 110);
            this.grpBoxAddTasks.Name = "grpBoxAddTasks";
            this.grpBoxAddTasks.Size = new System.Drawing.Size(920, 238);
            this.grpBoxAddTasks.TabIndex = 4;
            this.grpBoxAddTasks.TabStop = false;
            this.grpBoxAddTasks.Text = "Add tasks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(700, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "(optional)";
            // 
            // grpBoxAssignMembers
            // 
            this.grpBoxAssignMembers.Controls.Add(this.btnAssignMember);
            this.grpBoxAssignMembers.Controls.Add(this.lstBxAssignedMembers);
            this.grpBoxAssignMembers.Controls.Add(this.cmboBxSelectMember);
            this.grpBoxAssignMembers.Controls.Add(this.label5);
            this.grpBoxAssignMembers.Location = new System.Drawing.Point(61, 406);
            this.grpBoxAssignMembers.Name = "grpBoxAssignMembers";
            this.grpBoxAssignMembers.Size = new System.Drawing.Size(920, 254);
            this.grpBoxAssignMembers.TabIndex = 4;
            this.grpBoxAssignMembers.TabStop = false;
            this.grpBoxAssignMembers.Text = "Assign members";
            // 
            // btnAssignMember
            // 
            this.btnAssignMember.Location = new System.Drawing.Point(580, 68);
            this.btnAssignMember.Name = "btnAssignMember";
            this.btnAssignMember.Size = new System.Drawing.Size(119, 23);
            this.btnAssignMember.TabIndex = 5;
            this.btnAssignMember.Text = "Assign member";
            this.btnAssignMember.UseVisualStyleBackColor = true;
            this.btnAssignMember.Click += new System.EventHandler(this.btnAssignMember_Click);
            // 
            // lstBxAssignedMembers
            // 
            this.lstBxAssignedMembers.FormattingEnabled = true;
            this.lstBxAssignedMembers.ItemHeight = 15;
            this.lstBxAssignedMembers.Location = new System.Drawing.Point(242, 108);
            this.lstBxAssignedMembers.Name = "lstBxAssignedMembers";
            this.lstBxAssignedMembers.Size = new System.Drawing.Size(457, 124);
            this.lstBxAssignedMembers.TabIndex = 4;
            // 
            // cmboBxSelectMember
            // 
            this.cmboBxSelectMember.FormattingEnabled = true;
            this.cmboBxSelectMember.Location = new System.Drawing.Point(482, 25);
            this.cmboBxSelectMember.Name = "cmboBxSelectMember";
            this.cmboBxSelectMember.Size = new System.Drawing.Size(217, 23);
            this.cmboBxSelectMember.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select a member";
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Location = new System.Drawing.Point(397, 699);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(262, 39);
            this.btnCreateProject.TabIndex = 5;
            this.btnCreateProject.Text = "Create project";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // txtProjectTitle
            // 
            this.txtProjectTitle.Location = new System.Drawing.Point(543, 68);
            this.txtProjectTitle.Name = "txtProjectTitle";
            this.txtProjectTitle.Size = new System.Drawing.Size(217, 23);
            this.txtProjectTitle.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Project title";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.editToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.logoutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1066, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "Home";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
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
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addProjectToolStripMenuItem
            // 
            this.addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            this.addProjectToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addProjectToolStripMenuItem.Text = "Add project";
            this.addProjectToolStripMenuItem.Click += new System.EventHandler(this.addProjectToolStripMenuItem_Click);
            // 
            // editProjectToolStripMenuItem
            // 
            this.editProjectToolStripMenuItem.Name = "editProjectToolStripMenuItem";
            this.editProjectToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editProjectToolStripMenuItem.Text = "Edit project";
            this.editProjectToolStripMenuItem.Click += new System.EventHandler(this.editProjectToolStripMenuItem_Click);
            // 
            // allocateTasksToolStripMenuItem
            // 
            this.allocateTasksToolStripMenuItem.Name = "allocateTasksToolStripMenuItem";
            this.allocateTasksToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.allocateTasksToolStripMenuItem.Text = "Allocate tasks";
            this.allocateTasksToolStripMenuItem.Click += new System.EventHandler(this.allocateTasksToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.logoutToolStripMenuItem.Text = "About";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // AddProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1066, 767);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtProjectTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.grpBoxAssignMembers);
            this.Controls.Add(this.grpBoxAddTasks);
            this.Name = "AddProjectView";
            this.Text = "Add Project";
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