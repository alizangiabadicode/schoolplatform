using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class EducStu
    {
        //public EducStu(
        //    global::System.Int32 id,
        //    global::System.Int32 educationId,
        //    global::System.Int32 studentId,
        //    Education education,
        //    Student student,
        //    global::System.Int32 year,
        //    int classid)
        //{
        //    Id = id;
        //    EducationId = educationId;
        //    StudentId = studentId;
        //    Education = education;
        //    Student = student;
        //    Year = year;
        //    ClassId = classid;
        //}

        public int Id { get; set; }
        public int EducationId { get; set; }
        public Education Education { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int Year { get; set; }
        //public int ClassId { get; private set; }
        //public Class Class { get; set; }
        public decimal Payed { get; set; }
    }
}
