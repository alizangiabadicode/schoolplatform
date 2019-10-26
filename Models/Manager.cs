using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class Manager
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public ICollection<Education> Educations { get; set; }
        public string NationalId { get; set; }
        public string PersonnelNumber { get; set; }
    }
}
