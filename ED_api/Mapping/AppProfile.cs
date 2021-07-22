using System;
using AutoMapper;
using ED_api.Models;

namespace ED_api.Mapping
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<Employee, EmployeeDTO>();
            CreateMap<Praise, PraiseDTO>();
        }
    }
}
