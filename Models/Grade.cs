using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int LectureId { get; set; }
        public Lecture Lecture { get; set; }
        public double score { get; set; }
    }
}
