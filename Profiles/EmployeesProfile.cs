using AdminLTEASPNETEmployees.Dtos;
using AdminLTEASPNETEmployees.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTEASPNETEmployees.Profiles
{
    public class EmployeesProfile : Profile
    {
        public EmployeesProfile()
        {
            //Source -> Target
            CreateMap<Employees, EmployeesReadDto>();
            CreateMap<EmployeesCreateDto, Employees>();
        }
    }
}
