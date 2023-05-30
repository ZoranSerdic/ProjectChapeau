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

namespace ChapeauUI
{
    public partial class EditEmployee : NewEmployee
    {
        private Employee updatedEmployee;
        private Employee employee;
        public EditEmployee(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
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
    }
}
