using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

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
    }
}
