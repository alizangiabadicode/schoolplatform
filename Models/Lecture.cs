using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class Lecture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EducationId { get; set; }
        public Education Education { get; set; }
        public int Factor { get; set; }
        //public double Grade { get; set; }
    }
}
