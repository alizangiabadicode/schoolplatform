using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using myschool.Data;
using myschool.Models;
using myschool.Dtos;
using stu = myschool.Models.Student;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace myschool.Areas.Student.Controllers
{
    public class MainController : Controller
    {
        public MainController(IStudentRepository sturepo,
                              IMapper mapper,
                              Seed seed,
                              ILogger<MainController> logger)
        {
            Sturepo = sturepo;
            Mapper = mapper;
            Seed = seed;
            Logger = logger;
        }

        public IStudentRepository Sturepo { get; }
        public IMapper Mapper { get; }
        public Seed Seed { get; }
        public ILogger<MainController> Logger { get; }

        public async Task<IActionResult> Index()
        {
            // set id to 1 for azmayesh
            var options = new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(1)
            };
            HttpContext.Response.Cookies.Append("id", "1", options);

            stu student = await Sturepo.GetStudent(1);
            StudentIndexPage studentDto = Mapper.Map<StudentIndexPage>(student);
            ViewBag.fname = studentDto.FirstName;
            ViewBag.lname = studentDto.LastName;
            ViewBag.stuid = student.Id;
            return View(student);
        }

        public IActionResult CreateStudent(List<stu> stus)
        {
            foreach (var s in stus)
            {
                Sturepo.AddStudent(s);
            }
           
            Sturepo.SaveStudent(true);

            // اگه سیو شد 
            return Ok();
        }

        public async Task<IActionResult> StudentEducations(int id)
        {
            //Logger.LogWarning(HttpContext.Request.Cookies.FirstOrDefault(e => e.Key == "id").Value.ToString());
            List<EducationDto> education = Mapper.Map<List<EducationDto>>(await Sturepo.StudentEducations(id));
            var edustu = await Sturepo.EduStus(id);
            foreach(EducationDto e in education)
            {
              //  e.Grade = edustu.FirstOrDefault(e => e.EducationId == e.EducationId).Grade;
            }
            return View(education);
        }

        public async Task<IActionResult> EducationGrades(int educationId)
        {
            List<int> lectureIds = (await Sturepo.StudentEducation(educationId)).Lectures.Select(e => e.Id).ToList();
            var stuid = int.Parse(HttpContext.Request.Cookies["id"]);
            Logger.LogWarning($"stuid = {stuid}");
            var education = await Sturepo.StudentGrade(educationId, lectureIds);
            return View(education);
        }

    }
}