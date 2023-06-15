using ChapeauModel;
using ChapeauService;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChapeauUI
{
    public partial class NewEmployee : Form
    {
        Employee employeeForConstructors;
        private Employee newEmployee;
        private Employee employeeToUpdate;
        private EmployeeService service;
        private bool update;
        public NewEmployee(Employee employee)
        {
            InitializeComponent();
            this.employeeForConstructors = employee;
            service = new EmployeeService();
            update = false;
        }
        public NewEmployee(Employee employeeToUpdate, Employee employee)
        {
            InitializeComponent();
            this.employeeForConstructors = employee;
            this.employeeToUpdate = employeeToUpdate;
            service = new EmployeeService();
            update = true;
            PrefillForm();
        }
        private void PrefillForm()
        {
            //fills the form with the information provided by the employee 
            txtBoxFirstName.Text = employeeToUpdate.FirstName;
            txtBoxLastName.Text = employeeToUpdate.LastName;
            if (employeeToUpdate.Occupation == Role.Barman)
            {
                radBtnBartender.Checked = true;
            }
            else if (employeeToUpdate.Occupation == Role.Chef)
            {
                radBtnChef.Checked = true;
            }
            else
                radBtnWaiter.Checked = true;
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckForm())
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirmation needed", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        CreateNewEmployee();
                        if (!update)
                        {
                            service.AddEmployee(newEmployee);
                        }
                        else
                        {
                            service.UpdateEmployee(newEmployee);
                        }
                        dialogResult = MessageBox.Show("Action performed successfully", "success");
                        ReturnToEmployeeOverview();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void CreateNewEmployee()
        {
            newEmployee = new Employee();
            if (update)
            {
                newEmployee.EmployeeId = employeeToUpdate.EmployeeId;
            }
            newEmployee.FirstName = txtBoxFirstName.Text;
            newEmployee.LastName = txtBoxLastName.Text;
            newEmployee.Pincode = service.Hash(txtBoxPin2.Text);

            if (radBtnBartender.Checked)
            {
                newEmployee.Occupation = Role.Barman;
            }
            else if (radBtnChef.Checked)
            {
                newEmployee.Occupation = Role.Chef;
            }
            else
            {
                newEmployee.Occupation = Role.Waiter;
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
            DisplayMessageBox("the pins were not the same");
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
            DisplayMessageBox("pins have to be four digits");
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
                DisplayMessageBox("error with the names");
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
                DisplayMessageBox("error with the occupaion");
                return false;
            }
        }

        //making sure that the pins are only numbers 
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


        //methods for returning 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToEmployeeOverview();
        }
        private void ReturnToEmployeeOverview()
        {
            this.Hide();
            ManagerEmployeeOverview overview = new ManagerEmployeeOverview(this.employeeForConstructors);
            overview.ShowDialog();
            this.Close();
        }
    }
}
