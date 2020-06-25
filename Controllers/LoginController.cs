using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AdminLTEASPNETEmployees.Data;
using AdminLTEASPNETEmployees.Dtos;
using AdminLTEASPNETEmployees.HttpResponse;
using AdminLTEASPNETEmployees.Models;
using AdminLTEASPNETEmployees.EncryptPassword;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AdminLTEASPNETEmployees.Controllers
{
    public class LoginController : Controller
    {

        private readonly IEmployeesRepo _repository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _hosting;


        public LoginController(IEmployeesRepo repository, IMapper mapper, IWebHostEnvironment hosting)
        {
            _repository = repository;
            _mapper = mapper;
            _hosting = hosting;
        }

        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginDTO ad)
        {
            Employees emp = _repository.GetEmployeesByEmail(ad);


            if (emp == null)
            {
                Response response = new Response()
                {
                    IsSuccess = false,
                    ErrorCode = "401",
                    Message = "Email or password incorrect!"
                };
                return Json(JsonConvert.SerializeObject(response));
            }
            else
            {
                string passWord = Encrypt.EncryptPassword(ad.Password, emp.EmpSalt);
                if (emp.EmpPass == passWord)
                {

                    var userClaims = new List<Claim>()
                        {
                        new Claim("Email", emp.EmpEmail),
                        new Claim(ClaimTypes.NameIdentifier, emp.EmpId.ToString()),
                        new Claim(ClaimTypes.Role, emp.RoleId.ToString())
                        };

                    var userIdentity = new ClaimsIdentity(userClaims, "User Identity");

                    var userPrincipal = new ClaimsPrincipal(new[] { userIdentity });
                    HttpContext.SignInAsync(userPrincipal);
                    if (emp.RoleId == 1)
                    {
                        ResponseURL response = new ResponseURL()
                        {
                            IsSuccess = true,
                            ErrorCode = "200",
                            url = Url.Action("Index", "Home"),
                            Message = "Login successfully!"
                        };
                        return Json(JsonConvert.SerializeObject(response));
                    }
                    else
                    {
                        ResponseURL response = new ResponseURL()
                        {
                            IsSuccess = true,
                            ErrorCode = "200",
                            url = Url.Action("User", "User"),
                            Message = "Login successfully!"
                        };
                        return Json(JsonConvert.SerializeObject(response));
                    }

                }
                else
                {
                    Response response = new Response()
                    {
                        IsSuccess = false,
                        ErrorCode = "401",
                        Message = "Email or password incorrect!"
                    };
                    return Json(JsonConvert.SerializeObject(response));
                }
            }
        }

        [HttpGet]
        public ActionResult UserAccessDenied()
        {
            return View();
        }

        public IActionResult Logout()
        {
            foreach (var cookie in Request.Cookies.Keys)
            {
                Response.Cookies.Delete(cookie);
            }
            HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Login");
        }
    }
}
