using AdminLTEASPNETEmployees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTEASPNETEmployees.Data
{
    public class SqlEmployeesRepo : IEmployeesRepo
    {
        private readonly EmployeesContext _context;

        public SqlEmployeesRepo(EmployeesContext context)
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

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
