namespace Routine
{
    partial class ManageTasksForm
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
            this.addTaskButton = new System.Windows.Forms.Button();
            this.taskList = new System.Windows.Forms.ListBox();
            this.removeTaskButton = new System.Windows.Forms.Button();
            this.editTaskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(13, 13);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(259, 23);
            this.addTaskButton.TabIndex = 0;
            this.addTaskButton.Text = "Add Task";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.AddTaskButtonClick);
            // 
            // taskList
            // 
            this.taskList.FormattingEnabled = true;
            this.taskList.Location = new System.Drawing.Point(13, 43);
            this.taskList.Name = "taskList";
            this.taskList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.taskList.Size = new System.Drawing.Size(259, 173);
            this.taskList.TabIndex = 1;
            this.taskList.SelectedIndexChanged += new System.EventHandler(this.TaskListSelectedIndexChanged);
            // 
            // removeTaskButton
            // 
            this.removeTaskButton.Enabled = false;
            this.removeTaskButton.Location = new System.Drawing.Point(12, 227);
            this.removeTaskButton.Name = "removeTaskButton";
            this.removeTaskButton.Size = new System.Drawing.Size(109, 23);
            this.removeTaskButton.TabIndex = 2;
            this.removeTaskButton.Text = "Remove Task(s)";
            this.removeTaskButton.UseVisualStyleBackColor = true;
            this.removeTaskButton.Click += new System.EventHandler(this.RemoveTaskButtonClick);
            // 
            // editTaskButton
            // 
            this.editTaskButton.Enabled = false;
            this.editTaskButton.Location = new System.Drawing.Point(127, 227);
            this.editTaskButton.Name = "editTaskButton";
            this.editTaskButton.Size = new System.Drawing.Size(144, 23);
            this.editTaskButton.TabIndex = 3;
            this.editTaskButton.Text = "Edit Task";
            this.editTaskButton.UseVisualStyleBackColor = true;
            this.editTaskButton.Click += new System.EventHandler(this.EditTaskButtonClick);
            // 
            // ManageTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.editTaskButton);
            this.Controls.Add(this.removeTaskButton);
            this.Controls.Add(this.taskList);
            this.Controls.Add(this.addTaskButton);
            this.Name = "ManageTasksForm";
            this.Text = "Manage Tasks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageTasksFormClosed);
            this.Load += new System.EventHandler(this.ManageTasks_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.ListBox taskList;
        private System.Windows.Forms.Button removeTaskButton;
        private System.Windows.Forms.Button editTaskButton;
    }
}