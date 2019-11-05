using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class Payment
    {
        //public Payment(
        //    global::System.Int32 studentId,
        //    global::System.Int32 schoolId,
        //    global::System.UInt64 value,
        //    DateTime date)
        //{
        //    StudentId = studentId;
        //    SchoolId = schoolId;
        //    Value = value;
        //    Date = date;
        //}

        ////public int StudentId { get; set; }
        //public int SchoolId { get; set; }
        //public School School { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        //public int EducationId { get; set; }
        //public Education Education { get; set; }
        public decimal Cash { get; set; }
        public int Year { get; set; }

    }
}
