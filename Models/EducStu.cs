using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class EducStu
    {
        public EducStu(
            global::System.Int32 id,
            global::System.Int32 educationId,
            global::System.Int32 studentId,
            Education education,
            Student student,
            global::System.Int32 year)
        {
            Id = id;
            EducationId = educationId;
            StudentId = studentId;
            Education = education;
            Student = student;
            Year = year;
        }

        public int Id { get; set; }
        public int EducationId { get; set; }
        public int StudentId { get; set; }
        public Education Education { get; set; }
        public Student Student { get; set; }
        public int Year { get; set; }//needed beacuse a student may be in one education for two  years
    }
}
