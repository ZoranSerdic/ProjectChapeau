using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class EmployeeDAO : BaseDAO
    {
        public List<Employee> GetAllEmployees()
        {
            //gathering all employees from the table
            string query = "SELECT employeeId, [hash], firstname, lastname, occupation FROM Employee;";
            return ReadTables(ExecuteSelectQuery(query));
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
        public void UpdateEmployee(Employee employee)
        {
            //this method updates existing employees 
            string query = "UPDATE Employee SET firstname = @firstName, lastName = @lastname, [occupation] = @occupation, [hash] = @hash WHERE employeeId = @EmployeeId;";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@firstname", employee.FirstName);
            sqlParameters[1] = new SqlParameter("@lastname", employee.LastName);
            sqlParameters[2] = new SqlParameter("@hash", employee.Pincode);
            sqlParameters[3] = new SqlParameter("@EmployeeId", employee.EmployeeId);
            sqlParameters[4] = new SqlParameter("@occupation", employee.Occupation);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void RemoveEmployee(Employee employee)
        {
            string query = "DELETE FROM Employee WHERE employeeId = @employeeID;";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@employeeID", employee.EmployeeId);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void AddEmployee(Employee employee)
        {
            //this method adds the item into the menu Item table 
            string query = "INSERT INTO Employee([hash], firstname, lastname, occupation) VALUES(@hash,@FirstName,@LastName,@Occupation);";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@Occupation", employee.Occupation);
            sqlParameters[1] = new SqlParameter("@FirstName", employee.FirstName);
            sqlParameters[2] = new SqlParameter("@LastName", employee.LastName);
            sqlParameters[3] = new SqlParameter("@hash", employee.Pincode);
            ExecuteEditQuery(query, sqlParameters);
        }

        public Employee GetEmployeeById(int employeeId)
        {
            string query = @"SELECT employeeId, [hash], firstname, lastname, occupation FROM Employee
                           WHERE EmployeeId = @EmployeeId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@EmployeeId", employeeId);

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                Employee employee = ReadEmployee(dataRow);
                return employee;
            }
            throw new Exception($"Employee with the {employeeId} id was not found!");
    }

        private Employee ReadEmployee(DataRow dataRow)
        {
            Employee employee = new Employee
            {
                EmployeeId = (int)dataRow["employeeId"],
                Pincode = (string)dataRow["hash"],
                FirstName = (string)dataRow["firstName"],
                LastName = (string)dataRow["lastName"],
                Occupation = (Role)Enum.Parse(typeof(Role), dataRow["occupation"].ToString(), ignoreCase: true)
            };
            return employee;
        } 
    }
}
