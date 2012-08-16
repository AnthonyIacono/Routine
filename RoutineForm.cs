using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Routine.Properties;

namespace Routine
{
    public partial class RoutineForm : Form
    {
        public Routine Routine { get; set; }

        public RoutineForm(Routine routine)
        {
            Routine = routine;

            InitializeComponent();

            UpdatePendingTasksList();
        }

        public void UpdatePendingTasksList()
        {
            pendingTasksList.Items.Clear();

            keyTaskLabel.Text = Resources.RoutineForm_UpdatePendingTasksList_KeyTaskLabel + Resources.RoutineForm_UpdatePendingTasksList_KeyTaskLabelNone;
            var tasks = Routine.Tasks.Where(t => null != Routine.GetPendingExpectation(t));

            var first = true;

            foreach(var task in tasks)
            {
                pendingTasksList.Items.Add(task);

                if(first)
                {
                    first = false;
                    keyTaskLabel.Text = Resources.RoutineForm_UpdatePendingTasksList_KeyTaskLabel + task;
                }
            }
        }

        private void ManageTasksButtonClick(object sender, EventArgs e)
        {
            var manageTasksForm = new ManageTasksForm(this, Routine);

            manageTasksForm.UpdateAndShow();

            this.Hide();
        }

        private void RoutineFormFormClosed(object sender, FormClosedEventArgs e)
        {
            Routine.Save(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "routine.json"));
        }

        private void CompleteTaskButtonClick(object sender, EventArgs e)
        {
            foreach(Task item in pendingTasksList.SelectedItems)
            {
                Routine.CompleteTask(item);
            }

            UpdatePendingTasksList();
        }

        public void UpdateAndShow()
        {
            UpdatePendingTasksList();
            Show();
        }

        private void UpdateTimerTick(object sender, EventArgs e)
        {
            UpdatePendingTasksList();
        }
    }
}
