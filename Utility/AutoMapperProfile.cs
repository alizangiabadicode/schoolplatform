using AutoMapper;
using myschool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myschool.Dtos;
namespace myschool.Utility
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, StudentIndexPage>().ReverseMap();
            CreateMap<Lecture, LectureDto>();
            CreateMap<Education, EducationDto>();
        }
    }
}
