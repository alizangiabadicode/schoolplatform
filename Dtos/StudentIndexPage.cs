using myschool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Dtos
{
    public class StudentIndexPage
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string StuPhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string Address { get; set; }
        public string NationalCode { get; set; }
        public string StuCode { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<Education> Educations { get; set; }
    }
}
