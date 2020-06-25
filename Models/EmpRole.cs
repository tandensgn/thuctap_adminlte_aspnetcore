using System;
using System.Collections.Generic;

namespace AdminLTEASPNETEmployees.Models
{
    public partial class EmpRole
    {
        public EmpRole()
        {
            Employees = new HashSet<Employees>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
