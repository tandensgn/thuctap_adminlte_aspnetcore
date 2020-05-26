using AdminLTEASPNETEmployees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTEASPNETEmployees.Data
{
    public interface IEmployeesRepo
    {
        IEnumerable<Employees> GetAllEmployees();
        Employees GetEmployeesById(int id);
        void AddEmployee(Employees em);
        void UpdateEmployee(Employees em);
        void RemoveEmployeeById(int id);
        void SaveChanges();
    }
}
