using myschool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Data
{
    public interface IStudentRepository
    {
        //statc void ali() { }
        Task<Student> GetStudent(int id);

        // این متود نیازی به اسینک بودن ندارد 
        void UpdateStudent(Student stu);
        // این متود نیازی به اسینک بودن ندارد 
        void AddStudent(Student stu);
        Task SaveStudent(bool throwError);

        Task<List<Education>> StudentEducations(int id);

        Task<List<EducStu>> EduStus(int studentId);
        Task<Education> StudentEducation(int id);
        Task<List<Grade>> StudentGrade(int stuid, List<int> lecid);
    }
}
