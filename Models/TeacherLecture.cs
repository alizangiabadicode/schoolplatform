using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class TeacherLecture
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int LectureId { get; set; }
        public Lecture Lecture { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public int Year { get; set; }
    }
}
