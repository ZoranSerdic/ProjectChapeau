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
    public partial class NewEmployee : Form
    {
        public NewEmployee()
        {
            InitializeComponent();
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {

            }
            else
            {
                //message that the form is incorrect 
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
            else
            {
                return false;
            }
        }
        private bool CheckPins()
        {
            if (numPin1.Value == numPin2.Value)
            {
                return true;
            }

            DisplayMessageBox("error with the pins");
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
    }
}
