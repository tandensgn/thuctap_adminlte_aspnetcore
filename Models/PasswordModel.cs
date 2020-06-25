using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTEASPNETEmployees.Models
{
    public class PasswordModel
    {
        public int passId { get; set; }
        public string currentPassword { get; set; }
        public string newPassword { get; set; }
        public string confirmPassword { get; set; }
    }
}
