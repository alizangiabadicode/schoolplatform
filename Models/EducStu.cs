using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class EducStu
    {
        public int Id { get; set; }
        public int EducationId { get; set; }
        public int StudentId { get; set; }
        public Education Education { get; set; }
        public Student Student { get; set; }
    }
}
