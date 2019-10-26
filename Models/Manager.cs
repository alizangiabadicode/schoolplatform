using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class Manager
    {
        public Manager(global::System.String name, global::System.Int32 id, global::System.Int32 schoolId)
        {
            Name = name;
            Id = id;
            SchoolId = schoolId;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public int SchoolId { get; set; }

    }
}
