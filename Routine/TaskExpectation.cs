using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Routine
{
    public class TaskExpectation
    {
        public Guid TaskGuid;
        public DateTime ExpectedDateTime;

        public TaskExpectation(Guid taskGuid, DateTime expectedDate, TimeSpan expectedTime)
        {
            TaskGuid = taskGuid;
            ExpectedDateTime = expectedDate.Date.Add(expectedTime);
        }
    }
}
