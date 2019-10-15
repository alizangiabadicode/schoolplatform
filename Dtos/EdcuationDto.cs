using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Dtos
{
    public class EducationDto
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Grade { get; set; }
        public ICollection<LectureDto> Lectures { get; set; }

    }
}
