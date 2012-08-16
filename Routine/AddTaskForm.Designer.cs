namespace Routine
{
    partial class AddTaskForm
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
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.taskNameTextbox = new System.Windows.Forms.TextBox();
            this.repeatCheckbox = new System.Windows.Forms.CheckBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.taskTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sundayRepeat = new System.Windows.Forms.CheckBox();
            this.mondayRepeat = new System.Windows.Forms.CheckBox();
            this.tuesdayRepeat = new System.Windows.Forms.CheckBox();
            this.wednesdayRepeat = new System.Windows.Forms.CheckBox();
            this.thursdayRepeat = new System.Windows.Forms.CheckBox();
            this.fridayRepeat = new System.Windows.Forms.CheckBox();
            this.saturdayRepeat = new System.Windows.Forms.CheckBox();
            this.saveAndCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Location = new System.Drawing.Point(13, 13);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(62, 13);
            this.taskNameLabel.TabIndex = 0;
            this.taskNameLabel.Text = "Task Name";
            // 
            // taskNameTextbox
            // 
            this.taskNameTextbox.Location = new System.Drawing.Point(109, 13);
            this.taskNameTextbox.Name = "taskNameTextbox";
            this.taskNameTextbox.Size = new System.Drawing.Size(163, 20);
            this.taskNameTextbox.TabIndex = 1;
            this.taskNameTextbox.Text = "<untitled task>";
            this.taskNameTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // repeatCheckbox
            // 
            this.repeatCheckbox.AutoSize = true;
            this.repeatCheckbox.Checked = true;
            this.repeatCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.repeatCheckbox.Location = new System.Drawing.Point(211, 63);
            this.repeatCheckbox.Name = "repeatCheckbox";
            this.repeatCheckbox.Size = new System.Drawing.Size(61, 17);
            this.repeatCheckbox.TabIndex = 3;
            this.repeatCheckbox.Text = "Repeat";
            this.repeatCheckbox.UseVisualStyleBackColor = true;
            this.repeatCheckbox.CheckedChanged += new System.EventHandler(this.RepeatCheckboxCheckedChanged);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(16, 42);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(30, 13);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "Time";
            this.timeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // taskTimePicker
            // 
            this.taskTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.taskTimePicker.Location = new System.Drawing.Point(72, 40);
            this.taskTimePicker.Name = "taskTimePicker";
            this.taskTimePicker.ShowUpDown = true;
            this.taskTimePicker.Size = new System.Drawing.Size(200, 20);
            this.taskTimePicker.TabIndex = 5;
            // 
            // sundayRepeat
            // 
            this.sundayRepeat.AutoSize = true;
            this.sundayRepeat.Checked = true;
            this.sundayRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sundayRepeat.Location = new System.Drawing.Point(210, 86);
            this.sundayRepeat.Name = "sundayRepeat";
            this.sundayRepeat.Size = new System.Drawing.Size(62, 17);
            this.sundayRepeat.TabIndex = 6;
            this.sundayRepeat.Text = "Sunday";
            this.sundayRepeat.UseVisualStyleBackColor = true;
            // 
            // mondayRepeat
            // 
            this.mondayRepeat.AutoSize = true;
            this.mondayRepeat.Checked = true;
            this.mondayRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mondayRepeat.Location = new System.Drawing.Point(208, 109);
            this.mondayRepeat.Name = "mondayRepeat";
            this.mondayRepeat.Size = new System.Drawing.Size(64, 17);
            this.mondayRepeat.TabIndex = 7;
            this.mondayRepeat.Text = "Monday";
            this.mondayRepeat.UseVisualStyleBackColor = true;
            // 
            // tuesdayRepeat
            // 
            this.tuesdayRepeat.AutoSize = true;
            this.tuesdayRepeat.Checked = true;
            this.tuesdayRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tuesdayRepeat.Location = new System.Drawing.Point(205, 132);
            this.tuesdayRepeat.Name = "tuesdayRepeat";
            this.tuesdayRepeat.Size = new System.Drawing.Size(67, 17);
            this.tuesdayRepeat.TabIndex = 8;
            this.tuesdayRepeat.Text = "Tuesday";
            this.tuesdayRepeat.UseVisualStyleBackColor = true;
            this.tuesdayRepeat.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // wednesdayRepeat
            // 
            this.wednesdayRepeat.AutoSize = true;
            this.wednesdayRepeat.Checked = true;
            this.wednesdayRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wednesdayRepeat.Location = new System.Drawing.Point(191, 156);
            this.wednesdayRepeat.Name = "wednesdayRepeat";
            this.wednesdayRepeat.Size = new System.Drawing.Size(83, 17);
            this.wednesdayRepeat.TabIndex = 9;
            this.wednesdayRepeat.Text = "Wednesday";
            this.wednesdayRepeat.UseVisualStyleBackColor = true;
            // 
            // thursdayRepeat
            // 
            this.thursdayRepeat.AutoSize = true;
            this.thursdayRepeat.Checked = true;
            this.thursdayRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.thursdayRepeat.Location = new System.Drawing.Point(202, 179);
            this.thursdayRepeat.Name = "thursdayRepeat";
            this.thursdayRepeat.Size = new System.Drawing.Size(70, 17);
            this.thursdayRepeat.TabIndex = 10;
            this.thursdayRepeat.Text = "Thursday";
            this.thursdayRepeat.UseVisualStyleBackColor = true;
            // 
            // fridayRepeat
            // 
            this.fridayRepeat.AutoSize = true;
            this.fridayRepeat.Checked = true;
            this.fridayRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fridayRepeat.Location = new System.Drawing.Point(218, 202);
            this.fridayRepeat.Name = "fridayRepeat";
            this.fridayRepeat.Size = new System.Drawing.Size(54, 17);
            this.fridayRepeat.TabIndex = 11;
            this.fridayRepeat.Text = "Friday";
            this.fridayRepeat.UseVisualStyleBackColor = true;
            // 
            // saturdayRepeat
            // 
            this.saturdayRepeat.AutoSize = true;
            this.saturdayRepeat.Checked = true;
            this.saturdayRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saturdayRepeat.Location = new System.Drawing.Point(204, 225);
            this.saturdayRepeat.Name = "saturdayRepeat";
            this.saturdayRepeat.Size = new System.Drawing.Size(68, 17);
            this.saturdayRepeat.TabIndex = 12;
            this.saturdayRepeat.Text = "Saturday";
            this.saturdayRepeat.UseVisualStyleBackColor = true;
            // 
            // saveAndCloseButton
            // 
            this.saveAndCloseButton.Location = new System.Drawing.Point(13, 225);
            this.saveAndCloseButton.Name = "saveAndCloseButton";
            this.saveAndCloseButton.Size = new System.Drawing.Size(102, 23);
            this.saveAndCloseButton.TabIndex = 13;
            this.saveAndCloseButton.Text = "Save and Close";
            this.saveAndCloseButton.UseVisualStyleBackColor = true;
            this.saveAndCloseButton.Click += new System.EventHandler(this.SaveAndCloseButtonClick);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.saveAndCloseButton);
            this.Controls.Add(this.saturdayRepeat);
            this.Controls.Add(this.fridayRepeat);
            this.Controls.Add(this.thursdayRepeat);
            this.Controls.Add(this.wednesdayRepeat);
            this.Controls.Add(this.tuesdayRepeat);
            this.Controls.Add(this.mondayRepeat);
            this.Controls.Add(this.sundayRepeat);
            this.Controls.Add(this.taskTimePicker);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.repeatCheckbox);
            this.Controls.Add(this.taskNameTextbox);
            this.Controls.Add(this.taskNameLabel);
            this.Name = "AddTaskForm";
            this.Text = "Add Task";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddTaskFormFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.TextBox taskNameTextbox;
        private System.Windows.Forms.CheckBox repeatCheckbox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.DateTimePicker taskTimePicker;
        private System.Windows.Forms.CheckBox sundayRepeat;
        private System.Windows.Forms.CheckBox mondayRepeat;
        private System.Windows.Forms.CheckBox tuesdayRepeat;
        private System.Windows.Forms.CheckBox wednesdayRepeat;
        private System.Windows.Forms.CheckBox thursdayRepeat;
        private System.Windows.Forms.CheckBox fridayRepeat;
        private System.Windows.Forms.CheckBox saturdayRepeat;
        private System.Windows.Forms.Button saveAndCloseButton;
    }
}