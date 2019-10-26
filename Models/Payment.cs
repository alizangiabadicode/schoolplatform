using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class Payment
    {
        public Payment(
            global::System.Int32 studentId,
            global::System.Int32 schoolId,
            global::System.UInt64 value,
            DateTime date)
        {
            StudentId = studentId;
            SchoolId = schoolId;
            Value = value;
            Date = date;
        }

        public int StudentId { get; set; }
        public int SchoolId { get; set; }
        public ulong Value { get; set; }
        public DateTime Date { get; set; }
    }
}
