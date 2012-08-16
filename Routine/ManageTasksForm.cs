using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Routine
{
    public partial class ManageTasksForm : Form
    {
        public RoutineForm RoutineFormObj;
        public Routine Routine;

        public ManageTasksForm(RoutineForm routineForm, Routine routine)
        {
            RoutineFormObj = routineForm;
            Routine = routine;
            InitializeComponent();
        }

        public void UpdateTasksList()
        {
            taskList.Items.Clear();

            foreach (var task in Routine.Tasks)
            {
                taskList.Items.Add(task);
            }
        }

        private void ManageTasks_Load(object sender, EventArgs e)
        {

        }

        private void ManageTasksFormClosed(object sender, FormClosedEventArgs e)
        {
            RoutineFormObj.UpdateAndShow();
        }

        private void AddTaskButtonClick(object sender, EventArgs e)
        {
            var addTaskForm = new AddTaskForm(this, Routine);
            addTaskForm.UpdateAndShow();
            this.Hide();
        }

        private void EditTaskButtonClick(object sender, EventArgs e)
        {
            var task = (Task)taskList.SelectedItem;

            if(task == null)
            {
                throw new Exception("No task selected");
            }

            var editTaskForm = new EditTaskForm(this, task, Routine);

            editTaskForm.UpdateAndShow();

            this.Hide();
        }

        private void TaskListSelectedIndexChanged(object sender, EventArgs e)
        {
            editTaskButton.Enabled = taskList.SelectedItems.Count == 1;
            removeTaskButton.Enabled = taskList.SelectedItems.Count > 0;
        }

        public void UpdateAndShow()
        {
            UpdateTasksList();
            TaskListSelectedIndexChanged(null, null);
            Show();
        }

        private void RemoveTaskButtonClick(object sender, EventArgs e)
        {
            foreach(Task task in taskList.SelectedItems)
            {
                Routine.RemoveTask(task.Guid);
            }

            UpdateTasksList();
        }
    }
}
