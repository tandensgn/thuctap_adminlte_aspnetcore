using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AdminLTEASPNETEmployees.Models;
using Microsoft.EntityFrameworkCore.Internal;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using AdminLTEASPNETEmployees.Data;
using AdminLTEASPNETEmployees.Dtos;
using System.IO;

namespace AdminLTEASPNETEmployees.Controllers
{
    public class HomeController : Controller
    {

        EmployeesDBContext db = new EmployeesDBContext();
        private readonly IEmployeesRepo _repository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _hosting;
        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }

        public HomeController(IEmployeesRepo repository, IMapper mapper, IWebHostEnvironment hosting)
        {
            _repository = repository;
            _mapper = mapper;
            _hosting = hosting;
        }

        public IActionResult Index()
        {
            var employeeItems = _repository.GetAllEmployees();
            var employeeDTO = _mapper.Map<IEnumerable<EmployeesReadDto>>(employeeItems);
            return View(employeeDTO);
        }
        public IActionResult EmployeesList()
        {
            var employeeItems = _repository.GetAllEmployees();
            var employeeDto = _mapper.Map<IEnumerable<EmployeesReadDto>>(employeeItems);
            return PartialView("_EmployeesList", employeeDto);
        }
        [HttpPost]
        public IActionResult EditEmployee(EmployeesCreateDto em)
        {

            if (em.EmpAvatarStream != null)
            {
                var uniqueFileName = GetUniqueFileName(em.EmpAvatarStream.FileName);
                var uploads = Path.Combine(_hosting.WebRootPath, "images");
                var filePath = Path.Combine(uploads, uniqueFileName);
                em.EmpAvatarStream.CopyTo(new FileStream(filePath, FileMode.Create));

                //to do : Save uniqueFileName  to your db table   
                Employees employees = _mapper.Map<Employees>(em);
                employees.EmpAvatar = uniqueFileName;
                _repository.UpdateEmployee(employees);
                _repository.SaveChanges();
                return EmployeesList();

            }
            else
            {
                Employees employees = _repository.GetEmployeesById(em.EmpId);
                employees.EmpUsername = em.EmpUsername;
                employees.EmpPass = em.EmpPass;
                employees.EmpFullname = em.EmpFullname;
                employees.EmpPhone = em.EmpPhone;
                employees.EmpAddress = em.EmpAddress;
                employees.EmpRole = em.EmpRole;
                employees.EmpStatus = em.EmpStatus;
                _repository.UpdateEmployee(employees);
                _repository.SaveChanges();
                return EmployeesList();
            }
        }
        public IActionResult RemoveEmployee(int id)
        {

            Employees em = _repository.GetEmployeesById(id); 
            if (em.EmpAvatar != null)
            {
                var uploads = Path.Combine(_hosting.WebRootPath, "images");
                var filePath = Path.Combine(uploads, em.EmpAvatar);
                System.IO.File.Delete(filePath);
                _repository.RemoveEmployeeById(id);
                _repository.SaveChanges();

                return EmployeesList();
            }
            else
            {
                _repository.RemoveEmployeeById(id);
                _repository.SaveChanges();

                return EmployeesList();
            }
        }

        public IActionResult AddEmployee(EmployeesCreateDto em)
        {

            if (em.EmpAvatarStream != null)
            {
                var uniqueFileName = GetUniqueFileName(em.EmpAvatarStream.FileName);
                var uploads = Path.Combine(_hosting.WebRootPath, "images");
                var filePath = Path.Combine(uploads, uniqueFileName);
                em.EmpAvatarStream.CopyTo(new FileStream(filePath, FileMode.Create));

                //to do : Save uniqueFileName  to your db table   
                Employees employee = _mapper.Map<Employees>(em);
                employee.EmpAvatar = uniqueFileName;
                _repository.AddEmployee(employee);
                _repository.SaveChanges();
                return EmployeesList();

            }
            else
            {
                return EmployeesList();
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorView { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
