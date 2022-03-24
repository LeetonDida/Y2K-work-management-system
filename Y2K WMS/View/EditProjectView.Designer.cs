
namespace Y2K_WMS.View
{
    partial class EditProjectView
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
            this.cmboBoxSelectProject = new System.Windows.Forms.ComboBox();
            this.lblSelectProject = new System.Windows.Forms.Label();
            this.txtCompletionStatus = new System.Windows.Forms.TextBox();
            this.lblCompletionStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBoxCompleted = new System.Windows.Forms.CheckBox();
            this.taskGrpBox = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.txtSubTask = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allocateTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.taskGrpBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmboBoxSelectProject
            // 
            this.cmboBoxSelectProject.FormattingEnabled = true;
            this.cmboBoxSelectProject.Location = new System.Drawing.Point(536, 32);
            this.cmboBoxSelectProject.Name = "cmboBoxSelectProject";
            this.cmboBoxSelectProject.Size = new System.Drawing.Size(121, 23);
            this.cmboBoxSelectProject.TabIndex = 0;
            this.cmboBoxSelectProject.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSelectProject
            // 
            this.lblSelectProject.AutoSize = true;
            this.lblSelectProject.Location = new System.Drawing.Point(360, 32);
            this.lblSelectProject.Name = "lblSelectProject";
            this.lblSelectProject.Size = new System.Drawing.Size(78, 15);
            this.lblSelectProject.TabIndex = 2;
            this.lblSelectProject.Text = "Select project";
            // 
            // txtCompletionStatus
            // 
            this.txtCompletionStatus.Location = new System.Drawing.Point(536, 101);
            this.txtCompletionStatus.Name = "txtCompletionStatus";
            this.txtCompletionStatus.Size = new System.Drawing.Size(121, 23);
            this.txtCompletionStatus.TabIndex = 3;
            // 
            // lblCompletionStatus
            // 
            this.lblCompletionStatus.AutoSize = true;
            this.lblCompletionStatus.Location = new System.Drawing.Point(360, 101);
            this.lblCompletionStatus.Name = "lblCompletionStatus";
            this.lblCompletionStatus.Size = new System.Drawing.Size(104, 15);
            this.lblCompletionStatus.TabIndex = 2;
            this.lblCompletionStatus.Text = "Completion status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBoxCompleted);
            this.groupBox1.Controls.Add(this.lblCompletionStatus);
            this.groupBox1.Controls.Add(this.txtCompletionStatus);
            this.groupBox1.Controls.Add(this.cmboBoxSelectProject);
            this.groupBox1.Controls.Add(this.lblSelectProject);
            this.groupBox1.Location = new System.Drawing.Point(34, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 192);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project";
            // 
            // chkBoxCompleted
            // 
            this.chkBoxCompleted.AutoSize = true;
            this.chkBoxCompleted.Location = new System.Drawing.Point(536, 147);
            this.chkBoxCompleted.Name = "chkBoxCompleted";
            this.chkBoxCompleted.Size = new System.Drawing.Size(85, 19);
            this.chkBoxCompleted.TabIndex = 4;
            this.chkBoxCompleted.Text = "Completed";
            this.chkBoxCompleted.UseVisualStyleBackColor = true;
            this.chkBoxCompleted.CheckedChanged += new System.EventHandler(this.chkBoxCompleted_CheckedChanged);
            // 
            // taskGrpBox
            // 
            this.taskGrpBox.Controls.Add(this.btnAdd);
            this.taskGrpBox.Controls.Add(this.txtComment);
            this.taskGrpBox.Controls.Add(this.label4);
            this.taskGrpBox.Controls.Add(this.label3);
            this.taskGrpBox.Controls.Add(this.txtTaskName);
            this.taskGrpBox.Controls.Add(this.txtSubTask);
            this.taskGrpBox.Controls.Add(this.label5);
            this.taskGrpBox.Location = new System.Drawing.Point(34, 272);
            this.taskGrpBox.Name = "taskGrpBox";
            this.taskGrpBox.Size = new System.Drawing.Size(1020, 265);
            this.taskGrpBox.TabIndex = 4;
            this.taskGrpBox.TabStop = false;
            this.taskGrpBox.Text = "Task";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(536, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add new";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(536, 154);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(121, 23);
            this.txtComment.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sub task";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Task name";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(536, 38);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(121, 23);
            this.txtTaskName.TabIndex = 3;
            // 
            // txtSubTask
            // 
            this.txtSubTask.Location = new System.Drawing.Point(536, 100);
            this.txtSubTask.Name = "txtSubTask";
            this.txtSubTask.Size = new System.Drawing.Size(121, 23);
            this.txtSubTask.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Comment";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(462, 559);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1088, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "Home";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
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
            // 
            // editProjectToolStripMenuItem
            // 
            this.editProjectToolStripMenuItem.Name = "editProjectToolStripMenuItem";
            this.editProjectToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editProjectToolStripMenuItem.Text = "Edit project";
            // 
            // allocateTasksToolStripMenuItem
            // 
            this.allocateTasksToolStripMenuItem.Name = "allocateTasksToolStripMenuItem";
            this.allocateTasksToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.allocateTasksToolStripMenuItem.Text = "Allocate tasks";
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
            // 
            // EditProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 620);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.taskGrpBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditProjectView";
            this.Text = "Edit Project";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.taskGrpBox.ResumeLayout(false);
            this.taskGrpBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboBoxSelectProject;
        private System.Windows.Forms.Label lblSelectProject;
        private System.Windows.Forms.TextBox txtCompletionStatus;
        private System.Windows.Forms.Label lblCompletionStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox taskGrpBox;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubTask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkBoxCompleted;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allocateTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
    }
}