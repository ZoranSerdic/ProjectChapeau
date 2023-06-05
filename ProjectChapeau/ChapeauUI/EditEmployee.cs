using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class EditEmployee : Form
    {
        private Employee employee;
        private Employee updatedEmployee;
        private EmployeeService employeeService;
        public EditEmployee(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.employeeService = new EmployeeService();
            PrefillForm();
        }
        private void PrefillForm()
        {
            //fills the form with the information provided by the employee 
            txtBoxFirstName.Text = employee.FirstName;
            txtBoxLastName.Text = employee.LastName;
            if (employee.Occupation == Role.Barman)
            {
                radBtnBartender.Checked = true;
            }
            else if (employee.Occupation == Role.Chef)
            {
                radBtnChef.Checked = true;
            }
            else
                radBtnWaiter.Checked = true;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirmation needed", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        CreateNewEmployee();
                        employeeService.UpdateEmployee(updatedEmployee);
                        dialogResult = MessageBox.Show("Action performed successfully", "success");
                        ReturnToEmployeeOverview();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                DisplayMessageBox("The form was not filled correctly");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToEmployeeOverview();
        }
        private void ReturnToEmployeeOverview()
        {
            this.Hide();
            ManagerEmployeeOverview overview = new ManagerEmployeeOverview();
            overview.ShowDialog();
            this.Close();
        }

        private void CreateNewEmployee()
        {
            updatedEmployee = new Employee();
            updatedEmployee.EmployeeId = employee.EmployeeId;
            updatedEmployee.FirstName = txtBoxFirstName.Text;
            updatedEmployee.LastName = txtBoxLastName.Text;
            updatedEmployee.Pincode = txtBoxPin2.Text;

            if (radBtnBartender.Checked)
            {
                updatedEmployee.Occupation = Role.Barman;
            }
            else if (radBtnChef.Checked)
            {
                updatedEmployee.Occupation = Role.Chef;
            }
            else
            {
                updatedEmployee.Occupation = Role.Waiter;
            }
        }
        private void DisplayMessageBox(string message)
        {
            DialogResult dialogResult = MessageBox.Show(message, "Error");
        }
        private bool CheckForm()
        {
            if (CheckNames() && CheckRadButons() && CheckPins())
            {
                return true;
            }
            return false;
        }
        private bool CheckPins()
        {
            if ((txtBoxPin1.Text == txtBoxPin2.Text) && CheckPinLength())
            {
                return true;
            }
            DisplayMessageBox("pins are not identical");
            txtBoxPin1.Text = string.Empty;
            txtBoxPin2.Text = string.Empty;
            return false;
        }
        private bool CheckPinLength()
        {
            if (txtBoxPin1.Text.Length == 4 && txtBoxPin2.Text.Length == 4)
            {
                return true;
            }
            DisplayMessageBox("pin has to be four digits");
            return false;
        }
        private bool CheckNames()
        {
            if (txtBoxFirstName.Text != "" && txtBoxLastName.Text != "")
            {
                return true;
            }
            else
            {
                DisplayMessageBox("invalid first or last name");
                return false;
            }
        }
        private bool CheckRadButons()
        {
            if (radBtnBartender.Checked || radBtnChef.Checked || radBtnWaiter.Checked)
            {
                return true;
            }
            else
            {
                DisplayMessageBox("no occupation was selected");
                return false;
            }
        }

        private void txtBoxPin1_TextChanged(object sender, EventArgs e)
        {
            //try to parse the input, if it is unsuccessful, the inside textbox is cleared
            if (!int.TryParse(txtBoxPin1.Text, out int result))
            {
                txtBoxPin1.Text = string.Empty;
            }
        }

        private void txtBoxPin2_TextChanged(object sender, EventArgs e)
        {
            //try to parse the input, if it is unsuccessful, the inside textbox is cleared 
            if (!int.TryParse(txtBoxPin1.Text, out int result))
            {
                txtBoxPin2.Text = string.Empty;
            }
        }
    }
}
