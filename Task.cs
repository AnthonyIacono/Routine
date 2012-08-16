using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Routine
{
    public class Task
    {
        public string Title { get; set; }
        public TimeSpan TimeOfDay { get; set; }
        public bool Repeat { get; set; }
        public bool RepeatSunday { get; set; }
        public bool RepeatMonday { get; set; }
        public bool RepeatTuesday { get; set; }
        public bool RepeatWednesday { get; set; }
        public bool RepeatThursday { get; set; }
        public bool RepeatFriday { get; set; }
        public bool RepeatSaturday { get; set; }
        public DateTime Date { get; set; }
        public Guid Guid;
        public Task(string title, DateTime date, TimeSpan timeOfDay, bool repeat, bool repeatSunday, bool repeatMonday, bool repeatTuesday, bool repeatWednesday, bool repeatThursday, bool repeatFriday, bool repeatSaturday)
        {
            Title = title;
            Date = date;
            TimeOfDay = timeOfDay;
            Repeat = repeat;
            RepeatSunday = repeatSunday;
            RepeatMonday = repeatMonday;
            RepeatTuesday = repeatTuesday;
            RepeatWednesday = repeatWednesday;
            RepeatThursday = repeatThursday;
            RepeatFriday = repeatFriday;
            RepeatSaturday = repeatSaturday;
            Guid = Guid.NewGuid();
        }

        public override string ToString()
        {
            return Title + " [" + DateTime.Now.Date.Add(TimeOfDay).ToString("hh:mm tt") + "]";
        }

        public bool ShouldOccurOn(DateTime dateTime)
        {
            if(dateTime < this.Date)
            {
                return false;
            }

            if (this.Repeat)
            {

                if (dateTime.DayOfWeek == DayOfWeek.Sunday)
                {
                    return this.RepeatSunday;
                }
                else if (dateTime.DayOfWeek == DayOfWeek.Monday)
                {
                    return this.RepeatMonday;
                }
                else if (dateTime.DayOfWeek == DayOfWeek.Tuesday)
                {
                    return this.RepeatTuesday;
                }
                else if (dateTime.DayOfWeek == DayOfWeek.Wednesday)
                {
                    return this.RepeatWednesday;
                }
                else if (dateTime.DayOfWeek == DayOfWeek.Thursday)
                {
                    return this.RepeatThursday;
                }
                else if (dateTime.DayOfWeek == DayOfWeek.Friday)
                {
                    return this.RepeatFriday;
                }

                return this.RepeatSaturday;
            }

            return this.Date.Date == dateTime.Date;
        }
    }
}
