using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdminLTEASPNETEmployees.Models
{
    public partial class Employees
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        public string EmpUsername { get; set; }
        public string EmpFullname { get; set; }
        [Required]
        public string EmpEmail { get; set; }
        public string EmpPhone { get; set; }
        [Required]
        public string EmpPass { get; set; }
        public string EmpAddress { get; set; }
        public string EmpAvatar { get; set; }
        [Required]
        public string EmpRole { get; set; }
        [Required]
        public string EmpStatus { get; set; }
    }
}
