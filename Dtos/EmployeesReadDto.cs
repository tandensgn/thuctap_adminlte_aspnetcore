using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTEASPNETEmployees.Dtos
{
    public class EmployeesReadDto
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        public string EmpUsername { get; set; }
        public string EmpFullname { get; set; }
        [Required]
        public string EmpEmail { get; set; }
        [Required]
        public string EmpPhone { get; set; }
        public string EmpAddress { get; set; }
        public string EmpAvatar { get; set; }
        [Required]
        public string EmpRole { get; set; }
        [Required]
        public string EmpStatus { get; set; }
    }
}
