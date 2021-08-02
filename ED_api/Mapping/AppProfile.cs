using System;
using AutoMapper;
using ED_api.Models;
using ED_api.ViewModels;

namespace ED_api.Mapping
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<Praise, PraiseDTO>().ReverseMap();
        }
    }
}
