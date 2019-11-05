using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class Education
    {
        //public Education(
        //    global::System.Int32 id,
        //    global::System.String name,
        //    ICollection<Lecture> lectures,
        //    global::System.UInt64 cost)
        //{
        //    Id = id;
        //    Name = name;
        //    Lectures = lectures;
        //    Cost = cost;
        //}

        public int Id { get; set; }
        public string Name { get; set; }
        public int code { get; set; }
        //public double Grade { get; set; }
        //public int StudentId { get; set; }
        //public Student Student { get; set; }
        public ICollection<Lecture> Lectures { get; set; }
        //public ICollection<Student> Students { get; set; }
        //public int PaymentId { get; set; } // standard cost of each education
        //public Payment Payment { get; set; }
    }
}
