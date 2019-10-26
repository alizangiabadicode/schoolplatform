using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // تحصیلات خود استاد

        //public ICollection<Education> Educations { get; set; }
        //public ICollection<School> Schools { get; set; }
        //public ICollection<Lecture> Lectures { get; set; }
        //public Schedule Schedule { get; set; }
    }
}
