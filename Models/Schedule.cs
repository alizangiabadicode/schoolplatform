using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
        //public int EducationId { get; set; }
        //public ICollection<Education> Educations { get; set; }
        public int LectureId { get; set; }
        public Lecture Lecture { get; set; }
        public int TimeId { get; set; }
        [ForeignKey("TimeId")]
        public Time Time { get; set; }
        [Range(0, 6)]
        public int DayOfWeek { get; set; }
        public int Year { get; set; }
    }
}
