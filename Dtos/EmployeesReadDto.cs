using AdminLTEASPNETEmployees.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTEASPNETEmployees.Dtos
{
    // Form to show data output
    public class EmployeesReadDto
    {
        public int EmpId { get; set; }
        public string EmpUsername { get; set; }
        public string EmpEmail { get; set; }
        public string EmpPass { get; set; }
        public string EmpFullname { get; set; }
        public string EmpPhone { get; set; }
        public string EmpAddress { get; set; }
        public string EmpAvatar { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string EmpStatus { get; set; }
        public string EmpSalt { get; set; }

        public virtual EmpRole Role { get; set; }
    }
}
