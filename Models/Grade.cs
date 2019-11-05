using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class Grade
    {
        //public Grade(
        //    global::System.Int32 id,
        //    global::System.Int32 studentId,
        //    Student student,
        //    global::System.Int32 lectureId,
        //    Lecture lecture,
        //    global::System.Double score,
        //    global::System.Int32 year)
        //{
        //    Id = id;
        //    StudentId = studentId;
        //    Student = student;
        //    LectureId = lectureId;
        //    Lecture = lecture;
        //    this.Score = score;
        //    Year = year;
        //}

        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int LectureId { get; set; }
        public Lecture Lecture { get; set; }
        public double Score { get; set; }
        public int Year { get; set; }
    }
}
