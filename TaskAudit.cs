using System;

namespace Routine
{
    public class TaskAudit
    {
        public TaskExpectation TaskExpectation { get; set; }
        public DateTime DateTime { get; set; }
        public Guid TaskGuid;
        public Guid Guid;

        public TaskAudit(Guid taskGuid, TaskExpectation taskExpectation, DateTime dateTime)
        {
            TaskExpectation = taskExpectation;
            DateTime = dateTime;
            TaskGuid = taskGuid;
            Guid = Guid.NewGuid();
        }
    }
}