using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        //public ICollection<Student> Students { get; set; }
        //public ICollection<Schedule> Schedules { get; set; }
    }
}
