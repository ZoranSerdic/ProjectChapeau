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
        private Employee selectedEmployee;
        private EmployeeService service;
        private List<Employee> employees;  
        
        public ManagerEmployeeOverview()
        {
            InitializeComponent();
            service = new EmployeeService();
            employees = new List<Employee>();
            employees.AddRange(service.GetAllEmployees());

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
        private void UpdateListView()
        {
            listViewEmployees.Clear();
            employees.Clear();  
            employees.AddRange(service.GetAllEmployees());
            DisplayEmployees(employees);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnToManagerView();
        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewEmployee newEmployee = new NewEmployee();
            newEmployee.ShowDialog();
            this.Close();
        }
        private void ReturnToManagerView()
        {
            this.Hide();
            ManagerView managerView = new ManagerView();
            managerView.ShowDialog();
            this.Close();
        }

        private void BtnRemoveEmployee_Click(object sender, EventArgs e)
        {
            //checks first if there is a selected row 
            if (listViewEmployees.SelectedItems.Count > 0)
            {
                selectedEmployee = new Employee();
                ListViewItem selectedListViewItemRow = listViewEmployees.SelectedItems[0];

                //adds the menuID from the row to the menu Item 
                selectedEmployee.EmployeeId = int.Parse(selectedListViewItemRow.SubItems[0].Text);

                //double checks action 
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirmation needed", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    service.RemoveEmployee(selectedEmployee);
                    UpdateListView();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("No Employee was selected", "Error");
            }
        }
    }
}
