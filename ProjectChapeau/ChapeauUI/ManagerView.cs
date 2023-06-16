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
    public partial class ManagerView : Form
    {
        private Employee loggedInEmployee;
        public ManagerView(Employee employee)
        {
            InitializeComponent();
            this.loggedInEmployee = employee;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryOverview inventoryOverview = new InventoryOverview(this.loggedInEmployee);
            inventoryOverview.ShowDialog();
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuViewAllItems menu = new MenuViewAllItems(this.loggedInEmployee);
            menu.ShowDialog();
            this.Close();
        }

        private void btnTableOverview_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableView tableView = new TableView(loggedInEmployee);
            tableView.ShowDialog();
            this.Close();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerEmployeeOverview employeeOverview = new ManagerEmployeeOverview(this.loggedInEmployee);
            employeeOverview.ShowDialog();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillView billsView = new BillView(this.loggedInEmployee);
            billsView.ShowDialog();
            this.Close();
        }
    }
}
