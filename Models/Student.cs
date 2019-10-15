using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Born { get; set; }
        public string StuPhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string Address { get; set; }
        public string NationalCode { get; set; }
        public string StuCode { get; set; }
        //public ICollection<Education> Educations { get; set; }
        public string PhotoUrl { get; set; }
        //public ICollection<Lecture> Lectures { get; set; }
    }
}
