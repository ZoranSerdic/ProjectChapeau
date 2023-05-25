using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Pincode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Occupation { get; set; }

        public Employee()
        {
            // constructor without any parameters 
        }
        public Employee(int employeeId, string pincode, string firstName, string lastName, Role occupation)
        {
            EmployeeId = employeeId;
            Pincode = pincode;
            FirstName = firstName;
            LastName = lastName;
            Occupation = occupation;
        }

    }
}
