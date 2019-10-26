using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class Student
    {
        public Student(
            global::System.Int32 id,
            global::System.String firstName,
            global::System.String lastName,
            DateTime born,
            global::System.String stuPhoneNumber,
            global::System.String homePhoneNumber,
            global::System.String address,
            global::System.String nationalCode,
            global::System.String stuCode,
            global::System.String photoUrl,
            global::System.UInt64 cash,
            global::System.Int32 parnet1Id,
            global::System.Int32 parnet2Id)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Born = born;
            StuPhoneNumber = stuPhoneNumber;
            HomePhoneNumber = homePhoneNumber;
            Address = address;
            NationalCode = nationalCode;
            StuCode = stuCode;
            PhotoUrl = photoUrl;
            Cash = cash;
            Parnet1Id = parnet1Id;
            Parnet2Id = parnet2Id;
        }

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
        public ulong Cash { get; set; }// Money paid
        public int Parnet1Id { get; set; }
        public int Parnet2Id { get; set; }//each student can have 2 parents
    }
}
