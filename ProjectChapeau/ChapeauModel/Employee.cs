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
        public string Hash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Occupation Occupation { get; set; }

        public Employee(int employeeId, string hash, string firstName, string lastName, Occupation occupation)
        {
            EmployeeId = employeeId;
            Hash = hash;
            FirstName = firstName;
            LastName = lastName;
            Occupation = occupation;
        }
    }
}
