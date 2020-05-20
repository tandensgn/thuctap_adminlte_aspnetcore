//using AdminLTEASPNETEmployees.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace AdminLTEASPNETEmployees.Data
//{
//    public class MockEmployeesRepo : IEmployeesRepo
//    {
//        public void CreateEmployee(Employees emp)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<Employees> GetAllEmployees()
//        {
//            var employees = new List<Employees>
//            {
//                new Employees
//            {
//                EmpId = 0,
//                EmpUsername = "tandensgn",
//                EmpFullname = "Le Ho Phuc Tan",
//                EmpEmail = "email1@gmail.com",
//                EmpPhone = "0909009000",
//                EmpPass = "123",
//                EmpAddress = "Quan 12",
//                EmpAvatar = "~/asset/img/1.jpg",
//                EmpRole = "Admin",
//                EmpStatus = "Active"
//            },
//                new Employees
//            {
//                EmpId = 0,
//                EmpUsername = "congchan",
//                EmpFullname = "Nguyen Thanh Cong",
//                EmpEmail = "email2@gmail.com",
//                EmpPhone = "0909009001",
//                EmpPass = "124",
//                EmpAddress = "Quan 12",
//                EmpAvatar = "~/asset/img/2.jpg",
//                EmpRole = "Normal User",
//                EmpStatus = "DeActive"
//            }
//            };
//            return employees;
//        }

//        public Employees GetEmployeesById(int id)
//        {
//            return new Employees
//            {
//                EmpId = 0,
//                EmpUsername = "tandensgn",
//                EmpFullname = "Le Ho Phuc Tan",
//                EmpEmail = "email1@gmail.com",
//                EmpPhone = "0909009000",
//                EmpPass = "123",
//                EmpAddress = "Quan 12",
//                EmpAvatar = "~/asset/img/1.jpg",
//                EmpRole = "Admin",
//                EmpStatus = "Active"
//            };
//        }

//        public bool SaveChanges()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
