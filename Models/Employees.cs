using System;
using System.Collections.Generic;

namespace AdminLTEASPNETEmployees.Models
{
    public partial class Employees
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
        public string EmpStatus { get; set; }
        public string EmpSalt { get; set; }
        public virtual EmpRole Role { get; set; }
    }
}
