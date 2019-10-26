using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class TeacherSchool
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
        public int Year { get; set; }
    }
}
