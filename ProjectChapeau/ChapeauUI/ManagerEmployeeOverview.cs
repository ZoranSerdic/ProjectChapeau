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
        Employee employee;
        private Employee selectedEmployee;
        private EmployeeService service;

        public ManagerEmployeeOverview(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            service = new EmployeeService();
            DisplayEmployees(service.GetAllEmployees());
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
            DisplayEmployees(service.GetAllEmployees());
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnToManagerView();
        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewEmployee newEmployee = new NewEmployee(this.employee);
            newEmployee.ShowDialog();
            this.Close();
        }
        private void ReturnToManagerView()
        {
            this.Hide();
            ManagerView managerView = new ManagerView(this.employee);
            managerView.ShowDialog();
            this.Close();
        }

        private void BtnRemoveEmployee_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BtnEditEmployee_Click(object sender, EventArgs e)
        {

            //checks first if there is a selected row 
            if (listViewEmployees.SelectedItems.Count > 0)
            {
                try
                {
                    this.selectedEmployee = new Employee();

                    ListViewItem selectedEmployee = listViewEmployees.SelectedItems[0];

                    //adds the menuID from the row to the menu Item 
                    this.selectedEmployee.EmployeeId = int.Parse(selectedEmployee.SubItems[0].Text);
                    this.selectedEmployee.FirstName = selectedEmployee.SubItems[1].Text;
                    this.selectedEmployee.LastName = selectedEmployee.SubItems[2].Text;
                    //to get the correct enum, first get it as a string, then convert and assign
                    string occupation = selectedEmployee.SubItems[3].Text;
                    this.selectedEmployee.Occupation = (Role)Enum.Parse(typeof(Role), occupation);
                    ChangeToEditEmployee(this.selectedEmployee);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("No Employee was selected", "Error");
            }
        }
        private void ChangeToEditEmployee(Employee selectedEmployee)
        {
            this.Hide();
            NewEmployee editEmployee = new NewEmployee(selectedEmployee, this.employee);
            editEmployee.ShowDialog();
            this.Close();
        }
    }
}
