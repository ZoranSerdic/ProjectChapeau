using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;
using System.Security.Cryptography;

namespace ChapeauService
{
    public class EmployeeService
    {
        EmployeeDAO employeeDao;
        public EmployeeService()
        {
            employeeDao = new EmployeeDAO();
        }
        //passes on all the employees 
        public List<Employee> GetAllEmployees()
        {
            return employeeDao.GetAllEmployees();  
        }
        public void RemoveEmployee(Employee employee)
        {
            employeeDao.RemoveEmployee(employee);
        }
        public void AddEmployee(Employee employee)
        {
            employeeDao.AddEmployee(employee);
        }
        public void UpdateEmployee(Employee employee)
        {
            employeeDao.UpdateEmployee(employee);
        }
        public Employee GetEmployeeByPassword(string employeePassword)
        {
            return employeeDao.GetEmployeeByPassword(employeePassword);
        }
        public string Hash(string password)
        {
            var sha = SHA256.Create();

            var asByteArray = Encoding.Default.GetBytes(password);
            var hashedPassword = sha.ComputeHash(asByteArray);

            return Convert.ToBase64String(hashedPassword);
        }
    }
}
