using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminLTEASPNETEmployees.Data;
using AdminLTEASPNETEmployees.Dtos;
using AdminLTEASPNETEmployees.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AdminLTEASPNETEmployees.Controllers
{
    //api commands
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeesRepo _repository;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeesRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api commands
        [HttpGet]
        public ActionResult<IEnumerable<EmployeesReadDto>> GetAllEmployee()
        {
            var employeeItems = _repository.GetAllEmployees();
            return Ok(_mapper.Map<IEnumerable<EmployeesReadDto>>(employeeItems));
        }
        //GET api/employee/{id}
        [HttpGet("{id}", Name = "GetEmployeeById")]
        public ActionResult<EmployeesReadDto> GetEmployeeById(int id)
        {
            var employeeItems = _repository.GetEmployeesById(id);
            if (employeeItems != null)
            {
                return Ok(_mapper.Map<EmployeesReadDto>(employeeItems));
            }
            return NotFound();
        }
        //POST api/employee
        [HttpPost]
        public ActionResult<EmployeesReadDto> CreateEmployees(EmployeesCreateDto employeesCreateDto)
        {
            var employeesModel = _mapper.Map<Employees>(employeesCreateDto);
            _repository.CreateEmployee(employeesModel);
            _repository.SaveChanges();

            var employeesReadDto = _mapper.Map<EmployeesReadDto>(employeesModel);

            return CreatedAtRoute(nameof(GetEmployeeById), new { Id = employeesReadDto.EmpId }, employeesReadDto);

        }
    }
}