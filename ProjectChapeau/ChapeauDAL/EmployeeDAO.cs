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
    internal class EmployeeDAO: BaseDAO
    {
        public List<Employee> GetAllEmployees()
        {
            //gathering all employees from the table
            string query = ""; //insert sql query here 
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee()
                {
                    EmployeeId = (int)dr["EmployeeID"],
                    FirstName = dr["FirstName"].ToString(),
                    LastName = dr["LastName"].ToString(),
                    Pincode = dr["Pincode"].ToString(),
                    Occupation = dr["Role"].ToString()   
                    //occupation is an enum, instead of a string 
                };
                employees.Add(employee);
            }
            return employees;
        }
    }
}
