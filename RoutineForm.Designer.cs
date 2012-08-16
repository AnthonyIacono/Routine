namespace Routine
{
    partial class RoutineForm
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
            this.keyTaskLabel = new System.Windows.Forms.Label();
            this.pendingTasksList = new System.Windows.Forms.ListBox();
            this.completeTaskButton = new System.Windows.Forms.Button();
            this.manageTasksButton = new System.Windows.Forms.Button();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // keyTaskLabel
            // 
            this.keyTaskLabel.AutoSize = true;
            this.keyTaskLabel.Location = new System.Drawing.Point(9, 9);
            this.keyTaskLabel.Name = "keyTaskLabel";
            this.keyTaskLabel.Size = new System.Drawing.Size(84, 13);
            this.keyTaskLabel.TabIndex = 0;
            this.keyTaskLabel.Text = "Key Task: None";
            // 
            // pendingTasksList
            // 
            this.pendingTasksList.FormattingEnabled = true;
            this.pendingTasksList.Location = new System.Drawing.Point(12, 32);
            this.pendingTasksList.Name = "pendingTasksList";
            this.pendingTasksList.Size = new System.Drawing.Size(260, 186);
            this.pendingTasksList.TabIndex = 1;
            // 
            // completeTaskButton
            // 
            this.completeTaskButton.Location = new System.Drawing.Point(161, 227);
            this.completeTaskButton.Name = "completeTaskButton";
            this.completeTaskButton.Size = new System.Drawing.Size(112, 23);
            this.completeTaskButton.TabIndex = 2;
            this.completeTaskButton.Text = "Complete Task(s)";
            this.completeTaskButton.UseVisualStyleBackColor = true;
            this.completeTaskButton.Click += new System.EventHandler(this.CompleteTaskButtonClick);
            // 
            // manageTasksButton
            // 
            this.manageTasksButton.Location = new System.Drawing.Point(11, 227);
            this.manageTasksButton.Name = "manageTasksButton";
            this.manageTasksButton.Size = new System.Drawing.Size(143, 23);
            this.manageTasksButton.TabIndex = 3;
            this.manageTasksButton.Text = "Manage All Tasks";
            this.manageTasksButton.UseVisualStyleBackColor = true;
            this.manageTasksButton.Click += new System.EventHandler(this.ManageTasksButtonClick);
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 30000;
            this.updateTimer.Tick += new System.EventHandler(this.UpdateTimerTick);
            // 
            // RoutineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.manageTasksButton);
            this.Controls.Add(this.completeTaskButton);
            this.Controls.Add(this.pendingTasksList);
            this.Controls.Add(this.keyTaskLabel);
            this.Name = "RoutineForm";
            this.Text = "Routine";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoutineFormFormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label keyTaskLabel;
        private System.Windows.Forms.ListBox pendingTasksList;
        private System.Windows.Forms.Button completeTaskButton;
        private System.Windows.Forms.Button manageTasksButton;
        private System.Windows.Forms.Timer updateTimer;
    }
}

