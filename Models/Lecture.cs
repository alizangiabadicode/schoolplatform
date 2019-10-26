using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class Lecture
    {
        public Lecture(
            int teacherId,
            global::System.Int32 id,
            global::System.String name,
            global::System.Int32 educationId,
            Education education,
            global::System.Int32 factor)
        {
            Id = id;
            Name = name;
            EducationId = educationId;
            Education = education;
            Factor = factor;
            TeacherId = teacherId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int EducationId { get; set; }
        public Education Education { get; set; }
        public int Factor { get; set; }
        public int TeacherId { get; set; }
    }
}
