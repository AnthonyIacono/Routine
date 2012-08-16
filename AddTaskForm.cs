using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Routine.Properties;

namespace Routine
{
    public partial class AddTaskForm : Form
    {
        ManageTasksForm ManageTasks;
        Routine Routine;

        public AddTaskForm(ManageTasksForm manageTasks, Routine routine)
        {
            ManageTasks = manageTasks;
            Routine = routine;
            AlreadySaved = false;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RepeatCheckboxCheckedChanged(object sender, EventArgs e)
        {
            var repeatEnabled = repeatCheckbox.Checked;
            
            mondayRepeat.Enabled = repeatEnabled;
            tuesdayRepeat.Enabled = repeatEnabled;
            wednesdayRepeat.Enabled = repeatEnabled;
            thursdayRepeat.Enabled = repeatEnabled;
            fridayRepeat.Enabled = repeatEnabled;
            saturdayRepeat.Enabled = repeatEnabled;
            sundayRepeat.Enabled = repeatEnabled;
        }

        private void AddTaskFormFormClosing(object sender, FormClosingEventArgs e)
        {
            if(AlreadySaved)
            {
                return;
            }

            var answer = MessageBox.Show(Resources.AddTaskForm_AddTaskFormFormClosing_SavePrompt,
                Resources.AddTaskForm_AddTaskFormFormClosing_SavePromptCaption, MessageBoxButtons.YesNoCancel);

            if (answer == DialogResult.Yes)
            {
                SaveTask();
                
                ManageTasks.UpdateAndShow();
            }
            else if (answer == DialogResult.No)
            {
                ManageTasks.UpdateAndShow();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void SaveAndCloseButtonClick(object sender, EventArgs e)
        {
            SaveTask();

            ManageTasks.UpdateAndShow();
            AlreadySaved = true;
            this.Close();
        }

        public bool AlreadySaved { get; set; }

        private void SaveTask()
        {
            var taskTitle = taskNameTextbox.Text.Trim() == "" ? "<untitled task>" : taskNameTextbox.Text;

            var taskTimeOfDay = taskTimePicker.Value.TimeOfDay;

            var task = new Task(taskTitle, DateTime.Now, taskTimeOfDay, repeatCheckbox.Checked, sundayRepeat.Checked,
                                mondayRepeat.Checked, tuesdayRepeat.Checked, wednesdayRepeat.Checked,
                                thursdayRepeat.Checked, fridayRepeat.Checked, saturdayRepeat.Checked);

            Routine.AddTask(task);
        }

        public void UpdateAndShow()
        {
            Show();
        }
    }
}
