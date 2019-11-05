using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Logging;
using myschool.Models;

namespace myschool.Data
{
    public class StudentRepository : IStudentRepository
    {
        public StudentRepository(DataContext context, ILogger<StudentRepository> logger) {
            Context = context;
            Logger = logger;
        }

        public DataContext Context { get; }
        public ILogger<StudentRepository> Logger { get; }

        public void UpdateStudent(Student stu)
        {
            
            Context.Students.Update(stu);
        }

        public async Task<Student> GetStudent(int id)
        {
            var value = await Context.Students.FirstOrDefaultAsync(e=> e.Id == id);
            Logger.LogWarning((value == null).ToString());
            return value;
        }

        public void AddStudent(Student stu)
        {
            Context.Add(stu);
        }

        public async Task SaveStudent(bool throwError)
        {
            if(!(await Context.SaveChangesAsync() > 0))
            {
                if (throwError)
                {
                    throw new Exception("Can not save to Student");
                }
            }
        }

        public async Task<List<Education>> StudentEducations(int id)
        {
            ////اول تمام مقاطعی که دانش اموز دارد راجمع میکنیم
            //List<int> educationId = Context.EducStus.Where(e => e.StudentId == id).Select(e => e.EducationId).ToList();
            
            //List<Education> educationtoreturn = new List<Education>();
            //var e = Context.Educations.Include(e => e.Lectures);
            //foreach (int i in educationId)
            //{
            //    Education edu = await e.FirstOrDefaultAsync(e => e.Id == i);
            //    if (edu != null)
            //    {
            //        educationtoreturn.Add(edu);
            //    }
            //}

            return new List<Education>();
        }

        public async Task<List<EducStu>> EduStus(int studentId)
        {
            List<EducStu> listtoreturn = await Context.EducStus.Where(e => e.StudentId == studentId).ToListAsync();
            return listtoreturn;
        }

        public async Task<List<Grade>> StudentGrade(int stuid, List<int> lecid)
        {
            //var education = await Context.Educations.FirstOrDefaultAsync(e => e.Id == id);
            var stugrade = await Context.Grades.Include(e => e.Lecture)
                .Include(e => e.Student)
                .Where(e => e.StudentId == stuid && lecid.Contains(e.LectureId))
                .ToListAsync();
            foreach (int ls in lecid)
            {
                Logger.LogWarning(ls.ToString());
            }
            return stugrade;
        }

        public async Task<Education> StudentEducation(int educationId)
        {
            var edu = await Context.Educations.Include(e=>e.Lectures).FirstOrDefaultAsync(e => e.Id == educationId);
            return edu;
        }



        //public List<Education> StudentEducation(int id)
        //{
        //    //Logger.LogWarning(id.ToString());
        //    var education =  Context.Educations.Include(e => e.Lectures).Where(e => e.StudentId == id).OrderByDescending(e => e.code).ToList();
        //    return education;
        //}
    }
}
