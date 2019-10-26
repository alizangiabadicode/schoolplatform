using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class Service
    {
        public Service(
            global::System.String name,
            TimeSpan duration,
            DateTime startTime,
            global::System.Int32 schoolId)
        {
            Name = name;
            Duration = duration;
            StartTime = startTime;
            SchoolId = schoolId;
        }

        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime StartTime { get; set; }
        public int SchoolId { get; set; }
        //...
    }
}
