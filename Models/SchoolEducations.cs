using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class SchoolEducations
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
        public int EducationId { get; set; }
        public Education Education { get; set; }
    }
}
