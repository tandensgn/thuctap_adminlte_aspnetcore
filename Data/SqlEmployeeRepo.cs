using AdminLTEASPNETEmployees.Models;
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
           return _context.Employees.ToList();
        }


        public Employees GetEmployeesById(int id)
        {
            return _context.Employees.FirstOrDefault(p => p.EmpId == id);
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
         
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
