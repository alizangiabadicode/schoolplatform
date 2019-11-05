using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class Teacher
    {
        //public Teacher(
        //    global::System.Int32 id,
        //    global::System.String name,
        //    global::System.Int32 lectureId,
        //    List<Lecture> classes)
        //{
        //    Id = id;
        //    Name = name;
        //    LectureId = lectureId;
        //    Classes = classes;
        //}

        public int Id { get; set; }
        public string Name { get; set; }
        //public int LectureId { get; set; }//lecture can teach
        //public List<Lecture> Classes { get; set; }
    }
}
