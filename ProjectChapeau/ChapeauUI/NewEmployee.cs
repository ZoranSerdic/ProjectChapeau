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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChapeauUI
{
    public partial class NewEmployee : Form
    {
        private Employee newEmployee;
        private EmployeeService service;
        public NewEmployee()
        {
            InitializeComponent();
            service = new EmployeeService();
        }

        protected virtual void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToEmployeeOverview();
        }
        protected virtual void ReturnToEmployeeOverview()
        {
            this.Hide();
            ManagerEmployeeOverview overview = new ManagerEmployeeOverview();
            overview.ShowDialog();
            this.Close();
        }

        protected virtual void btnConfirm_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirmation needed", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    CreateNewEmployee();
                    service.AddEmployee(newEmployee);
                    dialogResult = MessageBox.Show("Action performed successfully", "success");
                    ReturnToEmployeeOverview();
                }
            }
        }
        protected void CreateNewEmployee()
        {
            newEmployee = new Employee();
            newEmployee.FirstName = txtBoxFirstName.Text;
            newEmployee.LastName = txtBoxLastName.Text;
            newEmployee.Pincode = txtBoxPin2.Text;

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
        protected void DisplayMessageBox(string message)
        {
            DialogResult dialogResult = MessageBox.Show(message, "Error");
        }
        protected bool CheckForm()
        {
            if (CheckNames() && CheckRadButons() && CheckPins())
            {
                return true;
            }
            return false;
        }
        protected bool CheckPins()
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
        protected bool CheckPinLength()
        {
            if (txtBoxPin1.Text.Length == 4 && txtBoxPin2.Text.Length == 4)
            {
                return true;
            }
            DisplayMessageBox("pins have to be four digits");
            return false;
        }
        protected bool CheckNames()
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
        protected bool CheckRadButons()
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
        protected void txtBoxPin1_TextChanged(object sender, EventArgs e)
        {
            //try to parse the input, if it is unsuccessful, the inside textbox is cleared
            if (!int.TryParse(txtBoxPin1.Text, out int result))
            {
                txtBoxPin1.Text = string.Empty;
            }
        }
        protected void txtBoxPin2_TextChanged(object sender, EventArgs e)
        {
            //try to parse the input, if it is unsuccessful, the inside textbox is cleared 
            if (!int.TryParse(txtBoxPin1.Text, out int result))
            {
                txtBoxPin2.Text = string.Empty;
            }
        }
    }
}
