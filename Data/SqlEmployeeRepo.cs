using AdminLTEASPNETEmployees.Dtos;
using AdminLTEASPNETEmployees.Models;
using AdminLTEASPNETEmployees.EncryptPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTEASPNETEmployees.Data
{
    public class SqlEmployeesRepo : IEmployeesRepo
    {
        private readonly EmployeesDBContext _context;

        public SqlEmployeesRepo(EmployeesDBContext context)
        {
            _context = context;
        }

        public void CreateEmployee(Employees emp)
        {
            if(emp == null)
            {
                throw new ArgumentNullException(nameof(emp));
            }

            _context.Employees.Add(emp);
        }

        public IEnumerable<Employees> GetAllEmployees()
        {
            return _context.Employees.Where(u => (u.RoleId == 2) && (u.EmpStatus == "Active")).ToList();
        }


        public Employees GetEmployeesById(int id)
        {
            return _context.Employees.FirstOrDefault(p => p.EmpId == id);
        }

        public Employees GetEmployeesByEmail(LoginDTO user)
        {
            return _context.Employees.Where(u => (u.EmpEmail == user.Email)).FirstOrDefault();
        }

        public void RemoveEmployeeById(int id)
        {
            _context.Employees.Remove(_context.Employees.FirstOrDefault(p => p.EmpId == id));
        }

        public void UpdateEmployee(Employees em)
        {
            _context.Update(em);
        }
        public void AddEmployee(Employees em)
        {
            _context.Employees.Add(em);
        }
        public Employees GetAdmin(int id)
        {
            return _context.Employees.FirstOrDefault(p => (p.EmpId == id) && (p.RoleId == 1));
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
