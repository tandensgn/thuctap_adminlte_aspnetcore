using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTEASPNETEmployees.Dtos
{
    public class EmployeesCreateDto
    {
        public int EmpId { get; set; }
        public string EmpUsername { get; set; }
        public string EmpFullname { get; set; }
        public string EmpEmail { get; set; }
        public string EmpPhone { get; set; }
        public string EmpPass { get; set; }
        public string EmpAddress { get; set; }
        public IFormFile EmpAvatarStream { get; set; }
        public string EmpRole { get; set; }
        public string EmpStatus { get; set; }
    }
}
