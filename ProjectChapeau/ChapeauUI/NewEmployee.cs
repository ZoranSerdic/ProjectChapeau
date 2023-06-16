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
        //needed for the login 
        Employee employeeForConstructors;
        //employee passed on which will be updated 
        private Employee employeeToUpdate;
        private EmployeeService service;
        //form used for updating or adding an employee 
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
                        Employee employee = new Employee();
                        CreateEmployee(employee);
                        if (!update)
                        {
                            //uses the service to add an employee to the database
                            service.AddEmployee(employee);
                        }
                        else
                        {
                            //uses the service layer to update an existing employee in the database 
                            service.UpdateEmployee(employee);
                        }
                        ReturnToEmployeeOverview();
                    }
                }
            }
            catch (Exception exception)
            {
                DisplayErrorMessageBox(exception.Message);
            }
        }
        private Employee CreateEmployee(Employee employee)
        {
            if (update)
            {
                //if you are updating an employee, pass on the ID 
                employee.EmployeeId = employeeToUpdate.EmployeeId;
            }
            //adding all the information 
            employee.FirstName = txtBoxFirstName.Text;
            employee.LastName = txtBoxLastName.Text;
            //Hashing the password via the service layer 
            employee.Pincode = service.Hash(txtBoxPin2.Text);
            //checking the radioButtons, and adding the role accordingly 
            if (radBtnBartender.Checked)
            {
                employee.Occupation = Role.Barman;
            }
            else if (radBtnChef.Checked)
            {
                employee.Occupation = Role.Chef;
            }
            else
            {
                employee.Occupation = Role.Waiter;
            }
            return employee;
        }

        private void DisplayErrorMessageBox(string message)
        {
            //displays the message with the Error heading
            MessageBox.Show(message, "Error");
        }
        private bool CheckForm()
        {
            //checks if the entire form is correct
            if (CheckNames() && CheckRadButons() && CheckPins() && CheckPinLength())
            {
                return true;
            }
            return false;
        }
        private bool CheckPins()
        {
            //checks if pins are the same 
            if ((txtBoxPin1.Text == txtBoxPin2.Text))
            {
                return true;
            }
            DisplayErrorMessageBox("Pins do not match");
            ClearPins();
            return false;
        }
        private bool CheckPinLength()
        {
            //check that the pins are 4 numbers long
            if (txtBoxPin1.Text.Length == 4)
            {
                return true;
            }
            DisplayErrorMessageBox("Pins have to be four digits");
            ClearPins();
            return false;
        }
        private bool CheckNames()
        {
            //checks if name boxes are filled in 
            if (txtBoxFirstName.Text != "" && txtBoxLastName.Text != "")
            {
                return true;
            }
            DisplayErrorMessageBox("Text boxes not filled in");
            return false;
        }
        private bool CheckRadButons()
        {
            //checks if at least one radiobutton is selected
            if (radBtnBartender.Checked || radBtnChef.Checked || radBtnWaiter.Checked)
            {
                return true;
            }
            DisplayErrorMessageBox("No occupation selected");
            return false;
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
        private void ClearPins()
        {
            //clears the pin sections for ease of use 
            txtBoxPin1.Text = string.Empty;
            txtBoxPin2.Text = string.Empty;
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
