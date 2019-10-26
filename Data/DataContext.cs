using Microsoft.EntityFrameworkCore;
using myschool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<EducStu> EducStus { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<TeacherLecture> TeacherLectures { get; set; }
        public DbSet<TeacherSchool> TeacherSchools { get; set; }
        public DbSet<SchoolEducations> schoolEducations { get; set; }
        public DbSet<Time> Times { get; set; }
    }
}
