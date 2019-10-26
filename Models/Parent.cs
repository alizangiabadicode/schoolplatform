using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class Parent
    {
        public Parent(
            global::System.String name,
            global::System.Int32 id,
            global::System.Int32 sudent1Id,
            global::System.Int32 sudent2Id,
            global::System.Int32 sudent3Id,
            global::System.Int32 sudent4Id,
            global::System.Int32 sudent5Id)
        {
            Name = name;
            Id = id;
            Sudent1Id = sudent1Id;
            Sudent2Id = sudent2Id;
            Sudent3Id = sudent3Id;
            Sudent4Id = sudent4Id;
            Sudent5Id = sudent5Id;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public int Sudent1Id { get; set; }
        public int Sudent2Id { get; set; }
        public int Sudent3Id { get; set; }
        public int Sudent4Id { get; set; }
        public int Sudent5Id { get; set; }// each parent can handle 5 children


    }
}
