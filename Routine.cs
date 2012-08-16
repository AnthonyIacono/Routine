using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Routine
{
    public class Routine
    {
        public List<Task> Tasks;

        public List<TaskAudit> TaskAudits;
 
        public Routine()
        {
            Tasks = new List<Task>();
            TaskAudits = new List<TaskAudit>();
        }

        public void AddTask(Task task)
        {
            if(null != FindTaskInRoutine(task))
            {
                return;
            }

            Tasks.Add(task);
        }

        Task FindTaskInRoutine(Task task)
        {
            return FindTaskInRoutine(task.Guid);
        }

        Task FindTaskInRoutine(Guid guid)
        {
            foreach(var task in Tasks)
            {
                if(task.Guid.Equals(guid))
                {
                    return task;
                }
            }

            return null;
        }

        public void RemoveTask(Task task)
        {
            RemoveTask(task.Guid);
        }

        public void RemoveTask(Guid taskGuid)
        {
            Tasks.RemoveAll(t => t.Guid == taskGuid);
        }

        public void Save(string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(this));
        }

        public TaskExpectation GetPendingExpectation(Task task)
        {
            var expectations = GetTaskExpectations(task);

            if(expectations.Count == 0)
            {
                return null;
            }

            foreach (var expectation in expectations)
            {
                if(HasExpectationBeenMet(expectation) || IsThereAMoreRecentExpectation(expectations, expectation))
                {
                    continue;
                }

                var hours = DateTime.Now.Subtract(expectation.ExpectedDateTime).TotalHours;

                if(hours >= -1)
                {
                    return expectation;
                }
            }

            return null;
        }

        private bool IsThereAMoreRecentExpectation(List<TaskExpectation> expectations, TaskExpectation expectation)
        {
            return
                expectations.FirstOrDefault(ta => ta.TaskGuid == expectation.TaskGuid && ta.ExpectedDateTime > expectation.ExpectedDateTime) != null;
        }

        public bool HasExpectationBeenMet(TaskExpectation taskExpectation)
        {
            var audit = TaskAudits.FirstOrDefault(ta => ta.TaskGuid == taskExpectation.TaskGuid && ta.DateTime.Date == taskExpectation.ExpectedDateTime.Date);

            return audit != null;
        }

        public List<TaskExpectation> GetTaskExpectations(Task task, int days = 30)
        {
            var now = DateTime.Now;

            var expectations = new List<TaskExpectation>();

            for(int x = 0; x < days; x++)
            {
                var dateTime = now.AddDays(-x);

                var expectation = GetDailyExpectation(task, dateTime);

                if(expectation == null)
                {
                    continue;
                }

                expectations.Add(expectation);
            }

            return expectations;
        }

        public TaskExpectation GetDailyExpectation(Task task, DateTime dateTime)
        {
            if(!task.ShouldOccurOn(dateTime))
            {
                return null;
            }

            return new TaskExpectation(task.Guid, dateTime.Date, task.TimeOfDay);
        }

        public void CompleteTask(Task task)
        {
            var expectation = GetPendingExpectation(task);

            if(null == expectation)
            {
                throw new Exception("Task isn't pending");
            }

            TaskAudits.Add(new TaskAudit(task.Guid, expectation, DateTime.Now));
        }

        public void UpdateTask(Guid taskGuid, Task task)
        {
            for(int x = 0; x < Tasks.Count; x++)
            {
                if(Tasks[x].Guid != taskGuid)
                {
                    continue;
                }
                
                Tasks[x] = task;
                break;
            }
        }
    }
}
