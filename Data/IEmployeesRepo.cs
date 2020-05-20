using AdminLTEASPNETEmployees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTEASPNETEmployees.Data
{
    public interface IEmployeesRepo
    {
        bool SaveChanges();


        IEnumerable<Employees> GetAllEmployees();
        Employees GetEmployeesById(int id);
        void CreateEmployee(Employees emp);
    }
}
