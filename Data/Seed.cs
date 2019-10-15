using myschool.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using myschool.Dtos;
using AutoMapper;
using Newtonsoft.Json.Linq;

namespace myschool.Data
{
    public class Seed
    {
        public Seed(IStudentRepository stuRepo, ILogger<Seed> logger, DataContext context, IMapper mapper) {
            StuRepo = stuRepo;
            Logger = logger;
            Context = context;
            Mapper = mapper;
        }

        public IStudentRepository StuRepo { get; }
        public ILogger<Seed> Logger { get; }
        public DataContext Context { get; }
        public IMapper Mapper { get; }

        public async Task StudentSeeder()
        {
            string jsonFile = File.ReadAllText(@"D:\myschool\myschool\Data\StudentData.json");
            List<StudentIndexPage> stus = JsonConvert.DeserializeObject<List<StudentIndexPage>>(jsonFile);

            foreach(var s in stus)
            {
                var student = Mapper.Map<Student>(s);
                //Logger.LogInformation(s.FirstName);
                StuRepo.AddStudent(student);
            }

            await Context.SaveChangesAsync();
            //StuRepo.SaveStudent(true);
        }

        public void EducationSeeder()
        {
            string jsonfile = File.ReadAllText(@"D:\myschool\myschool\Data\Education.json");
            List<Education> educations = JsonConvert.DeserializeObject<List<Education>>(jsonfile);

            foreach(var e in educations)
            {
                Context.Add(e);
            }

            Context.SaveChanges();
        }

        public void LectureSeeder()
        {
            string jsonfile = File.ReadAllText(@"D:\myschool\myschool\Data\Lectures.json");
            List<Lecture> lectures = JsonConvert.DeserializeObject<List<Lecture>>(jsonfile);

            foreach (var l in lectures)
            {
                Context.Add(l);
            }

            Context.SaveChanges();
        }

        public void SeedImage()
        {
            string jsonfile = File.ReadAllText(@"D:\myschool\myschool\Data\StudentImage.json");
            JObject images = JObject.Parse(jsonfile);
            var students = Context.Students;
            // get JSON result objects into a list
            IList<JToken> results = images["results"].Children().ToList();
            int id = 1;
            foreach (JToken img in results)
            {
                //var image = img["picture"]["large"].ToString();
                students.Find(id).PhotoUrl = img["picture"]["large"].ToString();
                id++;
            }
            Context.SaveChanges();
        }

        public void SeedEduStu()
        {
            string jsonfile = File.ReadAllText(@"D:\myschool\myschool\Data\EduStu.json");
            List<EducStu> edustu = JsonConvert.DeserializeObject<List<EducStu>>(jsonfile);
            foreach (EducStu e in edustu)
            {
                Context.Add(e);
            }

            Context.SaveChanges();
        }

        public void SeedGrade()
        {
            string jsonfile = File.ReadAllText(@"D:\myschool\myschool\Data\Grade.json");
            List<Grade> grades = JsonConvert.DeserializeObject<List<Grade>>(jsonfile);
            foreach (Grade g in grades)
            {
                Context.Add(g);
            }

            Context.SaveChanges();
        }

    }
}
