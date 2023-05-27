using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauService;

namespace ChapeauUI
{
    public partial class ManagerEmployeeOverview : Form
    {
        public ManagerEmployeeOverview()
        {
            InitializeComponent();
            List<Employee> employees = new List<Employee>();
            EmployeeService employeeService = new EmployeeService();
            employees.AddRange(employeeService.GetAllEmployees());

            DisplayEmployees(employees);
        }

        //fills the listview with all the employees 
        public void DisplayEmployees(List<Employee> employees)
        {
            //clear the listview before filling it
            listViewEmployees.Clear();

            //adding the columns
            listViewEmployees.Columns.Add("Employee ID", 110);
            listViewEmployees.Columns.Add("First Name", 140);
            listViewEmployees.Columns.Add("Last Name", 140);
            listViewEmployees.Columns.Add("Occupation", 140);

            //adding the rows to the listview
            foreach (Employee employee in employees)
            {
                ListViewItem li = new ListViewItem(employee.EmployeeId.ToString());
                li.SubItems.Add(employee.FirstName);
                li.SubItems.Add(employee.LastName);
                li.SubItems.Add(employee.Occupation.ToString());
                li.Tag = employee;
                listViewEmployees.Items.Add(li);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerView managerView = new ManagerView();
            managerView.ShowDialog();
            this.Close();
        }
    }
}
