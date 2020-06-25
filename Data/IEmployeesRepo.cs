using AdminLTEASPNETEmployees.Dtos;
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
        Employees GetEmployeesByEmail(LoginDTO user);
        // Add Employee to Database
        void AddEmployee(Employees em);
        // Edit Employee in Database
        void UpdateEmployee(Employees em);
        // Remove Employee by id
        void RemoveEmployeeById(int id);
        // Save changes
        void SaveChanges();
    }
}
