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
using Microsoft.AspNetCore.Authorization;
using AdminLTEASPNETEmployees.EncryptPassword;
using System.Security.Claims;
using AdminLTEASPNETEmployees.HttpResponse;
using Newtonsoft.Json;
using LazZiya.ImageResize;
using System.Drawing;

namespace AdminLTEASPNETEmployees.Controllers
{
    [Authorize(Roles = "1")]
    public class HomeController : Controller
    {
        // Database //
        EmployeesDBContext db = new EmployeesDBContext();
        private readonly IEmployeesRepo _repository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _hosting;

        // Get Unique File Name //
        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }

        // Repository, Mapper, hosting //
        public HomeController(IEmployeesRepo repository, IMapper mapper, IWebHostEnvironment hosting)
        {
            _repository = repository;
            _mapper = mapper;
            _hosting = hosting;
        }

        // Index //
        public IActionResult Index()
        {
            var employeeItems = _repository.GetAllEmployees();
            var employeeDTO = _mapper.Map<IEnumerable<EmployeesReadDto>>(employeeItems);
            return View(employeeDTO);
        }

        // Showlist All Employees //
        public IActionResult EmployeesList()
        {
            var employeeItems = _repository.GetAllEmployees();
            var employeeDto = _mapper.Map<IEnumerable<EmployeesReadDto>>(employeeItems);
            return PartialView("_EmployeesList", employeeDto);
        }


        // Remove Employee //
        [HttpPost]
        public IActionResult RemoveEmployee(int id)
        {

            Employees em = _repository.GetEmployeesById(id);
            if (em.EmpAvatar != null)
            {
                // Find and delete images file in server
                var uploads = Path.Combine(_hosting.WebRootPath, "images");
                var filePath = Path.Combine(uploads, em.EmpAvatar);
                System.IO.File.Delete(filePath);
                _repository.RemoveEmployeeById(id);
                _repository.SaveChanges();
                return EmployeesList();
            }
            else
            {
                // Remove items don't have image
                _repository.RemoveEmployeeById(id);
                _repository.SaveChanges();
                return EmployeesList();
            }
        }


        // Edit Employees //
        [HttpPost]
        public IActionResult EditEmployee(EmployeesCreateDto em)
        {

            if (em.EmpAvatarStream != null)
            {
                // Rename images file, upload file and copy to server
                var uniqueFileName = GetUniqueFileName(em.EmpAvatarStream.FileName);
                var uploads = Path.Combine(_hosting.WebRootPath, "images");
                var filePath = Path.Combine(uploads, uniqueFileName);
                em.EmpAvatarStream.CopyTo(new FileStream(filePath, FileMode.Create));

                // to do : Save uniqueFileName  to your db table   
                Employees employees = _mapper.Map<Employees>(em);
                employees.EmpAvatar = uniqueFileName;
                string salt = Encrypt.GenerateSaltForPassword();
                string hashPass = Encrypt.EncryptPassword(employees.EmpPass, salt).ToString();
                employees.EmpPass = hashPass;
                employees.EmpSalt = salt.ToString();
                employees.RoleId = 2;
                _repository.UpdateEmployee(employees);
                _repository.SaveChanges();
                return EmployeesList();

            }
            else
            {
                // Change edit infor and keep unchange ones
                Employees employees = _repository.GetEmployeesById(em.EmpId);
                employees.EmpUsername = em.EmpUsername;
                employees.EmpPass = em.EmpPass;
                employees.EmpFullname = em.EmpFullname;
                employees.EmpPhone = em.EmpPhone;
                employees.EmpAddress = em.EmpAddress;
                employees.RoleId = em.RoleId;
                employees.EmpStatus = em.EmpStatus;
                employees.EmpSalt = em.EmpSalt;
                _repository.UpdateEmployee(employees);
                _repository.SaveChanges();
                return EmployeesList();
            }
        }

        // Change password //
        [HttpPost]
        public IActionResult PasswordEmployee(PasswordModel pass)
        {

            Employees emp = _repository.GetEmployeesById(pass.passId);

            if (pass.newPassword == pass.confirmPassword)
            {
                string salt = Encrypt.GenerateSaltForPassword();
                string newHashPassword = Encrypt.EncryptPassword(pass.newPassword, salt);
                emp.EmpPass = newHashPassword;
                emp.EmpSalt = salt;
                _repository.UpdateEmployee(emp);
                _repository.SaveChanges();
                Response response = new Response()
                {
                    IsSuccess = true,

                    Message = "Change password successfully!"
                };
                return Json(JsonConvert.SerializeObject(response));
            }
            else
            {
                Response response = new Response()
                {
                    IsSuccess = false,
                    ErrorCode = "401",
                    Message = "Incorrect password!"
                };
                return Json(JsonConvert.SerializeObject(response));
            }
        }

        // Add Employee //
        public IActionResult AddEmployee(EmployeesCreateDto em)
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
                string salt = Encrypt.GenerateSaltForPassword();
                string hashPass = Encrypt.EncryptPassword(employees.EmpPass, salt).ToString();
                employees.EmpPass = hashPass;
                employees.EmpSalt = salt.ToString();
                employees.RoleId = 2;
                _repository.AddEmployee(employees);
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


        public IActionResult Calendar(int id)
        {
            //var email = _repository.GetApprovedEmail(id);
            //var em = _repository.GetEmployeeById(id);
            //List<DateTime> days = new List<DateTime>();
            //int totaldaysoff = 0;
            //foreach (var item in email)
            //{

            //    totaldaysoff += (item.EndTime.Value - item.StartTime.Value).Days + 1;
            //    for (DateTime date = item.StartTime.Value; date <= item.EndTime.Value; date = date.AddDays(1))
            //        days.Add(date);

            //}
            //// days.Reverse();
            //DaysOffDTO daysOffDTO = new DaysOffDTO()
            //{
            //    EmName = em.FullName,
            //    totalDaysOff = totaldaysoff,
            //    daysLeft = 10 - totaldaysoff,
            //    days = days
            //};


            return View(/*daysOffDTO*/);
        }
    }
}
