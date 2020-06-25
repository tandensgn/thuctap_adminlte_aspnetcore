using AdminLTEASPNETEmployees.Data;
using AdminLTEASPNETEmployees.Dtos;
using AdminLTEASPNETEmployees.Models;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AdminLTEASPNETEmployees.ViewComponents
{
    public class SideNavViewComponent
    {
        private readonly IEmployeesRepo _repository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _hosting;

        public SideNavViewComponent(IEmployeesRepo repository, IMapper mapper, IWebHostEnvironment hosting)
        {
            _repository = repository;
            _mapper = mapper;
            _hosting = hosting;

        }

        //public IViewComponentResult Invoke()
        //{
        //    var user = User as ClaimsPrincipal;
        //    string userId = user.FindFirstValue(ClaimTypes.NameIdentifier);
        //    Employees em = _repository.GetEmployeesById(Int16.Parse(userId));
        //    EmployeesReadDto emDTO = _mapper.Map<EmployeesReadDto>(em);

        //    return View(emDTO);
        //}
    }
}
