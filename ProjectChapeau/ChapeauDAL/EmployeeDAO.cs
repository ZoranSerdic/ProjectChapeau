using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    public class EmployeeDAO: BaseDAO
    {
        public List<Employee> GetAllEmployees()
        {
            //gathering all employees from the table
            string query = "SELECT employeeId, [hash], firstname, lastname, occupation FROM Employee;";  
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Employee> ReadTables(DataTable dataTable)
        {
            //this methods gets all the employees in a list from the database 
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows)
            {
                //gets the occupation firstly as a string
                string occupationString = dr["occupation"].ToString();

                //creates the new employee with all the information from the table
                Employee employee = new Employee()
                {
                    //occupationString is then converted into the correct Role Enum
                    Occupation = (Role)Enum.Parse(typeof(Role), occupationString),
                    EmployeeId = (int)dr["employeeID"],
                    FirstName = dr["firstname"].ToString(),
                    LastName = dr["lastname"].ToString(),
                    Pincode = dr["hash"].ToString(),
                };
                //adds the employee to the list of all employees 
                employees.Add(employee);
            }
            //finally all employees are returned in a list 
            return employees;
        }
    }
}
