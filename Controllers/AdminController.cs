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
using AdminLTEASPNETEmployees.CustomHandler;

namespace AdminLTEASPNETEmployees.Controllers
{
    [Authorize(Roles = "1")]
    public class AdminController : Controller
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
        public AdminController(IEmployeesRepo repository, IMapper mapper, IWebHostEnvironment hosting)
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
        // Profile //
        public IActionResult Profile()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Employees em = _repository.GetEmployeesById(Int32.Parse(userId));
            EmployeesReadDto emDTO = _mapper.Map<EmployeesReadDto>(em);
            return View(emDTO);
        }
        // Edit Admin //
        [HttpPost]
        public IActionResult EditAdmin(EmployeesCreateDto em)
        {
            var userId = Int16.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            if (em.EmpAvatarStream != null)
            {

                var uniqueFileName = FileManager.GetUniqueFileName(em.EmpAvatarStream.FileName);
                var uploads = Path.Combine(_hosting.WebRootPath, "images");
                var filePath = Path.Combine(uploads, uniqueFileName);
                em.EmpAvatarStream.CopyTo(new FileStream(filePath, FileMode.Create));

                //to do : Save uniqueFileName  to your db table   
                Employees employee = _mapper.Map<Employees>(em);

                employee.EmpAvatar = uniqueFileName;
                employee.EmpPhone = em.EmpPhone;
                employee.EmpStatus = "Active";
                employee.EmpAddress = em.EmpAddress;
                employee.EmpEmail = em.EmpEmail;
                employee.EmpFullname = em.EmpFullname;
                employee.RoleId = 1;
                employee.EmpId = userId;

                _repository.UpdateEmployee(employee);
                _repository.SaveChanges();
            }
            else
            {
                Employees employee = _repository.GetAdmin(userId);
                employee.EmpPhone = em.EmpPhone;
                employee.EmpStatus = "Active";
                employee.EmpAddress = em.EmpAddress;
                employee.EmpEmail = em.EmpEmail;
                employee.EmpFullname = em.EmpFullname;
                employee.RoleId = 1;

                _repository.UpdateEmployee(employee);
                _repository.SaveChanges();
            }
            Response response = new Response()
            {
                IsSuccess = true,

                Message = "Change information successfully!"
            };
            return Json(JsonConvert.SerializeObject(response));
        }

        // Showlist All Employees //
        public IActionResult EmployeesList()
        {
            var employeeItems = _repository.GetAllEmployees();
            var employeeDto = _mapper.Map<IEnumerable<EmployeesReadDto>>(employeeItems);
            return PartialView("_EmployeesList", employeeDto);
        }

        // Add Employee //
        public IActionResult AddEmployee(EmployeesCreateDto em)
        {
            Employees employee = _mapper.Map<Employees>(em);
            if (em.EmpAvatarStream != null)
            {
                var uniqueFileName = GetUniqueFileName(em.EmpAvatarStream.FileName);
                var uploads = Path.Combine(_hosting.WebRootPath, "images");
                var filePath = Path.Combine(uploads, uniqueFileName);
                em.EmpAvatarStream.CopyTo(new FileStream(filePath, FileMode.Create));
                employee.EmpAvatar = uniqueFileName;
            }
            //to do : Save uniqueFileName  to your db table
            string salt = Encrypt.GenerateSaltForPassword();
            string hashPass = Encrypt.EncryptPassword(employee.EmpPass, salt).ToString();
            employee.EmpPass = hashPass;
            employee.EmpSalt = salt.ToString();
            employee.RoleId = 2;
            _repository.AddEmployee(employee);
            _repository.SaveChanges();
            return EmployeesList();
        }

        // Remove Employee //
        [HttpPost]
        public IActionResult RemoveEmployee(int id)
        {

            Employees em = _repository.GetEmployeesById(id);
            if (em.EmpAvatar != null)
            {
                // Find and delete images file in server

                //var uploads = Path.Combine(_hosting.WebRootPath, "images");
                //var filePath = Path.Combine(uploads, em.EmpAvatar);
                //System.IO.File.Delete(filePath);
                //_repository.RemoveEmployeeById(id);
                //_repository.SaveChanges();
                //return EmployeesList();

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
            Employees employee = _repository.GetEmployeesById(em.EmpId);
            if (em.EmpAvatarStream != null)
            {
                var uniqueFileName = FileManager.GetUniqueFileName(em.EmpAvatarStream.FileName);
                var uploads = Path.Combine(_hosting.WebRootPath, "images");
                var filePath = Path.Combine(uploads, uniqueFileName);
                em.EmpAvatarStream.CopyTo(new FileStream(filePath, FileMode.Create));

                //to do : Save uniqueFileName  to your db table   

                employee.EmpAvatar = uniqueFileName;
            }
            employee.EmpUsername = em.EmpUsername;
            employee.EmpFullname = em.EmpFullname;
            employee.EmpEmail = em.EmpEmail;
            employee.EmpPhone = em.EmpPhone;
            employee.EmpAddress = em.EmpAddress;
            employee.EmpStatus = "Active";
            employee.RoleId = 2;

            _repository.UpdateEmployee(employee);
            _repository.SaveChanges();
            return EmployeesList();
        }

        // Change password //
        [HttpPost]
        public IActionResult PasswordEmployee(EmployeesCreateDto em)
        {
            Employees employee = _repository.GetEmployeesById(em.EmpId);

            string salt = Encrypt.GenerateSaltForPassword();
            string hashPass = Encrypt.EncryptPassword(em.EmpPass, salt).ToString();
            employee.EmpPass = hashPass;
            employee.EmpSalt = salt.ToString();

            _repository.UpdateEmployee(employee);
            _repository.SaveChanges();
            return EmployeesList();
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
